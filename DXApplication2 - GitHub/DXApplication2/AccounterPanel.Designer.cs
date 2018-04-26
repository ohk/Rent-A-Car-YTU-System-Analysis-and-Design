namespace DXApplication2
{
    partial class AccounterPanel
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAccounting = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.adminPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dataGridViewAccounting = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdated = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountUserID = new System.Windows.Forms.TextBox();
            this.btnDeleted = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaved = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.txtAccountMoney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAccounting,
            this.btnSave,
            this.btnUpdate,
            this.btnDelete,
            this.barButtonItem1,
            this.barButtonGroup1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.adminPage});
            this.ribbon.Size = new System.Drawing.Size(808, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAccounting
            // 
            this.btnAccounting.Caption = "Accounting- Expense";
            this.btnAccounting.Id = 1;
            this.btnAccounting.ImageOptions.Image = global::DXApplication2.Properties.Resources._005_accounting;
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAccounting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccounting_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = global::DXApplication2.Properties.Resources._003_save;
            this.btnSave.Name = "btnSave";
            this.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 3;
            this.btnUpdate.ImageOptions.Image = global::DXApplication2.Properties.Resources._001_exchange;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 4;
            this.btnDelete.ImageOptions.Image = global::DXApplication2.Properties.Resources._002_close_circular_button_of_a_cross;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Accounting - Income";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = global::DXApplication2.Properties.Resources._005_accounting;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Users";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = global::DXApplication2.Properties.Resources._004_avatar;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cars";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = global::DXApplication2.Properties.Resources._006_rent_a_car;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "GPS";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.Image = global::DXApplication2.Properties.Resources._001_cursor;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Meintance Examination";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.ImageOptions.Image = global::DXApplication2.Properties.Resources._007_car;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Rents";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.ImageOptions.Image = global::DXApplication2.Properties.Resources._006_rent_a_car;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Accounting";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAccounting);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // adminPage
            // 
            this.adminPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.adminPage.Name = "adminPage";
            this.adminPage.Text = "Admin Panel";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(808, 31);
            // 
            // dataGridViewAccounting
            // 
            this.dataGridViewAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccounting.Location = new System.Drawing.Point(0, 143);
            this.dataGridViewAccounting.Name = "dataGridViewAccounting";
            this.dataGridViewAccounting.Size = new System.Drawing.Size(808, 275);
            this.dataGridViewAccounting.TabIndex = 2;
            this.dataGridViewAccounting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounting_CellContentClick);
            this.dataGridViewAccounting.Click += new System.EventHandler(this.dataGridViewAccounting_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnUpdated);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtAccountUserID);
            this.groupControl1.Controls.Add(this.btnDeleted);
            this.groupControl1.Controls.Add(this.btnSaved);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtAccountType);
            this.groupControl1.Controls.Add(this.txtAccountMoney);
            this.groupControl1.Location = new System.Drawing.Point(596, 141);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(212, 282);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "1 - Income 2- Expense";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Account User ID";
            // 
            // btnUpdated
            // 
            this.btnUpdated.ImageOptions.Image = global::DXApplication2.Properties.Resources._001_exchange__3_;
            this.btnUpdated.Location = new System.Drawing.Point(114, 161);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(77, 42);
            this.btnUpdated.TabIndex = 30;
            this.btnUpdated.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Account Type ";
            // 
            // txtAccountUserID
            // 
            this.txtAccountUserID.Location = new System.Drawing.Point(101, 48);
            this.txtAccountUserID.Name = "txtAccountUserID";
            this.txtAccountUserID.Size = new System.Drawing.Size(100, 21);
            this.txtAccountUserID.TabIndex = 24;
            // 
            // btnDeleted
            // 
            this.btnDeleted.ImageOptions.Image = global::DXApplication2.Properties.Resources._002_close_circular_button_of_a_cross__3_;
            this.btnDeleted.Location = new System.Drawing.Point(68, 209);
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(77, 42);
            this.btnDeleted.TabIndex = 29;
            this.btnDeleted.Text = "Deleted";
            // 
            // btnSaved
            // 
            this.btnSaved.ImageOptions.Image = global::DXApplication2.Properties.Resources._003_save__3_;
            this.btnSaved.Location = new System.Drawing.Point(21, 161);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(77, 42);
            this.btnSaved.TabIndex = 28;
            this.btnSaved.Text = "Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Account Money";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(103, 102);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(98, 21);
            this.txtAccountType.TabIndex = 31;
            // 
            // txtAccountMoney
            // 
            this.txtAccountMoney.Location = new System.Drawing.Point(102, 75);
            this.txtAccountMoney.Name = "txtAccountMoney";
            this.txtAccountMoney.Size = new System.Drawing.Size(100, 21);
            this.txtAccountMoney.TabIndex = 25;
            // 
            // AccounterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 449);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridViewAccounting);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "AccounterPanel";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AccounterPanel";
            this.Load += new System.EventHandler(this.AccounterPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAccounting;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewAccounting;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage adminPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.TextBox txtAccountMoney;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnUpdated;
        private DevExpress.XtraEditors.SimpleButton btnDeleted;
        private DevExpress.XtraEditors.SimpleButton btnSaved;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}