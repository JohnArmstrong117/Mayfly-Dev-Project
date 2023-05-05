using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class designed to hold data for teachers.
    /// </summary>
    [Serializable]
    public class Teacher : User
    {
        private List<SchoolClass> schoolClasses;

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        public Teacher()
            : base()
        {
            this.schoolClasses = new List<SchoolClass>();
        }

        /// <summary>
        /// Gets a list of this teachers classes.
        /// </summary>
        public List<SchoolClass> SchoolClasses
        {
            get { return this.schoolClasses; }
        }

        /// <summary>
        /// Adds a class to the list.
        /// </summary>
        /// <param name="schoolClass">Class to add.</param>
        public override void AddClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Add(schoolClass);
        }
    }
}
