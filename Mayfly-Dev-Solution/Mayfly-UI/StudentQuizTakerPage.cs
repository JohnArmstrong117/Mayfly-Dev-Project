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
    public partial class StudentQuizTakerPage : UserControl
    {
        private Quiz demoQuiz;
        private int questionNum;

        public StudentQuizTakerPage()
        {
            InitializeComponent();
            this.demoQuiz = new Quiz();
            this.demoQuiz.QuizName = "DemoQuiz";
            this.CreateDemoQuiz();
            this.questionNum = 1;
            this.EnterQuestionData();
        }

        private void aAnswerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidQuestionSubmit();
        }

        private void bAnswerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidQuestionSubmit();
        }

        private void cAnswerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidQuestionSubmit();
        }

        private void dAnswerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidQuestionSubmit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.questionNum++;
            this.EnterQuestionData();
            this.ValidQuestionSubmit();
        }

        private void finishQuizButton_Click(object sender, EventArgs e)
        {
            DialogResult verify = MessageBox.Show("Are you sure you want to submit? Any  unanswered questions will be marked incorrect.", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (verify == DialogResult.Yes)
            {
                Form1? parForm = this.ParentForm as Form1;
                if (parForm != null)
                {
                    StudentHomePage shp = new StudentHomePage();
                    parForm.SwitchUserControl(shp);
                }
            }
            else
            {
                return;
            }
        }

        private void CreateDemoQuiz()
        {
            Question question = new Question();
            question.QuestionText = "What color is the Sky?";
            string[] answers = new string[4];
            answers[0] = "Blue";
            answers[1] = "Red";
            answers[2] = "Green";
            answers[3] = "There is no Sky.";
            question.CorrectIndex = 0;
            question.AnswerText = answers;
            this.demoQuiz.AddQuestion(question);

            Question questionTwo = new Question();
            questionTwo.QuestionText = "What planet are we on?";
            string[] answersTwo = new string[4];
            answersTwo[0] = "Mars";
            answersTwo[1] = "Jupiter";
            answersTwo[2] = "Earth";
            answersTwo[3] = "Planet Cool";
            questionTwo.CorrectIndex = 2;
            questionTwo.AnswerText = answersTwo;
            this.demoQuiz.AddQuestion(questionTwo);

            Question questionThree = new Question();
            questionThree.QuestionText = "What is the tip of a shoelace called?";
            string[] answersThree = new string[4];
            answersThree[0] = "A Lip";
            answersThree[1] = "Aglet";
            answersThree[2] = "Crabhook";
            answersThree[3] = "What is a shoelace?";
            questionThree.CorrectIndex = 1;
            questionThree.AnswerText = answersThree;
            this.demoQuiz.AddQuestion(questionThree);
        }

        private void ValidQuestionSubmit()
        {
            if (this.aAnswerButton.Checked || this.bAnswerButton.Checked || this.cAnswerButton.Checked || this.dAnswerButton.Checked)
            {
                if (this.questionNum != this.demoQuiz.Questions.Count)
                {
                    this.button1.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = false;
                }
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void EnterQuestionData()
        {
            this.QuestionTextLabel.Text = this.demoQuiz.Questions[this.questionNum-1].QuestionText;
            this.answerOneLabel.Text = this.demoQuiz.Questions[this.questionNum-1].AnswerText[0];
            this.answerTwoLabel.Text = this.demoQuiz.Questions[this.questionNum-1].AnswerText[1];
            this.answerThreeLabel.Text = this.demoQuiz.Questions[this.questionNum-1].AnswerText[2];
            this.answerFourLabel.Text = this.demoQuiz.Questions[this.questionNum-1].AnswerText[3];
            this.questionNumberLabel.Text = "Question " + this.questionNum.ToString() + "/" + this.demoQuiz.Questions.Count.ToString();
        }
    }
}
