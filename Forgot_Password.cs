using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ООО__ЭКО_Сити_
{
    public partial class Forgot_Password : Form
    {
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        public static string connectString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public Forgot_Password()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != txtOldPassword.Text)
            {
                if(txtNewPassword.Text == txtNewPassword_replau.Text)
                {
                    string sql_select = $"SELECT email FROM Users WHERE email = '{txtEmail.Text}' AND password = '{txtOldPassword.Text}'";
                    OleDbCommand command = new OleDbCommand(sql_select, myConnection);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        string sql_update = $"UPDATE Users SET password='{txtNewPassword.Text}' WHERE email = '{txtEmail.Text}'";
                        OleDbCommand cmd = new OleDbCommand(sql_update, myConnection);
                        if (cmd.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Ошибка: Не удалось обновить пароль пользователя с таким Email: " + txtEmail.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Я вас не нашел в базе данных :(\nПроверьте правильность ввода данных!");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: Пароли не совпдают");
                    txtNewPassword.Text = string.Empty;
                    txtNewPassword_replau.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("ERROR: Новый пароль и старый пароль совпадают!");
                txtNewPassword.Text = string.Empty;
                txtNewPassword_replau.Text = string.Empty;
            }
        }
    }
}
