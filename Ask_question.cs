using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ООО__ЭКО_Сити_
{
    public partial class Ask_question : Form
    {
        public Ask_question()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmail_user.Text == string.Empty || txtMessage.Text == string.Empty || txtTopic.Text == string.Empty || txtFio.Text == string.Empty)
            {
                MessageBox.Show("Вы не заполнили поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(txtEmail_user.Text, txtFio.Text);
            // кому отправляем
            MailAddress to = new MailAddress("На какую почту отправлять");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = txtTopic.Text;
            // текст письма
            m.Body = txtMessage.Text;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25); // SMTP кдиент пример (он не будет работать! даже не пытайся) -> ["smtp.yandex.ru", 25]
            // логин и пароль
            smtp.Credentials = new NetworkCredential("Логин smtp", "Пароль smtp");
            smtp.EnableSsl = true;
            smtp.Send(m);


            MessageBox.Show("Ваш вопрос успешно отправлен, " + txtFio.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
