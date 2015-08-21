namespace Task01.StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Validator
    {
        public static bool CheckName(string value)
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                return false;
            }

            return true;
        }

        public static bool CheckStudentIDForRange(int value, int minRange, int maxRange)
        {
            if (value < minRange || value > maxRange)
            {
                return false;
            }

            return true;
        }

        public static bool CheckStudentIfNull(Student student)
        {
            if (student == null)
            {
                return false;
            }

            return true;
        }

        public static bool CheckCourseIfNull(Course course)
        {
            if (course == null)
            {
                return false;
            }

            return true;
        }

        public static bool CheckIfCourseContainsStudent(ICollection<Student> students, Student student)
        {
            if (students.Contains(student))
            {
                return true;
            }

            return false;
        }

        public static bool CheckIfSchoolContainsCourse(ICollection<Course> courses, Course course)
        {
            if (courses.Contains(course))
            {
                return true;
            }

            return false;
        }
    }
}
