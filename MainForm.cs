using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        private void отчётСамостройToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "SamostroyRep";
            reportForm.Show();
        }

        private void отчётНеСамостройToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "NeSamostroyRep";
            reportForm.Show();
        }

        private void отчётЖелезныеГаражиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "FerrumRep";
            reportForm.Show();
        }

        private void отчт2хЭтажныеГаражиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "TwiceFloorGaragesRep";
            reportForm.Show();
        }

        private void отчётЭлектричествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "ElectricityRep";
            reportForm.Show();
        }

        private void отчётАрендаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "RentRep";
            reportForm.Show();
        }

        private void отчётШлагбаумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ReportName = "BarrierRep";
            reportForm.Show();
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
    }
}
