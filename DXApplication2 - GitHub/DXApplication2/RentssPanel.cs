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
    public partial class RentssPanel : DevExpress.XtraEditors.XtraForm
    {
        public RentssPanel()
        {
            InitializeComponent();
        }
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private void RentssPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _databaseQuery.TakeRents();
        }
    }
}