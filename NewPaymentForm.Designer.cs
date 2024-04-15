
namespace SGC_garages
{
    partial class NewPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPaymentForm));
            this.NumGarLbl = new System.Windows.Forms.Label();
            this.numGarcmbbx = new System.Windows.Forms.ComboBox();
            this.tgaragesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tGarDS = new SGC_garages.tGarDS();
            this.TypeGarLbl = new System.Windows.Forms.Label();
            this.typeGarcmbbx = new System.Windows.Forms.ComboBox();
            this.sgaragetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGarType = new SGC_garages.sGarType();
            this.OwnerLbl = new System.Windows.Forms.Label();
            this.OwnerCmbbx = new System.Windows.Forms.ComboBox();
            this.spersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPerDS = new SGC_garages.sPerDS();
            PayerCmbbx = new System.Windows.Forms.ComboBox();
            this.spersonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            sPerP = new SGC_garages.sPerP();
            this.PayerLbl = new System.Windows.Forms.Label();
            this.AccLbl = new System.Windows.Forms.Label();
            this.SumTxtbx = new System.Windows.Forms.TextBox();
            this.AccCmbbx = new System.Windows.Forms.ComboBox();
            this.saccntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accntDS = new SGC_garages.AccntDS();
            this.AddPayerBtn = new System.Windows.Forms.Button();
            this.SumLbl = new System.Windows.Forms.Label();
            this.NewPaymentBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.t_garagesTableAdapter = new SGC_garages.tGarDSTableAdapters.t_garagesTableAdapter();
            this.s_garage_typesTableAdapter = new SGC_garages.sGarTypeTableAdapters.s_garage_typesTableAdapter();
            this.s_personsTableAdapter = new SGC_garages.sPerDSTableAdapters.s_personsTableAdapter();
            s_personsTableAdapter1 = new SGC_garages.sPerPTableAdapters.s_personsTableAdapter();
            this.s_accntTableAdapter = new SGC_garages.AccntDSTableAdapters.s_accountTableAdapter();
            this.Dictdatagrpbx = new System.Windows.Forms.GroupBox();
            this.Accdatagrpbx = new System.Windows.Forms.GroupBox();
            this.Electricitydatagrpbx = new System.Windows.Forms.GroupBox();
            this.nightdatagrpbx = new System.Windows.Forms.TextBox();
            this.daydatatxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tgaragesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGarDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPerDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sPerP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accntDS)).BeginInit();
            this.Dictdatagrpbx.SuspendLayout();
            this.Accdatagrpbx.SuspendLayout();
            this.Electricitydatagrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumGarLbl
            // 
            this.NumGarLbl.AutoSize = true;
            this.NumGarLbl.Location = new System.Drawing.Point(14, 33);
            this.NumGarLbl.Name = "NumGarLbl";
            this.NumGarLbl.Size = new System.Drawing.Size(84, 13);
            this.NumGarLbl.TabIndex = 0;
            this.NumGarLbl.Text = "Номер гаража:";
            // 
            // numGarcmbbx
            // 
            this.numGarcmbbx.DataSource = this.tgaragesBindingSource;
            this.numGarcmbbx.DisplayMember = "num";
            this.numGarcmbbx.FormattingEnabled = true;
            this.numGarcmbbx.Location = new System.Drawing.Point(104, 30);
            this.numGarcmbbx.Name = "numGarcmbbx";
            this.numGarcmbbx.Size = new System.Drawing.Size(167, 21);
            this.numGarcmbbx.TabIndex = 1;
            this.numGarcmbbx.ValueMember = "id_garage";
            // 
            // tgaragesBindingSource
            // 
            this.tgaragesBindingSource.DataMember = "t_garages";
            this.tgaragesBindingSource.DataSource = this.tGarDS;
            // 
            // tGarDS
            // 
            this.tGarDS.DataSetName = "tGarDS";
            this.tGarDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypeGarLbl
            // 
            this.TypeGarLbl.AutoSize = true;
            this.TypeGarLbl.Location = new System.Drawing.Point(14, 76);
            this.TypeGarLbl.Name = "TypeGarLbl";
            this.TypeGarLbl.Size = new System.Drawing.Size(69, 13);
            this.TypeGarLbl.TabIndex = 2;
            this.TypeGarLbl.Text = "Тип гаража:";
            // 
            // typeGarcmbbx
            // 
            this.typeGarcmbbx.DataSource = this.sgaragetypesBindingSource;
            this.typeGarcmbbx.DisplayMember = "name_garage_type";
            this.typeGarcmbbx.FormattingEnabled = true;
            this.typeGarcmbbx.Location = new System.Drawing.Point(104, 73);
            this.typeGarcmbbx.Name = "typeGarcmbbx";
            this.typeGarcmbbx.Size = new System.Drawing.Size(167, 21);
            this.typeGarcmbbx.TabIndex = 3;
            this.typeGarcmbbx.ValueMember = "id_garage_type";
            // 
            // sgaragetypesBindingSource
            // 
            this.sgaragetypesBindingSource.DataMember = "s_garage_types";
            this.sgaragetypesBindingSource.DataSource = this.sGarType;
            // 
            // sGarType
            // 
            this.sGarType.DataSetName = "sGarType";
            this.sGarType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OwnerLbl
            // 
            this.OwnerLbl.AutoSize = true;
            this.OwnerLbl.Location = new System.Drawing.Point(14, 124);
            this.OwnerLbl.Name = "OwnerLbl";
            this.OwnerLbl.Size = new System.Drawing.Size(59, 13);
            this.OwnerLbl.TabIndex = 4;
            this.OwnerLbl.Text = "Владелец:";
            // 
            // OwnerCmbbx
            // 
            this.OwnerCmbbx.DataSource = this.spersonsBindingSource;
            this.OwnerCmbbx.DisplayMember = "fio";
            this.OwnerCmbbx.FormattingEnabled = true;
            this.OwnerCmbbx.Location = new System.Drawing.Point(104, 121);
            this.OwnerCmbbx.Name = "OwnerCmbbx";
            this.OwnerCmbbx.Size = new System.Drawing.Size(167, 21);
            this.OwnerCmbbx.TabIndex = 5;
            this.OwnerCmbbx.ValueMember = "id_person";
            // 
            // spersonsBindingSource
            // 
            this.spersonsBindingSource.DataMember = "s_persons";
            this.spersonsBindingSource.DataSource = this.sPerDS;
            // 
            // sPerDS
            // 
            this.sPerDS.DataSetName = "sPerDS";
            this.sPerDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PayerCmbbx
            // 
            PayerCmbbx.DataSource = this.spersonsBindingSource1;
            PayerCmbbx.DisplayMember = "fio";
            PayerCmbbx.FormattingEnabled = true;
            PayerCmbbx.Location = new System.Drawing.Point(104, 166);
            PayerCmbbx.Name = "PayerCmbbx";
            PayerCmbbx.Size = new System.Drawing.Size(167, 21);
            PayerCmbbx.TabIndex = 7;
            PayerCmbbx.ValueMember = "id_person";
            // 
            // spersonsBindingSource1
            // 
            this.spersonsBindingSource1.DataMember = "s_persons";
            this.spersonsBindingSource1.DataSource = sPerP;
            // 
            // sPerP
            // 
            sPerP.DataSetName = "sPerP";
            sPerP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PayerLbl
            // 
            this.PayerLbl.AutoSize = true;
            this.PayerLbl.Location = new System.Drawing.Point(14, 169);
            this.PayerLbl.Name = "PayerLbl";
            this.PayerLbl.Size = new System.Drawing.Size(74, 13);
            this.PayerLbl.TabIndex = 6;
            this.PayerLbl.Text = "Плательщик:";
            // 
            // AccLbl
            // 
            this.AccLbl.AutoSize = true;
            this.AccLbl.Location = new System.Drawing.Point(19, 28);
            this.AccLbl.Name = "AccLbl";
            this.AccLbl.Size = new System.Drawing.Size(45, 13);
            this.AccLbl.TabIndex = 8;
            this.AccLbl.Text = "Статья:";
            // 
            // SumTxtbx
            // 
            this.SumTxtbx.Location = new System.Drawing.Point(73, 171);
            this.SumTxtbx.Name = "SumTxtbx";
            this.SumTxtbx.Size = new System.Drawing.Size(208, 20);
            this.SumTxtbx.TabIndex = 9;
            // 
            // AccCmbbx
            // 
            this.AccCmbbx.DataSource = this.saccntBindingSource;
            this.AccCmbbx.DisplayMember = "name_account";
            this.AccCmbbx.FormattingEnabled = true;
            this.AccCmbbx.Location = new System.Drawing.Point(72, 25);
            this.AccCmbbx.Name = "AccCmbbx";
            this.AccCmbbx.Size = new System.Drawing.Size(207, 21);
            this.AccCmbbx.TabIndex = 10;
            this.AccCmbbx.ValueMember = "id_account";
            this.AccCmbbx.SelectedIndexChanged += new System.EventHandler(this.AccCmbbx_SelectedIndexChanged);
            // 
            // saccntBindingSource
            // 
            this.saccntBindingSource.DataMember = "s_account";
            this.saccntBindingSource.DataSource = this.accntDS;
            // 
            // accntDS
            // 
            this.accntDS.DataSetName = "AccntDS";
            this.accntDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddPayerBtn
            // 
            this.AddPayerBtn.Location = new System.Drawing.Point(277, 164);
            this.AddPayerBtn.Name = "AddPayerBtn";
            this.AddPayerBtn.Size = new System.Drawing.Size(29, 23);
            this.AddPayerBtn.TabIndex = 14;
            this.AddPayerBtn.Text = "...";
            this.AddPayerBtn.UseVisualStyleBackColor = true;
            this.AddPayerBtn.Click += new System.EventHandler(this.AddPayerBtn_Click);
            // 
            // SumLbl
            // 
            this.SumLbl.AutoSize = true;
            this.SumLbl.Location = new System.Drawing.Point(21, 174);
            this.SumLbl.Name = "SumLbl";
            this.SumLbl.Size = new System.Drawing.Size(44, 13);
            this.SumLbl.TabIndex = 16;
            this.SumLbl.Text = "Сумма:";
            // 
            // NewPaymentBtn
            // 
            this.NewPaymentBtn.Image = global::SGC_garages.Properties.Resources.plus;
            this.NewPaymentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewPaymentBtn.Location = new System.Drawing.Point(113, 227);
            this.NewPaymentBtn.Name = "NewPaymentBtn";
            this.NewPaymentBtn.Size = new System.Drawing.Size(125, 29);
            this.NewPaymentBtn.TabIndex = 17;
            this.NewPaymentBtn.Text = "Внести платёж";
            this.NewPaymentBtn.UseVisualStyleBackColor = true;
            this.NewPaymentBtn.Click += new System.EventHandler(this.NewPaymentBtn_Click);
            // 
            // button7
            // 
            this.button7.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(244, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 29);
            this.button7.TabIndex = 18;
            this.button7.Text = "Очистить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Image = global::SGC_garages.Properties.Resources.delete;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(375, 227);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 29);
            this.button8.TabIndex = 19;
            this.button8.Text = "Закрыть";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // t_garagesTableAdapter
            // 
            this.t_garagesTableAdapter.ClearBeforeFill = true;
            // 
            // s_garage_typesTableAdapter
            // 
            this.s_garage_typesTableAdapter.ClearBeforeFill = true;
            // 
            // s_personsTableAdapter
            // 
            this.s_personsTableAdapter.ClearBeforeFill = true;
            // 
            // s_personsTableAdapter1
            // 
            s_personsTableAdapter1.ClearBeforeFill = true;
            // 
            // s_accntTableAdapter
            // 
            this.s_accntTableAdapter.ClearBeforeFill = true;
            // 
            // Dictdatagrpbx
            // 
            this.Dictdatagrpbx.Controls.Add(this.AddPayerBtn);
            this.Dictdatagrpbx.Controls.Add(PayerCmbbx);
            this.Dictdatagrpbx.Controls.Add(this.PayerLbl);
            this.Dictdatagrpbx.Controls.Add(this.OwnerCmbbx);
            this.Dictdatagrpbx.Controls.Add(this.OwnerLbl);
            this.Dictdatagrpbx.Controls.Add(this.typeGarcmbbx);
            this.Dictdatagrpbx.Controls.Add(this.TypeGarLbl);
            this.Dictdatagrpbx.Controls.Add(this.numGarcmbbx);
            this.Dictdatagrpbx.Controls.Add(this.NumGarLbl);
            this.Dictdatagrpbx.Location = new System.Drawing.Point(7, 7);
            this.Dictdatagrpbx.Name = "Dictdatagrpbx";
            this.Dictdatagrpbx.Size = new System.Drawing.Size(312, 209);
            this.Dictdatagrpbx.TabIndex = 20;
            this.Dictdatagrpbx.TabStop = false;
            this.Dictdatagrpbx.Text = "Справочные данные";
            // 
            // Accdatagrpbx
            // 
            this.Accdatagrpbx.Controls.Add(this.Electricitydatagrpbx);
            this.Accdatagrpbx.Controls.Add(this.SumTxtbx);
            this.Accdatagrpbx.Controls.Add(this.SumLbl);
            this.Accdatagrpbx.Controls.Add(this.AccCmbbx);
            this.Accdatagrpbx.Controls.Add(this.AccLbl);
            this.Accdatagrpbx.Location = new System.Drawing.Point(325, 7);
            this.Accdatagrpbx.Name = "Accdatagrpbx";
            this.Accdatagrpbx.Size = new System.Drawing.Size(287, 206);
            this.Accdatagrpbx.TabIndex = 21;
            this.Accdatagrpbx.TabStop = false;
            this.Accdatagrpbx.Text = "Данные платежа";
            // 
            // Electricitydatagrpbx
            // 
            this.Electricitydatagrpbx.Controls.Add(this.nightdatagrpbx);
            this.Electricitydatagrpbx.Controls.Add(this.daydatatxtbx);
            this.Electricitydatagrpbx.Controls.Add(this.label2);
            this.Electricitydatagrpbx.Controls.Add(this.label1);
            this.Electricitydatagrpbx.Location = new System.Drawing.Point(22, 71);
            this.Electricitydatagrpbx.Name = "Electricitydatagrpbx";
            this.Electricitydatagrpbx.Size = new System.Drawing.Size(257, 85);
            this.Electricitydatagrpbx.TabIndex = 18;
            this.Electricitydatagrpbx.TabStop = false;
            this.Electricitydatagrpbx.Text = "Электричество";
            this.Electricitydatagrpbx.Visible = false;
            // 
            // nightdatagrpbx
            // 
            this.nightdatagrpbx.Location = new System.Drawing.Point(126, 50);
            this.nightdatagrpbx.Name = "nightdatagrpbx";
            this.nightdatagrpbx.Size = new System.Drawing.Size(125, 20);
            this.nightdatagrpbx.TabIndex = 20;
            // 
            // daydatatxtbx
            // 
            this.daydatatxtbx.Location = new System.Drawing.Point(126, 24);
            this.daydatatxtbx.Name = "daydatatxtbx";
            this.daydatatxtbx.Size = new System.Drawing.Size(125, 20);
            this.daydatatxtbx.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Показания ночь, кВт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Показания день, кВт";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 268);
            this.Controls.Add(this.Accdatagrpbx);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Dictdatagrpbx);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.NewPaymentBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый платёж";
            this.Load += new System.EventHandler(this.NewPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgaragesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGarDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPerDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spersonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sPerP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accntDS)).EndInit();
            this.Dictdatagrpbx.ResumeLayout(false);
            this.Dictdatagrpbx.PerformLayout();
            this.Accdatagrpbx.ResumeLayout(false);
            this.Accdatagrpbx.PerformLayout();
            this.Electricitydatagrpbx.ResumeLayout(false);
            this.Electricitydatagrpbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumGarLbl;
        private System.Windows.Forms.ComboBox numGarcmbbx;
        private System.Windows.Forms.Label TypeGarLbl;
        private System.Windows.Forms.ComboBox typeGarcmbbx;
        private System.Windows.Forms.Label OwnerLbl;
        private System.Windows.Forms.ComboBox OwnerCmbbx;
        private System.Windows.Forms.Label PayerLbl;
        private System.Windows.Forms.Label AccLbl;
        private System.Windows.Forms.TextBox SumTxtbx;
        private System.Windows.Forms.ComboBox AccCmbbx;
        private System.Windows.Forms.Button AddPayerBtn;
        private System.Windows.Forms.Label SumLbl;
        private System.Windows.Forms.Button NewPaymentBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private tGarDS tGarDS;
        private System.Windows.Forms.BindingSource tgaragesBindingSource;
        private tGarDSTableAdapters.t_garagesTableAdapter t_garagesTableAdapter;
        private sGarType sGarType;
        private System.Windows.Forms.BindingSource sgaragetypesBindingSource;
        private sGarTypeTableAdapters.s_garage_typesTableAdapter s_garage_typesTableAdapter;
        private sPerDS sPerDS;
        private System.Windows.Forms.BindingSource spersonsBindingSource;
        private sPerDSTableAdapters.s_personsTableAdapter s_personsTableAdapter;
        private System.Windows.Forms.BindingSource spersonsBindingSource1;
        private AccntDS accntDS;
        private System.Windows.Forms.BindingSource saccntBindingSource;
        private AccntDSTableAdapters.s_accountTableAdapter s_accntTableAdapter;
        private System.Windows.Forms.GroupBox Dictdatagrpbx;
        private System.Windows.Forms.GroupBox Accdatagrpbx;
        private System.Windows.Forms.GroupBox Electricitydatagrpbx;
        private System.Windows.Forms.TextBox nightdatagrpbx;
        private System.Windows.Forms.TextBox daydatatxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public static System.Windows.Forms.ComboBox PayerCmbbx;
        public static sPerP sPerP;
        public static sPerPTableAdapters.s_personsTableAdapter s_personsTableAdapter1;
    }
}