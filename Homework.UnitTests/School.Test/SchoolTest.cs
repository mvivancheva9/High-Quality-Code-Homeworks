using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolNameShouldReturnExpectedResult()
        {
            var school = new School("Telerik Academy");

            Assert.AreEqual("Telerik Academy", school.SchoolName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameShouldThrowErrorIfIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameShouldThrowErrorIfIsEmptyString()
        {
            var school = new School("");
        }

        [TestMethod]
        public void SchoolNameShouldReturnExpectedResultWhenStudentIsAdded()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Margarita Ivancheva", 12345);
            school.AddStudent(student);
            Assert.AreEqual(1, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameShouldThrowErrorIfNullStudentIsAdded()
        {
            var school = new School("Telerik Academy");
            Student student = null;
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolNameShouldThrowErrorIfSameStudentIsAdded()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Margarita Ivancheva", 12345);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        public void SchoolNameShouldReturnExpectedResultWhenStudentIsremoved()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Margarita Ivancheva", 12345);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.AreEqual(0, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolNameShouldThrowErrorIfNullStudentIsRemoved()
        {
            var school = new School("Telerik Academy");
            Student student = null;
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolNameShouldThrowErrorIfStudentWhoIsNotPartOfTheSchoolIsRemoved()
        {
            var school = new School("Telerik Academy");
            var student = new Student("Margarita Ivancheva", 12345);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void SchoolShouldReturnExpectedResultWhenCourseIsAdded()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            Assert.AreEqual(1, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowErrorIfNullCourseIsAdded()
        {
            var school = new School("Telerik Academy");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowErrorIfSameCourseIsAdded()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void SchoolShouldReturnExpectedResultWhenCourseIsRemoved()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(0, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowErrorIfNullCourseIsRemoved()
        {
            var school = new School("Telerik Academy");
            Course course = null;
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowErrorIfCourseWhichIsNotPartOfTheSchoolIsRemoved()
        {
            var school = new School("Telerik Academy");
            var course = new Course("HQC");
            school.RemoveCourse(course);
        }

    }
}
