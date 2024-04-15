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
    public partial class FormGenFind : Form
    {
        public string senderName = "";
        public string find_str = "";
        public FormGenFind()
        {            
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            find_str = Findtxtbx.Text;
            if (find_str != "")
            {
                if ((senderName == "GeneralPersonsListForm") || (senderName == "OwnersForm") ||
                    (senderName == "PayersForm") || (senderName == "UsersForm"))
                {
                    PersonClass personClass = new PersonClass();
                    personClass.set_null();
                    personClass.FIO = find_str;
                    personClass.address = find_str;
                    personClass.phone_number = find_str;
                    personClass.note = find_str;

                    if (senderName == "GeneralPersonsListForm") //фильтрация для справочника с общим списком ФИО
                    {

                        string find_sql = "SELECT id_person, fio, note, phone_number, address, is_user, is_owner, is_payer " +
                                          "FROM public.s_persons " +
                                          "WHERE UPPER(fio) like UPPER('%" + personClass.FIO + "%') " +
                                          "or UPPER(phone_number) like UPPER('%" + personClass.phone_number + "%') " +
                                          "or UPPER(address) like UPPER('%" + personClass.address + "%') " +
                                          "or UPPER(note) like UPPER('%" + personClass.note + "%') ";

                        Class_Conn cl_conn = new Class_Conn();
                        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                        NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                        npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                        DataTable dt_find = new DataTable();
                        npgsqlDataAdapter.Fill(dt_find);
                        SGC_garages.GeneralPersonsListForm.FIOListgrd.DataSource = dt_find;
                        SGC_garages.GeneralPersonsListForm.FIOListgrd.Refresh();
                    }

                    if (senderName == "OwnersForm") //фильтрация по sender'у - Справочник Собственников
                    {
                        string find_sql = "SELECT id_person, fio, note, phone_number, address, is_user, is_owner, is_payer " +
                                         "FROM public.s_persons " +
                                         "WHERE (UPPER(fio) like UPPER('%" + personClass.FIO + "%') " +
                                         "or UPPER(phone_number) like UPPER('%" + personClass.phone_number + "%') " +
                                         "or UPPER(address) like UPPER('%" + personClass.address + "%') " +
                                         "or UPPER(note) like UPPER('%" + personClass.note + "%')) " +
                                         "and is_owner = 1 ";

                        Class_Conn cl_conn = new Class_Conn();
                        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                        NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                        npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                        DataTable dt_find = new DataTable();
                        npgsqlDataAdapter.Fill(dt_find);
                        SGC_garages.OwnersForm.FIOOwnersgrd.DataSource = dt_find;
                        SGC_garages.OwnersForm.FIOOwnersgrd.Refresh();
                    }
                    if (senderName == "PayersForm") //фильтрация по sender'у - Справочник Плательщиков
                    {
                        string find_sql = "SELECT id_person, fio, note, phone_number, address, is_user, is_owner, is_payer " +
                                          "FROM public.s_persons " +
                                          "WHERE (UPPER(fio) like UPPER('%" + personClass.FIO + "%') " +
                                          "or UPPER(phone_number) like UPPER('%" + personClass.phone_number + "%') " +
                                          "or UPPER(address) like UPPER('%" + personClass.address + "%') " +
                                          "or UPPER(note) like UPPER('%" + personClass.note + "%')) " +
                                          "and is_payer = 1 ";

                        Class_Conn cl_conn = new Class_Conn();
                        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                        NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                        npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                        DataTable dt_find = new DataTable();
                        npgsqlDataAdapter.Fill(dt_find);
                        SGC_garages.PayersForm.FIOPayersgrd.DataSource = dt_find;
                        SGC_garages.PayersForm.FIOPayersgrd.Refresh();
                    }
                    if (senderName == "UsersForm") //фильтрация по sender'у - Справочник Пользователей системы
                    {
                        string find_sql = "SELECT id_person, fio, note, phone_number, address, is_user, is_owner, is_payer " +
                                         "FROM public.s_persons " +
                                         "WHERE (UPPER(fio) like UPPER('%" + personClass.FIO + "%') " +
                                         "or UPPER(phone_number) like UPPER('%" + personClass.phone_number + "%') " +
                                         "or UPPER(address) like UPPER('%" + personClass.address + "%') " +
                                         "or UPPER(note) like UPPER('%" + personClass.note + "%')) " +
                                         "and is_user = 1";

                        Class_Conn cl_conn = new Class_Conn();
                        NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                        NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                        npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                        DataTable dt_find = new DataTable();
                        npgsqlDataAdapter.Fill(dt_find);
                        SGC_garages.UsersListForm.FIOUsersgrd.DataSource = dt_find;
                        SGC_garages.UsersListForm.FIOUsersgrd.Refresh();
                    }
                }

                if (senderName == "GarageTypeForm") //фильтрация для справочника с типами гаражей
                {
                    string find_sql = "SELECT name_garage_type, note, id_garage_type " +
                                      "FROM public.s_garage_types " +
                                      "WHERE UPPER(name_garage_type) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(note) like UPPER('%" + find_str + "%') ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    SGC_garages.GarageTypeForm.GarageTypegrd.DataSource = dt_find;
                    SGC_garages.GarageTypeForm.GarageTypegrd.Refresh();
                }
                if (senderName == "AccTypeForm") //фильтрация для справочника с типами статей
                {
                    string find_sql = "SELECT name_account_type, note, id_account_type " +
                                      "FROM public.s_account_type " +
                                      "WHERE UPPER(name_account_type) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(note) like UPPER('%" + find_str + "%') ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    SGC_garages.AccTypeForm.AccTypegrd.DataSource = dt_find;
                    SGC_garages.AccTypeForm.AccTypegrd.Refresh();
                }

                if (senderName == "AccForm") //фильтрация для справочника со статьями
                {
                    string find_sql = "SELECT name_account, note, id_account_type, id_account " +
                                      "FROM public.s_account " +
                                      "WHERE UPPER(name_account) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(note) like UPPER('%" + find_str + "%') ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    SGC_garages.AccountForm.AccGrd.DataSource = dt_find;
                    SGC_garages.AccountForm.AccGrd.Refresh();
                }

                if (senderName == "AccFareValueForm") //фильтрация для справочника с тарифами статей
                {
                    string find_sql = "SELECT name_account, note, id_account_type, id_account " +
                                      "FROM t_acc_value t_acc, s_account s_acc " +
                                      "WHERE t_acc.id_account = s_acc.id_account " + 
                                      "and UPPER(s_acc.name_account) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(s_acc.note) like UPPER('%" + find_str + "%') ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    //SGC_garages.AccValueForm.FareGrd.DataSource = dt_find;
                    //SGC_garages.AccValueForm.FareGrd.Refresh();
                }

                if (senderName == "SiForm") //фильтрация для справочника единиц измерений
                {
                    string find_sql = "SELECT name_si, note, id_si " +
                                      "FROM public.s_si " +
                                      "WHERE UPPER(name_si) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(note) like UPPER('%" + find_str + "%') ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    SGC_garages.SiForm.Sigrd.DataSource = dt_find;
                    SGC_garages.SiForm.Sigrd.Refresh();
                }

                if (senderName == "LogHistoryForm") //фильтрация для таблицы логирования
                {
                    string find_sql = "SELECT sp.fio, su.login, l.date_act, l.action, l.note, l.id_log, l.id_user, sp.id_person " +
                                      "FROM t_log l, s_users su, s_persons sp " +
                                      "where sp.id_person = su.id_person " +
                                      "and su.id_user = l.id_user " +
                                      "and (UPPER(sp.fio) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(su.login) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(TO_CHAR(l.date_act, 'DD.MM.YYYY')) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(l.action) like UPPER('%" + find_str + "%') " +
                                      "or UPPER(l.note) like UPPER('%" + find_str + "%') " +
                                      ") order by date_act desc ";

                    Class_Conn cl_conn = new Class_Conn();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand(find_sql, cl_conn.npgSqlConnection);
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    npgsqlDataAdapter.SelectCommand = npgsqlCommand;
                    DataTable dt_find = new DataTable();
                    npgsqlDataAdapter.Fill(dt_find);
                    SGC_garages.HistoryForm.tLoggrd.DataSource = dt_find;
                    SGC_garages.HistoryForm.tLoggrd.Refresh();
                }

                if (senderName == "MainForm") //вызов поиска всех данных по ключевому слову из основного окна, отображаться рез-ты буду на вкладках формы SearchForm
                {
                    SearchForm searchForm = new SearchForm();
                    searchForm.Show();
                }
                this.Close();
            }
        }
    }
}
