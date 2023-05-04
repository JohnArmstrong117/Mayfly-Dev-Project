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
    public partial class TeacherHomePage : UserControl
    {
        public TeacherHomePage()
        {
            InitializeComponent();
        }

        private void viewAccountButton_Click(object sender, EventArgs e)
        {

        }

        private void viewClassesButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                TeacherViewClasses tvc = new TeacherViewClasses();
                parForm.SwitchUserControl(tvc);
            }
        }
    }
}
