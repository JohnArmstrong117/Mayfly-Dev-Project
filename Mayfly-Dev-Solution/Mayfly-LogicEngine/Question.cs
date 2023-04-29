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
        /// <param name="ans">Array of strings containing answer text.</param>
        /// <param name="ind">Integer index of correct answer in Answer text array.</param>
        public Question(string quest, string[] ans, int ind)
        {
            this.questionText = quest;
            this.correctIndex = ind;
            Array.Copy(ans, this.answersText, 4);
        }

        /// <summary>
        /// Gets the correct index for the questions answer.
        /// </summary>
        public int CorrectIndex
        {
            get { return this.correctIndex; }
        }

        /// <summary>
        /// Gets an array of strings containing the answers to the question.
        /// </summary>
        public string[] AnswerText
        {
            get { return this.answersText; }
        }

        /// <summary>
        /// Gets or Sets the questions text.
        /// </summary>
        public string QuestionText
        {
            get { return this.questionText; }
            set { this.questionText = value; }
        }
    }
}