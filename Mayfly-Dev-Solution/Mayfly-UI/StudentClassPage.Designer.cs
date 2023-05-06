namespace Mayfly_UI
{
    partial class StudentClassPage
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
            backButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            demoQuizOneButton = new Button();
            demoQuizTwoButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "DemoClass1";
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(255, 128, 128);
            backButton.Location = new Point(255, 18);
            backButton.Name = "backButton";
            backButton.Size = new Size(144, 34);
            backButton.TabIndex = 1;
            backButton.Text = "Return to Classes";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(demoQuizOneButton);
            flowLayoutPanel1.Controls.Add(demoQuizTwoButton);
            flowLayoutPanel1.Location = new Point(21, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(490, 203);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // demoQuizOneButton
            // 
            demoQuizOneButton.BackColor = Color.FromArgb(255, 255, 128);
            demoQuizOneButton.Location = new Point(3, 3);
            demoQuizOneButton.Name = "demoQuizOneButton";
            demoQuizOneButton.Size = new Size(136, 59);
            demoQuizOneButton.TabIndex = 0;
            demoQuizOneButton.Text = "DemoQuiz1";
            demoQuizOneButton.UseVisualStyleBackColor = false;
            demoQuizOneButton.Click += demoQuizOneButton_Click;
            // 
            // demoQuizTwoButton
            // 
            demoQuizTwoButton.BackColor = Color.FromArgb(255, 128, 0);
            demoQuizTwoButton.Location = new Point(145, 3);
            demoQuizTwoButton.Name = "demoQuizTwoButton";
            demoQuizTwoButton.Size = new Size(128, 59);
            demoQuizTwoButton.TabIndex = 1;
            demoQuizTwoButton.Text = "DemoQuiz2";
            demoQuizTwoButton.UseVisualStyleBackColor = false;
            demoQuizTwoButton.Click += demoQuizTwoButton_Click;
            // 
            // StudentClassPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(backButton);
            Controls.Add(label1);
            Name = "StudentClassPage";
            Size = new Size(536, 308);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button demoQuizOneButton;
        private Button demoQuizTwoButton;
    }
}
