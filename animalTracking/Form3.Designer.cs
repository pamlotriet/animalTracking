
namespace animalTracking
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnFindDate = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkNameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spottedAnimalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.honnsProjectDataDataSet = new animalTracking.honnsProjectDataDataSet();
            this.btnBackUni = new System.Windows.Forms.Button();
            this.cmbParks = new System.Windows.Forms.ComboBox();
            this.nationalparksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTitle = new System.Windows.Forms.Button();
            this.cmbAnimals = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkroadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.park_roadsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter();
            this.national_parksTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.national_parksTableAdapter();
            this.animalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.animalsTableAdapter();
            this.spotted_AnimalsTableAdapter = new animalTracking.honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindDate
            // 
            this.btnFindDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindDate.Location = new System.Drawing.Point(373, 167);
            this.btnFindDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindDate.Name = "btnFindDate";
            this.btnFindDate.Size = new System.Drawing.Size(140, 33);
            this.btnFindDate.TabIndex = 26;
            this.btnFindDate.Text = "Find By Date";
            this.btnFindDate.UseVisualStyleBackColor = true;
            this.btnFindDate.Click += new System.EventHandler(this.btnFindDate_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDate.Location = new System.Drawing.Point(36, 167);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(328, 30);
            this.txtDate.TabIndex = 25;
            this.txtDate.Text = "2021/10/10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 532);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Facebook Data:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.Location = new System.Drawing.Point(31, 219);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(228, 24);
            this.lblDatabase.TabIndex = 23;
            this.lblDatabase.Text = "Relational Database data:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 13.25F);
            this.richTextBox1.Location = new System.Drawing.Point(36, 559);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(1616, 206);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindAll.Location = new System.Drawing.Point(1151, 167);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(211, 33);
            this.btnFindAll.TabIndex = 27;
            this.btnFindAll.Text = "Load All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.parkNameIDDataGridViewTextBoxColumn,
            this.animalIDDataGridViewTextBoxColumn,
            this.roadIDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.road_name});
            this.dataGridView1.DataSource = this.spottedAnimalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 246);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1617, 244);
            this.dataGridView1.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkNameIDDataGridViewTextBoxColumn
            // 
            this.parkNameIDDataGridViewTextBoxColumn.DataPropertyName = "Park_Name_ID";
            this.parkNameIDDataGridViewTextBoxColumn.HeaderText = "Park_Name_ID";
            this.parkNameIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkNameIDDataGridViewTextBoxColumn.Name = "parkNameIDDataGridViewTextBoxColumn";
            this.parkNameIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "Animal_ID";
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "Animal_ID";
            this.animalIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            this.animalIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roadIDDataGridViewTextBoxColumn
            // 
            this.roadIDDataGridViewTextBoxColumn.DataPropertyName = "Road_ID";
            this.roadIDDataGridViewTextBoxColumn.HeaderText = "Road_ID";
            this.roadIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roadIDDataGridViewTextBoxColumn.Name = "roadIDDataGridViewTextBoxColumn";
            this.roadIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // road_name
            // 
            this.road_name.DataPropertyName = "road_name";
            this.road_name.HeaderText = "road_name";
            this.road_name.MinimumWidth = 6;
            this.road_name.Name = "road_name";
            this.road_name.ReadOnly = true;
            // 
            // spottedAnimalsBindingSource
            // 
            this.spottedAnimalsBindingSource.DataMember = "Spotted_Animals";
            this.spottedAnimalsBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // honnsProjectDataDataSet
            // 
            this.honnsProjectDataDataSet.DataSetName = "honnsProjectDataDataSet";
            this.honnsProjectDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBackUni
            // 
            this.btnBackUni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUni.Location = new System.Drawing.Point(1391, 167);
            this.btnBackUni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackUni.Name = "btnBackUni";
            this.btnBackUni.Size = new System.Drawing.Size(263, 33);
            this.btnBackUni.TabIndex = 19;
            this.btnBackUni.Text = "Back";
            this.btnBackUni.UseVisualStyleBackColor = true;
            this.btnBackUni.Click += new System.EventHandler(this.btnBackUni_Click);
            // 
            // cmbParks
            // 
            this.cmbParks.DataSource = this.nationalparksBindingSource;
            this.cmbParks.DisplayMember = "park_name";
            this.cmbParks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParks.FormattingEnabled = true;
            this.cmbParks.Location = new System.Drawing.Point(556, 169);
            this.cmbParks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbParks.MaxDropDownItems = 100;
            this.cmbParks.Name = "cmbParks";
            this.cmbParks.Size = new System.Drawing.Size(269, 32);
            this.cmbParks.TabIndex = 16;
            this.cmbParks.ValueMember = "park_id";
            this.cmbParks.SelectedIndexChanged += new System.EventHandler(this.cmbParks_SelectedIndexChanged);
            // 
            // nationalparksBindingSource
            // 
            this.nationalparksBindingSource.DataMember = "national_parks";
            this.nationalparksBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // btnTitle
            // 
            this.btnTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTitle.BackColor = System.Drawing.Color.Khaki;
            this.btnTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTitle.BackgroundImage")));
            this.btnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTitle.Enabled = false;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.Black;
            this.btnTitle.Location = new System.Drawing.Point(1, -12);
            this.btnTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(1671, 142);
            this.btnTitle.TabIndex = 15;
            this.btnTitle.Text = "Wild Life Tracking";
            this.btnTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // cmbAnimals
            // 
            this.cmbAnimals.DataSource = this.animalsBindingSource;
            this.cmbAnimals.DisplayMember = "animal_name";
            this.cmbAnimals.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimals.FormattingEnabled = true;
            this.cmbAnimals.Location = new System.Drawing.Point(857, 169);
            this.cmbAnimals.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAnimals.Name = "cmbAnimals";
            this.cmbAnimals.Size = new System.Drawing.Size(269, 32);
            this.cmbAnimals.TabIndex = 28;
            this.cmbAnimals.ValueMember = "animal_id";
            this.cmbAnimals.SelectedIndexChanged += new System.EventHandler(this.cmbAnimals_SelectedIndexChanged);
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "animals";
            this.animalsBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // parkroadsBindingSource
            // 
            this.parkroadsBindingSource.DataMember = "park_roads";
            this.parkroadsBindingSource.DataSource = this.honnsProjectDataDataSet;
            // 
            // park_roadsTableAdapter
            // 
            this.park_roadsTableAdapter.ClearBeforeFill = true;
            // 
            // national_parksTableAdapter
            // 
            this.national_parksTableAdapter.ClearBeforeFill = true;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // spotted_AnimalsTableAdapter
            // 
            this.spotted_AnimalsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1692, 780);
            this.Controls.Add(this.cmbAnimals);
            this.Controls.Add(this.btnFindDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackUni);
            this.Controls.Add(this.cmbParks);
            this.Controls.Add(this.btnTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unified View";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spottedAnimalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.honnsProjectDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalparksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkroadsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackUni;
        private System.Windows.Forms.ComboBox cmbParks;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.ComboBox cmbAnimals;
        private honnsProjectDataDataSet honnsProjectDataDataSet;
        private System.Windows.Forms.BindingSource parkroadsBindingSource;
        private honnsProjectDataDataSetTableAdapters.park_roadsTableAdapter park_roadsTableAdapter;
        private System.Windows.Forms.BindingSource nationalparksBindingSource;
        private honnsProjectDataDataSetTableAdapters.national_parksTableAdapter national_parksTableAdapter;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private honnsProjectDataDataSetTableAdapters.animalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.BindingSource spottedAnimalsBindingSource;
        private honnsProjectDataDataSetTableAdapters.Spotted_AnimalsTableAdapter spotted_AnimalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkNameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn road_name;
    }
}