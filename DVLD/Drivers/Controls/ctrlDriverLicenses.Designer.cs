namespace DVLD.Drivers
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tbDriverLicenses = new TabControl();
            tpLocal = new TabPage();
            dgvLocalLicenses = new Sunny.UI.UIDataGridView();
            colShow = new DataGridViewImageColumn();
            tpInternational = new TabPage();
            dgvInternationalLicenses = new Sunny.UI.UIDataGridView();
            label1 = new Label();
            colShowInt = new DataGridViewImageColumn();
            tbDriverLicenses.SuspendLayout();
            tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).BeginInit();
            tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            SuspendLayout();
            // 
            // tbDriverLicenses
            // 
            tbDriverLicenses.Controls.Add(tpLocal);
            tbDriverLicenses.Controls.Add(tpInternational);
            tbDriverLicenses.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDriverLicenses.Location = new Point(23, 38);
            tbDriverLicenses.Name = "tbDriverLicenses";
            tbDriverLicenses.SelectedIndex = 0;
            tbDriverLicenses.Size = new Size(1020, 383);
            tbDriverLicenses.TabIndex = 0;
            // 
            // tpLocal
            // 
            tpLocal.BackColor = Color.FromArgb(243, 249, 255);
            tpLocal.Controls.Add(dgvLocalLicenses);
            tpLocal.Location = new Point(4, 32);
            tpLocal.Name = "tpLocal";
            tpLocal.Padding = new Padding(3);
            tpLocal.Size = new Size(1012, 347);
            tpLocal.TabIndex = 0;
            tpLocal.Text = "Local Licenses";
            // 
            // dgvLocalLicenses
            // 
            dgvLocalLicenses.AllowUserToAddRows = false;
            dgvLocalLicenses.AllowUserToDeleteRows = false;
            dgvLocalLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvLocalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalLicenses.BackgroundColor = Color.White;
            dgvLocalLicenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLocalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalLicenses.ColumnHeadersHeight = 32;
            dgvLocalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLocalLicenses.Columns.AddRange(new DataGridViewColumn[] { colShow });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLocalLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLocalLicenses.EnableHeadersVisualStyles = false;
            dgvLocalLicenses.Font = new Font("Microsoft Sans Serif", 12F);
            dgvLocalLicenses.GridColor = Color.FromArgb(80, 160, 255);
            dgvLocalLicenses.Location = new Point(6, 6);
            dgvLocalLicenses.Name = "dgvLocalLicenses";
            dgvLocalLicenses.ReadOnly = true;
            dgvLocalLicenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLocalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLocalLicenses.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvLocalLicenses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvLocalLicenses.SelectedIndex = -1;
            dgvLocalLicenses.Size = new Size(1000, 335);
            dgvLocalLicenses.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvLocalLicenses.TabIndex = 0;
            dgvLocalLicenses.CellContentClick += dgvLocalLicenses_CellContentClick;
            dgvLocalLicenses.MouseMove += dgvLocalLicenses_MouseMove;
            // 
            // colShow
            // 
            colShow.HeaderText = "";
            colShow.Image = Properties.Resources.id_card_fill__4_;
            colShow.MinimumWidth = 6;
            colShow.Name = "colShow";
            colShow.ReadOnly = true;
            colShow.Resizable = DataGridViewTriState.True;
            colShow.SortMode = DataGridViewColumnSortMode.Automatic;
            colShow.Width = 40;
            // 
            // tpInternational
            // 
            tpInternational.BackColor = Color.FromArgb(243, 249, 255);
            tpInternational.Controls.Add(dgvInternationalLicenses);
            tpInternational.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpInternational.Location = new Point(4, 32);
            tpInternational.Name = "tpInternational";
            tpInternational.Padding = new Padding(3);
            tpInternational.Size = new Size(1012, 347);
            tpInternational.TabIndex = 1;
            tpInternational.Text = "International Licenses";
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgvInternationalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dgvInternationalLicenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvInternationalLicenses.ColumnHeadersHeight = 32;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInternationalLicenses.Columns.AddRange(new DataGridViewColumn[] { colShowInt });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvInternationalLicenses.DefaultCellStyle = dataGridViewCellStyle8;
            dgvInternationalLicenses.EnableHeadersVisualStyles = false;
            dgvInternationalLicenses.Font = new Font("Microsoft Sans Serif", 12F);
            dgvInternationalLicenses.GridColor = Color.FromArgb(80, 160, 255);
            dgvInternationalLicenses.Location = new Point(6, 6);
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dgvInternationalLicenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvInternationalLicenses.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dgvInternationalLicenses.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvInternationalLicenses.SelectedIndex = -1;
            dgvInternationalLicenses.Size = new Size(1000, 335);
            dgvInternationalLicenses.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvInternationalLicenses.TabIndex = 1;
            dgvInternationalLicenses.CellContentClick += dgvInternationalLicenses_CellContentClick;
            dgvInternationalLicenses.MouseMove += dgvInternationalLicenses_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 1;
            label1.Text = "Driver Licenses:";
            // 
            // colShowInt
            // 
            colShowInt.HeaderText = "";
            colShowInt.Image = Properties.Resources.id_card_fill__4_1;
            colShowInt.MinimumWidth = 6;
            colShowInt.Name = "colShowInt";
            colShowInt.ReadOnly = true;
            colShowInt.Resizable = DataGridViewTriState.True;
            colShowInt.SortMode = DataGridViewColumnSortMode.Automatic;
            colShowInt.Width = 40;
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label1);
            Controls.Add(tbDriverLicenses);
            Name = "ctrlDriverLicenses";
            RectColor = Color.FromArgb(243, 249, 255);
            Size = new Size(1052, 432);
            tbDriverLicenses.ResumeLayout(false);
            tpLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenses).EndInit();
            tpInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbDriverLicenses;
        private TabPage tpLocal;
        private TabPage tpInternational;
        private Label label1;
        private Sunny.UI.UIDataGridView dgvLocalLicenses;
        private Sunny.UI.UIDataGridView dgvInternationalLicenses;
        private DataGridViewImageColumn colShow;
        private DataGridViewImageColumn colShowInt;
    }
}
