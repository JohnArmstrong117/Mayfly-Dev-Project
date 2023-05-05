namespace Mayfly_UI
{
    using Mayfly_LogicEngine;

    public partial class Form1 : Form
    {
        private MayFlyAppManager appManager;

        public Form1()
        {
            InitializeComponent();
            this.AppManager = MayFlyAppManager.GetInstance();
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
            MayFlyAppManager.GetInstance().ActiveUser = newActive;
        }

        /// <summary>
        /// Adds a new class to the active Teacher.
        /// </summary>
        /// <param name="newName">string name of new class.</param>
        public void AddClassForActiveTeacher(string newName)
        {
            Teacher? currentTeacher = this.appManager.ActiveUser as Teacher;
            if (currentTeacher != null)
            {
                SchoolClass newClass = new SchoolClass();
                newClass.Name = newName;
                newClass.Teacher = this.appManager.ActiveUser;
                currentTeacher.AddClass(newClass);
                this.appManager.SaveAllChanges();
            }
        }

        /// <summary>
        /// Gets a class using a name from the active user.
        /// </summary>
        /// <param name="name">Name of the class to be found.</param>
        /// <returns>Class if found, null if not.</returns>
        public SchoolClass GetClassFromUserByName(string name)
        {
            Teacher? currentTeacher = (Teacher)MayFlyAppManager.GetInstance().ActiveUser;
            if (currentTeacher != null)
            {
                List<SchoolClass> classes = currentTeacher.SchoolClasses;
                foreach (SchoolClass c in classes)
                {
                    if (c.Name == name)
                    {
                        return c;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Returns active teachers classes.
        /// </summary>
        /// <returns>active teachers classes.</returns>
        public List<SchoolClass> GetTeacherClasses()
        {
            if (this.appManager.ActiveUser != null)
            {
                Teacher currTeach = (Teacher)this.appManager.ActiveUser;
                return currTeach.SchoolClasses;
            }

            return null;
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