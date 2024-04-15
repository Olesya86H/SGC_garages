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
    public partial class AddAccForm : Form
    {
        public AddAccForm()
        {
            InitializeComponent();
        }

        private void AddAccForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAccTypeDS.s_account_type". При необходимости она может быть перемещена или удалена.
            this.s_account_typeTableAdapter.Fill(this.sAccTypeDS.s_account_type);

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AccNametxtbx.Text = "";
            AccTypecmbbx.Text = "";
            Notetxtbx.Text = "";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            AccClass accClass = new AccClass();
            UserClass userClass = new UserClass();
            //считываем данные:           
            Class_Conn class_Conn = new Class_Conn();
            accClass.set_null();

            if (AccNametxtbx.Text != "")
                accClass.name_account = AccNametxtbx.Text;
            else
                accClass.name_account = "null";

            if (Notetxtbx.Text != "")
                accClass.note = Notetxtbx.Text;
            else
                accClass.note = "null";

            if (AccTypecmbbx.Text != "")
                accClass.id_type_account = Convert.ToInt32(AccTypecmbbx.ValueMember.ToString());
            else
                accClass.id_type_account = 0;

            accClass.id_account = 0;

            //вносим изменения в БД:
            try
            {                
                class_Conn.ExecSQLStr("insert into public.s_account (name_account, note, id_type_account) values (" +
                class_Conn.neither_quoke(accClass.name_account) + "," +
                accClass.id_type_account + "," +
                class_Conn.neither_quoke(accClass.note) + 
                ")");

                SGC_garages.AccountForm.s_accountTableAdapter.Fill(SGC_garages.AccountForm.sAccDS.s_account);
                SGC_garages.AccountForm.AccGrd.DataSource = SGC_garages.AccountForm.sAccDS.s_account;
                SGC_garages.AccountForm.AccGrd.Refresh();

                MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userClass.log_info("data added to s_account", "name of account = " + accClass.name_account);                
            }
            catch
            {
                userClass.log_info("data not added to s_account", "name of account = " + accClass.name_account);
                MessageBox.Show("Данные не сохранены!" + Environment.NewLine + "При сохранении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            accClass.set_null();
        }
    }
}
