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

        // Using Strings for units

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        // Using Enumeration for units

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        private double toDistance;
        private double fromDistance;

        /// <summary>
        /// This method will output a heading, ask  for the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// 
        /// Derek Peacock Version 2.0
        /// </summary>
        public void Run()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select your from unit");
            toUnit = SelectUnit(" Please select your to unit");

            Console.WriteLine($" \n You are converting from {fromUnit} to {toUnit} \n");

            fromDistance = InputDistance(fromUnit);

            ConvertDistance();

            OutputDistance();
        }

        private double InputDistance(DistanceUnits unit)
        {
            Console.WriteLine();
            Console.Write($" Please input the distance in {unit} > ");

            string number = Console.ReadLine();
            return Convert.ToDouble(number);
        }

        private double InputDistance(string unit)
        {
            Console.WriteLine();
            Console.Write($" Please input the distance in {unit} > ");

            string number = Console.ReadLine();
            return Convert.ToDouble(number);
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
    }
}
