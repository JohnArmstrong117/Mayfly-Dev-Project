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
    public partial class TeacherViewClasses : UserControl
    {
        public TeacherViewClasses()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == string.Empty)
            {
                this.createClassButton.Enabled = false;
            }
            else
            {
                this.createClassButton.Enabled = true;
            }
        }

        private void createClassButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                parForm.AddClassForActiveTeacher(this.textBox1.Text);
                Button classButton = new Button();
                classButton.Text = this.textBox1.Text;
                classButton.Size = new Size(94, 60);

                this.flowLayoutPanel1.Controls.Add(classButton);
            }
            this.textBox1.Text = string.Empty;
            this.createClassButton.Enabled = false;
        }

        private void TeacherViewClasses_Load(object sender, EventArgs e)
        {
            this.createClassButton.Enabled = false;
        }
    }
}
