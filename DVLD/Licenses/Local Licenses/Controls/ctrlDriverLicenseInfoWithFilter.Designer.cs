namespace DVLD.Licenses.Local_Licenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDriverLicenseInfoWithFilter));
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            gbFilter = new Sunny.UI.UIGroupBox();
            btnSearch = new Button();
            label2 = new Label();
            txtSearchBy = new Sunny.UI.UITextBox();
            label1 = new Label();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlDriverLicenseInfo1.Location = new Point(14, 122);
            ctrlDriverLicenseInfo1.MinimumSize = new Size(1, 1);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlDriverLicenseInfo1.Size = new Size(1073, 430);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            ctrlDriverLicenseInfo1.Text = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(label2);
            gbFilter.Controls.Add(txtSearchBy);
            gbFilter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(14, 10);
            gbFilter.Margin = new Padding(4, 5, 4, 5);
            gbFilter.MinimumSize = new Size(1, 1);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(0, 32, 0, 0);
            gbFilter.RectDisableColor = Color.FromArgb(243, 249, 255);
            gbFilter.Size = new Size(1058, 104);
            gbFilter.TabIndex = 11;
            gbFilter.Text = "Filter";
            gbFilter.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(243, 249, 255);
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(448, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 41);
            btnSearch.TabIndex = 8;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 9;
            label2.Text = "Find By:";
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(217, 37);
            txtSearchBy.Margin = new Padding(4, 5, 4, 5);
            txtSearchBy.MinimumSize = new Size(1, 16);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.Padding = new Padding(5);
            txtSearchBy.Radius = 10;
            txtSearchBy.ShowText = false;
            txtSearchBy.Size = new Size(224, 43);
            txtSearchBy.TabIndex = 7;
            txtSearchBy.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchBy.Watermark = "";
            txtSearchBy.KeyPress += txtSearchBy_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 52);
            label1.Name = "label1";
            label1.Size = new Size(103, 26);
            label1.TabIndex = 10;
            label1.Text = "License ID";
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(gbFilter);
            Controls.Add(ctrlDriverLicenseInfo1);
            Name = "ctrlDriverLicenseInfoWithFilter";
            RectColor = Color.FromArgb(243, 249, 255);
            Size = new Size(1105, 598);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private Sunny.UI.UIGroupBox gbFilter;
        private Button btnSearch;
        private Label label2;
        private Sunny.UI.UITextBox txtSearchBy;
        private Label label1;
    }
}
