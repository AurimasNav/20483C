using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradesPrototype;
using GradesPrototype.Data;

namespace GradesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            DataSource.CreateData();
        }

        [TestMethod]
        public void TestValidGrade()
        {
            Grade grade = new Grade(0, "2019-01-01", "Math", "A", "comment");
            Assert.AreEqual(grade.AssessmentDate, "2019-01-01");
            Assert.AreEqual(grade.SubjectName, "Math");
            Assert.AreEqual(grade.Assessment, "A");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadDate()
        {
            Grade grade = new Grade(0, "3000-01-01", "Math", "A", "nice nice!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateNotRecognized()
        {
            Grade grade = new Grade(0,"some invalid date", "Math", "A", "gutentaken");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadAssessment()
        {
            Grade grade = new Grade(0, "2019-01-01", "Math", "ketvirtukas", "komentaras");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBadSubject()
        {
            Grade grade = new Grade(0, "2019-01-01", "Dalykas", "A", "komentaras");
        }
    }
}
