//============================================================================================\\
//===================================Assignment_09============================================\\
//============================================================================================\\

namespace Assignment_09;
using System;

static class Maths
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            System.Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }
}

class Assignment_09
{
    static void Main()
    {
        double num1 = 10;
        double num2 = 5;

        Console.WriteLine("Add: " + Maths.Add(num1, num2));
        Console.WriteLine("Subtract: " + Maths.Subtract(num1, num2));
        Console.WriteLine("Multiply: " + Maths.Multiply(num1, num2));
        Console.WriteLine("Divide: " + Maths.Divide(num1, num2));
    }
}
