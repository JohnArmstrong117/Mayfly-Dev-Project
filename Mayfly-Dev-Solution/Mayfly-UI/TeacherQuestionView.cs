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
    public partial class TeacherQuestionView : UserControl
    {

        private Quiz activeQuiz;

        public TeacherQuestionView(Quiz q)
        {
            InitializeComponent();
            this.activeQuiz = q;
            this.label1.Text = q.QuizName;
            this.LoadQuestionsToFlow();
        }

        private void LoadQuestionsToFlow()
        {
            foreach (Question question in this.activeQuiz.Questions)
            {
                Button quizButton = new Button();
                quizButton.Text = question.QuestionText;
                quizButton.Size = new Size(200, 50);
                quizButton.BackColor = Color.OrangeRed;
                quizButton.Click += new EventHandler(this.OnQuizButtonPress);
                this.flowLayoutPanel1.Controls.Add(quizButton);
            }
        }

        private void OnQuizButtonPress(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            string qt = clicked.Text;
            List<Question> questions = this.activeQuiz.Questions;
            foreach (Question q in questions)
            {
                if (q.QuestionText == qt)
                {
                    this.activeQuiz.Questions.Remove(q);
                    this.flowLayoutPanel1.Controls.Remove(clicked);
                    break;
                }
            }
        }

        private void TeacherQuestionView_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                TeacherQuizPage tqp = new TeacherQuizPage(this.activeQuiz.QuizName);
                parForm.SwitchUserControl(tqp);
            }
        }
    }
}
