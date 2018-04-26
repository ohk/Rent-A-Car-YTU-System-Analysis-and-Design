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
    public partial class MEpanel : DevExpress.XtraEditors.XtraForm
    {
        public MEpanel()
        {
            InitializeComponent();
        }
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int meID;
        private void MEpanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _databaseQuery.TakeMeintanceExamintaions();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            meID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            dtED.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dtEND.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
            dtMD.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);
            dtMND.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            txtCarId.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            _databaseQuery.AddME(Convert.ToDateTime(dtMD.Value.Date),Convert.ToDateTime(dtMND.Value.Date),Convert.ToDateTime(dtED.Value.Date),Convert.ToDateTime(dtEND.Value.Date),Convert.ToInt32(txtCarId.Text),(float) Convert.ToDouble(txtPrice.Text));
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            _databaseQuery.UpdateMeintance(Convert.ToDateTime(dtMD.Value.Date), Convert.ToDateTime(dtMND.Value.Date), Convert.ToDateTime(dtED.Value.Date), Convert.ToDateTime(dtEND.Value.Date), Convert.ToInt32(txtCarId.Text), (float)Convert.ToDouble(txtPrice.Text));
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _databaseQuery.DeleteMeintance(meID);
        }
    }
}