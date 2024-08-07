//============================================================================================\\
//===================================Assignment_1(Linq)=======================================\\
//============================================================================================\\
 
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_01Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            
            // // 1. Find all products that are out of stock.
            // var outOfStockProducts = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            // Console.WriteLine("Products that are out of stock:");
            // foreach (var product in outOfStockProducts)
            // {
            //     Console.WriteLine(product);
            // }
            //
            // // 2. Find all products that are in stock and cost more than 3.00 per unit.
            // var inStockAndExpensiveProducts = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            // Console.WriteLine("\nProducts that are in stock and cost more than 3.00 per unit:");
            // foreach (var product in inStockAndExpensiveProducts)
            // {
            //     Console.WriteLine(product);
            // }
            //
            // // 3. Returns digits whose name is shorter than their value.
            // string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            // var shortNamedDigits = digits.Where((d,index) => d.Length < index);
            // Console.WriteLine("\nDigits whose name is shorter than their value:");
            // foreach (var digit in shortNamedDigits)
            // {
            //     Console.WriteLine(digit);
            // }

            #endregion
            
            //================================================================================\\

            #region Ordering Operators
            
            // // 1. Sort a list of products by name
            // var productsSortedByName = ListGenerator.ProductList.OrderBy(p => p.ProductName);
            // Console.WriteLine("\nProducts sorted by name:");
            // foreach (var product in productsSortedByName)
            // {
            //     Console.WriteLine(product);
            // }
            //
            // // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            // string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            // var caseInsensitiveSortedWords = words.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            // Console.WriteLine("\nWords sorted case-insensitively:");
            // foreach (var word in caseInsensitiveSortedWords)
            // {
            //     Console.WriteLine(word);
            // }
            //
            // // 3. Sort a list of products by units in stock from highest to lowest.
            // var productsSortedByStock = ListGenerator.ProductList.OrderByDescending(p => p.UnitsInStock);
            // Console.WriteLine("\nProducts sorted by units in stock (highest to lowest):");
            // foreach (var product in productsSortedByStock)
            // {
            //     Console.WriteLine(product);
            // }
            //
            // // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            // string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            // var digitsSortedByNameLength = digits.OrderBy(d => d.Length).ThenBy(d => d);
            // Console.WriteLine("\nDigits sorted by length of name and then alphabetically:");
            // foreach (var digit in digitsSortedByNameLength)
            // {
            //     Console.WriteLine(digit);
            // }

            #endregion
            
            //================================================================================\\
            
            #region Transformation Operators
            
            // // 1. Return a sequence of just the names of a list of products.
            // var productNames = ListGenerator.ProductList.Select(p => p.ProductName);
            // Console.WriteLine("\nProduct names:");
            // foreach (var name in productNames)
            // {
            //     Console.WriteLine(name);
            // }
            //
            // // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            // string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            // var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            // Console.WriteLine("\nWords with uppercase and lowercase versions:");
            // foreach (var word in upperLowerWords)
            // {
            //     Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            // }
            //
            // // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            // var productDetails = ListGenerator.ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice });
            // Console.WriteLine("\nProduct details (with renamed UnitPrice):");
            // foreach (var detail in productDetails)
            // {
            //     Console.WriteLine($"ProductName: {detail.ProductName}, Price: {detail.Price}");
            // }

            #endregion
        }
    }
}
