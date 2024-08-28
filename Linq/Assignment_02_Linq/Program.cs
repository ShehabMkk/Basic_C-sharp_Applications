//============================================================================================\\
//===================================Assignment_02(Linq)======================================\\
//============================================================================================\\

namespace Assignment_02_Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        #region LINQ - Element Operators

        // var products = ListGenerator.ProductList;
        //
        // // 1. Get first Product out of Stock
        // var firstOutOfStock = products.FirstOrDefault(p => p.UnitsInStock == 0);
        // Console.WriteLine($"First product out of stock: {firstOutOfStock?.ProductName ?? "None"}");
        //
        // // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
        // var firstExpensiveProduct = products.FirstOrDefault(p => p.UnitPrice > 1000);
        // Console.WriteLine($"First product with price > 1000: {firstExpensiveProduct?.ProductName ?? "None"}");
        //
        // // 3. Retrieve the second number greater than 5
        // int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var secondGreaterThanFive = arr.Where(n => n > 5).Skip(1).FirstOrDefault();
        // Console.WriteLine($"Second number greater than 5: {secondGreaterThanFive}");

        #endregion

        //====================================================================================\\
        
        #region LINQ - Aggregate Operators

        // // 1. get the number of odd numbers in the array
        // int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // int oddCount = arr.Count(n => n % 2 != 0);
        // Console.WriteLine($"Number of odd numbers: {oddCount}");
        //
        // // 2. Return a list of customers and how many orders each has.
        // var customers = XElement.Load("C:\\Users\\HP\\RiderProjects\\Assignment_02_Linq\\Customers.xml").Elements("Customer");
        // var customerOrders = customers.Select(c => new
        // {
        //     CustomerID = (string)c.Element("CustomerID"),
        //     OrderCount = c.Elements("Orders").Elements("Order").Count()
        // });
        //
        // foreach (var customer in customerOrders)
        // {
        //     Console.WriteLine($"Customer {customer.CustomerID} has {customer.OrderCount} orders");
        // }
        //
        // // 3. Return a list of categories and how many products each has
        // var products = ListGenerator.ProductList;
        // var categoryProductCount = products.GroupBy(p => p.Category)
        //                                     .Select(g => new
        //                                     {
        //                                         Category = g.Key,
        //                                         ProductCount = g.Count()
        //                                     });
        //
        // foreach (var category in categoryProductCount)
        // {
        //     Console.WriteLine($"Category {category.Category} has {category.ProductCount} products");
        // }
        //
        // // 4. Get the total of the numbers in an array.
        // int totalSum = arr.Sum();
        // Console.WriteLine($"Total sum of array: {totalSum}");
        //
        // // 5. Get the total number of characters of all words in dictionary_english.txt
        // string[] dictionaryWords = System.IO.File.ReadAllLines("C:\\Users\\HP\\RiderProjects\\Assignment_02_Linq\\dictionary_english.txt");
        // int totalCharacters = dictionaryWords.Sum(word => word.Length);
        // Console.WriteLine($"Total number of characters in dictionary: {totalCharacters}");
        //
        // // 6. Get the length of the shortest word in dictionary_english.txt
        // int shortestWordLength = dictionaryWords.Min(word => word.Length);
        // Console.WriteLine($"Length of the shortest word: {shortestWordLength}");
        //
        // // 7. Get the length of the longest word in dictionary_english.txt
        // int longestWordLength = dictionaryWords.Max(word => word.Length);
        // Console.WriteLine($"Length of the longest word: {longestWordLength}");
        //
        // // 8. Get the average length of the words in dictionary_english.txt
        // double averageWordLength = dictionaryWords.Average(word => word.Length);
        // Console.WriteLine($"Average length of words: {averageWordLength}");
        //
        // // 9. Get the total units in stock for each product category.
        // var totalUnitsInStockByCategory = products.GroupBy(p => p.Category)
        //                                           .Select(g => new
        //                                           {
        //                                               Category = g.Key,
        //                                               TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //                                           });
        //
        // foreach (var category in totalUnitsInStockByCategory)
        // {
        //     Console.WriteLine($"Category {category.Category} has {category.TotalUnitsInStock} units in stock");
        // }

        #endregion

        //====================================================================================\\
        
        #region LINQ - Set Operators

        // // 1. Find the unique Category names from Product List
        // var products = ListGenerator.ProductList;
        // var uniqueCategories = products.Select(p => p.Category).Distinct();
        // Console.WriteLine("Unique categories:");
        // foreach (var category in uniqueCategories)
        // {
        //     Console.WriteLine(category);
        // }
        //
        // // 2. Produce a Sequence containing the unique first letter from both product and customer names.
        // var customers = XElement.Load("C:\\Users\\HP\\RiderProjects\\Assignment_02_Linq\\Customers.xml").Elements("Customer");
        // var productNames = products.Select(p => p.ProductName);
        // var customerNames = customers.Select(c => (string)c.Element("CompanyName"));
        // var uniqueFirstLetters = productNames.Concat(customerNames)
        //                                      .Select(name => name[0])
        //                                      .Distinct();
        // Console.WriteLine("Unique first letters from product and customer names:");
        // foreach (var letter in uniqueFirstLetters)
        // {
        //     Console.WriteLine(letter);
        // }
        //
        // // 3. Create one sequence that contains the common first letter from both product and customer names.
        // var commonFirstLetters = productNames.Select(p => p[0])
        //                                      .Intersect(customerNames.Select(c => c[0]));
        // Console.WriteLine("Common first letters from product and customer names:");
        // foreach (var letter in commonFirstLetters)
        // {
        //     Console.WriteLine(letter);
        // }
        //
        // // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
        // var productFirstLetters = productNames.Select(p => p[0]);
        // var customerFirstLetters = customerNames.Select(c => c[0]);
        // var uniqueProductFirstLetters = productFirstLetters.Except(customerFirstLetters);
        // Console.WriteLine("First letters of product names not in customer names:");
        // foreach (var letter in uniqueProductFirstLetters)
        // {
        //     Console.WriteLine(letter);
        // }
        //
        // // 5. Create one sequence that contains the last three characters in each name of all customers and products, including any duplicates
        // var lastThreeCharacters = productNames.Concat(customerNames)
        //                                       .Select(name => name.Length >= 3 ? name.Substring(name.Length - 3) : name);
        // Console.WriteLine("Last three characters in each name:");
        // foreach (var chars in lastThreeCharacters)
        // {
        //     Console.WriteLine(chars);
        // }

        #endregion

        //====================================================================================\\
        
        #region LINQ - Quantifiers

        // // 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
        // string[] dictionaryWords = System.IO.File.ReadAllLines("C:\\Users\\HP\\RiderProjects\\Assignment_02_Linq\\dictionary_english.txt");
        // bool containsEI = dictionaryWords.Any(word => word.Contains("ei"));
        // Console.WriteLine($"Any word contains 'ei': {containsEI}");
        //
        // // 2. Return a grouped list of products only for categories that have at least one product that is out of stock.
        // var products = ListGenerator.ProductList;
        // var categoriesWithOutOfStock = products.GroupBy(p => p.Category)
        //                                        .Where(g => g.Any(p => p.UnitsInStock == 0))
        //                                        .Select(g => new
        //                                        {
        //                                            Category = g.Key,
        //                                            Products = g.ToList()
        //                                        });
        //
        // Console.WriteLine("Categories with at least one out of stock product:");
        // foreach (var category in categoriesWithOutOfStock)
        // {
        //     Console.WriteLine($"Category: {category.Category}");
        //     foreach (var product in category.Products)
        //     {
        //         Console.WriteLine($" - {product.ProductName}");
        //     }
        // }
        //
        // // 3. Return a grouped list of products only for categories that have all of their products in stock.
        // var categoriesWithAllInStock = products.GroupBy(p => p.Category)
        //                                        .Where(g => g.All(p => p.UnitsInStock > 0))
        //                                        .Select(g => new
        //                                        {
        //                                            Category = g.Key,
        //                                            Products = g.ToList()
        //                                        });
        //
        // Console.WriteLine("Categories with all products in stock:");
        // foreach (var category in categoriesWithAllInStock)
        // {
        //     Console.WriteLine($"Category: {category.Category}");
        //     foreach (var product in category.Products)
        //     {
        //         Console.WriteLine($" - {product.ProductName}");
        //     }
        // }

        #endregion

        //====================================================================================\\
        
        #region LINQ - Grouping Operators

        // // Use group by to partition a list of numbers by their remainder when divided by 5
        // List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        // var groupedByRemainder = numbers.GroupBy(n => n % 5);
        //
        // Console.WriteLine("Numbers grouped by remainder when divided by 5:");
        // foreach (var group in groupedByRemainder)
        // {
        //     Console.WriteLine($"Remainder {group.Key}:");
        //     foreach (var number in group)
        //     {
        //         Console.WriteLine(number);
        //     }
        // }

        #endregion
    }
}
