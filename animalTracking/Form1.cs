using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;


namespace animalTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Process writeLine;
        private void run_cmd()
        {
            writeLine = Process.Start(@"C:\Users\pamel\OneDrive\Desktop\animalTracking\ScrapeFacebook\run.bat");
            //writeLine.Kill();
  
            // writeLine.Start();
            //System.Diagnostics.Process.Start(
        }
        private void btnExtract_Click(object sender, EventArgs e)
        {
            run_cmd();

        }

        private void btnAddRelData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frmAddRelData = new Form2();
            frmAddRelData.Show();
        }

        private void btnUnifiedview_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frmUnifiedView = new Form3();
            frmUnifiedView.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelRelData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 deleteRelData = new Form4();
            deleteRelData.Show();
        }
    }
}
