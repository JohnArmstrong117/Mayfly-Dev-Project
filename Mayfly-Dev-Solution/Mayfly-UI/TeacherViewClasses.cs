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

        MayFlyAppManager appManager;

        public TeacherViewClasses()
        {
            InitializeComponent();
            this.PopulateClassButtons();
            this.appManager = MayFlyAppManager.GetInstance();
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
                SchoolClass newClass = new SchoolClass();
                newClass.Teacher = this.appManager.ActiveUser;
                newClass.Name = this.textBox1.Text;
                MayFlyAppManager.GetInstance().ActiveUser.AddClass(newClass);
                MayFlyAppManager.GetInstance().SaveAllChanges();
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
                MayFlyAppManager.GetInstance().ActiveClass = parForm.GetClassFromUserByName(buttontext);
                parForm.SwitchUserControl(tcp);
            }
        }

        private void PopulateClassButtons()
        {
            Teacher cur = (Teacher)MayFlyAppManager.GetInstance().ActiveUser;
            List<SchoolClass> classes = cur.SchoolClasses;
            foreach (SchoolClass cls in classes)
            {
                Button classButton = new Button();
                classButton.Text = cls.Name;
                classButton.Size = new Size(94, 60);
                this.flowLayoutPanel1.Controls.Add(classButton);
            }
        }

        private void TeacherViewClasses_Load(object sender, EventArgs e)
        {
            this.createClassButton.Enabled = false;
        }
    }
}
