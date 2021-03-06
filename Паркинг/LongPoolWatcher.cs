﻿using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

using VkNet;
using VkNet.Model;
using VkNet.Exception;
using VkNet.Model.RequestParams;
using VkNet.Enums.Filters;

namespace Паркинг
{
    public delegate void MessagesRecievedDelegate(VkApi owner, ReadOnlyCollection<Message> messages);

    public class LongPoolWatcher
    {
        private VkApi vkAcc;

        private ulong? Ts { get; set; }
        private ulong? Pts { get; set; }

        public bool Active { get; private set; }

        #region Управление слежением
        private Timer _watchTimer;

        private byte MaxSleepSteps = 3;
        private int SteepSleepTime = 333;
        private byte _currentSleepSteps = 1;
        #endregion

        public event MessagesRecievedDelegate NewMessages;

        public LongPoolWatcher(VkApi api)
        {
            vkAcc = api;
        }

        private LongPollServerResponse GetLongPoolServer(ulong? lastPts = null)
        {
            var response = vkAcc.Messages.GetLongPollServer(false, 3);

            Ts = response.Ts;
            Pts = Pts == null ? response.Pts : lastPts;

            return response;
        }
        private Task<LongPollServerResponse> GetLongPoolServerAsync(ulong? lastPts = null)
        {
            return Task.Run(() => { return GetLongPoolServer(lastPts); });
        }

        private LongPollHistoryResponse GetLongPoolHistory()
        {
            if (!Ts.HasValue)
                GetLongPoolServer(null);
            MessagesGetLongPollHistoryParams rp = new MessagesGetLongPollHistoryParams();
            rp.Ts = Ts.Value;
            rp.Pts = Pts;

            int c = 0;
            LongPollHistoryResponse history = null;
            string errorLog = "";

            while (c < 5 && history == null)
            {
                c++;
                try
                {
                    history = vkAcc.Messages.GetLongPollHistory(rp);
                }
                catch (TooManyRequestsException)
                {
                    Thread.Sleep(150);
                    c--;
                }
                catch (Exception ex)
                {
                    DataBaseCenter dataBase = DataBaseCenter.Create();
                    System.Data.DataTable dataTable = dataBase.GetDataTable("SELECT значение FROM Настройки WHERE название='vk'");                                          
                    string[] str = dataTable.Rows[0].ItemArray[0].ToString().Split("|".ToCharArray());
                    ulong appId;
                    ulong.TryParse(str[0], out appId);
                    vkAcc.Authorize(new ApiAuthParams
                    {
                        ApplicationId = appId,
                        Login = str[1],
                        Password = str[2],
                        AccessToken = str[3],
                        Settings = Settings.All
                    });
                    try { GetLongPoolServer(null); } catch { };
                }
            }

            if (history != null)
            {
                Pts = history.NewPts;
                foreach (var m in history.Messages)
                    m.FromId = m.Type == VkNet.Enums.MessageType.Sended ? vkAcc.UserId : m.UserId;
            }            

            return history;
        }
        private Task<LongPollHistoryResponse> GetLongPoolHistoryAsync()
        {
            return Task.Run(() => { return GetLongPoolHistory(); });
        }

        private async void _watchAsync(object state)
        {
            var history = await GetLongPoolHistoryAsync();
            if (history != null && history.Messages.Count > 0)
            {
                _currentSleepSteps = 1;
                if (NewMessages != null)
                    NewMessages(vkAcc, history.Messages);
            }
            else if (_currentSleepSteps < MaxSleepSteps)
                _currentSleepSteps++;

            _watchTimer.Change(_currentSleepSteps * SteepSleepTime, Timeout.Infinite);
        }

        public async void StartAsync(ulong? lastTs = null, ulong? lastPts = null)
        {
            if (Active)
                throw new NotImplementedException("Messages already watching");

            Active = true;
            await GetLongPoolServerAsync(lastPts);

            _watchTimer = new Timer(new TimerCallback(_watchAsync), null, 0, Timeout.Infinite);
        }
        public void Stop()
        {
            if (_watchTimer != null)
                _watchTimer.Dispose();
            Active = false;
            _watchTimer = null;
        }
    }
}
