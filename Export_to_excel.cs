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
using Excel = Microsoft.Office.Interop.Excel;

namespace ООО__ЭКО_Сити_
{
    public partial class Export_to_excel : Form
    {

        //public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.mdb;";
        public static string connectString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=Database.mdb;";

        private OleDbConnection myConnection;
        public Export_to_excel()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        public void DisplayAndSearch(string query, DataGridView dvg)
        {
            string sql = query;
            OleDbCommand cmd = new OleDbCommand(sql, myConnection);

            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adp.Fill(tbl);
            dvg.DataSource = tbl;
            myConnection.Close();
        }

        public void Display()
        {
            DisplayAndSearch("SELECT * FROM Contracts WHERE user_email = '"+ DataBank.email_user_text_personal_account + "'", dataGridView);
        }

        private void Export_to_excel_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            string rep;
            for (i = 0; i <= dataGridView.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView.ColumnCount - 1; j++)
                {
                    wsh.Cells[1, j + 1] = dataGridView.Columns[j].HeaderText.ToString();
                    rep = dataGridView[j, i].Value.ToString().Replace("|", "\\");
                    wsh.Cells[i + 2, j + 1] = rep;
                }
            }
            exApp.Visible = true;
        }
    }
}
