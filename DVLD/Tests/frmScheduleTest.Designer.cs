namespace DVLD.Tests
{
    partial class frmScheduleTest
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
            ctrlSheduleTest1 = new Controls.ctrlSheduleTest();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // ctrlSheduleTest1
            // 
            ctrlSheduleTest1.Font = new Font("Microsoft Sans Serif", 12F);
            ctrlSheduleTest1.Location = new Point(17, 49);
            ctrlSheduleTest1.MinimumSize = new Size(1, 1);
            ctrlSheduleTest1.Name = "ctrlSheduleTest1";
            ctrlSheduleTest1.RectColor = Color.FromArgb(243, 249, 255);
            ctrlSheduleTest1.Size = new Size(612, 834);
            ctrlSheduleTest1.TabIndex = 0;
            ctrlSheduleTest1.TestTypeID = DVLD_BLL.clsTestType.enTestType.VisionTest;
            ctrlSheduleTest1.Text = "ctrlSheduleTest1";
            ctrlSheduleTest1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Location = new Point(264, 889);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.Size = new Size(125, 44);
            btnClose.TabIndex = 42;
            btnClose.Text = "Close";
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClose.Click += btnClose_Click;
            // 
            // frmScheduleTest
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(648, 942);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(ctrlSheduleTest1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmScheduleTest";
            ShowIcon = false;
            Text = "Schedule Test";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmScheduleTest_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlSheduleTest ctrlSheduleTest1;
        private Sunny.UI.UIButton btnClose;
    }
}