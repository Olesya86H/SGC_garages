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
    public partial class NewGarageForm : Form
    {
        public NewGarageForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGarageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sPer_NewGarDS.s_persons". При необходимости она может быть перемещена или удалена.
            s_personsTableAdapter.Fill(sPer_NewGarDS.s_persons);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sGarTypeDS.s_garage_types". При необходимости она может быть перемещена или удалена.
            this.s_garage_typesTableAdapter.Fill(this.sGarTypeDS.s_garage_types);

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NumGartxtbx.Text = "";
            TypeGarTxtbx.Text = "";
            Ownercmbbx.Text = "";
        }

        private void AddOwnerBtn_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.senderName = "OwnersFormNewGar";
            addPersonForm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            GarageClass.setnull();
            try
            {
                GarageClass.num = NumGartxtbx.Text;
                GarageClass.address = Addrrtxtbx.Text;
                GarageClass.note = notetxtbx.Text;
                GarageClass.id_type = Convert.ToInt32(TypeGarTxtbx.SelectedValue.ToString());
                GarageClass.id_owner = Convert.ToInt32(Ownercmbbx.SelectedValue.ToString());
                Class_Conn class_Conn = new Class_Conn();
                class_Conn.ExecSQLStr(@"insert into t_garages (id_owner, id_garage_type, num, address, note, date_in) 
                                    values (" + GarageClass.id_owner.ToString() +
                                        "," + GarageClass.id_type.ToString() +
                                        "," + GarageClass.num.ToString() +
                                        "," + GarageClass.address +
                                        "," + GarageClass.note +
                                        "," + DateTime.Today.ToString() +
                                        ")");
                UserClass userClass = new UserClass();
                userClass.log_info("Заведён новый гараж", "Номер гаража = " + GarageClass.num.ToString() + ", тип гаража = " + GarageClass.id_type.ToString() + "id собственника = " + GarageClass.id_owner.ToString() + ", дата записи: " + DateTime.Today.ToString());
            }
            catch 
            {
                MessageBox.Show("Проверьте правильность введённых данных!","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GarageClass.setnull();
        }
    }
}
