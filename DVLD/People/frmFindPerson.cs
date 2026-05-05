using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace DVLD.People
{
    public partial class frmFindPerson : UIForm
    {

        public delegate void DataBackEventHandler(object sender, string NationalNO);

        public event DataBackEventHandler DataBack;


        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            //DataBack?.Invoke(this, ctrlShowPersonDetailsWithFilter1.SelectedPersonInfo.NationalNO);


            string nationalNo = ctrlShowPersonDetailsWithFilter1.SelectedPersonInfo?.NationalNO;

            if (!string.IsNullOrEmpty(nationalNo))
            {
                DataBack?.Invoke(this, nationalNo);
            }

            this.Close();


        }

        private void frmFindPerson_Load(object sender, EventArgs e)
        {
            //ctrlShowPersonDetailsWithFilter1
        }

        private void ctrlShowPersonDetailsWithFilter1_Click(object sender, EventArgs e)
        {
            //
        }

        private void frmFindPerson_FormClosing(object sender, FormClosingEventArgs e)
        {

            //

        }
    }
}
