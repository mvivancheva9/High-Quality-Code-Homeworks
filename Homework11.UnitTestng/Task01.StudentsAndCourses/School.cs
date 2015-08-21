namespace Task01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private string schoolName;
        private ICollection<Course> courses;
        private ICollection<Student> students;

        public School(string schoolName, List<Course> courses, List<Student> student)
        {
            this.SchoolName = schoolName;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string SchoolName
        {
            get
            {
                return this.schoolName;
            }

            set
            {
                if (Validator.CheckName(value) == false)
                {
                    throw new ArgumentNullException("The name of the school should not be null or empty");
                }

                this.schoolName = value;
            }
        }

        public ICollection<Course> Courses
        {
            get 
            {
                return new List<Course>(this.courses); 
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

            if (Validator.CheckIfCourseContainsStudent(this.Students, student) == true)
            {
                throw new ArgumentException("This student already attends this course");
            }

            this.Students.Add(student);
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

        public void AddCourse(Course course)
        {
            if (Validator.CheckCourseIfNull(course) == false)
            {
                throw new ArgumentNullException("The course to be added should not be null");
            }

            if (Validator.CheckIfSchoolContainsCourse(this.Courses, course) == true)
            {
                throw new ArgumentException("This course is already part of the school program");
            }

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (Validator.CheckCourseIfNull(course) == false)
            {
                throw new ArgumentNullException("The course to be removed should not be null");
            }

            if (Validator.CheckIfSchoolContainsCourse(this.Courses, course) == false)
            {
                throw new ArgumentException("TThis course is not part of the school program");
            }

            this.Courses.Remove(course);
        }
    }
}
