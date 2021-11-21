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
    public partial class OprettedeBrugerView : Form
    {
        SqlConnection connection = new SqlConnection("Server=tcp:WIN-R7L5FHGJJ3M\\MSSQLSERVER01,1434;Database=KørselsLogbog; Integrated security=false; user=test; password=test;");
        public OprettedeBrugerView()
        {
            InitializeComponent();
            FillGridview();
        }
        public void FillGridview()
        {
            SqlDataAdapter GetDataFromDatabaseStamdata = new SqlDataAdapter("select Navn,Dato,Nr_plade From StamData", connection);
            connection.Open();
            DataTable DT = new DataTable();
            GetDataFromDatabaseStamdata.Fill(DT);
            OprettedeBrugerMedData.DataSource = DT;
            connection.Close();
        }

        private void OprettedeBrugerMedData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
