using System;
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
        private const int METERS_AND_FEET = 5280;
        private const double MILES_AND_METRES = 1609.34;
        private const double FEET_AND_METRES = 3.280839895;


        public DistanceUnits fromUnit { get; set; }
        public DistanceUnits toUnit { get; set; }

        public double fromDistance { get; set; }
        public double toDistance { get; set; }

        private const int MAX_UNITS = 3;

        private string[] units = new string[MAX_UNITS];

        public void InitialiseUnitArray()
        {
            units[0] = DistanceUnits.Feet.ToString();
            units[1] = DistanceUnits.Miles.ToString();
            units[2] = DistanceUnits.Metres.ToString();
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

        public DistanceUnits Input(string unit)
        {
            Console.WriteLine("Please choose one of the following units to convert " + unit);
            int option = ConsoleHelper.SelectChoice(units);

            if (option == 1)
                return DistanceUnits.Feet;
            else if (option == 2)
                return DistanceUnits.Miles;
            else if (option == 3)
                return DistanceUnits.Metres;
            else
                return DistanceUnits.NoUnit;
        }

        public void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + fromUnit);
            fromDistance = Convert.ToDouble(Console.ReadLine());
        }



        public void Calculate()
        {
            if(fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * METERS_AND_FEET;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METERS_AND_FEET;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * MILES_AND_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / MILES_AND_METRES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / FEET_AND_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_AND_METRES;
            }
        }


        /// <summary>
        /// Output a message to the user to enter the miles
        /// and then read it in as a string and convert it tp a double
        /// </summary>


        public void Output()
        {
            Console.WriteLine(fromDistance + " " + fromUnit.ToString() + " is " 
                + toDistance.ToString("0.00") + " " + toUnit.ToString());
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
