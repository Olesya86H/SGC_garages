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
    public partial class AddFareValueForm : Form
    {
        public AddFareValueForm()
        {
            InitializeComponent();
        }

        private void AddFareValueForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sSi_DS.s_si". При необходимости она может быть перемещена или удалена.
            this.s_siTableAdapter.Fill(this.sSi_DS.s_si);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sGarTypeDS.s_garage_types". При необходимости она может быть перемещена или удалена.
            this.s_garage_typesTableAdapter.Fill(this.sGarTypeDS.s_garage_types);
            if (AccFareValueShClass.name_account != "")
            {
                try
                {
                    Class_Conn class_Conn = new Class_Conn();
                    string ls_type_acc = "";
                    ls_type_acc = class_Conn.ExecSQLStr("select name_account_type from s_account_type where id_account_type = " + AccFareValueShClass.id_type_account.ToString());
                    AccNametxtbx.Text = AccFareValueShClass.name_account;
                    AccTypetxtbx.Text = ls_type_acc;
                }
                catch
                {
                    MessageBox.Show("Ошибка при выборке типа статьи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не выбрана статья для ввода тарифной ставки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            GarTypecmbbx.Text = "";
            FareValuetxtbx.Text = "";
            DateOnMtxtbx.Text = "01.01.1900";
            DateOffMtxtbx.Text = "01.01.3000";
            SiCmbx.Text = "";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {  
                string ls_dateon = "01.01.1900";
                string ls_dateoff = "01.01.3000";
                string ls_fare_value = "0";
                string ls_id_si = "0";
                string ls_id_garage_type = "0";
                if (DateOnMtxtbx.Text != "")
                    ls_dateon = DateOnMtxtbx.Text;
                if (DateOffMtxtbx.Text != "")
                    ls_dateoff = DateOffMtxtbx.Text;
                if (FareValuetxtbx.Text != "")
                    ls_fare_value = FareValuetxtbx.Text;
                if (SiCmbx.Text != "")
                    ls_id_si = SiCmbx.ValueMember.ToString();
                if (GarTypecmbbx.Text != "")
                    ls_id_garage_type = GarTypecmbbx.ValueMember.ToString();

                Class_Conn class_Conn = new Class_Conn();
                class_Conn.ExecSQLStr("insert into t_acc_value (id_account, date_on, date_off, value_fare, id_si, id_garage_type) " +
                                      "values(" + AccFareValueShClass.id_account.ToString() + 
                                                ", to_date('" + ls_dateon + "', 'dd.mm.yyyy'), " +
                                                ", to_date('" + ls_dateoff + "', 'dd.mm.yyyy'), " +
                                                ", " + ls_fare_value +
                                                ", " + ls_id_si +
                                                ", " + ls_id_garage_type + ")");
            }
            catch 
            {
                MessageBox.Show("При сохранении тарифа произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
