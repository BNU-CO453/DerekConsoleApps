using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Student Names
        public string [] Students { get; set; }

        // Student Marks
        public int [] Marks { get; set; } = new int [10];


        public void Run()
        {
            Students = new string[]
            {
                "Gita",
                "Veena",
                "Divy"
            };

            InputMarks();
            OutputMarks();
        }
        private void InputMarks()
        {
            Console.WriteLine(" Entering Marks\n");

            int index = 0;

            foreach(var student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber(
                    $" Enter a mark for {student} > ", 0, 100);

                Marks[index] = mark;
                index++;
            };

            Console.WriteLine();
        }

        private Grades ConvertToGrade(int mark)
        {
            return Grades.X;
        }

        private void OutputMarks()
        {
            for(int i = 0; i < 3; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);

                Console.WriteLine($"{Students[i]} Mark = {mark} Grade = {grade}");
            }
        }
    }
}
