using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GradesTests
    {
        [TestMethod]
        public void TestConvertHighestFail()
        {
            // Arrange

            StudentGrades app03 = new StudentGrades();

            // Act

            Grades actualGrade = app03.ConvertToGrades(39);

            //

            Assert.AreEqual(actualGrade, Grades.F);
        }
    }
}