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
    public partial class Personal_account : Form
    {
        public static string connectString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=Database.mdb;";
        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;

        public Personal_account()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }



        public void Personal_account_Load(object sender, EventArgs e)
        {
            emailuser.Text = DataBank.email_user_text_personal_account;

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = @"SELECT COUNT(*) FROM Contracts WHERE user_email = '" + DataBank.email_user_text_personal_account + "'";
            comm.Connection = myConnection;
            int count = (int)comm.ExecuteScalar();
            if (count > 0) //проверяем
            {
                urid_lab.Text = string.Empty;
                contract_info.Text = string.Empty;
                urid_lab.Text = "Посмотреть список договорах можно в меню";
                contract_info.Text = "Посмотреть список договорах можно в меню";
            }
            else
            {
                urid_lab.Text = "У вас нету договоров";
                contract_info.Text = "У вас нету договоров";
            }
        }
        
        private void exit_account_Click(object sender, EventArgs e)
        {
            Main Main_form = new Main();
            this.Hide();
            Main_form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword ResetPassword_form = new ResetPassword();
            ResetPassword_form.Show();
        }

        private void textBox_number_check_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox_number_check.Text == "Введите номер лиц. счета")
            {
                textBox_number_check.Text = "";
                textBox_number_check.ForeColor = Color.Black;
            }
        }

        private void textBox_surname_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_surname.Text == "Введите фамилию")
            {
                textBox_surname.Text = "";
                textBox_surname.ForeColor = Color.Black;
            }
        }

        private void send_contact_fiz_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_surname.Text) || String.IsNullOrEmpty(textBox_surname.Text))
            {
                MessageBox.Show("ERROR: Номер лиц. счета или фамилия пуста\nЗаполните пустые строки!");
            }
            else
            {
                OleDbCommand command = new OleDbCommand(
                    $"INSERT INTO [Contracts] (face_contracts, personal_account_number, surname, user_email) VALUES (@face_contracts, @personal_account_number, @surname, @user_email)",
                myConnection);

                command.Parameters.AddWithValue("face_contracts", "Физический");
                command.Parameters.AddWithValue("personal_account_number", textBox_number_check.Text);
                command.Parameters.AddWithValue("surname", textBox_surname.Text);
                command.Parameters.AddWithValue("user_email", DataBank.email_user_text_personal_account);

                command.ExecuteNonQuery();


                MessageBox.Show("Успешно!\nВы создали договор");
                Personal_account_Load(sender, e);
            }
        }

        private void number_contracts__urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (number_contracts__urid_face.Text == "Номер договора")
            {
                number_contracts__urid_face.Text = "";
                number_contracts__urid_face.ForeColor = Color.Black;
            }
        }

        private void inn_urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (inn_urid_face.Text == "ИНН")
            {
                inn_urid_face.Text = "";
                inn_urid_face.ForeColor = Color.Black;
            }
        }

        private void kpp_urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (kpp_urid_face.Text == "КПП")
            {
                kpp_urid_face.Text = "";
                kpp_urid_face.ForeColor = Color.Black;
            }
        }

        private void send_urid_face_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inn_urid_face.Text) || String.IsNullOrEmpty(number_contracts__urid_face.Text))
            {
                MessageBox.Show("ERROR: Номер договора и ИНН не заполнены!\nЗаполните пустые строки!");
            }
            else
            {

                OleDbCommand command = new OleDbCommand(
                    $"INSERT INTO [Contracts] (face_contracts, number_contracts, inn, kpp, user_email) VALUES (@face_contracts, @number_contracts, @inn, @kpp, @user_email)",
                myConnection);

                command.Parameters.AddWithValue("face_contracts", "Юридический");
                command.Parameters.AddWithValue("number_contracts", number_contracts__urid_face.Text);
                command.Parameters.AddWithValue("inn", inn_urid_face.Text);
                command.Parameters.AddWithValue("kpp", kpp_urid_face.Text);
                command.Parameters.AddWithValue("user_email", DataBank.email_user_text_personal_account);

                command.ExecuteNonQuery();
                try
                {
                    MessageBox.Show("Успешно!\nВы создали договор");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void физическийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export_to_excel_fiz exportExcel_fiz = new Export_to_excel_fiz();
            exportExcel_fiz.Show();
        }

        private void юридическийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Export_to_excel_urid exportExcel_urid = new Export_to_excel_urid();
            exportExcel_urid.Show();
        }
        
    }
}
