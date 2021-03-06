﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Паркинг
{
    public partial class WinFormDataHistoryTransit : Form
    {
        public WinFormDataHistoryTransit()
        {
            InitializeComponent();
        }        

        private void WinFormHistoryTransit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.парковки". При необходимости она может быть перемещена или удалена.
            this.парковкиTableAdapter.Fill(this.parkingDataSet.парковки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.parkingDataSet.авто);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.историяпроездов". При необходимости она может быть перемещена или удалена.
            this.историяпроездовTableAdapter.Fill(this.parkingDataSet.историяпроездов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.parkingDataSet.авто);            
        }

        private void историяпроездовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.историяпроездовBindingSource.EndEdit();
            this.tableAdapterManager.историяпроездовTableAdapter.Update(this.parkingDataSet.историяпроездов);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            историяпроездовBindingSource.Filter = string.Format(
                "(въехалДата >= '{0}' and въехалДата <= '{1}') or (выехалДата >= '{2}' and выехалДата <= '{3}')",
                dateTimePicker1.Value.ToString(),
                dateTimePicker2.Value.ToString(),
                dateTimePicker1.Value.ToString(),
                dateTimePicker2.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            историяпроездовBindingSource.Filter = "";
        }

        private void историяпроездовDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 3 || e.ColumnIndex == 5) && историяпроездовDataGridView.CurrentRow.Cells[e.ColumnIndex + 1].Value.ToString() != "")
            {
                byte [] arr = (byte[])историяпроездовDataGridView.CurrentRow.Cells[e.ColumnIndex + 1].Value;
                System.IO.MemoryStream stream = new System.IO.MemoryStream(arr);
                stream.Position = 0;
                if (stream.Length == 0)
                {
                    MessageBox.Show("Изображение отсутствует.", "Ошибка");
                    return;
                }

                Bitmap bmp = new Bitmap(stream);
                (new WinFormImageViewer(bmp)).Show();                
            }           
        }
    }
}
