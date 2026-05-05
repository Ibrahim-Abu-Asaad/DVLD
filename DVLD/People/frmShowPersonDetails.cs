using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_BLL;
using Sunny.UI;

namespace DVLD
{
    public partial class frmShowPersonDetails : UIForm
    {

        int PersonID = -1;
        clsPerson Person;

        public frmShowPersonDetails(int ID)
        {
            InitializeComponent();
            PersonID = ID;
            Person = clsPerson.Find(ID);
        }

        private void ctrlShowPersonDetails1_Click(object sender, EventArgs e)
        {
            //
        }

        private void frmShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrlShowPersonDetails2.LoadPersonDataAndFillPersonCard(PersonID);
            this.Text = "Show Person Details";
        }

        private void ctrlShowPersonDetails1_Load(object sender, EventArgs e)
        {
            //FillPersonInfo();

        }
    }
}
