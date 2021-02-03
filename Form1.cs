using System;
using System.IO;
using System.Windows.Forms;

namespace CsharpFinalProject
{
    public partial class AdditionForm : Form
    {
        Student student;
        public AdditionForm()
        {
            InitializeComponent();
        }

        private void GetGradeBtn_Click(object sender, EventArgs e)
        {
            string letterGrd;

            //Check to make sure at least one question has been answered
            if (student.TotalProblemsAnswered > 0)
            {
                if (student.Grade >= 90)
                {
                    letterGrd = "A";
                }
                else if (student.Grade >= 80 && student.Grade < 90)
                {
                    letterGrd = "B";
                }
                else if (student.Grade >= 70 && student.Grade < 80)
                {
                    letterGrd = "C";
                }
                else if (student.Grade >= 60 && student.Grade < 70)
                {
                    letterGrd = "D";
                }
                else
                {
                    letterGrd = "F";
                }

                UpdateMessageLbl("You got " + String.Format("{0:0.##}", student.Grade)
                    + "% " + letterGrd + ". See .csv file.");

                ExportToCSV();
            }
        }

        private void EnterNameBtn_Click(object sender, EventArgs e)
        {
            //Populate the student object names and then hide name buttons
            //Allow numbers and symbols, you never know these days
            student = new Student();

            if (firstNameTB.Text != "" && lastNameTB.Text != "")
            {
                student.FirstName = firstNameTB.Text.Trim();
                student.LastName = lastNameTB.Text.Trim();
                BeginProblemSolvingMode();
                problemResultTB.Focus();
                UpdateMessageLbl("Welcome, " + student.FirstName + " " + student.LastName + "!");
                msgLbl.Visible = true;
            }
            else
            {
                UpdateMessageLbl("Please enter both a first and last name!");
            }
        }
        
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            //Make sure a number is entered and no text and also not empty/null
            int x; bool ok = int.TryParse(problemResultTB.Text, out x);

            if (ok)
            {
                msgLbl.Visible = false;

                //Add the student answer to the problem object
                student.ProblemSet[student.CurrentProblem].StudentsAnswer = int.Parse(problemResultTB.Text);

                //Add one to student total problems answered
                student.TotalProblemsAnswered++;

                //Check answer
                CheckAnswer(student);

                //Add one to current problem index
                student.CurrentProblem++;

                //Generate next problem
                GenerateNextProblem();
            }
            else
            {
                //Error message
                UpdateMessageLbl("Please enter a valid integer number");
                msgLbl.Visible = true;
            }
        }

        private void CheckAnswer(Student student)
        {
            //Check to verify answer is correct.
            if (student.ProblemSet[student.CurrentProblem].StudentsAnswer == student.ProblemSet[student.CurrentProblem].Answer)
            {
                student.ProblemSet[student.CurrentProblem].StudentAnsweredCorrect = true;
                //If correct add a 1 to student answersCorrect.
                student.AnswersCorrect++;
                UpdateMessageLbl("Correct!");
            }
            //If wrong update property and show correct answer
            else
            {
                student.ProblemSet[student.CurrentProblem].StudentAnsweredCorrect = false;
                UpdateMessageLbl(student.ProblemSet[student.CurrentProblem].StudentsAnswer +
                    " is inccorrect.  The correct answer is: " +
                    student.ProblemSet[student.CurrentProblem].Number1 +
                    " + " + student.ProblemSet[student.CurrentProblem].Number2 +
                    " = " + student.ProblemSet[student.CurrentProblem].Answer);
            }
            UpdateStatusLbl();
        }

        private void UpdateStatusLbl()
        {
            int total = student.CurrentProblem + 1;

            //Update the status label to show correct / total problems so far
            statusLbl.Text = "You have " + student.AnswersCorrect + " out of " + total.ToString() + " correct.";
        }

        private void UpdateMessageLbl(string msgLblText)
        {
            //Populate the text in the message label
            msgLbl.Text = msgLblText;
            msgLbl.Visible = true;
        }

        private void UpdateProblemNoLbl(int pronmbr)
        {
            //Update to current problem
            probNoLbl.Text = "Problem No. " + pronmbr;
        }

