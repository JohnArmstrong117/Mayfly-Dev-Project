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
    public partial class TeacherClassPage : UserControl
    {
        private string className;

        public TeacherClassPage(string className)
        {
            InitializeComponent();
            this.className = className;
            this.classNameLabel.Text = className;
        }

        public string ClassName
        {
            get { return this.className; }
            set { this.className = value; }
        }

        private void TeacherClassPage_Load(object sender, EventArgs e)
        {

        }

        private void returnToHomeButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                TeacherHomePage thp = new TeacherHomePage();
                parForm.SwitchUserControl(thp);
            }
        }

        private void newNameBox_TextChanged(object sender, EventArgs e)
        {
            if (this.newNameBox.Text == string.Empty)
            {
                this.createQuizButton.Enabled = false;
            }
            else
            {
                this.createQuizButton.Enabled = true;
            }
        }

        private void createQuizButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                // TODO add quiz to class
                Button quizButton = new Button();
                quizButton.Text = this.newNameBox.Text;
                quizButton.Size = new Size(94, 60);

                this.flowLayoutPanel1.Controls.Add(quizButton);
                quizButton.Click += new EventHandler(this.QuizButton_Click);
            }

            this.newNameBox.Text = string.Empty;
            this.createQuizButton.Enabled = false;
        }

        private void QuizButton_Click(object sender, EventArgs e)
        {

        }
    }
}
