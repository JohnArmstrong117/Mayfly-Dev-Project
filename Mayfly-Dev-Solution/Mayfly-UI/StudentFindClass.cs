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
    public partial class StudentFindClass : UserControl
    {
        public StudentFindClass()
        {
            InitializeComponent();
            this.searchButton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {
                this.searchButton.Enabled = true;
            }
            else
            {
                this.searchButton.Enabled = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO: Search For the Class.
            MessageBox.Show("Failed to find class.");
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
    }
}
