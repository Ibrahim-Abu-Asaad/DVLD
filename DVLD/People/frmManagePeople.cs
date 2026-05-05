using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.People;
using DVLD_BLL;
using Sunny.UI;
using Sunny.UI.Win32;

namespace DVLD
{
    public partial class frmManagePeople : UIForm
    {
        public frmManagePeople()
        {
            InitializeComponent();

        }

        private DataTable _dtAllPeople = new DataTable();

        private void _RefreshTotalPeopleCount()
        {
            lblTotalPeople.Text = _dtAllPeople.DefaultView.Count.ToString();
        }

        private void _ListPeopleAndHideSomeColumns()
        {

            _dtAllPeople = clsPerson.GetPeopleAndHideSomeColumns();
            dgvManagePeople.DataSource = _dtAllPeople;

            _RefreshTotalPeopleCount();

        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {

            txtSearchBy.Visible = false;

            _ListPeopleAndHideSomeColumns();
            _FillSearchByWithInfo();

        }

        private void _RefreshPage()
        {

            _dtAllPeople.Clear();
            _ListPeopleAndHideSomeColumns();
            _FillSearchByWithInfo();
            _RefreshTotalPeopleCount();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillSearchByWithInfo()
        {

            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("None");

            foreach (DataColumn column in _dtAllPeople.Columns)
                cbSearchBy.Items.Add(column.ColumnName);


            cbSearchBy.SelectedIndex = 0;

        }

        /*
         
        0: None
        1: NationalNO
        2: FirstName
        3: LastName
        4: Gender
        5: Email
        6: CountryName

        */

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtSearchBy.Visible = (cbSearchBy.SelectedIndex != 0);

            if (txtSearchBy.Visible)
            {
                txtSearchBy.Text = "";
                txtSearchBy.Focus();
            }

            if (_dtAllPeople != null)
                _dtAllPeople.DefaultView.RowFilter = "";


            _RefreshTotalPeopleCount();


        }

        private void cbSearchBy_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void _FilterByManyWays()
        {
            string FilterColumn = "";

            switch (cbSearchBy.SelectedIndex)
            {
                case 1: FilterColumn = "National No"; break;
                case 2: FilterColumn = "First Name"; break;
                case 3: FilterColumn = "Last Name"; break;
                case 4: FilterColumn = "Gender"; break;
                case 5: FilterColumn = "Email"; break;
                case 6: FilterColumn = "Nationality"; break;
                default: FilterColumn = "None"; break;
            }

            if (txtSearchBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";

                _RefreshTotalPeopleCount();
                return;
            }

            _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearchBy.Text.Trim());
            _RefreshTotalPeopleCount();

        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {

            _FilterByManyWays();

        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {

            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _RefreshPage();

        }


        private void dgvManagePeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                string NationalNo = dgvManagePeople.Rows[e.RowIndex].Cells["National No"].Value.ToString();

                clsPerson person = clsPerson.Find(NationalNo);

                if (person != null)
                {

                    frmShowPersonDetails frm = new frmShowPersonDetails(person.ID);
                    frm.ShowDialog();

                    _RefreshPage();


                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvManagePeople_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                    dgvManagePeople.ClearSelection();

                    dgvManagePeople.Rows[e.RowIndex].Selected = true;

                    dgvManagePeople.CurrentCell = dgvManagePeople.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    cmsPersonRecord.Show(Cursor.Position);

                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (dgvManagePeople.SelectedRows.Count > 0)
            {

                string nationalNO = dgvManagePeople.SelectedRows[0].Cells["National NO"].Value.ToString();

                clsPerson person = clsPerson.Find(nationalNO);

                if (person != null)
                {

                    frmAddEditPerson frm = new frmAddEditPerson(person.ID);
                    frm.ShowDialog();

                    _RefreshPage();
                }
                else
                {
                    MessageBox.Show("Person not found!", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvManagePeople.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the National NO from the selected row
                    string nationalNO = dgvManagePeople.SelectedRows[0].Cells["National No"].Value.ToString();

                    // Find person by NationalNO
                    clsPerson person = clsPerson.Find(nationalNO);

                    // Check if person exists
                    if (person != null)
                    {
                        // Open the show details form with the person ID
                        frmShowPersonDetails frm = new frmShowPersonDetails(person.ID);
                        frm.ShowDialog();
                        _RefreshPage();
                    }
                    else
                    {
                        MessageBox.Show("Person not found!", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person");
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Person");
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call");
        }

        private void dgvManagePeople_MouseClick(object sender, MouseEventArgs e)
        {

            //if (e.Button == MouseButtons.Right)
            //{
            //    MessageBox.Show("TEST");
            //}

        }

        private void frmManagePeople_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                cmsPeopleDGV.Show(Cursor.Position);

            }

        }

        private void addNewPersonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();
            _RefreshPage();

        }

        private void Test_Click(object sender, EventArgs e)
        {

            frmFindPerson frm = new frmFindPerson();
            frm.ShowDialog();
            _RefreshPage();

        }
    }
}
