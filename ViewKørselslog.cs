using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class ViewKørselslog : Form
    {
        SqlConnection connection = new SqlConnection("Server=tcp:WIN-R7L5FHGJJ3M\\MSSQLSERVER01,1434;Database=KørselsLogbog; Integrated security=false; user=test; password=test;");
        string[] ArrayNames = new string[50];
        int nextWord = 0;
        public ViewKørselslog()
        {
            InitializeComponent();
            FillListBox();
        }
      

        void UpdateUserData()
        {
            string QueryDataFromStamData = string.Format("update StamData SET Opgave ='{0}' where Navn = '{1}' AND Dato = '{2}' And Nr_plade = '{3}'", OpretKørselslogOpgave.Text, OpretKørselslogNavn.Text, OpretKørselslogDato.Text, OpretKørselslogNrplade.Text); 
            SqlCommand UpdateDataFromDatabaseStamdata = new SqlCommand(QueryDataFromStamData, connection);
            connection.Open();
            UpdateDataFromDatabaseStamdata.ExecuteNonQuery();
            connection.Close();
        }
        private void ViewKørselslog_Load(object sender, EventArgs e)
        {

        }
        void FillListBox()
        {   //Vælger hvad jeg vil have fra databasen og eksekvere det samtidig med at jeg tilføre dem til en Array så der ikke bliver duplikater på listen
            string QueryDataFromStamData = "select Navn From KørselsLogbog.dbo.StamData  ;";
            SqlCommand GetDataFromDatabaseStamdata = new SqlCommand(QueryDataFromStamData, connection);
            SqlDataReader sqlDataReader;
            connection.Open();
            sqlDataReader = GetDataFromDatabaseStamdata.ExecuteReader();
            int NavnData = sqlDataReader.GetOrdinal("Navn");


            while (sqlDataReader.Read())
            {

                bool TestForDub = false;
                string StringName = sqlDataReader.GetString(NavnData);


                for (int test = 0; test < ArrayNames.Length; test++)
                {
                    if (ArrayNames[test] == StringName)
                    {
                        TestForDub = true;
                        break;
                    }

                }


                if (TestForDub == false)
                {
                    
                    OpretKørselslogNavn.Items.Add(StringName);
                    ArrayNames[nextWord] = StringName;
                    nextWord++;

                }

            }
            connection.Close();
        }

        private void OpretKørselslogNavn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpretKørselslogOk_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }
    }
}
