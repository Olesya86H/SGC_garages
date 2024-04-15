
namespace SGC_garages
{
    partial class ReesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReesForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьНачисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьНачисленияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReeTab = new System.Windows.Forms.TabControl();
            this.MainPg = new System.Windows.Forms.TabPage();
            this.MainGrd = new System.Windows.Forms.DataGridView();
            this.ContribPg = new System.Windows.Forms.TabPage();
            this.ContribGrd = new System.Windows.Forms.DataGridView();
            this.ElectricityPg = new System.Windows.Forms.TabPage();
            this.ElectricityGrd = new System.Windows.Forms.DataGridView();
            this.RentPg = new System.Windows.Forms.TabPage();
            this.RentGrd = new System.Windows.Forms.DataGridView();
            this.BenefitPg = new System.Windows.Forms.TabPage();
            this.BenefitGrd = new System.Windows.Forms.DataGridView();
            this.filtergrpbx = new System.Windows.Forms.GroupBox();
            this.saccounttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAccTypeReeDS = new SGC_garages.sAccTypeReeDS();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.TypeGarCmbbx = new System.Windows.Forms.ComboBox();
            this.sgaragetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGarTypeReeDS = new SGC_garages.sGarTypeReeDS();
            this.GarageTypeLbl = new System.Windows.Forms.Label();
            this.s_garage_typesTableAdapter = new SGC_garages.sGarTypeReeDSTableAdapters.s_garage_typesTableAdapter();
            this.s_account_typeTableAdapter = new SGC_garages.sAccTypeReeDSTableAdapters.s_account_typeTableAdapter();
            this.AccTypeLbl = new System.Windows.Forms.Label();
            this.AccTypeCmbbx = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.ReeTab.SuspendLayout();
            this.MainPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrd)).BeginInit();
            this.ContribPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContribGrd)).BeginInit();
            this.ElectricityPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectricityGrd)).BeginInit();
            this.RentPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentGrd)).BeginInit();
            this.BenefitPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BenefitGrd)).BeginInit();
            this.filtergrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saccounttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAccTypeReeDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeReeDS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.toolStripMenuItem2,
            this.сделатьНачисленияToolStripMenuItem1,
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
            this.toolStripMenuItem1,
            this.сделатьНачисленияToolStripMenuItem,
            this.обновитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this.действияToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.display;
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.find;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem1.Text = "Поиск";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // сделатьНачисленияToolStripMenuItem
            // 
            this.сделатьНачисленияToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.calculator;
            this.сделатьНачисленияToolStripMenuItem.Name = "сделатьНачисленияToolStripMenuItem";
            this.сделатьНачисленияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сделатьНачисленияToolStripMenuItem.Text = "Сделать начисления";
            this.сделатьНачисленияToolStripMenuItem.Click += new System.EventHandler(this.сделатьНачисленияToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.update;
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            this.обновитьToolStripMenuItem1.Click += new System.EventHandler(this.обновитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::SGC_garages.Properties.Resources.find;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem2.Text = "Поиск";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // сделатьНачисленияToolStripMenuItem1
            // 
            this.сделатьНачисленияToolStripMenuItem1.Image = global::SGC_garages.Properties.Resources.calculator;
            this.сделатьНачисленияToolStripMenuItem1.Name = "сделатьНачисленияToolStripMenuItem1";
            this.сделатьНачисленияToolStripMenuItem1.Size = new System.Drawing.Size(148, 20);
            this.сделатьНачисленияToolStripMenuItem1.Text = "Сделать начисления";
            this.сделатьНачисленияToolStripMenuItem1.Click += new System.EventHandler(this.сделатьНачисленияToolStripMenuItem_Click);
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
            // ReeTab
            // 
            this.ReeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReeTab.Controls.Add(this.MainPg);
            this.ReeTab.Controls.Add(this.ContribPg);
            this.ReeTab.Controls.Add(this.ElectricityPg);
            this.ReeTab.Controls.Add(this.RentPg);
            this.ReeTab.Controls.Add(this.BenefitPg);
            this.ReeTab.Location = new System.Drawing.Point(13, 89);
            this.ReeTab.Name = "ReeTab";
            this.ReeTab.SelectedIndex = 0;
            this.ReeTab.Size = new System.Drawing.Size(775, 403);
            this.ReeTab.TabIndex = 7;
            // 
            // MainPg
            // 
            this.MainPg.Controls.Add(this.MainGrd);
            this.MainPg.Location = new System.Drawing.Point(4, 22);
            this.MainPg.Name = "MainPg";
            this.MainPg.Padding = new System.Windows.Forms.Padding(3);
            this.MainPg.Size = new System.Drawing.Size(767, 377);
            this.MainPg.TabIndex = 0;
            this.MainPg.Text = "Основное";
            this.MainPg.UseVisualStyleBackColor = true;
            // 
            // MainGrd
            // 
            this.MainGrd.AllowUserToAddRows = false;
            this.MainGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrd.Location = new System.Drawing.Point(6, 6);
            this.MainGrd.Name = "MainGrd";
            this.MainGrd.Size = new System.Drawing.Size(755, 365);
            this.MainGrd.TabIndex = 0;
            // 
            // ContribPg
            // 
            this.ContribPg.Controls.Add(this.ContribGrd);
            this.ContribPg.Location = new System.Drawing.Point(4, 22);
            this.ContribPg.Name = "ContribPg";
            this.ContribPg.Padding = new System.Windows.Forms.Padding(3);
            this.ContribPg.Size = new System.Drawing.Size(767, 377);
            this.ContribPg.TabIndex = 1;
            this.ContribPg.Text = "Взносы";
            this.ContribPg.UseVisualStyleBackColor = true;
            // 
            // ContribGrd
            // 
            this.ContribGrd.AllowUserToAddRows = false;
            this.ContribGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContribGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContribGrd.Location = new System.Drawing.Point(3, 6);
            this.ContribGrd.Name = "ContribGrd";
            this.ContribGrd.Size = new System.Drawing.Size(758, 365);
            this.ContribGrd.TabIndex = 0;
            // 
            // ElectricityPg
            // 
            this.ElectricityPg.Controls.Add(this.ElectricityGrd);
            this.ElectricityPg.Location = new System.Drawing.Point(4, 22);
            this.ElectricityPg.Name = "ElectricityPg";
            this.ElectricityPg.Padding = new System.Windows.Forms.Padding(3);
            this.ElectricityPg.Size = new System.Drawing.Size(767, 377);
            this.ElectricityPg.TabIndex = 2;
            this.ElectricityPg.Text = "Электричество";
            this.ElectricityPg.UseVisualStyleBackColor = true;
            // 
            // ElectricityGrd
            // 
            this.ElectricityGrd.AllowUserToAddRows = false;
            this.ElectricityGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElectricityGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElectricityGrd.Location = new System.Drawing.Point(6, 6);
            this.ElectricityGrd.Name = "ElectricityGrd";
            this.ElectricityGrd.Size = new System.Drawing.Size(755, 365);
            this.ElectricityGrd.TabIndex = 0;
            // 
            // RentPg
            // 
            this.RentPg.Controls.Add(this.RentGrd);
            this.RentPg.Location = new System.Drawing.Point(4, 22);
            this.RentPg.Name = "RentPg";
            this.RentPg.Padding = new System.Windows.Forms.Padding(3);
            this.RentPg.Size = new System.Drawing.Size(767, 377);
            this.RentPg.TabIndex = 3;
            this.RentPg.Text = "Аренда";
            this.RentPg.UseVisualStyleBackColor = true;
            // 
            // RentGrd
            // 
            this.RentGrd.AllowUserToAddRows = false;
            this.RentGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RentGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentGrd.Location = new System.Drawing.Point(6, 6);
            this.RentGrd.Name = "RentGrd";
            this.RentGrd.Size = new System.Drawing.Size(755, 365);
            this.RentGrd.TabIndex = 0;
            // 
            // BenefitPg
            // 
            this.BenefitPg.Controls.Add(this.BenefitGrd);
            this.BenefitPg.Location = new System.Drawing.Point(4, 22);
            this.BenefitPg.Name = "BenefitPg";
            this.BenefitPg.Padding = new System.Windows.Forms.Padding(3);
            this.BenefitPg.Size = new System.Drawing.Size(767, 377);
            this.BenefitPg.TabIndex = 4;
            this.BenefitPg.Text = "Благоустройство";
            this.BenefitPg.UseVisualStyleBackColor = true;
            // 
            // BenefitGrd
            // 
            this.BenefitGrd.AllowUserToAddRows = false;
            this.BenefitGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BenefitGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BenefitGrd.Location = new System.Drawing.Point(6, 6);
            this.BenefitGrd.Name = "BenefitGrd";
            this.BenefitGrd.Size = new System.Drawing.Size(755, 365);
            this.BenefitGrd.TabIndex = 0;
            // 
            // filtergrpbx
            // 
            this.filtergrpbx.Controls.Add(this.AccTypeCmbbx);
            this.filtergrpbx.Controls.Add(this.AccTypeLbl);
            this.filtergrpbx.Controls.Add(this.FilterBtn);
            this.filtergrpbx.Controls.Add(this.TypeGarCmbbx);
            this.filtergrpbx.Controls.Add(this.GarageTypeLbl);
            this.filtergrpbx.Location = new System.Drawing.Point(12, 27);
            this.filtergrpbx.Name = "filtergrpbx";
            this.filtergrpbx.Size = new System.Drawing.Size(772, 56);
            this.filtergrpbx.TabIndex = 13;
            this.filtergrpbx.TabStop = false;
            this.filtergrpbx.Text = "Фильтры";
            // 
            // saccounttypeBindingSource
            // 
            this.saccounttypeBindingSource.DataMember = "s_account_type";
            this.saccounttypeBindingSource.DataSource = this.sAccTypeReeDS;
            // 
            // sAccTypeReeDS
            // 
            this.sAccTypeReeDS.DataSetName = "sAccTypeReeDS";
            this.sAccTypeReeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FilterBtn
            // 
            this.FilterBtn.Image = global::SGC_garages.Properties.Resources.play;
            this.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterBtn.Location = new System.Drawing.Point(369, 15);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(130, 33);
            this.FilterBtn.TabIndex = 9;
            this.FilterBtn.Text = "Показать";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // TypeGarCmbbx
            // 
            this.TypeGarCmbbx.DataSource = this.sgaragetypesBindingSource;
            this.TypeGarCmbbx.DisplayMember = "name_garage_type";
            this.TypeGarCmbbx.FormattingEnabled = true;
            this.TypeGarCmbbx.Location = new System.Drawing.Point(101, 22);
            this.TypeGarCmbbx.Name = "TypeGarCmbbx";
            this.TypeGarCmbbx.Size = new System.Drawing.Size(239, 21);
            this.TypeGarCmbbx.TabIndex = 11;
            this.TypeGarCmbbx.ValueMember = "id_garage_type";
            // 
            // sgaragetypesBindingSource
            // 
            this.sgaragetypesBindingSource.DataMember = "s_garage_types";
            this.sgaragetypesBindingSource.DataSource = this.sGarTypeReeDS;
            // 
            // sGarTypeReeDS
            // 
            this.sGarTypeReeDS.DataSetName = "sGarTypeReeDS";
            this.sGarTypeReeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GarageTypeLbl
            // 
            this.GarageTypeLbl.AutoSize = true;
            this.GarageTypeLbl.Location = new System.Drawing.Point(14, 25);
            this.GarageTypeLbl.Name = "GarageTypeLbl";
            this.GarageTypeLbl.Size = new System.Drawing.Size(69, 13);
            this.GarageTypeLbl.TabIndex = 10;
            this.GarageTypeLbl.Text = "Тип гаража:";
            // 
            // s_garage_typesTableAdapter
            // 
            this.s_garage_typesTableAdapter.ClearBeforeFill = true;
            // 
            // s_account_typeTableAdapter
            // 
            this.s_account_typeTableAdapter.ClearBeforeFill = true;
            // 
            // AccTypeLbl
            // 
            this.AccTypeLbl.AutoSize = true;
            this.AccTypeLbl.Location = new System.Drawing.Point(566, 25);
            this.AccTypeLbl.Name = "AccTypeLbl";
            this.AccTypeLbl.Size = new System.Drawing.Size(66, 13);
            this.AccTypeLbl.TabIndex = 12;
            this.AccTypeLbl.Text = "Тип статьи:";
            this.AccTypeLbl.Visible = false;
            // 
            // AccTypeCmbbx
            // 
            this.AccTypeCmbbx.DataSource = this.saccounttypeBindingSource;
            this.AccTypeCmbbx.DisplayMember = "name_account_type";
            this.AccTypeCmbbx.FormattingEnabled = true;
            this.AccTypeCmbbx.Location = new System.Drawing.Point(638, 19);
            this.AccTypeCmbbx.Name = "AccTypeCmbbx";
            this.AccTypeCmbbx.Size = new System.Drawing.Size(113, 21);
            this.AccTypeCmbbx.TabIndex = 13;
            this.AccTypeCmbbx.ValueMember = "id_account_type";
            this.AccTypeCmbbx.Visible = false;
            // 
            // ReesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.filtergrpbx);
            this.Controls.Add(this.ReeTab);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестры";
            this.Load += new System.EventHandler(this.ReesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ReeTab.ResumeLayout(false);
            this.MainPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrd)).EndInit();
            this.ContribPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContribGrd)).EndInit();
            this.ElectricityPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ElectricityGrd)).EndInit();
            this.RentPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentGrd)).EndInit();
            this.BenefitPg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BenefitGrd)).EndInit();
            this.filtergrpbx.ResumeLayout(false);
            this.filtergrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saccounttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAccTypeReeDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgaragetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGarTypeReeDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem2;
        private System.Windows.Forms.TabControl ReeTab;
        private System.Windows.Forms.TabPage MainPg;
        private System.Windows.Forms.TabPage ContribPg;
        private System.Windows.Forms.TabPage ElectricityPg;
        private System.Windows.Forms.TabPage RentPg;
        private System.Windows.Forms.TabPage BenefitPg;
        private System.Windows.Forms.DataGridView MainGrd;
        private System.Windows.Forms.DataGridView ContribGrd;
        private System.Windows.Forms.DataGridView ElectricityGrd;
        private System.Windows.Forms.DataGridView RentGrd;
        private System.Windows.Forms.DataGridView BenefitGrd;
        private System.Windows.Forms.GroupBox filtergrpbx;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.ComboBox TypeGarCmbbx;
        private System.Windows.Forms.Label GarageTypeLbl;
        private System.Windows.Forms.ToolStripMenuItem сделатьНачисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьНачисленияToolStripMenuItem1;
        private sGarTypeReeDS sGarTypeReeDS;
        private System.Windows.Forms.BindingSource sgaragetypesBindingSource;
        private sGarTypeReeDSTableAdapters.s_garage_typesTableAdapter s_garage_typesTableAdapter;
        private sAccTypeReeDS sAccTypeReeDS;
        private System.Windows.Forms.BindingSource saccounttypeBindingSource;
        private sAccTypeReeDSTableAdapters.s_account_typeTableAdapter s_account_typeTableAdapter;
        private System.Windows.Forms.ComboBox AccTypeCmbbx;
        private System.Windows.Forms.Label AccTypeLbl;
    }
}