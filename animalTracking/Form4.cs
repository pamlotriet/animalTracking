using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalTracking
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet1.Spotted_Animals' table. You can move, or remove it, as needed.
            this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet1.Spotted_Animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet1.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.honnsProjectDataDataSet1.animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.park_roads' table. You can move, or remove it, as needed.
            this.park_roadsTableAdapter.Fill(this.honnsProjectDataDataSet.park_roads);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.national_parks' table. You can move, or remove it, as needed.
            this.national_parksTableAdapter.Fill(this.honnsProjectDataDataSet.national_parks);
            this.spotted_AnimalsTableAdapter.FillBy(this.honnsProjectDataDataSet.Spotted_Animals);

            if (tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 1 || tabControl1.SelectedIndex == 2)
            {
                Size = new Size(541, 324);
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                Size = new Size(1117, 553);
            }
            else
            {
                Size = new Size(1117, 553);
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

        private void btnBackRoadDel_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.park_roadsTableAdapter.FillBy1(this.honnsProjectDataDataSet.park_roads);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.park_roadsTableAdapter.FillBy2(this.honnsProjectDataDataSet.park_roads);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbParkRoadDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.park_roadsTableAdapter.FillByPark(this.honnsProjectDataDataSet.park_roads,(int)cmbParkRoadDel.SelectedValue);
        }

        private void btnBackDelAni_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void btnBackDelS_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0 || tabControl1.SelectedIndex == 1 || tabControl1.SelectedIndex == 2)
            {
                Size = new Size(541, 324);
            }
            else if(tabControl1.SelectedIndex == 3)
            {
                Size = new Size(1117, 553);
            }
            else
            {
                Size = new Size(1117, 553);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spotted_AnimalsTableAdapter.FillBy(this.honnsProjectDataDataSet.Spotted_Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet.Spotted_Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet1.Spotted_Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet.Spotted_Animals);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnDeletePark_Click(object sender, EventArgs e)
        {
            int park_id = (int)cmbParkDel.SelectedValue;
            this.park_roadsTableAdapter.DeleteQueryIfParkDel(park_id);
            this.national_parksTableAdapter.DeleteQuery(park_id);
            MessageBox.Show("Park was deleted.");
            reload_form();
        }

        private void btnDeleteRoad_Click(object sender, EventArgs e)
        {
            int park_id = (int)cmbParkRoadDel.SelectedValue;
            int road_id = (int)cmbRoadDel.SelectedValue;
            this.park_roadsTableAdapter.DeleteQueryRoad(road_id, park_id);
            MessageBox.Show("Road was deleted.");
            reload_form();
        }

        private void btnDelAni_Click(object sender, EventArgs e)
        {
            int animal_id = (int)cmbDelAni.SelectedValue;
            this.animalsTableAdapter.DeleteQuery(animal_id);
            MessageBox.Show("Animal was deleted.");
            reload_form();
        }

        private void reload_form()
        {
            this.Hide();
            Form4 frmReload = new Form4();
            frmReload.Show();
        }

        private void btnDelSighting_Click(object sender, EventArgs e)
        {
            int sighting_id = (int)cmbDelSighting.SelectedValue;
            this.spotted_AnimalsTableAdapter.DeleteQuery(sighting_id);
            MessageBox.Show("Sighting was deleted.");
            reload_form();
        }
    }
}
