
namespace SGC_garages
{
    partial class UsersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListForm));
            FIOUsersgrd = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            s_UsersDS = new SGC_garages.s_UsersDS();
            s_UsersTableAdapter = new SGC_garages.s_UsersDSTableAdapters.s_personsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(FIOUsersgrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(s_UsersDS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FIOUsersgrd
            // 
            FIOUsersgrd.AllowUserToAddRows = false;
            FIOUsersgrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            FIOUsersgrd.AutoGenerateColumns = false;
            FIOUsersgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FIOUsersgrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.isuserDataGridViewTextBoxColumn,
            this.isownerDataGridViewTextBoxColumn,
            this.ispayerDataGridViewTextBoxColumn,
            this.idpersonDataGridViewTextBoxColumn});
            FIOUsersgrd.DataSource = this.sUsersBindingSource;
            FIOUsersgrd.Location = new System.Drawing.Point(12, 27);
            FIOUsersgrd.Name = "FIOUsersgrd";
            FIOUsersgrd.Size = new System.Drawing.Size(774, 411);
            FIOUsersgrd.TabIndex = 0;
            FIOUsersgrd.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(FIOUsersgrd_CellBeginEdit);
            FIOUsersgrd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(FIOUsersgrd_RowEnter);
            FIOUsersgrd.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(FIOUsersgrd_RowLeave);
            FIOUsersgrd.Leave += new System.EventHandler(FIOUsersgrd_Leave);
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 200;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечания";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // isuserDataGridViewTextBoxColumn
            // 
            this.isuserDataGridViewTextBoxColumn.DataPropertyName = "is_user";
            this.isuserDataGridViewTextBoxColumn.HeaderText = "is_user";
            this.isuserDataGridViewTextBoxColumn.Name = "isuserDataGridViewTextBoxColumn";
            this.isuserDataGridViewTextBoxColumn.Visible = false;
            // 
            // isownerDataGridViewTextBoxColumn
            // 
            this.isownerDataGridViewTextBoxColumn.DataPropertyName = "is_owner";
            this.isownerDataGridViewTextBoxColumn.HeaderText = "is_owner";
            this.isownerDataGridViewTextBoxColumn.Name = "isownerDataGridViewTextBoxColumn";
            this.isownerDataGridViewTextBoxColumn.Visible = false;
            // 
            // ispayerDataGridViewTextBoxColumn
            // 
            this.ispayerDataGridViewTextBoxColumn.DataPropertyName = "is_payer";
            this.ispayerDataGridViewTextBoxColumn.HeaderText = "is_payer";
            this.ispayerDataGridViewTextBoxColumn.Name = "ispayerDataGridViewTextBoxColumn";
            this.ispayerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "id_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "id_person";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUsersBindingSource
            // 
            this.sUsersBindingSource.DataMember = "s_persons";
            this.sUsersBindingSource.DataSource = s_UsersDS;
            // 
            // s_UsersDS
            // 
            s_UsersDS.DataSetName = "s_UsersDS";
            s_UsersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_UsersTableAdapter
            // 
            s_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.удаToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.обновитьToolStripMenuItem,
            this.закрытьToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
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
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.plus;
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.закрытьToolStripMenuItem1.Text = "Добавить";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
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
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(FIOUsersgrd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи системы";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(FIOUsersgrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(s_UsersDS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sUsersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ispayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem2;
        public static System.Windows.Forms.DataGridView FIOUsersgrd;
        public static s_UsersDS s_UsersDS;
        public static s_UsersDSTableAdapters.s_personsTableAdapter s_UsersTableAdapter;
    }
}