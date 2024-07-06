//============================================================================================\\
//===================================Assignment_06============================================\\
//============================================================================================\\

namespace Assignment_06;
using System;
class Assignment_06
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
    }

//============================================================================================\\

    // 1. Define a struct “Person” with properties “Name” and 
    // “Age”. Create an array of three “Person” objects and 
    // populate it with data. Then, write a C# program to 
    // display the details of all the persons in the array.

    #region Task 1
    
    struct Person
    {
        public string Name;
        public int Age;
    }


    static void Task1()
    {
        Person[] persons = new Person[3];

        persons[0] = new Person { Name = "shehab", Age = 20 };
        persons[1] = new Person { Name = "zezo", Age = 19 };
        persons[2] = new Person { Name = "omar", Age = 19 };

        foreach (Person person in persons)
        {
            Console.WriteLine("Name: " + person.Name + ", Age: " + person.Age);
        }
    }

    #endregion

//============================================================================================\\

    // 2. Create a struct called “Point” to represent a 2D point 
    // with properties “X” and “Y”. Write a C# program that 
    // takes two points as input from the user and calculates 
    // the distance between them.

    #region Task 2
    
    struct Point
    {
        public int X;
        public int Y;
    }

    static void Task2()
    {
        Point point1, point2;

        Console.WriteLine("Enter the coordinates for the first point (X Y):");
        point1.X = int.Parse(Console.ReadLine());
        point1.Y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coordinates for the second point (X Y):");
        point2.X = int.Parse(Console.ReadLine());
        point2.Y = int.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        Console.WriteLine("The distance between the two points is: " + distance);
    }
    
    #endregion

//============================================================================================\\

    // 3. Create a struct called “Person” with properties “Name” and 
    // “Age”. Write a C# program that takes details of 3 persons as 
    // input from the user and displays the name and age of the 
    // oldest person
    
    #region Task 3

    static void Task3()
    {
        Person[] persons = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("Name: ");
            persons[i].Name = Console.ReadLine();
            Console.Write("Age: ");
            persons[i].Age = int.Parse(Console.ReadLine());
        }

        Person oldestPerson = persons[0];
        for (int i = 1; i < 3; i++)
        {
            if (persons[i].Age > oldestPerson.Age)
            {
                oldestPerson = persons[i];
            }
        }

        Console.WriteLine("The oldest person is " + oldestPerson.Name + " with age " + oldestPerson.Age);
    }

    #endregion
    
}
