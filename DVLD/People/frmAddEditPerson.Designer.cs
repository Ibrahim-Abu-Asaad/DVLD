namespace DVLD
{
    partial class frmAddEditPerson
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
            lblTitle = new Sunny.UI.UILabel();
            txtAddress = new Sunny.UI.UIRichTextBox();
            rbFemale = new Sunny.UI.UIRadioButton();
            rbMale = new Sunny.UI.UIRadioButton();
            btnSave = new Sunny.UI.UISymbolButton();
            llblRemove = new LinkLabel();
            llblSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            txtEmail = new Sunny.UI.UITextBox();
            cbCountry = new Sunny.UI.UIComboBox();
            txtPhone = new Sunny.UI.UITextBox();
            dtpDateOfBirth = new Sunny.UI.UIDatePicker();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            l2 = new Label();
            l1 = new Label();
            txtNationalNO = new Sunny.UI.UITextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtLastName = new Sunny.UI.UITextBox();
            txtThirdName = new Sunny.UI.UITextBox();
            txtSecondName = new Sunny.UI.UITextBox();
            txtFirstName = new Sunny.UI.UITextBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(3, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1050, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Person";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // txtAddress
            // 
            txtAddress.FillColor = Color.White;
            txtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            txtAddress.Location = new Point(219, 419);
            txtAddress.Margin = new Padding(4, 5, 4, 5);
            txtAddress.MinimumSize = new Size(1, 1);
            txtAddress.Name = "txtAddress";
            txtAddress.Padding = new Padding(2);
            txtAddress.ShowText = false;
            txtAddress.Size = new Size(572, 120);
            txtAddress.TabIndex = 9;
            txtAddress.TextAlignment = ContentAlignment.MiddleCenter;
            txtAddress.KeyPress += txtBox_KeyPress;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // rbFemale
            // 
            rbFemale.BackColor = Color.FromArgb(243, 249, 255);
            rbFemale.Font = new Font("Microsoft Sans Serif", 12F);
            rbFemale.Location = new Point(320, 303);
            rbFemale.MinimumSize = new Size(1, 1);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(96, 36);
            rbFemale.TabIndex = 0;
            rbFemale.Text = "Female";
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.BackColor = Color.FromArgb(243, 249, 255);
            rbMale.Font = new Font("Microsoft Sans Serif", 12F);
            rbMale.Location = new Point(233, 304);
            rbMale.MinimumSize = new Size(1, 1);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(81, 36);
            rbMale.TabIndex = 0;
            rbMale.Text = "Male";
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(666, 547);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // llblRemove
            // 
            llblRemove.AutoSize = true;
            llblRemove.BackColor = Color.FromArgb(243, 249, 255);
            llblRemove.Cursor = Cursors.Hand;
            llblRemove.Location = new Point(872, 488);
            llblRemove.Name = "llblRemove";
            llblRemove.Size = new Size(69, 20);
            llblRemove.TabIndex = 0;
            llblRemove.TabStop = true;
            llblRemove.Text = "Remove";
            llblRemove.LinkClicked += llblRemove_LinkClicked;
            // 
            // llblSetImage
            // 
            llblSetImage.AutoSize = true;
            llblSetImage.BackColor = Color.FromArgb(243, 249, 255);
            llblSetImage.Cursor = Cursors.Hand;
            llblSetImage.Location = new Point(872, 463);
            llblSetImage.Name = "llblSetImage";
            llblSetImage.Size = new Size(99, 20);
            llblSetImage.TabIndex = 0;
            llblSetImage.TabStop = true;
            llblSetImage.Text = "Set Image";
            llblSetImage.LinkClicked += llblSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackColor = Color.FromArgb(243, 249, 255);
            pbPersonImage.Image = Properties.Resources.Male_5121;
            pbPersonImage.Location = new Point(814, 239);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(212, 211);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 79;
            pbPersonImage.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(219, 353);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 10;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(166, 36);
            txtEmail.TabIndex = 8;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            txtEmail.KeyPress += txtBox_KeyPress;
            // 
            // cbCountry
            // 
            cbCountry.DataSource = null;
            cbCountry.FillColor = Color.White;
            cbCountry.Font = new Font("Microsoft Sans Serif", 12F);
            cbCountry.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbCountry.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbCountry.Location = new Point(603, 353);
            cbCountry.Margin = new Padding(4, 5, 4, 5);
            cbCountry.MinimumSize = new Size(63, 0);
            cbCountry.Name = "cbCountry";
            cbCountry.Padding = new Padding(0, 0, 30, 2);
            cbCountry.Radius = 10;
            cbCountry.Size = new Size(188, 36);
            cbCountry.SymbolSize = 24;
            cbCountry.TabIndex = 0;
            cbCountry.TextAlignment = ContentAlignment.MiddleLeft;
            cbCountry.Watermark = "";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            txtPhone.Location = new Point(603, 298);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(5);
            txtPhone.Radius = 10;
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(166, 36);
            txtPhone.TabIndex = 7;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "";
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtBox_KeyPress;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpDateOfBirth.FillColor = Color.White;
            dtpDateOfBirth.Font = new Font("Microsoft Sans Serif", 12F);
            dtpDateOfBirth.Location = new Point(603, 248);
            dtpDateOfBirth.Margin = new Padding(4, 5, 4, 5);
            dtpDateOfBirth.MaxLength = 10;
            dtpDateOfBirth.MinimumSize = new Size(63, 0);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Padding = new Padding(0, 0, 30, 2);
            dtpDateOfBirth.Radius = 10;
            dtpDateOfBirth.Size = new Size(188, 36);
            dtpDateOfBirth.SymbolDropDown = 61555;
            dtpDateOfBirth.SymbolNormal = 61555;
            dtpDateOfBirth.SymbolSize = 24;
            dtpDateOfBirth.TabIndex = 6;
            dtpDateOfBirth.Text = "2026-04-28";
            dtpDateOfBirth.TextAlignment = ContentAlignment.MiddleLeft;
            dtpDateOfBirth.Value = new DateTime(2026, 4, 28, 17, 47, 45, 652);
            dtpDateOfBirth.Watermark = "";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Country_32;
            pictureBox8.Location = new Point(565, 358);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 74;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Phone_32;
            pictureBox7.Location = new Point(565, 303);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 73;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Calendar_32;
            pictureBox6.Location = new Point(565, 253);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 31);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 72;
            pictureBox6.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(243, 249, 255);
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(469, 363);
            label10.Name = "label10";
            label10.Size = new Size(90, 26);
            label10.TabIndex = 71;
            label10.Text = "Country:";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.BackColor = Color.FromArgb(243, 249, 255);
            l2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l2.ForeColor = Color.Black;
            l2.Location = new Point(486, 308);
            l2.Name = "l2";
            l2.Size = new Size(73, 26);
            l2.TabIndex = 70;
            l2.Text = "Phone:";
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.BackColor = Color.FromArgb(243, 249, 255);
            l1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l1.ForeColor = Color.Black;
            l1.Location = new Point(422, 253);
            l1.Name = "l1";
            l1.Size = new Size(137, 26);
            l1.TabIndex = 69;
            l1.Text = "Date Of Birth:";
            // 
            // txtNationalNO
            // 
            txtNationalNO.Font = new Font("Microsoft Sans Serif", 12F);
            txtNationalNO.Location = new Point(219, 248);
            txtNationalNO.Margin = new Padding(4, 5, 4, 5);
            txtNationalNO.MinimumSize = new Size(1, 16);
            txtNationalNO.Name = "txtNationalNO";
            txtNationalNO.Padding = new Padding(5);
            txtNationalNO.Radius = 10;
            txtNationalNO.ShowText = false;
            txtNationalNO.Size = new Size(166, 36);
            txtNationalNO.TabIndex = 5;
            txtNationalNO.TextAlignment = ContentAlignment.MiddleLeft;
            txtNationalNO.Watermark = "";
            txtNationalNO.KeyPress += txtBox_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(243, 249, 255);
            label9.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(869, 160);
            label9.Name = "label9";
            label9.Size = new Size(42, 23);
            label9.TabIndex = 67;
            label9.Text = "Last";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(243, 249, 255);
            label8.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(668, 160);
            label8.Name = "label8";
            label8.Size = new Size(52, 23);
            label8.TabIndex = 66;
            label8.Text = "Third";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(243, 249, 255);
            label7.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(463, 159);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 65;
            label7.Text = "Second";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(279, 160);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 64;
            label1.Text = "First";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName.Location = new Point(807, 185);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.MinimumSize = new Size(1, 16);
            txtLastName.Name = "txtLastName";
            txtLastName.Padding = new Padding(5);
            txtLastName.Radius = 10;
            txtLastName.ShowText = false;
            txtLastName.Size = new Size(166, 36);
            txtLastName.TabIndex = 4;
            txtLastName.TextAlignment = ContentAlignment.MiddleLeft;
            txtLastName.Watermark = "";
            txtLastName.KeyPress += txtBox_KeyPress;
            // 
            // txtThirdName
            // 
            txtThirdName.Font = new Font("Microsoft Sans Serif", 12F);
            txtThirdName.Location = new Point(611, 185);
            txtThirdName.Margin = new Padding(4, 5, 4, 5);
            txtThirdName.MinimumSize = new Size(1, 16);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.Padding = new Padding(5);
            txtThirdName.Radius = 10;
            txtThirdName.ShowText = false;
            txtThirdName.Size = new Size(166, 36);
            txtThirdName.TabIndex = 3;
            txtThirdName.TextAlignment = ContentAlignment.MiddleLeft;
            txtThirdName.Watermark = "";
            txtThirdName.KeyPress += txtBox_KeyPress;
            // 
            // txtSecondName
            // 
            txtSecondName.Font = new Font("Microsoft Sans Serif", 12F);
            txtSecondName.Location = new Point(415, 185);
            txtSecondName.Margin = new Padding(4, 5, 4, 5);
            txtSecondName.MinimumSize = new Size(1, 16);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Padding = new Padding(5);
            txtSecondName.Radius = 10;
            txtSecondName.ShowText = false;
            txtSecondName.Size = new Size(166, 36);
            txtSecondName.TabIndex = 2;
            txtSecondName.TextAlignment = ContentAlignment.MiddleLeft;
            txtSecondName.Watermark = "";
            txtSecondName.KeyPress += txtBox_KeyPress;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F);
            txtFirstName.Location = new Point(219, 185);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.MinimumSize = new Size(1, 16);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Padding = new Padding(5);
            txtFirstName.Radius = 10;
            txtFirstName.ShowText = false;
            txtFirstName.Size = new Size(166, 36);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFirstName.Watermark = "";
            txtFirstName.KeyPress += txtBox_KeyPress;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Person_321;
            pictureBox9.Location = new Point(169, 190);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 31);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 59;
            pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Address_32;
            pictureBox5.Location = new Point(169, 419);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Email_32;
            pictureBox4.Location = new Point(169, 358);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 57;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Man_32;
            pictureBox3.Location = new Point(169, 303);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Number_32;
            pictureBox2.Location = new Point(169, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(243, 249, 255);
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(27, 424);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 54;
            label6.Text = "Address:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(243, 249, 255);
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(27, 363);
            label5.Name = "label5";
            label5.Size = new Size(70, 26);
            label5.TabIndex = 53;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(243, 249, 255);
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(27, 308);
            label4.Name = "label4";
            label4.Size = new Size(85, 26);
            label4.TabIndex = 52;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(243, 249, 255);
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(27, 253);
            label3.Name = "label3";
            label3.Size = new Size(128, 26);
            label3.TabIndex = 51;
            label3.Text = "National NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 249, 255);
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 195);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 50;
            label2.Text = "Name:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(535, 547);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 80;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // frmAddEditPerson
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1056, 626);
            Controls.Add(btnClose);
            Controls.Add(txtAddress);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(btnSave);
            Controls.Add(llblRemove);
            Controls.Add(llblSetImage);
            Controls.Add(pbPersonImage);
            Controls.Add(txtEmail);
            Controls.Add(cbCountry);
            Controls.Add(txtPhone);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(label10);
            Controls.Add(l2);
            Controls.Add(l1);
            Controls.Add(txtNationalNO);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtThirdName);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Name = "frmAddEditPerson";
            ShowIcon = false;
            Text = "Add/Edit Person Info";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            FormClosing += frmAddEditPerson_FormClosing;
            Load += frmAddEditPerson_Load;
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIRichTextBox txtAddress;
        private Sunny.UI.UIRadioButton rbFemale;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UISymbolButton btnSave;
        private LinkLabel llblRemove;
        private LinkLabel llblSetImage;
        private PictureBox pbPersonImage;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UIComboBox cbCountry;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UIDatePicker dtpDateOfBirth;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label label10;
        private Label l2;
        private Label l1;
        private Sunny.UI.UITextBox txtNationalNO;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label1;
        private Sunny.UI.UITextBox txtLastName;
        private Sunny.UI.UITextBox txtThirdName;
        private Sunny.UI.UITextBox txtSecondName;
        private Sunny.UI.UITextBox txtFirstName;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Sunny.UI.UIButton btnClose;
    }
}