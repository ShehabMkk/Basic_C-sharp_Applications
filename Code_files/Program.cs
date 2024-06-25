//============================================================================================\\
//===================================Assignment_02============================================\\
//============================================================================================\\

namespace Assignment_02;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // Task7();
        // Task8();
        // Task9();
        // Task10();
        // Task11();
        // Task12();
        // Task13();
        // Task14();
        // Task15();
        // Task16();
        // Task17();
        // Task18();
    }
    
    // 1- Write a program that takes a number from the user then print yes if 
    // that number can be divided by 3 and 4 otherwise print no.
    
    #region Task 1
    
    static void Task1()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 3 == 0 && num % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    #endregion
//============================================================================================\\

    // 2- Write a program that allows the user to insert an integer then print 
    //     negative if it is negative number otherwise print positive.
    
    #region Task 2

    static void Task2()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("positive");
    }

    #endregion
//============================================================================================\\

    // 3- Write a program that takes 3 integers from the user then prints the max 
    // element and the min element.
    
    #region Task 3

    static void Task3()
    {
        Console.WriteLine("Enter three integers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int max = Math.Max(num1, Math.Max(num2, num3));
        int min = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine($"max element = {max}");
        Console.WriteLine($"min element = {min}");
    }

    #endregion
//============================================================================================\\

    // 4- Write a program that allows the user to insert an integer number then 
    //     check If a number is even or odd.
    
    #region Task 4

    static void Task4()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine("even");
        else
            Console.WriteLine("odd");
    }

    #endregion
//============================================================================================\\

    // 5- Write a program that takes character from the user then if it is a 
    //     vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
    
    #region Task 5

    static void Task5()
    {
        Console.WriteLine("Enter a character:");
        char ch = char.Parse(Console.ReadLine().ToLower());
        if ("aeiou".IndexOf(ch) >= 0)
            Console.WriteLine("vowel");
        else
            Console.WriteLine("consonant");
    }

    #endregion
//============================================================================================\\

    // 6- Write a program that allows the user to insert an integer then print 
    //     all numbers between 1 to that number.
    
    #region Task 6

    static void Task6()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    #endregion
//============================================================================================\\

    // 7- Write a program that allows the user to insert an integer then 
    // print a multiplication table up to 12.
    
    #region Task 7

    static void Task7()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.Write(num * i + " ");
        }

        Console.WriteLine();
    }

    #endregion
//============================================================================================\\

    // 8- Write a program that allows to user to insert number then print all 
    //     even numbers between 1 to this number
    
    #region Task 8

    static void Task8()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    #endregion
//============================================================================================\\

    // 9- Write a program that takes two integers then prints the power.
    
    #region Task 9

    static void Task9()
    {
        Console.WriteLine("Enter base and exponent:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(num1, num2));
    }

    #endregion
//============================================================================================\\

    // 10- Write a program to enter marks of five subjects and calculate total, 
    //     average and percentage.
    
    #region Task 10

    static void Task10()
    {
        Console.WriteLine("Enter marks of five subjects:");
        int[] marks = new int[5];
        int total = 0;
        for (int i = 0; i < 5; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];
        }
        double average = total / 5.0;
        double percentage = (total / 500.0) * 100;
        Console.WriteLine($"Total marks = {total}");
        Console.WriteLine($"Average Marks = {average}");
        Console.WriteLine($"Percentage = {percentage}");
    }

    #endregion
//============================================================================================\\

    // 11- Write a program to input the month number and print the number of days 
    // in that month.
    
    #region Task 11

    static void Task11()
    {
        Console.WriteLine("Enter month number:");
        int month = int.Parse(Console.ReadLine());
        int days = DateTime.DaysInMonth(DateTime.Now.Year, month);
        Console.WriteLine($"Days in Month: {days}");
    }

    #endregion
//============================================================================================\\

    // 12- Write a program to create a Simple Calculator.
    
    #region Task 12

    static void Task12()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());
        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }

    #endregion
//============================================================================================\\

    // 13- Write a program to allow the user to enter a string and print the 
    // REVERSE of it.
    
    #region Task 13

    static void Task13()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }

    #endregion
//============================================================================================\\

    // 14- Write a program to allow the user to enter int and print the REVERSED 
    //     of it.
    
    #region Task 14

    static void Task14()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());
        int reversed = 0;
        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine(reversed);
    }

    #endregion
//============================================================================================\\

    // 15- Write a program in C# Sharp to find prime numbers within a range of 
    //     numbers.
    
    #region Task 15

    static void Task15()
    {
        Console.WriteLine("Enter the range:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("The prime numbers are:");
        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    #endregion
//============================================================================================\\

    // 16- . Write a program in C# Sharp to convert a decimal number into binary 
    // without using an array.
    
    #region Task 16

    static void Task16()
    {
        Console.WriteLine("Enter a decimal number:");
        int num = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(num, 2);
        Console.WriteLine($"Binary: {binary}");
    }

    #endregion
//============================================================================================\\

    // 17- Create a program that asks the user to input three points (x1, y1), 
    // (x2, y2), and (x3, y3), and determines whether these points lie on a 
    // single straight line.
    
    #region Task 17

    static void Task17()
    {
        Console.WriteLine("Enter three points (x1, y1), (x2, y2), (x3, y3):");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            Console.WriteLine("The points lie on a single straight line.");
        else
            Console.WriteLine("The points do not lie on a single straight line.");
    }

    #endregion
//============================================================================================\\

    // 18- Within a company, the efficiency of workers is evaluated based on the 
    // duration required to complete a specific task. A worker's efficiency level 
    // is determined as follows: - If the worker completes the job within 2 to 3 hours, they are considered 
    //     highly efficient. - If the worker takes 3 to 4 hours, they are instructed to increase their 
    // speed. - If the worker takes 4 to 5 hours, they are provided with training to 
    // enhance their speed. - If the worker takes more than 5 hours, they are required to leave the 
    //     company. 
    //     To calculate the efficiency of a worker, the time taken for the task is 
    // obtained via user input from the keyboard.
    
    #region Task 18

    static void Task18()
    {
        Console.WriteLine("Enter time taken by worker :");
        double hours = double.Parse(Console.ReadLine());
        if (hours >= 2 && hours <= 3)
            Console.WriteLine("Highly efficient");
        else if (hours > 3 && hours <= 4)
            Console.WriteLine("Increase your speed");
        else if (hours > 4 && hours <= 5)
            Console.WriteLine("Training is required");
        else if (hours > 5)
            Console.WriteLine("Leave the company");
        else
            Console.WriteLine("Invalid input");
    }

    #endregion
}