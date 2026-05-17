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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications
{
    public partial class ctrlApplicationBasicInfo : UIUserControl
    {

        int _ApplicationID = -1;

        public int ApplicationId
        {
            get { return _ApplicationID; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationBasicInfoByApplicationID(int ApplicationID)
        {

            clsApplication App = clsApplication.FindBaseApplication(ApplicationID);
            if (App == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _LoadApplicationData(ApplicationID);


            


        }

        private void _LoadApplicationData(int ApplicationID)
        {

            clsApplication App = clsApplication.FindBaseApplication(ApplicationID);


            lblStatus.Text = App.AppStatusText.ToString();
            lblFees.Text = App.PaidFees.ToString();
            lblType.Text = App.ApplicationTypeInfo.Title;

            string FullName = App.PersonInfo.FirstName + " " + App.PersonInfo.SecondName + " " + App.PersonInfo.LastName;
            lblApplicant.Text = FullName;

            lblCreatedBy.Text = App.CreatedByUserInfo.Username + $" ({App.CreatedByUserInfo.PersonInfo.FirstName + " " + App.CreatedByUserInfo.PersonInfo.LastName})";

            lblDate.Text = App.Date.ToShortDateString();
            lblStatusDate.Text = App.LastStatusDate.ToShortDateString();

        }

        public void ResetApplicationInfo()
        {

            lblStatus.Text = "[??????]";
            lblFees.Text = "[$$$$$$]";
            lblType.Text = "[??????]";

            lblApplicant.Text = "[??????]";

            lblCreatedBy.Text = "[??????]";
            lblDate.Text = "[??????]";
            lblStatusDate.Text = "[??????]";

        }
    }
}
