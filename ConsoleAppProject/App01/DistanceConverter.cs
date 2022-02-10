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

        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine("  " + miles + " miles is " + feet + " feet");
            Console.WriteLine();
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
            Console.WriteLine("           by Derek Peacock     ");
            Console.WriteLine("  ==============================");
        }
    }
}
