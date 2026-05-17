namespace DVLD.Applications.LocalDrivingLicenseApplications
{
    partial class frmManageLocalDrivingLicenseApplications
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label2 = new Label();
            imgbtnAddNewApp = new Sunny.UI.UIImageButton();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            dgvManageLocalDrivingLicenseApps = new Sunny.UI.UIDataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cmsPersonRecord = new Sunny.UI.UIContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            scheduleTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripSeparator();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            lblTotalApps = new Label();
            label3 = new Label();
            cbStatus = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)imgbtnAddNewApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageLocalDrivingLicenseApps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsPersonRecord.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 385);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 17;
            label2.Text = "Filter By:";
            // 
            // imgbtnAddNewApp
            // 
            imgbtnAddNewApp.Cursor = Cursors.Hand;
            imgbtnAddNewApp.Font = new Font("Microsoft Sans Serif", 12F);
            imgbtnAddNewApp.Image = Properties.Resources.New_Application_64;
            imgbtnAddNewApp.Location = new Point(1204, 350);
            imgbtnAddNewApp.Name = "imgbtnAddNewApp";
            imgbtnAddNewApp.Size = new Size(67, 70);
            imgbtnAddNewApp.SizeMode = PictureBoxSizeMode.CenterImage;
            imgbtnAddNewApp.TabIndex = 16;
            imgbtnAddNewApp.TabStop = false;
            imgbtnAddNewApp.Text = null;
            imgbtnAddNewApp.Click += imgbtnAddNewApp_Click;
            // 
            // cbSearchBy
            // 
            cbSearchBy.Cursor = Cursors.Hand;
            cbSearchBy.DataSource = null;
            cbSearchBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbSearchBy.FillColor = Color.White;
            cbSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearchBy.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbSearchBy.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbSearchBy.Location = new Point(135, 377);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(218, 43);
            cbSearchBy.SymbolSize = 24;
            cbSearchBy.TabIndex = 15;
            cbSearchBy.Text = "None";
            cbSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbSearchBy.Watermark = "";
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(359, 377);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 14;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.TextChanged += txtSearchBy_TextChanged;
            // 
            // dgvManageLocalDrivingLicenseApps
            // 
            dgvManageLocalDrivingLicenseApps.AllowUserToAddRows = false;
            dgvManageLocalDrivingLicenseApps.AllowUserToDeleteRows = false;
            dgvManageLocalDrivingLicenseApps.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageLocalDrivingLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageLocalDrivingLicenseApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageLocalDrivingLicenseApps.BackgroundColor = Color.White;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageLocalDrivingLicenseApps.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageLocalDrivingLicenseApps.EnableHeadersVisualStyles = false;
            dgvManageLocalDrivingLicenseApps.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageLocalDrivingLicenseApps.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageLocalDrivingLicenseApps.Location = new Point(29, 428);
            dgvManageLocalDrivingLicenseApps.Name = "dgvManageLocalDrivingLicenseApps";
            dgvManageLocalDrivingLicenseApps.ReadOnly = true;
            dgvManageLocalDrivingLicenseApps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageLocalDrivingLicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageLocalDrivingLicenseApps.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageLocalDrivingLicenseApps.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageLocalDrivingLicenseApps.SelectedIndex = -1;
            dgvManageLocalDrivingLicenseApps.Size = new Size(1242, 318);
            dgvManageLocalDrivingLicenseApps.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageLocalDrivingLicenseApps.TabIndex = 13;
            dgvManageLocalDrivingLicenseApps.CellMouseClick += dgvManageLocalDrivingLicenseApps_CellMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(584, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(272, 244);
            label1.Name = "label1";
            label1.Size = new Size(807, 49);
            label1.TabIndex = 11;
            label1.Text = "Manage Local Driving License Applications";
            // 
            // cmsPersonRecord
            // 
            cmsPersonRecord.BackColor = Color.FromArgb(243, 249, 255);
            cmsPersonRecord.Font = new Font("Microsoft Sans Serif", 12F);
            cmsPersonRecord.ImageScalingSize = new Size(20, 20);
            cmsPersonRecord.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem1, deleteApplicationToolStripMenuItem, toolStripMenuItem2, cancelToolStripMenuItem, toolStripMenuItem3, scheduleTestToolStripMenuItem, phoneCallToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, toolStripMenuItem4, showLicenseToolStripMenuItem, toolStripMenuItem5, showPersonLicenseHistoryToolStripMenuItem });
            cmsPersonRecord.Name = "cmsManagePeople";
            cmsPersonRecord.Size = new Size(391, 344);
            cmsPersonRecord.ZoomScaleDisabled = true;
            cmsPersonRecord.Opening += cmsPersonRecord_Opening;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(390, 38);
            showDetailsToolStripMenuItem.Text = "Show Application Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(387, 6);
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Font = new Font("Trebuchet MS", 12F);
            editToolStripMenuItem1.Image = Properties.Resources.edit_32;
            editToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(390, 38);
            editToolStripMenuItem1.Text = "Edit Application";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteApplicationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(390, 38);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(387, 6);
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            cancelToolStripMenuItem.Image = Properties.Resources.Delete_321;
            cancelToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(390, 38);
            cancelToolStripMenuItem.Text = "Cancel Application";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(387, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            scheduleTestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            scheduleTestToolStripMenuItem.Image = Properties.Resources.Schedule_Test_32;
            scheduleTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            scheduleTestToolStripMenuItem.Size = new Size(390, 38);
            scheduleTestToolStripMenuItem.Text = "Schedule Test";
            scheduleTestToolStripMenuItem.Click += scheduleTestToolStripMenuItem_Click;
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.BackColor = Color.FromArgb(243, 249, 255);
            scheduleVisionTestToolStripMenuItem.Image = Properties.Resources.Vision_Test_32;
            scheduleVisionTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(304, 38);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.BackColor = Color.FromArgb(243, 249, 255);
            scheduleWrittenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_32;
            scheduleWrittenTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(304, 38);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.BackColor = Color.FromArgb(243, 249, 255);
            scheduleStreetTestToolStripMenuItem.Image = Properties.Resources.Street_Test_32;
            scheduleStreetTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(304, 38);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(387, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.IssueDrivingLicense_32;
            issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(390, 38);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(387, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(390, 38);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(387, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(390, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // lblTotalApps
            // 
            lblTotalApps.AutoSize = true;
            lblTotalApps.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalApps.ForeColor = SystemColors.HotTrack;
            lblTotalApps.Location = new Point(162, 756);
            lblTotalApps.Name = "lblTotalApps";
            lblTotalApps.Size = new Size(22, 26);
            lblTotalApps.TabIndex = 19;
            lblTotalApps.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 756);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 18;
            label3.Text = "Total People:";
            // 
            // cbStatus
            // 
            cbStatus.Cursor = Cursors.Hand;
            cbStatus.DataSource = null;
            cbStatus.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbStatus.FillColor = Color.White;
            cbStatus.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbStatus.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbStatus.Location = new Point(591, 377);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.MinimumSize = new Size(63, 0);
            cbStatus.Name = "cbStatus";
            cbStatus.Padding = new Padding(0, 0, 30, 2);
            cbStatus.Radius = 10;
            cbStatus.Size = new Size(218, 43);
            cbStatus.SymbolSize = 24;
            cbStatus.TabIndex = 20;
            cbStatus.Text = "None";
            cbStatus.TextAlignment = ContentAlignment.MiddleLeft;
            cbStatus.Watermark = "";
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1300, 815);
            Controls.Add(cbStatus);
            Controls.Add(lblTotalApps);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imgbtnAddNewApp);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(dgvManageLocalDrivingLicenseApps);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmManageLocalDrivingLicenseApplications";
            ShowIcon = false;
            Text = "Manage Local Driving License Applications";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmManageLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)imgbtnAddNewApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageLocalDrivingLicenseApps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsPersonRecord.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Sunny.UI.UIImageButton imgbtnAddNewApp;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIDataGridView dgvManageLocalDrivingLicenseApps;
        private PictureBox pictureBox1;
        private Label label1;
        private Sunny.UI.UIContextMenuStrip cmsPersonRecord;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private ToolStripSeparator phoneCallToolStripMenuItem;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private Label lblTotalApps;
        private Label label3;
        private Sunny.UI.UIComboBox cbStatus;
    }
}