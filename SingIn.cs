using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ООО__ЭКО_Сити_
{
    public partial class SingIn : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public SingIn()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void SingIn_Load(object sender, EventArgs e)
        {
            textBox1.Text = DataBank.email_user_text_personal_account;
            textBox2.Text = DataBank.password_text_personal_account;
        }

        private void SingIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.Text = "Введите email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                textBox2.Text = "Введите пароль";
                textBox2.PasswordChar = '\0';
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите пароль")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.Black;
            }
        }

        public void button_singin_Click(object sender, EventArgs e)
        {
            
            string sql_select = $"SELECT email FROM users WHERE email = '{textBox1.Text}' AND password = '{textBox2.Text}'";
            OleDbCommand command = new OleDbCommand(sql_select, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show($"Привет {textBox1.Text}");
                DataBank.email_user_text_personal_account = textBox1.Text;
                Personal_account Personal_account_form = new Personal_account();
                this.Hide();
                Personal_account_form.Show(); 
            }
            else
            {
                MessageBox.Show("ERROR: Я вас не нашел в базе данных :(\nПроверьте правильность ввода данных!");
            }
            
        }

        private void register_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg_from register_forms = new reg_from();
            this.Hide();
            register_forms.Show();
        }

        private void forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь в тех поддержку сайта");
            System.Diagnostics.Process.Start("https://ecocity26.ru/");

        }
    }
}
