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
    public partial class CarsPanel : DevExpress.XtraEditors.XtraForm
    {
        public CarsPanel()
        {
            InitializeComponent();
        }
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private void CarsPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _databaseQuery.TakeCarsesAll();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            _databaseQuery.AddCars(Convert.ToInt32(txtCarGroup.Text),Convert.ToInt32(txtKM.Text),txtModels.Text,txtManufac.Text,Convert.ToInt32(txtCare.Text),Convert.ToInt32(txtExam.Text),(float) Convert.ToDecimal(txtSoldPrice.Text),(float) Convert.ToInt32(txtPrice.Text));
        }

        public int carsId;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            carsId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtKM.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCarGroup.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtModels.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtManufac.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCare.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtExam.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtRentOk.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            _databaseQuery.UpdateCars(carsId,Convert.ToInt32(txtCarGroup.Text),Convert.ToInt32(txtKM.Text),txtModels.Text,txtManufac.Text,Convert.ToInt32(txtCare.Text),Convert.ToInt32(txtExam.Text),(float) Convert.ToDecimal(txtPrice.Text));
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _databaseQuery.DeleteCars(carsId);
        }
    }
}