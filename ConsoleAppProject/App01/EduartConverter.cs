using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App01
{
    public class EduartConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        /// <summary>
        /// 
        /// </summary>
        public const string FEET = "FEET";
        public const string METRES = "METRES";
        public const string MILES = "MILES";

        /// <summary>
        /// 
        /// </summary>
        private double fromDistance;
        private double toDistance;

        /// <summary>
        /// 
        /// </summary>
        private string fromUnit;
        private string toUnit;

        public object Distance { get; private set; }


        /// <summary>
        ///
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();
            fromUnit = SelectUnit(" Please select the _from distance unit_ > ");
            toUnit = SelectUnit(" Please select the _to distance unit_ > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance = ConsoleHelper.InputNumber
                ($" Please enter the number of {fromUnit} > ");

            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }

            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// 
        /// </summary>
        private static string ExecuteChoice(string choice)
        {
            if (choice == ("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }

            else if (choice == ("3"))
            {
                return MILES;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }


        /// <summary>
        /// 
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" \n {fromDistance} {fromUnit}" +
                $" = {toDistance} {toUnit}\n");
        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        Distance Converter Created         ");
            Console.WriteLine("              By N.E.IONESCU               ");
            Console.WriteLine("=========================================\n");
            Console.WriteLine();
        }
    }
}
