using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task01.StudentsAndCourses;

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
        public void StudentShouldThrowNullReferenceExceptionIfStudentNameIsNull()
        {
            var student = new Student(null, 12345);

        }

        [TestMethod]
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


    }
}
