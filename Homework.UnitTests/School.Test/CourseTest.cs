using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseNameShouldReturnExpectedResult()
        {
            var course = new Course("HQC");

            Assert.AreEqual("HQC", course.CourseName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseNameShouldThrowErrorIfCourseNameIsNull()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseNameShouldThrowErrorIfCourseNameIsEmptyString()
        {
            var course = new Course("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseNameShouldThrowErrorIfStudentToBeAddedIsNull()
        {
            Student student = null;
            var course = new Course("HQC");
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseShoulThrowAnErrorIfContainsMoreStudentsThanAllowed()
        {
            var course = new Course("HQC");

            for (int i = 0; i < 50; i++)
            {
                var student = new Student(i.ToString(), 10000 + i);
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShoulThrowAnErrorIfStudentWhoIsInCourseAlreadyIsAdded()
        {
            var course = new Course("HQC");
            var student = new Student("Margarita Ivancheva", 12345);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        public void CourseShouldHaveTheExpectedNumberOfStudents()
        {
            var course = new Course("HQC");
            var student = new Student("Margarita Ivancheva", 12345);
            course.AddStudent(student);

            Assert.AreEqual(1, course.Students.Count);
        }
        [TestMethod]
        public void CourseShouldHaveTheExpectedNumberOfStudentsWhenRemoved()
        {
            var course = new Course("HQC");
            var student = new Student("Margarita Ivancheva", 12345);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(1, course.Students.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowAnErrorWhenNullStudentIsTriedToBeRemoved()
        {
            var course = new Course("HQC");
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowAnErrorWhenStudentWhoIsNotPartOfTheCourseIsTriedToBeRemoved()
        {
            var course = new Course("HQC");
            var student = new Student("Margarita Ivancheva", 12345);
            course.RemoveStudent(student);
        }
    }
}
