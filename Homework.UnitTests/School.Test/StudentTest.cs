using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentNameShouldReturnExpectedName()
        {
            var student = new Student("Margarita Ivancheva", 12345);

            Assert.AreEqual("Margarita Ivancheva", student.StudentName);
        }

        [TestMethod]
        public void StudentNameShouldReturnExpectedID()
        {
            var student = new Student("Margarita Ivancheva", 12345);

            Assert.AreEqual(12345, student.StudentID);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionIfStudentNameIsNull()
        {
            var student = new Student(null, 12345);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowNullReferenceExceptionIfStudentNameIsEmpty()
        {
            var student = new Student(string.Empty, 12345);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowOutOfRangeExceptionIfStudentIDIsOutOfRange()
        {
            var student = new Student("Margarita Ivancheva", 123);
        }

        [TestMethod]
        public void StudentAddedToCourseShouldHaveTheExpectedOutcome()
        {

            var course = new Course("HQC");
            var student = new Student("Margarita Ivancheva", 12345);
            student.JoinCourse(course);
        }

        [TestMethod]
        public void StudentRemovedFromCourseShouldNotThrowException()
        {
            var student = new Student("Margarita Ivancheva", 12345);
            var course = new Course("HQC");
            student.JoinCourse(course);
            student.LeaveCourse(course);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentAddedToCourseShouldThrowArgumentNullExceptionIfCourseIsNull()
        {
            var student = new Student("Margarita Ivancheva", 12345);
            Course course = null;
            student.JoinCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentRemovedFromCourseShouldThrowArgumentNullExceptionIfCourseIsNull()
        {
            var student = new Student("Margarita Ivancheva", 12345);
            Course course = null;
            student.LeaveCourse(course);
        }
    }
}
