using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppTest
{
    [TestClass]
    public class App01Test
    {
        DistanceConverter distanceConverter = new DistanceConverter();  
        [TestMethod]
        public void TestFeetToMiles()
        {
            distanceConverter.InitialiseUnitArray();

            distanceConverter.fromUnit = DistanceUnits.Miles;
            distanceConverter.toUnit = DistanceUnits.Feet;

            distanceConverter.fromDistance = 100;

            distanceConverter.Calculate();

            Assert.AreEqual(528000, distanceConverter.toDistance);

        }
    }
}