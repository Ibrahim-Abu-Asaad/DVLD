namespace DVLD.People.Controls
{
    partial class ctrlShowPersonDetailsWithFilter
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
            components = new System.ComponentModel.Container();
            ctrlShowPersonDetails21 = new ctrlShowPersonDetails2();
            label2 = new Label();
            cbFindBy = new Sunny.UI.UIComboBox();
            txtSearchBy = new Sunny.UI.UITextBox();
            gbFilter = new Sunny.UI.UIGroupBox();
            pbAddNewPerson = new PictureBox();
            pbSearchPerson = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNewPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlShowPersonDetails21
            // 
            ctrlShowPersonDetails21.BackColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails21.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlShowPersonDetails21.Location = new Point(13, 104);
            ctrlShowPersonDetails21.MinimumSize = new Size(1, 1);
            ctrlShowPersonDetails21.Name = "ctrlShowPersonDetails21";
            ctrlShowPersonDetails21.RectColor = Color.FromArgb(243, 249, 255);
            ctrlShowPersonDetails21.Size = new Size(962, 351);
            ctrlShowPersonDetails21.TabIndex = 0;
            ctrlShowPersonDetails21.Text = "ctrlShowPersonDetails21";
            ctrlShowPersonDetails21.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 26);
            label2.TabIndex = 9;
            label2.Text = "Find By:";
            // 
            // cbFindBy
            // 
            cbFindBy.Cursor = Cursors.Hand;
            cbFindBy.DataSource = null;
            cbFindBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbFindBy.FillColor = Color.White;
            cbFindBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFindBy.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbFindBy.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbFindBy.Location = new Point(102, 44);
            cbFindBy.Margin = new Padding(4, 5, 4, 5);
            cbFindBy.MinimumSize = new Size(63, 0);
            cbFindBy.Name = "cbFindBy";
            cbFindBy.Padding = new Padding(0, 0, 30, 2);
            cbFindBy.Radius = 10;
            cbFindBy.Size = new Size(218, 43);
            cbFindBy.SymbolSize = 24;
            cbFindBy.TabIndex = 8;
            cbFindBy.Text = "None";
            cbFindBy.TextAlignment = ContentAlignment.MiddleLeft;
            cbFindBy.Watermark = "";
            cbFindBy.SelectedIndexChanged += cbFindBy_SelectedIndexChanged;
            // 
            // txtSearchBy
            // 
            txtSearchBy.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBy.Location = new Point(326, 44);
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
            txtSearchBy.Validating += txtSearchBy_Validating;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbAddNewPerson);
            gbFilter.Controls.Add(pbSearchPerson);
            gbFilter.Controls.Add(label2);
            gbFilter.Controls.Add(txtSearchBy);
            gbFilter.Controls.Add(cbFindBy);
            gbFilter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(17, 6);
            gbFilter.Margin = new Padding(4, 5, 4, 5);
            gbFilter.MinimumSize = new Size(1, 1);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(0, 32, 0, 0);
            gbFilter.RectColor = Color.FromArgb(173, 178, 181);
            gbFilter.Size = new Size(949, 104);
            gbFilter.TabIndex = 10;
            gbFilter.Text = "Filter";
            gbFilter.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // pbAddNewPerson
            // 
            pbAddNewPerson.Cursor = Cursors.Hand;
            pbAddNewPerson.Image = Properties.Resources.Add_Person_404;
            pbAddNewPerson.Location = new Point(609, 50);
            pbAddNewPerson.Name = "pbAddNewPerson";
            pbAddNewPerson.Size = new Size(46, 37);
            pbAddNewPerson.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewPerson.TabIndex = 20;
            pbAddNewPerson.TabStop = false;
            pbAddNewPerson.Click += pbAddNewPerson_Click;
            // 
            // pbSearchPerson
            // 
            pbSearchPerson.Cursor = Cursors.Hand;
            pbSearchPerson.Image = Properties.Resources.SearchPerson;
            pbSearchPerson.Location = new Point(557, 50);
            pbSearchPerson.Name = "pbSearchPerson";
            pbSearchPerson.Size = new Size(46, 37);
            pbSearchPerson.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearchPerson.TabIndex = 19;
            pbSearchPerson.TabStop = false;
            pbSearchPerson.Click += pbSearchPerson_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlShowPersonDetailsWithFilter
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(gbFilter);
            Controls.Add(ctrlShowPersonDetails21);
            Name = "ctrlShowPersonDetailsWithFilter";
            Size = new Size(988, 470);
            Load += ctrlShowPersonDetailsWithFilter_Load;
            Click += ctrlShowPersonDetailsWithFilter_Click;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddNewPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearchPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlShowPersonDetails2 ctrlShowPersonDetails21;
        private Label label2;
        private Sunny.UI.UIComboBox cbFindBy;
        private Sunny.UI.UITextBox txtSearchBy;
        private Sunny.UI.UIGroupBox gbFilter;
        private PictureBox pbSearchPerson;
        private PictureBox pbAddNewPerson;
        private ErrorProvider errorProvider1;
    }
}
