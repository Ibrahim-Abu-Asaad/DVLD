namespace DVLD
{
    partial class frmEditApplicationTypes
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
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSave = new Sunny.UI.UIButton();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtTitle = new Sunny.UI.UITextBox();
            txtFees = new Sunny.UI.UITextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(120, 68);
            label1.Name = "label1";
            label1.Size = new Size(433, 49);
            label1.TabIndex = 1;
            label1.Text = "Edit Application Types";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money_32;
            pictureBox3.Location = new Point(174, 248);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 107;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.edit_321;
            pictureBox2.Location = new Point(174, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 106;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(271, 333);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 105;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(109, 250);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(60, 26);
            lblConfirmPassword.TabIndex = 104;
            lblConfirmPassword.Text = "Fees:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(107, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 26);
            lblPassword.TabIndex = 103;
            lblPassword.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(209, 187);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.Radius = 10;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(355, 43);
            txtTitle.TabIndex = 101;
            txtTitle.TextAlignment = ContentAlignment.MiddleLeft;
            txtTitle.Watermark = "";
            // 
            // txtFees
            // 
            txtFees.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.Location = new Point(209, 240);
            txtFees.Margin = new Padding(4, 5, 4, 5);
            txtFees.MinimumSize = new Size(1, 16);
            txtFees.Name = "txtFees";
            txtFees.Padding = new Padding(5);
            txtFees.Radius = 10;
            txtFees.ShowText = false;
            txtFees.Size = new Size(224, 43);
            txtFees.TabIndex = 102;
            txtFees.TextAlignment = ContentAlignment.MiddleLeft;
            txtFees.Watermark = "";
            txtFees.KeyPress += txtFees_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationTypes
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(671, 409);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnSave);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtTitle);
            Controls.Add(txtFees);
            Controls.Add(label1);
            Name = "frmEditApplicationTypes";
            ShowIcon = false;
            Text = "Edit Application Types";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmEditApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Sunny.UI.UIButton btnSave;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UITextBox txtFees;
        private ErrorProvider errorProvider1;
    }
}