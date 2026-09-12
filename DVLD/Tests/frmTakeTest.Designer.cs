namespace DVLD.Tests
{
    partial class frmTakeTest
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
            rtxtNotes = new RichTextBox();
            label9 = new Label();
            rbtnFail = new Sunny.UI.UIRadioButton();
            rbtnPass = new Sunny.UI.UIRadioButton();
            label1 = new Label();
            lblMessage = new Label();
            ctrlScheduledTest1 = new Controls.ctrlScheduledTest();
            btnSave = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // rtxtNotes
            // 
            rtxtNotes.Location = new Point(101, 677);
            rtxtNotes.Name = "rtxtNotes";
            rtxtNotes.Size = new Size(245, 82);
            rtxtNotes.TabIndex = 78;
            rtxtNotes.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(243, 249, 255);
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(48, 48, 48);
            label9.Location = new Point(21, 676);
            label9.Name = "label9";
            label9.Size = new Size(70, 26);
            label9.TabIndex = 77;
            label9.Text = "Notes:";
            // 
            // rbtnFail
            // 
            rbtnFail.BackColor = Color.FromArgb(243, 249, 255);
            rbtnFail.Font = new Font("Microsoft Sans Serif", 12F);
            rbtnFail.Location = new Point(177, 635);
            rbtnFail.MinimumSize = new Size(1, 1);
            rbtnFail.Name = "rbtnFail";
            rbtnFail.Size = new Size(76, 36);
            rbtnFail.TabIndex = 76;
            rbtnFail.Text = "Fail";
            // 
            // rbtnPass
            // 
            rbtnPass.BackColor = Color.FromArgb(243, 249, 255);
            rbtnPass.Font = new Font("Microsoft Sans Serif", 12F);
            rbtnPass.Location = new Point(98, 635);
            rbtnPass.MinimumSize = new Size(1, 1);
            rbtnPass.Name = "rbtnPass";
            rbtnPass.Size = new Size(82, 36);
            rbtnPass.TabIndex = 75;
            rbtnPass.Text = "Pass";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 249, 255);
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(48, 48, 48);
            label1.Location = new Point(21, 640);
            label1.Name = "label1";
            label1.Size = new Size(74, 26);
            label1.TabIndex = 74;
            label1.Text = "Result:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.FromArgb(243, 249, 255);
            lblMessage.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Tomato;
            lblMessage.Location = new Point(259, 644);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(222, 20);
            lblMessage.TabIndex = 73;
            lblMessage.Text = "You can not change the result";
            // 
            // ctrlScheduledTest1
            // 
            ctrlScheduledTest1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlScheduledTest1.Location = new Point(21, 47);
            ctrlScheduledTest1.MinimumSize = new Size(1, 1);
            ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            ctrlScheduledTest1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlScheduledTest1.Size = new Size(492, 551);
            ctrlScheduledTest1.TabIndex = 79;
            ctrlScheduledTest1.Text = "ctrlScheduledTest1";
            ctrlScheduledTest1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(388, 790);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 80;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(257, 790);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 81;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click_1;
            // 
            // frmTakeTest
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(540, 847);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(ctrlScheduledTest1);
            Controls.Add(rtxtNotes);
            Controls.Add(label9);
            Controls.Add(rbtnFail);
            Controls.Add(rbtnPass);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTakeTest";
            ShowIcon = false;
            Text = "Take Test";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtNotes;
        private Label label9;
        private Sunny.UI.UIRadioButton rbtnFail;
        private Sunny.UI.UIRadioButton rbtnPass;
        private Label label1;
        private Label lblMessage;
        private Controls.ctrlScheduledTest ctrlScheduledTest1;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnClose;
    }
}