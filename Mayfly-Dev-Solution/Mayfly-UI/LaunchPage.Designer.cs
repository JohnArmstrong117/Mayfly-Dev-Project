namespace Mayfly_UI
{
    partial class LaunchPage
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(155, 37);
            label1.Name = "label1";
            label1.Size = new Size(268, 47);
            label1.TabIndex = 0;
            label1.Text = "MayFly Quiz";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(243, 121);
            button1.Name = "button1";
            button1.Size = new Size(80, 50);
            button1.TabIndex = 1;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(243, 191);
            button2.Name = "button2";
            button2.Size = new Size(80, 50);
            button2.TabIndex = 2;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LaunchPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "LaunchPage";
            Size = new Size(611, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}
