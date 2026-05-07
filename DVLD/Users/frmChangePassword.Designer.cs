namespace DVLD.Users
{
    partial class frmChangePassword
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
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            label2 = new Label();
            txtNewPassword = new Sunny.UI.UITextBox();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            txtCurrentPassword = new Sunny.UI.UITextBox();
            lblTitle = new Label();
            btnSave = new Sunny.UI.UIButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(139, 322);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(172, 26);
            lblConfirmPassword.TabIndex = 24;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(172, 269);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(139, 26);
            lblPassword.TabIndex = 23;
            lblPassword.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 199);
            label2.Name = "label2";
            label2.Size = new Size(169, 26);
            label2.TabIndex = 22;
            label2.Text = "Current Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(316, 261);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.MinimumSize = new Size(1, 16);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Padding = new Padding(5);
            txtNewPassword.Radius = 10;
            txtNewPassword.ShowText = false;
            txtNewPassword.Size = new Size(224, 43);
            txtNewPassword.TabIndex = 20;
            txtNewPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPassword.Watermark = "";
            txtNewPassword.TextChanged += txtCurrentPassword_TextChanged_1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(316, 314);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.Radius = 10;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(224, 43);
            txtConfirmPassword.TabIndex = 21;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            txtConfirmPassword.TextChanged += txtCurrentPassword_TextChanged_1;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(316, 191);
            txtCurrentPassword.Margin = new Padding(4, 5, 4, 5);
            txtCurrentPassword.MinimumSize = new Size(1, 16);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Padding = new Padding(5);
            txtCurrentPassword.Radius = 10;
            txtCurrentPassword.ShowText = false;
            txtCurrentPassword.Size = new Size(224, 43);
            txtCurrentPassword.TabIndex = 19;
            txtCurrentPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtCurrentPassword.Watermark = "";
            txtCurrentPassword.TextChanged += txtCurrentPassword_TextChanged_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(200, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 49);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Change Passwrod";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(316, 378);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(734, 472);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(label2);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtCurrentPassword);
            Name = "frmChangePassword";
            ShowIcon = false;
            Text = "Change Password";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label label2;
        private Sunny.UI.UITextBox txtNewPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Sunny.UI.UITextBox txtCurrentPassword;
        private Label lblTitle;
        private Sunny.UI.UIButton btnSave;
        private ErrorProvider errorProvider1;
    }
}