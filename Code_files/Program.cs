//============================================================================================\\
//===================================Assignment_10============================================\\
//============================================================================================\\

namespace Assignment_10;
using System;
using System.Collections;
using System.Collections.Generic;

#region Generic Range

public class Range<T> where T : IComparable<T>
{
    public T Min { get; private set; }
    public T Max { get; private set; }

    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("Min value should be less than or equal to Max value.");
        
        Min = min;
        Max = max;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }

    public T Length()
    {
        dynamic min = Min;
        dynamic max = Max;
        return max - min;
    }
}

#endregion

//============================================================================================\\

#region Reverse Array

public class ArrayListReverser
{
    public static void Reverse(ArrayList list)
    {
        int count = list.Count;
        for (int i = 0; i < count / 2; i++)
        {
            var temp = list[i];
            list[i] = list[count - i - 1];
            list[count - i - 1] = temp;
        }
    }
}

#endregion

//============================================================================================\\

#region Even Numbers

public class EvenNumbersExtractor
{
    public static List<int> ExtractEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }
        return evenNumbers;
    }
}

#endregion

//============================================================================================\\

public class Program
{
    public static void Main()
    {
        #region Test Generic Range
        
        Range<int> intRange = new Range<int>(1, 10);
        Console.WriteLine(intRange.IsInRange(5));
        Console.WriteLine(intRange.IsInRange(11));
        Console.WriteLine(intRange.Length());

        #endregion
        
        //====================================================================================\\

        #region Test Reverse Array
        
        // ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        // ArrayListReverser.Reverse(list);
        // foreach (var item in list)
        // {
        //     Console.Write(item + " ");
        // }
        // Console.WriteLine();

        #endregion
        
        //====================================================================================\\

        #region Test EvenNumbersExtractor
        
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        // List<int> evenNumbers = EvenNumbersExtractor.ExtractEvenNumbers(numbers);
        // foreach (var num in evenNumbers)
        // {
        //     Console.Write(num + " ");
        // }
        
        #endregion
    }
}
