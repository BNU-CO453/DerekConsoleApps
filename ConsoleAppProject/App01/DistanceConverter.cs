using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 1.0
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1602.34;
        
        private double toDistance;
        private double fromDistance;

        /// <summary>
        /// This method will output a heading, ask  for the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            
            ConvertFeetToMiles();
            ConvertMilesToFeet();
        }

        public void ConvertFeetToMiles()
        {
            fromDistance = InputDistance(DistanceUnits.Feet);
        }

        public void ConvertMilesToFeet()
        {
            fromDistance = InputDistance(DistanceUnits.Miles);
        }
        private static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ==============================");
            Console.WriteLine("    App01 Distance Converter   ");
            Console.WriteLine("            by Derek           ");
            Console.WriteLine(" ==============================");
            Console.WriteLine();
        }

        private double InputDistance(DistanceUnits unit)
        {
            Console.WriteLine();
            Console.Write($" Please input the distance in {unit} > ");

            string number = Console.ReadLine();
            return Convert.ToDouble(number);            
        }
        
        private void CalculateFeet()
        {
            //feet = miles * FEET_IN_MILES;
        }

        private void OutputDistance()
        {
           // Console.WriteLine(" " + miles + " miles = " + feet + " feet!");
        }
    }
}
