using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Applications.TestTypes;
using DVLD.Licenses.Local_Licenses;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD.Drivers
{
    public partial class ctrlDriverLicenses : UIUserControl
    {
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private int _DriverID = -1;
        private clsDriver _Driver;
        private DataTable _dtLocalLicenses = new DataTable();
        private DataTable _dtInternationalLicenses = new DataTable();

        private void _LoadLocalLicensesData()
        {

            _dtLocalLicenses = clsDriver.GetLicenses(_DriverID);
            dgvLocalLicenses.DataSource = _dtLocalLicenses;

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Show";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[1].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[1].Width = 110;

                dgvLocalLicenses.Columns[2].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[2].Width = 110;

                dgvLocalLicenses.Columns[3].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[3].Width = 270;

                dgvLocalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[4].Width = 170;

                dgvLocalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[5].Width = 170;

                dgvLocalLicenses.Columns[6].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[6].Width = 110;

            }

        }

        private void _LoadInternationalLicensesData()
        {

            _dtInternationalLicenses = clsDriver.GetInternationalLicenses(_DriverID);
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Show";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[1].Width = 160;

                dgvInternationalLicenses.Columns[2].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[2].Width = 130;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 130;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 180;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 180;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 120;

            }



        }

        private void _LoadDataByPersonID(int personID)
        {
            _Driver = clsDriver.GetDriverByPersonID(personID);
            _DriverID = _Driver.ID;
            if (_DriverID == -1)
            {
                MessageBox.Show("Person is not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicensesData();
            _LoadInternationalLicensesData();

        }

        private void _LoadDataByDriverID(int driverID)
        {

            _Driver = clsDriver.GetDriverByID(driverID);
            _DriverID = _Driver.ID;
            if (_DriverID == -1)
            {
                MessageBox.Show("Driver is not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLocalLicensesData();
            _LoadInternationalLicensesData();

        }


        public void LoadDataByPersonID(int personID)
            => _LoadDataByPersonID(personID);
        public void LoadDataByDriverID(int driverID)
            => _LoadDataByDriverID(driverID);

        private void dgvLocalLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvLocalLicenses.Columns[e.ColumnIndex].Name == "colShow")
            {

                int LicenseID = (int)dgvLocalLicenses.Rows[e.RowIndex].Cells["ID"].Value;
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID,true);
                frm.ShowDialog();
                //_RefreshPage();

            }

        }

        private void dgvLocalLicenses_MouseMove(object sender, MouseEventArgs e)
        {

            var hit = dgvLocalLicenses.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 &&
                dgvLocalLicenses.Columns[hit.ColumnIndex].Name == "colShow")
            {
                Rectangle cellBounds = dgvLocalLicenses.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);

                Image img = Properties.Resources.id_card_fill__4_;

                float ratio = Math.Min((float)cellBounds.Width / img.Width, (float)cellBounds.Height / img.Height);
                int imgWidth = (int)(img.Width * ratio);
                int imgHeight = (int)(img.Height * ratio);

                int imgX = cellBounds.X + (cellBounds.Width - imgWidth) / 2;
                int imgY = cellBounds.Y + (cellBounds.Height - imgHeight) / 2;

                Rectangle iconRect = new Rectangle(imgX, imgY, imgWidth, imgHeight);

                if (iconRect.Contains(e.Location))
                {
                    dgvLocalLicenses.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvLocalLicenses.Cursor = Cursors.Default;
                }
            }
            else
            {
                dgvLocalLicenses.Cursor = Cursors.Default;
            }

        }

        private void dgvInternationalLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvInternationalLicenses.Columns[e.ColumnIndex].Name == "colShowInt")
            {

                MessageBox.Show("It works");

            }

        }

        private void dgvInternationalLicenses_MouseMove(object sender, MouseEventArgs e)
        {

            var hit = dgvInternationalLicenses.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 &&
                dgvInternationalLicenses.Columns[hit.ColumnIndex].Name == "colShowInt")
            {
                Rectangle cellBounds = dgvInternationalLicenses.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);

                Image img = Properties.Resources.id_card_fill__4_;

                float ratio = Math.Min((float)cellBounds.Width / img.Width, (float)cellBounds.Height / img.Height);
                int imgWidth = (int)(img.Width * ratio);
                int imgHeight = (int)(img.Height * ratio);

                int imgX = cellBounds.X + (cellBounds.Width - imgWidth) / 2;
                int imgY = cellBounds.Y + (cellBounds.Height - imgHeight) / 2;

                Rectangle iconRect = new Rectangle(imgX, imgY, imgWidth, imgHeight);

                if (iconRect.Contains(e.Location))
                {
                    dgvInternationalLicenses.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvInternationalLicenses.Cursor = Cursors.Default;
                }
            }
            else
            {
                dgvInternationalLicenses.Cursor = Cursors.Default;
            }

        }

        public void Clear()
        {

            _dtLocalLicenses.Clear();
            _dtInternationalLicenses.Clear();

        }



    }
}
