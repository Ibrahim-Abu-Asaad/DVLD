namespace DVLD.Drivers
{
    partial class frmListDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDrivers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            dgvManageDrivers = new Sunny.UI.UIDataGridView();
            btnClose = new Sunny.UI.UIButton();
            lblTotalDrivers = new Label();
            label3 = new Label();
            cmsDrivers = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            issueInternationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageDrivers).BeginInit();
            cmsDrivers.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(524, 236);
            label1.Name = "label1";
            label1.Size = new Size(306, 49);
            label1.TabIndex = 13;
            label1.Text = "Manage Drivers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 339);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 24;
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
            cbSearchBy.Location = new Point(125, 331);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(218, 43);
            cbSearchBy.SymbolSize = 24;
            cbSearchBy.TabIndex = 22;
            cbSearchBy.Text = "None";
            cbSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbSearchBy.Watermark = "";
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(349, 331);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 21;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.TextChanged += txtSearchBy_TextChanged;
            // 
            // dgvManageDrivers
            // 
            dgvManageDrivers.AllowUserToAddRows = false;
            dgvManageDrivers.AllowUserToDeleteRows = false;
            dgvManageDrivers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageDrivers.BackgroundColor = Color.White;
            dgvManageDrivers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageDrivers.EnableHeadersVisualStyles = false;
            dgvManageDrivers.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageDrivers.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageDrivers.Location = new Point(26, 382);
            dgvManageDrivers.Name = "dgvManageDrivers";
            dgvManageDrivers.ReadOnly = true;
            dgvManageDrivers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageDrivers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageDrivers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageDrivers.SelectedIndex = -1;
            dgvManageDrivers.Size = new Size(1242, 318);
            dgvManageDrivers.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageDrivers.TabIndex = 26;
            dgvManageDrivers.CellMouseClick += dgvManageDrivers_CellMouseClick;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(1143, 706);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 84;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // lblTotalDrivers
            // 
            lblTotalDrivers.AutoSize = true;
            lblTotalDrivers.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalDrivers.ForeColor = SystemColors.HotTrack;
            lblTotalDrivers.Location = new Point(159, 706);
            lblTotalDrivers.Name = "lblTotalDrivers";
            lblTotalDrivers.Size = new Size(22, 26);
            lblTotalDrivers.TabIndex = 83;
            lblTotalDrivers.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 706);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 82;
            label3.Text = "Total People:";
            // 
            // cmsDrivers
            // 
            cmsDrivers.ImageScalingSize = new Size(20, 20);
            cmsDrivers.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, toolStripMenuItem1, issueInternationalLicenseToolStripMenuItem, toolStripMenuItem2, showPersonLicenseHistoryToolStripMenuItem });
            cmsDrivers.Name = "cmsDrivers";
            cmsDrivers.Size = new Size(353, 130);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPersonDetailsToolStripMenuItem.Image = (Image)resources.GetObject("showPersonDetailsToolStripMenuItem.Image");
            showPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(352, 38);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Info";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(349, 6);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            issueInternationalLicenseToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            issueInternationalLicenseToolStripMenuItem.Image = (Image)resources.GetObject("issueInternationalLicenseToolStripMenuItem.Image");
            issueInternationalLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            issueInternationalLicenseToolStripMenuItem.Size = new Size(352, 38);
            issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            issueInternationalLicenseToolStripMenuItem.Click += issueInternationalLicenseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(349, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            showPersonLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image");
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(352, 38);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem.Click += showPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // frmListDrivers
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1286, 776);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lblTotalDrivers);
            Controls.Add(label3);
            Controls.Add(dgvManageDrivers);
            Controls.Add(label2);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListDrivers";
            ShowIcon = false;
            Text = "Manage Drivers";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmListDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageDrivers).EndInit();
            cmsDrivers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Sunny.UI.UIComboBox cbStatus;
        private Label label2;
        private Sunny.UI.UIImageButton imgbtnAddNewApp;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIDataGridView dgvManageDrivers;
        private Sunny.UI.UIButton btnClose;
        private Label lblTotalDrivers;
        private Label label3;
        private ContextMenuStrip cmsDrivers;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}