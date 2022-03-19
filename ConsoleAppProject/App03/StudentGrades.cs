using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class just asks the user to enter a mark
    /// for each of the student names, and outputs
    /// those marks and the associated grades.
    /// </summary>
    public class StudentGrades
    {
        public const int MINIMUM_MARK = 0;
        public const int MAXIMUM_MARK = 100;

        public const int MINIMUM_D = 40;
        public const int MINIMUM_C = 50;
        public const int MINIMUM_B = 60;
        public const int MINIMUM_A = 40;
        
        // Student names
        public string [] Students { get; set; }
        // Student marks
        public int [] Marks { get; set; }

        public void Run()
        {
            Students = new string [] { "Veena", "Gita", "Sue"};
            Marks = new int[Students.Length];

            ConsoleHelper.OutputHeading("App03 Student Marks");

            InputMarks();
            OutputGrades();
        }

        private void InputMarks()
        {
            Console.WriteLine("Please enter a mark for each student\n");
            int index = 0;

            foreach(string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{name} enter mark > ", 0, 100);
                Marks[index] = mark;
            }
        }

        private void OutputGrades()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($"{Students[i]}  mark = {mark} Grade = {grade}" );
            }
        }

        public Grades ConvertToGrades(int mark)
        {
            if (mark >= 0 && mark < MINIMUM_D)
                return Grades.F;
            
            else if (mark >= MINIMUM_D && mark < MINIMUM_C)
                return Grades.D;

            else return Grades.X;
        }
    }
}
