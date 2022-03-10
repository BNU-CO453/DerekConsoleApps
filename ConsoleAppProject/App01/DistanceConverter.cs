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

        private double toDistance;
        private double fromDistance;

<<<<<<< Updated upstream
        private String toUnit;
        private String fromUnit;
=======
        public DistanceUnits fromUnit; //{ get; set; }
    public DistanceUnits toUnit; //{ get; set; }
>>>>>>> Stashed changes

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
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");
            
            toUnit = Console.ReadLine();
        }
        private void InputFromUnit()
        {
            Console.WriteLine("Enter the fromUnit: ");
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");
            
            fromUnit = Console.ReadLine();
        }

        private void InputFromDistance()
        {
            Console.Write(" Please enter the distance in " + fromUnit + " > ");
            String value = Console.ReadLine();
            fromDistance = Convert.ToDouble(value);
        }

        private void Output()
        {
            Console.WriteLine(fromDistance + " " + fromUnit + " is " + toDistance.ToString("0.0000") + " " + toUnit);
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

        private void CalcuateToDistance()
        {
            if(fromUnit.Contains("Miles",StringComparison.CurrentCultureIgnoreCase) 
                    && toUnit.Contains("Feet"))
                    {
                        toDistance = fromDistance * 5280;
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
