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
    public partial class StudentClassViewPage : UserControl
    {
        public StudentClassViewPage()
        {
            InitializeComponent();
        }

        private void findClassButton_Click(object sender, EventArgs e)
        {
            Form1? parform = this.ParentForm as Form1;
            if (parform != null)
            {
                StudentFindClass sfc = new StudentFindClass();
                parform.SwitchUserControl(sfc);
            }
        }

        private void demoClassButton1_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                StudentClassPage scp = new StudentClassPage();
                parForm.SwitchUserControl(scp);
            }
        }

        private void demoClassButtonTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Class has Ended, Class View no longer available.");
        }
    }
}
