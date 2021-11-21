using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tur_Retur_kørselslogbog;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ViewOprettedeBruger_Click(object sender, EventArgs e)
        {
            OprettedeBrugerView oprettedeBrugerView = new OprettedeBrugerView();
            oprettedeBrugerView.Show();
        }

        private void ViewUdførterKørsler_Click(object sender, EventArgs e)
        {
            ViewUdførteKørslerForm viewUdførteKørsler = new ViewUdførteKørslerForm();
            viewUdførteKørsler.Show();
        }

        private void Opret_kørselslog_button_Click(object sender, EventArgs e)
        {
            ViewKørselslog viewKørselslog = new ViewKørselslog();
            viewKørselslog.Show();
        }
    }
}
