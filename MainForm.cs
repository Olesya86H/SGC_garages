using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Npgsql;

namespace SGC_garages
{
    public partial class MainForm : Form
    {
        Class_Conn Cl_conn = new Class_Conn();
        UserClass userClass = new UserClass();
        public string find_form_sender = "";
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int is_user;
                is_user = 0;
                try
                { 
                    is_user = userClass.IsSystemUser();
                }
                catch
                {
                    MessageBox.Show("Соединение с БД не установлено!", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Environment.Exit(0);
                }
                if (is_user == 1)
                {
                    this.Text = "ПС \"Учёт гаражей\", пользователь - " + userClass.GetName();
                    userClass.log_info("log in system", "");
                }
                else
                {
                    MessageBox.Show("Ваша учётная запись не заведена в системе! Доступ невозможен, обратитесь к администратору.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    Environment.Exit(0);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Ошибка, обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                Environment.Exit(0);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {               
                Cl_conn.Close();
                this.Close();
            }
            catch { }           
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void личныйКабинетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutProgramm aboutProgramm = new AboutProgramm();
            aboutProgramm.Show();
        }

        private void владельцыГаражейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnersForm ownersForm = new OwnersForm();
            ownersForm.Show();
        }

        private void плательщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayersForm payersForm = new PayersForm();
            payersForm.Show();
        }

