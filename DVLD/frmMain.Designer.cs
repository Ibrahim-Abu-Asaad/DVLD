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
            trebuchetMS12ptToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            MainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainFormMenuStrip
            // 
            MainFormMenuStrip.Dock = DockStyle.Left;
            MainFormMenuStrip.ImageScalingSize = new Size(20, 20);
            MainFormMenuStrip.Items.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, trebuchetMS12ptToolStripMenuItem, driversToolStripMenuItem, usersToolStripMenuItem, accountSettingsToolStripMenuItem });
            MainFormMenuStrip.Location = new Point(0, 35);
            MainFormMenuStrip.Name = "MainFormMenuStrip";
            MainFormMenuStrip.Size = new Size(289, 634);
            MainFormMenuStrip.TabIndex = 0;
            MainFormMenuStrip.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Image = Properties.Resources.Applications_64;
            peopleToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Margin = new Padding(10);
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(256, 68);
            peopleToolStripMenuItem.Text = "Applications";
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
            accountSettingsToolStripMenuItem.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountSettingsToolStripMenuItem.Image = Properties.Resources.account_settings_64;
            accountSettingsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            accountSettingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            accountSettingsToolStripMenuItem.Margin = new Padding(10);
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(256, 68);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // frmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Car3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 669);
            ControlBoxFillHoverColor = Color.FromArgb(80, 160, 255);
            Controls.Add(MainFormMenuStrip);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MainFormMenuStrip;
            Name = "frmMain";
            ShowIcon = false;
            Text = "DVLD";
            WindowState = FormWindowState.Maximized;
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
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
    }
}
