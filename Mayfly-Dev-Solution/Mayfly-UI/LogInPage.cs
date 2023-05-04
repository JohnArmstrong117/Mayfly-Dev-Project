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
    public partial class LogInPage : UserControl
    {
        private LogInManager logInManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogInPage"/> class.
        /// </summary>
        public LogInPage()
        {
            InitializeComponent();
            this.logInManager = new LogInManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == string.Empty || this.textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter both a username and password.");
            }
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (this.logInManager.UserExists(username))
            {
                User foundUser = this.logInManager.getUserByUsername(username);
                if (foundUser != null)
                {
                    if (password == foundUser.Password)
                    {
                        if (foundUser is Teacher)
                        {
                            // TODO: LOGIn to teacher Ui with user
                            Form1? parForm = this.ParentForm as Form1;
                            if (parForm != null)
                            {
                                parForm.SetActiveUser(foundUser);
                                TeacherHomePage teacherHomePage = new TeacherHomePage();
                                parForm.SwitchUserControl(teacherHomePage);
                            }

                            MessageBox.Show("Success Teacher Logged In.");
                        }
                        else if (foundUser is Student)
                        {
                            MessageBox.Show("Success Student Logged In.");
                            // TODO: LOGIN to student ui with user
                            Form1? parForm = this.ParentForm as Form1;
                            if (parForm != null)
                            {
                                parForm.SetActiveUser(foundUser);
                                StudentHomePage studentHomePage = new StudentHomePage();
                                parForm.SwitchUserControl(studentHomePage);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("No matching User Found.");
                return;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
