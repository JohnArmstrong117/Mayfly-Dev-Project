namespace Mayfly_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches active controlls in the form.
        /// </summary>
        /// <param name="newControll">Control to Switch to.</param>
        public void SwitchUserControl(UserControl newControll)
        {
            this.Controls.Remove(this.ActiveControl);
            this.Controls.Add(newControll);
            newControll.Enabled = true;
            newControll.Visible = true;
            newControll.Dock = DockStyle.Fill;
            this.ActiveControl = newControll;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LaunchPage lp = new LaunchPage();
            this.Controls.Add(lp);
            lp.Enabled = true;
            lp.Visible = true;
            lp.Dock = DockStyle.Fill;
            this.ActiveControl = lp;
        }
    }
}