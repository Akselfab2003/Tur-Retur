using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace menu
{
    public partial class ViewUdførteKørslerForm : Form
    {
        SqlConnection connection = new SqlConnection("Server=tcp:WIN-R7L5FHGJJ3M\\MSSQLSERVER01,1434;Database=KørselsLogbog; Integrated security=false; user=test; password=test;");
        public ViewUdførteKørslerForm()
        {
            InitializeComponent();
            FillGridViewerUdførteKørsler();
        }
        public void FillGridViewerUdførteKørsler()
        { 
           // QueryDataFromStamData = string.Format("select Navn,Dato,Nr_plade From StamData Where Navn='{0}'", );
            SqlDataAdapter GetDataFromDatabaseStamdata = new SqlDataAdapter("select Navn, Dato, Nr_plade, Opgave From StamData where Opgave!='null'", connection);
            connection.Open();
            DataTable DT = new DataTable();
            GetDataFromDatabaseStamdata.Fill(DT);
            ViewUdførteKørsler.DataSource = DT;
            connection.Close();
        }

        private void ViewUdførteKørsler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUdførteKørslerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
