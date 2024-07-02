namespace demo_05;

using System;

class demo_05
{
    static void Main(string[] args)
    {
        #region Part 01 Named and Default Input Parameters
        // NamedAndDefaultParameters(param2: "Hello");
        // NamedAndDefaultParameters("First", "Second");
        #endregion

        #region Part 02 Passing Parameters By Value [Value Type]
        // int valueType = 5;
        // Console.WriteLine($"Before Passing By Value: {valueType}");
        // PassingByValue(valueType);
        // Console.WriteLine($"After Passing By Value: {valueType}");
        #endregion

        #region Part 03 Passing Parameters By Reference [Value Type]
        // int valueTypeRef = 5;
        // Console.WriteLine($"Before Passing By Reference: {valueTypeRef}");
        // PassingByReference(ref valueTypeRef);
        // Console.WriteLine($"After Passing By Reference: {valueTypeRef}");
        #endregion

        #region Part 04 Passing By Value & Reference [Reference Type] (In Case Of Changing Element Inside Array)
        // int[] referenceType = { 1, 2, 3 };
        // Console.WriteLine($"Before Changing Element: {referenceType[0]}");
        // ChangeElement(referenceType);
        // Console.WriteLine($"After Changing Element: {referenceType[0]}");
        #endregion

        #region Part 05 Passing By Value & Reference [Reference Type] (Re-Initialize Array)
        // int[] referenceTypeReInit = { 1, 2, 3 };
        // Console.WriteLine($"Before Re-Initialization: {referenceTypeReInit.Length}");
        // ReInitializeArray(ref referenceTypeReInit);
        // Console.WriteLine($"After Re-Initialization: {referenceTypeReInit.Length}");
        #endregion

        #region Part 06 Passing By Out
        // int outValue;
        // PassingByOut(out outValue);
        // Console.WriteLine($"Out Value: {outValue}");
        #endregion

        #region Part 07 Passing By Value Vs Reference Vs Out
        // int byValue = 10;
        // int byReference = 10;
        // int byOut;
        // PassingByValueVsReferenceVsOut(byValue, ref byReference, out byOut);
        // Console.WriteLine($"By Value: {byValue}, By Reference: {byReference}, By Out: {byOut}");
        #endregion

        #region Part 08 Params
        // ParamsMethod(1, 2, 3, 4, 5);
        #endregion

        #region Part 09 Enum
        // DisplayEnum(DaysOfWeek.Wednesday);
        #endregion
    }

    #region Part 01 Named and Default Input Parameters
    static void NamedAndDefaultParameters(string param1 = "Default", string param2 = "World")
    {
        Console.WriteLine($"Param1: {param1}, Param2: {param2}");
    }
    #endregion

    #region Part 02 Passing Parameters By Value [Value Type]
    static void PassingByValue(int value)
    {
        value = 10;
    }
    #endregion

    #region Part 03 Passing Parameters By Reference [Value Type]
    static void PassingByReference(ref int value)
    {
        value = 10;
    }
    #endregion

    #region Part 04 Passing By Value & Reference [Reference Type] (In Case Of Changing Element Inside Array)
    static void ChangeElement(int[] array)
    {
        if (array.Length > 0)
            array[0] = 100;
    }
    #endregion

    #region Part 05 Passing By Value & Reference [Reference Type] (Re-Initialize Array)
    static void ReInitializeArray(ref int[] array)
    {
        array = new int[] { 4, 5, 6, 7, 8 };
    }
    #endregion

    #region Part 06 Passing By Out
    static void PassingByOut(out int value)
    {
        value = 10;
    }
    #endregion

    #region Part 07 Passing By Value Vs Reference Vs Out
    static void PassingByValueVsReferenceVsOut(int value, ref int reference, out int outParam)
    {
        value = 20;
        reference = 30;
        outParam = 40;
    }
    #endregion

    #region Part 08 Params
    static void ParamsMethod(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
    #endregion

    #region Part 09 Enum
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    static void DisplayEnum(DaysOfWeek day)
    {
        Console.WriteLine($"Selected Day: {day}");
    }
    #endregion
}
