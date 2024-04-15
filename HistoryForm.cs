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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void ПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenFind formGenFind = new FormGenFind();
            formGenFind.senderName = "LogHistoryForm";
            formGenFind.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_logTableAdapter.Fill(tLogDS.t_log);
            tLoggrd.DataSource = tLogDS.t_log;
            tLoggrd.Refresh();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tLogDS.t_log". При необходимости она может быть перемещена или удалена.
            t_logTableAdapter.Fill(tLogDS.t_log);

        }
    }
}
