using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class designed to store quiz data.
    /// </summary>
    internal class Quiz
    {
        private List<Question> questions;
        private string quizName;
        private Dictionary<User, int> studentCorrectNumbers;

        /// <summary>
        /// Gets a dictionary of Users as Keys and Ints representing the number of correct answers the user recieved.
        /// </summary>
        public Dictionary<User, int> StudentCorrectNumbers
        {
            get { return this.studentCorrectNumbers; }
        }

        /// <summary>
        /// Gets or Sets the name of the quiz.
        /// </summary>
        public string QuizName
        {
            get { return this.quizName; }
            set { this.quizName = value; }
        }

        /// <summary>
        /// Gets the list of questions in the quiz.
        /// </summary>
        public List<Question> Questions
        {
            get { return this.questions; }
        }
    }
}
