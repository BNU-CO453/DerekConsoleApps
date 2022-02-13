﻿using ConsoleAppProject.App01;
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

            DistanceConverter app01 = new DistanceConverter();
            app01.Run();

            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
