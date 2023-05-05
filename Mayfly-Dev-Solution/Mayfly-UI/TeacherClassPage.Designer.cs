namespace Mayfly_UI
{
    partial class TeacherClassPage
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
            classNameLabel = new Label();
            returnToHomeButton = new Button();
            label1 = new Label();
            newNameBox = new TextBox();
            createQuizButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // classNameLabel
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.BackColor = Color.FromArgb(192, 255, 255);
            classNameLabel.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            classNameLabel.Location = new Point(24, 25);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new Size(121, 35);
            classNameLabel.TabIndex = 0;
            classNameLabel.Text = "label1";
            // 
            // returnToHomeButton
            // 
            returnToHomeButton.BackColor = Color.FromArgb(255, 192, 192);
            returnToHomeButton.Location = new Point(38, 77);
            returnToHomeButton.Name = "returnToHomeButton";
            returnToHomeButton.Size = new Size(94, 29);
            returnToHomeButton.TabIndex = 1;
            returnToHomeButton.Text = "Home";
            returnToHomeButton.UseVisualStyleBackColor = false;
            returnToHomeButton.Click += returnToHomeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 119);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 2;
            label1.Text = "To Create a quiz enter the\r\nnew quiz name bellow:";
            // 
            // newNameBox
            // 
            newNameBox.Location = new Point(24, 175);
            newNameBox.Name = "newNameBox";
            newNameBox.Size = new Size(179, 27);
            newNameBox.TabIndex = 3;
            newNameBox.TextChanged += newNameBox_TextChanged;
            // 
            // createQuizButton
            // 
            createQuizButton.BackColor = Color.FromArgb(192, 255, 192);
            createQuizButton.Location = new Point(38, 219);
            createQuizButton.Name = "createQuizButton";
            createQuizButton.Size = new Size(94, 29);
            createQuizButton.TabIndex = 4;
            createQuizButton.Text = "Create Quiz";
            createQuizButton.UseVisualStyleBackColor = false;
            createQuizButton.Click += createQuizButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(235, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(276, 314);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // TeacherClassPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(createQuizButton);
            Controls.Add(newNameBox);
            Controls.Add(label1);
            Controls.Add(returnToHomeButton);
            Controls.Add(classNameLabel);
            Name = "TeacherClassPage";
            Size = new Size(549, 367);
            Load += TeacherClassPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classNameLabel;
        private Button returnToHomeButton;
        private Label label1;
        private TextBox newNameBox;
        private Button createQuizButton;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
