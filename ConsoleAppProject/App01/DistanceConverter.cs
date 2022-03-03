using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Nick Day version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        
        private double feet;

        public double toDistance;
        public double fromDistance;

        public DistanceUnits toUnit;
        public DistanceUnits fromUnit;

        public DistanceConverter()
        {
            miles = 0;
            feet = 0;
        }

        /// <summary>
        /// This method will run the distance converter
        /// </summary>
        public void Run()
        {
            OutputHeading();

            InputFromUnit();
            InputToUnit();

            Console.WriteLine("To unit is : " + toUnit);
            Console.WriteLine("From unit is : " + fromUnit);

            InputFromDistance();
            CalcuateToDistance();

            Output();

            //InputMiles();
            //ConvertMilesToFeet();
            //OutputFeet();
        }

        private void InputToUnit()
        {
            Console.WriteLine("Enter the toUnit: ");
            Console.WriteLine("1. " + DistanceUnits.Feet.ToString());
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");
            
            int choice = Convert.ToInt16(Console.ReadLine());
            switch(choice)
            {
                case 1 : toUnit = DistanceUnits.Feet; break;
                case 2: toUnit = DistanceUnits.Metres; break;
                case 3: toUnit = DistanceUnits.Miles; break;
                default : toUnit = DistanceUnits.NoUnit; break;
            }
        }
        private void InputFromUnit()
        {
            Console.WriteLine("1. " + DistanceUnits.Feet.ToString());
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");

            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1: toUnit = DistanceUnits.Feet; break;
                case 2: toUnit = DistanceUnits.Metres; break;
                case 3: toUnit = DistanceUnits.Miles; break;
                default: toUnit = DistanceUnits.NoUnit; break;
            }
        }

        private void InputFromDistance()
        {
            Console.Write(" Please enter the distance in " + fromUnit + " > ");
            String value = Console.ReadLine();
            fromDistance = Convert.ToDouble(value);
        }

        private void Output()
        {
            Console.WriteLine(fromDistance + " " + fromUnit.ToString() + " is " + toDistance.ToString("0.0000") + " " + toUnit.ToString()) ;
        }
        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(" " + miles + " miles is " + feet + " feet");
            Console.WriteLine();
        }
        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine(" " + feet + " feet is " + miles + " miles");
            Console.WriteLine();
        }

        private void ConvertMilesToFeet()
        {
            feet = miles * 5280;
        }

        public void CalcuateToDistance()
        {
            if(fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * 5280;
            }
            if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / 5280;
            }
        }

        /// <summary>
        /// Prompt the user to enter a distance in miles as a double
        /// </summary>
        private void InputMiles()
        {
            Console.Write(" Please enter the distance in miles > ");
            String value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void InputFeet()
        {
            Console.Write(" Please enter the distance in feet > ");
            String value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }


        private void OutputHeading()
        {
            Console.WriteLine(" ==============================");
            Console.WriteLine("    App01 Distance Converter   ");
            Console.WriteLine("        by Nick Day       ");
            Console.WriteLine(" ==============================");
        }
    }
}
