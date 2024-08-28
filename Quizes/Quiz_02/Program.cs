using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Quiz_02;

class Program
{
    static void Main(string[] args)
    {
        Subject Sub1 = new Subject(10, "C#");
        Sub1.CreateExam();
        Console.Clear();
        Console.Write("Do You Want To Start The Exam (y | n): ");

        if (Char.Parse(Console.ReadLine()) == 'y')
        {
            Stopwatch SW = new Stopwatch();
            SW.Start();
            int score = Sub1.TakeExam();
            SW.Stop();
            Console.WriteLine($"Your score is: {score}");
            Console.WriteLine($"The Time you take is: {SW.Elapsed}");
            Console.WriteLine();

            Sub1.ShowExam();
        }
    }
}
