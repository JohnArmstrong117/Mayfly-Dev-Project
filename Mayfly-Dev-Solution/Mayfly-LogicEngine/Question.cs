namespace Mayfly_LogicEngine
{
    /// <summary>
    /// Class designed to store question data.
    /// </summary>
    public class Question
    {
        private string questionText;
        private string[] answersText = new string[4];
        private int correctIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class.
        /// </summary>
        /// <param name="quest">String containing question text.</param>
        /// <param name="ans">Array (length 4) of strings containing answer text.</param>
        /// <param name="ind">Integer index of correct answer in Answer text array.</param>
        public Question()
        {
            this.questionText = string.Empty;
            this.correctIndex = -1;
        }

        /// <summary>
        /// Gets or Sets the correct index for the questions answer.
        /// </summary>
        public int CorrectIndex
        {
            get { return this.correctIndex; }
            set { this.correctIndex = value; }
        }

        /// <summary>
        /// Gets or Sets an array of strings containing the answers to the question.
        /// </summary>
        public string[] AnswerText
        {
            get { return this.answersText; }
            set { this.answersText = value; }
        }

        /// <summary>
        /// Gets or Sets the questions text.
        /// </summary>
        public string QuestionText
        {
            get { return this.questionText; }
            set { this.questionText = value; }
        }

        /// <summary>
        /// Checks to see if the answered index is the correct index.
        /// </summary>
        /// <param name="answedIndex">Index number of the answer selected.</param>
        /// <returns>True if answered index is correct index.</returns>
        public bool IsCorrectAnswer(int answedIndex)
        {
            return this.correctIndex == answedIndex;
        }
    }
}