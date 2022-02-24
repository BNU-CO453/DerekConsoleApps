﻿using System;
using ConsoleAppProject.Helpers;

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
        private const int METERS_AND_

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        private double fromDistance;
        private double toDistance;

        private const int MAX_UNITS = 3;

        private string[] units = new string[MAX_UNITS];

        private const string FEET = "FEET";
        private const string MILES = "MILES";
        private const string METERS = "METERS";

        private void InitialiseUnitArray()
        {
            units[0] = FEET;
            units[1] = MILES;
            units[2] = METERS;
        }

        public void Run()
        {
            OutputHeading();

            InitialiseUnitArray();
            fromUnit = Input("FROM");
            toUnit = Input("TO");

            InputFromDistance();

            Calculate();

            Output();

        }

        private DistanceUnits Input(string unit)
        {
            Console.WriteLine("Please choose one of the following units to convert " + unit);
            int option = ConsoleHelper.SelectChoice(units);

            if (option == 1)
                return DistanceUnits.Feet;
            else if (option == 2)
                return DistanceUnits.Miles;
            else 
                return DistanceUnits.Metres;
        }

        private void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + fromUnit);
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }



        private void Calculate()
        {
            if(fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * 5280;
            }
        }


        /// <summary>
        /// Output a message to the user to enter the miles
        /// and then read it in as a string and convert it tp a double
        /// </summary>


        private void Output()
        {
            Console.WriteLine(fromDistance + " " + fromUnit.ToString() + " is " + toDistance + " " + toUnit.ToString()); ;
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
