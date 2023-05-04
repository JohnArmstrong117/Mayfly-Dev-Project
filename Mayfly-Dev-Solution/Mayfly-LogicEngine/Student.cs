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
    public class Student : User
    {
        private List<SchoolClass> classes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
            : base()
        {
            this.classes = new List<SchoolClass>();
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
