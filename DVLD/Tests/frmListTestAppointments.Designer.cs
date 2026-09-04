namespace DVLD.Tests
{
    partial class frmListTestAppointments
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            ctrlLocalDrivingLicenseAppInfo1 = new Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo();
            pbTestType = new PictureBox();
            lblTestType = new Label();
            dgvLicenseTestAppointments = new Sunny.UI.UIDataGridView();
            btnAddAppointment = new Button();
            btnClose = new Sunny.UI.UIButton();
            label1 = new Label();
            label2 = new Label();
            lblTotalAppointments = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTestType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).BeginInit();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            ctrlLocalDrivingLicenseAppInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlLocalDrivingLicenseAppInfo1.Location = new Point(3, 129);
            ctrlLocalDrivingLicenseAppInfo1.MinimumSize = new Size(1, 1);
            ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlLocalDrivingLicenseAppInfo1.Size = new Size(910, 533);
            ctrlLocalDrivingLicenseAppInfo1.TabIndex = 0;
            ctrlLocalDrivingLicenseAppInfo1.Text = "ctrlLocalDrivingLicenseAppInfo1";
            ctrlLocalDrivingLicenseAppInfo1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pbTestType
            // 
            pbTestType.Image = Properties.Resources.Vision_5121;
            pbTestType.Location = new Point(258, 50);
            pbTestType.Name = "pbTestType";
            pbTestType.Size = new Size(98, 93);
            pbTestType.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestType.TabIndex = 1;
            pbTestType.TabStop = false;
            // 
            // lblTestType
            // 
            lblTestType.AutoSize = true;
            lblTestType.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestType.ForeColor = SystemColors.HotTrack;
            lblTestType.Location = new Point(37, 65);
            lblTestType.Name = "lblTestType";
            lblTestType.Size = new Size(221, 49);
            lblTestType.TabIndex = 2;
            lblTestType.Text = "Vision Test";
            // 
            // dgvLicenseTestAppointments
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgvLicenseTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvLicenseTestAppointments.BackgroundColor = Color.White;
            dgvLicenseTestAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvLicenseTestAppointments.DefaultCellStyle = dataGridViewCellStyle8;
            dgvLicenseTestAppointments.EnableHeadersVisualStyles = false;
            dgvLicenseTestAppointments.Font = new Font("Microsoft Sans Serif", 12F);
            dgvLicenseTestAppointments.GridColor = Color.FromArgb(80, 160, 255);
            dgvLicenseTestAppointments.Location = new Point(47, 696);
            dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            dgvLicenseTestAppointments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvLicenseTestAppointments.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dgvLicenseTestAppointments.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvLicenseTestAppointments.SelectedIndex = -1;
            dgvLicenseTestAppointments.Size = new Size(852, 122);
            dgvLicenseTestAppointments.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvLicenseTestAppointments.TabIndex = 3;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Cursor = Cursors.Hand;
            btnAddAppointment.Image = Properties.Resources.AddAppointment_32;
            btnAddAppointment.Location = new Point(866, 653);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(37, 39);
            btnAddAppointment.TabIndex = 4;
            btnAddAppointment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(774, 824);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 43;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(47, 664);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 44;
            label1.Text = "Appointments:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(47, 824);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 45;
            label2.Text = "Total Appointments:";
            // 
            // lblTotalAppointments
            // 
            lblTotalAppointments.AutoSize = true;
            lblTotalAppointments.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAppointments.ForeColor = Color.Tomato;
            lblTotalAppointments.Location = new Point(222, 824);
            lblTotalAppointments.Name = "lblTotalAppointments";
            lblTotalAppointments.Size = new Size(20, 23);
            lblTotalAppointments.TabIndex = 46;
            lblTotalAppointments.Text = "0";
            // 
            // frmListTestAppointments
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(952, 885);
            ControlBox = false;
            Controls.Add(lblTotalAppointments);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnAddAppointment);
            Controls.Add(dgvLicenseTestAppointments);
            Controls.Add(lblTestType);
            Controls.Add(pbTestType);
            Controls.Add(ctrlLocalDrivingLicenseAppInfo1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListTestAppointments";
            ShowIcon = false;
            Text = "List Test Appointments";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ((System.ComponentModel.ISupportInitialize)pbTestType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private PictureBox pbTestType;
        private Label lblTestType;
        private Sunny.UI.UIDataGridView dgvLicenseTestAppointments;
        private Button btnAddAppointment;
        private Sunny.UI.UIButton btnClose;
        private Label label1;
        private Label label2;
        private Label lblTotalAppointments;
    }
}