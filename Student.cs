using System;
using System.Collections.Generic;

namespace CsharpFinalProject
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int answersCorrect;
        private int totalProblemsAnswered = 0;
        private int currentProblem = 0;
        private List<Problem> problemSet = new List<Problem>();

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int AnswersCorrect { get => answersCorrect; set => answersCorrect = value; }
        public int TotalProblemsAnswered { get => totalProblemsAnswered; set => totalProblemsAnswered = value; }
        public int CurrentProblem { get => currentProblem; set => currentProblem = value; }
        internal List<Problem> ProblemSet { get => problemSet; set => problemSet = value; }
        public double Grade
        {
            get { return (Convert.ToDouble(AnswersCorrect) / Convert.ToDouble(TotalProblemsAnswered)) * 100; }
        }
    }
}
