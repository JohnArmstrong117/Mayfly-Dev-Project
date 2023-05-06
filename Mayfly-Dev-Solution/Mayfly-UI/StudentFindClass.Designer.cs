namespace Mayfly_UI
{
    partial class StudentFindClass
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
            textBox1 = new TextBox();
            searchButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(205, 35);
            label1.TabIndex = 0;
            label1.Text = "Find A Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 66);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Teachers Class Code:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 255, 192);
            searchButton.Location = new Point(32, 141);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 39);
            searchButton.TabIndex = 3;
            searchButton.Text = "Enroll";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(255, 128, 128);
            backButton.Location = new Point(32, 200);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 42);
            backButton.TabIndex = 4;
            backButton.Text = "Cancel";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // StudentFindClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(backButton);
            Controls.Add(searchButton);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentFindClass";
            Size = new Size(503, 345);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button searchButton;
        private Button backButton;
    }
}
