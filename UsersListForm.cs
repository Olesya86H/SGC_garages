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
    public partial class UsersListForm : Form
    {
        UserClass userClass = new UserClass();
        string action = "";
        int row_inx = 0;
        int col_inx = 0;
        DataTable dt = new DataTable();
        public UsersListForm()
        {
            InitializeComponent();
        }
        private void get_data()
        {
            //в таблицу dt заносим данные, над которыми совершаем действие до сохранения
            int cnt = 0;
            //добавляем запись в dt:
            dt.Rows.Add();
            cnt = dt.Rows.Count;
            FIOUsersgrd.CommitEdit(DataGridViewDataErrorContexts.Commit); // применяем изменения
            if (FIOUsersgrd.Rows.Count > 0)
            {
                dt.Rows[cnt - 1].SetField(dt.Columns[0], FIOUsersgrd.Rows[row_inx].Cells[0].Value.ToString()); //ФИО
                dt.Rows[cnt - 1].SetField(dt.Columns[1], FIOUsersgrd.Rows[row_inx].Cells[1].Value.ToString()); //Телефон
                dt.Rows[cnt - 1].SetField(dt.Columns[2], FIOUsersgrd.Rows[row_inx].Cells[2].Value.ToString()); //Адрес
                dt.Rows[cnt - 1].SetField(dt.Columns[3], FIOUsersgrd.Rows[row_inx].Cells[3].Value.ToString()); //Примечания
                dt.Rows[cnt - 1].SetField(dt.Columns[4], FIOUsersgrd.Rows[row_inx].Cells[4].Value.ToString()); //Собственник
                dt.Rows[cnt - 1].SetField(dt.Columns[5], "1"); //Плательщик
                dt.Rows[cnt - 1].SetField(dt.Columns[6], FIOUsersgrd.Rows[row_inx].Cells[6].Value.ToString()); //Пользователь ПС
                dt.Rows[cnt - 1].SetField(dt.Columns[7], FIOUsersgrd.Rows[row_inx].Cells[7].Value.ToString()); //ID
                dt.Rows[cnt - 1].SetField(dt.Columns[8], this.action);
            }
            this.action = ""; //обнуляем действие
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "s_UsersDS.s_persons". При необходимости она может быть перемещена или удалена.
            s_UsersTableAdapter.Fill(s_UsersDS.s_persons);
            for (int i = 0; i <= 8; i++) //добавляем информацию о персоне: фио, телефон, адрес, примечание, признак - собственник, признак - плательщик, признак - пользователь проги, id (если есть в БД), действие над записью
            {
                dt.Columns.Add();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.senderName = "UsersForm";
            addPersonForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.action = "remove";
            get_data();
            FIOUsersgrd.Rows.RemoveAt(row_inx);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FIOUsersgrd_RowLeave(this, null);
            }
            catch { }

            PersonClass personClass = new PersonClass();

            //вносим изменения в БД:           
            if (dt.Rows.Count > 0)
            {
                Class_Conn class_Conn = new Class_Conn();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    personClass.set_null();

                    if (dt.Rows[i].ItemArray[0].ToString() != "")
                        personClass.FIO = dt.Rows[i].ItemArray[0].ToString();
                    else
                        personClass.FIO = "null";

                    if (dt.Rows[i].ItemArray[1].ToString() != "")
                        personClass.phone_number = dt.Rows[i].ItemArray[1].ToString();
                    else
                        personClass.phone_number = "null";

                    if (dt.Rows[i].ItemArray[2].ToString() != "")
                        personClass.address = dt.Rows[i].ItemArray[2].ToString();
                    else
                        personClass.address = "null";

                    if (dt.Rows[i].ItemArray[3].ToString() != "")
                        personClass.note = dt.Rows[i].ItemArray[3].ToString();
                    else
                        personClass.note = "null";

                    if (dt.Rows[i].ItemArray[4].ToString() == "1")
                        personClass.is_owner = 1;//Convert.ToInt32(dt.Rows[i].ItemArray[4].ToString());
                    else
                        personClass.is_owner = 0;

                    if (dt.Rows[i].ItemArray[5].ToString() == "1")
                        personClass.is_payer = 1;//Convert.ToInt32(dt.Rows[i].ItemArray[5].ToString());
                    else
                        personClass.is_payer = 0;

                    if (dt.Rows[i].ItemArray[6].ToString() == "1")
                        personClass.is_user = 1;//Convert.ToInt32(dt.Rows[i].ItemArray[6].ToString());
                    else
                        personClass.is_user = 0;

                    if (dt.Rows[i].ItemArray[7].ToString() != "")
                        personClass.id_person = Convert.ToInt32(dt.Rows[i].ItemArray[7].ToString());
                    else
                        personClass.id_person = 0;

                    if (dt.Rows[i].ItemArray[8].ToString() == "remove")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("delete from public.s_persons where id_person = " + personClass.id_person.ToString());
                            class_Conn.ExecSQLStr("delete from public.s_users where id_person = " + personClass.id_person.ToString());
                            MessageBox.Show("Данные удалены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data deleted from s_persons", "id_person = " + personClass.id_person.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not deleted from s_persons", "id_person = " + personClass.id_person.ToString());
                            MessageBox.Show("Данные не удалены!" + Environment.NewLine + "При удалении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    if (dt.Rows[i].ItemArray[8].ToString() == "upd")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("update public.s_persons set fio = " + class_Conn.neither_quoke(personClass.FIO) + ", " +
                                                                            "phone_number = " + class_Conn.neither_quoke(personClass.phone_number) + ", " +
                                                                            "address = " + class_Conn.neither_quoke(personClass.address) + ", " +
                                                                            "note = " + class_Conn.neither_quoke(personClass.note) + ", " +
                                                                            "is_owner = " + personClass.is_owner.ToString() + ", " +
                                                                            "is_payer = " + personClass.is_payer.ToString() + ", " +
                                                                            "is_user  = " + personClass.is_user.ToString() +
                                                " where id_person = " + personClass.id_person.ToString());
                            MessageBox.Show("Изменения успешно применены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data updated in s_persons", "id_person = " + personClass.id_person.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not updated in s_persons", "id_person = " + personClass.id_person.ToString());
                            MessageBox.Show("Данные не изменены!" + Environment.NewLine + "При изменении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };

                }

                //очищаем таблицу:
                try
                {
                    dt.Clear();
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        dt.Rows.RemoveAt(i);
                    }
                }
                catch { }

                s_UsersTableAdapter.Fill(s_UsersDS.s_persons);
                FIOUsersgrd.DataSource = s_UsersDS.s_persons;
                FIOUsersgrd.Refresh();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "UsersForm";
            formGenFind.Show();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s_UsersTableAdapter.Fill(s_UsersDS.s_persons);
            FIOUsersgrd.DataSource = s_UsersDS.s_persons;
            FIOUsersgrd.Refresh();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIOUsersgrd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
            DataGridViewCell cell = FIOUsersgrd.Rows[row_inx].Cells[col_inx];
            FIOUsersgrd.CurrentCell = cell;
            this.action = "upd";
        }

        private void FIOUsersgrd_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void FIOUsersgrd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //получаем индекс строки, над которой совершали действия, и которая потеряла фокус
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
        }

        private void FIOUsersgrd_Leave(object sender, EventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }
    }
}
