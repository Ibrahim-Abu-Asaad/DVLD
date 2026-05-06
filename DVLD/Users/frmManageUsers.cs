using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Users
{
    public partial class frmManageUsers : UIForm
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ListUsers()
        {

            DataTable dtUsers = clsUser.GetAllUsers();

            dgvManageUsers.DataSource = dtUsers;

            lblTotalUsers.Text = clsUser.NumberOfTotalUsersAndAdmins().ToString();

        }

        private void _FillInfoInsideComboBoxSearchBy()
        {



            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("None");
            cbSearchBy.Items.Add("Username");
            cbSearchBy.Items.Add("IsActive");

            cbSearchBy.SelectedIndex = cbSearchBy.FindString("None");

            txtSearchBy.Visible = false;
            cbIsActive.Visible = false;

        }

        private void _FillInfoInsideComboBoxIsActive()
        {

            cbIsActive.Items.Clear();
            cbIsActive.Items.Add("Yes");
            cbIsActive.Items.Add("No");

            cbIsActive.SelectedIndex = cbIsActive.FindString("Yes");

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _FillInfoInsideComboBoxIsActive();
            _FillInfoInsideComboBoxSearchBy();
            _ListUsers();
        }

        private void _FilterUsers()
        {

            DataTable dtUsers = clsUser.GetAllUsers();

            if (cbSearchBy.Text.Trim().ToLower() == "none")
            {
                dgvManageUsers.DataSource = dtUsers;
                lblTotalUsers.Text = dtUsers.Rows.Count.ToString();
                return;
            }

            DataView dv = dtUsers.DefaultView;

            if (cbSearchBy.Text.Trim().ToLower() == "username")
            {
                string searchValue = txtSearchBy.Text.Trim();
                if (string.IsNullOrEmpty(searchValue))
                {
                    dv.RowFilter = "";
                }
                else
                {
                    dv.RowFilter = $"Username LIKE '%{searchValue}%'";
                }
            }
            else if (cbSearchBy.Text.Trim().ToLower() == "isactive")
            {
                if (cbIsActive.Text.Trim().ToLower() == "yes")
                    dv.RowFilter = "IsActive = True";
                else
                    dv.RowFilter = "IsActive = False";
            }

            dgvManageUsers.DataSource = dv;
            lblTotalUsers.Text = dv.Count.ToString();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSearchBy.Text.Trim().ToLower() == "none")
            {
                txtSearchBy.Visible = false;
                cbIsActive.Visible = false;
                _FilterUsers();
            }
            else if (cbSearchBy.Text.Trim().ToLower() == "username")
            {
                cbIsActive.Visible = false;
                txtSearchBy.Visible = true;
                txtSearchBy.Clear();
                txtSearchBy.Focus();
                _FilterUsers();
            }
            else if (cbSearchBy.Text.Trim().ToLower() == "isactive")
            {

                txtSearchBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Location = txtSearchBy.Location;
                _FilterUsers();

            }


        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            _FilterUsers();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterUsers();
        }

        private void pbAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
        }
    }


}
