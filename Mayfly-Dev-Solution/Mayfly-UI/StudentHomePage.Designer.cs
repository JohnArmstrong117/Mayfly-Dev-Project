﻿namespace Mayfly_UI
{
    partial class StudentHomePage
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
            viewClassesButton = new Button();
            signOutButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(151, 24);
            label1.Name = "label1";
            label1.Size = new Size(268, 47);
            label1.TabIndex = 0;
            label1.Text = "MayFly Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 83);
            label2.Name = "label2";
            label2.Size = new Size(112, 27);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // viewClassesButton
            // 
            viewClassesButton.BackColor = Color.FromArgb(192, 255, 192);
            viewClassesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewClassesButton.Location = new Point(235, 215);
            viewClassesButton.Name = "viewClassesButton";
            viewClassesButton.Size = new Size(112, 68);
            viewClassesButton.TabIndex = 3;
            viewClassesButton.Text = "View Classes";
            viewClassesButton.UseVisualStyleBackColor = false;
            viewClassesButton.Click += viewClassesButton_Click;
            // 
            // signOutButton
            // 
            signOutButton.BackColor = Color.FromArgb(255, 128, 128);
            signOutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signOutButton.Location = new Point(237, 299);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(110, 57);
            signOutButton.TabIndex = 4;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(235, 121);
            button1.Name = "button1";
            button1.Size = new Size(112, 78);
            button1.TabIndex = 5;
            button1.Text = "View Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // StudentHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(button1);
            Controls.Add(signOutButton);
            Controls.Add(viewClassesButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentHomePage";
            Size = new Size(613, 390);
            Load += StudentHomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button viewClassesButton;
        private Button signOutButton;
        private Button button1;
    }
}
