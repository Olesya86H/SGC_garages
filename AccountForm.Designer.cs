
namespace SGC_garages
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
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
            AccGrd = new System.Windows.Forms.DataGridView();
            this.saccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sAccDS = new SGC_garages.sAccDS();
            s_accountTableAdapter = new SGC_garages.sAccDSTableAdapters.s_accountTableAdapter();
            this.nameaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_account_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccFareValue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idaccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(AccGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sAccDS)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // AccGrd
            // 
            AccGrd.AllowUserToAddRows = false;
            AccGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            AccGrd.AutoGenerateColumns = false;
            AccGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameaccountDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.name_account_type,
            this.AccFareValue,
            this.idaccountDataGridViewTextBoxColumn});
            AccGrd.DataSource = this.saccountBindingSource;
            AccGrd.Location = new System.Drawing.Point(12, 27);
            AccGrd.Name = "AccGrd";
            AccGrd.Size = new System.Drawing.Size(776, 411);
            AccGrd.TabIndex = 7;
            AccGrd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(AccGrd_CellBeginEdit);
            AccGrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(AccGrd_CellClick);
            AccGrd.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(AccGrd_CellMouseDoubleClick);
            AccGrd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(AccGrd_RowEnter);
            AccGrd.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(AccGrd_RowLeave);
            AccGrd.Leave += new System.EventHandler(AccGrd_Leave);
            // 
            // saccountBindingSource
            // 
            this.saccountBindingSource.DataMember = "s_account";
            this.saccountBindingSource.DataSource = sAccDS;
            // 
            // sAccDS
            // 
            sAccDS.DataSetName = "sAccDS";
            sAccDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_accountTableAdapter
            // 
            s_accountTableAdapter.ClearBeforeFill = true;
            // 
            // nameaccountDataGridViewTextBoxColumn
            // 
            this.nameaccountDataGridViewTextBoxColumn.DataPropertyName = "name_account";
            this.nameaccountDataGridViewTextBoxColumn.HeaderText = "Наименование статьи";
            this.nameaccountDataGridViewTextBoxColumn.Name = "nameaccountDataGridViewTextBoxColumn";
            this.nameaccountDataGridViewTextBoxColumn.Width = 200;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечания";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 200;
            // 
            // name_account_type
            // 
            this.name_account_type.DataPropertyName = "name_account_type";
            this.name_account_type.HeaderText = "Тип статьи";
            this.name_account_type.Name = "name_account_type";
            // 
            // AccFareValue
            // 
            this.AccFareValue.HeaderText = "Тарифы статьи";
            this.AccFareValue.Name = "AccFareValue";
            this.AccFareValue.Text = "...";
            this.AccFareValue.UseColumnTextForButtonValue = true;
            this.AccFareValue.Width = 50;
            // 
            // idaccountDataGridViewTextBoxColumn
            // 
            this.idaccountDataGridViewTextBoxColumn.DataPropertyName = "id_account";
            this.idaccountDataGridViewTextBoxColumn.HeaderText = "id_account";
            this.idaccountDataGridViewTextBoxColumn.Name = "idaccountDataGridViewTextBoxColumn";
            this.idaccountDataGridViewTextBoxColumn.Visible = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(AccGrd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статьи";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(AccGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sAccDS)).EndInit();
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
        private System.Windows.Forms.BindingSource saccountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameaccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_account_type;
        private System.Windows.Forms.DataGridViewButtonColumn AccFareValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idaccountDataGridViewTextBoxColumn;
        public static System.Windows.Forms.DataGridView AccGrd;
        public static sAccDS sAccDS;
        public static sAccDSTableAdapters.s_accountTableAdapter s_accountTableAdapter;
    }
}