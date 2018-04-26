using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RentACarProjectRemastered;

namespace DXApplication2
{
    public partial class UsersPanel : DevExpress.XtraEditors.XtraForm
    {
        public UsersPanel()
        {
            InitializeComponent();
        }
        int dataID;
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private void UsersPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _databaseQuery.TakeAllUserses();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            _databaseQuery.AddUser(txtUsername.Text,txtpass.Text,txtname.Text,Convert.ToDateTime(dateTimePickerBirthday.Value),txtlicense.Text,Convert.ToDateTime(dateTimePickerLicenseYear.Value),txtTC.Text,txtAdress.Text);
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            _databaseQuery.UpdateUser(dataID,txtUsername.Text,txtpass.Text,txtname.Text,Convert.ToDateTime(dateTimePickerBirthday.Value),txtlicense.Text,Convert.ToDateTime(dateTimePickerLicenseYear.Value),txtTC.Text,txtAdress.Text);
        }
        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerBirthday.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            txtlicense.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerLicenseYear.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
            txtTC.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAdress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtScore.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtMembership.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtUserGroup.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtMonthlyRent.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            
            dataID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _databaseQuery.DeleteUser(dataID);
        }
    }
}