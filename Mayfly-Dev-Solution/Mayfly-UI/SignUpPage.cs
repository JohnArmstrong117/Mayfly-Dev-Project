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
    public partial class SignUpPage : UserControl
    {
        private LogInManager logInManager;

        public SignUpPage()
        {
            InitializeComponent();
            this.button1.Enabled = false;
            this.logInManager = new LogInManager();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked || this.radioButton2.Checked)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked || this.radioButton2.Checked)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == string.Empty || this.textBox2.Text == string.Empty || this.textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Fill out all Fields.");
                return;
            }

            if (this.textBox2.Text != this.textBox3.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (this.radioButton1.Checked)
            {
                string username = this.textBox1.Text;
                string password = this.textBox2.Text;
                this.logInManager.AddStudentUser(username, password);
            }
            else if (this.radioButton2.Checked)
            {
                string username = this.textBox1.Text;
                string password = this.textBox2.Text;
                this.logInManager.AddTeacherUser(username, password);
            }

            MessageBox.Show("SignUp Success -- Please Log In.");
            Form1? parForm = this.ParentForm as Form1;
            LogInPage lip = new LogInPage();
            if (parForm != null)
            {
                parForm.SwitchUserControl(lip);
            }
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }
    }
}