        private void общийСписокФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralPersonsListForm generalPersonsListForm = new GeneralPersonsListForm();
            generalPersonsListForm.Show();
        }

        private void пользователиСистемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersListForm usersListForm = new UsersListForm();
            usersListForm.Show();
        }

        private void типыГаражейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarageTypeForm garageTypeForm = new GarageTypeForm();
            garageTypeForm.Show();
        }

        private void типыСтатейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccTypeForm accTypeForm = new AccTypeForm();
            accTypeForm.Show();
        }

        private void статьиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiForm siForm = new SiForm();
            siForm.Show();
        }

        private void историяДействийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserCab userCab = new UserCab();
            userCab.Show();
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "MainForm";
            formGenFind.Show();
        }

        private void отправитьПисьмоВТехподдержкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessForm sendMessForm = new SendMessForm();
            sendMessForm.Show();
        }

        public void Report_create(string RepName)
        {
            userClass.log_info("Report started", "");
            Class_Conn cl_conn = new Class_Conn();

            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();            
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = xlWorkBook.Sheets.Add();
            
            DataTable dt = new DataTable();
            if (RepName == "Самострой" || RepName == "Не самострой" || RepName == "Железные гаражи" || RepName == "2-х этажные гаражи" || RepName == "ПГСК Барсово")
            {
                string ls_filter_garage_type = " and tg.id_garage_type = (select id_garage_type from s_garage_types sgt where sgt.name_garage_type = '" + RepName + "') ";

                //Основной запрос:
                string query_string = @"select tg.date_in,	                                           	   
	                                           trim(sp.fio) as fio,
                                               tg.num,
	                                           sgt.name_garage_type,	   
	                                           ts.debt,
	                                           sp.phone_number
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

                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query_string, cl_conn.npgSqlConnection);
                NpgsqlDataAdapter npgsqlDataAdapterRep = new NpgsqlDataAdapter();
                npgsqlDataAdapterRep.SelectCommand = npgsqlCommand;
                npgsqlDataAdapterRep.Fill(dt);

                //Запись данных в определенные ячейки:
                xlWorkSheet.Cells[1, 1] = "Дата вступления";
                xlWorkSheet.Cells[1, 2] = "ФИО";
                xlWorkSheet.Cells[1, 3] = "Номер гаража";
                xlWorkSheet.Cells[1, 4] = "Тип гаража";
                xlWorkSheet.Cells[1, 5] = "Задолженность/переплата";
                xlWorkSheet.Cells[1, 6] = "Телефон";

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    xlWorkSheet.Cells[i + 2, 1] = dt.Rows[i].ItemArray[0].ToString();
                    xlWorkSheet.Cells[i + 2, 2] = dt.Rows[i].ItemArray[1].ToString();
                    xlWorkSheet.Cells[i + 2, 3] = dt.Rows[i].ItemArray[2].ToString();
                    xlWorkSheet.Cells[i + 2, 4] = dt.Rows[i].ItemArray[3].ToString();
                    xlWorkSheet.Cells[i + 2, 5] = dt.Rows[i].ItemArray[4].ToString();
                    xlWorkSheet.Cells[i + 2, 6] = dt.Rows[i].ItemArray[5].ToString();
                }
                xlWorkSheet.Columns.AutoFit();
                xlWorkSheet.Name = RepName;
                xlApp.Visible = true;
                //xlWorkBook.SaveAs(pathXL, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();
            }

            if (RepName == "Аренда" || RepName == "Благоустройство")
            {
                //отчёт "Аренда":
                string find_sql_RentGrd = @"select tg.date_in,	                                               	   
	                                               trim(sp.fio) as fio,
                                                   tg.num,
	                                               sgt.name_garage_type,
	                                               sacc.name_account,
	                                               sacc_t.name_account_type,
	                                               ts.debt,
	                                               sp.phone_number
                                            from t_garages tg 
	                                             left outer join (select sum(debt) debt, 
					  		                                             ts.id_garage,
					  		                                             ts.id_account
	  	   			                                              from  t_sum ts, 
					  		                                            s_account sacc,
					  		                                            s_account_type sacc_t
					                                              where ts.id_account = sacc.id_account
					                                              and sacc.id_type_account = sacc_t.id_account_type
					                                              and sacc_t.name_account_type = '" + RepName + @"'
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
                                            and sacc_t.name_account_type = '" + RepName + @"'
                                            order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql_RentGrd, cl_conn.npgSqlConnection);
                NpgsqlDataAdapter npgsqlDataAdapterRentGrd = new NpgsqlDataAdapter();
                npgsqlDataAdapterRentGrd.SelectCommand = npgsqlCommand;
                npgsqlDataAdapterRentGrd.Fill(dt);

                //Запись данных в определенные ячейки:
                xlWorkSheet.Cells[1, 1] = "Дата вступления";
                xlWorkSheet.Cells[1, 2] = "ФИО";
                xlWorkSheet.Cells[1, 3] = "Номер гаража";
                xlWorkSheet.Cells[1, 4] = "Тип гаража";
                xlWorkSheet.Cells[1, 5] = "Статья";
                xlWorkSheet.Cells[1, 6] = "Тип статьи";
                xlWorkSheet.Cells[1, 7] = "Задолженность/переплата";
                xlWorkSheet.Cells[1, 8] = "Телефон";

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    xlWorkSheet.Cells[i + 2, 1] = dt.Rows[i].ItemArray[0].ToString();
                    xlWorkSheet.Cells[i + 2, 2] = dt.Rows[i].ItemArray[1].ToString();
                    xlWorkSheet.Cells[i + 2, 3] = dt.Rows[i].ItemArray[2].ToString();
                    xlWorkSheet.Cells[i + 2, 4] = dt.Rows[i].ItemArray[3].ToString();
                    xlWorkSheet.Cells[i + 2, 5] = dt.Rows[i].ItemArray[4].ToString();
                    xlWorkSheet.Cells[i + 2, 6] = dt.Rows[i].ItemArray[5].ToString();
                    xlWorkSheet.Cells[i + 2, 7] = dt.Rows[i].ItemArray[6].ToString();
                    xlWorkSheet.Cells[i + 2, 8] = dt.Rows[i].ItemArray[7].ToString();
                }
                xlWorkSheet.Columns.AutoFit();
                xlWorkSheet.Name = RepName;
                xlApp.Visible = true;
                //xlWorkBook.SaveAs(pathXL, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();
            }

            if (RepName == "Электричество")
            {
                //отчёт "Электричество":
                string find_sql_RentGrd = @"    select tg.date_in,	                                                      
	                                                   trim(sp.fio) as fio,
                                                       tg.num,	
	                                                   sgt.name_garage_type,
	                                                   sacc.name_account,
	                                                   ts.debt,
	                                                   sp.phone_number
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
                                                and sacc_t.name_account_type = 'Электричество' 
                                                order by tg.id_garage, tg.num, sp.fio, sacc_t.name_account_type, sacc.name_account";

                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql_RentGrd, cl_conn.npgSqlConnection);
                NpgsqlDataAdapter npgsqlDataAdapterRentGrd = new NpgsqlDataAdapter();
                npgsqlDataAdapterRentGrd.SelectCommand = npgsqlCommand;
                npgsqlDataAdapterRentGrd.Fill(dt);

                //Запись данных в определенные ячейки:
                xlWorkSheet.Cells[1, 1] = "Дата вступления";
                xlWorkSheet.Cells[1, 2] = "ФИО";
                xlWorkSheet.Cells[1, 3] = "Номер гаража";
                xlWorkSheet.Cells[1, 4] = "Тип гаража";
                xlWorkSheet.Cells[1, 5] = "Статья";
                xlWorkSheet.Cells[1, 6] = "Задолженность/переплата";
                xlWorkSheet.Cells[1, 7] = "Телефон";

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    xlWorkSheet.Cells[i + 2, 1] = dt.Rows[i].ItemArray[0].ToString();
                    xlWorkSheet.Cells[i + 2, 2] = dt.Rows[i].ItemArray[1].ToString();
                    xlWorkSheet.Cells[i + 2, 3] = dt.Rows[i].ItemArray[2].ToString();
                    xlWorkSheet.Cells[i + 2, 4] = dt.Rows[i].ItemArray[3].ToString();
                    xlWorkSheet.Cells[i + 2, 5] = dt.Rows[i].ItemArray[4].ToString();
                    xlWorkSheet.Cells[i + 2, 6] = dt.Rows[i].ItemArray[5].ToString();
                    xlWorkSheet.Cells[i + 2, 7] = dt.Rows[i].ItemArray[6].ToString();
                }
                xlWorkSheet.Columns.AutoFit();
                xlWorkSheet.Name = RepName;
                xlApp.Visible = true;
                //xlWorkBook.SaveAs(pathXL, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();
            }

            userClass.log_info("Report end", "");
        }

        private void отчётСамостройToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "SamostroyRep";
            //reportForm.Show();
            Report_create("Самострой");
        }

        private void отчётНеСамостройToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "NeSamostroyRep";
            //reportForm.Show();
            Report_create("Не самострой");
        }        

        private void отчётЖелезныеГаражиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "FerrumRep";
            //reportForm.Show();
            Report_create("Железные гаражи");
        }

        private void отчт2хЭтажныеГаражиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "TwiceFloorGaragesRep";
            //reportForm.Show();
            Report_create("2-х этажные гаражи");
        }

        private void отчётЭлектричествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "ElectricityRep";
            //reportForm.Show();
            Report_create("Электричество");
        }

        private void отчётАрендаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "RentRep";
            //reportForm.Show();
            Report_create("Аренда");
        }

        private void отчётШлагбаумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    private void новыйПлатёжToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPaymentForm newPaymentForm = new NewPaymentForm();
            newPaymentForm.Show();
        }

        private void новыйГаражToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGarageForm newGarageForm = new NewGarageForm();
            newGarageForm.Show();
        }

        private void реестрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReesForm allReesForm = new ReesForm();
            allReesForm.Show();
        }

        private void ПоискГаражаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindGarageForm findGarageForm = new FindGarageForm();
            findGarageForm.Show();
        }

        private void отчётПГСКБарсовоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_create("ПГСК Барсово");
        }

        private void отчётБлагоустрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.ReportName = "Benefit";
            //reportForm.Show();
            Report_create("Благоустройство");
        }
    }
}
