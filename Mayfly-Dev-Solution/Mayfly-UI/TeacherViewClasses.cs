using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mayfly_LogicEngine;

namespace Mayfly_UI
{
    public partial class TeacherViewClasses : UserControl
    {
        public TeacherViewClasses()
        {
            InitializeComponent();
            this.PopulateClassButtons();
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
                classButton.Click += new EventHandler(this.ClassButton_Click);
            }

            this.textBox1.Text = string.Empty;
            this.createClassButton.Enabled = false;
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                Button clicked = (Button)sender;
                string buttontext = clicked.Text;
                TeacherClassPage tcp = new TeacherClassPage(buttontext);
                parForm.AppManager.ActiveClass = parForm.GetClassFromUserByName(buttontext);
                parForm.SwitchUserControl(tcp);
            }
        }

        private void PopulateClassButtons()
        {
            Form1? parForm = this.ParentForm as Form1;
            if (parForm != null)
            {
                List<SchoolClass> classes = parForm.GetTeacherClasses();
                foreach (SchoolClass cls in classes)
                {
                    Button classButton = new Button();
                    classButton.Text = cls.Name;
                    classButton.Size = new Size(94, 60);
                    this.flowLayoutPanel1.Controls.Add(classButton);
                }
            }
        }

        private void TeacherViewClasses_Load(object sender, EventArgs e)
        {
            this.createClassButton.Enabled = false;
        }
    }
}
