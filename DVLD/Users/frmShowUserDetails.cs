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

namespace DVLD.Users
{
    public partial class frmShowUserDetails : UIForm
    {

        int _UserID = -1;
        clsUser _User = new clsUser();

        public frmShowUserDetails(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _User = clsUser.GetUserByID(UserID);
        }

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            ctrlShowUserDetails2.FillInfoInUserCard(_User.ID);
        }
    }
}
