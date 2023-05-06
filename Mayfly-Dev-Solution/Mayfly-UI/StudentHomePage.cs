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
    public partial class StudentHomePage : UserControl
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        private void StudentHomePage_Load(object sender, EventArgs e)
        {
        }

        private void viewClassesButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                StudentClassViewPage scv = new StudentClassViewPage();
                parForm.SwitchUserControl(scv);
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                LaunchPage lp = new LaunchPage();
                MayFlyAppManager.GetInstance().ActiveClass = null;
                MayFlyAppManager.GetInstance().ActiveUser = null;
                MayFlyAppManager.GetInstance().ActiveQuiz = null;
                parForm.SwitchUserControl(lp);
            }
        }
    }
}
