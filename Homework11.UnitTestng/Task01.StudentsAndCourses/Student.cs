namespace Task01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private const int MinStudentIDRange = 10000;
        private const int MaxSidentIDInRange = 99999;

        private string studentName;
        private int studentID;

        public Student(string studentName, int studentID)
        {
            this.StudentName = studentName;
            this.StudentID = studentID;
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }

            set
            {
                if (Validator.CheckName(value) == false)
                {
                    throw new ArgumentNullException("The name of the student should not be null or empty");
                }

                this.studentName = value;
            }
        }

        public int StudentID
        {
            get
            {
                return this.studentID;
            }

            set
            {
                if (Validator.CheckStudentIDForRange(value, MinStudentIDRange, MaxSidentIDInRange) == false)
                {
                    throw new ArgumentOutOfRangeException("The id of the student should be in the range [10000..99999]");
                }

                this.studentID = value;
            }
        }


        public void JoinCourse(Course course)
        {
            if (Validator.CheckCourseIfNull(course))
            {
                throw new ArgumentNullException("The course for adding a student should not be null");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (Validator.CheckCourseIfNull(course))
            {
                throw new ArgumentNullException("The course for removing a student should not be null");
            }

            course.RemoveStudent(this);
        }
    }
}
