using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SGC_garages
{
    public partial class ReportForm : Form
    {
        UserClass userClass = new UserClass();
        public string ReportName = "";
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DateBegMtxtbx.Text = "";
            DateEndMtxtbx.Text = "";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportNametxtbx.Text = "";
            if (ReportName == "SamostroyRep")
                ReportNametxtbx.Text = "Самострой";
            if (ReportName == "NeSamostroyRep")
                ReportNametxtbx.Text = "Не самострой";
            if (ReportName == "FerrumRep")
                ReportNametxtbx.Text = "Железные гаражи";
            if (ReportName == "TwiceFloorGaragesRep")
                ReportNametxtbx.Text = "2-х этажные гаражи";
            if (ReportName == "ElectricityRep")
                ReportNametxtbx.Text = "Электричество";
            if (ReportName == "RentRep")
                ReportNametxtbx.Text = "Аренда";
            if (ReportName == "BarrierRep")
                ReportNametxtbx.Text = "Шлагбаум";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (ReportNametxtbx.Text == "")
                userClass.log_info("Report started", "Name rep = '" + ReportName + "'");
            else
                userClass.log_info("Report started", "Name rep = '" + ReportNametxtbx + "'");
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            if (ReportNametxtbx.Text == "")
                userClass.log_info("Report end", "Name rep = '" + ReportName + "'");
            else
                userClass.log_info("Report end", "Name rep = '" + ReportNametxtbx + "'");
        }
    }
}