        private void BeginEnterNameMode()
        {
            ClearNameTBs();
            ShowStuff(false, true);
        }

        private void BeginProblemSolvingMode()
        {
            ClearProblemTBs();
            GenerateNextProblem();
            ShowStuff(true, false);
        }

        private void ExportToCSV()
        {
            //Write Full Name, Grade percentage to file
            string str, headerstr, problemstr;

            str = student.FirstName + " " + student.LastName + "," + student.Grade.ToString();
            headerstr = "Problem Number, Number1, Number2, Correct Answer, Student Answer";
            problemstr = "";
            int index = 1;
            StreamWriter sw;
            sw = new StreamWriter("c:/tempOut/CSharpFinal_Results.csv");
            sw.WriteLine(str);
            sw.WriteLine(headerstr);

            //Could also add list of problems with correct answer versus student answer
            foreach (Problem problem in student.ProblemSet)
            {
                if (index <= student.TotalProblemsAnswered)
                {
                    problemstr = index + "," + problem.Number1 + "," + problem.Number2
                    + "," + problem.Answer + "," + problem.StudentsAnswer;
                    sw.WriteLine(problemstr);
                    index++;
                }
            }

            sw.Close();
        }

        private void GenerateNextProblem()
        {
            int num1, num2;

            problemResultTB.Clear();

            //Generate the next problem using two random numbers
            Random random = new Random();
            num1 = random.Next(1, 10);
            num2 = random.Next(1, 10);
            Problem problem = new Problem(num1, num2);

            problemTB1.Text = problem.Number1.ToString();
            problemTB2.Text = problem.Number2.ToString();

            UpdateProblemNoLbl(student.TotalProblemsAnswered + 1);

            //Add the problem to the student problemset Array List
            student.ProblemSet.Add(problem);
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            //Hide the problem buttons and show the name buttons
            msgLbl.Visible = false;
            ClearLbls();
            BeginEnterNameMode();
        }

        private void ClearProblemTBs()
        {
            problemTB1.Clear();
            problemTB2.Clear();
            problemResultTB.Clear();
        }

        private void ClearNameTBs()
        {
            firstNameTB.Clear();
            lastNameTB.Clear();
        }

        private void ClearLbls()
        {
            msgLbl.Text = "";
            statusLbl.Text = "";
        }

        private void ShowStuff(bool problem, bool name)
        {
            //Show/hide Name buttons, textboxes, and labels
            firstNameLbl.Visible = name;
            firstNameTB.Visible = name;
            lastNameLbl.Visible = name;
            lastNameTB.Visible = name;
            topLbl.Visible = name;
            enterNameBtn.Visible = name;

            //Show/hide Problem buttons, textboxes, and labels and Restart button
            probNoLbl.Visible = problem;
            problemTB1.Visible = problem;
            problemTB2.Visible = problem;
            problemResultTB.Visible = problem;
            signLbl.Visible = problem;
            equalsLbl.Visible = problem;
            acceptBtn.Visible = problem;
            getGradeBtn.Visible = problem;
            statusLbl.Visible = problem;
            restartBtn.Visible = problem;
        }

        private void problemResultTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AcceptBtn_Click(sender, e);
        }

        private void lastNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterNameBtn_Click(sender, e);
        }

        private void firstNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterNameBtn_Click(sender, e);
        }
    }
}

/*
TESTING PROGRAM FOR ADDING NUMBERS
- CLASS DEFINED AS STUDENT
- PROGRAM WILL ASK USERS NAME AND CREATE AND INSTANCE OF STUDENT
- WITHIN THE STUDENT CLASS, YOU WILL KEEP TRACK OF THE PERCENTAGE (5 RIGHT OUT OF THE 10, THEN PERCENTAGE WILL BE 50%)
- AT THE END, WRITE IT OUT TO A FILE
"JOE BOB, 80"
CSV FILE
TEXTBOX: 3 + 5 = ?
TEXTBOX: 8
PROGRAM WILL CHECK TO SEE IF IT IS RIGHT

Use random numbers
*/