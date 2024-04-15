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
    public partial class SendMessForm : Form
    {
        UserClass userClass = new UserClass();
        public SendMessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               
                string userName = "ПС \"Учёт гаражей\""; //имя пользователя
                string adressTo = "Chernyavskaya_OS@mail.ru"; //адрес пользователя
                string messageSubject = "ПС \"Учёт гаражей\""; //тема
                string messageText = Messrtxtbx.Text; //текст
                userClass.Send_Message(userName, adressTo, messageSubject, messageText);
                MessageBox.Show("Сообщение отправлено по эл.почте: " + Environment.NewLine + "с адреса sgc_garages@mail.ru на адрес Chernyavskaya_OS@mail.ru", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userClass.log_info("Message sended to support", "");
            }
            catch
            {
                userClass.log_info("Error - Message not sended to support", "");
                MessageBox.Show("Сообщение эл.почты не отправлено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Messrtxtbx.Text = "";
        }
    }
}
