//============================================================================================\\
//===================================Assignment_03(Linq)======================================\\
//============================================================================================\\

namespace Assignment_03_Linq;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var customers = ListGenerator.CustomerList;
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        
//============================================================================================\\

        #region task1

        // // 1. Get the first 3 orders from customers in Washington.
        // var firstThreeWashingtonOrders = customers
        //     .Where(c => c.Region == "WA")
        //     .SelectMany(c => c.Orders)
        //     .Take(3);
        //
        // Console.WriteLine("First 3 orders from customers in Washington:");
        // foreach (var order in firstThreeWashingtonOrders)
        // {
        //     Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
        // }
        
        #endregion
        
//============================================================================================\\

        #region task2

        // // 2. Get all but the first 2 orders from customers in Washington.
        // var allButFirstTwoWashingtonOrders = customers
        //     .Where(c => c.Region == "WA")
        //     .SelectMany(c => c.Orders)
        //     .Skip(2);
        //
        // Console.WriteLine("All but the first 2 orders from customers in Washington:");
        // foreach (var order in allButFirstTwoWashingtonOrders)
        // {
        //     Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
        // }
        
        #endregion
        
//============================================================================================\\
        
        #region task3

        // // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
        // var elementsBeforeCondition = numbers.TakeWhile((n, index) => n >= index);
        //
        // Console.WriteLine("Elements before hitting a number less than its position:");
        // foreach (var number in elementsBeforeCondition)
        // {
        //     Console.WriteLine(number);
        // }
        
        #endregion
        
//============================================================================================\\

        #region task4

        // // 4. Get the elements of the array starting from the first element divisible by 3.
        // var elementsFromDivisibleByThree = numbers.SkipWhile(n => n % 3 != 0);
        //
        // Console.WriteLine("Elements starting from the first divisible by 3:");
        // foreach (var number in elementsFromDivisibleByThree)
        // {
        //     Console.WriteLine(number);
        // }
        
        #endregion
        
//============================================================================================\\

        #region task5

        // // 5. Get the elements of the array starting from the first element less than its position.
        // var elementsFromFirstLessThanPosition = numbers.SkipWhile((n, index) => n >= index);
        //
        // Console.WriteLine("Elements starting from the first element less than its position:");
        // foreach (var number in elementsFromFirstLessThanPosition)
        // {
        //     Console.WriteLine(number);
        // }
        
        #endregion

    }
}
