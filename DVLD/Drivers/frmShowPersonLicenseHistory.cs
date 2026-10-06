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
    public partial class frmShowPersonLicenseHistory : UIForm
    {

        private int _PersonID = -1;
        private clsPerson _Person;

        public frmShowPersonLicenseHistory()
        {
            InitializeComponent();
            ctrlShowPersonDetailsWithFilter1.OnPersonSelected += CtrlShowPersonDetailsWithFilter1_OnPersonSelected;
        }

        public frmShowPersonLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            //_Person = clsPerson.Find(personID);
        }

        private void CtrlShowPersonDetailsWithFilter1_OnPersonSelected(string nationalNo)
        {

            clsPerson person = clsPerson.Find(nationalNo);
            _PersonID = person.ID;
            if (person == null)
                ctrlDriverLicenses1.Clear();
            else
                ctrlDriverLicenses1.LoadDataByPersonID(person.ID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            
            if(_PersonID != -1)
            {
                ctrlShowPersonDetailsWithFilter1.LoadPersonInfo(_PersonID);
                ctrlDriverLicenses1.LoadDataByPersonID(_PersonID);
                ctrlShowPersonDetailsWithFilter1.FilterEnabled = false;
            }
            else
            {
                ctrlShowPersonDetailsWithFilter1.FilterEnabled = true;
            }

        }


    }
}
