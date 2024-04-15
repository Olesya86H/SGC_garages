
namespace SGC_garages
{
    partial class UserCab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCab));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.написатьВПоддержкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.написатьВПоддержкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FIOlbl = new System.Windows.Forms.Label();
            this.AddrLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.note1Lbl = new System.Windows.Forms.Label();
            this.note2Lbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.dateRegLbl = new System.Windows.Forms.Label();
            this.FIOtxtbx = new System.Windows.Forms.TextBox();
            this.Phonetxtbx = new System.Windows.Forms.TextBox();
            this.Addrtxtbx = new System.Windows.Forms.TextBox();
            this.logintxtbx = new System.Windows.Forms.TextBox();
            this.dateRegtxtbx = new System.Windows.Forms.TextBox();
            this.note1txtbx = new System.Windows.Forms.TextBox();
            this.note2txtbx = new System.Windows.Forms.TextBox();
            this.tLoggrd = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlogUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLogUserDS = new SGC_garages.tLogUserDS();
            this.tloglbl = new System.Windows.Forms.Label();
            this.t_logUserTableAdapter = new SGC_garages.tLogUserDSTableAdapters.t_logTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLoggrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlogUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLogUserDS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.написатьВПоддержкуToolStripMenuItem1,
            this.обновитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem1,
            this.написатьВПоддержкуToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.обновитьToolStripMenuItem});
            this.действияToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.display;
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.options;
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.save;
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // написатьВПоддержкуToolStripMenuItem
            // 
            this.написатьВПоддержкуToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.envelope_pencil;
            this.написатьВПоддержкуToolStripMenuItem.Name = "написатьВПоддержкуToolStripMenuItem";
            this.написатьВПоддержкуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.написатьВПоддержкуToolStripMenuItem.Text = "Написать в поддержку";
            this.написатьВПоддержкуToolStripMenuItem.Click += new System.EventHandler(this.написатьВПоддержкуToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.options;
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.save;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // написатьВПоддержкуToolStripMenuItem1
            // 
            this.написатьВПоддержкуToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.envelope_pencil;
            this.написатьВПоддержкуToolStripMenuItem1.Name = "написатьВПоддержкуToolStripMenuItem1";
            this.написатьВПоддержкуToolStripMenuItem1.Size = new System.Drawing.Size(159, 20);
            this.написатьВПоддержкуToolStripMenuItem1.Text = "Написать в поддержку";
            this.написатьВПоддержкуToolStripMenuItem1.Click += new System.EventHandler(this.написатьВПоддержкуToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // FIOlbl
            // 
            this.FIOlbl.AutoSize = true;
            this.FIOlbl.Location = new System.Drawing.Point(30, 51);
            this.FIOlbl.Name = "FIOlbl";
            this.FIOlbl.Size = new System.Drawing.Size(37, 13);
            this.FIOlbl.TabIndex = 1;
            this.FIOlbl.Text = "ФИО:";
            // 
            // AddrLbl
            // 
            this.AddrLbl.AutoSize = true;
            this.AddrLbl.Location = new System.Drawing.Point(26, 123);
            this.AddrLbl.Name = "AddrLbl";
            this.AddrLbl.Size = new System.Drawing.Size(41, 13);
            this.AddrLbl.TabIndex = 2;
            this.AddrLbl.Text = "Адрес:";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(12, 84);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(55, 13);
            this.PhoneLbl.TabIndex = 3;
            this.PhoneLbl.Text = "Телефон:";
            // 
            // note1Lbl
            // 
            this.note1Lbl.AutoSize = true;
            this.note1Lbl.Location = new System.Drawing.Point(23, 170);
            this.note1Lbl.Name = "note1Lbl";
            this.note1Lbl.Size = new System.Drawing.Size(82, 13);
            this.note1Lbl.TabIndex = 4;
            this.note1Lbl.Text = "Примечание 1:";
            // 
            // note2Lbl
            // 
            this.note2Lbl.AutoSize = true;
            this.note2Lbl.Location = new System.Drawing.Point(23, 205);
            this.note2Lbl.Name = "note2Lbl";
            this.note2Lbl.Size = new System.Drawing.Size(82, 13);
            this.note2Lbl.TabIndex = 5;
            this.note2Lbl.Text = "Примечание 2:";
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(397, 54);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(41, 13);
            this.loginLbl.TabIndex = 6;
            this.loginLbl.Text = "Логин:";
            // 
            // dateRegLbl
            // 
            this.dateRegLbl.AutoSize = true;
            this.dateRegLbl.Location = new System.Drawing.Point(335, 92);
            this.dateRegLbl.Name = "dateRegLbl";
            this.dateRegLbl.Size = new System.Drawing.Size(103, 13);
            this.dateRegLbl.TabIndex = 7;
            this.dateRegLbl.Text = "Дата регистрации:";
            // 
            // FIOtxtbx
            // 
            this.FIOtxtbx.Location = new System.Drawing.Point(97, 51);
            this.FIOtxtbx.Name = "FIOtxtbx";
            this.FIOtxtbx.Size = new System.Drawing.Size(200, 20);
            this.FIOtxtbx.TabIndex = 8;
            // 
            // Phonetxtbx
            // 
            this.Phonetxtbx.Location = new System.Drawing.Point(97, 84);
            this.Phonetxtbx.Name = "Phonetxtbx";
            this.Phonetxtbx.Size = new System.Drawing.Size(200, 20);
            this.Phonetxtbx.TabIndex = 9;
            // 
            // Addrtxtbx
            // 
            this.Addrtxtbx.Location = new System.Drawing.Point(97, 120);
            this.Addrtxtbx.Name = "Addrtxtbx";
            this.Addrtxtbx.Size = new System.Drawing.Size(200, 20);
            this.Addrtxtbx.TabIndex = 10;
            // 
            // logintxtbx
            // 
            this.logintxtbx.Enabled = false;
            this.logintxtbx.Location = new System.Drawing.Point(444, 51);
            this.logintxtbx.Name = "logintxtbx";
            this.logintxtbx.Size = new System.Drawing.Size(200, 20);
            this.logintxtbx.TabIndex = 11;
            // 
            // dateRegtxtbx
            // 
            this.dateRegtxtbx.Enabled = false;
            this.dateRegtxtbx.Location = new System.Drawing.Point(444, 89);
            this.dateRegtxtbx.Name = "dateRegtxtbx";
            this.dateRegtxtbx.Size = new System.Drawing.Size(200, 20);
            this.dateRegtxtbx.TabIndex = 12;
            // 
            // note1txtbx
            // 
            this.note1txtbx.Location = new System.Drawing.Point(111, 167);
            this.note1txtbx.Name = "note1txtbx";
            this.note1txtbx.Size = new System.Drawing.Size(533, 20);
            this.note1txtbx.TabIndex = 13;
            // 
            // note2txtbx
            // 
            this.note2txtbx.Location = new System.Drawing.Point(111, 202);
            this.note2txtbx.Name = "note2txtbx";
            this.note2txtbx.Size = new System.Drawing.Size(533, 20);
            this.note2txtbx.TabIndex = 14;
            // 
            // tLoggrd
            // 
            this.tLoggrd.AllowUserToAddRows = false;
            this.tLoggrd.AllowUserToDeleteRows = false;
            this.tLoggrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLoggrd.AutoGenerateColumns = false;
            this.tLoggrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tLoggrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.login,
            this.actionDataGridViewTextBoxColumn,
            this.date_act,
            this.phone_number,
            this.noteDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.idlogDataGridViewTextBoxColumn});
            this.tLoggrd.DataSource = this.tlogUserBindingSource;
            this.tLoggrd.Location = new System.Drawing.Point(15, 269);
            this.tLoggrd.Name = "tLoggrd";
            this.tLoggrd.Size = new System.Drawing.Size(780, 250);
            this.tLoggrd.TabIndex = 15;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Действие";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // date_act
            // 
            this.date_act.DataPropertyName = "date_act";
            this.date_act.HeaderText = "Дата действия";
            this.date_act.Name = "date_act";
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "Телефон";
            this.phone_number.Name = "phone_number";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание к логу";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.Width = 50;
            // 
            // idlogDataGridViewTextBoxColumn
            // 
            this.idlogDataGridViewTextBoxColumn.DataPropertyName = "id_log";
            this.idlogDataGridViewTextBoxColumn.HeaderText = "id_log";
            this.idlogDataGridViewTextBoxColumn.Name = "idlogDataGridViewTextBoxColumn";
            this.idlogDataGridViewTextBoxColumn.Width = 50;
            // 
            // tlogUserBindingSource
            // 
            this.tlogUserBindingSource.DataMember = "t_log";
            this.tlogUserBindingSource.DataSource = this.tLogUserDS;
            // 
            // tLogUserDS
            // 
            this.tLogUserDS.DataSetName = "tLogUserDS";
            this.tLogUserDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tloglbl
            // 
            this.tloglbl.AutoSize = true;
            this.tloglbl.Location = new System.Drawing.Point(28, 239);
            this.tloglbl.Name = "tloglbl";
            this.tloglbl.Size = new System.Drawing.Size(103, 13);
            this.tloglbl.TabIndex = 16;
            this.tloglbl.Text = "История действий:";
            // 
            // t_logUserTableAdapter
            // 
            this.t_logUserTableAdapter.ClearBeforeFill = true;
            // 
            // UserCab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.tloglbl);
            this.Controls.Add(this.tLoggrd);
            this.Controls.Add(this.note2txtbx);
            this.Controls.Add(this.note1txtbx);
            this.Controls.Add(this.dateRegtxtbx);
            this.Controls.Add(this.logintxtbx);
            this.Controls.Add(this.Addrtxtbx);
            this.Controls.Add(this.Phonetxtbx);
            this.Controls.Add(this.FIOtxtbx);
            this.Controls.Add(this.dateRegLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.note2Lbl);
            this.Controls.Add(this.note1Lbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.AddrLbl);
            this.Controls.Add(this.FIOlbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserCab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.UserCab_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLoggrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlogUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLogUserDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem написатьВПоддержкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem написатьВПоддержкуToolStripMenuItem1;
        private System.Windows.Forms.Label FIOlbl;
        private System.Windows.Forms.Label AddrLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label note1Lbl;
        private System.Windows.Forms.Label note2Lbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label dateRegLbl;
        private System.Windows.Forms.TextBox FIOtxtbx;
        private System.Windows.Forms.TextBox Phonetxtbx;
        private System.Windows.Forms.TextBox Addrtxtbx;
        private System.Windows.Forms.TextBox logintxtbx;
        private System.Windows.Forms.TextBox dateRegtxtbx;
        private System.Windows.Forms.TextBox note1txtbx;
        private System.Windows.Forms.TextBox note2txtbx;
        private System.Windows.Forms.DataGridView tLoggrd;
        private System.Windows.Forms.Label tloglbl;
        private tLogUserDS tLogUserDS;
        private System.Windows.Forms.BindingSource tlogUserBindingSource;
        private tLogUserDSTableAdapters.t_logTableAdapter t_logUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_act;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
    }
}