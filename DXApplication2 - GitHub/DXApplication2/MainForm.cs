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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DatabaseQuery _databaseQuery = new DatabaseQuery();
        public int _UserId = 0;
        public string _UserName = "";
        public int _UserGroup;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dataGridViewLoginTakeId.DataSource = _databaseQuery.Login(txtUsername.Text, txtPassword.Text);
            try
            {
                if (dataGridViewLoginTakeId.Rows[0].Cells[1].Value.ToString() != null)
                {
                    _UserId = Convert.ToInt32(dataGridViewLoginTakeId.Rows[0].Cells[0].Value);
                    _UserName = dataGridViewLoginTakeId.Rows[0].Cells[3].Value.ToString();
                    _UserGroup = Convert.ToInt32(dataGridViewLoginTakeId.Rows[0].Cells[10].Value);
                    MessageBox.Show(_UserName);
                    MessageBox.Show(_UserId.ToString());
                    MessageBox.Show("Your information is correct. You are being redirected to your panel. Please wait!",
                        "LOGGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtUsername.Text.Contains("admin"))
                    {
                        AccounterPanel acconterPanel = new AccounterPanel();
                        acconterPanel.UserId = _UserId;
                        acconterPanel.UserName = _UserName;
                        acconterPanel.UserGroup = _UserGroup;
                        acconterPanel.Show();
                    }
        
                    else if (txtUsername.Text.Contains("accounter"))
                    {
                        AccounterPanel acconterPanel = new AccounterPanel();
                        acconterPanel.UserId = _UserId;
                        acconterPanel.UserName = _UserName;
                        acconterPanel.UserGroup = _UserGroup;
                        acconterPanel.Show();
                    }

                    else
                    {
                        UserPanel userPanel = new UserPanel();
                        userPanel.UserId = _UserId;
                        userPanel.UserName = _UserName;
                        userPanel.UserGroup = _UserGroup;
                        userPanel.Show();
                    }

                    _UserId = Convert.ToInt32(dataGridViewLoginTakeId.Rows[0].Cells[0].Value);
                    _UserName = dataGridViewLoginTakeId.Rows[0].Cells[3].Value.ToString();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have made an incorrect login attempt.Please check your information!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("You have made an incorrect login attempt.Please check your information!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}