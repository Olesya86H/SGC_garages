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
    public partial class AccValueForm : Form
    {
        UserClass userClass = new UserClass();
        string action = "";
        int row_inx = 0;
        int col_inx = 0;
        int id_acc_first = 0;
        DataTable dt = new DataTable();

        public AccValueForm()
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
            FareGrd.CommitEdit(DataGridViewDataErrorContexts.Commit); // применяем изменения
            if (FareGrd.Rows.Count > 0)
            {
                dt.Rows[cnt - 1].SetField(dt.Columns[0], FareGrd.Rows[row_inx].Cells[0].Value.ToString()); //Наименование статьи
                dt.Rows[cnt - 1].SetField(dt.Columns[1], FareGrd.Rows[row_inx].Cells[1].Value.ToString()); //Значение тарифа                
                dt.Rows[cnt - 1].SetField(dt.Columns[2], FareGrd.Rows[row_inx].Cells[2].Value.ToString()); //Единица измерения
                dt.Rows[cnt - 1].SetField(dt.Columns[3], FareGrd.Rows[row_inx].Cells[3].Value.ToString()); //Тип гаража
                dt.Rows[cnt - 1].SetField(dt.Columns[4], FareGrd.Rows[row_inx].Cells[4].Value.ToString()); //Дата начала действия тарифа
                dt.Rows[cnt - 1].SetField(dt.Columns[5], FareGrd.Rows[row_inx].Cells[5].Value.ToString()); //Дата окончания действия тарифа
                dt.Rows[cnt - 1].SetField(dt.Columns[6], FareGrd.Rows[row_inx].Cells[6].Value.ToString()); //ID тарифа - t_acc_value.id_acc_value
                dt.Rows[cnt - 1].SetField(dt.Columns[7], this.action);
            }
            this.action = ""; //обнуляем действие
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccFareValueShClass.set_null();
            this.Close();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFareValueForm AddAccFareValueForm = new AddFareValueForm();
            AddAccFareValueForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.action = "remove";
            get_data();
            FareGrd.Rows.RemoveAt(row_inx);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FareGrd_RowLeave(this, null);
            }
            catch { }

            AccFareClass accFareClass = new AccFareClass();

            //вносим изменения в БД:           
            if (dt.Rows.Count > 0)
            {
                Class_Conn class_Conn = new Class_Conn();
                int li = 0;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    accFareClass.set_null();

                    if (dt.Rows[i].ItemArray[0].ToString() != "")
                    {
                        li = class_Conn.ExecSQLInt("Select id_account from s_account where name_account = " + dt.Rows[i].ItemArray[0].ToString());
                        accFareClass.id_account = li;
                    }
                    else
                        accFareClass.id_account = 0;

                    if (dt.Rows[i].ItemArray[1].ToString() != "")
                        accFareClass.fare_value = Convert.ToDecimal(dt.Rows[i].ItemArray[1].ToString());
                    else
                        accFareClass.fare_value = 0;

                    if (dt.Rows[i].ItemArray[2].ToString() != "")
                    {
                        li = class_Conn.ExecSQLInt("Select id_si from s_si where name_si = " + dt.Rows[i].ItemArray[2].ToString());
                        accFareClass.id_si = li;
                    }
                    else
                        accFareClass.id_si = 0;

                    if (dt.Rows[i].ItemArray[3].ToString() != "")
                    {
                        li = class_Conn.ExecSQLInt("Select id_garage_type from s_garage_types where name_garage_type = " + dt.Rows[i].ItemArray[3].ToString());
                        accFareClass.id_garage_type = li;
                    }
                    else
                        accFareClass.id_garage_type = 0;

                    if (dt.Rows[i].ItemArray[4].ToString() != "")
                        accFareClass.date_on = Convert.ToDateTime(dt.Rows[i].ItemArray[4].ToString());
                    else
                        accFareClass.date_on = Convert.ToDateTime("01.01.1900");

                    if (dt.Rows[i].ItemArray[5].ToString() != "")
                        accFareClass.date_off = Convert.ToDateTime(dt.Rows[i].ItemArray[5].ToString());
                    else
                        accFareClass.date_off = Convert.ToDateTime("01.01.3000");

                    if (dt.Rows[i].ItemArray[6].ToString() != "")
                        accFareClass.id_acc_value = Convert.ToInt32(dt.Rows[i].ItemArray[6].ToString());
                    else
                        accFareClass.id_acc_value = 0;

                    if (dt.Rows[i].ItemArray[7].ToString() == "remove")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("delete from t_acc_value where id_acc_value = " + accFareClass.id_acc_value.ToString());
                            MessageBox.Show("Данные удалены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data deleted from t_acc_value", "id_acc_value = " + accFareClass.id_acc_value.ToString() + ", id_account = " + accFareClass.id_account.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not deleted from t_acc_value", "id_acc_value = " + accFareClass.id_acc_value.ToString() + ", id_account = " + accFareClass.id_account.ToString());
                            MessageBox.Show("Данные не удалены!" + Environment.NewLine + "При удалении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    if (dt.Rows[i].ItemArray[7].ToString() == "upd")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("update t_acc_value set date_on = to_date('" + class_Conn.neither_quoke(accFareClass.date_on.ToString()) + "','dd.mm.yyyy'), " +
                                                  "date_off =  to_date('" + class_Conn.neither_quoke(accFareClass.date_off.ToString()) + "','dd.mm.yyyy'), " +
                                                  "fare_value = " + accFareClass.fare_value.ToString() + ", " +
                                                  "id_si = " + accFareClass.id_si.ToString() + ", " +
                                                  "id_garage_type = " + accFareClass.id_garage_type.ToString() +
                                                  " where id_account = " + accFareClass.id_account.ToString() +
                                                  " and id_acc_value = " + accFareClass.id_acc_value.ToString());
                            MessageBox.Show("Изменения успешно применены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data updated in t_acc_value", "id_account = " + accFareClass.id_account.ToString() + ", id_acc_value = " + accFareClass.id_acc_value.ToString());
                        }
                        catch
                        {
                            userClass.log_info("data not updated in t_acc_value", "id_account = " + accFareClass.id_account.ToString() + ", id_acc_value = " + accFareClass.id_acc_value.ToString());
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

                обновитьToolStripMenuItem1_Click(this, null);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "AccFareValueForm";
            formGenFind.Show();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string find_sql = "SELECT t_acc.id_acc_value, s_acc.name_account, t_acc.date_on, t_acc.date_off, t_acc.value_fare, s_si.name_si, s_gtype.name_garage_type " +
                                "FROM t_acc_value t_acc, s_garage_types s_gtype, s_account s_acc, s_si " +
                                "WHERE t_acc.id_garage_type = s_gtype.id_garage_type " +
                                "AND t_acc.id_account = s_acc.id_account " +
                                "AND(t_acc.id_si = s_si.id_si) " +
                                "AND t_acc.id_account = " + id_acc_first.ToString();

            Class_Conn cl_conn = new Class_Conn();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            npgsqlDataAdapter.SelectCommand = npgsqlCommand;
            DataTable dt_find = new DataTable();
            npgsqlDataAdapter.Fill(dt_find);
            FareGrd.DataSource = dt_find;
            FareGrd.Refresh();
        }

        private void FareGrd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
            DataGridViewCell cell = FareGrd.Rows[row_inx].Cells[col_inx];
            FareGrd.CurrentCell = cell;
            this.action = "upd";
        }

        private void FareGrd_Leave(object sender, EventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void FareGrd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //получаем индекс строки, над которой совершали действия, и которая потеряла фокус
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
        }

        private void FareGrd_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void AccValueForm_Load(object sender, EventArgs e)
        {
            string find_sql = "SELECT t_acc.id_acc_value, s_acc.name_account, t_acc.date_on, t_acc.date_off, t_acc.value_fare, s_si.name_si, s_gtype.name_garage_type " +
                                "FROM t_acc_value t_acc, s_garage_types s_gtype, s_account s_acc, s_si " +
                                "WHERE t_acc.id_garage_type = s_gtype.id_garage_type " + 
                                "AND t_acc.id_account = s_acc.id_account " + 
                                "AND(t_acc.id_si = s_si.id_si) " +
                                "AND t_acc.id_account = " + AccFareValueShClass.id_account.ToString();

            Class_Conn cl_conn = new Class_Conn();
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
            npgsqlDataAdapter.SelectCommand = npgsqlCommand;
            DataTable dt_find = new DataTable();
            npgsqlDataAdapter.Fill(dt_find);
            FareGrd.DataSource = dt_find;
            FareGrd.Refresh();

            id_acc_first = AccFareValueShClass.id_account;
        }
    }
}
