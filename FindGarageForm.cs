using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_garages
{
    public partial class FindGarageForm : Form
    {
        public FindGarageForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GarageClass.setnull();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GarageNumbercmbbx.Text = "";
            typegaragecmbbx.Text = "";
            GarageOwnercmbbx.Text = "";
            GarageClass.setnull();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GarageClass.id = 1;
            //заполняем поля гаража, находим его id
            GarageForm garageForm = new GarageForm();
            garageForm.Show();
        }
    }
}
