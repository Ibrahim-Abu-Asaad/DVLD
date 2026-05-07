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

namespace DVLD.Users.Controls
{
    public partial class ctrlShowUserDetails : UIUserControl
    {

        //int _UserID = -1;
        //clsUser _User = new clsUser();

        //public ctrlShowUserDetails(int UserID)
        //{
        //    InitializeComponent();

        //    _UserID = UserID;
        //    _User = clsUser.GetUserByID(UserID);
        //}

        public ctrlShowUserDetails()
        {
            InitializeComponent();
        }

        private void ctrlShowUserDetails_Click(object sender, EventArgs e)
        {
            //
        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {
            //
        }

        public void FillInfoInUserCard(int UserID)
        {

            clsUser user = clsUser.GetUserByID(UserID);

            ctrlShowPersonDetails21.LoadPersonDataAndFillPersonCard(user.PersonID);
            lblUsername.Text = user.Username;
            lblIsActive.Text = (user.IsActive == true) ? "Yes" : "No";

        }

        private void ctrlShowUserDetails_Load(object sender, EventArgs e)
        {
            //ctrlShowPersonDetails21.LoadPersonDataAndFillPersonCard(_User.PersonID);
            //lblUsername.Text = _User.Username;
            //lblIsActive.Text = (_User.IsActive == true) ? "Yes" : "No";
        }
    }
}
