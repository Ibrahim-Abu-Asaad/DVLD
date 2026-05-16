namespace DVLD.Applications
{
    partial class frmAddEditLocalDrivingLicenseApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tbPersonalInfo = new TabPage();
            btnNext = new Sunny.UI.UIButton();
            ctrlShowPersonDetailsWithFilter1 = new People.Controls.ctrlShowPersonDetailsWithFilter();
            tbApplicationInfo = new TabPage();
            lblFullName = new Label();
            cbLisenceClass = new Sunny.UI.UIComboBox();
            lblCreatedBy = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            lblAppFees = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblAppDate = new Label();
            pictureBox7 = new PictureBox();
            btnBack = new Sunny.UI.UIButton();
            label2 = new Label();
            btnClose = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            tabControl1.SuspendLayout();
            tbPersonalInfo.SuspendLayout();
            tbApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(182, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(732, 49);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbPersonalInfo);
            tabControl1.Controls.Add(tbApplicationInfo);
            tabControl1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(30, 138);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1015, 620);
            tabControl1.TabIndex = 25;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tbPersonalInfo
            // 
            tbPersonalInfo.BackColor = Color.FromArgb(243, 249, 255);
            tbPersonalInfo.Controls.Add(btnNext);
            tbPersonalInfo.Controls.Add(ctrlShowPersonDetailsWithFilter1);
            tbPersonalInfo.Location = new Point(4, 35);
            tbPersonalInfo.Name = "tbPersonalInfo";
            tbPersonalInfo.Padding = new Padding(3);
            tbPersonalInfo.Size = new Size(1007, 581);
            tbPersonalInfo.TabIndex = 0;
            tbPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Font = new Font("Microsoft Sans Serif", 12F);
            btnNext.Location = new Point(856, 481);
            btnNext.MinimumSize = new Size(1, 1);
            btnNext.Name = "btnNext";
            btnNext.Radius = 10;
            btnNext.Size = new Size(125, 44);
            btnNext.TabIndex = 21;
            btnNext.Text = "Next";
            btnNext.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnNext.Click += btnNext_Click;
            // 
            // ctrlShowPersonDetailsWithFilter1
            // 
            ctrlShowPersonDetailsWithFilter1.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.FilterEnabled = true;
            ctrlShowPersonDetailsWithFilter1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetailsWithFilter1.Location = new Point(16, 18);
            ctrlShowPersonDetailsWithFilter1.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetailsWithFilter1.Name = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetailsWithFilter1.ShowAddPersonIcon = true;
            ctrlShowPersonDetailsWithFilter1.Size = new Size(974, 454);
            ctrlShowPersonDetailsWithFilter1.TabIndex = 0;
            ctrlShowPersonDetailsWithFilter1.Text = "ctrlShowPersonDetailsWithFilter1";
            ctrlShowPersonDetailsWithFilter1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tbApplicationInfo
            // 
            tbApplicationInfo.BackColor = Color.FromArgb(243, 249, 255);
            tbApplicationInfo.Controls.Add(lblFullName);
            tbApplicationInfo.Controls.Add(cbLisenceClass);
            tbApplicationInfo.Controls.Add(lblCreatedBy);
            tbApplicationInfo.Controls.Add(pictureBox3);
            tbApplicationInfo.Controls.Add(label8);
            tbApplicationInfo.Controls.Add(lblAppFees);
            tbApplicationInfo.Controls.Add(pictureBox2);
            tbApplicationInfo.Controls.Add(label6);
            tbApplicationInfo.Controls.Add(pictureBox1);
            tbApplicationInfo.Controls.Add(label4);
            tbApplicationInfo.Controls.Add(lblAppDate);
            tbApplicationInfo.Controls.Add(pictureBox7);
            tbApplicationInfo.Controls.Add(btnBack);
            tbApplicationInfo.Controls.Add(label2);
            tbApplicationInfo.Location = new Point(4, 35);
            tbApplicationInfo.Name = "tbApplicationInfo";
            tbApplicationInfo.Padding = new Padding(3);
            tbApplicationInfo.Size = new Size(1007, 581);
            tbApplicationInfo.TabIndex = 1;
            tbApplicationInfo.Text = "Application Info";
            tbApplicationInfo.Click += tbApplicationInfo_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Red;
            lblFullName.Location = new Point(419, 388);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(84, 23);
            lblFullName.TabIndex = 30;
            lblFullName.Text = "username";
            // 
            // cbLisenceClass
            // 
            cbLisenceClass.Cursor = Cursors.Hand;
            cbLisenceClass.DataSource = null;
            cbLisenceClass.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbLisenceClass.FillColor = Color.White;
            cbLisenceClass.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLisenceClass.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbLisenceClass.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbLisenceClass.Location = new Point(418, 179);
            cbLisenceClass.Margin = new Padding(4, 5, 4, 5);
            cbLisenceClass.MinimumSize = new Size(63, 0);
            cbLisenceClass.Name = "cbLisenceClass";
            cbLisenceClass.Padding = new Padding(0, 0, 30, 2);
            cbLisenceClass.Size = new Size(341, 40);
            cbLisenceClass.SymbolSize = 24;
            cbLisenceClass.TabIndex = 29;
            cbLisenceClass.TextAlignment = ContentAlignment.MiddleLeft;
            cbLisenceClass.Watermark = "";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedBy.Location = new Point(417, 359);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(100, 26);
            lblCreatedBy.TabIndex = 28;
            lblCreatedBy.Text = "username";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.User_32__2;
            pictureBox3.Location = new Point(380, 354);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(204, 359);
            label8.Name = "label8";
            label8.Size = new Size(118, 26);
            label8.TabIndex = 26;
            label8.Text = "Created By:";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppFees.Location = new Point(417, 276);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(42, 26);
            lblAppFees.TabIndex = 25;
            lblAppFees.Text = "300";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.money_321;
            pictureBox2.Location = new Point(380, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(204, 276);
            label6.Name = "label6";
            label6.Size = new Size(169, 26);
            label6.TabIndex = 23;
            label6.Text = "Application Fees:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Renew_Driving_License_321;
            pictureBox1.Location = new Point(380, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 193);
            label4.Name = "label4";
            label4.Size = new Size(137, 26);
            label4.TabIndex = 20;
            label4.Text = "Lisence Class:";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppDate.Location = new Point(417, 110);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(102, 26);
            lblAppDate.TabIndex = 19;
            lblAppDate.Text = "22/2/2022";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Calendar_32;
            pictureBox7.Location = new Point(380, 105);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F);
            btnBack.Location = new Point(6, 481);
            btnBack.MinimumSize = new Size(1, 1);
            btnBack.Name = "btnBack";
            btnBack.Radius = 10;
            btnBack.Size = new Size(125, 44);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 110);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 16;
            label2.Text = "Application Date:";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(789, 764);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(920, 764);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1079, 824);
            Controls.Add(tabControl1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Name = "frmNewLocalDrivingLicenseApplication";
            ShowIcon = false;
            Text = "New Local Driving License Application";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Activated += frmNewLocalDrivingLicenseApplication_Activated;
            Load += frmNewLocalDrivingLicenseApplication_Load;
            tabControl1.ResumeLayout(false);
            tbPersonalInfo.ResumeLayout(false);
            tbApplicationInfo.ResumeLayout(false);
            tbApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tbPersonalInfo;
        private Sunny.UI.UIButton btnNext;
        private People.Controls.ctrlShowPersonDetailsWithFilter ctrlShowPersonDetailsWithFilter1;
        private TabPage tbApplicationInfo;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnSave;
        private Label label2;
        private Label lblCreatedBy;
        private PictureBox pictureBox3;
        private Label label8;
        private Label lblAppFees;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblAppDate;
        private PictureBox pictureBox7;
        private Sunny.UI.UIComboBox cbLisenceClass;
        private Label lblFullName;
    }
}