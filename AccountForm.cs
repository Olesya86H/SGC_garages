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
    public partial class AccountForm : Form
    {
        UserClass userClass = new UserClass();
        string action = "";
        int row_inx = 0;
        int col_inx = 0;
        DataTable dt = new DataTable();

        public AccountForm()
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
            AccGrd.CommitEdit(DataGridViewDataErrorContexts.Commit); // применяем изменения
            if (AccGrd.Rows.Count > 0)
            {
                dt.Rows[cnt - 1].SetField(dt.Columns[0], AccGrd.Rows[row_inx].Cells[0].Value.ToString()); //Наименование
                dt.Rows[cnt - 1].SetField(dt.Columns[2], AccGrd.Rows[row_inx].Cells[2].Value.ToString()); //Тип статьи
                dt.Rows[cnt - 1].SetField(dt.Columns[1], AccGrd.Rows[row_inx].Cells[1].Value.ToString()); //Примечание                
                dt.Rows[cnt - 1].SetField(dt.Columns[4], AccGrd.Rows[row_inx].Cells[4].Value.ToString()); //ID
                dt.Rows[cnt - 1].SetField(dt.Columns[5], this.action);
            }
            this.action = ""; //обнуляем действие
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAccDS.s_account". При необходимости она может быть перемещена или удалена.
            s_accountTableAdapter.Fill(sAccDS.s_account);

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccForm addAccForm = new AddAccForm();
            addAccForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.action = "remove";
            get_data();
            AccGrd.Rows.RemoveAt(row_inx);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AccGrd_RowLeave(this, null);
            }
            catch { }

            AccClass accClass = new AccClass();

            //вносим изменения в БД:           
            if (dt.Rows.Count > 0)
            {
                Class_Conn class_Conn = new Class_Conn();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    accClass.set_null();

                    if (dt.Rows[i].ItemArray[0].ToString() != "")
                        accClass.name_account = dt.Rows[i].ItemArray[0].ToString();
                    else
                        accClass.name_account = "null";

                    if (dt.Rows[i].ItemArray[1].ToString() != "")
                        accClass.id_type_account = Convert.ToInt32(dt.Rows[i].ItemArray[1].ToString());
                    else
                        accClass.id_type_account = 0;

                    if (dt.Rows[i].ItemArray[2].ToString() != "")
                        accClass.note = dt.Rows[i].ItemArray[3].ToString();
                    else
                        accClass.note = "null";

                    if (dt.Rows[i].ItemArray[3].ToString() != "")
                        accClass.id_account = Convert.ToInt32(dt.Rows[i].ItemArray[3].ToString());
                    else
                        accClass.id_account = 0;

                    if (dt.Rows[i].ItemArray[3].ToString() == "remove")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("delete from public.s_account where id_account = " + accClass.id_account.ToString());
                            MessageBox.Show("Данные удалены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data deleted from s_account", "id_account = " + accClass.id_account.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not deleted from s_account", "id_account = " + accClass.id_account.ToString());
                            MessageBox.Show("Данные не удалены!" + Environment.NewLine + "При удалении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    if (dt.Rows[i].ItemArray[3].ToString() == "upd")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("update public.s_account set name_account = " + class_Conn.neither_quoke(accClass.name_account) + ", " +
                                                  "note = " + class_Conn.neither_quoke(accClass.note) + ", " +
                                                  "id_account_type = " + accClass.id_type_account.ToString() +
                                                  " where id_account = " + accClass.id_account.ToString());
                            MessageBox.Show("Изменения успешно применены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data updated in s_account", "id_account = " + accClass.id_account.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not updated in s_account", "id_account = " + accClass.id_account.ToString());
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

                s_accountTableAdapter.Fill(sAccDS.s_account);
                AccGrd.DataSource = sAccDS.s_account;
                AccGrd.Refresh();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "AccForm";
            formGenFind.Show();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s_accountTableAdapter.Fill(sAccDS.s_account);
            AccGrd.DataSource = sAccDS.s_account;
            AccGrd.Refresh();
        }

        private void AccGrd_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void AccGrd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //получаем индекс строки, над которой совершали действия, и которая потеряла фокус
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
        }

        private void AccGrd_Leave(object sender, EventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void AccGrd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
            DataGridViewCell cell = AccGrd.Rows[row_inx].Cells[col_inx];
            AccGrd.CurrentCell = cell;
            this.action = "upd";
        }

        private void AccGrd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AccValueForm accValueForm = new AccValueForm();
            AccFareValueShClass.name_account = AccGrd.Rows[e.RowIndex].Cells[0].Value.ToString();
            AccFareValueShClass.note = AccGrd.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (AccGrd.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
            {
                int li_acc_type = 0;
                Class_Conn class_Conn = new Class_Conn();
                li_acc_type = class_Conn.ExecSQLInt("select id_account_type from s_account_type where name_account_type = '" + AccGrd.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ");
                AccFareValueShClass.id_type_account = li_acc_type;
            }
            
            AccFareValueShClass.id_account = Convert.ToInt32(AccGrd.Rows[e.RowIndex].Cells[4].Value.ToString());
            accValueForm.Show();
        }

        private void AccGrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                AccValueForm accValueForm = new AccValueForm();
                AccFareValueShClass.name_account = AccGrd.Rows[e.RowIndex].Cells[0].Value.ToString();
                AccFareValueShClass.note = AccGrd.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (AccGrd.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    int li_acc_type = 0;
                    Class_Conn class_Conn = new Class_Conn();
                    li_acc_type = class_Conn.ExecSQLInt("select id_account_type from s_account_type where name_account_type = '" + AccGrd.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ");
                    AccFareValueShClass.id_type_account = li_acc_type;
                }

                AccFareValueShClass.id_account = Convert.ToInt32(AccGrd.Rows[e.RowIndex].Cells[4].Value.ToString());
                accValueForm.Show();
            }
        }
    }
}
