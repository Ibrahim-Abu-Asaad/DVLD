namespace DVLD
{
    partial class frmManagePeople
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvManagePeople = new Sunny.UI.UIDataGridView();
            txtSearchBy = new Sunny.UI.UITextBox();
            cbSearchBy = new Sunny.UI.UIComboBox();
            uiImageButton1 = new Sunny.UI.UIImageButton();
            label2 = new Label();
            uiButton1 = new Sunny.UI.UIButton();
            label3 = new Label();
            lblTotalPeople = new Label();
            cmsPersonRecord = new Sunny.UI.UIContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deletePersonToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            emailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            cmsPeopleDGV = new ContextMenuStrip(components);
            addNewPersonToolStripMenuItem = new ToolStripMenuItem();
            Test = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManagePeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).BeginInit();
            cmsPersonRecord.SuspendLayout();
            cmsPeopleDGV.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(510, 236);
            label1.Name = "label1";
            label1.Size = new Size(298, 49);
            label1.TabIndex = 0;
            label1.Text = "Manage People";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.People_400;
            pictureBox1.Location = new Point(578, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvManagePeople
            // 
            dgvManagePeople.AllowUserToAddRows = false;
            dgvManagePeople.AllowUserToDeleteRows = false;
            dgvManagePeople.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgvManagePeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvManagePeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManagePeople.BackgroundColor = Color.White;
            dgvManagePeople.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvManagePeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvManagePeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvManagePeople.DefaultCellStyle = dataGridViewCellStyle8;
            dgvManagePeople.EnableHeadersVisualStyles = false;
            dgvManagePeople.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManagePeople.GridColor = Color.FromArgb(80, 160, 255);
            dgvManagePeople.Location = new Point(23, 411);
            dgvManagePeople.Name = "dgvManagePeople";
            dgvManagePeople.ReadOnly = true;
            dgvManagePeople.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvManagePeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvManagePeople.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManagePeople.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvManagePeople.SelectedIndex = -1;
            dgvManagePeople.Size = new Size(1242, 318);
            dgvManagePeople.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManagePeople.TabIndex = 2;
            dgvManagePeople.CellDoubleClick += dgvManagePeople_CellDoubleClick;
            dgvManagePeople.CellMouseClick += dgvManagePeople_CellMouseClick;
            dgvManagePeople.MouseClick += dgvManagePeople_MouseClick;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(353, 360);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 3;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.TextChanged += txtSearchBy_TextChanged;
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
            cbSearchBy.Location = new Point(129, 360);
            cbSearchBy.Margin = new Padding(4, 5, 4, 5);
            cbSearchBy.MinimumSize = new Size(63, 0);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Padding = new Padding(0, 0, 30, 2);
            cbSearchBy.Radius = 10;
            cbSearchBy.Size = new Size(218, 43);
            cbSearchBy.SymbolSize = 24;
            cbSearchBy.TabIndex = 4;
            cbSearchBy.Text = "None";
            cbSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbSearchBy.Watermark = "";
            cbSearchBy.TextChanged += cbSearchBy_TextChanged;
            cbSearchBy.SelectedIndexChanged += cbSearchBy_SelectedIndexChanged;
            // 
            // uiImageButton1
            // 
            uiImageButton1.Cursor = Cursors.Hand;
            uiImageButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton1.Image = Properties.Resources.Add_Person_72;
            uiImageButton1.Location = new Point(1198, 333);
            uiImageButton1.Name = "uiImageButton1";
            uiImageButton1.Size = new Size(67, 70);
            uiImageButton1.SizeMode = PictureBoxSizeMode.CenterImage;
            uiImageButton1.TabIndex = 5;
            uiImageButton1.TabStop = false;
            uiImageButton1.Text = null;
            uiImageButton1.Click += uiImageButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 368);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 6;
            label2.Text = "Filter By:";
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(1140, 735);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 7;
            uiButton1.Text = "Close";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.Click += uiButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 735);
            label3.Name = "label3";
            label3.Size = new Size(131, 26);
            label3.TabIndex = 8;
            label3.Text = "Total People:";
            // 
            // lblTotalPeople
            // 
            lblTotalPeople.AutoSize = true;
            lblTotalPeople.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPeople.ForeColor = SystemColors.HotTrack;
            lblTotalPeople.Location = new Point(156, 735);
            lblTotalPeople.Name = "lblTotalPeople";
            lblTotalPeople.Size = new Size(22, 26);
            lblTotalPeople.TabIndex = 9;
            lblTotalPeople.Text = "0";
            // 
            // cmsPersonRecord
            // 
            cmsPersonRecord.BackColor = Color.FromArgb(243, 249, 255);
            cmsPersonRecord.Font = new Font("Microsoft Sans Serif", 12F);
            cmsPersonRecord.ImageScalingSize = new Size(20, 20);
            cmsPersonRecord.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripMenuItem1, editToolStripMenuItem1, deletePersonToolStripMenuItem, toolStripMenuItem2, emailToolStripMenuItem, phoneCallToolStripMenuItem });
            cmsPersonRecord.Name = "cmsManagePeople";
            cmsPersonRecord.Size = new Size(216, 206);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(215, 38);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(212, 6);
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Font = new Font("Trebuchet MS", 12F);
            editToolStripMenuItem1.Image = Properties.Resources.edit_32;
            editToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(215, 38);
            editToolStripMenuItem1.Text = "Edit";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // deletePersonToolStripMenuItem
            // 
            deletePersonToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            deletePersonToolStripMenuItem.Image = Properties.Resources.Delete_32;
            deletePersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            deletePersonToolStripMenuItem.Size = new Size(215, 38);
            deletePersonToolStripMenuItem.Text = "Delete";
            deletePersonToolStripMenuItem.Click += deletePersonToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(212, 6);
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            emailToolStripMenuItem.Image = Properties.Resources.send_email_32;
            emailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(215, 38);
            emailToolStripMenuItem.Text = "Email";
            emailToolStripMenuItem.Click += emailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.Font = new Font("Trebuchet MS", 12F);
            phoneCallToolStripMenuItem.Image = Properties.Resources.call_32;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(215, 38);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // cmsPeopleDGV
            // 
            cmsPeopleDGV.ImageScalingSize = new Size(20, 20);
            cmsPeopleDGV.Items.AddRange(new ToolStripItem[] { addNewPersonToolStripMenuItem });
            cmsPeopleDGV.Name = "cmsPeopleDGV";
            cmsPeopleDGV.Size = new Size(250, 50);
            // 
            // addNewPersonToolStripMenuItem
            // 
            addNewPersonToolStripMenuItem.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewPersonToolStripMenuItem.Image = Properties.Resources.Add_Person_403;
            addNewPersonToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            addNewPersonToolStripMenuItem.Size = new Size(249, 46);
            addNewPersonToolStripMenuItem.Text = "Add New Person";
            addNewPersonToolStripMenuItem.Click += addNewPersonToolStripMenuItem_Click_1;
            // 
            // Test
            // 
            Test.Font = new Font("Microsoft Sans Serif", 12F);
            Test.Location = new Point(861, 350);
            Test.MinimumSize = new Size(1, 1);
            Test.Name = "Test";
            Test.Size = new Size(125, 44);
            Test.TabIndex = 10;
            Test.Text = "Test";
            Test.TipsFont = new Font("Microsoft Sans Serif", 9F);
            Test.Click += Test_Click;
            // 
            // frmManagePeople
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 809);
            Controls.Add(Test);
            Controls.Add(lblTotalPeople);
            Controls.Add(label3);
            Controls.Add(uiButton1);
            Controls.Add(label2);
            Controls.Add(uiImageButton1);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearchBy);
            Controls.Add(dgvManagePeople);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmManagePeople";
            ShowIcon = false;
            Text = "Manage People";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmManagePeople_Load;
            MouseClick += frmManagePeople_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManagePeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).EndInit();
            cmsPersonRecord.ResumeLayout(false);
            cmsPeopleDGV.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Sunny.UI.UIDataGridView dgvManagePeople;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIComboBox cbSearchBy;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Label label2;
        private Sunny.UI.UIButton uiButton1;
        private Label label3;
        private Label lblTotalPeople;
        private Sunny.UI.UIContextMenuStrip cmsPersonRecord;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem deletePersonToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ContextMenuStrip cmsPeopleDGV;
        private ToolStripMenuItem addNewPersonToolStripMenuItem;
        private Sunny.UI.UIButton Test;
    }
}