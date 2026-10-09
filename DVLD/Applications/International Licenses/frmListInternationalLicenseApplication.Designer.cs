namespace DVLD.Applications.International_Licenses
{
    partial class frmListInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicenseApplication));
            btnClose = new Sunny.UI.UIButton();
            cbIsReleased = new Sunny.UI.UIComboBox();
            lblTotalInternationalApps = new Label();
            label3 = new Label();
            label2 = new Label();
            imgbtnAddNewApp = new Sunny.UI.UIImageButton();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            dgvManageInternationalDrivingLicenseApps = new Sunny.UI.UIDataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            cmsInternational = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            showPersonLicensesHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)imgbtnAddNewApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageInternationalDrivingLicenseApps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cmsInternational.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(1129, 735);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 92;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // cbIsReleased
            // 
            cbIsReleased.Cursor = Cursors.Hand;
            cbIsReleased.DataSource = null;
            cbIsReleased.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbIsReleased.FillColor = Color.White;
            cbIsReleased.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsReleased.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbIsReleased.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbIsReleased.Location = new Point(616, 356);
            cbIsReleased.Margin = new Padding(4, 5, 4, 5);
            cbIsReleased.MinimumSize = new Size(63, 0);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Padding = new Padding(0, 0, 30, 2);
            cbIsReleased.Radius = 10;
            cbIsReleased.Size = new Size(218, 43);
            cbIsReleased.SymbolSize = 24;
            cbIsReleased.TabIndex = 91;
            cbIsReleased.Text = "None";
            cbIsReleased.TextAlignment = ContentAlignment.MiddleLeft;
            cbIsReleased.Watermark = "";
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged;
            // 
            // lblTotalInternationalApps
            // 
            lblTotalInternationalApps.AutoSize = true;
            lblTotalInternationalApps.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalInternationalApps.ForeColor = SystemColors.HotTrack;
            lblTotalInternationalApps.Location = new Point(145, 735);
            lblTotalInternationalApps.Name = "lblTotalInternationalApps";
            lblTotalInternationalApps.Size = new Size(22, 26);
            lblTotalInternationalApps.TabIndex = 90;
            lblTotalInternationalApps.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 735);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 89;
            label3.Text = "Total People:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 364);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 88;
            label2.Text = "Filter By:";
            // 
            // imgbtnAddNewApp
            // 
            imgbtnAddNewApp.Cursor = Cursors.Hand;
            imgbtnAddNewApp.Font = new Font("Microsoft Sans Serif", 12F);
            imgbtnAddNewApp.Image = Properties.Resources.New_Application_64;
            imgbtnAddNewApp.Location = new Point(1187, 329);
            imgbtnAddNewApp.Name = "imgbtnAddNewApp";
            imgbtnAddNewApp.Size = new Size(67, 70);
            imgbtnAddNewApp.SizeMode = PictureBoxSizeMode.CenterImage;
            imgbtnAddNewApp.TabIndex = 87;
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
            cbSearchBy.Location = new Point(118, 356);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(258, 43);
            cbSearchBy.SymbolSize = 24;
            cbSearchBy.TabIndex = 86;
            cbSearchBy.Text = "None";
            cbSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbSearchBy.Watermark = "";
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(384, 356);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 85;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.TextChanged += txtSearchBy_TextChanged;
            txtSearchBy.KeyPress += txtSearchBy_KeyPress;
            // 
            // dgvManageInternationalDrivingLicenseApps
            // 
            dgvManageInternationalDrivingLicenseApps.AllowUserToAddRows = false;
            dgvManageInternationalDrivingLicenseApps.AllowUserToDeleteRows = false;
            dgvManageInternationalDrivingLicenseApps.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageInternationalDrivingLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageInternationalDrivingLicenseApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageInternationalDrivingLicenseApps.BackgroundColor = Color.White;
            dgvManageInternationalDrivingLicenseApps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageInternationalDrivingLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageInternationalDrivingLicenseApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageInternationalDrivingLicenseApps.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageInternationalDrivingLicenseApps.EnableHeadersVisualStyles = false;
            dgvManageInternationalDrivingLicenseApps.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageInternationalDrivingLicenseApps.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageInternationalDrivingLicenseApps.Location = new Point(13, 407);
            dgvManageInternationalDrivingLicenseApps.Name = "dgvManageInternationalDrivingLicenseApps";
            dgvManageInternationalDrivingLicenseApps.ReadOnly = true;
            dgvManageInternationalDrivingLicenseApps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageInternationalDrivingLicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageInternationalDrivingLicenseApps.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageInternationalDrivingLicenseApps.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageInternationalDrivingLicenseApps.SelectedIndex = -1;
            dgvManageInternationalDrivingLicenseApps.Size = new Size(1242, 318);
            dgvManageInternationalDrivingLicenseApps.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageInternationalDrivingLicenseApps.TabIndex = 84;
            dgvManageInternationalDrivingLicenseApps.CellContentClick += dgvManageInternationalDrivingLicenseApps_CellContentClick;
            dgvManageInternationalDrivingLicenseApps.CellMouseClick += dgvManageInternationalDrivingLicenseApps_CellMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Applications;
            pictureBox1.Location = new Point(567, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(192, 220);
            label1.Name = "label1";
            label1.Size = new Size(953, 49);
            label1.TabIndex = 82;
            label1.Text = "Manage International Driving License Applications";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(567, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 33);
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            // 
            // cmsInternational
            // 
            cmsInternational.ImageScalingSize = new Size(20, 20);
            cmsInternational.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, toolStripMenuItem1, showLicenseDetailsToolStripMenuItem, toolStripMenuItem2, showPersonLicensesHistoryToolStripMenuItem });
            cmsInternational.Name = "contextMenuStrip1";
            cmsInternational.Size = new Size(320, 130);
            cmsInternational.Opening += contextMenuStrip1_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(319, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(316, 6);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(319, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(316, 6);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            showPersonLicensesHistoryToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            showPersonLicensesHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicensesHistoryToolStripMenuItem.Image");
            showPersonLicensesHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            showPersonLicensesHistoryToolStripMenuItem.Size = new Size(319, 38);
            showPersonLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            showPersonLicensesHistoryToolStripMenuItem.Click += showPersonLicensesHistoryToolStripMenuItem_Click;
            // 
            // frmListInternationalLicenseApplication
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1268, 795);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(cbIsReleased);
            Controls.Add(lblTotalInternationalApps);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(imgbtnAddNewApp);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(dgvManageInternationalDrivingLicenseApps);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListInternationalLicenseApplication";
            ShowIcon = false;
            Text = "List International License Application";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmListInternationalLicenseApplication_Load;
            ((System.ComponentModel.ISupportInitialize)imgbtnAddNewApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageInternationalDrivingLicenseApps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cmsInternational.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIComboBox cbIsReleased;
        private Label lblTotalInternationalApps;
        private Label label3;
        private Label label2;
        private Sunny.UI.UIImageButton imgbtnAddNewApp;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIDataGridView dgvManageInternationalDrivingLicenseApps;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private ContextMenuStrip cmsInternational;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
    }
}