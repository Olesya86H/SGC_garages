
namespace SGC_garages
{
    partial class FormGenFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenFind));
            this.StrLbl = new System.Windows.Forms.Label();
            this.Findtxtbx = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrLbl
            // 
            this.StrLbl.AutoSize = true;
            this.StrLbl.Location = new System.Drawing.Point(25, 33);
            this.StrLbl.Name = "StrLbl";
            this.StrLbl.Size = new System.Drawing.Size(85, 13);
            this.StrLbl.TabIndex = 0;
            this.StrLbl.Text = "Строка поиска:";
            // 
            // Findtxtbx
            // 
            this.Findtxtbx.Location = new System.Drawing.Point(116, 30);
            this.Findtxtbx.Name = "Findtxtbx";
            this.Findtxtbx.Size = new System.Drawing.Size(326, 20);
            this.Findtxtbx.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(278, 75);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(118, 30);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FindBtn
            // 
            this.FindBtn.Image = global::SGC_garages.Properties.Resources.find;
            this.FindBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindBtn.Location = new System.Drawing.Point(143, 75);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(118, 30);
            this.FindBtn.TabIndex = 3;
            this.FindBtn.Text = "Поиск";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // FormGenFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 129);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Findtxtbx);
            this.Controls.Add(this.StrLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGenFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задайте строку поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StrLbl;
        private System.Windows.Forms.TextBox Findtxtbx;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button FindBtn;
    }
}