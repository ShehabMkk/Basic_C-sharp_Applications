//============================================================================================\\
//===================================Assignment_05============================================\\
//============================================================================================\\

namespace Assignment_05;
using System;

class Assignment_05
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
    }

//============================================================================================\\

    // 1- Create an enum called "WeekDays" with the days of the week
    //    (Monday to Sunday) as its members. Then, write a C# program that
    //    prints out all the days of the week using this enum.


    #region Task 1
    
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    
    static void Task1()
    {
        foreach (var day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
        Console.WriteLine();
    }

    #endregion

//============================================================================================\\

    // 2. Create an enum called "Season" with the four seasons (Spring,
    //     Summer, Autumn, Winter) as its members. Write a C# program that
    //     takes a season name as input from the user and displays the
    //     corresponding month range for that season. Note range for seasons (
    //     spring march to may , summer june to august , autumn September to
    //     November , winter December to February)


    #region Task 2
    
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    
    static void Task2()
    {
        Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
        string seasonInput = Console.ReadLine();
        Season season;
        if (Enum.TryParse(seasonInput, true, out season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid season");
        }
        Console.WriteLine();
    }

    #endregion

//============================================================================================\\

    // 3- Assign the following Permissions (Read, write, Delete, Execute) in a
    //    form of Enum.
    //    Create Variable from previous Enum to Add and Remove
    //    Permission from variable, check if specific Permission is
    //    existed inside variable
    
    #region Task 3

    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    
    static void Task3()
    {
        Permissions user = Permissions.Write | Permissions.Delete;
        Console.WriteLine("Current permissions: " + user);

        bool hasExecute = (user & Permissions.Execute) == Permissions.Execute;
        Console.WriteLine("Has Execute permission: " + hasExecute);
        Console.WriteLine();
    }

    #endregion

//============================================================================================\\

    // 4. Create an enum called "Colors" with the basic colors (Red, Green, Blue)
    //    as its members. Write a C# program that takes a color name as input from
    //    the user and displays a message indicating whether the input color is a
    //    primary color or not.

    #region Task 4

    enum Colors
    {
        Red,
        Green,
        Blue
    }
    
    static void Task4()
    {
        Console.Write("Enter a color (Red, Green, Blue): ");
        string colorInput = Console.ReadLine();
        Colors color;
        if (Enum.TryParse(colorInput, true, out color))
        {
            switch (color)
            {
                case Colors.Red:
                case Colors.Green:
                case Colors.Blue:
                    Console.WriteLine($"{color} is a primary color.");
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine($"{colorInput} is not a primary color.");
        }
    }
    #endregion
}
