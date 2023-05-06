using Mayfly_LogicEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayfly_UI
{
    public partial class TeacherQuizPage : UserControl
    {
        private string name;
        private Quiz thisQuiz;

        public TeacherQuizPage(string nm)
        {
            InitializeComponent();
            this.name = nm;
            this.nameLabel.Text = nm;
            this.thisQuiz = MayFlyAppManager.GetInstance().ActiveQuiz;
            if (this.thisQuiz == null)
            {
                this.thisQuiz = new Quiz();
            }

            this.addQuestionButton.Enabled = false;
        }

        private void TeacherQuizPage_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MayFlyAppManager.GetInstance().ActiveClass.QuizList.Add(this.thisQuiz);
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                TeacherHomePage thp = new TeacherHomePage();
                parForm.SwitchUserControl(thp);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            string qText = this.textBox1.Text;
            string[] astrings = new string[4];
            astrings[0] = this.textBox2.Text;
            astrings[1] = this.textBox3.Text;
            astrings[2] = this.textBox4.Text;
            astrings[3] = this.textBox5.Text;
            int cInd = -1;
            if (this.radioButton1.Checked)
            {
                cInd = 0;
            }
            else if (this.radioButton2.Checked)
            {
                cInd = 1;
            }
            else if (this.radioButton3.Checked)
            {
                cInd = 2;
            }
            else if (this.radioButton4.Checked)
            {
                cInd = 3;
            }

            Question newQuestion = new Question();
            newQuestion.QuestionText = qText;
            newQuestion.AnswerText = astrings;
            newQuestion.CorrectIndex = cInd;
            this.thisQuiz.AddQuestion(newQuestion);
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox5.Text = string.Empty;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
        }

        private void viewQuestionsButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                TeacherQuestionView tqw = new TeacherQuestionView(this.thisQuiz);
                parForm.SwitchUserControl(tqw);
            }
        }

        private void CheckValidAddQuiz()
        {
            if (this.textBox1.Text.Length > 0 && this.textBox2.Text.Length > 0 && this.textBox3.Text.Length > 0 && this.textBox4.Text.Length > 0 && this.textBox5.Text.Length > 0)
            {
                if (this.radioButton1.Checked || this.radioButton2.Checked || this.radioButton3.Checked || this.radioButton4.Checked)
                {
                    this.addQuestionButton.Enabled = true;
                }
            }
            else
            {
                this.addQuestionButton.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckValidAddQuiz();
        }
    }
}
