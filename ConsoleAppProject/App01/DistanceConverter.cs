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
        public DistanceConverter()
        {

        }

        /// <summary>
        /// This method will run the distance converter
        /// </summary>
        public void Run()
        {
            OutputHeading();
        }

        private void OutputHeading()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("   App01 Distance Converter   ");
            Console.WriteLine("       by Derek Peacock       ");
            Console.WriteLine("==============================");
        }
    }
}
