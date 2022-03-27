using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.App05;
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
    /// Derek Peacock 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine( "----------------------------------------------");
            Console.WriteLine(" BNU CO453 Applications Programming 2021-2022 ");
            Console.WriteLine(" ----------------------------------------------");
            Console.WriteLine();

            string[] choices =
            {
                "App01 Distance Converter",
                "App02 BMI Calculator",
                "App03 Student Grades",
                "App04 Social Network",
                "App05 RPG Game"
            };

            Console.WriteLine("Please choose your App\n ");

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    DistanceConverter app01 = new DistanceConverter();
                    app01.Run();
                    break;

                case 2: break;

                case 3:
                    StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;
                case 4: break;

                case 5:
                    Game app05 = new Game();
                    app05.Run();break;

                default:
                    break;
            }


            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
