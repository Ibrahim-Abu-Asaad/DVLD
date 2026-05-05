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

namespace DVLD.People.Controls
{
    public partial class ctrlShowPersonDetailsWithFilter : UIUserControl
    {

        public event Action<string> OnPersonSelected;

        protected virtual void PersonSelected(string NationalNO)
        {

            Action<string> handler = OnPersonSelected;

            if (handler != null)
                handler(NationalNO);

        }

        private bool _ShowAddPersonIcon = true;
        public bool ShowAddPersonIcon
        {
            get { return _ShowAddPersonIcon; }
            set
            {
                _ShowAddPersonIcon = value;
                pbAddNewPerson.Visible = _ShowAddPersonIcon;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public ctrlShowPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlShowPersonDetails21.PersonID; }
        }

        private string _NationalNO = "";
        public string NationalNO
        {
            get { return ctrlShowPersonDetails21.NationalNO; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ctrlShowPersonDetails21.SelectedPersonInfo; }
        }

        public void LoadPersonInfo()
        {

            cbFindBy.SelectedIndex = 0;
            txtSearchBy.Text = SelectedPersonInfo.NationalNO;
            FindNow();

        }

        private void FindNow()
        {
            ctrlShowPersonDetails21.LoadPersonDataAndFillPersonCard(txtSearchBy.Text);

            if (ctrlShowPersonDetails21.SelectedPersonInfo != null)
            {
                if (OnPersonSelected != null && FilterEnabled)
                    OnPersonSelected(ctrlShowPersonDetails21.SelectedPersonInfo.NationalNO);
            }
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBy.Text = "";
            txtSearchBy.Focus();
        }

        private void pbSearchPerson_Click(object sender, EventArgs e)
        {

            if (txtSearchBy.Text == string.Empty)
            {
                ctrlShowPersonDetails21.ResetToDefault();
                MessageBox.Show("National NO is required",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!this.ValidateChildren())
            //{
            //    MessageBox.Show("National NO Is Required");
            //    return;
            //}

            FindNow();

        }

        private void txtSearchBy_Validating(object sender, CancelEventArgs e)
        {

            //if (string.IsNullOrWhiteSpace(txtSearchBy.Text))
            //{
            //    e.Cancel = true;
            //    txtSearchBy.Focus();
            //    errorProvider1.SetError(txtSearchBy, "This field is required!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtSearchBy, null);
            //}

        }

        private void DataBackEvent(object sender, string NationalNO)
        {

            cbFindBy.SelectedIndex = 0;
            txtSearchBy.Text = NationalNO;
            ctrlShowPersonDetails21.LoadPersonDataAndFillPersonCard(NationalNO);

        }

        private void pbAddNewPerson_Click(object sender, EventArgs e)
        {

            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

        }

        private void ctrlShowPersonDetailsWithFilter_Click(object sender, EventArgs e)
        {
            _ShowAddPersonIcon = true;
            pbAddNewPerson.Visible = true;
        }

        public void FillComboBoxWithOnlyNationalNO()
        {

            cbFindBy.Items.Clear();
            cbFindBy.Items.Add("National NO");

            if (cbFindBy.Items.Count > 0)
            {
                cbFindBy.SelectedIndex = 0;
            }

            txtSearchBy.Focus();

        }

        private void ctrlShowPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {

            FillComboBoxWithOnlyNationalNO();

        }
    }
}
