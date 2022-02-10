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

        public DistanceConverter()
        {

        }

        /// <summary>
        /// This method will run the distance converter
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputMiles();
            ConvertMilesToFeet();
            OutputFeet();
        }

        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(" " + miles + " miles is " + feet + " feet");
            Console.WriteLine();
        }

        private void ConvertMilesToFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Prompt the user to enter a distance in miles as a double
        /// </summary>
        private void InputMiles()
        {
            Console.Write(" Please enter the distance in miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void OutputHeading()
        {
            Console.WriteLine(" ==============================");
            Console.WriteLine("    App01 Distance Converter   ");
            Console.WriteLine("        by Derek Peacock       ");
            Console.WriteLine(" ==============================");
        }
    }
}
