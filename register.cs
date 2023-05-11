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
    public partial class reg_from : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public reg_from()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void reg_from_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Введите email")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text.Trim() == "")
            {
                email.Text = "Введите email";
                email.ForeColor = Color.Gray;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text.Trim() == "")
            {
                password.Text = "Введите пароль";
                password.PasswordChar = '\0';
                password.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.PasswordChar = '*';
                password.ForeColor = Color.Black;
            }
        }

        private void password_confiurm_Leave(object sender, EventArgs e)
        {
            if (password_confiurm.Text.Trim() == "")
            {
                password_confiurm.Text = "Повторите пароль";
                password_confiurm.PasswordChar = '\0';
                password_confiurm.ForeColor = Color.Gray;
            }
        }

        private void password_confiurm_Enter(object sender, EventArgs e)
        {
            if (password_confiurm.Text == "Повторите пароль")
            {
                password_confiurm.Text = "";
                password_confiurm.PasswordChar = '*';
                password_confiurm.ForeColor = Color.Black;
            }
        }

        private void register_send_Click(object sender, EventArgs e)
        {
            
            if(password.Text == password_confiurm.Text)
            {
                
                OleDbCommand command = new OleDbCommand($"INSERT INTO [users] (email, password) VALUES (@email, @password)", myConnection);

                command.Parameters.AddWithValue("email", email.Text);
                command.Parameters.AddWithValue("password", password.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно зарегистрировались!");
                DataBank.email_user_text_personal_account = email.Text;
                DataBank.password_text_personal_account = password.Text;
                SingIn SingIng_form = new SingIn();
                SingIng_form.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("ERROR: Пароли не совпадают!");
                password_confiurm.PasswordChar = '\0';
                password.PasswordChar = '\0';
                password.Text = "Введите пароль";
                password_confiurm.Text = "Повторите пароль";
            }
        }

        private void sing_in_Click(object sender, EventArgs e)
        {
            SingIn SingIng_form = new SingIn();
            this.Hide();
            SingIng_form.Show();
        }


    }
}
