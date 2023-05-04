using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class for storing student data.
    /// </summary>
    [Serializable]
    internal class Student : User
    {
        private List<SchoolClass> classes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="newPass"></param>
        /// <param name="newUID"></param>
        public Student(string newName, string newPass, string newUID)
            : base(newName, newPass, newUID)
        {
            // TODO: IMplement constructor.
        }

        /// <summary>
        /// Gets a list of this students classes.
        /// </summary>
        public List<SchoolClass> Classes
        {
            get { return this.classes; }
        }
    }
}
