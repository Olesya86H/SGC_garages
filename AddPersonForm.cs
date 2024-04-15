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
    public partial class AddPersonForm : Form
    {
        UserClass userClass = new UserClass();
        public string senderName = "";
        DataTable dt = new DataTable();
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void Phonetxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            PersonClass personClass = new PersonClass();

            //считываем данные:           
            Class_Conn class_Conn = new Class_Conn();
            personClass.set_null();

            if (FIOtxtbx.Text != "")
                personClass.FIO = FIOtxtbx.Text;
            else
                personClass.FIO = "null";

            if (Phonetxtbx.Text != "")
                personClass.phone_number = Phonetxtbx.Text;
            else
                personClass.phone_number = "null";

            if (Addrtxtbx.Text != "")
                personClass.address = Addrtxtbx.Text;
            else
                personClass.address = "null";

            if (Notetxtbx.Text != "")
                personClass.note = Notetxtbx.Text;
            else
                personClass.note = "null";

            if (Ownerchkbx.Checked == true)
                personClass.is_owner = 1;
            else
                personClass.is_owner = 0;

            if (Payerchkbx.Checked == true)
                personClass.is_payer = 1;
            else
                personClass.is_payer = 0;

            if (Userchkbx.Checked == true)
                personClass.is_user = 1;
            else
                personClass.is_user = 0;

            personClass.id_person = 0;

            //вносим изменения в БД:
            try
            {
                if (Userchkbx.Checked == true)
                {
                    class_Conn.ExecSQLStr("insert into public.s_users (date_reg, login, note) values (current_date, '" + logintxtbx.Text +"', '')");
                }
                class_Conn.ExecSQLStr("insert into public.s_persons (fio, phone_number, address, note, is_owner, is_payer, is_user) values (" +
                class_Conn.neither_quoke(personClass.FIO) + "," +
                class_Conn.neither_quoke(personClass.phone_number) + "," +
                class_Conn.neither_quoke(personClass.address) + "," +
                class_Conn.neither_quoke(personClass.note) + "," +
                personClass.is_owner.ToString() + "," +
                personClass.is_payer.ToString() + "," +
                personClass.is_user.ToString() +
                ")");

                if (Userchkbx.Checked == true)
                {
                    class_Conn.ExecSQLStr("update public.s_users set id_person = (select max(id_person) from s_persons) where login = '" + logintxtbx.Text + "'");
                }
                if (senderName == "GeneralPersonsListForm") //фильтрация по sender'у - Общий список ФИО
                {
                    SGC_garages.GeneralPersonsListForm.s_personsTableAdapter.Fill(SGC_garages.GeneralPersonsListForm.sPersonsDS.s_persons);
                    SGC_garages.GeneralPersonsListForm.FIOListgrd.DataSource = SGC_garages.GeneralPersonsListForm.sPersonsDS.s_persons;
                    SGC_garages.GeneralPersonsListForm.FIOListgrd.Refresh();
                }
                if (senderName == "OwnersForm") //фильтрация по sender'у - Справочник Собственников из общих справочников
                {
                    SGC_garages.OwnersForm.s_OwnersTableAdapter.Fill(SGC_garages.OwnersForm.s_OwnersDS.s_persons);
                    SGC_garages.OwnersForm.FIOOwnersgrd.DataSource = SGC_garages.OwnersForm.s_OwnersDS.s_persons;
                    SGC_garages.OwnersForm.FIOOwnersgrd.Refresh();
                }
                if (senderName == "OwnersFormNewGar") //фильтрация по sender'у - Справочник Собственников из формы заведения нового гаража
                {
                    SGC_garages.NewGarageForm.s_personsTableAdapter.Fill(SGC_garages.NewGarageForm.sPer_NewGarDS.s_persons);
                    SGC_garages.NewGarageForm.Ownercmbbx.DataSource = SGC_garages.NewGarageForm.sPer_NewGarDS.s_persons;
                    SGC_garages.NewGarageForm.Ownercmbbx.Refresh();
                }
                if (senderName == "PayersForm") //фильтрация по sender'у - Справочник Плательщиков из общих справочников
                {
                    SGC_garages.PayersForm.s_payersTableAdapter.Fill(SGC_garages.PayersForm.s_payersDS.s_persons);
                    SGC_garages.PayersForm.FIOPayersgrd.DataSource = SGC_garages.PayersForm.s_payersDS.s_persons;
                    SGC_garages.PayersForm.FIOPayersgrd.Refresh();
                }
                if (senderName == "PayersFormNewPay") //фильтрация по sender'у - Справочник Плательщиков из формы заведения нового платежа
                {
                    SGC_garages.NewPaymentForm.s_personsTableAdapter1.Fill(SGC_garages.NewPaymentForm.sPerP.s_persons);
                    SGC_garages.NewPaymentForm.PayerCmbbx.DataSource = SGC_garages.NewPaymentForm.sPerP.s_persons;
                    SGC_garages.NewPaymentForm.PayerCmbbx.Refresh();
                }
                if (senderName == "UsersForm") //фильтрация по sender'у - Справочник Пользователей системы
                {
                    SGC_garages.UsersListForm.s_UsersTableAdapter.Fill(SGC_garages.UsersListForm.s_UsersDS.s_persons);
                    SGC_garages.UsersListForm.FIOUsersgrd.DataSource = SGC_garages.UsersListForm.s_UsersDS.s_persons;
                    SGC_garages.UsersListForm.FIOUsersgrd.Refresh();
                }

                MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userClass.log_info("data added to s_persons", "FIO of person = " + personClass.FIO + ", " + senderName);
                if (Userchkbx.Checked == true)
                    userClass.log_info("data added to s_users", "login = " + logintxtbx.Text + ", " + senderName);
            }
            catch 
            {
                userClass.log_info("data not added to s_persons", "FIO of person = " + personClass.FIO + ", " + senderName);
                if (Userchkbx.Checked == true)
                    userClass.log_info("data not added to s_users", "login = " + logintxtbx.Text + ", " + senderName);
                MessageBox.Show("Данные не сохранены!" + Environment.NewLine + "При сохранении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            personClass.set_null();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FIOtxtbx.Text = "";
            Phonetxtbx.Text = "";
            Addrtxtbx.Text = "";
            Notetxtbx.Text = "";
            Ownerchkbx.Checked = false;
            Payerchkbx.Checked = false;
            Userchkbx.Checked = false;
        }

        private void Userchkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Userchkbx.Checked == true)
            {
                logintxtbx.Enabled = true;
                LoginLbl.Enabled = true;
            }
            else
            {
                logintxtbx.Enabled = false;
                LoginLbl.Enabled = false;
            }
        }
       
    }
}
