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
    public partial class StudentClassPage : UserControl
    {
        public StudentClassPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                StudentClassViewPage scv = new StudentClassViewPage();
                parForm.SwitchUserControl(scv);
            }
        }

        private void demoQuizOneButton_Click(object sender, EventArgs e)
        {
            Form1? parform = this.ParentForm as Form1;
            if (parform != null)
            {
                StudentQuizTakerPage sqt = new StudentQuizTakerPage();
                parform.SwitchUserControl(sqt);
            }
        }

        private void demoQuizTwoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz's Available time has expired.");
        }
    }
}
