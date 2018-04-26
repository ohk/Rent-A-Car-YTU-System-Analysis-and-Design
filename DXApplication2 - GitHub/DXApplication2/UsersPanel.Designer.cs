namespace DXApplication2
{
    partial class UsersPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserGroup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonthlyRent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerLicenseYear = new System.Windows.Forms.DateTimePicker();
            this.btnUpdated = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleted = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaved = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(739, 11);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(109, 21);
            this.txtUsername.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(739, 38);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(109, 21);
            this.txtpass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(739, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(109, 21);
            this.txtname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name Surname";
            // 
            // txtlicense
            // 
            this.txtlicense.Location = new System.Drawing.Point(739, 92);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(109, 21);
            this.txtlicense.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "License ID";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(739, 119);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(109, 21);
            this.txtTC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TC";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(739, 146);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(109, 21);
            this.txtAdress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adress";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(739, 173);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(109, 21);
            this.txtScore.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Score";
            // 
            // txtMembership
            // 
            this.txtMembership.Location = new System.Drawing.Point(739, 200);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.Size = new System.Drawing.Size(109, 21);
            this.txtMembership.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Member Ship Type";
            // 
            // txtUserGroup
            // 
            this.txtUserGroup.Location = new System.Drawing.Point(739, 227);
            this.txtUserGroup.Name = "txtUserGroup";
            this.txtUserGroup.Size = new System.Drawing.Size(109, 21);
            this.txtUserGroup.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "User Group";
            // 
            // txtMonthlyRent
            // 
            this.txtMonthlyRent.Location = new System.Drawing.Point(739, 254);
            this.txtMonthlyRent.Name = "txtMonthlyRent";
            this.txtMonthlyRent.Size = new System.Drawing.Size(109, 21);
            this.txtMonthlyRent.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Monthly Rent";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(651, 306);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerBirthday.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(698, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Birthday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(696, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "License Year";
            // 
            // dateTimePickerLicenseYear
            // 
            this.dateTimePickerLicenseYear.Location = new System.Drawing.Point(649, 351);
            this.dateTimePickerLicenseYear.Name = "dateTimePickerLicenseYear";
            this.dateTimePickerLicenseYear.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerLicenseYear.TabIndex = 23;
            // 
            // btnUpdated
            // 
            this.btnUpdated.ImageOptions.Image = global::DXApplication2.Properties.Resources._001_exchange__3_;
            this.btnUpdated.Location = new System.Drawing.Point(714, 380);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(77, 42);
            this.btnUpdated.TabIndex = 33;
            this.btnUpdated.Text = "Update";
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.ImageOptions.Image = global::DXApplication2.Properties.Resources._002_close_circular_button_of_a_cross__3_;
            this.btnDeleted.Location = new System.Drawing.Point(797, 380);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(77, 42);
            this.btnDeleted.TabIndex = 32;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.ImageOptions.Image = global::DXApplication2.Properties.Resources._003_save__3_;
            this.btnSaved.Location = new System.Drawing.Point(631, 380);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(77, 42);
            this.btnSaved.TabIndex = 31;
            this.btnSaved.Text = "Save";
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // UsersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 434);
            this.Controls.Add(this.btnUpdated);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerLicenseYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.txtMonthlyRent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUserGroup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMembership);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlicense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersPanel";
            this.Text = "UsersPanel";
            this.Load += new System.EventHandler(this.UsersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlicense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMonthlyRent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerLicenseYear;
        private DevExpress.XtraEditors.SimpleButton btnUpdated;
        private DevExpress.XtraEditors.SimpleButton btnDeleted;
        private DevExpress.XtraEditors.SimpleButton btnSaved;
    }
}