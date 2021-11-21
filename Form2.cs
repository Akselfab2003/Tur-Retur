using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Tur_Retur_kørselslogbog
{
    public partial class Form2 : Form
    {
       //Connection er den måde forbinder mig med sql serveren så jeg kan hente data der fra eller sende data der til 
        SqlConnection connection = new SqlConnection("Server=tcp:WIN-R7L5FHGJJ3M\\MSSQLSERVER01,1434;Database=KørselsLogbog; Integrated security=false; user=test; password=test;");
        string[] ArrayNames = new string[50];
        int nextWord = 0;
        public Form2()
        {
            InitializeComponent();
            //FillListBox er en metode jeg kalder med det samme så det er mugligt at vælge tidliger personer som er oprettet i systemet 
            FillListBox();
        }
        //Fylder alle ComboBoxne op med de forskelige Navn fra personer i databasen
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
               
               
                   for(int test=0;test < ArrayNames.Length; test++)
                   { if (ArrayNames[test] == StringName)
                    {
                        TestForDub = true;
                        break;
                    }
                    
                   }
                    
                      
                if(TestForDub == false)
                {
                    NavnComboBoxRediger.Items.Add(StringName);
                    NavnComboBoxSlet.Items.Add(StringName);
                    OpretKørselslogNavn.Items.Add(StringName);
                    ArrayNames[nextWord] = StringName;
                    nextWord++;
                   
                }
  
            }
            connection.Close();
        }
        //UpdateUserData bliver brugt til at opdatere data allerede i Databasen  
        void UpdateUserData()
        {
            string QueryDataFromStamData;
            if (NavnComboBoxRediger.Text.Length !=0)
            {
                 QueryDataFromStamData = string.Format("Update StamData Set Nr_plade = '{0}' where Navn = '{1}' AND Dato = '{2}'", textRedigerStamDataNrplade.Text, NavnComboBoxRediger.Text, textRedigerStamDataDato.Text);
            }
            else
            {
                QueryDataFromStamData = string.Format("update StamData SET Opgave ='{0}' where Navn = '{1}' AND Dato = '{2}' And Nr_plade = '{3}'", OpretKørselslogOpgave.Text, OpretKørselslogNavn.Text, OpretKørselslogDato.Text,OpretKørselslogNrplade.Text);
            }
            SqlCommand UpdateDataFromDatabaseStamdata = new SqlCommand(QueryDataFromStamData, connection);
            connection.Open();
            UpdateDataFromDatabaseStamdata.ExecuteNonQuery();
            connection.Close();
        }
        //listSpecificUser bliver brugt til at fremvise den data som person lige har ændret eller tilføjet. Dataene bliver vist i de to dataGridViewer 
        void listSpecificUser()
        {
            string QueryDataFromStamData;
            if (textOpretNavn.Text.Length != 0)
            {
                QueryDataFromStamData = string.Format("select Navn,Dato,Nr_plade From StamData Where Navn='{0}'", textOpretNavn.Text);
            }
            else if(NavnComboBoxRediger.Text.Length !=0)
            {
                QueryDataFromStamData = string.Format("select Navn,Dato,Nr_plade From StamData Where Navn='{0}'", NavnComboBoxRediger.Text);
            }
            else
            {
                QueryDataFromStamData = string.Format("select Navn,Dato,Nr_plade,Opgave From StamData Where Navn='{0}' AND Dato='{1}' AND Nr_plade='{2}'", OpretKørselslogNavn.Text,OpretKørselslogDato.Text,OpretKørselslogNrplade.Text);
            }
            SqlDataAdapter GetDataFromDatabaseStamdata = new SqlDataAdapter(QueryDataFromStamData, connection);
            connection.Open();
            
                DataTable DT = new DataTable();
                GetDataFromDatabaseStamdata.Fill(DT);
            if(textOpretNavn.Text.Length != 0 || NavnComboBoxRediger.Text.Length != 0)
            {
                dataGridView1.DataSource = DT;
            }

            else
            {
                OpretKørselslogDataGridView.DataSource = DT;
            }
            
            connection.Close();
        }
        //DeleteUser bliver brugt til at fjerne Personer fra databasen
        void DeleteUser()
        {
          string QueryDataFromStamData = string.Format("Delete From StamData Where Navn='{0}'", NavnComboBoxSlet.Text);
            SqlCommand UpdateDataFromDatabaseStamdata = new SqlCommand(QueryDataFromStamData, connection);
            connection.Open();
            UpdateDataFromDatabaseStamdata.ExecuteNonQuery();
            Array.Clear(ArrayNames, 0, ArrayNames.Length);
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void label17_Click(object sender, EventArgs e)
        {

        }
        
        //button1_click bliver brugt til at tilføje nye person til databasen den bliver kaldt når personen klikker på ok i opret Stamdata
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO StamData (Navn, Dato, Nr_plade) VALUES('" + textOpretNavn.Text + "','" + textOpretDato.Text  + "','" + textOpretNrPlade.Text + "');";
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            listSpecificUser();
            FillListBox();
            textOpretNavn.Clear();
            textOpretDato.Clear();
            textOpretNrPlade.Clear();
        }
        //button3_click er Cancel Knappen i Opret Stamdata
        private void button3_Click(object sender, EventArgs e)
        {
            textOpretNavn.Clear();
            textOpretDato.Clear();
            textOpretNrPlade.Clear();
        }
        //OkOpdaterRedigerStamdata_Click er ok knappen som bliver brugt til kalde UpdateUserData og listSpecificUser indtastninger i rediger stamdata
        private void OkOpdaterRedigerStamdata_Click(object sender, EventArgs e)
        {
            UpdateUserData();
            listSpecificUser();
            NavnComboBoxRediger.ResetText();
            textRedigerStamDataDato.Clear();
            textRedigerStamDataNrplade.Clear();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //CancelResetFelterRediger_Click er cancel knappen som bliver brugt til fjerne indtastninger i rediger stamdata
        private void CancelResetFelterRediger_Click(object sender, EventArgs e)
        {
            NavnComboBoxRediger.ResetText();
            textRedigerStamDataDato.Clear();
            textRedigerStamDataNrplade.Clear();
        }

        private void NavnComboBoxSlet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //CancelResetFelterSlet_Click er cancel knappen som bliver brugt til fjerne indtastninger i Slet stamdata
        private void CancelResetFelterSlet_Click(object sender, EventArgs e)
        {
            NavnComboBoxSlet.ResetText();
        }

        private void textOpretNrPlade_TextChanged(object sender, EventArgs e)
        {

        }

        private void NavnComboBoxRediger_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //OpretKørselslogOk_Click er ok knappen som bliver brugt til kalde UpdateUserData og listSpecificUser i opret kørsels log stamdata
        private void OpretKørselslogOk_Click(object sender, EventArgs e)
        {
            UpdateUserData();
            listSpecificUser();
            OpretKørselslogNavn.ResetText();
            OpretKørselslogOpgave.Clear();
            OpretKørselslogDato.Clear();
            OpretKørselslogNrplade.Clear();
        }
        //OpretKørselslogCancel_Click er cancel knappen som bliver brugt til fjerne indtastninger i Opret kørsels log
        private void OpretKørselslogCancel_Click(object sender, EventArgs e)
        {
            OpretKørselslogNavn.ResetText();
            OpretKørselslogOpgave.Clear(); 
            OpretKørselslogDato.Clear();
            OpretKørselslogNrplade.Clear();
        }
        //OkSletStamdata_Click er ok knappen som bliver brugt til kalde DeleteUser og FillListBox i Slet stamdata
        private void OkSletStamdata_Click(object sender, EventArgs e)
        {
            DeleteUser();
            NavnComboBoxSlet.ResetText();
            NavnComboBoxSlet.Items.Clear();
            NavnComboBoxRediger.Items.Clear();
            OpretKørselslogNavn.Items.Clear();
            FillListBox();
        }

        
    }
}
