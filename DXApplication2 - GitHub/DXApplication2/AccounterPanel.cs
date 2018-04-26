using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using RentACarProjectRemastered;

namespace DXApplication2
{
    public partial class AccounterPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AccounterPanel()
        {
            InitializeComponent();
        }

        
        public int UserGroup;
        public int UserId;
        public string UserName;
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private int AccountingID;
        private int AccountUserId;
        private float AccountMoney;
        private int AccountType;
        private void AccounterPanel_Load(object sender, EventArgs e)
        {
            dataGridViewAccounting.DataSource = _databaseQuery.TakeAccounting();
        }

        private void btnAccounting_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            dataGridViewAccounting.DataSource = _databaseQuery.TakeAccounting().Where(u => u.accountType.Equals(2));
        }

        private void dataGridViewAccounting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //1 Gelir
            dataGridViewAccounting.DataSource = _databaseQuery.TakeAccounting().Where(u => u.accountType.Equals(1));
        }

        private void dataGridViewAccounting_Click(object sender, EventArgs e)
        {
            AccountingID = Convert.ToInt32(dataGridViewAccounting.CurrentRow.Cells[0].Value);
            AccountUserId = Convert.ToInt32(dataGridViewAccounting.CurrentRow.Cells[2].Value);
            AccountMoney = (float) dataGridViewAccounting.CurrentRow.Cells[5].Value;
            AccountType = Convert.ToInt32(dataGridViewAccounting.CurrentRow.Cells[1].Value);
            txtAccountUserID.Text = AccountUserId.ToString();
            txtAccountMoney.Text = AccountMoney.ToString();
            txtAccountType.Text = AccountType.ToString();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            AccountMoney = (float)Convert.ToDouble(txtAccountMoney.Text.ToString());
            AccountType = Convert.ToInt32(txtAccountType.Text);
            AccountUserId = Convert.ToInt32(txtAccountUserID.Text);
            _databaseQuery.UpdatePayments(AccountingID,AccountUserId,AccountType,AccountMoney);
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            AccountMoney = (float)Convert.ToDouble(txtAccountMoney.Text.ToString());
            AccountType = Convert.ToInt32(txtAccountType.Text);
            AccountUserId = Convert.ToInt32(txtAccountUserID.Text);
            _databaseQuery.AddPayments(AccountUserId,AccountMoney,AccountType);
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _databaseQuery.DeletePayments(AccountingID);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            GPSpanel _gpSpanel = new GPSpanel();
            _gpSpanel.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            RentssPanel _rentssPanel = new RentssPanel();
            _rentssPanel.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            MEpanel _mEpanel = new MEpanel();
            _mEpanel.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CarsPanel _carsPanel = new CarsPanel();
            _carsPanel.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsersPanel _usersPanel = new UsersPanel();
            _usersPanel.Show();
        }
    }
}