using System;

public class ExamResult
{
    private string comments;
    private int minGrade;
    private int maxGrade;
    private int grade;
    
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The grade should not be negative nummber");
            }

            this.grade = value;

        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The value for min Grade should not be negative");
            }
            this.minGrade = value;
        }
    }

    public int MaxGrade
	{
		get 
        { 
            return this.maxGrade; 
        }

		private set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("The value for max Grade should not be negative.");
			}
            if (value < this.minGrade)
            {
                throw new ArgumentOutOfRangeException("The value for max Grade should not be less than min value.");
            }

			this.maxGrade = value;
		}
	}

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (value == null)
            {
                throw new ArgumentNullException("The value for comment cannot be null");
            }

            if (value == "")
            {
                throw new ArgumentException("The value for comment cannot be empty");
            }

            this.comments = value;
        }
    }
}
