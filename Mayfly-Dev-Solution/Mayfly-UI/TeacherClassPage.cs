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
    public partial class TeacherClassPage : UserControl
    {
        private string className;

        public TeacherClassPage(string className)
        {
            InitializeComponent();
            this.className = className;
        }

        public string ClassName
        {
            get { return this.className;  }
            set { this.className = value; }
        }

        private void TeacherClassPage_Load(object sender, EventArgs e)
        {

        }
    }
}
