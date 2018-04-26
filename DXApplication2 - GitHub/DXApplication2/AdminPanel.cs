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

namespace DXApplication2
{
    public partial class AdminPanel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        public int UserId;
        public string UserName;

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}