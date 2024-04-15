
namespace SGC_garages
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ReportNametxtbx = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateEndMtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBegMtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование отчёта:";
            // 
            // ReportNametxtbx
            // 
            this.ReportNametxtbx.Enabled = false;
            this.ReportNametxtbx.Location = new System.Drawing.Point(149, 18);
            this.ReportNametxtbx.Name = "ReportNametxtbx";
            this.ReportNametxtbx.Size = new System.Drawing.Size(346, 20);
            this.ReportNametxtbx.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Location = new System.Drawing.Point(68, 116);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(135, 33);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Сформировать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(374, 116);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(135, 33);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(221, 116);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(135, 33);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Период:";
            // 
            // DateEndMtxtbx
            // 
            this.DateEndMtxtbx.Location = new System.Drawing.Point(275, 50);
            this.DateEndMtxtbx.Mask = "00.00.0000";
            this.DateEndMtxtbx.Name = "DateEndMtxtbx";
            this.DateEndMtxtbx.Size = new System.Drawing.Size(100, 20);
            this.DateEndMtxtbx.TabIndex = 5;
            this.DateEndMtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // DateBegMtxtbx
            // 
            this.DateBegMtxtbx.Location = new System.Drawing.Point(149, 50);
            this.DateBegMtxtbx.Mask = "00.00.0000";
            this.DateBegMtxtbx.Name = "DateBegMtxtbx";
            this.DateBegMtxtbx.Size = new System.Drawing.Size(100, 20);
            this.DateBegMtxtbx.TabIndex = 3;
            this.DateBegMtxtbx.ValidatingType = typeof(System.DateTime);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 180);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DateEndMtxtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateBegMtxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReportNametxtbx);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры отчёта";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReportNametxtbx;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DateEndMtxtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DateBegMtxtbx;
    }
}