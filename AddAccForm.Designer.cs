
namespace SGC_garages
{
    partial class AddAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccForm));
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Notetxtbx = new System.Windows.Forms.TextBox();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AccNametxtbx = new System.Windows.Forms.TextBox();
            this.AccNameLbl = new System.Windows.Forms.Label();
            this.AccTypeLbl = new System.Windows.Forms.Label();
            this.AccTypecmbbx = new System.Windows.Forms.ComboBox();
            this.sAccTypeDS = new SGC_garages.SAccTypeDS();
            this.saccounttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_account_typeTableAdapter = new SGC_garages.SAccTypeDSTableAdapters.s_account_typeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sAccTypeDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccounttypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(309, 154);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 27);
            this.ClearBtn.TabIndex = 21;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Notetxtbx
            // 
            this.Notetxtbx.Location = new System.Drawing.Point(150, 102);
            this.Notetxtbx.Name = "Notetxtbx";
            this.Notetxtbx.Size = new System.Drawing.Size(447, 20);
            this.Notetxtbx.TabIndex = 20;
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Location = new System.Drawing.Point(71, 105);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Size = new System.Drawing.Size(73, 13);
            this.NoteLbl.TabIndex = 19;
            this.NoteLbl.Text = "Примечания:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(468, 154);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(129, 27);
            this.CloseBtn.TabIndex = 18;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::SGC_garages.Properties.Resources.save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(152, 154);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 27);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AccNametxtbx
            // 
            this.AccNametxtbx.Location = new System.Drawing.Point(150, 12);
            this.AccNametxtbx.Name = "AccNametxtbx";
            this.AccNametxtbx.Size = new System.Drawing.Size(447, 20);
            this.AccNametxtbx.TabIndex = 16;
            // 
            // AccNameLbl
            // 
            this.AccNameLbl.AutoSize = true;
            this.AccNameLbl.Location = new System.Drawing.Point(21, 15);
            this.AccNameLbl.Name = "AccNameLbl";
            this.AccNameLbl.Size = new System.Drawing.Size(123, 13);
            this.AccNameLbl.TabIndex = 15;
            this.AccNameLbl.Text = "Наименование статьи:";
            // 
            // AccTypeLbl
            // 
            this.AccTypeLbl.AutoSize = true;
            this.AccTypeLbl.Location = new System.Drawing.Point(78, 61);
            this.AccTypeLbl.Name = "AccTypeLbl";
            this.AccTypeLbl.Size = new System.Drawing.Size(66, 13);
            this.AccTypeLbl.TabIndex = 22;
            this.AccTypeLbl.Text = "Тип статьи:";
            // 
            // AccTypecmbbx
            // 
            this.AccTypecmbbx.DataSource = this.saccounttypeBindingSource;
            this.AccTypecmbbx.DisplayMember = "name_account_type";
            this.AccTypecmbbx.FormattingEnabled = true;
            this.AccTypecmbbx.Location = new System.Drawing.Point(150, 58);
            this.AccTypecmbbx.Name = "AccTypecmbbx";
            this.AccTypecmbbx.Size = new System.Drawing.Size(447, 21);
            this.AccTypecmbbx.TabIndex = 23;
            this.AccTypecmbbx.ValueMember = "id_account_type";
            // 
            // sAccTypeDS
            // 
            this.sAccTypeDS.DataSetName = "SAccTypeDS";
            this.sAccTypeDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saccounttypeBindingSource
            // 
            this.saccounttypeBindingSource.DataMember = "s_account_type";
            this.saccounttypeBindingSource.DataSource = this.sAccTypeDS;
            // 
            // s_account_typeTableAdapter
            // 
            this.s_account_typeTableAdapter.ClearBeforeFill = true;
            // 
            // AddAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 220);
            this.Controls.Add(this.AccTypecmbbx);
            this.Controls.Add(this.AccTypeLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Notetxtbx);
            this.Controls.Add(this.NoteLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AccNametxtbx);
            this.Controls.Add(this.AccNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить статью в справочник";
            this.Load += new System.EventHandler(this.AddAccForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAccTypeDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saccounttypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.TextBox Notetxtbx;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox AccNametxtbx;
        private System.Windows.Forms.Label AccNameLbl;
        private System.Windows.Forms.Label AccTypeLbl;
        private System.Windows.Forms.ComboBox AccTypecmbbx;
        private SAccTypeDS sAccTypeDS;
        private System.Windows.Forms.BindingSource saccounttypeBindingSource;
        private SAccTypeDSTableAdapters.s_account_typeTableAdapter s_account_typeTableAdapter;
    }
}