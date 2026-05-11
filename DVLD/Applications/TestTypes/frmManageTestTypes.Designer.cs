namespace DVLD.Applications.TestTypes
{
    partial class frmManageTestTypes
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgvManageTestTypes = new Sunny.UI.UIDataGridView();
            colEdit = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageTestTypes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TestType_5121;
            pictureBox2.Location = new Point(367, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 161);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(279, 225);
            label1.Name = "label1";
            label1.Size = new Size(364, 49);
            label1.TabIndex = 2;
            label1.Text = "Manage Test Types";
            // 
            // dgvManageTestTypes
            // 
            dgvManageTestTypes.AllowUserToAddRows = false;
            dgvManageTestTypes.AllowUserToDeleteRows = false;
            dgvManageTestTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvManageTestTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvManageTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageTestTypes.BackgroundColor = Color.White;
            dgvManageTestTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvManageTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvManageTestTypes.ColumnHeadersHeight = 32;
            dgvManageTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvManageTestTypes.Columns.AddRange(new DataGridViewColumn[] { colEdit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvManageTestTypes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvManageTestTypes.EnableHeadersVisualStyles = false;
            dgvManageTestTypes.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageTestTypes.GridColor = Color.FromArgb(80, 160, 255);
            dgvManageTestTypes.Location = new Point(3, 290);
            dgvManageTestTypes.Name = "dgvManageTestTypes";
            dgvManageTestTypes.ReadOnly = true;
            dgvManageTestTypes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvManageTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvManageTestTypes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvManageTestTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvManageTestTypes.SelectedIndex = -1;
            dgvManageTestTypes.Size = new Size(960, 330);
            dgvManageTestTypes.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvManageTestTypes.TabIndex = 4;
            dgvManageTestTypes.CellContentClick += dgvManageTestTypes_CellContentClick_1;
            dgvManageTestTypes.MouseMove += dgvManageTestTypes_MouseMove;
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
            // frmManageTestTypes
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(966, 666);
            Controls.Add(dgvManageTestTypes);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "frmManageTestTypes";
            ShowIcon = false;
            Text = "Manage Test Types";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmManageTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManageTestTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Sunny.UI.UIDataGridView dgvManageTestTypes;
        private DataGridViewImageColumn colEdit;
    }
}