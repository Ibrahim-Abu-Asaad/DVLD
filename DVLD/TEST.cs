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

namespace DVLD
{
    public partial class TEST : UIForm
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {

            ctrlDriverLicenses1.LoadDataByDriverID(9);

        }

    }
}
