namespace DXApplication2
{
    partial class MEpanel
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
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtMD = new System.Windows.Forms.DateTimePicker();
            this.dtMND = new System.Windows.Forms.DateTimePicker();
            this.dtED = new System.Windows.Forms.DateTimePicker();
            this.dtEND = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdated = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleted = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaved = new DevExpress.XtraEditors.SimpleButton();
            this.Price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(619, 12);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(200, 21);
            this.txtCarId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEcarID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Meintance Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Meintance Next Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Examination Date";
            // 
            // dtMD
            // 
            this.dtMD.Location = new System.Drawing.Point(618, 85);
            this.dtMD.Name = "dtMD";
            this.dtMD.Size = new System.Drawing.Size(200, 21);
            this.dtMD.TabIndex = 9;
            // 
            // dtMND
            // 
            this.dtMND.Location = new System.Drawing.Point(618, 112);
            this.dtMND.Name = "dtMND";
            this.dtMND.Size = new System.Drawing.Size(200, 21);
            this.dtMND.TabIndex = 10;
            // 
            // dtED
            // 
            this.dtED.Location = new System.Drawing.Point(618, 139);
            this.dtED.Name = "dtED";
            this.dtED.Size = new System.Drawing.Size(200, 21);
            this.dtED.TabIndex = 11;
            // 
            // dtEND
            // 
            this.dtEND.Location = new System.Drawing.Point(618, 166);
            this.dtEND.Name = "dtEND";
            this.dtEND.Size = new System.Drawing.Size(200, 21);
            this.dtEND.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Examination Next Date";
            // 
            // btnUpdated
            // 
            this.btnUpdated.ImageOptions.Image = global::DXApplication2.Properties.Resources._001_exchange__3_;
            this.btnUpdated.Location = new System.Drawing.Point(674, 229);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(77, 42);
            this.btnUpdated.TabIndex = 33;
            this.btnUpdated.Text = "Update";
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // btnDeleted
            // 
            this.btnDeleted.ImageOptions.Image = global::DXApplication2.Properties.Resources._002_close_circular_button_of_a_cross__3_;
            this.btnDeleted.Location = new System.Drawing.Point(628, 277);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(77, 42);
            this.btnDeleted.TabIndex = 32;
            this.btnDeleted.Text = "Deleted";
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.ImageOptions.Image = global::DXApplication2.Properties.Resources._003_save__3_;
            this.btnSaved.Location = new System.Drawing.Point(581, 229);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(77, 42);
            this.btnSaved.TabIndex = 31;
            this.btnSaved.Text = "Save";
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(556, 44);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(30, 13);
            this.Price.TabIndex = 35;
            this.Price.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(618, 39);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 21);
            this.txtPrice.TabIndex = 34;
            // 
            // MEpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 377);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnUpdated);
            this.Controls.Add(this.btnDeleted);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEND);
            this.Controls.Add(this.dtED);
            this.Controls.Add(this.dtMND);
            this.Controls.Add(this.dtMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MEpanel";
            this.Text = "MEpanel";
            this.Load += new System.EventHandler(this.MEpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtMD;
        private System.Windows.Forms.DateTimePicker dtMND;
        private System.Windows.Forms.DateTimePicker dtED;
        private System.Windows.Forms.DateTimePicker dtEND;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnUpdated;
        private DevExpress.XtraEditors.SimpleButton btnDeleted;
        private DevExpress.XtraEditors.SimpleButton btnSaved;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtPrice;
    }
}