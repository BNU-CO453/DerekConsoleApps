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
        public Student [] Students { get; set; }

        public void Run()
        {
            Students = new Student [] 
            { 
                new Student {  Name = "Veena", Mark = 0},
                new Student {  Name = "Gita",  Mark = 30},
                new Student {  Name = "Divy",  Mark = 40}
            };

            ConsoleHelper.OutputHeading("App03 Student Marks");

            InputMarks();
            OutputGrades();
        }

        private void InputMarks()
        {
            Console.WriteLine("Please enter a mark for each student\n");
            int index = 0;

            foreach(Student student in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"{student.Name} enter mark > ", 0, 100);
                student.Mark = mark;
            }
        }

        private void OutputGrades()
        {
            foreach(Student student in Students)
            {
                Grades grade = ConvertToGrades(student.Mark);
                student.Grade = grade;

                Console.WriteLine($"{student.Name}  mark = {student.Mark} Grade = {grade}" );
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
