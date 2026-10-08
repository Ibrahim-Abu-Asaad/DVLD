namespace DVLD.Applications.Release_Detained_License
{
    partial class frmListDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDetainedLicenses));
            btnClose = new Sunny.UI.UIButton();
            cbStatus = new Sunny.UI.UIComboBox();
            lblTotalDetainedLicenses = new Label();
            label3 = new Label();
            label2 = new Label();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            dgvManageDetainedLicenses = new Sunny.UI.UIDataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            imgBtnReleaseDetainedLicense = new Button();
            imgBtnDetainLicense = new Button();
            cmsDetainedLicenses = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvManageDetainedLicenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cmsDetainedLicenses.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(1147, 728);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 92;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
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
            cbStatus.Location = new Point(575, 356);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.MinimumSize = new Size(63, 0);
            cbStatus.Name = "cbStatus";
            cbStatus.Padding = new Padding(0, 0, 30, 2);
            cbStatus.Radius = 10;
            cbStatus.Size = new Size(218, 43);
            cbStatus.SymbolSize = 24;
            cbStatus.TabIndex = 91;
            cbStatus.Text = "None";
            cbStatus.TextAlignment = ContentAlignment.MiddleLeft;
            cbStatus.Watermark = "";
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // lblTotalDetainedLicenses
            // 
            lblTotalDetainedLicenses.AutoSize = true;
            lblTotalDetainedLicenses.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDetainedLicenses.ForeColor = SystemColors.HotTrack;
            lblTotalDetainedLicenses.Location = new Point(252, 728);
            lblTotalDetainedLicenses.Name = "lblTotalDetainedLicenses";
            lblTotalDetainedLicenses.Size = new Size(22, 26);
            lblTotalDetainedLicenses.TabIndex = 90;
            lblTotalDetainedLicenses.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 728);
            label3.Name = "label3";
            label3.Size = new Size(233, 26);
            label3.TabIndex = 89;
            label3.Text = "Total Detained Licenses:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 364);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 88;
            label2.Text = "Filter By:";
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
            cbSearchBy.Location = new Point(119, 356);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(218, 43);
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
            txtSearchBy.Location = new Point(343, 356);
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
            // dgvManageDetainedLicenses
            // 
            dgvManageDetainedLicenses.AllowUserToAddRows = false;
            dgvManageDetainedLicenses.AllowUserToDeleteRows = false;
            dgvManageDetainedLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageDetainedLicenses.BackgroundColor = Color.White;
            dgvManageDetainedLicenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageDetainedLicenses.EnableHeadersVisualStyles = false;
            dgvManageDetainedLicenses.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageDetainedLicenses.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageDetainedLicenses.Location = new Point(13, 407);
            dgvManageDetainedLicenses.Name = "dgvManageDetainedLicenses";
            dgvManageDetainedLicenses.ReadOnly = true;
            dgvManageDetainedLicenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageDetainedLicenses.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageDetainedLicenses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageDetainedLicenses.SelectedIndex = -1;
            dgvManageDetainedLicenses.Size = new Size(1259, 318);
            dgvManageDetainedLicenses.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageDetainedLicenses.TabIndex = 84;
            dgvManageDetainedLicenses.CellMouseClick += dgvManageDetainedLicenses_CellMouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 54);
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
            label1.Location = new Point(457, 229);
            label1.Name = "label1";
            label1.Size = new Size(511, 49);
            label1.TabIndex = 82;
            label1.Text = "Manage Detained Licenses";
            // 
            // imgBtnReleaseDetainedLicense
            // 
            imgBtnReleaseDetainedLicense.Cursor = Cursors.Hand;
            imgBtnReleaseDetainedLicense.Image = (Image)resources.GetObject("imgBtnReleaseDetainedLicense.Image");
            imgBtnReleaseDetainedLicense.ImageAlign = ContentAlignment.MiddleRight;
            imgBtnReleaseDetainedLicense.Location = new Point(1128, 334);
            imgBtnReleaseDetainedLicense.Name = "imgBtnReleaseDetainedLicense";
            imgBtnReleaseDetainedLicense.Size = new Size(70, 65);
            imgBtnReleaseDetainedLicense.TabIndex = 94;
            imgBtnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            imgBtnReleaseDetainedLicense.Click += imgBtnReleaseDetainedLicense_Click;
            // 
            // imgBtnDetainLicense
            // 
            imgBtnDetainLicense.Cursor = Cursors.Hand;
            imgBtnDetainLicense.Image = (Image)resources.GetObject("imgBtnDetainLicense.Image");
            imgBtnDetainLicense.Location = new Point(1204, 334);
            imgBtnDetainLicense.Name = "imgBtnDetainLicense";
            imgBtnDetainLicense.Size = new Size(68, 65);
            imgBtnDetainLicense.TabIndex = 95;
            imgBtnDetainLicense.UseVisualStyleBackColor = true;
            imgBtnDetainLicense.Click += imgBtnDetainLicense_Click;
            // 
            // cmsDetainedLicenses
            // 
            cmsDetainedLicenses.ImageScalingSize = new Size(20, 20);
            cmsDetainedLicenses.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem, toolStripMenuItem1, releaseDetainedLicenseToolStripMenuItem });
            cmsDetainedLicenses.Name = "cmsDetainedLicenses";
            cmsDetainedLicenses.Size = new Size(312, 162);
            cmsDetainedLicenses.Opening += cmsDetainedLicenses_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(311, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            showLicenseDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseDetailsToolStripMenuItem.Image");
            showLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(311, 38);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(311, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(308, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Font = new Font("Trebuchet MS", 10.2F);
            releaseDetainedLicenseToolStripMenuItem.Image = (Image)resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image");
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(311, 38);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // frmListDetainedLicenses
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 786);
            ControlBox = false;
            Controls.Add(imgBtnDetainLicense);
            Controls.Add(imgBtnReleaseDetainedLicense);
            Controls.Add(btnClose);
            Controls.Add(cbStatus);
            Controls.Add(lblTotalDetainedLicenses);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(dgvManageDetainedLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListDetainedLicenses";
            ShowIcon = false;
            Text = "Manage Detained Licenses";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmListDetainedLicenses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManageDetainedLicenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cmsDetainedLicenses.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIComboBox cbStatus;
        private Label lblTotalDetainedLicenses;
        private Label label3;
        private Label label2;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIDataGridView dgvManageDetainedLicenses;
        private PictureBox pictureBox1;
        private Label label1;
        private Button imgBtnReleaseDetainedLicense;
        private Button imgBtnDetainLicense;
        private ContextMenuStrip cmsDetainedLicenses;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}