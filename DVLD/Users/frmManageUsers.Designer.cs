namespace DVLD.Users
{
    partial class frmManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbSearchBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            cbIsActive = new Sunny.UI.UIComboBox();
            dgvManageUsers = new Sunny.UI.UIDataGridView();
            btnClose = new Sunny.UI.UIButton();
            pbAddNewUser = new PictureBox();
            lblTotalUsers = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users_2_4001;
            pictureBox1.Location = new Point(581, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(513, 232);
            label1.Name = "label1";
            label1.Size = new Size(274, 49);
            label1.TabIndex = 2;
            label1.Text = "Manage Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 726);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 17;
            label3.Text = "Total Users:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 359);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 15;
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
            cbSearchBy.Location = new Point(127, 351);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(218, 43);
            cbSearchBy.SymbolSize = 24;
            cbSearchBy.TabIndex = 13;
            cbSearchBy.Text = "None";
            cbSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbSearchBy.Watermark = "";
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(353, 351);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 12;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.TextChanged += txtSearchBy_TextChanged;
            // 
            // cbIsActive
            // 
            cbIsActive.Cursor = Cursors.Hand;
            cbIsActive.DataSource = null;
            cbIsActive.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbIsActive.FillColor = Color.White;
            cbIsActive.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbIsActive.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbIsActive.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbIsActive.Location = new Point(585, 352);
            cbIsActive.Margin = new Padding(4, 5, 4, 5);
            cbIsActive.MinimumSize = new Size(63, 0);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Padding = new Padding(0, 0, 30, 2);
            cbIsActive.Radius = 10;
            cbIsActive.Size = new Size(218, 44);
            cbIsActive.SymbolSize = 24;
            cbIsActive.TabIndex = 21;
            cbIsActive.Text = "None";
            cbIsActive.TextAlignment = ContentAlignment.MiddleLeft;
            cbIsActive.Watermark = "";
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // dgvManageUsers
            // 
            dgvManageUsers.AllowUserToAddRows = false;
            dgvManageUsers.AllowUserToDeleteRows = false;
            dgvManageUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageUsers.BackgroundColor = Color.White;
            dgvManageUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageUsers.EnableHeadersVisualStyles = false;
            dgvManageUsers.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageUsers.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageUsers.Location = new Point(21, 402);
            dgvManageUsers.Name = "dgvManageUsers";
            dgvManageUsers.ReadOnly = true;
            dgvManageUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageUsers.SelectedIndex = -1;
            dgvManageUsers.Size = new Size(1242, 318);
            dgvManageUsers.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageUsers.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(1138, 726);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // pbAddNewUser
            // 
            pbAddNewUser.Cursor = Cursors.Hand;
            pbAddNewUser.Image = Properties.Resources.Add_New_User_722;
            pbAddNewUser.Location = new Point(1196, 326);
            pbAddNewUser.Name = "pbAddNewUser";
            pbAddNewUser.Size = new Size(67, 70);
            pbAddNewUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewUser.TabIndex = 19;
            pbAddNewUser.TabStop = false;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = SystemColors.HotTrack;
            lblTotalUsers.Location = new Point(141, 726);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(22, 26);
            lblTotalUsers.TabIndex = 20;
            lblTotalUsers.Text = "0";
            // 
            // frmManageUsers
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1281, 802);
            Controls.Add(lblTotalUsers);
            Controls.Add(pbAddNewUser);
            Controls.Add(btnClose);
            Controls.Add(cbIsActive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(dgvManageUsers);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmManageUsers";
            ShowIcon = false;
            Text = "Manage Users";
            ZoomScaleRect = new Rectangle(19, 19, 1215, 732);
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddNewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Sunny.UI.UIButton Test;
        private Label lblTotalPeople;
        private Label label3;
        private Sunny.UI.UIButton uiButton1;
        private Label label2;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIDataGridView dgvManageUsers;
        private Sunny.UI.UIButton btnClose;
        private PictureBox pbAddNewUser;
        private Label lblTotalUsers;
        private Sunny.UI.UIComboBox cbIsActive;
    }
}