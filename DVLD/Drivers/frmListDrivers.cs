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

namespace DVLD.Drivers
{
    public partial class frmListDrivers : UIForm
    {
        public frmListDrivers()
        {
            InitializeComponent();
        }

        DataTable _dtDrivers = clsDriver.GetAllDrivers();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {

            cbSearchBy.SelectedIndex = 0;
            dgvManageDrivers.DataSource = _dtDrivers;
            lblTotalDrivers.Text = dgvManageDrivers.RowCount.ToString();
            if (dgvManageDrivers.Rows.Count > 0)
            {
                dgvManageDrivers.Columns[0].HeaderText = "Driver ID";
                dgvManageDrivers.Columns[0].Width = 90;

                dgvManageDrivers.Columns[1].HeaderText = "Person ID";
                dgvManageDrivers.Columns[1].Width = 90;

                dgvManageDrivers.Columns[2].HeaderText = "Full Name";
                dgvManageDrivers.Columns[2].Width = 330;

                dgvManageDrivers.Columns[3].HeaderText = "National No";
                dgvManageDrivers.Columns[3].Width = 100;

                dgvManageDrivers.Columns[4].HeaderText = "Date";
                dgvManageDrivers.Columns[4].Width = 170;

                dgvManageDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvManageDrivers.Columns[5].Width = 220;
            }

            _LoadComboBoxInfo();

        }

        private void _LoadComboBoxInfo()
        {

            cbSearchBy.Items.Clear();

            cbSearchBy.Items.Add("None");
            cbSearchBy.Items.Add("Driver ID");
            cbSearchBy.Items.Add("Person ID");
            cbSearchBy.Items.Add("National No");
            cbSearchBy.Items.Add("Full Name");


            if (cbSearchBy.Items.Count > 0)
                cbSearchBy.SelectedIndex = 0;


        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtSearchBy.Visible = (cbSearchBy.Text != "None");

            if (txtSearchBy.Visible)
            {
                txtSearchBy.Text = "";
                txtSearchBy.Focus();
            }

            _dtDrivers.DefaultView.RowFilter = "";
            lblTotalDrivers.Text = dgvManageDrivers.Rows.Count.ToString();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {

            _Filtering();

        }

        private void _Filtering()
        {

            string filterColumn = cbSearchBy.Text;

            switch (filterColumn)
            {
                case "Driver ID":
                    filterColumn = "ID";
                    break;
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "National No":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (string.IsNullOrWhiteSpace(txtSearchBy.Text.Trim()) || filterColumn == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lblTotalDrivers.Text = dgvManageDrivers.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "ID" || filterColumn == "PersonID")
            {

                if (int.TryParse(txtSearchBy.Text.Trim(), out int value))
                    //_dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, value);
                    _dtDrivers.DefaultView.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '{1}%'", filterColumn, txtSearchBy.Text.Trim());
                else
                    _dtDrivers.DefaultView.RowFilter = "1 = 0";
            }
            else
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtSearchBy.Text.Trim());


            lblTotalDrivers.Text = dgvManageDrivers.Rows.Count.ToString();

        }
    }
}
