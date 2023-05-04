namespace Mayfly_UI
{
    using Mayfly_LogicEngine;

    public partial class Form1 : Form
    {
        private MayFlyAppManager appManager;

        public Form1()
        {
            InitializeComponent();
            this.AppManager = new MayFlyAppManager();
        }

        /// <summary>
        /// Gets or Sets AppManager.
        /// </summary>
        public MayFlyAppManager AppManager
        {
            get { return this.appManager; }
            set { this.appManager = value; }
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

        /// <summary>
        /// Sets the active user.
        /// </summary>
        /// <param name="newActive">User to set as active.</param>
        public void SetActiveUser(User newActive)
        {
            this.appManager.ActiveUser = newActive;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
                c.Visible = false;
                c.Dock = DockStyle.Fill;
            }

            LaunchPage lp = new LaunchPage();
            this.Controls.Add(lp);
            lp.Enabled = true;
            lp.Visible = true;
            lp.Dock = DockStyle.Fill;
            this.ActiveControl = lp;
        }
    }
}