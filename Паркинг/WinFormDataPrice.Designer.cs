﻿namespace Паркинг
{
    partial class WinFormDataPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormDataPrice));
            this.parkingDataSet = new Паркинг.parkingDataSet();
            this.тарифыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тарифыTableAdapter = new Паркинг.parkingDataSetTableAdapters.тарифыTableAdapter();
            this.tableAdapterManager = new Паркинг.parkingDataSetTableAdapters.TableAdapterManager();
            this.тарифыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.тарифыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.тарифыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingNavigator)).BeginInit();
            this.тарифыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "parkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тарифыBindingSource
            // 
            this.тарифыBindingSource.DataMember = "тарифы";
            this.тарифыBindingSource.DataSource = this.parkingDataSet;
            // 
            // тарифыTableAdapter
            // 
            this.тарифыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Паркинг.parkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.автоTableAdapter = null;
            this.tableAdapterManager.группыTableAdapter = null;
            this.tableAdapterManager.историяпроездовTableAdapter = null;
            this.tableAdapterManager.историятранзакцийTableAdapter = null;
            this.tableAdapterManager.клиентыTableAdapter = null;
            this.tableAdapterManager.контактыклиентовTableAdapter = null;
            this.tableAdapterManager.маркиавтоTableAdapter = null;
            this.tableAdapterManager.моделиавтоTableAdapter = null;
            this.tableAdapterManager.настройкиTableAdapter = null;
            this.tableAdapterManager.парковкиTableAdapter = null;
            this.tableAdapterManager.пользователиTableAdapter = null;
            this.tableAdapterManager.тарифыTableAdapter = this.тарифыTableAdapter;
            // 
            // тарифыBindingNavigator
            // 
            this.тарифыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тарифыBindingNavigator.BindingSource = this.тарифыBindingSource;
            this.тарифыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тарифыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тарифыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.тарифыBindingNavigatorSaveItem});
            this.тарифыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тарифыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тарифыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тарифыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тарифыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тарифыBindingNavigator.Name = "тарифыBindingNavigator";
            this.тарифыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тарифыBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.тарифыBindingNavigator.TabIndex = 0;
            this.тарифыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // тарифыBindingNavigatorSaveItem
            // 
            this.тарифыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тарифыBindingNavigatorSaveItem.Enabled = false;
            this.тарифыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тарифыBindingNavigatorSaveItem.Image")));
            this.тарифыBindingNavigatorSaveItem.Name = "тарифыBindingNavigatorSaveItem";
            this.тарифыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.тарифыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тарифыBindingNavigatorSaveItem.Click += new System.EventHandler(this.тарифыBindingNavigatorSaveItem_Click);
            // 
            // тарифыDataGridView
            // 
            this.тарифыDataGridView.AllowUserToAddRows = false;
            this.тарифыDataGridView.AllowUserToDeleteRows = false;
            this.тарифыDataGridView.AutoGenerateColumns = false;
            this.тарифыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тарифыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.тарифыDataGridView.DataSource = this.тарифыBindingSource;
            this.тарифыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.тарифыDataGridView.Location = new System.Drawing.Point(0, 25);
            this.тарифыDataGridView.Name = "тарифыDataGridView";
            this.тарифыDataGridView.ReadOnly = true;
            this.тарифыDataGridView.Size = new System.Drawing.Size(800, 425);
            this.тарифыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "бесплатныеМинуты";
            this.dataGridViewTextBoxColumn3.HeaderText = "Бесплатные минуты";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ценаРубВЧас";
            this.dataGridViewTextBoxColumn4.HeaderText = "Цена Руб/Час";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // WinFormDataPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.тарифыDataGridView);
            this.Controls.Add(this.тарифыBindingNavigator);
            this.Name = "WinFormDataPrice";
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.WinFormDataPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingNavigator)).EndInit();
            this.тарифыBindingNavigator.ResumeLayout(false);
            this.тарифыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private parkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource тарифыBindingSource;
        private parkingDataSetTableAdapters.тарифыTableAdapter тарифыTableAdapter;
        private parkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тарифыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton тарифыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView тарифыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}