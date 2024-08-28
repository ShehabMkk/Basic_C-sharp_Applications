//============================================================================================\\
//===================================Assignment_03============================================\\
//============================================================================================\\

using System.Runtime.CompilerServices;

namespace Assignment_03;
using System;

class Assignment_03
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

    }
    
//============================================================================================\\

    //=== Arrays ===\\
    
    // 1- . Write a program that prints an identity matrix using for 
    // loop, in other words takes a value n from the user and shows the 
    // identity table of size n * n.
    
    #region Task 1
    
    static void Task1()
    {
        Console.WriteLine("please input the size of the  identity matrix :");
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (i == j)
                    Console.Write("1 ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }    
    }

    #endregion
//============================================================================================\\

    // 2- Write a program in C# Sharp to find the sum of all elements 
    // of the array.
    
    #region Task 2

    static void Task2()
    {
        int[] array = new int[5];
        
        Console.WriteLine("Enter values for a 5 elemant array:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        int sum = array.Sum();
        
        Console.WriteLine("the sum of all elements of the array is :" + sum);
    }

    #endregion
//============================================================================================\\

    // 3- Write a program in C# Sharp to merge two arrays of the same 
    // size sorted in ascending order.
    
    #region Task 3

    static void Task3()
    {
        int[] array1 = new int[5];
        int[] array2 = new int[5];
        
        Console.WriteLine("Enter values for array1:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The array1 is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Enter values for array2:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array2[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The array2 is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array2[i] + " ");
        }
        Console.WriteLine();

        int[] merge_arr = array1.Union(array2).ToArray();
        Array.Sort(merge_arr);
        
        Console.WriteLine("The merge of array1 + array2 is:");
        for (int i = 0; i < merge_arr.Length; i++)
        {
            Console.Write(merge_arr[i] + " ");
        }
        Console.WriteLine();
    }

    #endregion
//============================================================================================\\

    // 4- Write a program in C# Sharp to count the frequency of each 
    //     element of an array.
    
    #region Task 4

    static void Task4()
    {
        int[] array = new int[10];
        
        Console.WriteLine("Enter values for a 10 elemant array:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        var frequency = array.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        foreach (var item in frequency)
        {
            Console.WriteLine($"{item.Key} appears {item.Value} times");
        }
    }

    #endregion
//============================================================================================\\

    // 5- Write a program in C# Sharp to find maximum and minimum 
    // element in an array
    
    #region Task 5

    static void Task5()
    {
        int[] array = new int[5];
        
        Console.WriteLine("Enter values for a 5 elemant array:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        int max = array.Max();
        int min = array.Min();
        Console.WriteLine($"Maximum: {max}, Minimum: {min}");
    }

    #endregion
//============================================================================================\\

    // 6- Write a program in C# Sharp to find the second largest element 
    // in an array.
    
    #region Task 6

    static void Task6()
    {
        int[] array = new int[5];
        int larg2nd = 0;
        
        Console.WriteLine("Enter values for a 5 elemant array:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            if (array[i] == array.Max())
                continue;
            else
            {
                if (larg2nd < array[i])
                    larg2nd = array[i];
            }
        }
        
        Console.WriteLine($"second largest element is: {larg2nd}");
    }

    #endregion
//============================================================================================\\

    // 7- write a program to find the longest distance between Two equal 
    //    cells.
    
    #region Task 7

    static void Task7()
    {
        int[] array = new int[10];
        
        Console.WriteLine("Enter values for a 10 elemant array:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        int maxDistance = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    int distance = j - i;
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
            }
        }
        
        Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
    }

    #endregion
//============================================================================================\\

    // 8- Given a list of space separated words, reverse the order of 
    //     the words.
    
    #region Task 8

    static void Task8()
    {
        Console.WriteLine("write a string to reverse it's words");
        string sentence= Console.ReadLine();
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string reversed = string.Join(" ", words);
        Console.WriteLine($"the reversed words is: {reversed}");
    }

    #endregion
//============================================================================================\\

    // 9- Write a program to create two multidimensional arrays of the 
    // same size. Accept value from the user and store them in the first 
    // array. Now copy all the elements of the first array onto the 
    //     second array and print the second array. 
    
    #region Task 9

    static void Task9()
    {
        int[,] array1 = new int[3, 3];
        int[,] array2 = new int[3, 3];

        Console.WriteLine("Enter values for the first 3x3 array:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array1[i, j] = int.Parse(Console.ReadLine());
                array2[i, j] = array1[i, j];
            }
        }
        
        Console.WriteLine("Second array is:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(array2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    #endregion
//============================================================================================\\

    // 10- Write a Program to Print One Dimensional Array in Reverse 
    //     Order
    
    #region Task 10

    static void Task10()
    {
        int[] array = new int[5];
        
        Console.WriteLine("Enter values for a 5 elemant array:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter value for element [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("The reversed array is:");
        int n = 5;
        while (n-- != 0)
        {
            Console.Write(array[n] + " ");
        }
        Console.WriteLine();
    }

    #endregion
//============================================================================================\\

    //=== General ===\\

    // 1-Write a program that calculates the simple interest given the 
    // principal amount, rate of interest, and time.
    
    #region Task 11

    static void Task11()
    {
        Console.WriteLine("General Problem 1: Simple Interest");
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter time: ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest: {simpleInterest}\n");
    }

    #endregion
//============================================================================================\\

    // 2- Write a program that calculates the Body Mass Index
    // (BMI) given a person's weight in kilograms
    // and height in meters.    
    
    #region Task 12

    static void Task12()
    {
        Console.WriteLine("General Problem 2: BMI");
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter height (m): ");
        double height = double.Parse(Console.ReadLine());
        double bmi = weight / (height * height);
        Console.WriteLine($"BMI: {bmi}\n");
    }

    #endregion
//============================================================================================\\

    // 3- Write a program that uses the ternary operator to check if 
    // the temperature is too hot, too cold, or just good. Assign the 
    // result in a variable then display the result. Assume that below 
    // 10 degrees is "Just Cold", above 30 degrees is 
    // "Just Hot", and anything else is "Just Good"

    
    #region Task 13

    static void Task13()
    {
        Console.WriteLine("General Problem 3: Temperature Check");
        Console.Write("Enter temperature: ");
        int temperature = int.Parse(Console.ReadLine());
        string temperatureStatus = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
        Console.WriteLine($"Temperature status: {temperatureStatus}\n");
    }

    #endregion
//============================================================================================\\

    // 4- Write a program that takes the date from the user and 
    //     displays it in various formats using string interpolation.
    
    #region Task 14

    static void Task14()
    {
        Console.WriteLine("General Problem 4: Date Formats");
        Console.Write("Enter date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"Today's date: {date:dd, MM, yyyy}");
        Console.WriteLine($"Today's date: {date:dd / MM / yyyy}");
        Console.WriteLine($"Today's date: {date:dd – MM – yyyy}\n");
    }

    #endregion
//============================================================================================\\

    // 5-What is the output of the following C# code?
    //   DateTime date = new DateTime(2024, 6, 14); 
    //   Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
    
    #region Task 15

    //the output should be (c) The event is on 06/14/2024

    #endregion

}
