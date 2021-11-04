
namespace animalTracking
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeletePark = new System.Windows.Forms.Button();
            this.cmbParkDel = new System.Windows.Forms.ComboBox();
            this.nationalparksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honnsProjectDataDataSet = new animalTracking.honnsProjectDataDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackRoadDel = new System.Windows.Forms.Button();
            this.btnDeleteRoad = new System.Windows.Forms.Button();
            this.cmbRoadDel = new System.Windows.Forms.ComboBox();
            this.parkroadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbParkRoadDel = new System.Windows.Forms.ComboBox();
            this.nationalparksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackDelAni = new System.Windows.Forms.Button();
            this.btnDelAni = new System.Windows.Forms.Button();
            this.cmbDelAni = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honnsProjectDataDataSet1 = new animalTracking.honnsProjectDataDataSet();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackDelS = new System.Windows.Forms.Button();
            this.btnDelSighting = new System.Windows.Forms.Button();
            this.cmbDelSighting = new System.Windows.Forms.ComboBox();
            this.national_parksTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.national_parksTableAdapter();
            this.park_roadsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter();
            this.animalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.animalsTableAdapter();
            this.spotted_AnimalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spottedAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1145, 514);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Wheat;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.btnDeletePark);
            this.tabPage1.Controls.Add(this.cmbParkDel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1137, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Delete Park";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Park Name";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(88, 153);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(393, 62);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletePark
            // 
            this.btnDeletePark.Location = new System.Drawing.Point(88, 86);
            this.btnDeletePark.Name = "btnDeletePark";
            this.btnDeletePark.Size = new System.Drawing.Size(393, 61);
            this.btnDeletePark.TabIndex = 1;
            this.btnDeletePark.Text = "Delete Park";
            this.btnDeletePark.UseVisualStyleBackColor = true;
            this.btnDeletePark.Click += new System.EventHandler(this.btnDeletePark_Click);
            // 
            // cmbParkDel
            // 
            this.cmbParkDel.DataSource = this.nationalparksBindingSource;
            this.cmbParkDel.DisplayMember = "park_name";
            this.cmbParkDel.FormattingEnabled = true;
            this.cmbParkDel.Location = new System.Drawing.Point(227, 39);
            this.cmbParkDel.Name = "cmbParkDel";
            this.cmbParkDel.Size = new System.Drawing.Size(254, 28);
            this.cmbParkDel.TabIndex = 0;
            this.cmbParkDel.ValueMember = "park_id";
            // 
            // nationalparksBindingSource
            // 
            this.nationalparksBindingSource.DataMember = "national_parks";
            this.nationalparksBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // honnsProjectDataDataSet
            // 
            this.honnsProjectDataDataSet.DataSetName = "honnsProjectDataDataSet";
            this.honnsProjectDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnBackRoadDel);
            this.tabPage2.Controls.Add(this.btnDeleteRoad);
            this.tabPage2.Controls.Add(this.cmbRoadDel);
            this.tabPage2.Controls.Add(this.cmbParkRoadDel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1137, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Road";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Road Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Park Name";
            // 
            // btnBackRoadDel
            // 
            this.btnBackRoadDel.Location = new System.Drawing.Point(78, 157);
            this.btnBackRoadDel.Name = "btnBackRoadDel";
            this.btnBackRoadDel.Size = new System.Drawing.Size(401, 56);
            this.btnBackRoadDel.TabIndex = 3;
            this.btnBackRoadDel.Text = "Back";
            this.btnBackRoadDel.UseVisualStyleBackColor = true;
            this.btnBackRoadDel.Click += new System.EventHandler(this.btnBackRoadDel_Click);
            // 
            // btnDeleteRoad
            // 
            this.btnDeleteRoad.Location = new System.Drawing.Point(78, 99);
            this.btnDeleteRoad.Name = "btnDeleteRoad";
            this.btnDeleteRoad.Size = new System.Drawing.Size(401, 52);
            this.btnDeleteRoad.TabIndex = 2;
            this.btnDeleteRoad.Text = "Delete Road";
            this.btnDeleteRoad.UseVisualStyleBackColor = true;
            this.btnDeleteRoad.Click += new System.EventHandler(this.btnDeleteRoad_Click);
            // 
            // cmbRoadDel
            // 
            this.cmbRoadDel.DataSource = this.parkroadsBindingSource;
            this.cmbRoadDel.DisplayMember = "road_name";
            this.cmbRoadDel.FormattingEnabled = true;
            this.cmbRoadDel.Location = new System.Drawing.Point(224, 65);
            this.cmbRoadDel.Name = "cmbRoadDel";
            this.cmbRoadDel.Size = new System.Drawing.Size(255, 28);
            this.cmbRoadDel.TabIndex = 1;
            this.cmbRoadDel.ValueMember = "road_id";
            // 
            // parkroadsBindingSource
            // 
            this.parkroadsBindingSource.DataMember = "park_roads";
            this.parkroadsBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // cmbParkRoadDel
            // 
            this.cmbParkRoadDel.DataSource = this.nationalparksBindingSource1;
            this.cmbParkRoadDel.DisplayMember = "park_name";
            this.cmbParkRoadDel.FormattingEnabled = true;
            this.cmbParkRoadDel.Location = new System.Drawing.Point(224, 25);
            this.cmbParkRoadDel.Name = "cmbParkRoadDel";
            this.cmbParkRoadDel.Size = new System.Drawing.Size(255, 28);
            this.cmbParkRoadDel.TabIndex = 0;
            this.cmbParkRoadDel.ValueMember = "park_id";
            this.cmbParkRoadDel.SelectedIndexChanged += new System.EventHandler(this.cmbParkRoadDel_SelectedIndexChanged);
            // 
            // nationalparksBindingSource1
            // 
            this.nationalparksBindingSource1.DataMember = "national_parks";
            this.nationalparksBindingSource1.DataSource = this.honnsProjectDataDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Wheat;
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnBackDelAni);
            this.tabPage3.Controls.Add(this.btnDelAni);
            this.tabPage3.Controls.Add(this.cmbDelAni);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1137, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Animal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Animal";
            // 
            // btnBackDelAni
            // 
            this.btnBackDelAni.Location = new System.Drawing.Point(111, 141);
            this.btnBackDelAni.Name = "btnBackDelAni";
            this.btnBackDelAni.Size = new System.Drawing.Size(280, 47);
            this.btnBackDelAni.TabIndex = 2;
            this.btnBackDelAni.Text = "Back";
            this.btnBackDelAni.UseVisualStyleBackColor = true;
            this.btnBackDelAni.Click += new System.EventHandler(this.btnBackDelAni_Click);
            // 
            // btnDelAni
            // 
            this.btnDelAni.Location = new System.Drawing.Point(111, 93);
            this.btnDelAni.Name = "btnDelAni";
            this.btnDelAni.Size = new System.Drawing.Size(280, 42);
            this.btnDelAni.TabIndex = 1;
            this.btnDelAni.Text = "Delete Animal";
            this.btnDelAni.UseVisualStyleBackColor = true;
            this.btnDelAni.Click += new System.EventHandler(this.btnDelAni_Click);
            // 
            // cmbDelAni
            // 
            this.cmbDelAni.DataSource = this.animalsBindingSource;
            this.cmbDelAni.DisplayMember = "animal_name";
            this.cmbDelAni.FormattingEnabled = true;
            this.cmbDelAni.Location = new System.Drawing.Point(214, 51);
            this.cmbDelAni.Name = "cmbDelAni";
            this.cmbDelAni.Size = new System.Drawing.Size(177, 28);
            this.cmbDelAni.TabIndex = 0;
            this.cmbDelAni.ValueMember = "animal_id";
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.honnsProjectDataDataSet1;
            // 
            // honnsProjectDataDataSet1
            // 
            this.honnsProjectDataDataSet1.DataSetName = "honnsProjectDataDataSet";
            this.honnsProjectDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Wheat;
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.btnBackDelS);
            this.tabPage4.Controls.Add(this.btnDelSighting);
            this.tabPage4.Controls.Add(this.cmbDelSighting);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1137, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete Sighting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Sighting ID";
            // 
            // btnBackDelS
            // 
            this.btnBackDelS.Location = new System.Drawing.Point(904, 411);
            this.btnBackDelS.Name = "btnBackDelS";
            this.btnBackDelS.Size = new System.Drawing.Size(151, 43);
            this.btnBackDelS.TabIndex = 3;
            this.btnBackDelS.Text = "Back";
            this.btnBackDelS.UseVisualStyleBackColor = true;
            this.btnBackDelS.Click += new System.EventHandler(this.btnBackDelS_Click);
            // 
            // btnDelSighting
            // 
            this.btnDelSighting.Location = new System.Drawing.Point(11, 411);
            this.btnDelSighting.Name = "btnDelSighting";
            this.btnDelSighting.Size = new System.Drawing.Size(151, 43);
            this.btnDelSighting.TabIndex = 2;
            this.btnDelSighting.Text = "Delete Sighting";
            this.btnDelSighting.UseVisualStyleBackColor = true;
            this.btnDelSighting.Click += new System.EventHandler(this.btnDelSighting_Click);
            // 
            // cmbDelSighting
            // 
            this.cmbDelSighting.DataSource = this.spottedAnimalsBindingSource;
            this.cmbDelSighting.DisplayMember = "id";
            this.cmbDelSighting.FormattingEnabled = true;
            this.cmbDelSighting.Location = new System.Drawing.Point(151, 28);
            this.cmbDelSighting.Name = "cmbDelSighting";
            this.cmbDelSighting.Size = new System.Drawing.Size(99, 28);
            this.cmbDelSighting.TabIndex = 0;
            this.cmbDelSighting.ValueMember = "id";
            // 
            // national_parksTableAdapter
            // 
            this.national_parksTableAdapter.ClearBeforeFill = true;
            // 
            // park_roadsTableAdapter
            // 
            this.park_roadsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // spotted_AnimalsTableAdapter
            // 
            this.spotted_AnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.parkNameIDDataGridViewTextBoxColumn,
            this.animalIDDataGridViewTextBoxColumn,
            this.roadIDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.roadnameDataGridViewTextBoxColumn,
            this.parknameDataGridViewTextBoxColumn,
            this.animalnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spottedAnimalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 331);
            this.dataGridView1.TabIndex = 5;
            // 
            // spottedAnimalsBindingSource
            // 
            this.spottedAnimalsBindingSource.DataMember = "Spotted_Animals";
            this.spottedAnimalsBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkNameIDDataGridViewTextBoxColumn
            // 
            this.parkNameIDDataGridViewTextBoxColumn.DataPropertyName = "Park_Name_ID";
            this.parkNameIDDataGridViewTextBoxColumn.HeaderText = "Park_Name_ID";
            this.parkNameIDDataGridViewTextBoxColumn.Name = "parkNameIDDataGridViewTextBoxColumn";
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "Animal_ID";
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "Animal_ID";
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "Road_ID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "Road_ID";
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // roadnameDataGridViewTextBoxColumn
            // 
            this.roadnameDataGridViewTextBoxColumn.DataPropertyName = "road_name";
            this.roadnameDataGridViewTextBoxColumn.HeaderText = "road_name";
            this.roadnameDataGridViewTextBoxColumn.Name = "roadnameDataGridViewTextBoxColumn";
            // 
            // parknameDataGridViewTextBoxColumn
            // 
            this.parknameDataGridViewTextBoxColumn.DataPropertyName = "park_name";
            this.parknameDataGridViewTextBoxColumn.HeaderText = "park_name";
            this.parknameDataGridViewTextBoxColumn.Name = "parknameDataGridViewTextBoxColumn";
            // 
            // animalnameDataGridViewTextBoxColumn
            // 
            this.animalnameDataGridViewTextBoxColumn.DataPropertyName = "animal_name";
            this.animalnameDataGridViewTextBoxColumn.HeaderText = "animal_name";
            this.animalnameDataGridViewTextBoxColumn.Name = "animalnameDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 514);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Relational Data";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeletePark;
        private System.Windows.Forms.ComboBox cmbParkDel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private honnsProjectDataDataSet honnsProjectDataDataSet;
        private System.Windows.Forms.BindingSource nationalparksBindingSource;
        private honnsProjectDataDataSetTableAdapters.national_parksTableAdapter national_parksTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackRoadDel;
        private System.Windows.Forms.Button btnDeleteRoad;
        private System.Windows.Forms.ComboBox cmbRoadDel;
        private System.Windows.Forms.ComboBox cmbParkRoadDel;
        private System.Windows.Forms.BindingSource nationalparksBindingSource1;
        private System.Windows.Forms.BindingSource parkroadsBindingSource;
        private honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter park_roadsTableAdapter;
        private System.Windows.Forms.Button btnBackDelAni;
        private System.Windows.Forms.Button btnDelAni;
        private System.Windows.Forms.ComboBox cmbDelAni;
        private honnsProjectDataDataSet honnsProjectDataDataSet1;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private honnsProjectDataDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.ComboBox cmbDelSighting;
        private honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter spotted_AnimalsTableAdapter;
        private System.Windows.Forms.Button btnBackDelS;
        private System.Windows.Forms.Button btnDelSighting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spottedAnimalsBindingSource;
    }
}