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
using DVLD_DAL;
using Sunny.UI;

namespace DVLD
{
    public partial class frmManageApplicationTypes : UIForm
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _ListApplicationTypes()
        {

            dgvManageApplicationTypes.DataSource = clsApplicationTypes.GetApplicationTypes();

            dgvManageApplicationTypes.Columns["ID"].Visible = false;

            if (dgvManageApplicationTypes.Columns.Count > 0)
            {

                dgvManageApplicationTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
                dgvManageApplicationTypes.Columns["ApplicationTypeTitle"].Width = 350;

                dgvManageApplicationTypes.Columns["ApplicationFees"].HeaderText = "Fees";
                dgvManageApplicationTypes.Columns["ApplicationFees"].Width = 150;
            }

            if (dgvManageApplicationTypes.Columns.Contains("colEdit"))
            {
                DataGridViewImageColumn editCol = (DataGridViewImageColumn)dgvManageApplicationTypes.Columns["colEdit"];

                editCol.Image = Properties.Resources.Edit1;
                editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editCol.HeaderText = "Action";
                editCol.Width = 80;

                editCol.DisplayIndex = dgvManageApplicationTypes.Columns.Count - 1;
            }

        }

        private void _RefreshPage()
        {
            _ListApplicationTypes();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {

            _ListApplicationTypes();

        }

        private void dgvManageApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int ApplicationTypeID = (int)dgvManageApplicationTypes.Rows[e.RowIndex].Cells["ID"].Value;

            if (e.RowIndex >= 0 && dgvManageApplicationTypes.Columns[e.ColumnIndex].Name == "colEdit")
            {
                frmEditApplicationTypes frm = new frmEditApplicationTypes(ApplicationTypeID);
                frm.ShowDialog();
                _RefreshPage();
            }

        }

        private void dgvManageApplicationTypes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && dgvManageApplicationTypes.Columns[e.ColumnIndex].Name == "colEdit")
            //    dgvManageApplicationTypes.Cursor = Cursors.Hand;
        }

        private void dgvManageApplicationTypes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dgvManageApplicationTypes.Cursor = Cursors.Default;
        }

        private void dgvManageApplicationTypes_MouseMove(object sender, MouseEventArgs e)
        {

            var hit = dgvManageApplicationTypes.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 &&
                dgvManageApplicationTypes.Columns[hit.ColumnIndex].Name == "colEdit")
            {
                Rectangle cellBounds = dgvManageApplicationTypes.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);

                Image img = Properties.Resources.Edit1;

                float ratio = Math.Min((float)cellBounds.Width / img.Width, (float)cellBounds.Height / img.Height);
                int imgWidth = (int)(img.Width * ratio);
                int imgHeight = (int)(img.Height * ratio);

                int imgX = cellBounds.X + (cellBounds.Width - imgWidth) / 2;
                int imgY = cellBounds.Y + (cellBounds.Height - imgHeight) / 2;

                Rectangle iconRect = new Rectangle(imgX, imgY, imgWidth, imgHeight);

                if (iconRect.Contains(e.Location))
                {
                    dgvManageApplicationTypes.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvManageApplicationTypes.Cursor = Cursors.Default;
                }
            }
            else
            {
                dgvManageApplicationTypes.Cursor = Cursors.Default;
            }

        }
    }
}
