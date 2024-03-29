﻿using System;
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
    public partial class LaunchPage : UserControl
    {
        public LaunchPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            LogInPage lip = new LogInPage();
            if (parForm != null)
            {
                parForm.SwitchUserControl(lip);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1? parForm = this.ParentForm as Form1;
            SignUpPage sp = new SignUpPage();
            if (parForm != null)
            {
                parForm.SwitchUserControl(sp);
            }
        }
    }
}
