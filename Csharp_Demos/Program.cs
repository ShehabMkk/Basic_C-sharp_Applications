//============================================================================================\\
//===================================== Demo_07 ==============================================\\
//============================================================================================\\

namespace Demo_07;
using System;

#region Part 01 Class Overview & Its Constructor
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
#endregion

//============================================================================================\\

#region Part 02 Internal Constructor Chaining
public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age) : this(name, age, "Unknown") { }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }

    public void DisplayEmployeeInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Position: {Position}");
    }
}
#endregion

//============================================================================================\\

#region Part 03 Inheritance & Diamond Problem
public interface IManager
{
    void Manage();
}

public interface IWorker
{
    void Work();
}

public class Manager : Employee, IManager, IWorker
{
    public Manager(string name, int age, string position) : base(name, age, position) { }

    public void Manage()
    {
        Console.WriteLine("Managing the team.");
    }

    public void Work()
    {
        Console.WriteLine("Working on tasks.");
    }
}
#endregion

//============================================================================================\\

#region Part 04 External Constructor Chaining
public class Intern : Employee
{
    public Intern(string name, int age) : base(name, age, "Intern") { }
}
#endregion

//============================================================================================\\

#region Part 05 Disadvantages Of Constructor Chaining
// Constructor chaining can make the class hierarchy rigid and less flexible.
#endregion

//============================================================================================\\

#region Part 06 Polymorphism (Method Overloading)
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public string Add(string a, string b)
    {
        return a + b;
    }
}
#endregion

//============================================================================================\\

#region Part 07 Polymorphism (Static Binding)
public class StaticPolymorphismDemo
{
    public void Show()
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(2, 3));
        Console.WriteLine(calculator.Add(2.5, 3.5));
        Console.WriteLine(calculator.Add("Hello", " World"));
    }
}
#endregion

//============================================================================================\\

#region Part 08 Polymorphism (Dynamic Binding)
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

public class DynamicPolymorphismDemo
{
    public void Show()
    {
        Animal myAnimal = new Dog();
        myAnimal.Speak();
    }
}
#endregion

//============================================================================================\\

#region Part 09 Binding Case Study
public class BindingCaseStudy
{
    public void Show()
    {
        StaticPolymorphismDemo staticDemo = new StaticPolymorphismDemo();
        staticDemo.Show();

        DynamicPolymorphismDemo dynamicDemo = new DynamicPolymorphismDemo();
        dynamicDemo.Show();
    }
}
#endregion

//============================================================================================\\

#region Part 10 Interface Overview
public interface IPrintable
{
    void Print();
}

public class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}
#endregion

//============================================================================================\\

#region Part 11 Interface Example
public class InterfaceExampleDemo
{
    public void Show()
    {
        IPrintable doc = new Document();
        doc.Print();
    }
}
#endregion

//============================================================================================\\

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Class Overview & Its Constructor:");
        // Person person = new Person("shehab", 30);
        // person.DisplayInfo();
        // Console.WriteLine();
        //
        // Console.WriteLine("Internal Constructor Chaining:");
        // Employee employee = new Employee("mkk", 28, "Developer");
        // employee.DisplayEmployeeInfo();
        // Console.WriteLine();
        //
        // Console.WriteLine("Inheritance & Diamond Problem:");
        // Manager manager = new Manager("omar", 40, "Team Lead");
        // manager.Manage();
        // manager.Work();
        // Console.WriteLine();
        //
        // Console.WriteLine("External Constructor Chaining:");
        // Intern intern = new Intern("khalid", 22);
        // intern.DisplayEmployeeInfo();
        // Console.WriteLine();
        //
        // Console.WriteLine("Polymorphism (Method Overloading):");
        // StaticPolymorphismDemo staticDemo = new StaticPolymorphismDemo();
        // staticDemo.Show();
        // Console.WriteLine();
        //
        // Console.WriteLine("Polymorphism (Dynamic Binding):");
        // DynamicPolymorphismDemo dynamicDemo = new DynamicPolymorphismDemo();
        // dynamicDemo.Show();
        // Console.WriteLine();
        //
        // Console.WriteLine("Binding Case Study:");
        // BindingCaseStudy bindingCaseStudy = new BindingCaseStudy();
        // bindingCaseStudy.Show();
        // Console.WriteLine();
        //
        // Console.WriteLine("Interface Overview:");
        // Document document = new Document();
        // document.Print();
        // Console.WriteLine();
        //
        // Console.WriteLine("Interface Example:");
        // InterfaceExampleDemo interfaceDemo = new InterfaceExampleDemo();
        // interfaceDemo.Show();
    }
}
