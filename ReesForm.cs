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
    public partial class ReesForm : Form
    {
        DataTable dt_garages_for_accruals = new DataTable();
        public ReesForm()
        {
            InitializeComponent();
        }

        public void get_garages_for_accurals()
        {
            try
            {
                dt_garages_for_accruals.Clear();
                for (int i = 0; i <= dt_garages_for_accruals.Rows.Count - 1; i++)
                    dt_garages_for_accruals.Rows.RemoveAt(0);
            }
            catch { }

            try
            {
                if (dt_garages_for_accruals.Columns.Count == 0)
                {
                    dt_garages_for_accruals.Columns.Add(); //id_garage
                    dt_garages_for_accruals.Columns.Add(); //id_account
                    dt_garages_for_accruals.Columns.Add(); //id_garage_type
                }
            }
            catch { }

            if (ReeTab.SelectedTab.Name == "ContribPg")
                if (ContribGrd.SelectedRows.Count > 0)
                    for (int i = 0; i <= ContribGrd.SelectedRows.Count - 1; i++)
                    {
                        dt_garages_for_accruals.Rows.Add();
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[0], Convert.ToInt32(ContribGrd.SelectedRows[i].Cells[0].Value.ToString())); //id_garage
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[1], Convert.ToInt32(ContribGrd.SelectedRows[i].Cells[1].Value.ToString())); //id_account
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[2], Convert.ToInt32(ContribGrd.SelectedRows[i].Cells[2].Value.ToString())); //id_garage_type
                    }
            if (ReeTab.SelectedTab.Name == "ElectricityPg")
                if (ElectricityGrd.SelectedRows.Count > 0)
                    for (int i = 0; i <= ElectricityGrd.SelectedRows.Count - 1; i++)
                    {
                        dt_garages_for_accruals.Rows.Add();
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[0], Convert.ToInt32(ElectricityGrd.SelectedRows[i].Cells[0].Value.ToString())); //id_garage
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[1], Convert.ToInt32(ElectricityGrd.SelectedRows[i].Cells[1].Value.ToString())); //id_account
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[2], Convert.ToInt32(ElectricityGrd.SelectedRows[i].Cells[2].Value.ToString())); //id_garage_type
                    }
            if (ReeTab.SelectedTab.Name == "RentPg")
                if (RentGrd.SelectedRows.Count > 0)
                    for (int i = 0; i <= RentGrd.SelectedRows.Count - 1; i++)
                    {
                        dt_garages_for_accruals.Rows.Add();
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[0], Convert.ToInt32(RentGrd.SelectedRows[i].Cells[0].Value.ToString())); //id_garage
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[1], Convert.ToInt32(RentGrd.SelectedRows[i].Cells[1].Value.ToString())); //id_account
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[2], Convert.ToInt32(RentGrd.SelectedRows[i].Cells[2].Value.ToString())); //id_garage_type
                    }
            if (ReeTab.SelectedTab.Name == "BenefitPg")
                if (BenefitGrd.SelectedRows.Count > 0)
                    for (int i = 0; i <= BenefitGrd.SelectedRows.Count - 1; i++)
                    {
                        dt_garages_for_accruals.Rows.Add();
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[0], Convert.ToInt32(BenefitGrd.SelectedRows[i].Cells[0].Value.ToString())); //id_garage
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[1], Convert.ToInt32(BenefitGrd.SelectedRows[i].Cells[1].Value.ToString())); //id_account
                        dt_garages_for_accruals.Rows[i].SetField(dt_garages_for_accruals.Columns[2], Convert.ToInt32(BenefitGrd.SelectedRows[i].Cells[2].Value.ToString())); //id_garage_type
                    }
        }

        private void сделатьНачисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReeTab.SelectedTab.Name == "MainPg")
            {
                MessageBox.Show("Для закладки \"Основное\" не производится начислений, это информативная закладка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            get_garages_for_accurals();
            if (dt_garages_for_accruals.Rows.Count > 0)
            { 
                UserClass userClass = new UserClass();
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите произвести начисления за текущий период?","Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    for (int i = 0; i <= dt_garages_for_accruals.Rows.Count - 1; i++)
                    {
                        try
                        {
                            Class_Conn class_Conn = new Class_Conn();
                            string ls_name_acc_type = "";
                            if (ReeTab.SelectedTab.Name == "ContribPg") //определяем сумму для начисления для каждой строки, т.к. типы гаражей м.б.разные в каждой строке
                            {
                                ls_name_acc_type = "Взнос";
                            }
                            if (ReeTab.SelectedTab.Name == "ElectricityPg") //определяем сумму для начисления для каждой строки, т.к. типы гаражей м.б.разные в каждой строке
                            {
                                ls_name_acc_type = "Электричество";
                            }
                            if (ReeTab.SelectedTab.Name == "MainPg") //определяем сумму для начисления для каждой строки, т.к. типы гаражей м.б.разные в каждой строке
                            {
                                ls_name_acc_type = "RentPg";
                            }
                            if (ReeTab.SelectedTab.Name == "BenefitPg") //определяем сумму для начисления для каждой строки, т.к. типы гаражей м.б.разные в каждой строке
                            {
                                ls_name_acc_type = "Благоустройство";
                            }
                            string ls_sql_fare = @"select nvl(value_fare, 0) 
                                                     from t_acc_value av 
                                                    where av.id_account = (select max(id_account) 
                                                                         from s_account s_acc
                                                                        where s_acc.id_type_account = (select max(id_account_type)
                                                                                                        from s_account_type s_acc_t
                                                                                                        where s_acc_t.name_account_type = '"+ ls_name_acc_type + @"'))
                                                    and current_date between av.date_on and av.date_off
                                                    and av.id_acc_value = (select max(id_acc_value) 
                                                                             from t_acc_value av1
                                                                            where av1.id_account = av.id_account
                                                                            and current_date between av1.date_on and av1.date_off
                                                                            and av1.id_garage_type = " + dt_garages_for_accruals.Rows[i].ItemArray[2].ToString() +
                                                                          @")
                                                    av.id_garage_type = " + dt_garages_for_accruals.Rows[i].ItemArray[2].ToString();


                            string sql_fare_value = "";
                            sql_fare_value = class_Conn.ExecSQLStr(ls_sql_fare);
                            string ls_comm;
                            ls_comm = "call get_accruals(" + dt_garages_for_accruals.Rows[i].ItemArray[0].ToString() +
                                                      ", " + dt_garages_for_accruals.Rows[i].ItemArray[1].ToString() +
                                                      ", " + sql_fare_value + ");";                            
                            class_Conn.ExecSQLStr(ls_comm);
                            userClass.log_info("Произведены начисления в текущем периоде", DateTime.Today.ToString());

                        }
                        catch
                        {
                            MessageBox.Show("Начисления не произведены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userClass.log_info("Ошибка проведения начислений в текущем периоде", DateTime.Today.ToString());
                            return;
                        }
                    }

                    MessageBox.Show("Начисления успешно произведены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //очищаем таблицу данных:
            try
            {
                dt_garages_for_accruals.Clear();
                for (int i = 0; i <= dt_garages_for_accruals.Rows.Count - 1; i++)
                    dt_garages_for_accruals.Rows.RemoveAt(0);
            }
            catch { }
        }              

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            get_data_grids();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void get_data_grids()
        {
            //очищаем таблицы:
            try
            {
                this.MainGrd.DataSource = null;
                if (this.MainGrd.Columns.Count > 0)
                {
                    for (int i = 0; i <= this.MainGrd.Columns.Count - 1; i++)
                        this.MainGrd.Columns.RemoveAt(0);
                }
            }
            catch { }

            try
            {
                this.BenefitGrd.DataSource = null;
                if (this.BenefitGrd.Columns.Count > 0)
                {
                    for (int i = 0; i <= this.BenefitGrd.Columns.Count - 1; i++)
                        this.BenefitGrd.Columns.RemoveAt(0);
                }
            }
            catch { }

            try
            {
                this.ContribGrd.DataSource = null;
                if (this.ContribGrd.Columns.Count > 0)
                {
                    for (int i = 0; i <= this.ContribGrd.Columns.Count - 1; i++)
                        this.ContribGrd.Columns.RemoveAt(0);
                }
            }
            catch { }

            try
            {
                this.ElectricityGrd.DataSource = null;
                if (this.ElectricityGrd.Columns.Count > 0)
                {
                    for (int i = 0; i <= this.ElectricityGrd.Columns.Count - 1; i++)
                        this.ElectricityGrd.Columns.RemoveAt(0);
                }
            }
            catch { }

            try
            {
                this.RentGrd.DataSource = null;
                if (this.RentGrd.Columns.Count > 0)
                {
                    for (int i = 0; i <= this.RentGrd.Columns.Count - 1; i++)
                        this.RentGrd.Columns.RemoveAt(0);
                }
            }
            catch { }

            Class_Conn cl_conn = new Class_Conn();

            //обработка фильтров:
            string ls_filter_acc_type = "";
            if (AccTypeCmbbx.Text != "")
            {
                ls_filter_acc_type = " and sacc_t.id_account_type = " + AccTypeCmbbx.SelectedValue.ToString();
            }

            string ls_filter_garage_type = "";
            if (TypeGarCmbbx.Text != "")
            {
                ls_filter_garage_type = " and tg.id_garage_type = " + TypeGarCmbbx.SelectedValue.ToString();
            }

            //таблица на закладке "Основное":
            string find_sql_mainGrd = @"select tg.id_garage,
                                               tg.date_in,
	                                           tg.num,	   
	                                           sp.fio,
	                                           sgt.name_garage_type,	   
	                                           ts.debt,
	                                           sp.phone_number,
	                                           case when coalesce(debt, 0) < 0 then -1
	                                           else 1 end as flag_pic
                                        from t_garages tg 
	                                         left outer join (select sum(debt) debt, ts.id_garage
	  	   			                                          from t_sum ts
	  	   			                                          group by ts.id_garage) ts	
	                                         on tg.id_garage = ts.id_garage,
	                                         s_persons sp,
	                                         s_garage_types sgt
                                        where tg.id_owner = sp.id_person
                                        and sp.is_owner = 1
                                        and tg.id_garage_type = sgt.id_garage_type" + ls_filter_garage_type +
                                        " order by tg.id_garage, tg.num, sp.fio, sgt.name_garage_type";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql_mainGrd, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapterMainGrd = new NpgsqlDataAdapter();
            npgsqlDataAdapterMainGrd.SelectCommand = npgsqlCommand;
            DataTable dt_MainGrd = new DataTable();
            npgsqlDataAdapterMainGrd.Fill(dt_MainGrd);
            this.MainGrd.DataSource = dt_MainGrd;
            
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "Flags";
            this.MainGrd.Columns.Add(imgColumn);
            
            if (this.MainGrd.Rows.Count > 0)
            {
                for (int i = 0; i < this.MainGrd.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToDecimal(this.MainGrd.Rows[i].Cells[5].Value.ToString()) > 0)
                            this.MainGrd.Rows[i].Cells["Flags"].Value = Properties.Resources.flag_green;
                        if (Convert.ToDecimal(this.MainGrd.Rows[i].Cells[5].Value.ToString()) == 0)
                            this.MainGrd.Rows[i].Cells["Flags"].Value = Properties.Resources.flag_yellow;
                        if (Convert.ToDecimal(this.MainGrd.Rows[i].Cells[5].Value.ToString()) < 0)
                            this.MainGrd.Rows[i].Cells["Flags"].Value = Properties.Resources.flag_red;
                    }
                    catch
                    {
                        this.MainGrd.Rows[i].Cells["Flags"].Value = Properties.Resources.flag_yellow;
                    }
                }
            }

            this.MainGrd.Refresh();

            //Заполняю заголовок столбцов:
            this.MainGrd.Columns[0].HeaderText = "ID гаража";
            this.MainGrd.Columns[1].HeaderText = "Дата вступления";
            this.MainGrd.Columns[2].HeaderText = "Номер гаража";
            this.MainGrd.Columns[3].HeaderText = "ФИО";
            this.MainGrd.Columns[4].HeaderText = "Тип гаража";
            this.MainGrd.Columns[5].HeaderText = "Задолженность/переплата";
            this.MainGrd.Columns[6].HeaderText = "Телефон";
            this.MainGrd.Columns[7].HeaderText = "Неисп.индикатор";
            this.MainGrd.Columns[8].HeaderText = "Индикатор";

            this.MainGrd.Columns[0].Visible = false;
            this.MainGrd.Columns[7].Visible = false;

            this.MainGrd.Columns[8].Width = 80;

            //таблица на закладке "Взносы":
            string find_sql_ContribGrd = @" select tg.id_garage,
                                                   tg.date_in,
	                                               tg.num,	   
	                                               sp.fio,
	                                               sgt.name_garage_type,
	                                               sacc.name_account,
	                                               sacc_t.name_account_type,
	                                               ts.debt,
	                                               sp.phone_number,
	                                               case when coalesce(debt, 0) < 0 then -1
	                                               else 1 end as flag_pic
                                            from t_garages tg 
	                                             left outer join (select sum(debt) debt, 
					  		                                             ts.id_garage,
					  		                                             ts.id_account
	  	   			                                              from  t_sum ts, 
					  		                                            s_account sacc,
					  		                                            s_account_type sacc_t
					                                              where ts.id_account = sacc.id_account
					                                              and sacc.id_type_account = sacc_t.id_account_type
					                                              and sacc_t.name_account_type = 'Взнос'
	  	   			                                              group by ts.id_garage, ts.id_account) ts	
	                                             on tg.id_garage = ts.id_garage,
	                                             s_persons sp,
	                                             s_garage_types sgt,
	                                             s_account sacc,
	                                             s_account_type sacc_t
                                            where tg.id_owner = sp.id_person
                                            and sp.is_owner = 1
                                            and tg.id_garage_type = sgt.id_garage_type
                                            and ts.id_account = sacc.id_account
                                            and sacc.id_type_account = sacc_t.id_account_type
                                            and sacc_t.name_account_type = 'Взнос'" + ls_filter_acc_type + ls_filter_garage_type +
                                            " order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

            npgsqlCommand = new NpgsqlCommand(find_sql_ContribGrd, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapterContribGrd = new NpgsqlDataAdapter();
            npgsqlDataAdapterContribGrd.SelectCommand = npgsqlCommand;
            DataTable dt_Contrib = new DataTable();
            npgsqlDataAdapterContribGrd.Fill(dt_Contrib);
            this.ContribGrd.DataSource = dt_Contrib;
            
            //Заполняю заголовок столбцов:
            this.ContribGrd.Columns[0].HeaderText = "ID гаража";
            this.ContribGrd.Columns[1].HeaderText = "Дата вступления";
            this.ContribGrd.Columns[2].HeaderText = "Номер гаража";
            this.ContribGrd.Columns[3].HeaderText = "ФИО";
            this.ContribGrd.Columns[4].HeaderText = "Тип гаража";
            this.ContribGrd.Columns[5].HeaderText = "Статья";
            this.ContribGrd.Columns[6].HeaderText = "Тип статьи";
            this.ContribGrd.Columns[7].HeaderText = "Задолженность/переплата";
            this.ContribGrd.Columns[8].HeaderText = "Телефон";
            this.ContribGrd.Columns[9].HeaderText = "Неисп.флаг";

            this.ContribGrd.Columns[0].Visible = false;
            this.ContribGrd.Columns[9].Visible = false;

            this.ContribGrd.Refresh();

            //таблица на закладке "Электричество":
            string find_sql_ElectricityGrd = @" select tg.id_garage,
                                                       tg.date_in,
	                                                   tg.num,	   
	                                                   sp.fio,
	                                                   sgt.name_garage_type,
	                                                   sacc.name_account,
	                                                   sacc_t.name_account_type,
	                                                   ts.debt,
	                                                   sp.phone_number,
	                                                   case when coalesce(debt, 0) < 0 then -1
	                                                   else 1 end as flag_pic
                                                from t_garages tg,
											         t_sum ts,
	                                                 s_persons sp,
	                                                 s_garage_types sgt,
	                                                 s_account sacc,
	                                                 s_account_type sacc_t
                                                where tg.id_owner = sp.id_person
                                                and sp.is_owner = 1
										        and ts.id_account = sacc.id_account
                                                and tg.id_garage_type = sgt.id_garage_type
                                                and ts.id_account = sacc.id_account
										        and ts.id_garage = tg.id_garage
                                                and sacc.id_type_account = sacc_t.id_account_type
                                                and Upper(sacc.name_account) = Upper('Электричество (общее)')
                                                and sacc_t.name_account_type = 'Электричество'" + ls_filter_acc_type + ls_filter_garage_type +
                                                " order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

            npgsqlCommand = new NpgsqlCommand(find_sql_ElectricityGrd, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapterElectricityGrd = new NpgsqlDataAdapter();
            npgsqlDataAdapterElectricityGrd.SelectCommand = npgsqlCommand;
            DataTable dt_Electricity = new DataTable();
            npgsqlDataAdapterElectricityGrd.Fill(dt_Electricity);
            this.ElectricityGrd.DataSource = dt_Electricity;
            
            //Заполняю заголовок столбцов:
            this.ElectricityGrd.Columns[0].HeaderText = "ID гаража";
            this.ElectricityGrd.Columns[1].HeaderText = "Дата вступления";
            this.ElectricityGrd.Columns[2].HeaderText = "Номер гаража";
            this.ElectricityGrd.Columns[3].HeaderText = "ФИО";
            this.ElectricityGrd.Columns[4].HeaderText = "Тип гаража";
            this.ElectricityGrd.Columns[5].HeaderText = "Статья";
            this.ElectricityGrd.Columns[6].HeaderText = "Тип статьи";
            this.ElectricityGrd.Columns[7].HeaderText = "Задолженность/переплата";
            this.ElectricityGrd.Columns[8].HeaderText = "Телефон";
            this.ElectricityGrd.Columns[9].HeaderText = "Неисп.флаг";

            this.ElectricityGrd.Columns[0].Visible = false;
            this.ElectricityGrd.Columns[9].Visible = false;

            this.ElectricityGrd.Refresh();

            //таблица на закладке "Аренда":
            string find_sql_RentGrd = @"select tg.id_garage,
                                               tg.date_in,
	                                           tg.num,	   
	                                           sp.fio,
	                                           sgt.name_garage_type,
	                                           sacc.name_account,
	                                           sacc_t.name_account_type,
	                                           ts.debt,
	                                           sp.phone_number,
	                                           case when coalesce(debt, 0) < 0 then -1
	                                           else 1 end as flag_pic
                                        from t_garages tg 
	                                         left outer join (select sum(debt) debt, 
					  		                                         ts.id_garage,
					  		                                         ts.id_account
	  	   			                                          from  t_sum ts, 
					  		                                        s_account sacc,
					  		                                        s_account_type sacc_t
					                                          where ts.id_account = sacc.id_account
					                                          and sacc.id_type_account = sacc_t.id_account_type
					                                          and sacc_t.name_account_type = 'Аренда'
	  	   			                                          group by ts.id_garage, ts.id_account) ts	
	                                         on tg.id_garage = ts.id_garage,
	                                         s_persons sp,
	                                         s_garage_types sgt,
	                                         s_account sacc,
	                                         s_account_type sacc_t
                                        where tg.id_owner = sp.id_person
                                        and sp.is_owner = 1
                                        and tg.id_garage_type = sgt.id_garage_type
                                        and ts.id_account = sacc.id_account
                                        and sacc.id_type_account = sacc_t.id_account_type
                                        and sacc_t.name_account_type = 'Аренда'" + ls_filter_acc_type + ls_filter_garage_type +
                                        " order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

            npgsqlCommand = new NpgsqlCommand(find_sql_RentGrd, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapterRentGrd = new NpgsqlDataAdapter();
            npgsqlDataAdapterRentGrd.SelectCommand = npgsqlCommand;
            DataTable dt_Rent = new DataTable();
            npgsqlDataAdapterRentGrd.Fill(dt_Rent);
            this.RentGrd.DataSource = dt_Rent;
            
            //Заполняю заголовок столбцов:
            this.RentGrd.Columns[0].HeaderText = "ID гаража";
            this.RentGrd.Columns[1].HeaderText = "Дата вступления";
            this.RentGrd.Columns[2].HeaderText = "Номер гаража";
            this.RentGrd.Columns[3].HeaderText = "ФИО";
            this.RentGrd.Columns[4].HeaderText = "Тип гаража";
            this.RentGrd.Columns[5].HeaderText = "Статья";
            this.RentGrd.Columns[6].HeaderText = "Тип статьи";
            this.RentGrd.Columns[7].HeaderText = "Задолженность/переплата";
            this.RentGrd.Columns[8].HeaderText = "Телефон";
            this.RentGrd.Columns[9].HeaderText = "Неисп.флаг";

            this.RentGrd.Columns[0].Visible = false;
            this.RentGrd.Columns[9].Visible = false;

            this.RentGrd.Refresh();

            //таблица на закладке "Благоустройство":
            string find_sql_BenefitGrd = @" select tg.id_garage,
                                                   tg.date_in,
	                                               tg.num,	   
	                                               sp.fio,
	                                               sgt.name_garage_type,
	                                               sacc.name_account,
	                                               sacc_t.name_account_type,
	                                               ts.debt,
	                                               sp.phone_number,
	                                               case when coalesce(debt, 0) < 0 then -1
	                                               else 1 end as flag_pic
                                            from t_garages tg 
	                                             left outer join (select sum(debt) debt, 
					  		                                             ts.id_garage,
					  		                                             ts.id_account
	  	   			                                              from  t_sum ts, 
					  		                                            s_account sacc,
					  		                                            s_account_type sacc_t
					                                              where ts.id_account = sacc.id_account
					                                              and sacc.id_type_account = sacc_t.id_account_type
					                                              and sacc_t.name_account_type = 'Благоустройство'
	  	   			                                              group by ts.id_garage, ts.id_account) ts	
	                                             on tg.id_garage = ts.id_garage,
	                                             s_persons sp,
	                                             s_garage_types sgt,
	                                             s_account sacc,
	                                             s_account_type sacc_t
                                            where tg.id_owner = sp.id_person
                                            and sp.is_owner = 1
                                            and tg.id_garage_type = sgt.id_garage_type
                                            and ts.id_account = sacc.id_account
                                            and sacc.id_type_account = sacc_t.id_account_type
                                            and sacc_t.name_account_type = 'Благоустройство'" + ls_filter_acc_type + ls_filter_garage_type +
                                            " order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

            npgsqlCommand = new NpgsqlCommand(find_sql_BenefitGrd, cl_conn.npgSqlConnection);
            NpgsqlDataAdapter npgsqlDataAdapterBenefitGrd = new NpgsqlDataAdapter();
            npgsqlDataAdapterBenefitGrd.SelectCommand = npgsqlCommand;
            DataTable dt_Benefit = new DataTable();
            npgsqlDataAdapterBenefitGrd.Fill(dt_Benefit);
            this.BenefitGrd.DataSource = dt_Benefit;            

            //Заполняю заголовок столбцов:
            this.BenefitGrd.Columns[0].HeaderText = "ID гаража";
            this.BenefitGrd.Columns[1].HeaderText = "Дата вступления";
            this.BenefitGrd.Columns[2].HeaderText = "Номер гаража";
            this.BenefitGrd.Columns[3].HeaderText = "ФИО";
            this.BenefitGrd.Columns[4].HeaderText = "Тип гаража";
            this.BenefitGrd.Columns[5].HeaderText = "Статья";
            this.BenefitGrd.Columns[6].HeaderText = "Тип статьи";
            this.BenefitGrd.Columns[7].HeaderText = "Задолженность/переплата";
            this.BenefitGrd.Columns[8].HeaderText = "Телефон";
            this.BenefitGrd.Columns[9].HeaderText = "Неисп.флаг";

            this.BenefitGrd.Columns[0].Visible = false;
            this.BenefitGrd.Columns[9].Visible = false;

            this.BenefitGrd.Refresh();
        }
        private void ReesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sAccTypeReeDS.s_account_type". При необходимости она может быть перемещена или удалена.
            this.s_account_typeTableAdapter.Fill(this.sAccTypeReeDS.s_account_type);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sGarTypeReeDS.s_garage_types". При необходимости она может быть перемещена или удалена.
            this.s_garage_typesTableAdapter.Fill(this.sGarTypeReeDS.s_garage_types);
            get_data_grids();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            get_data_grids();
        }
    }
}
