
namespace SGC_garages
{
    partial class AddPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonForm));
            this.FIOLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.AddrLbl = new System.Windows.Forms.Label();
            this.Ownerchkbx = new System.Windows.Forms.CheckBox();
            this.Payerchkbx = new System.Windows.Forms.CheckBox();
            this.Userchkbx = new System.Windows.Forms.CheckBox();
            this.FIOtxtbx = new System.Windows.Forms.TextBox();
            this.Phonetxtbx = new System.Windows.Forms.TextBox();
            this.Addrtxtbx = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.Notetxtbx = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.logintxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FIOLbl
            // 
            this.FIOLbl.AutoSize = true;
            this.FIOLbl.Location = new System.Drawing.Point(56, 22);
            this.FIOLbl.Name = "FIOLbl";
            this.FIOLbl.Size = new System.Drawing.Size(37, 13);
            this.FIOLbl.TabIndex = 0;
            this.FIOLbl.Text = "ФИО:";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(24, 65);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(69, 13);
            this.PhoneLbl.TabIndex = 1;
            this.PhoneLbl.Text = "Телефон(ы):";
            // 
            // AddrLbl
            // 
            this.AddrLbl.AutoSize = true;
            this.AddrLbl.Location = new System.Drawing.Point(40, 113);
            this.AddrLbl.Name = "AddrLbl";
            this.AddrLbl.Size = new System.Drawing.Size(53, 13);
            this.AddrLbl.TabIndex = 2;
            this.AddrLbl.Text = "Адрес(а):";
            // 
            // Ownerchkbx
            // 
            this.Ownerchkbx.AutoSize = true;
            this.Ownerchkbx.Location = new System.Drawing.Point(112, 245);
            this.Ownerchkbx.Name = "Ownerchkbx";
            this.Ownerchkbx.Size = new System.Drawing.Size(132, 17);
            this.Ownerchkbx.TabIndex = 3;
            this.Ownerchkbx.Text = "Собственник гаража";
            this.Ownerchkbx.UseVisualStyleBackColor = true;
            // 
            // Payerchkbx
            // 
            this.Payerchkbx.AutoSize = true;
            this.Payerchkbx.Location = new System.Drawing.Point(278, 245);
            this.Payerchkbx.Name = "Payerchkbx";
            this.Payerchkbx.Size = new System.Drawing.Size(90, 17);
            this.Payerchkbx.TabIndex = 5;
            this.Payerchkbx.Text = "Плательщик";
            this.Payerchkbx.UseVisualStyleBackColor = true;
            // 
            // Userchkbx
            // 
            this.Userchkbx.AutoSize = true;
            this.Userchkbx.Location = new System.Drawing.Point(411, 245);
            this.Userchkbx.Name = "Userchkbx";
            this.Userchkbx.Size = new System.Drawing.Size(200, 17);
            this.Userchkbx.TabIndex = 6;
            this.Userchkbx.Text = "Пользователь ПС \"Учёт гаражей\"";
            this.Userchkbx.UseVisualStyleBackColor = true;
            this.Userchkbx.CheckedChanged += new System.EventHandler(this.Userchkbx_CheckedChanged);
            // 
            // FIOtxtbx
            // 
            this.FIOtxtbx.Location = new System.Drawing.Point(113, 19);
            this.FIOtxtbx.Name = "FIOtxtbx";
            this.FIOtxtbx.Size = new System.Drawing.Size(447, 20);
            this.FIOtxtbx.TabIndex = 7;
            // 
            // Phonetxtbx
            // 
            this.Phonetxtbx.Location = new System.Drawing.Point(113, 62);
            this.Phonetxtbx.Name = "Phonetxtbx";
            this.Phonetxtbx.Size = new System.Drawing.Size(447, 20);
            this.Phonetxtbx.TabIndex = 8;
            this.Phonetxtbx.TextChanged += new System.EventHandler(this.Phonetxtbx_TextChanged);
            // 
            // Addrtxtbx
            // 
            this.Addrtxtbx.Location = new System.Drawing.Point(113, 110);
            this.Addrtxtbx.Name = "Addrtxtbx";
            this.Addrtxtbx.Size = new System.Drawing.Size(447, 20);
            this.Addrtxtbx.TabIndex = 9;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::SGC_garages.Properties.Resources.save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(115, 282);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 27);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(431, 282);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(129, 27);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Location = new System.Drawing.Point(20, 162);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Size = new System.Drawing.Size(73, 13);
            this.NoteLbl.TabIndex = 12;
            this.NoteLbl.Text = "Примечания:";
            // 
            // Notetxtbx
            // 
            this.Notetxtbx.Location = new System.Drawing.Point(113, 159);
            this.Notetxtbx.Name = "Notetxtbx";
            this.Notetxtbx.Size = new System.Drawing.Size(447, 20);
            this.Notetxtbx.TabIndex = 13;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(272, 282);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 27);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Enabled = false;
            this.LoginLbl.Location = new System.Drawing.Point(56, 208);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(41, 13);
            this.LoginLbl.TabIndex = 15;
            this.LoginLbl.Text = "Логин:";
            // 
            // logintxtbx
            // 
            this.logintxtbx.Enabled = false;
            this.logintxtbx.Location = new System.Drawing.Point(112, 205);
            this.logintxtbx.Name = "logintxtbx";
            this.logintxtbx.Size = new System.Drawing.Size(448, 20);
            this.logintxtbx.TabIndex = 16;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 331);
            this.Controls.Add(this.logintxtbx);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Notetxtbx);
            this.Controls.Add(this.NoteLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Addrtxtbx);
            this.Controls.Add(this.Phonetxtbx);
            this.Controls.Add(this.FIOtxtbx);
            this.Controls.Add(this.Userchkbx);
            this.Controls.Add(this.Payerchkbx);
            this.Controls.Add(this.Ownerchkbx);
            this.Controls.Add(this.AddrLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.FIOLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить персону в справочники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIOLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label AddrLbl;
        private System.Windows.Forms.CheckBox Ownerchkbx;
        private System.Windows.Forms.CheckBox Payerchkbx;
        private System.Windows.Forms.CheckBox Userchkbx;
        private System.Windows.Forms.TextBox FIOtxtbx;
        private System.Windows.Forms.TextBox Phonetxtbx;
        private System.Windows.Forms.TextBox Addrtxtbx;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.TextBox Notetxtbx;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.TextBox logintxtbx;
    }
}