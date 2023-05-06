namespace Mayfly_UI
{
    partial class TeacherQuizPage
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
            nameLabel = new Label();
            homeButton = new Button();
            questionLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            addQuestionButton = new Button();
            viewQuestionsButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.FromArgb(192, 255, 255);
            nameLabel.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(20, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(121, 35);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "label1";
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(255, 192, 192);
            homeButton.Location = new Point(36, 68);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(94, 55);
            homeButton.TabIndex = 1;
            homeButton.Text = "Return Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(164, 24);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(102, 20);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "Question Text:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(272, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(306, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(272, 215);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(306, 27);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 74);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 8;
            label1.Text = "Answer1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 9;
            label2.Text = "Answer2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 168);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 10;
            label3.Text = "Answer3:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 218);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 11;
            label4.Text = "Answer4:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 281);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 12;
            label5.Text = "Correct Answer:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Answer1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(108, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Answer2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 56);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(86, 24);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "Answer3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(108, 56);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(86, 24);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "Answer4";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(272, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 91);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // addQuestionButton
            // 
            addQuestionButton.BackColor = Color.FromArgb(192, 255, 192);
            addQuestionButton.Location = new Point(24, 265);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(117, 63);
            addQuestionButton.TabIndex = 18;
            addQuestionButton.Text = "Add Question";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // viewQuestionsButton
            // 
            viewQuestionsButton.BackColor = Color.FromArgb(192, 255, 255);
            viewQuestionsButton.Location = new Point(36, 147);
            viewQuestionsButton.Name = "viewQuestionsButton";
            viewQuestionsButton.Size = new Size(94, 62);
            viewQuestionsButton.TabIndex = 19;
            viewQuestionsButton.Text = "View Questions";
            viewQuestionsButton.UseVisualStyleBackColor = false;
            viewQuestionsButton.Click += viewQuestionsButton_Click;
            // 
            // TeacherQuizPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(viewQuestionsButton);
            Controls.Add(addQuestionButton);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(questionLabel);
            Controls.Add(homeButton);
            Controls.Add(nameLabel);
            Name = "TeacherQuizPage";
            Size = new Size(607, 342);
            Load += TeacherQuizPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button homeButton;
        private Label questionLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private Button addQuestionButton;
        private Button viewQuestionsButton;
    }
}
