using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 14/12/2020 Version 2.0
    /// </summary>
    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine(" BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("----------------------------------------------\n");

            string[] choices = { "App01", "App02", "App03" };

            int choice = ConsoleHelper.SelectChoice(choices);

            switch(choice)
            {
                case 1: DistanceConverter app01 = new DistanceConverter();
                    app01.Run();break;

                case 2: BMI calculator = new BMI(); calculator.Run();
                    break;

                case 3: StudentGrades grades = new StudentGrades();
                    grades.Run();break;
            }
          
        }
    }
}
