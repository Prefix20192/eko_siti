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
    public partial class ResetPassword : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;

        public ResetPassword()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }



        private void now_password_MouseClick(object sender, MouseEventArgs e)
        {
            if(now_password.Text == "Текущий пароль")
            {
                now_password.Text = "";
                now_password.PasswordChar = '*';
                now_password.ForeColor = Color.Black;
            }
        }

        private void new_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_password.Text == "Новый пароль")
            {
                new_password.Text = "";
                new_password.PasswordChar = '*';
                new_password.ForeColor = Color.Black;
            }
        }

        private void new_password_confiurm_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_password_confiurm.Text == "Подтверждение нового пароля")
            {
                new_password_confiurm.Text = "";
                new_password_confiurm.PasswordChar = '*';
                new_password_confiurm.ForeColor = Color.Black;
            }
        }

        private void reset_password_Click(object sender, EventArgs e)
        {
            string sql_update = $"UPDATE [users] SET pssword = '{new_password.Text}' WHERE password = '{now_password.Text}'";
            if(new_password.Text == new_password_confiurm.Text)
            {
                OleDbCommand command = new OleDbCommand(sql_update, myConnection);

                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно сменили пароль");
                this.Hide();
                SingIn sing_in_form = new SingIn();
                sing_in_form.Show();

            }
            else
            {
                MessageBox.Show("ERROR: Пароли не совпадают!");
                new_password.PasswordChar = ' ';
                new_password_confiurm.PasswordChar = ' ';
                new_password.Text = "Введите пароль";
                new_password_confiurm.Text = "Повторите пароль";
            }
        }
    }
}
