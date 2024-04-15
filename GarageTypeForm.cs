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
    public partial class GarageTypeForm : Form
    {
        UserClass userClass = new UserClass();

        string action = "";
        int row_inx = 0;
        int col_inx = 0;
        DataTable dt = new DataTable();
        public GarageTypeForm()
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
            GarageTypegrd.CommitEdit(DataGridViewDataErrorContexts.Commit); // применяем изменения
            if (GarageTypegrd.Rows.Count > 0)
            {
                dt.Rows[cnt - 1].SetField(dt.Columns[0], GarageTypegrd.Rows[row_inx].Cells[0].Value.ToString()); //Наименование
                dt.Rows[cnt - 1].SetField(dt.Columns[1], GarageTypegrd.Rows[row_inx].Cells[1].Value.ToString()); //Примечание                
                dt.Rows[cnt - 1].SetField(dt.Columns[2], GarageTypegrd.Rows[row_inx].Cells[2].Value.ToString()); //ID
                dt.Rows[cnt - 1].SetField(dt.Columns[3], this.action);
            }
            this.action = ""; //обнуляем действие
        }


        private void GarageTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "s_GarageTypesDS.s_garage_types". При необходимости она может быть перемещена или удалена.
            s_garage_typesTableAdapter.Fill(s_GarageTypesDS.s_garage_types);
            for (int i = 0; i <= 3; i++) //добавляем информацию о персоне: фио, телефон, адрес, примечание, признак - собственник, признак - плательщик, признак - пользователь проги, id (если есть в БД), действие над записью
            {
                dt.Columns.Add();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDictItemForm addGarageTypeForm = new AddDictItemForm();
            addGarageTypeForm.senderName = "GarageTypeForm";
            addGarageTypeForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.action = "remove";
            get_data();
            GarageTypegrd.Rows.RemoveAt(row_inx);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GarageTypegrd_RowLeave(this, null);
            }
            catch { }

           DictItemClass dictItemClass = new DictItemClass();

            //вносим изменения в БД:           
            if (dt.Rows.Count > 0)
            {
                Class_Conn class_Conn = new Class_Conn();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dictItemClass.set_null();

                    if (dt.Rows[i].ItemArray[0].ToString() != "")
                        dictItemClass.name_item = dt.Rows[i].ItemArray[0].ToString();
                    else
                        dictItemClass.name_item = "null";

                    if (dt.Rows[i].ItemArray[1].ToString() != "")
                        dictItemClass.note = dt.Rows[i].ItemArray[3].ToString();
                    else
                        dictItemClass.note = "null";

                    if (dt.Rows[i].ItemArray[2].ToString() != "")
                        dictItemClass.id_item = Convert.ToInt32(dt.Rows[i].ItemArray[2].ToString());
                    else
                        dictItemClass.id_item = 0;

                    if (dt.Rows[i].ItemArray[3].ToString() == "remove")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("delete from public.s_garage_types where id_garage_type = " + dictItemClass.id_item.ToString());
                            MessageBox.Show("Данные удалены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data deleted from s_garage_types", "id_garage_type = " + dictItemClass.id_item.ToString());
                        }
                        catch
                        {
                            userClass.log_info("error - data not deleted from s_garage_types", "id_garage_type = " + dictItemClass.id_item.ToString());
                            MessageBox.Show("Данные не удалены!" + Environment.NewLine + "При удалении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                        }
                    };
                    if (dt.Rows[i].ItemArray[3].ToString() == "upd")
                    {
                        try
                        {
                            class_Conn.ExecSQLStr("update public.s_garage_types set name_garage_type = " + class_Conn.neither_quoke(dictItemClass.name_item) + ", " +
                                                  "note = " + class_Conn.neither_quoke(dictItemClass.note) +
                                                  " where id_garage_type = " + dictItemClass.id_item.ToString());
                            MessageBox.Show("Изменения успешно применены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            userClass.log_info("data updated in s_garage_types", "id_garage_type = " + dictItemClass.id_item.ToString());
                        }

                        catch
                        {
                            userClass.log_info("error - data not updated in s_garage_types", "id_garage_type = " + dictItemClass.id_item.ToString());
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

                s_garage_typesTableAdapter.Fill(s_GarageTypesDS.s_garage_types);
                GarageTypegrd.DataSource = s_GarageTypesDS.s_garage_types;
                GarageTypegrd.Refresh();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "GarageTypeForm";
            formGenFind.Show();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s_garage_typesTableAdapter.Fill(s_GarageTypesDS.s_garage_types);
            GarageTypegrd.DataSource = s_GarageTypesDS.s_garage_types;
            GarageTypegrd.Refresh();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GarageTypegrd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
            DataGridViewCell cell = GarageTypegrd.Rows[row_inx].Cells[col_inx];
            GarageTypegrd.CurrentCell = cell;
            this.action = "upd";
        }

        private void GarageTypegrd_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }

        private void GarageTypegrd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //получаем индекс строки, над которой совершали действия, и которая потеряла фокус
            row_inx = e.RowIndex;
            col_inx = e.ColumnIndex;
        }

        private void GarageTypegrd_Leave(object sender, EventArgs e)
        {
            if (this.action == "upd")
                get_data();
        }
    }
}
