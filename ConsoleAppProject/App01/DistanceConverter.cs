using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek Peacock version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        private string fromUnit;
        private string toUnit;

        private double fromDistance;
        private double toDistance;

        public void Run()
        {
            OutputHeading();

            InputFromUnit();
            InputToUnit();

            Console.WriteLine("fromUnit is " + fromUnit);
            Console.WriteLine("toUnit is " + toUnit);

            //InputMiles();
            //CalculateFeet();
            //OutputFeet();
        }

        private void InputFromUnit()
        {
            Console.WriteLine("Please choose one of the following units to convert FROM: ");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
            fromUnit = Console.ReadLine();
        }

        private void InputToUnit()
        {
            Console.WriteLine("Please choose one of the following units to convert TO: ");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine("3. Meters");
            toUnit = Console.ReadLine();
        }

        private void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + fromUnit);
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }


        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine("  " + miles + " miles is " + feet + " feet");
            Console.WriteLine();
        }

        private void Calculate()
        {

        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Output a message to the user to enter the miles
        /// and then read it in as a string and convert it tp a double
        /// </summary>
        private void InputMiles()
        {
            Console.WriteLine();
            Console.Write("  Please enter your distance as miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutputHeading()
        {
            Console.WriteLine("  ==============================");
            Console.WriteLine("      App01: Distance Converter ");
            Console.WriteLine("           by Nick Day     ");
            Console.WriteLine("  ==============================");
        }
    }
}
