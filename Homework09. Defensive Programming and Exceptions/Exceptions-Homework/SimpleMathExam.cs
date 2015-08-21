using System;

public class SimpleMathExam : Exam
{
    private const string InvalidResultsComment = "Invalid number of problems solved!";
    private const string GoodResultsComment = "Good result: almost everything's done correctly.";
    private const string AverageResultsComment = "Average result: almost nothing done.";
    private const string BadResultsComment = "Bad result: nothing done.";

    private int problemSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemSolved;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The value for problems solved should not be negative number");
            }

            if (value > 10)
            {
                throw new ArgumentOutOfRangeException("The value for problems solved should not be bigger than 10");
            }

            this.problemSolved = value;
        }
    }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0:
                return new ExamResult(2, 2, 6, BadResultsComment);
            case 1:
                return new ExamResult(4, 2, 6, AverageResultsComment);
            case 2:
                return new ExamResult(6, 2, 6, AverageResultsComment);
        }

        return new ExamResult(0, 0, 0, InvalidResultsComment);
    }
}
