
namespace animalTracking
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nationalparksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honnsProjectDataDataSet = new animalTracking.honnsProjectDataDataSet();
            this.tabParkRoads = new System.Windows.Forms.TabPage();
            this.cmbParkNameRoadIns = new System.Windows.Forms.ComboBox();
            this.nationalparksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.honnsProjectDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRoadPark = new System.Windows.Forms.Label();
            this.btnBackRoad = new System.Windows.Forms.Button();
            this.btnInsertRoad = new System.Windows.Forms.Button();
            this.txtRoadName = new System.Windows.Forms.TextBox();
            this.lblRoadName = new System.Windows.Forms.Label();
            this.tabParks = new System.Windows.Forms.TabPage();
            this.btnBackPark = new System.Windows.Forms.Button();
            this.btnInsertPark = new System.Windows.Forms.Button();
            this.txtParkName = new System.Windows.Forms.TextBox();
            this.lblParkName = new System.Windows.Forms.Label();
            this.tabPageAnimals = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsertAnimal = new System.Windows.Forms.Button();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.tCttrlDatabaseControl = new System.Windows.Forms.TabControl();
            this.tabPageSpottedAnimal = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSABack = new System.Windows.Forms.Button();
            this.btnSAInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cmbRoad = new System.Windows.Forms.ComboBox();
            this.parkroadsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPark = new System.Windows.Forms.ComboBox();
            this.nationalparksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parkroadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spottedAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.national_parksTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.national_parksTableAdapter();
            this.animalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.animalsTableAdapter();
            this.park_roadsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter();
            this.spotted_AnimalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter();
            this.parkroadsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.parkroadsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).BeginInit();
            this.tabParkRoads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSetBindingSource)).BeginInit();
            this.tabParks.SuspendLayout();
            this.tabPageAnimals.SuspendLayout();
            this.tCttrlDatabaseControl.SuspendLayout();
            this.tabPageSpottedAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalparksBindingSource
            // 
            this.nationalparksBindingSource.DataMember = "national_parks";
            // 
            // honnsProjectDataDataSet
            // 
            this.honnsProjectDataDataSet.DataSetName = "honnsProjectDataDataSet";
            this.honnsProjectDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabParkRoads
            // 
            this.tabParkRoads.BackColor = System.Drawing.Color.Wheat;
            this.tabParkRoads.Controls.Add(this.cmbParkNameRoadIns);
            this.tabParkRoads.Controls.Add(this.lblRoadPark);
            this.tabParkRoads.Controls.Add(this.btnBackRoad);
            this.tabParkRoads.Controls.Add(this.btnInsertRoad);
            this.tabParkRoads.Controls.Add(this.txtRoadName);
            this.tabParkRoads.Controls.Add(this.lblRoadName);
            this.tabParkRoads.Location = new System.Drawing.Point(4, 29);
            this.tabParkRoads.Name = "tabParkRoads";
            this.tabParkRoads.Padding = new System.Windows.Forms.Padding(3);
            this.tabParkRoads.Size = new System.Drawing.Size(859, 334);
            this.tabParkRoads.TabIndex = 2;
            this.tabParkRoads.Text = "Insert new park road";
            // 
            // cmbParkNameRoadIns
            // 
            this.cmbParkNameRoadIns.DataSource = this.nationalparksBindingSource2;
            this.cmbParkNameRoadIns.DisplayMember = "park_name";
            this.cmbParkNameRoadIns.FormattingEnabled = true;
            this.cmbParkNameRoadIns.Location = new System.Drawing.Point(281, 79);
            this.cmbParkNameRoadIns.Name = "cmbParkNameRoadIns";
            this.cmbParkNameRoadIns.Size = new System.Drawing.Size(207, 28);
            this.cmbParkNameRoadIns.TabIndex = 13;
            this.cmbParkNameRoadIns.ValueMember = "park_id";
            // 
            // nationalparksBindingSource2
            // 
            this.nationalparksBindingSource2.DataMember = "national_parks";
            this.nationalparksBindingSource2.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // honnsProjectDataDataSetBindingSource
            // 
            this.honnsProjectDataDataSetBindingSource.DataSource = this.honnsProjectDataDataSet;
            this.honnsProjectDataDataSetBindingSource.Position = 0;
            // 
            // lblRoadPark
            // 
            this.lblRoadPark.AutoSize = true;
            this.lblRoadPark.Location = new System.Drawing.Point(135, 82);
            this.lblRoadPark.Name = "lblRoadPark";
            this.lblRoadPark.Size = new System.Drawing.Size(140, 20);
            this.lblRoadPark.TabIndex = 12;
            this.lblRoadPark.Text = "Select Park Name:";
            // 
            // btnBackRoad
            // 
            this.btnBackRoad.Location = new System.Drawing.Point(138, 171);
            this.btnBackRoad.Name = "btnBackRoad";
            this.btnBackRoad.Size = new System.Drawing.Size(350, 41);
            this.btnBackRoad.TabIndex = 11;
            this.btnBackRoad.Text = "Back";
            this.btnBackRoad.UseVisualStyleBackColor = true;
            this.btnBackRoad.Click += new System.EventHandler(this.btnBackRoad_Click);
            // 
            // btnInsertRoad
            // 
            this.btnInsertRoad.Location = new System.Drawing.Point(138, 124);
            this.btnInsertRoad.Name = "btnInsertRoad";
            this.btnInsertRoad.Size = new System.Drawing.Size(350, 41);
            this.btnInsertRoad.TabIndex = 10;
            this.btnInsertRoad.Text = "Insert Road";
            this.btnInsertRoad.UseVisualStyleBackColor = true;
            this.btnInsertRoad.Click += new System.EventHandler(this.btnInsertRoad_Click);
            // 
            // txtRoadName
            // 
            this.txtRoadName.Location = new System.Drawing.Point(282, 47);
            this.txtRoadName.Name = "txtRoadName";
            this.txtRoadName.Size = new System.Drawing.Size(206, 26);
            this.txtRoadName.TabIndex = 9;
            // 
            // lblRoadName
            // 
            this.lblRoadName.AutoSize = true;
            this.lblRoadName.Location = new System.Drawing.Point(135, 53);
            this.lblRoadName.Name = "lblRoadName";
            this.lblRoadName.Size = new System.Drawing.Size(141, 20);
            this.lblRoadName.TabIndex = 8;
            this.lblRoadName.Text = "Enter Road Name:";
            // 
            // tabParks
            // 
            this.tabParks.BackColor = System.Drawing.Color.Wheat;
            this.tabParks.Controls.Add(this.btnBackPark);
            this.tabParks.Controls.Add(this.btnInsertPark);
            this.tabParks.Controls.Add(this.txtParkName);
            this.tabParks.Controls.Add(this.lblParkName);
            this.tabParks.Location = new System.Drawing.Point(4, 29);
            this.tabParks.Name = "tabParks";
            this.tabParks.Padding = new System.Windows.Forms.Padding(3);
            this.tabParks.Size = new System.Drawing.Size(859, 334);
            this.tabParks.TabIndex = 1;
            this.tabParks.Text = "Insert new Park";
            // 
            // btnBackPark
            // 
            this.btnBackPark.Location = new System.Drawing.Point(176, 151);
            this.btnBackPark.Name = "btnBackPark";
            this.btnBackPark.Size = new System.Drawing.Size(250, 41);
            this.btnBackPark.TabIndex = 7;
            this.btnBackPark.Text = "Back";
            this.btnBackPark.UseVisualStyleBackColor = true;
            this.btnBackPark.Click += new System.EventHandler(this.btnBackPark_Click);
            // 
            // btnInsertPark
            // 
            this.btnInsertPark.Location = new System.Drawing.Point(175, 104);
            this.btnInsertPark.Name = "btnInsertPark";
            this.btnInsertPark.Size = new System.Drawing.Size(250, 41);
            this.btnInsertPark.TabIndex = 6;
            this.btnInsertPark.Text = "Insert Park";
            this.btnInsertPark.UseVisualStyleBackColor = true;
            this.btnInsertPark.Click += new System.EventHandler(this.btnInsertPark_Click);
            // 
            // txtParkName
            // 
            this.txtParkName.Location = new System.Drawing.Point(312, 46);
            this.txtParkName.Name = "txtParkName";
            this.txtParkName.Size = new System.Drawing.Size(113, 26);
            this.txtParkName.TabIndex = 5;
            // 
            // lblParkName
            // 
            this.lblParkName.AutoSize = true;
            this.lblParkName.Location = new System.Drawing.Point(172, 49);
            this.lblParkName.Name = "lblParkName";
            this.lblParkName.Size = new System.Drawing.Size(134, 20);
            this.lblParkName.TabIndex = 4;
            this.lblParkName.Text = "Enter Park Name:";
            // 
            // tabPageAnimals
            // 
            this.tabPageAnimals.BackColor = System.Drawing.Color.Wheat;
            this.tabPageAnimals.Controls.Add(this.btnBack);
            this.tabPageAnimals.Controls.Add(this.btnInsertAnimal);
            this.tabPageAnimals.Controls.Add(this.txtAnimalName);
            this.tabPageAnimals.Controls.Add(this.lblAnimalName);
            this.tabPageAnimals.Location = new System.Drawing.Point(4, 29);
            this.tabPageAnimals.Name = "tabPageAnimals";
            this.tabPageAnimals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnimals.Size = new System.Drawing.Size(859, 334);
            this.tabPageAnimals.TabIndex = 0;
            this.tabPageAnimals.Text = "Insert new animal";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsertAnimal
            // 
            this.btnInsertAnimal.Location = new System.Drawing.Point(170, 111);
            this.btnInsertAnimal.Name = "btnInsertAnimal";
            this.btnInsertAnimal.Size = new System.Drawing.Size(265, 41);
            this.btnInsertAnimal.TabIndex = 2;
            this.btnInsertAnimal.Text = "Insert Animal";
            this.btnInsertAnimal.UseVisualStyleBackColor = true;
            this.btnInsertAnimal.Click += new System.EventHandler(this.btnInsertAnimal_Click);
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(322, 47);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(113, 26);
            this.txtAnimalName.TabIndex = 1;
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(166, 50);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(150, 20);
            this.lblAnimalName.TabIndex = 0;
            this.lblAnimalName.Text = "Enter Animal Name:";
            // 
            // tCttrlDatabaseControl
            // 
            this.tCttrlDatabaseControl.Controls.Add(this.tabPageAnimals);
            this.tCttrlDatabaseControl.Controls.Add(this.tabParks);
            this.tCttrlDatabaseControl.Controls.Add(this.tabParkRoads);
            this.tCttrlDatabaseControl.Controls.Add(this.tabPageSpottedAnimal);
            this.tCttrlDatabaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCttrlDatabaseControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCttrlDatabaseControl.Location = new System.Drawing.Point(0, 0);
            this.tCttrlDatabaseControl.Name = "tCttrlDatabaseControl";
            this.tCttrlDatabaseControl.SelectedIndex = 0;
            this.tCttrlDatabaseControl.Size = new System.Drawing.Size(867, 367);
            this.tCttrlDatabaseControl.TabIndex = 0;
            this.tCttrlDatabaseControl.SelectedIndexChanged += new System.EventHandler(this.tCttrlDatabaseControl_SelectedIndexChanged);
            // 
            // tabPageSpottedAnimal
            // 
            this.tabPageSpottedAnimal.BackColor = System.Drawing.Color.Wheat;
            this.tabPageSpottedAnimal.Controls.Add(this.txtDate);
            this.tabPageSpottedAnimal.Controls.Add(this.label6);
            this.tabPageSpottedAnimal.Controls.Add(this.btnSABack);
            this.tabPageSpottedAnimal.Controls.Add(this.btnSAInsert);
            this.tabPageSpottedAnimal.Controls.Add(this.label5);
            this.tabPageSpottedAnimal.Controls.Add(this.label4);
            this.tabPageSpottedAnimal.Controls.Add(this.label3);
            this.tabPageSpottedAnimal.Controls.Add(this.label2);
            this.tabPageSpottedAnimal.Controls.Add(this.label1);
            this.tabPageSpottedAnimal.Controls.Add(this.txtQty);
            this.tabPageSpottedAnimal.Controls.Add(this.txtTime);
            this.tabPageSpottedAnimal.Controls.Add(this.cmbRoad);
            this.tabPageSpottedAnimal.Controls.Add(this.cmbAnimal);
            this.tabPageSpottedAnimal.Controls.Add(this.cmbPark);
            this.tabPageSpottedAnimal.Location = new System.Drawing.Point(4, 29);
            this.tabPageSpottedAnimal.Name = "tabPageSpottedAnimal";
            this.tabPageSpottedAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpottedAnimal.Size = new System.Drawing.Size(859, 334);
            this.tabPageSpottedAnimal.TabIndex = 3;
            this.tabPageSpottedAnimal.Text = "Insert new spotted animal";
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDate.Location = new System.Drawing.Point(216, 178);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(172, 26);
            this.txtDate.TabIndex = 14;
            this.txtDate.Text = "2021/07/12";
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter Day";
            // 
            // btnSABack
            // 
            this.btnSABack.Location = new System.Drawing.Point(410, 186);
            this.btnSABack.Name = "btnSABack";
            this.btnSABack.Size = new System.Drawing.Size(239, 53);
            this.btnSABack.TabIndex = 12;
            this.btnSABack.Text = "Back";
            this.btnSABack.UseVisualStyleBackColor = true;
            this.btnSABack.Click += new System.EventHandler(this.btnSABack_Click);
            // 
            // btnSAInsert
            // 
            this.btnSAInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSAInsert.Location = new System.Drawing.Point(410, 36);
            this.btnSAInsert.Name = "btnSAInsert";
            this.btnSAInsert.Size = new System.Drawing.Size(239, 52);
            this.btnSAInsert.TabIndex = 11;
            this.btnSAInsert.Text = "Insert Sighting";
            this.btnSAInsert.UseVisualStyleBackColor = true;
            this.btnSAInsert.Click += new System.EventHandler(this.btnSAInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Road";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Park";
            // 
            // txtQty
            // 
            this.txtQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtQty.Location = new System.Drawing.Point(216, 213);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(172, 26);
            this.txtQty.TabIndex = 4;
            this.txtQty.Text = "i.e. pride or 10";
            this.txtQty.Click += new System.EventHandler(this.txtQty_Click);
            // 
            // txtTime
            // 
            this.txtTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTime.Location = new System.Drawing.Point(216, 141);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(172, 26);
            this.txtTime.TabIndex = 3;
            this.txtTime.Text = "i.e. 14:02";
            this.txtTime.Click += new System.EventHandler(this.txtTime_Click);
            // 
            // cmbRoad
            // 
            this.cmbRoad.DataSource = this.parkroadsBindingSource1;
            this.cmbRoad.DisplayMember = "road_name";
            this.cmbRoad.FormattingEnabled = true;
            this.cmbRoad.Location = new System.Drawing.Point(216, 105);
            this.cmbRoad.Name = "cmbRoad";
            this.cmbRoad.Size = new System.Drawing.Size(172, 28);
            this.cmbRoad.TabIndex = 2;
            this.cmbRoad.ValueMember = "road_id";
            // 
            // parkroadsBindingSource1
            // 
            this.parkroadsBindingSource1.DataMember = "park_roads";
            this.parkroadsBindingSource1.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.DataSource = this.animalsBindingSource;
            this.cmbAnimal.DisplayMember = "animal_name";
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(216, 71);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(172, 28);
            this.cmbAnimal.TabIndex = 1;
            this.cmbAnimal.ValueMember = "animal_id";
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // cmbPark
            // 
            this.cmbPark.DataSource = this.nationalparksBindingSource1;
            this.cmbPark.DisplayMember = "park_name";
            this.cmbPark.FormattingEnabled = true;
            this.cmbPark.Location = new System.Drawing.Point(216, 36);
            this.cmbPark.Name = "cmbPark";
            this.cmbPark.Size = new System.Drawing.Size(172, 28);
            this.cmbPark.TabIndex = 0;
            this.cmbPark.ValueMember = "park_id";
            this.cmbPark.SelectedIndexChanged += new System.EventHandler(this.cmbPark_SelectedIndexChanged);
            // 
            // nationalparksBindingSource1
            // 
            this.nationalparksBindingSource1.DataMember = "national_parks";
            this.nationalparksBindingSource1.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // parkroadsBindingSource
            // 
            this.parkroadsBindingSource.DataMember = "park_roads";
            // 
            // spottedAnimalsBindingSource
            // 
            this.spottedAnimalsBindingSource.DataMember = "Spotted_Animals";
            // 
            // national_parksTableAdapter
            // 
            this.national_parksTableAdapter.ClearBeforeFill = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // park_roadsTableAdapter
            // 
            this.park_roadsTableAdapter.ClearBeforeFill = true;
            // 
            // spotted_AnimalsTableAdapter
            // 
            this.spotted_AnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // parkroadsBindingSource2
            // 
            this.parkroadsBindingSource2.DataMember = "park_roads";
            this.parkroadsBindingSource2.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // parkroadsBindingSource3
            // 
            this.parkroadsBindingSource3.DataMember = "park_roads";
            this.parkroadsBindingSource3.DataSource = this.honnsProjectDataDataSetBindingSource;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 367);
            this.Controls.Add(this.tCttrlDatabaseControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Relational Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).EndInit();
            this.tabParkRoads.ResumeLayout(false);
            this.tabParkRoads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSetBindingSource)).EndInit();
            this.tabParks.ResumeLayout(false);
            this.tabParks.PerformLayout();
            this.tabPageAnimals.ResumeLayout(false);
            this.tabPageAnimals.PerformLayout();
            this.tCttrlDatabaseControl.ResumeLayout(false);
            this.tabPageSpottedAnimal.ResumeLayout(false);
            this.tabPageSpottedAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nationalparksBindingSource;
        private honnsProjectDataDataSet honnsProjectDataDataSet;
        private System.Windows.Forms.TabPage tabParkRoads;
        private System.Windows.Forms.ComboBox cmbParkNameRoadIns;
        private System.Windows.Forms.Label lblRoadPark;
        private System.Windows.Forms.Button btnBackRoad;
        private System.Windows.Forms.Button btnInsertRoad;
        private System.Windows.Forms.TextBox txtRoadName;
        private System.Windows.Forms.Label lblRoadName;
        private System.Windows.Forms.TabPage tabParks;
        private System.Windows.Forms.Button btnBackPark;
        private System.Windows.Forms.Button btnInsertPark;
        private System.Windows.Forms.TextBox txtParkName;
        private System.Windows.Forms.Label lblParkName;
        private System.Windows.Forms.TabPage tabPageAnimals;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsertAnimal;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.TabControl tCttrlDatabaseControl;
        private System.Windows.Forms.TabPage tabPageSpottedAnimal;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSABack;
        private System.Windows.Forms.Button btnSAInsert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cmbRoad;
        private System.Windows.Forms.BindingSource parkroadsBindingSource;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private System.Windows.Forms.BindingSource honnsProjectDataDataSetBindingSource;
        private System.Windows.Forms.ComboBox cmbPark;
        private System.Windows.Forms.BindingSource spottedAnimalsBindingSource;
        private honnsProjectDataDataSetTableAdapters.national_parksTableAdapter national_parksTableAdapter;
        private honnsProjectDataDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter park_roadsTableAdapter;
        private honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter spotted_AnimalsTableAdapter;
        private System.Windows.Forms.BindingSource nationalparksBindingSource1;
        private System.Windows.Forms.BindingSource parkroadsBindingSource1;
        private System.Windows.Forms.BindingSource parkroadsBindingSource2;
        private System.Windows.Forms.BindingSource nationalparksBindingSource2;
        private System.Windows.Forms.BindingSource parkroadsBindingSource3;
    }
}