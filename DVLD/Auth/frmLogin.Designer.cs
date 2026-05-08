namespace DVLD.Auth
{
    partial class frmLogin
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
            btnLogin = new Sunny.UI.UIButton();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            chbShowPassword = new Sunny.UI.UICheckBox();
            errorProvider1 = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F);
            btnLogin.Location = new Point(887, 438);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 10;
            btnLogin.Size = new Size(125, 44);
            btnLogin.TabIndex = 34;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(742, 337);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(101, 26);
            lblConfirmPassword.TabIndex = 32;
            lblConfirmPassword.Text = "Password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(734, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(109, 26);
            lblPassword.TabIndex = 31;
            lblPassword.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(887, 273);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(5);
            txtUsername.Radius = 10;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(224, 43);
            txtUsername.TabIndex = 28;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(887, 326);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '●';
            txtPassword.Radius = 10;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(224, 43);
            txtPassword.TabIndex = 29;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // chbShowPassword
            // 
            chbShowPassword.Font = new Font("Microsoft Sans Serif", 12F);
            chbShowPassword.ForeColor = Color.FromArgb(48, 48, 48);
            chbShowPassword.Location = new Point(886, 369);
            chbShowPassword.MinimumSize = new Size(1, 1);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(188, 36);
            chbShowPassword.TabIndex = 100;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login_Photo;
            pictureBox1.Location = new Point(3, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 554);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(757, 142);
            label1.Name = "label1";
            label1.Size = new Size(434, 49);
            label1.TabIndex = 37;
            label1.Text = "Login To Your Account";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Person_322;
            pictureBox2.Location = new Point(852, 275);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password_322;
            pictureBox3.Location = new Point(852, 334);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1256, 596);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(chbShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            Text = "Login";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnLogin;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UICheckBox chbShowPassword;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}