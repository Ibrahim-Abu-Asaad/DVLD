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
            _RefreshPage();
        }

        private void dgvManageUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    dgvManageUsers.ClearSelection();

                    dgvManageUsers.Rows[e.RowIndex].Selected = true;

                    dgvManageUsers.CurrentCell = dgvManageUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cmsUserRecord.Show(Cursor.Position);

                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (dgvManageUsers.SelectedRows.Count > 0)
            {

                string username = dgvManageUsers.SelectedRows[0].Cells["Username"].Value.ToString();

                clsUser User = clsUser.GetUserByUsername(username);

                if (User != null)
                {

                    frmAddEditUser frm = new frmAddEditUser(User.ID);
                    frm.ShowDialog();

                    _RefreshPage();
                }
                else
                {
                    MessageBox.Show("User not found!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void _RefreshPage()
        {

            _ListUsers();

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string username = "";

            if (dgvManageUsers.SelectedRows.Count > 0)
                username = dgvManageUsers.CurrentRow.Cells["Username"].Value.ToString();


            int ID = clsUser.GetUserByUsername(username).ID;

            frmChangePassword frm = new frmChangePassword(ID);
            frm.ShowDialog();

            _RefreshPage();

        }
    }


}
