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

namespace animalTracking
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string[] fileData;
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.Spotted_Animals' table. You can move, or remove it, as needed.
            this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet.Spotted_Animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.honnsProjectDataDataSet.animals);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.national_parks' table. You can move, or remove it, as needed.
            this.national_parksTableAdapter.Fill(this.honnsProjectDataDataSet.national_parks);
            // TODO: This line of code loads data into the 'honnsProjectDataDataSet.park_roads' table. You can move, or remove it, as needed.
            this.park_roadsTableAdapter.Fill(this.honnsProjectDataDataSet.park_roads);
            this.cmbParks.Text = "Park";
            this.cmbAnimals.Text = "Animals";
           
        }

        private void btnBackUni_Click(object sender, EventArgs e)
        {
            backHome();
        }

        private void backHome()
        {
            this.Hide();
            Form1 frmHome = new Form1();
            frmHome.Show();
        }



        string find_by_date;
        private void btnFindDate_Click(object sender, EventArgs e)
        {
            find_by_date = txtDate.Text;
            fileData = System.IO.File.ReadAllLines(@"C:\Users\pamel\OneDrive\Desktop\animalTracking\animalTracking\bin\Debug\Articles.txt");
            //getting the date to find values by
            richTextBox1.Clear();
            DateTime fbDate = DateTime.Parse(find_by_date.ToString());
            //fbDate = fbDate.ToLongDateString();
            int month = fbDate.Month;
            string finalMonth = "";
            int day = fbDate.Day;
            string find_fb_date = "";

            switch(month)
            {
                case 1:
                    finalMonth = "January";
                    break;
                case 2:
                    finalMonth = "Febuary";
                    break;
                case 3:
                    finalMonth = "March";
                    break;
                case 4:
                    finalMonth = "April";
                    break;
                case 5:
                    finalMonth = "May";
                    break;
                case 6:
                    finalMonth = "June";
                    break;
                case 7:
                    finalMonth = "July";
                    break;
                case 8:
                    finalMonth = "August";
                    break;
                case 9:
                    finalMonth = "September";
                    break;
                case 10:
                    finalMonth = "October";
                    break;
                case 11:
                    finalMonth = "November";
                    break;
                case 12:
                    finalMonth = "December";
                    break;
                default:
                    finalMonth = "";
                break;
            }

            find_fb_date = day.ToString() + ' ' + finalMonth;

            //MessageBox.Show(find_fb_date);

            if (find_by_date == "")
            {
                MessageBox.Show("Please enter a date in the form of yyyy/mm/dd");
            }
            else
            {
                for(int i = 0; i < fileData.Length;i++)
                {
                    
                    if (fileData[i].Contains(find_fb_date))
                    {
                        richTextBox1.Text += fileData[i];
                    }
                }

                try
                {
                    this.spotted_AnimalsTableAdapter.FillByDate(this.honnsProjectDataDataSet.Spotted_Animals, find_by_date);
                }
                catch
                {
                    MessageBox.Show("Please enter a date");

                }


            }
            

        }

        int selectAnimal ;
        int selectPark ;
        private string find_fb_date = "";

        private void cmbParks_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            find_data();   
        }

        private void find_data()
        {
            if(txtDate.Text != "")
            {
                find_by_date = txtDate.Text;
                fileData = System.IO.File.ReadAllLines(@"C:\Users\pamel\OneDrive\Desktop\animalTracking\animalTracking\bin\Debug\Articles.txt");
                //getting the date to find values by
                richTextBox1.Clear();
                DateTime fbDate = Convert.ToDateTime(find_by_date);
                //fbDate = fbDate.ToLongDateString();
                int month = fbDate.Month;
                string finalMonth = "";
                int day = fbDate.Day;
                string find_fb_date = "";

                switch (month)
                {
                    case 1:
                        finalMonth = "January";
                        break;
                    case 2:
                        finalMonth = "Febuary";
                        break;
                    case 3:
                        finalMonth = "March";
                        break;
                    case 4:
                        finalMonth = "April";
                        break;
                    case 5:
                        finalMonth = "May";
                        break;
                    case 6:
                        finalMonth = "June";
                        break;
                    case 7:
                        finalMonth = "July";
                        break;
                    case 8:
                        finalMonth = "August";
                        break;
                    case 9:
                        finalMonth = "September";
                        break;
                    case 10:
                        finalMonth = "October";
                        break;
                    case 11:
                        finalMonth = "November";
                        break;
                    case 12:
                        finalMonth = "December";
                        break;
                    default:
                        finalMonth = "";
                        break;
                }

                find_fb_date = day.ToString() + ' ' + finalMonth;
            }
            else
            {
                find_by_date = "";
            }

            fileData = System.IO.File.ReadAllLines(@"C:\Users\pamel\OneDrive\Desktop\animalTracking\animalTracking\bin\Debug\Articles.txt");
            selectAnimal = (int)cmbAnimals.SelectedValue;
           // MessageBox.Show(selectPark.ToString());
            selectPark = (int)cmbParks.SelectedValue;
            //MessageBox.Show(selectAnimal.ToString());
            find_by_date = txtDate.Text;
            
            //find by date only
            if (find_by_date != "" && selectAnimal == -1 && selectPark == -1)
            {
                this.spotted_AnimalsTableAdapter.getByDate(this.honnsProjectDataDataSet.Spotted_Animals, find_by_date);
            }
            //find by date and park
            else if (find_by_date != "" && selectAnimal == -1 && selectPark != -1)
            {
                this.spotted_AnimalsTableAdapter.FillDatePark(this.honnsProjectDataDataSet.Spotted_Animals, find_by_date, selectPark);
            }
            //find by date, park, and animal
            else if (find_by_date != "" && selectAnimal != -1 && selectPark != -1)
            {
                this.spotted_AnimalsTableAdapter.FilDPA(this.honnsProjectDataDataSet.Spotted_Animals, find_by_date, selectPark, selectAnimal);
            }
            //Find by animal only
            else if (find_by_date == "" && selectAnimal != -1 && selectPark == -1)
            {
                this.spotted_AnimalsTableAdapter.FillByAnimal(this.honnsProjectDataDataSet.Spotted_Animals, selectAnimal);
              
            }
            //Find by park only
            else if (find_by_date == "" && selectAnimal == -1 && selectPark != -1)
            {
                this.spotted_AnimalsTableAdapter.FillByPark(this.honnsProjectDataDataSet.Spotted_Animals, selectPark);
            }
            //find by animal and park
            else if (find_by_date == "" && selectAnimal != -1 && selectPark != -1)
            {
                try
                {
                    this.spotted_AnimalsTableAdapter.FillByAniPark(this.honnsProjectDataDataSet.Spotted_Animals, selectPark, selectAnimal);
                }
                catch
                {
                    MessageBox.Show("Somethig went wrong.");
                }
               
            }
            //find by animal and date
            else if (find_by_date != "" && selectAnimal != -1 && selectPark == -1)
            {
                this.spotted_AnimalsTableAdapter.FillByDateAni(this.honnsProjectDataDataSet.Spotted_Animals, find_by_date, selectAnimal);
            }
            else
            {
                //show error message
                MessageBox.Show("Something went wrong.");
            }

            
            //find facebook data
            //find by animal name
            
            //find by parks and animals
            if(selectAnimal != -1 && selectPark != -1)
            {
                for (int i = 0; i < fileData.Length; i++)
                {
                    if(find_by_date == "")
                    {
                        if (fileData[i].Contains(cmbParks.Text.ToLower().ToString()) || fileData[i].Contains(cmbParks.Text.ToUpper().ToString()) || fileData[i].Contains(cmbParks.Text.ToString()) || fileData[i].Contains(cmbAnimals.Text.ToLower().ToString()) || fileData[i].Contains(cmbAnimals.Text.ToUpper().ToString()) || fileData[i].Contains(cmbAnimals.Text.ToString()))
                        {
                            richTextBox1.Text += fileData[i] + '\n' + '\n';
                        }
                    }
                    else
                    {
                       if(find_fb_date != "" )
                        {
                            if (fileData[i].Contains(find_fb_date) && fileData[i].Contains(cmbParks.Text.ToString()) && fileData[i].Contains(cmbAnimals.Text.ToString()))
                            {
                                richTextBox1.Text += fileData[i];
                            }
                        }
                    }   
                }
            }
       
        }

        private void cmbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            find_data();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //open the picture when link is clicked in richtextbox
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            fileData = System.IO.File.ReadAllLines(@"C:\Users\pamel\OneDrive\Desktop\animalTracking\animalTracking\bin\Debug\Articles.txt");
            selectAnimal = (int)cmbAnimals.SelectedValue;
            richTextBox1.Clear();
            this.spotted_AnimalsTableAdapter.Fill(this.honnsProjectDataDataSet.Spotted_Animals);
            for(int i =0; i<fileData.Length;i++)
            {
                richTextBox1.Text += fileData[i] + '\n' + '\n';
            }
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            this.txtDate.ForeColor = Color.Black;
            this.txtDate.Text = "";
        }

    }
}
