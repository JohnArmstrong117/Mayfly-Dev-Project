namespace Mayfly_UI
{
    partial class TeacherHomePage
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
            label2 = new Label();
            viewAccountButton = new Button();
            viewClassesButton = new Button();
            signOutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(138, 25);
            label1.Name = "label1";
            label1.Size = new Size(268, 47);
            label1.TabIndex = 0;
            label1.Text = "Mayfly Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 86);
            label2.Name = "label2";
            label2.Size = new Size(112, 27);
            label2.TabIndex = 1;
            label2.Text = "Teacher";
            // 
            // viewAccountButton
            // 
            viewAccountButton.BackColor = Color.FromArgb(255, 192, 255);
            viewAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewAccountButton.Location = new Point(223, 130);
            viewAccountButton.Name = "viewAccountButton";
            viewAccountButton.Size = new Size(94, 67);
            viewAccountButton.TabIndex = 2;
            viewAccountButton.Text = "View Account";
            viewAccountButton.UseVisualStyleBackColor = false;
            viewAccountButton.Click += viewAccountButton_Click;
            // 
            // viewClassesButton
            // 
            viewClassesButton.BackColor = Color.FromArgb(192, 255, 192);
            viewClassesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewClassesButton.Location = new Point(223, 217);
            viewClassesButton.Name = "viewClassesButton";
            viewClassesButton.Size = new Size(94, 64);
            viewClassesButton.TabIndex = 3;
            viewClassesButton.Text = "View Classes";
            viewClassesButton.UseVisualStyleBackColor = false;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.FromArgb(255, 128, 128);
            signOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signOutButton.Location = new Point(223, 300);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(94, 66);
            signOutButton.TabIndex = 4;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            // 
            // TeacherHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(signOutButton);
            Controls.Add(viewClassesButton);
            Controls.Add(viewAccountButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TeacherHomePage";
            Size = new Size(584, 393);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button viewAccountButton;
        private Button viewClassesButton;
        private Button signOutButton;
    }
}
