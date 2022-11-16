namespace importera_exportera_kunskapcampinet
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnXlsSkrivare = new System.Windows.Forms.Button();
            this.savfDatan = new System.Windows.Forms.SaveFileDialog();
            this.btnNyElev = new System.Windows.Forms.Button();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVisaElev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXlsSkrivare
            // 
            this.btnXlsSkrivare.Location = new System.Drawing.Point(313, 135);
            this.btnXlsSkrivare.Name = "btnXlsSkrivare";
            this.btnXlsSkrivare.Size = new System.Drawing.Size(111, 23);
            this.btnXlsSkrivare.TabIndex = 4;
            this.btnXlsSkrivare.Text = "Skriv ut tabellen";
            this.btnXlsSkrivare.UseVisualStyleBackColor = true;
            this.btnXlsSkrivare.Click += new System.EventHandler(this.btnXlsSkrivare_Click);
            // 
            // btnNyElev
            // 
            this.btnNyElev.Location = new System.Drawing.Point(542, 135);
            this.btnNyElev.Name = "btnNyElev";
            this.btnNyElev.Size = new System.Drawing.Size(159, 23);
            this.btnNyElev.TabIndex = 5;
            this.btnNyElev.Text = "Lägg till en ny elev";
            this.btnNyElev.UseVisualStyleBackColor = true;
            this.btnNyElev.Click += new System.EventHandler(this.btnNyElev_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(147, 106);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(132, 23);
            this.txtNamn.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(313, 106);
            this.txtPassword.MaxLength = 4;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(75, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "För-Efter namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lössenordet:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(41, 106);
            this.txtID.MaxLength = 5;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 23);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(41, 164);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 317);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnVisaElev
            // 
            this.btnVisaElev.Location = new System.Drawing.Point(41, 135);
            this.btnVisaElev.Name = "btnVisaElev";
            this.btnVisaElev.Size = new System.Drawing.Size(80, 23);
            this.btnVisaElev.TabIndex = 10;
            this.btnVisaElev.Text = "Visa Elev";
            this.btnVisaElev.UseVisualStyleBackColor = true;
            this.btnVisaElev.Click += new System.EventHandler(this.btnVisaElev_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 505);
            this.Controls.Add(this.btnVisaElev);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.btnNyElev);
            this.Controls.Add(this.btnXlsSkrivare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin sida";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnXlsSkrivare;
        private SaveFileDialog savfDatan;
        private Button btnNyElev;
        private TextBox txtNamn;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Button btnVisaElev;
    }
}