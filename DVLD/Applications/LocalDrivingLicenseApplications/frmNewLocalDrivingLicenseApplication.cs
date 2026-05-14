using DVLD.Global_Classes;
using DVLD_BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class frmNewLocalDrivingLicenseApplication : UIForm
    {

        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void tbApplicationInfo_Click(object sender, EventArgs e)
        {
            //if (!_IsPersonExist())
            //{
            //    tabControl1.SelectedTab = tbPersonalInfo;
            //    MessageBox.Show("Choose Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //tabControl1.SelectedTab = tbApplicationInfo;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _ValidateNavigation();

        }

        private bool _IsPersonExist()
            => ctrlShowPersonDetailsWithFilter1.PersonID != -1;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tbApplicationInfo)
                _ValidateNavigation();


        }

        private void _ValidateNavigation()
        {

            if (!_IsPersonExist())
            {
                tabControl1.SelectedTab = tbPersonalInfo;
                MessageBox.Show("Choose Person First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedTab = tbApplicationInfo;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPersonalInfo;
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

            _FillComboBoxWithData();
            _FillDataInForm();



        }

        private void _FillDataInForm()
        {

            clsApplicationType NewLocalApplicationType = new clsApplicationType();
            NewLocalApplicationType = clsApplicationType.Find(1);

            lblAppFees.Text = NewLocalApplicationType.Fees.ToString();

            lblAppDate.Text = DateTime.Now.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.Username;

            string Name = clsGlobal.CurrentUser.PersonInfo.FirstName + " " + clsGlobal.CurrentUser.PersonInfo.LastName;
            lblFullName.Text = Name;


        }

        private void _FillComboBoxWithData()
        {

            cbLisenceClass.DataSource = clsLicenseClass.GetAllClassLisences();

            cbLisenceClass.DisplayMember = "ClassName";

            cbLisenceClass.ValueMember = "ID";

            cbLisenceClass.SelectedValue = 3;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
