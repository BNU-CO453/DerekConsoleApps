using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App here!
    /// </summary>
    /// <author>
    /// Derek version 2.0
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
        /// the choice of from unit, then ask for the choice
        /// of to unit then input the from distance 
        /// calculate and output the to distance
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

        private DistanceUnits SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine();

            Console.WriteLine($" 1. {DistanceUnits.Miles}");
            Console.WriteLine($" 2. {DistanceUnits.Feet}");
            Console.WriteLine($" 3. {DistanceUnits.Metres}");

            Console.WriteLine();
            Console.Write(" Please enter coice > ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                return DistanceUnits.Miles;
            }
            else if (choice == "2")
            {
                return DistanceUnits.Feet;
            }
            else if (choice == "3")
            {
                return DistanceUnits.Metres;
            }
            else return DistanceUnits.NoUnit;
        }

        private void OutputDistance()
        {
            Console.WriteLine();
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance}  {toUnit}!");
            Console.WriteLine();
        }

        private void ConvertDistance()
        {
            if (fromUnit == DistanceUnits.Miles &&
                  toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                       toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres &&
                       toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
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
