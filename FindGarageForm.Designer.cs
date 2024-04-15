
namespace SGC_garages
{
    partial class FindGarageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindGarageForm));
            this.GarageNumberlbl = new System.Windows.Forms.Label();
            this.TypeGaragebl = new System.Windows.Forms.Label();
            this.typegaragecmbbx = new System.Windows.Forms.ComboBox();
            this.GarageNumbercmbbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GarageOwnerlbl = new System.Windows.Forms.Label();
            this.GarageOwnercmbbx = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GarageNumberlbl
            // 
            this.GarageNumberlbl.AutoSize = true;
            this.GarageNumberlbl.Location = new System.Drawing.Point(42, 22);
            this.GarageNumberlbl.Name = "GarageNumberlbl";
            this.GarageNumberlbl.Size = new System.Drawing.Size(84, 13);
            this.GarageNumberlbl.TabIndex = 0;
            this.GarageNumberlbl.Text = "Номер гаража:";
            // 
            // TypeGaragebl
            // 
            this.TypeGaragebl.AutoSize = true;
            this.TypeGaragebl.Location = new System.Drawing.Point(57, 66);
            this.TypeGaragebl.Name = "TypeGaragebl";
            this.TypeGaragebl.Size = new System.Drawing.Size(69, 13);
            this.TypeGaragebl.TabIndex = 1;
            this.TypeGaragebl.Text = "Тип гаража:";
            // 
            // typegaragecmbbx
            // 
            this.typegaragecmbbx.FormattingEnabled = true;
            this.typegaragecmbbx.Location = new System.Drawing.Point(132, 63);
            this.typegaragecmbbx.Name = "typegaragecmbbx";
            this.typegaragecmbbx.Size = new System.Drawing.Size(295, 21);
            this.typegaragecmbbx.TabIndex = 2;
            // 
            // GarageNumbercmbbx
            // 
            this.GarageNumbercmbbx.FormattingEnabled = true;
            this.GarageNumbercmbbx.Location = new System.Drawing.Point(132, 19);
            this.GarageNumbercmbbx.Name = "GarageNumbercmbbx";
            this.GarageNumbercmbbx.Size = new System.Drawing.Size(295, 21);
            this.GarageNumbercmbbx.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::SGC_garages.Properties.Resources.find;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(45, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GarageOwnerlbl
            // 
            this.GarageOwnerlbl.AutoSize = true;
            this.GarageOwnerlbl.Location = new System.Drawing.Point(27, 117);
            this.GarageOwnerlbl.Name = "GarageOwnerlbl";
            this.GarageOwnerlbl.Size = new System.Drawing.Size(99, 13);
            this.GarageOwnerlbl.TabIndex = 5;
            this.GarageOwnerlbl.Text = "Владелец гаража:";
            // 
            // GarageOwnercmbbx
            // 
            this.GarageOwnercmbbx.FormattingEnabled = true;
            this.GarageOwnercmbbx.Location = new System.Drawing.Point(132, 114);
            this.GarageOwnercmbbx.Name = "GarageOwnercmbbx";
            this.GarageOwnercmbbx.Size = new System.Drawing.Size(295, 21);
            this.GarageOwnercmbbx.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Image = global::SGC_garages.Properties.Resources.recycle_bin_sign;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(200, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::SGC_garages.Properties.Resources.delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(352, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FindGarageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 211);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GarageOwnercmbbx);
            this.Controls.Add(this.GarageOwnerlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GarageNumbercmbbx);
            this.Controls.Add(this.typegaragecmbbx);
            this.Controls.Add(this.TypeGaragebl);
            this.Controls.Add(this.GarageNumberlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindGarageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск гаража";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GarageNumberlbl;
        private System.Windows.Forms.Label TypeGaragebl;
        private System.Windows.Forms.ComboBox typegaragecmbbx;
        private System.Windows.Forms.ComboBox GarageNumbercmbbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GarageOwnerlbl;
        private System.Windows.Forms.ComboBox GarageOwnercmbbx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}