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
    public class Quiz
    {
        private List<Question> questions;
        private string quizName;
        private Dictionary<User, int> studentCorrectNumbers;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quiz"/> class.
        /// </summary>
        /// <param name="name">String containing the name for the quiz.</param>
        /// <param name="studentList">List of students whome should take this quiz.</param>
        public Quiz(string name, List<User> studentList)
        {
            this.questions = new List<Question>();
            this.quizName = name;
            this.studentCorrectNumbers = new Dictionary<User, int>();
            foreach (User user in studentList)
            {
                this.studentCorrectNumbers[user] = 0;
            }
        }

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

        /// <summary>
        /// Adds a question to the quiz.
        /// </summary>
        /// <param name="question">Question object to be added.</param>
        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }

        /// <summary>
        /// Removes the question at the given index in the list.
        /// </summary>
        /// <param name="questionIndex">Index of question to remove.</param>
        public void RemoveQuestion(int questionIndex)
        {
            this.questions.Remove(this.questions[questionIndex]);
        }

        /// <summary>
        /// Gets the number of correct answers from the given student.
        /// </summary>
        /// <param name="user">student to check number of correct responses.</param>
        /// <returns>returns number of students correct answers.</returns>
        public int GetStudentCorrectNumber(User user)
        {
            return this.studentCorrectNumbers[user];
        }
    }
}
