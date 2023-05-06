namespace Mayfly_UI
{
    partial class TeacherQuestionView
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 35);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(28, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(515, 270);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(152, 35);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 2;
            label2.Text = "Click A Question below to delete it.";
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(255, 128, 128);
            backButton.Location = new Point(409, 13);
            backButton.Name = "backButton";
            backButton.Size = new Size(134, 42);
            backButton.TabIndex = 3;
            backButton.Text = "Return to Quiz";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // TeacherQuestionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "TeacherQuestionView";
            Size = new Size(566, 360);
            Load += TeacherQuestionView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button backButton;
    }
}
