using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App01 here
    /// </summary>
    /// <author>
    /// Derek Peacock version 2.0
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;


        /// <summary>
        /// This method will output a heading, ask dfor the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select your from unit");
            toUnit = SelectUnit(" Please select your to unit");
            
            Console.WriteLine($" \n You are converting from {fromUnit} to {toUnit} \n");

            fromDistance = InputDistance($" Please enter the distance in {fromUnit} > ");

            ConvertDistance();

            OutputDistance();
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

        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance}  {toUnit}!");
        }

        private void ConvertDistance()
        {
            if(fromUnit == DistanceUnits.Miles && 
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

        private double InputDistance(string prompt)
        {
            Console.WriteLine();
            Console.Write(prompt);
            string number = Console.ReadLine();
            Console.WriteLine();

            return Convert.ToDouble(number);
        }

    }
}
