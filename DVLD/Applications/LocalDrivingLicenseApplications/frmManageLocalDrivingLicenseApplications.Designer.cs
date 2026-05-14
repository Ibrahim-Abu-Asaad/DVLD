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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            label2 = new Label();
            imgbtnAddNewApp = new Sunny.UI.UIImageButton();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            dgvManageLocalDrivingLicenseApps = new Sunny.UI.UIDataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgbtnAddNewApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageLocalDrivingLicenseApps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // dgvManageLocalDrivingLicenseApps
            // 
            dgvManageLocalDrivingLicenseApps.AllowUserToAddRows = false;
            dgvManageLocalDrivingLicenseApps.AllowUserToDeleteRows = false;
            dgvManageLocalDrivingLicenseApps.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageLocalDrivingLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvManageLocalDrivingLicenseApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageLocalDrivingLicenseApps.BackgroundColor = Color.White;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvManageLocalDrivingLicenseApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvManageLocalDrivingLicenseApps.DefaultCellStyle = dataGridViewCellStyle13;
            dgvManageLocalDrivingLicenseApps.EnableHeadersVisualStyles = false;
            dgvManageLocalDrivingLicenseApps.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageLocalDrivingLicenseApps.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageLocalDrivingLicenseApps.Location = new Point(29, 428);
            dgvManageLocalDrivingLicenseApps.Name = "dgvManageLocalDrivingLicenseApps";
            dgvManageLocalDrivingLicenseApps.ReadOnly = true;
            dgvManageLocalDrivingLicenseApps.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvManageLocalDrivingLicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvManageLocalDrivingLicenseApps.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageLocalDrivingLicenseApps.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvManageLocalDrivingLicenseApps.SelectedIndex = -1;
            dgvManageLocalDrivingLicenseApps.Size = new Size(1242, 318);
            dgvManageLocalDrivingLicenseApps.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageLocalDrivingLicenseApps.TabIndex = 13;
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
            label1.Location = new Point(336, 242);
            label1.Name = "label1";
            label1.Size = new Size(656, 49);
            label1.TabIndex = 11;
            label1.Text = "Local Driving License Applications";
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1300, 815);
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
    }
}