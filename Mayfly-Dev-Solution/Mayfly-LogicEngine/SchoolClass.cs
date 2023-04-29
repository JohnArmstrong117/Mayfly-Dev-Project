using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// class designed to store data for SchoolClasses.
    /// </summary>
    internal class SchoolClass
    {
        private List<Quiz> quizList;
        private string name;
        private List<User> students;
        private User teacher;

        /// <summary>
        /// Gets or Sets this Class' active teacher.
        /// </summary>
        public User Teacher
        {
            get { return this.teacher; }
            set { this.teacher = value; }
        }

        /// <summary>
        /// Gets the list of enrolled students.
        /// </summary>
        public List<User> Students
        {
            get { return this.students; }
        }

        /// <summary>
        /// Gets or Sets the Name of the class.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets a list of quizzes contained in this SchoolClass.
        /// </summary>
        public List<Quiz> QuizList
        {
            get { return this.quizList; }
        }
    }
}
