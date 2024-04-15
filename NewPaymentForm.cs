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
    public partial class NewPaymentForm : Form
    {
        public NewPaymentForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accntDS.s_account". При необходимости она может быть перемещена или удалена.
            this.s_accntTableAdapter.Fill(this.accntDS.s_account);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sPerP.s_persons". При необходимости она может быть перемещена или удалена.
            s_personsTableAdapter1.Fill(sPerP.s_persons);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sPerDS.s_persons". При необходимости она может быть перемещена или удалена.
            this.s_personsTableAdapter.Fill(this.sPerDS.s_persons);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sGarType.s_garage_types". При необходимости она может быть перемещена или удалена.
            this.s_garage_typesTableAdapter.Fill(this.sGarType.s_garage_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tGarDS.t_garages". При необходимости она может быть перемещена или удалена.
            this.t_garagesTableAdapter.Fill(this.tGarDS.t_garages);

        }
        private void AddPayerBtn_Click(object sender, EventArgs e)
        {
            AddPersonForm addPersonForm = new AddPersonForm();
            addPersonForm.senderName = "PayersFormNewPay";
            addPersonForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numGarcmbbx.Text = "";
            typeGarcmbbx.Text = "";
            OwnerCmbbx.Text = "";
            PayerCmbbx.Text = "";
            AccCmbbx.Text = "";
            SumTxtbx.Text = "";
        }

        private void NewPaymentBtn_Click(object sender, EventArgs e)
        {
            Class_Conn class_Conn = new Class_Conn();
            decimal meter_data = 0;
            decimal pay_sum = 0;
            bool new_pay_done = false;
            bool got_accrual = false;
            try
            {
                if (AccCmbbx.Text.IndexOf("Электричество, день") != -1)
                    meter_data = Convert.ToDecimal(daydatatxtbx.Text);
                else
                    meter_data = Convert.ToDecimal(nightdatagrpbx.Text);
            }
            catch 
            {
                meter_data = 0;
                MessageBox.Show("Проверьте правильность введённых показаний!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                pay_sum = Convert.ToDecimal(SumTxtbx.Text);
            }
            catch
            {
                pay_sum = 0;
                MessageBox.Show("Проверьте правильность введённой суммы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //добавляем платёж:
                class_Conn.ExecSQLStr(@"insert into t_payments (id_garage, id_account, meter_data, pay_sum, id_payer, date_payment)
                                    values(" + numGarcmbbx.SelectedValue.ToString() +
                                        "," + AccCmbbx.SelectedValue.ToString() +
                                        "," + meter_data.ToString() +
                                        "," + pay_sum.ToString() +
                                        "," + PayerCmbbx.SelectedValue.ToString() +
                                        "," + DateTime.Today.ToString() +
                                        ")");
                UserClass userClass = new UserClass();
                userClass.log_info("Внесён новый платёж", "id гаража = " + numGarcmbbx.SelectedValue.ToString() + ", id статьи = " + AccCmbbx.SelectedValue.ToString() + ", id плательщика = " + PayerCmbbx.SelectedValue.ToString() + ", сумма = " + pay_sum.ToString() + ", дата записи: " + DateTime.Today.ToString());
                new_pay_done = true; //внесли платёж

                //пересчитываем задолженность дебиторскую/кредиторскую:
                string ls_id_account = "0";
                string ls_comm;
                GarageClass.setnull();
                GarageClass.id = Convert.ToInt32(numGarcmbbx.SelectedValue.ToString());
                ls_id_account = AccCmbbx.SelectedValue.ToString();                
                ls_comm = "call get_accruals(" + GarageClass.id.ToString() + ", " + ls_id_account + ", " + SumTxtbx.Text + ");";
                class_Conn.ExecSQLStr(ls_comm);
                userClass.log_info("Произведён перерасчёт дебиторской/кредиторской задолженности по объекту", DateTime.Today.ToString());
                got_accrual = true; //пересчитали задолженность
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (new_pay_done != got_accrual)
            {
                string ls_mess = "Свяжитесь с разработчиком! Произошёл сбой при сохранении данных:";
                if ((new_pay_done == true) && (got_accrual = false))
                {
                    ls_mess = ls_mess + Environment.NewLine + "Платёж сохранён, но не проведён";
                }
                if ((new_pay_done == false) && (got_accrual = true)) //такого случая в данной реализации не м.б., но на всякий пишу
                {
                    ls_mess = ls_mess + Environment.NewLine + "Платёж проведён, но не сохранён";
                }
                MessageBox.Show(ls_mess,"Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AccCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((AccCmbbx.Text.IndexOf("Электричество, день") != -1) || (AccCmbbx.Text.IndexOf("Электричество, ночь") != -1))
            {
                Electricitydatagrpbx.Visible = true;
                if (AccCmbbx.Text.IndexOf("Электричество, день") != -1)
                {
                    daydatatxtbx.Visible = true;
                    label1.Visible = true;
                    nightdatagrpbx.Visible = false;
                    label2.Visible = false;
                    nightdatagrpbx.Text = "";
                }
                else
                {
                    daydatatxtbx.Visible = false;
                    label1.Visible = false;
                    nightdatagrpbx.Visible = true;
                    label2.Visible = true;
                    daydatatxtbx.Text = "";
                }
            }
            else
            {
                Electricitydatagrpbx.Visible = false;
                daydatatxtbx.Text = "";
                nightdatagrpbx.Text = "";
            }
        }
    }
}
