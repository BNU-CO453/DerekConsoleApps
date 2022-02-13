﻿using System;

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

        private double miles;
        private double feet;

        /// <summary>
        /// This method will output a heading, ask  for the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();
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

        private void InputMiles()
        {
            Console.Write(" Please input the distance in miles > ");

            string number = Console.ReadLine();
            miles = Convert.ToDouble(number);
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        private void OutputFeet()
        {
            Console.WriteLine(" " + miles + " miles = " + feet + " feet!");
        }
    }
}
