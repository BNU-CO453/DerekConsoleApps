using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppUnitTest
{
    [TestClass]
    public class UnitTestApp01
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceUnits.Miles;
            converter.toUnit = DistanceUnits.Feet;

            converter.fromDistance = 10;

            converter.CalcuateToDistance();

            Assert.AreEqual(52800, converter.toDistance);

        }
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceUnits.Feet;
            converter.toUnit = DistanceUnits.Miles;

            converter.fromDistance = 5281;

            converter.CalcuateToDistance();

            Assert.AreEqual(1, (int)converter.toDistance);
        }
    }
}
