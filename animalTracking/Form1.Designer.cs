
namespace animalTracking
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddRelData = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnUnifiedview = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelRelData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRelData
            // 
            this.btnAddRelData.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAddRelData.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnAddRelData.FlatAppearance.BorderSize = 0;
            this.btnAddRelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRelData.Location = new System.Drawing.Point(418, 36);
            this.btnAddRelData.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRelData.Name = "btnAddRelData";
            this.btnAddRelData.Size = new System.Drawing.Size(151, 58);
            this.btnAddRelData.TabIndex = 0;
            this.btnAddRelData.Text = "Add Relational Data";
            this.btnAddRelData.UseVisualStyleBackColor = false;
            this.btnAddRelData.Click += new System.EventHandler(this.btnAddRelData_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnExtract.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnExtract.FlatAppearance.BorderSize = 0;
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(418, 160);
            this.btnExtract.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(151, 58);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract Facebook Data";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnUnifiedview
            // 
            this.btnUnifiedview.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUnifiedview.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnUnifiedview.FlatAppearance.BorderSize = 0;
            this.btnUnifiedview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnifiedview.Location = new System.Drawing.Point(418, 222);
            this.btnUnifiedview.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnifiedview.Name = "btnUnifiedview";
            this.btnUnifiedview.Size = new System.Drawing.Size(151, 58);
            this.btnUnifiedview.TabIndex = 2;
            this.btnUnifiedview.Text = "Unified View";
            this.btnUnifiedview.UseVisualStyleBackColor = false;
            this.btnUnifiedview.Click += new System.EventHandler(this.btnUnifiedview_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(418, 284);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelRelData
            // 
            this.btnDelRelData.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDelRelData.FlatAppearance.BorderColor = System.Drawing.Color.DarkKhaki;
            this.btnDelRelData.FlatAppearance.BorderSize = 0;
            this.btnDelRelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRelData.Location = new System.Drawing.Point(418, 98);
            this.btnDelRelData.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelRelData.Name = "btnDelRelData";
            this.btnDelRelData.Size = new System.Drawing.Size(151, 58);
            this.btnDelRelData.TabIndex = 4;
            this.btnDelRelData.Text = "Delete Relational Data";
            this.btnDelRelData.UseVisualStyleBackColor = false;
            this.btnDelRelData.Click += new System.EventHandler(this.btnDelRelData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDelRelData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnifiedview);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnAddRelData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRelData;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnUnifiedview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelRelData;
    }
}

