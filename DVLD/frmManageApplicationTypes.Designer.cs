namespace DVLD
{
    partial class frmManageApplicationTypes
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
            dgvManageApplicationTypes = new Sunny.UI.UIDataGridView();
            colEdit = new DataGridViewImageColumn();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageApplicationTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvManageApplicationTypes
            // 
            dgvManageApplicationTypes.AllowUserToAddRows = false;
            dgvManageApplicationTypes.AllowUserToDeleteRows = false;
            dgvManageApplicationTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageApplicationTypes.BackgroundColor = Color.White;
            dgvManageApplicationTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageApplicationTypes.ColumnHeadersHeight = 32;
            dgvManageApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvManageApplicationTypes.Columns.AddRange(new DataGridViewColumn[] { colEdit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageApplicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageApplicationTypes.EnableHeadersVisualStyles = false;
            dgvManageApplicationTypes.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageApplicationTypes.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageApplicationTypes.Location = new Point(3, 307);
            dgvManageApplicationTypes.Name = "dgvManageApplicationTypes";
            dgvManageApplicationTypes.ReadOnly = true;
            dgvManageApplicationTypes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageApplicationTypes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageApplicationTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageApplicationTypes.SelectedIndex = -1;
            dgvManageApplicationTypes.Size = new Size(842, 330);
            dgvManageApplicationTypes.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageApplicationTypes.TabIndex = 3;
            dgvManageApplicationTypes.CellContentClick += dgvManageApplicationTypes_CellContentClick;
            dgvManageApplicationTypes.CellMouseEnter += dgvManageApplicationTypes_CellMouseEnter;
            dgvManageApplicationTypes.CellMouseLeave += dgvManageApplicationTypes_CellMouseLeave;
            dgvManageApplicationTypes.MouseMove += dgvManageApplicationTypes_MouseMove;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "";
            colEdit.Image = Properties.Resources.Edit1;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Resizable = DataGridViewTriState.True;
            colEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(132, 225);
            label1.Name = "label1";
            label1.Size = new Size(498, 49);
            label1.TabIndex = 4;
            label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Application_Types_512;
            pictureBox1.Location = new Point(289, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(848, 708);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvManageApplicationTypes);
            Name = "frmManageApplicationTypes";
            ShowIcon = false;
            Text = "Manage Application Types";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmManageApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManageApplicationTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView dgvManageApplicationTypes;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewImageColumn colEdit;
    }
}