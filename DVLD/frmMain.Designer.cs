namespace DVLD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainFormMenuStrip = new MenuStrip();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            drivingLicenseServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            replacementForDamagedOrLostLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            releaseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            localDrivingLicenseApplicationToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            detainLisencesToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            trebuchetMS12ptToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            showAccountInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            MainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.Dock = DockStyle.Left;
            MainFormMenuStrip.ImageScalingSize = new Size(20, 20);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, trebuchetMS12ptToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem, logoutToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 35);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(289, 634);
            MainFormMenuStrip.TabIndex = 0;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicenseServicesToolStripMenuItem, manageApplicationsToolStripMenuItem, toolStripMenuItem1, detainLisencesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            peopleToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Image = Properties.Resources.Applications_64;
            peopleToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Margin = new Padding(10);
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(256, 68);
            peopleToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, toolStripMenuItem2, replacementForDamagedOrLostLicenseToolStripMenuItem, toolStripMenuItem3, releaseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicenseServicesToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            drivingLicenseServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            drivingLicenseServicesToolStripMenuItem.Size = new Size(405, 70);
            drivingLicenseServicesToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newDrivingLicenseToolStripMenuItem.Image = Properties.Resources.New_Driving_License_32;
            newDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(496, 38);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Image = Properties.Resources.Local_32;
            localLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(302, 38);
            localLicenseToolStripMenuItem.Text = "Local License";
            localLicenseToolStripMenuItem.Click += localLicenseToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Image = Properties.Resources.International_32;
            internationalLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(302, 38);
            internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            renewDrivingLicenseToolStripMenuItem.Image = Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(496, 38);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(493, 6);
            // 
            // replacementForDamagedOrLostLicenseToolStripMenuItem
            // 
            replacementForDamagedOrLostLicenseToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            replacementForDamagedOrLostLicenseToolStripMenuItem.Image = Properties.Resources.Damaged_Driving_License_32;
            replacementForDamagedOrLostLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replacementForDamagedOrLostLicenseToolStripMenuItem.Name = "replacementForDamagedOrLostLicenseToolStripMenuItem";
            replacementForDamagedOrLostLicenseToolStripMenuItem.Size = new Size(496, 38);
            replacementForDamagedOrLostLicenseToolStripMenuItem.Text = "Replacement For Lost Or Damaged License";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(493, 6);
            // 
            // releaseToolStripMenuItem
            // 
            releaseToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            releaseToolStripMenuItem.Image = Properties.Resources.Detained_Driving_License_32;
            releaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            releaseToolStripMenuItem.Size = new Size(496, 38);
            releaseToolStripMenuItem.Text = "Release Detained Driving Lisence";
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            retakeTestToolStripMenuItem.Image = Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(496, 38);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationToolStripMenuItem, internationalLicenseApplicationsToolStripMenuItem });
            manageApplicationsToolStripMenuItem.Image = Properties.Resources.Manage_Applications_64;
            manageApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(405, 70);
            manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            localDrivingLicenseApplicationToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localDrivingLicenseApplicationToolStripMenuItem.Image = Properties.Resources.LocalDriving_License1;
            localDrivingLicenseApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            localDrivingLicenseApplicationToolStripMenuItem.Size = new Size(418, 38);
            localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Applications";
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            internationalLicenseApplicationsToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            internationalLicenseApplicationsToolStripMenuItem.Image = Properties.Resources.International_321;
            internationalLicenseApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            internationalLicenseApplicationsToolStripMenuItem.Size = new Size(418, 38);
            internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(402, 6);
            // 
            // detainLisencesToolStripMenuItem
            // 
            detainLisencesToolStripMenuItem.Image = Properties.Resources.Detain_64;
            detainLisencesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLisencesToolStripMenuItem.Name = "detainLisencesToolStripMenuItem";
            detainLisencesToolStripMenuItem.Size = new Size(405, 70);
            detainLisencesToolStripMenuItem.Text = "Detain Lisences";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageApplicationTypesToolStripMenuItem.Image = Properties.Resources.Application_Types_641;
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(405, 70);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Image = Properties.Resources.Test_Type_64;
            manageTestTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(405, 70);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // trebuchetMS12ptToolStripMenuItem
            // 
            trebuchetMS12ptToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trebuchetMS12ptToolStripMenuItem.Image = Properties.Resources.People_64;
            trebuchetMS12ptToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            trebuchetMS12ptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            trebuchetMS12ptToolStripMenuItem.Margin = new Padding(10);
            trebuchetMS12ptToolStripMenuItem.Name = "trebuchetMS12ptToolStripMenuItem";
            trebuchetMS12ptToolStripMenuItem.Size = new Size(256, 68);
            trebuchetMS12ptToolStripMenuItem.Text = "People";
            trebuchetMS12ptToolStripMenuItem.Click += trebuchetMS12ptToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            driversToolStripMenuItem.Image = Properties.Resources.Drivers_64;
            driversToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Margin = new Padding(10);
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(256, 68);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.Image = Properties.Resources.Users_2_64;
            usersToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Margin = new Padding(10);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(256, 68);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAccountInfoToolStripMenuItem, changePasswordToolStripMenuItem });
            accountSettingsToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountSettingsToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettingsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            accountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountSettingsToolStripMenuItem.Margin = new Padding(10);
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(256, 68);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // showAccountInfoToolStripMenuItem
            // 
            showAccountInfoToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAccountInfoToolStripMenuItem.Image = Properties.Resources.PersonDetails_321;
            showAccountInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showAccountInfoToolStripMenuItem.Name = "showAccountInfoToolStripMenuItem";
            showAccountInfoToolStripMenuItem.Size = new Size(276, 38);
            showAccountInfoToolStripMenuItem.Text = "Show Account Info";
            showAccountInfoToolStripMenuItem.Click += showAccountInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changePasswordToolStripMenuItem.Image = Properties.Resources.Password_321;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(276, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutToolStripMenuItem.Image = Properties.Resources.SignOut_64;
            logoutToolStripMenuItem.ImageAlign = ContentAlignment.BottomLeft;
            logoutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logoutToolStripMenuItem.Margin = new Padding(10);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(256, 68);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Car3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 669);
            ControlBox = false;
            ControlBoxFillHoverColor = Color.FromArgb(80, 160, 255);
            Controls.Add(MainFormMenuStrip);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MainFormMenuStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            ShowIcon = false;
            Text = "DVLD";
            WindowState = FormWindowState.Maximized;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmMain_Load;
            MainFormMenuStrip.ResumeLayout(false);
            MainFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainFormMenuStrip;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem trebuchetMS12ptToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem showAccountInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem detainLisencesToolStripMenuItem;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem replacementForDamagedOrLostLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem releaseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
    }
}
