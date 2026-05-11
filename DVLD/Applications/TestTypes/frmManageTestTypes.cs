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

namespace DVLD.Applications.TestTypes
{
    public partial class frmManageTestTypes : UIForm
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void dgvManageTestTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {

            _ListTestTypes();

        }

        private void dgvManageTestTypes_MouseMove(object sender, MouseEventArgs e)
        {

            var hit = dgvManageTestTypes.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0 &&
                dgvManageTestTypes.Columns[hit.ColumnIndex].Name == "colEdit")
            {
                Rectangle cellBounds = dgvManageTestTypes.GetCellDisplayRectangle(hit.ColumnIndex, hit.RowIndex, false);

                Image img = Properties.Resources.Edit1;

                float ratio = Math.Min((float)cellBounds.Width / img.Width, (float)cellBounds.Height / img.Height);
                int imgWidth = (int)(img.Width * ratio);
                int imgHeight = (int)(img.Height * ratio);

                int imgX = cellBounds.X + (cellBounds.Width - imgWidth) / 2;
                int imgY = cellBounds.Y + (cellBounds.Height - imgHeight) / 2;

                Rectangle iconRect = new Rectangle(imgX, imgY, imgWidth, imgHeight);

                if (iconRect.Contains(e.Location))
                {
                    dgvManageTestTypes.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvManageTestTypes.Cursor = Cursors.Default;
                }
            }
            else
            {
                dgvManageTestTypes.Cursor = Cursors.Default;
            }

        }

        private void dgvManageTestTypes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int TestTypeID = (int)dgvManageTestTypes.Rows[e.RowIndex].Cells["ID"].Value;

            if (e.RowIndex >= 0 && dgvManageTestTypes.Columns[e.ColumnIndex].Name == "colEdit")
            {
                frmEditTestTypes frm = new frmEditTestTypes(TestTypeID);
                frm.ShowDialog();
                _RefreshPage();
            }

        }

        private void _RefreshPage()
        {
            _ListTestTypes();
        }

        private void _ListTestTypes()
        {

            dgvManageTestTypes.DataSource = clsTestTypes.GetAllTestTypes();

            dgvManageTestTypes.Columns["ID"].Visible = false;

            if (dgvManageTestTypes.Columns.Count > 0)
            {

                dgvManageTestTypes.Columns["Title"].HeaderText = "Title";
                dgvManageTestTypes.Columns["Title"].Width = 300;

                dgvManageTestTypes.Columns["Description"].HeaderText = "Description";
                dgvManageTestTypes.Columns["Description"].Width = 400;

                dgvManageTestTypes.Columns["Fees"].HeaderText = "Fees";
                dgvManageTestTypes.Columns["Fees"].Width = 300;
            }

            if (dgvManageTestTypes.Columns.Contains("colEdit"))
            {
                DataGridViewImageColumn editCol = (DataGridViewImageColumn)dgvManageTestTypes.Columns["colEdit"];

                editCol.Image = Properties.Resources.Edit1;
                editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                editCol.HeaderText = "Action";
                editCol.Width = 80;

                editCol.DisplayIndex = dgvManageTestTypes.Columns.Count - 1;
            }

        }






    }
}
