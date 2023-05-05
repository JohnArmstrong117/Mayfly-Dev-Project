namespace Mayfly_UI
{
    partial class TeacherViewClasses
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
            homeButton = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            createClassButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 35);
            label1.TabIndex = 0;
            label1.Text = "Classes";
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(255, 192, 192);
            homeButton.Location = new Point(50, 76);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(94, 56);
            homeButton.TabIndex = 1;
            homeButton.Text = "Return Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 207);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(208, 27);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(343, 330);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(163, 60);
            label2.TabIndex = 4;
            label2.Text = "To create a class enter\r\na class name in the box\r\nbelow:\r\n";
            // 
            // createClassButton
            // 
            createClassButton.BackColor = Color.FromArgb(192, 255, 192);
            createClassButton.Location = new Point(50, 250);
            createClassButton.Name = "createClassButton";
            createClassButton.Size = new Size(94, 60);
            createClassButton.TabIndex = 6;
            createClassButton.Text = "Create Class";
            createClassButton.UseVisualStyleBackColor = false;
            createClassButton.Click += createClassButton_Click;
            // 
            // TeacherViewClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(createClassButton);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(homeButton);
            Controls.Add(label1);
            Name = "TeacherViewClasses";
            Size = new Size(575, 382);
            Load += TeacherViewClasses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button homeButton;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button createClassButton;
    }
}
