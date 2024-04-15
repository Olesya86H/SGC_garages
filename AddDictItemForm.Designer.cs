
namespace SGC_garages
{
    partial class AddDictItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDictItemForm));
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Notetxtbx = new System.Windows.Forms.TextBox();
            this.NoteLbl = new System.Windows.Forms.Label();
            this.Nametxtbx = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.ClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearBtn.Location = new System.Drawing.Point(219, 154);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(129, 27);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::SGC_garages.Properties.Resources.delete;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(370, 154);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(129, 27);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::SGC_garages.Properties.Resources.save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(74, 154);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(129, 27);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Notetxtbx
            // 
            this.Notetxtbx.Location = new System.Drawing.Point(100, 91);
            this.Notetxtbx.Name = "Notetxtbx";
            this.Notetxtbx.Size = new System.Drawing.Size(399, 20);
            this.Notetxtbx.TabIndex = 21;
            // 
            // NoteLbl
            // 
            this.NoteLbl.AutoSize = true;
            this.NoteLbl.Location = new System.Drawing.Point(7, 94);
            this.NoteLbl.Name = "NoteLbl";
            this.NoteLbl.Size = new System.Drawing.Size(73, 13);
            this.NoteLbl.TabIndex = 20;
            this.NoteLbl.Text = "Примечания:";
            // 
            // Nametxtbx
            // 
            this.Nametxtbx.Location = new System.Drawing.Point(100, 26);
            this.Nametxtbx.Name = "Nametxtbx";
            this.Nametxtbx.Size = new System.Drawing.Size(399, 20);
            this.Nametxtbx.TabIndex = 19;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(20, 26);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(60, 13);
            this.NameLbl.TabIndex = 18;
            this.NameLbl.Text = "Название:";
            // 
            // AddDictItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 211);
            this.Controls.Add(this.Notetxtbx);
            this.Controls.Add(this.NoteLbl);
            this.Controls.Add(this.Nametxtbx);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDictItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить элемент в справочник";
            this.Load += new System.EventHandler(this.AddDictItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox Notetxtbx;
        private System.Windows.Forms.Label NoteLbl;
        private System.Windows.Forms.TextBox Nametxtbx;
        private System.Windows.Forms.Label NameLbl;
    }
}