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
    internal class Teacher : User
    {
        private List<SchoolClass> schoolClasses;

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="newPass"></param>
        /// <param name="newUID"></param>
        public Teacher(string newName, string newPass, string newUID) 
            : base(newName, newPass, newUID)
        {
            // TODO: Implement Constructor.
        }

        /// <summary>
        /// Gets a list of this teachers classes.
        /// </summary>
        public List<SchoolClass> SchoolClasses
        {
            get { return this.SchoolClasses; }
        }
    }
}
