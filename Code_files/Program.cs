//============================================================================================\\
//===================================Assignment_11============================================\\
//============================================================================================\\

namespace Assignment_11;
using System;
using System.Collections.Generic;

class Program
{
    
    static int FirstNonRepeatedCharacter(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount.ContainsKey(s[i]))
            {
                charCount[s[i]]++;
            }
            else
            {
                charCount[s[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
    
    //============================================================================================\\ 
    
    static void Main(string[] args)
    {
        #region TestProblem1
        
        // string input = "lswisslk";
        // int result = FirstNonRepeatedCharacter(input);
        // if (result != -1)
        // {
        //     Console.WriteLine($"The first non-repeated character is at index: {result}");
        // }
        // else
        // {
        //     Console.WriteLine("No non-repeated character found.");
        // }
        
        #endregion
        
        //============================================================================================\\
        
        #region TestProblem2

        // var books = new Book[]
        // {
        //     new Book("978-0-316-76948-0", "The Catcher in the Rye", "J.D. Salinger", new DateTime(1951, 7, 16), 10.99m),
        //     new Book("978-0-7432-7356-5", "Brave New World", "Aldous Huxley", new DateTime(1932, 8, 18), 9.99m),
        //     new Book("978-0-452-28423-4", "Moby-Dick", "Herman Melville", new DateTime(1851, 10, 18), 12.99m),
        //     new Book("978-0-618-00222-8", "War and Peace", "Leo Tolstoy", new DateTime(1869, 1, 1), 15.99m),
        //     new Book("978-0-7432-7356-5", "Crime and Punishment", "Fyodor Dostoevsky", new DateTime(1866, 1, 1), 10.99m)
        // };
        //
        // foreach (var book in books)
        // {
        //     Console.WriteLine(book);
        //     Console.WriteLine($"Title: {BookFunctions.GetTitle(book)}");
        //     Console.WriteLine($"Authors: {BookFunctions.GetAuthors(book)}");
        //     Console.WriteLine($"Price: {BookFunctions.GetPrice(book)}");
        //     Console.WriteLine("=====================================");
        // }

        #endregion

        //============================================================================================\\
        
        #region TestProblem3

        // var bookList = new List<Book>(books);
        //
        // Func<Book, string> getTitle = BookFunctions.GetTitle;
        // Func<Book, string> getAuthors = BookFunctions.GetAuthors;
        // Func<Book, string> getPrice = BookFunctions.GetPrice;
        // Func<Book, string> getISBN = book => book.ISBN;
        // Func<Book, string> getPublicationDate = book => book.PublicationDate.ToString("dd-MM-yyyy");
        //
        // LibraryEngine.ProcessBooks(bookList, getTitle);
        // LibraryEngine.ProcessBooks(bookList, getAuthors);
        // LibraryEngine.ProcessBooks(bookList, getPrice);
        // LibraryEngine.ProcessBooks(bookList, getISBN);
        // LibraryEngine.ProcessBooks(bookList, getPublicationDate);

        #endregion

    }
}