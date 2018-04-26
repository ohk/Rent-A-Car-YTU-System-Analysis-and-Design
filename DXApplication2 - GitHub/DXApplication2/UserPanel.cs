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
    public partial class UserPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        public int UserGroup;
        public int UserId;
        public string UserName;
        
        private int carId;
        private float carPrice;
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        private void UserPanel_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserName);
            barStaticItem1.Caption = UserName + " Hoş Geldiniz.";
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            dataGridViewRental.DataSource = _databaseQuery.TakeCarses(UserGroup);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            dataGridViewRental.DataSource = _databaseQuery.TakeRentsBack(UserId);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewRental_Click(object sender, EventArgs e)
        {
            carId = Convert.ToInt32(dataGridViewRental.CurrentRow.Cells[0].Value);
            carPrice = Convert.ToInt32(dataGridViewRental.CurrentRow.Cells[7].Value);
        }

        private void btnPayments_ItemClick(object sender, ItemClickEventArgs e)
        {
            dataGridViewRental.DataSource = _databaseQuery.UserPayments(UserId);
        }

        private void btnRentx_ItemClick(object sender, ItemClickEventArgs e)
        {
            int days = (dateTimePickerFinish.Value - dateTimePickerStart.Value).Days;
            _databaseQuery.AddRent(dateTimePickerStart.Value, dateTimePickerFinish.Value, carId, UserId, carPrice*days);
            _databaseQuery.RentCarsUpdate(carId);

        }
    }
}