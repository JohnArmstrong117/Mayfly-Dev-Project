namespace Mayfly_UI
{
    partial class StudentClassViewPage
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
            findClassButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            demoClassButton1 = new Button();
            demoClassButtonTwo = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 0;
            label1.Text = "Classes";
            // 
            // findClassButton
            // 
            findClassButton.BackColor = Color.FromArgb(192, 255, 192);
            findClassButton.Location = new Point(17, 64);
            findClassButton.Name = "findClassButton";
            findClassButton.Size = new Size(126, 46);
            findClassButton.TabIndex = 1;
            findClassButton.Text = "Find a Class";
            findClassButton.UseVisualStyleBackColor = false;
            findClassButton.Click += findClassButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(demoClassButton1);
            flowLayoutPanel1.Controls.Add(demoClassButtonTwo);
            flowLayoutPanel1.Location = new Point(20, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(484, 192);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // demoClassButton1
            // 
            demoClassButton1.BackColor = Color.FromArgb(255, 128, 128);
            demoClassButton1.Location = new Point(3, 3);
            demoClassButton1.Name = "demoClassButton1";
            demoClassButton1.Size = new Size(129, 61);
            demoClassButton1.TabIndex = 0;
            demoClassButton1.Text = "Demo Class 1";
            demoClassButton1.UseVisualStyleBackColor = false;
            demoClassButton1.Click += demoClassButton1_Click;
            // 
            // demoClassButtonTwo
            // 
            demoClassButtonTwo.BackColor = Color.FromArgb(255, 128, 255);
            demoClassButtonTwo.Location = new Point(138, 3);
            demoClassButtonTwo.Name = "demoClassButtonTwo";
            demoClassButtonTwo.Size = new Size(143, 61);
            demoClassButtonTwo.TabIndex = 1;
            demoClassButtonTwo.Text = "Demo Class 2";
            demoClassButtonTwo.UseVisualStyleBackColor = false;
            demoClassButtonTwo.Click += demoClassButtonTwo_Click;
            // 
            // StudentClassViewPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(findClassButton);
            Controls.Add(label1);
            Name = "StudentClassViewPage";
            Size = new Size(523, 333);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button findClassButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button demoClassButton1;
        private Button demoClassButtonTwo;
    }
}
