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

        }

        private void viewQuestionsButton_Click(object sender, EventArgs e)
        {

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
