
namespace SGC_garages
{
    partial class AddFareValueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFareValueForm));
            this.AccTypeLbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.FareValuetxtbx = new System.Windows.Forms.TextBox();
            this.FareValueLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AccNametxtbx = new System.Windows.Forms.TextBox();
            this.AccNameLbl = new System.Windows.Forms.Label();
            this.AccTypetxtbx = new System.Windows.Forms.TextBox();
            this.DateOnLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOnMtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.DateOffMtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.GarTypeLbl = new System.Windows.Forms.Label();
            this.GarTypecmbbx = new System.Windows.Forms.ComboBox();
            this.sGarTypeDS = new SGC_garages.SGarTypeDS();
            this.sgaragetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_garage_typesTableAdapter = new SGC_garages.SGarTypeDSTableAdapters.s_garage_typesTableAdapter();
            this.SiLbl = new System.Windows.Forms.Label();
            this.SiCmbx = new System.Windows.Forms.ComboBox();
            this.sSi_DS = new SGC_garages.sSi_DS();
            this.ssiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_siTableAdapter = new SGC_garages.sSi_DSTableAdapters.s_siTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSi_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccTypeLbl
            // 
            this.AccTypeLbl.AutoSize = true;
            this.AccTypeLbl.Location = new System.Drawing.Point(84, 70);
            this.AccTypeLbl.Name = "AccTypeLbl";
            this.AccTypeLbl.Size = new System.Drawing.Size(66, 13);
            this.AccTypeLbl.TabIndex = 31;
            this.AccTypeLbl.Text = "Тип статьи:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(315, 292);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 27);
            this.ClearBtn.TabIndex = 30;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // FareValuetxtbx
            // 
            this.FareValuetxtbx.Location = new System.Drawing.Point(156, 160);
            this.FareValuetxtbx.Name = "FareValuetxtbx";
            this.FareValuetxtbx.Size = new System.Drawing.Size(102, 20);
            this.FareValuetxtbx.TabIndex = 29;
            // 
            // FareValueLbl
            // 
            this.FareValueLbl.AutoSize = true;
            this.FareValueLbl.Location = new System.Drawing.Point(52, 163);
            this.FareValueLbl.Name = "FareValueLbl";
            this.FareValueLbl.Size = new System.Drawing.Size(98, 13);
            this.FareValueLbl.TabIndex = 28;
            this.FareValueLbl.Text = "Значение тарифа:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(474, 292);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(129, 27);
            this.CloseBtn.TabIndex = 27;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::SGC_garages.Properties.Resources.save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(158, 292);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 27);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AccNametxtbx
            // 
            this.AccNametxtbx.Enabled = false;
            this.AccNametxtbx.Location = new System.Drawing.Point(156, 21);
            this.AccNametxtbx.Name = "AccNametxtbx";
            this.AccNametxtbx.Size = new System.Drawing.Size(447, 20);
            this.AccNametxtbx.TabIndex = 25;
            // 
            // AccNameLbl
            // 
            this.AccNameLbl.AutoSize = true;
            this.AccNameLbl.Location = new System.Drawing.Point(27, 24);
            this.AccNameLbl.Name = "AccNameLbl";
            this.AccNameLbl.Size = new System.Drawing.Size(123, 13);
            this.AccNameLbl.TabIndex = 24;
            this.AccNameLbl.Text = "Наименование статьи:";
            // 
            // AccTypetxtbx
            // 
            this.AccTypetxtbx.Enabled = false;
            this.AccTypetxtbx.Location = new System.Drawing.Point(156, 67);
            this.AccTypetxtbx.Name = "AccTypetxtbx";
            this.AccTypetxtbx.Size = new System.Drawing.Size(447, 20);
            this.AccTypetxtbx.TabIndex = 32;
            // 
            // DateOnLbl
            // 
            this.DateOnLbl.AutoSize = true;
            this.DateOnLbl.Location = new System.Drawing.Point(26, 209);
            this.DateOnLbl.Name = "DateOnLbl";
            this.DateOnLbl.Size = new System.Drawing.Size(124, 13);
            this.DateOnLbl.TabIndex = 33;
            this.DateOnLbl.Text = "Дата начала действия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Дата окончания действия:";
            // 
            // DateOnMtxtbx
            // 
            this.DateOnMtxtbx.Location = new System.Drawing.Point(158, 206);
            this.DateOnMtxtbx.Mask = "00.00.0000";
            this.DateOnMtxtbx.Name = "DateOnMtxtbx";
            this.DateOnMtxtbx.Size = new System.Drawing.Size(100, 20);
            this.DateOnMtxtbx.TabIndex = 36;
            this.DateOnMtxtbx.Text = "01011900";
            this.DateOnMtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // DateOffMtxtbx
            // 
            this.DateOffMtxtbx.Location = new System.Drawing.Point(156, 253);
            this.DateOffMtxtbx.Mask = "00.00.0000";
            this.DateOffMtxtbx.Name = "DateOffMtxtbx";
            this.DateOffMtxtbx.Size = new System.Drawing.Size(100, 20);
            this.DateOffMtxtbx.TabIndex = 37;
            this.DateOffMtxtbx.Text = "01013000";
            this.DateOffMtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // GarTypeLbl
            // 
            this.GarTypeLbl.AutoSize = true;
            this.GarTypeLbl.Location = new System.Drawing.Point(84, 120);
            this.GarTypeLbl.Name = "GarTypeLbl";
            this.GarTypeLbl.Size = new System.Drawing.Size(69, 13);
            this.GarTypeLbl.TabIndex = 38;
            this.GarTypeLbl.Text = "Тип гаража:";
            // 
            // GarTypecmbbx
            // 
            this.GarTypecmbbx.DataSource = this.sgaragetypesBindingSource;
            this.GarTypecmbbx.DisplayMember = "name_garage_type";
            this.GarTypecmbbx.FormattingEnabled = true;
            this.GarTypecmbbx.Location = new System.Drawing.Point(156, 117);
            this.GarTypecmbbx.Name = "GarTypecmbbx";
            this.GarTypecmbbx.Size = new System.Drawing.Size(447, 21);
            this.GarTypecmbbx.TabIndex = 39;
            this.GarTypecmbbx.ValueMember = "id_garage_type";
            // 
            // sGarTypeDS
            // 
            this.sGarTypeDS.DataSetName = "SGarTypeDS";
            this.sGarTypeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sgaragetypesBindingSource
            // 
            this.sgaragetypesBindingSource.DataMember = "s_garage_types";
            this.sgaragetypesBindingSource.DataSource = this.sGarTypeDS;
            // 
            // s_garage_typesTableAdapter
            // 
            this.s_garage_typesTableAdapter.ClearBeforeFill = true;
            // 
            // SiLbl
            // 
            this.SiLbl.AutoSize = true;
            this.SiLbl.Location = new System.Drawing.Point(294, 163);
            this.SiLbl.Name = "SiLbl";
            this.SiLbl.Size = new System.Drawing.Size(82, 13);
            this.SiLbl.TabIndex = 40;
            this.SiLbl.Text = "Ед.измерения:";
            // 
            // SiCmbx
            // 
            this.SiCmbx.DataSource = this.ssiBindingSource;
            this.SiCmbx.DisplayMember = "name_si";
            this.SiCmbx.FormattingEnabled = true;
            this.SiCmbx.Location = new System.Drawing.Point(382, 160);
            this.SiCmbx.Name = "SiCmbx";
            this.SiCmbx.Size = new System.Drawing.Size(120, 21);
            this.SiCmbx.TabIndex = 41;
            this.SiCmbx.ValueMember = "id_si";
            // 
            // sSi_DS
            // 
            this.sSi_DS.DataSetName = "sSi_DS";
            this.sSi_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ssiBindingSource
            // 
            this.ssiBindingSource.DataMember = "s_si";
            this.ssiBindingSource.DataSource = this.sSi_DS;
            // 
            // s_siTableAdapter
            // 
            this.s_siTableAdapter.ClearBeforeFill = true;
            // 
            // AddFareValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 331);
            this.Controls.Add(this.SiCmbx);
            this.Controls.Add(this.SiLbl);
            this.Controls.Add(this.GarTypecmbbx);
            this.Controls.Add(this.GarTypeLbl);
            this.Controls.Add(this.DateOffMtxtbx);
            this.Controls.Add(this.DateOnMtxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateOnLbl);
            this.Controls.Add(this.AccTypetxtbx);
            this.Controls.Add(this.AccTypeLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.FareValuetxtbx);
            this.Controls.Add(this.FareValueLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AccNametxtbx);
            this.Controls.Add(this.AccNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFareValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тариф для статьи";
            this.Load += new System.EventHandler(this.AddFareValueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSi_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AccTypeLbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox FareValuetxtbx;
        private System.Windows.Forms.Label FareValueLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox AccNametxtbx;
        private System.Windows.Forms.Label AccNameLbl;
        private System.Windows.Forms.TextBox AccTypetxtbx;
        private System.Windows.Forms.Label DateOnLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox DateOnMtxtbx;
        private System.Windows.Forms.MaskedTextBox DateOffMtxtbx;
        private System.Windows.Forms.Label GarTypeLbl;
        private System.Windows.Forms.ComboBox GarTypecmbbx;
        private SGarTypeDS sGarTypeDS;
        private System.Windows.Forms.BindingSource sgaragetypesBindingSource;
        private SGarTypeDSTableAdapters.s_garage_typesTableAdapter s_garage_typesTableAdapter;
        private System.Windows.Forms.Label SiLbl;
        private System.Windows.Forms.ComboBox SiCmbx;
        private sSi_DS sSi_DS;
        private System.Windows.Forms.BindingSource ssiBindingSource;
        private sSi_DSTableAdapters.s_siTableAdapter s_siTableAdapter;
    }
}