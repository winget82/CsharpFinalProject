namespace CsharpFinalProject
{
    class Problem
    {
        private int number1;
        private int number2;
        private int answer;
        private int studentsAnswer;
        private bool studentAnsweredCorrect;

        public Problem(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            answer = number1 + number2;
        }

        public int StudentsAnswer { get => studentsAnswer; set => studentsAnswer = value; }
        public bool StudentAnsweredCorrect { get => studentAnsweredCorrect; set => studentAnsweredCorrect = value; }
        public int Number1 { get => number1; set => number1 = value; }
        public int Number2 { get => number2; set => number2 = value; }
        public int Answer { get => answer; set => answer = value; }
    }
}
