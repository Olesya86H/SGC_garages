
namespace SGC_garages
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            tLoggrd = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            tLogDS = new SGC_garages.tLogDS();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            t_logTableAdapter = new SGC_garages.tLogDSTableAdapters.t_logTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(tLoggrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tLogDS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLoggrd
            // 
            tLoggrd.AllowUserToAddRows = false;
            tLoggrd.AllowUserToDeleteRows = false;
            tLoggrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tLoggrd.AutoGenerateColumns = false;
            tLoggrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tLoggrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio,
            this.login,
            this.dateactDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.idlogDataGridViewTextBoxColumn,
            this.id_person,
            this.iduserDataGridViewTextBoxColumn});
            tLoggrd.DataSource = this.tlogBindingSource;
            tLoggrd.Location = new System.Drawing.Point(12, 32);
            tLoggrd.Name = "tLoggrd";
            tLoggrd.Size = new System.Drawing.Size(848, 406);
            tLoggrd.TabIndex = 0;
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
            // dateactDataGridViewTextBoxColumn
            // 
            this.dateactDataGridViewTextBoxColumn.DataPropertyName = "date_act";
            this.dateactDataGridViewTextBoxColumn.HeaderText = "Дата действия";
            this.dateactDataGridViewTextBoxColumn.Name = "dateactDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Действие";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // idlogDataGridViewTextBoxColumn
            // 
            this.idlogDataGridViewTextBoxColumn.DataPropertyName = "id_log";
            this.idlogDataGridViewTextBoxColumn.HeaderText = "id_log";
            this.idlogDataGridViewTextBoxColumn.Name = "idlogDataGridViewTextBoxColumn";
            // 
            // id_person
            // 
            this.id_person.DataPropertyName = "id_person";
            this.id_person.HeaderText = "id_person";
            this.id_person.Name = "id_person";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            // 
            // tlogBindingSource
            // 
            this.tlogBindingSource.DataMember = "t_log";
            this.tlogBindingSource.DataSource = tLogDS;
            // 
            // tLogDS
            // 
            tLogDS.DataSetName = "tLogDS";
            tLogDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.обновитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.поToolStripMenuItem,
            this.закрытьToolStripMenuItem1});
            this.закрытьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.display;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.закрытьToolStripMenuItem.Text = "Действия";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.find;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Поиск";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.ПоискToolStripMenuItem_Click);
            // 
            // поToolStripMenuItem
            // 
            this.поToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.update;
            this.поToolStripMenuItem.Name = "поToolStripMenuItem";
            this.поToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.поToolStripMenuItem.Text = "Обновить";
            this.поToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.find;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.ПоискToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem2
            // 
            this.закрытьToolStripMenuItem2.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem2.Name = "закрытьToolStripMenuItem2";
            this.закрытьToolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.закрытьToolStripMenuItem2.Text = "Закрыть";
            this.закрытьToolStripMenuItem2.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // t_logTableAdapter
            // 
            t_logTableAdapter.ClearBeforeFill = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(tLoggrd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История действий";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(tLoggrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tLogDS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem2;
        private System.Windows.Forms.BindingSource tlogBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        public static System.Windows.Forms.DataGridView tLoggrd;
        public static tLogDS tLogDS;
        public static tLogDSTableAdapters.t_logTableAdapter t_logTableAdapter;
    }
}