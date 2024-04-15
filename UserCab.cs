using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SGC_garages
{
    public partial class UserCab : Form
    {
        UserClass userClass = new UserClass();
        int id_user = 0;
        int id_person = 0;
        public UserCab()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Conn cl_conn = new Class_Conn();

                cl_conn.ExecSQLStr("update s_persons set fio = '" + FIOtxtbx.Text + "' where id_person = " + id_person.ToString());
                cl_conn.ExecSQLStr("update s_persons set phone_number = '" + Phonetxtbx.Text + "' where id_person = " + id_person.ToString());
                cl_conn.ExecSQLStr("update s_persons set address = '" + Addrtxtbx.Text + "' where id_person = " + id_person.ToString());
                cl_conn.ExecSQLStr("update s_persons set note = '" + note1txtbx.Text + "' where id_person = " + id_person.ToString());
                cl_conn.ExecSQLStr("update s_users set note = '" + note2txtbx.Text + "' where id_user = " + id_user.ToString());

                FIOtxtbx.Enabled = false;
                Phonetxtbx.Enabled = false;
                Addrtxtbx.Enabled = false;
                note1txtbx.Enabled = false;
                note2txtbx.Enabled = false;

                MessageBox.Show("Изменения успешно применены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userClass.log_info("data updated in lk", "");
            }
            catch
            {
                userClass.log_info("data not updated in lk", "");
                MessageBox.Show("Изменения не применены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void написатьВПоддержкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessForm sendMessForm = new SendMessForm();
            sendMessForm.Show();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FIOtxtbx.Enabled = true;
            Phonetxtbx.Enabled = true;
            Addrtxtbx.Enabled = true;
            note1txtbx.Enabled = true;
            note2txtbx.Enabled = true;
        }

        private void refresh_lk()
        {            
            //таблица логирования для данного пользователя системы:
            string find_sql = "SELECT sp.fio, su.login, l.action, l.date_act, sp.phone_number, l.note, l.id_log, l.id_user " +
                              "FROM t_log l, s_users su, s_persons sp " +
                              "where sp.id_person = su.id_person " +
                              "and l.id_user = su.id_user " +
                              "and su.login = '" + userClass.GetLogin() + "'" +
                              "order by date_act desc";

            Class_Conn cl_conn = new Class_Conn();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            npgsqlDataAdapter.SelectCommand = npgsqlCommand;
            DataTable dt_find = new DataTable();
            npgsqlDataAdapter.Fill(dt_find);
            tLoggrd.DataSource = dt_find;
            tLoggrd.Refresh();

            //поля в ЛК:
            string find_lk_data = "SELECT sp.fio, sp.phone_number, sp.address, su.login, su.date_reg, su.note as note1, sp.note as note2, su.id_user, su.id_person " +
                                    "FROM s_users su, s_persons sp " +
                                    "where sp.id_person = su.id_person " +
                                    "and su.login = '" + userClass.GetLogin() + "'" ;
            
            NpgsqlCommand npgsqlCommand_lk = new NpgsqlCommand(find_lk_data, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlLKDataAdapter = new NpgsqlDataAdapter();
            npgsqlLKDataAdapter.SelectCommand = npgsqlCommand_lk;
            DataTable dt_find_lk_data = new DataTable();
            npgsqlLKDataAdapter.Fill(dt_find_lk_data);

            for (int i = 0; i <= dt_find_lk_data.Rows.Count - 1; i++)
            {
                FIOtxtbx.Text = dt_find_lk_data.Rows[i].ItemArray[0].ToString();
                Phonetxtbx.Text = dt_find_lk_data.Rows[i].ItemArray[1].ToString();
                Addrtxtbx.Text = dt_find_lk_data.Rows[i].ItemArray[2].ToString();
                note1txtbx.Text = dt_find_lk_data.Rows[i].ItemArray[5].ToString();
                note2txtbx.Text = dt_find_lk_data.Rows[i].ItemArray[6].ToString();
                id_user = Convert.ToInt32(dt_find_lk_data.Rows[i].ItemArray[7].ToString());
                id_person = Convert.ToInt32(dt_find_lk_data.Rows[i].ItemArray[8].ToString());
            }

            //закрываем от редактирования поля в ЛК:
            FIOtxtbx.Enabled = false;
            Phonetxtbx.Enabled = false;
            Addrtxtbx.Enabled = false;
            note1txtbx.Enabled = false;
            note2txtbx.Enabled = false;
        }

        private void UserCab_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tLogUserDS.t_log". При необходимости она может быть перемещена или удалена.
            //this.t_logUserTableAdapter.Fill(this.tLogUserDS.t_log);
            refresh_lk();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh_lk();
        }
    }
}
