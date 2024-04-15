
namespace SGC_garages
{
    partial class AccValueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccValueForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            FareGrd = new System.Windows.Forms.DataGridView();
            this.taccvalueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tAccValueDS = new SGC_garages.tAccValueDS();
            t_acc_valueTableAdapter = new SGC_garages.tAccValueDSTableAdapters.t_acc_valueTableAdapter();
            this.name_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valuefareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_si = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_garage_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idaccvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(FareGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taccvalueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tAccValueDS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.addToolStripMenuItem1,
            this.удаToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.обновитьToolStripMenuItem,
            this.закрытьToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.обновитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.действияToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.display;
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.plus;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.minus;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.save;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.find;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Поиск";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.plus;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.addToolStripMenuItem1.Text = "Добавить";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удаToolStripMenuItem
            // 
            this.удаToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.minus;
            this.удаToolStripMenuItem.Name = "удаToolStripMenuItem";
            this.удаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.удаToolStripMenuItem.Text = "Удалить";
            this.удаToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.save;
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::SGC_garages.Properties.Resources.find;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem2.Text = "Поиск";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem2
            // 
            this.закрытьToolStripMenuItem2.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem2.Name = "закрытьToolStripMenuItem2";
            this.закрытьToolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.закрытьToolStripMenuItem2.Text = "Закрыть";
            this.закрытьToolStripMenuItem2.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // FareGrd
            // 
            FareGrd.AllowUserToAddRows = false;
            FareGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            FareGrd.AutoGenerateColumns = false;
            FareGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FareGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_account,
            this.valuefareDataGridViewTextBoxColumn,
            this.name_si,
            this.name_garage_type,
            this.dateonDataGridViewTextBoxColumn,
            this.dateoffDataGridViewTextBoxColumn,
            this.idaccvalueDataGridViewTextBoxColumn});
            FareGrd.DataSource = this.taccvalueBindingSource;
            FareGrd.Location = new System.Drawing.Point(12, 27);
            FareGrd.Name = "FareGrd";
            FareGrd.Size = new System.Drawing.Size(748, 330);
            FareGrd.TabIndex = 7;
            FareGrd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(FareGrd_CellBeginEdit);
            FareGrd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(FareGrd_RowEnter);
            FareGrd.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(FareGrd_RowLeave);
            FareGrd.Leave += new System.EventHandler(FareGrd_Leave);
            // 
            // taccvalueBindingSource
            // 
            this.taccvalueBindingSource.DataMember = "t_acc_value";
            this.taccvalueBindingSource.DataSource = tAccValueDS;
            // 
            // tAccValueDS
            // 
            tAccValueDS.DataSetName = "tAccValueDS";
            tAccValueDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_acc_valueTableAdapter
            // 
            t_acc_valueTableAdapter.ClearBeforeFill = true;
            // 
            // name_account
            // 
            this.name_account.DataPropertyName = "name_account";
            this.name_account.HeaderText = "Наименование статьи";
            this.name_account.Name = "name_account";
            // 
            // valuefareDataGridViewTextBoxColumn
            // 
            this.valuefareDataGridViewTextBoxColumn.DataPropertyName = "value_fare";
            this.valuefareDataGridViewTextBoxColumn.HeaderText = "Значение тарифа";
            this.valuefareDataGridViewTextBoxColumn.Name = "valuefareDataGridViewTextBoxColumn";
            // 
            // name_si
            // 
            this.name_si.DataPropertyName = "name_si";
            this.name_si.HeaderText = "Единица измерения";
            this.name_si.Name = "name_si";
            // 
            // name_garage_type
            // 
            this.name_garage_type.DataPropertyName = "name_garage_type";
            this.name_garage_type.HeaderText = "Тип гаража";
            this.name_garage_type.Name = "name_garage_type";
            // 
            // dateonDataGridViewTextBoxColumn
            // 
            this.dateonDataGridViewTextBoxColumn.DataPropertyName = "date_on";
            this.dateonDataGridViewTextBoxColumn.HeaderText = "Дата начала действия тарифа";
            this.dateonDataGridViewTextBoxColumn.Name = "dateonDataGridViewTextBoxColumn";
            // 
            // dateoffDataGridViewTextBoxColumn
            // 
            this.dateoffDataGridViewTextBoxColumn.DataPropertyName = "date_off";
            this.dateoffDataGridViewTextBoxColumn.HeaderText = "Дата окончания действия тарифа";
            this.dateoffDataGridViewTextBoxColumn.Name = "dateoffDataGridViewTextBoxColumn";
            // 
            // idaccvalueDataGridViewTextBoxColumn
            // 
            this.idaccvalueDataGridViewTextBoxColumn.DataPropertyName = "id_acc_value";
            this.idaccvalueDataGridViewTextBoxColumn.HeaderText = "id_acc_value";
            this.idaccvalueDataGridViewTextBoxColumn.Name = "idaccvalueDataGridViewTextBoxColumn";
            this.idaccvalueDataGridViewTextBoxColumn.Visible = false;
            // 
            // AccValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 369);
            this.Controls.Add(FareGrd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифные ставки статьи";
            this.Load += new System.EventHandler(this.AccValueForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(FareGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taccvalueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tAccValueDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem2;
        public static System.Windows.Forms.DataGridView FareGrd;
        public static tAccValueDS tAccValueDS;
        private System.Windows.Forms.BindingSource taccvalueBindingSource;
        public static tAccValueDSTableAdapters.t_acc_valueTableAdapter t_acc_valueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn valuefareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_si;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_garage_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaccvalueDataGridViewTextBoxColumn;
    }
}