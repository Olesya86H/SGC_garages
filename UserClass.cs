using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;



using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;



namespace SGC_garages
{
    class UserClass
    {
        string login;
        string user_name;

        public string GetLogin()
        {
            login = Environment.UserName;
            return login;
        }

        public string GetName()
        {
            string ls_comm;
            ls_comm = "select sp.fio from public.s_persons sp, public.s_users su where su.id_person = sp.id_person and su.login = '" + this.GetLogin() + "'";
            Class_Conn class_Conn = new Class_Conn();
            user_name = class_Conn.ExecSQLStr(ls_comm);
            return user_name;
        }

        public int IsSystemUser()
        {
            int is_system_user = 0;
            int li;
            string ls_comm;
            li = 0;
            ls_comm = "select count(*) from public.s_users s where s.login = '" + this.GetLogin() + "'";
            Class_Conn class_Conn = new Class_Conn();           
            li = class_Conn.ExecSQLInt(ls_comm);
            if (li > 0)
                is_system_user = 1;
            else
                is_system_user = 0;
            return is_system_user;
        }

        public void log_info(string action, string note)
        {
            string ls_comm;
            ls_comm = "call log_info('" + this.GetLogin() + "', '" + action + "', '" + note + "');";
            Class_Conn class_Conn = new Class_Conn();
            class_Conn.ExecSQLStr(ls_comm);
        }

        public void Send_Message(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = @"sgc_garages@mail.ru"; // адреса отправителя
                string pass = "8cTBeuY76an1U8ukKtqf";//"31_03_2024_16_10 - основной пароль от ящика на сайте mail.ru; 8cTBeuY76an1U8ukKtqf - доп.пароль от ящика для отправки писем в тех поддержку из этого приложения. // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Отправлено сообщение в тех.поддержку";
                mess.Body = messageText;
                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
