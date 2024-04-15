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
    public partial class AddDictItemForm : Form
    {
        UserClass userClass = new UserClass();
        public string senderName = "";
        DataTable dt = new DataTable();
        public AddDictItemForm()
        {
            InitializeComponent();
        }

        private void AddDictItemForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Nametxtbx.Text = "";
            Notetxtbx.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DictItemClass dictItemClass = new DictItemClass();

            //считываем данные:           
            Class_Conn class_Conn = new Class_Conn();
            dictItemClass.set_null();

            if (Nametxtbx.Text != "")
                dictItemClass.name_item = Nametxtbx.Text;
            else
                dictItemClass.name_item = "null";

            if (Notetxtbx.Text != "")
                dictItemClass.note = Notetxtbx.Text;
            else
                dictItemClass.note = "null";

            dictItemClass.id_item = 0;

            //вносим изменения в БД:
            try
            {     
                if (senderName == "GarageTypeForm") //фильтрация по sender'у - Справочник типов гаражей
                {
                    class_Conn.ExecSQLStr("insert into public.s_garage_types (name_garage_type, note) values (" +
                                                class_Conn.neither_quoke(dictItemClass.name_item) + "," +
                                                class_Conn.neither_quoke(dictItemClass.note) +
                                       ")");
                    SGC_garages.GarageTypeForm.s_garage_typesTableAdapter.Fill(SGC_garages.GarageTypeForm.s_GarageTypesDS.s_garage_types);
                    SGC_garages.GarageTypeForm.GarageTypegrd.DataSource = SGC_garages.GarageTypeForm.s_GarageTypesDS.s_garage_types;
                    SGC_garages.GarageTypeForm.GarageTypegrd.Refresh();
                }
                if (senderName == "AccTypeForm") //фильтрация по sender'у - Справочник типов статей 
                {
                    class_Conn.ExecSQLStr("insert into public.s_account_type (name_account_type, note) values (" +
                                                class_Conn.neither_quoke(dictItemClass.name_item) + "," +
                                                class_Conn.neither_quoke(dictItemClass.note) +
                                       ")");
                    SGC_garages.AccTypeForm.s_account_typeTableAdapter.Fill(SGC_garages.AccTypeForm.accType_DS.s_account_type);
                    SGC_garages.AccTypeForm.AccTypegrd.DataSource = SGC_garages.AccTypeForm.accType_DS.s_account_type;
                    SGC_garages.AccTypeForm.AccTypegrd.Refresh();
                }
                if (senderName == "SiForm") //фильтрация по sender'у - Справочник единиц измерения
                {
                    class_Conn.ExecSQLStr("insert into public.s_si (name_si, note) values (" +
                                                class_Conn.neither_quoke(dictItemClass.name_item) + "," +
                                                class_Conn.neither_quoke(dictItemClass.note) +
                                       ")");
                    SGC_garages.SiForm.s_siTableAdapter.Fill(SGC_garages.SiForm.s_SiDS.s_si);
                    SGC_garages.SiForm.Sigrd.DataSource = SGC_garages.SiForm.s_SiDS.s_si;
                    SGC_garages.SiForm.Sigrd.Refresh();
                }
                if (senderName == "") //фильтрация по sender'у - Справочник 
                {
                    
                }

                userClass.log_info("data added to dict", "Name_item = " + dictItemClass.name_item + ", " + senderName);
                MessageBox.Show("Данные успешно сохранены!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                userClass.log_info("data not added to dict", "Name_item = " + dictItemClass.name_item + ", " + senderName);
                MessageBox.Show("Данные не сохранены!" + Environment.NewLine + "При сохранении данных произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dictItemClass.set_null();
        }
    }
}
