namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        public const int MaxStudentsInCourse = 30;

        private string courseName;
        private ICollection<Student> students;

        public Course(string courseName)
        {
            this.CourseName = courseName;
            this.students = new List<Student>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (Validator.CheckName(value) == false)
                {
                    throw new ArgumentNullException("The name of the course should not be null or empty");
                }

                this.courseName = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (Validator.CheckStudentIfNull(student) == false)
            {
                throw new ArgumentNullException("The student to be added should not be null");
            }

            if (this.Students.Count + 1 > MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("No more students can be added to this course, it is already full");
            }

            if (Validator.CheckIfCourseContainsStudent(this.Students, student) == true)
            {
                throw new ArgumentException("This student already attends this course");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (Validator.CheckStudentIfNull(student) == false)
            {
                throw new ArgumentNullException("The student to be removed should not be null");
            }

            if (Validator.CheckIfCourseContainsStudent(this.Students, student) == false)
            {
                throw new ArgumentException("This student does not attend this course");
            }

            this.Students.Remove(student);
        }
    }
}