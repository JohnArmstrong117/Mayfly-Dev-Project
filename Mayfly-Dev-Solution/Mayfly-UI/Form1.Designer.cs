namespace Mayfly_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logInPage1 = new LogInPage();
            launchPage1 = new LaunchPage();
            SuspendLayout();
            // 
            // logInPage1
            // 
            logInPage1.BackColor = SystemColors.ControlDark;
            logInPage1.Dock = DockStyle.Fill;
            logInPage1.Location = new Point(0, 0);
            logInPage1.Name = "logInPage1";
            logInPage1.Size = new Size(800, 450);
            logInPage1.TabIndex = 0;
            // 
            // launchPage1
            // 
            launchPage1.BackColor = SystemColors.ControlDark;
            launchPage1.Dock = DockStyle.Fill;
            launchPage1.Location = new Point(0, 0);
            launchPage1.Name = "launchPage1";
            launchPage1.Size = new Size(800, 450);
            launchPage1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(launchPage1);
            Controls.Add(logInPage1);
            Name = "Form1";
            Text = "Mayfly Quiz";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private LogInPage logInPage1;
        private LaunchPage launchPage1;
    }
}