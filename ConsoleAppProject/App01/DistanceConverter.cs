using ConsoleAppProject.Helpers;
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
            ConsoleHelper.OutputHeading("App01 Distance Converter");

            fromUnit = SelectUnit(" Please select your from unit");
            toUnit = SelectUnit(" Please select your to unit");

            Console.WriteLine($" \n You are converting from {fromUnit} to {toUnit} \n");

            fromDistance = ConsoleHelper.InputNumber($" Please input the distance in {fromUnit} > ");

            ConvertDistance();

            OutputDistance();
        }



        private DistanceUnits SelectUnit(string prompt)
        {
            string[] choices =
                {
                    $" 1. {DistanceUnits.Miles}",
                    $" 2. {DistanceUnits.Feet}",
                    $" 3. {DistanceUnits.Metres}"
                };

            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            return ExecuteChoice(choice);
        }

        private static DistanceUnits ExecuteChoice(int choice)
        {
            switch(choice)
            {
                case 1: return DistanceUnits.Miles;break;
                case 2: return DistanceUnits.Feet; break;
                case 3: return DistanceUnits.Metres;break;

                default: return DistanceUnits.NoUnit;
            }
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
    }
}
