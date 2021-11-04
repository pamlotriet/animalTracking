using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace animalTracking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.Spotted_Animals' table. You can move, or remove it, as needed.
            this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet.Spotted_Animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.park_roads' table. You can move, or remove it, as needed.
            this.park_roadsTableAdapter.Fill(this.honnsProjectDataDataSet.park_roads);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.honnsProjectDataDataSet.animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.national_parks' table. You can move, or remove it, as needed.
            this.national_parksTableAdapter.Fill(this.honnsProjectDataDataSet.national_parks);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.national_parks' table. You can move, or remove it, as needed.
            this.national_parksTableAdapter.Fill(this.honnsProjectDataDataSet.national_parks);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.honnsProjectDataDataSet.animals);
            //set combobox selected item
            //cmbPark.SelectedIndex = 0;
            if (tCttrlDatabaseControl.SelectedIndex == 0 || tCttrlDatabaseControl.SelectedIndex == 1 || tCttrlDatabaseControl.SelectedIndex == 2)
            {
                Size = new Size(634, 344);
            }
            else if (tCttrlDatabaseControl.SelectedIndex == 3)
            {
                Size = new Size(776, 346);
            }
        }

        private void tCttrlDatabaseControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tCttrlDatabaseControl.SelectedIndex == 0 || tCttrlDatabaseControl.SelectedIndex == 1 || tCttrlDatabaseControl.SelectedIndex == 2)
            {
                Size = new Size(634, 344);
            }       
            else if (tCttrlDatabaseControl.SelectedIndex == 3)
            {
                Size = new Size(776, 346);
            }
        }

        private void backHome()
        {
            this.Hide();
            Form1 frmHome = new Form1();
            frmHome.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            backHome();
        }
        private void btnInsertAnimal_Click(object sender, EventArgs e)
        {
            string animal_name = txtAnimalName.Text;
         
            try
            {
                //insert animal
                this.animalsTableAdapter.InsertQuery(animal_name);
                //Reload the form
                this.Hide();
                Form2 frmReload = new Form2();
                frmReload.Show();
                //show success message
                MessageBox.Show("New Animal Inserted");
            }
            catch
            {
                //show error message
                MessageBox.Show("An error occured");
            }

        }

        private void btnBackPark_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void btnBackRoad_Click(object sender, EventArgs e)
        {
            backHome();
        }

        int ParkId = 0;
        private void cmbPark_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParkId = (int)cmbPark.SelectedValue;
            MessageBox.Show(ParkId.ToString());
            //loading the roads in the selected park
            this.park_roadsTableAdapter.ParkRoads(this.honnsProjectDataDataSet.park_roads,ParkId);
        }

        private void btnSABack_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void btnInsertPark_Click(object sender, EventArgs e)
        {
            string park_name = txtParkName.Text;
            
            try
            {
                //insert park
                this.national_parksTableAdapter.InsertQuery(park_name);
                //Reload the form
                this.Hide();
                Form2 frmReload = new Form2();
                frmReload.Show();
                //show success message
                MessageBox.Show("New National Park Inserted");
            }
            catch
            {
                //show error message
                MessageBox.Show("An error occured");
            }
        }

        private void btnInsertRoad_Click(object sender, EventArgs e)
        {
            string road_name = txtRoadName.Text;
            int park_id = (int)cmbParkNameRoadIns.SelectedValue;
            try
            {
                //insert new road
                this.park_roadsTableAdapter.InsertQuery(road_name, park_id);
                //reload form
                this.Hide();
                Form2 frmReload = new Form2();
                frmReload.Show();
                //show success message
                MessageBox.Show("New National Park Inserted");
            }
            catch
            {
                //show error message
                MessageBox.Show("An error occured");
            }
            
        }

        private void btnSAInsert_Click(object sender, EventArgs e)
        {
            //create variables to get values to be inserted into the spotted animals table
            int park_name_id = (int)cmbPark.SelectedValue;
            int animal_id = (int)cmbAnimal.SelectedValue;
            int road_id = (int)cmbRoad.SelectedValue;
            string time = txtTime.Text;
            string day = txtDate.Text;
            string qty = txtQty.Text;

            try
            {
                //insert spotted animal
                this.spotted_AnimalsTableAdapter.InsertQuery(park_name_id, animal_id, road_id, time, day, qty);
                //reload form
                this.Hide();
                Form2 frmReload = new Form2();
                frmReload.Show();
                //show success message
                MessageBox.Show("New Animal Sighting Inserted");
            }
            catch
            {
                //show error message
                MessageBox.Show("An error occured");
            }
            
        }

        private void txtTime_Click(object sender, EventArgs e)
        {
            txtTime.ForeColor = Color.Black;
            txtTime.Text = "";
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            txtDate.ForeColor = Color.Black;
            txtDate.Text = "";
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            txtQty.ForeColor = Color.Black;
            txtQty.Text = "";
        }


    }
}
