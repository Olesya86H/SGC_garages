
namespace SGC_garages
{
    partial class NewGarageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGarageForm));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddOwnerBtn = new System.Windows.Forms.Button();
            this.OwnerLbl = new System.Windows.Forms.Label();
            this.TypeGarLbl = new System.Windows.Forms.Label();
            this.NumGarLbl = new System.Windows.Forms.Label();
            this.NumGartxtbx = new System.Windows.Forms.TextBox();
            this.TypeGarTxtbx = new System.Windows.Forms.ComboBox();
            this.sgaragetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGarTypeDS = new SGC_garages.sGarTypeDS();
            Ownercmbbx = new System.Windows.Forms.ComboBox();
            this.spersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sPer_NewGarDS = new SGC_garages.sPer_NewGarDS();
            this.s_garage_typesTableAdapter = new SGC_garages.sGarTypeDSTableAdapters.s_garage_typesTableAdapter();
            s_personsTableAdapter = new SGC_garages.sPer_NewGarDSTableAdapters.s_personsTableAdapter();
            this.AddrLbl = new System.Windows.Forms.Label();
            this.Addrrtxtbx = new System.Windows.Forms.RichTextBox();
            this.lbltxtbx = new System.Windows.Forms.Label();
            this.notetxtbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sPer_NewGarDS)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(444, 163);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(123, 28);
            this.CloseBtn.TabIndex = 30;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(304, 163);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(125, 28);
            this.ClearBtn.TabIndex = 29;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::SGC_garages.Properties.Resources.plus;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(166, 163);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(125, 28);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "Записать";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddOwnerBtn
            // 
            this.AddOwnerBtn.Location = new System.Drawing.Point(349, 109);
            this.AddOwnerBtn.Name = "AddOwnerBtn";
            this.AddOwnerBtn.Size = new System.Drawing.Size(29, 23);
            this.AddOwnerBtn.TabIndex = 26;
            this.AddOwnerBtn.Text = "...";
            this.AddOwnerBtn.UseVisualStyleBackColor = true;
            this.AddOwnerBtn.Click += new System.EventHandler(this.AddOwnerBtn_Click);
            // 
            // OwnerLbl
            // 
            this.OwnerLbl.AutoSize = true;
            this.OwnerLbl.Location = new System.Drawing.Point(16, 114);
            this.OwnerLbl.Name = "OwnerLbl";
            this.OwnerLbl.Size = new System.Drawing.Size(59, 13);
            this.OwnerLbl.TabIndex = 22;
            this.OwnerLbl.Text = "Владелец:";
            // 
            // TypeGarLbl
            // 
            this.TypeGarLbl.AutoSize = true;
            this.TypeGarLbl.Location = new System.Drawing.Point(16, 66);
            this.TypeGarLbl.Name = "TypeGarLbl";
            this.TypeGarLbl.Size = new System.Drawing.Size(69, 13);
            this.TypeGarLbl.TabIndex = 21;
            this.TypeGarLbl.Text = "Тип гаража:";
            // 
            // NumGarLbl
            // 
            this.NumGarLbl.AutoSize = true;
            this.NumGarLbl.Location = new System.Drawing.Point(16, 23);
            this.NumGarLbl.Name = "NumGarLbl";
            this.NumGarLbl.Size = new System.Drawing.Size(84, 13);
            this.NumGarLbl.TabIndex = 20;
            this.NumGarLbl.Text = "Номер гаража:";
            // 
            // NumGartxtbx
            // 
            this.NumGartxtbx.Location = new System.Drawing.Point(106, 20);
            this.NumGartxtbx.Name = "NumGartxtbx";
            this.NumGartxtbx.Size = new System.Drawing.Size(237, 20);
            this.NumGartxtbx.TabIndex = 31;
            // 
            // TypeGarTxtbx
            // 
            this.TypeGarTxtbx.DataSource = this.sgaragetypesBindingSource;
            this.TypeGarTxtbx.DisplayMember = "name_garage_type";
            this.TypeGarTxtbx.FormattingEnabled = true;
            this.TypeGarTxtbx.Location = new System.Drawing.Point(106, 63);
            this.TypeGarTxtbx.Name = "TypeGarTxtbx";
            this.TypeGarTxtbx.Size = new System.Drawing.Size(237, 21);
            this.TypeGarTxtbx.TabIndex = 34;
            this.TypeGarTxtbx.ValueMember = "id_garage_type";
            // 
            // sgaragetypesBindingSource
            // 
            this.sgaragetypesBindingSource.DataMember = "s_garage_types";
            this.sgaragetypesBindingSource.DataSource = this.sGarTypeDS;
            // 
            // sGarTypeDS
            // 
            this.sGarTypeDS.DataSetName = "sGarTypeDS";
            this.sGarTypeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ownercmbbx
            // 
            Ownercmbbx.DataSource = this.spersonsBindingSource;
            Ownercmbbx.DisplayMember = "fio";
            Ownercmbbx.FormattingEnabled = true;
            Ownercmbbx.Location = new System.Drawing.Point(106, 111);
            Ownercmbbx.Name = "Ownercmbbx";
            Ownercmbbx.Size = new System.Drawing.Size(237, 21);
            Ownercmbbx.TabIndex = 35;
            Ownercmbbx.ValueMember = "id_person";
            // 
            // spersonsBindingSource
            // 
            this.spersonsBindingSource.DataMember = "s_persons";
            this.spersonsBindingSource.DataSource = sPer_NewGarDS;
            // 
            // sPer_NewGarDS
            // 
            sPer_NewGarDS.DataSetName = "sPer_NewGarDS";
            sPer_NewGarDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_garage_typesTableAdapter
            // 
            this.s_garage_typesTableAdapter.ClearBeforeFill = true;
            // 
            // s_personsTableAdapter
            // 
            s_personsTableAdapter.ClearBeforeFill = true;
            // 
            // AddrLbl
            // 
            this.AddrLbl.AutoSize = true;
            this.AddrLbl.Location = new System.Drawing.Point(397, 20);
            this.AddrLbl.Name = "AddrLbl";
            this.AddrLbl.Size = new System.Drawing.Size(41, 13);
            this.AddrLbl.TabIndex = 36;
            this.AddrLbl.Text = "Адрес:";
            // 
            // Addrrtxtbx
            // 
            this.Addrrtxtbx.Location = new System.Drawing.Point(444, 17);
            this.Addrrtxtbx.Name = "Addrrtxtbx";
            this.Addrrtxtbx.Size = new System.Drawing.Size(281, 66);
            this.Addrrtxtbx.TabIndex = 37;
            this.Addrrtxtbx.Text = "";
            // 
            // lbltxtbx
            // 
            this.lbltxtbx.AutoSize = true;
            this.lbltxtbx.Location = new System.Drawing.Point(397, 111);
            this.lbltxtbx.Name = "lbltxtbx";
            this.lbltxtbx.Size = new System.Drawing.Size(73, 13);
            this.lbltxtbx.TabIndex = 38;
            this.lbltxtbx.Text = "Примечания:";
            // 
            // notetxtbx
            // 
            this.notetxtbx.Location = new System.Drawing.Point(476, 108);
            this.notetxtbx.Name = "notetxtbx";
            this.notetxtbx.Size = new System.Drawing.Size(249, 20);
            this.notetxtbx.TabIndex = 39;
            // 
            // NewGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 211);
            this.Controls.Add(this.notetxtbx);
            this.Controls.Add(this.lbltxtbx);
            this.Controls.Add(this.Addrrtxtbx);
            this.Controls.Add(this.AddrLbl);
            this.Controls.Add(Ownercmbbx);
            this.Controls.Add(this.TypeGarTxtbx);
            this.Controls.Add(this.NumGartxtbx);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AddOwnerBtn);
            this.Controls.Add(this.OwnerLbl);
            this.Controls.Add(this.TypeGarLbl);
            this.Controls.Add(this.NumGarLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGarageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый гараж";
            this.Load += new System.EventHandler(this.NewGarageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sPer_NewGarDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button AddOwnerBtn;
        private System.Windows.Forms.Label OwnerLbl;
        private System.Windows.Forms.Label TypeGarLbl;
        private System.Windows.Forms.Label NumGarLbl;
        private System.Windows.Forms.TextBox NumGartxtbx;
        private System.Windows.Forms.ComboBox TypeGarTxtbx;
        private sGarTypeDS sGarTypeDS;
        private System.Windows.Forms.BindingSource sgaragetypesBindingSource;
        private sGarTypeDSTableAdapters.s_garage_typesTableAdapter s_garage_typesTableAdapter;
        private System.Windows.Forms.BindingSource spersonsBindingSource;
        private System.Windows.Forms.Label AddrLbl;
        private System.Windows.Forms.RichTextBox Addrrtxtbx;
        private System.Windows.Forms.Label lbltxtbx;
        private System.Windows.Forms.TextBox notetxtbx;
        public static System.Windows.Forms.ComboBox Ownercmbbx;
        public static sPer_NewGarDS sPer_NewGarDS;
        public static sPer_NewGarDSTableAdapters.s_personsTableAdapter s_personsTableAdapter;
    }
}