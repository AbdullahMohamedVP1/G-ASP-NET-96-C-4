using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Create a one-dimensional array double[] prices with the values
            //25.5, 40.0, 33.75.
            //Print the second price (index 1).


            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question2
            //int[,] shelfCopies =
            //{
            //    {3,5},
            //    {1,4}
            //};

            //Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Question 3
            //static void PrintWelcomeMessage()
            //{
            //    Console.WriteLine("Welcome to the Library!");
            //}
            //PrintWelcomeMessage();
            #endregion

            #region Question 4

            // Write a method PrintBookTitle(string title)
            // that prints "Book title: " + title.
            // Call it with "Clean Code".

            //static void PrintBookTitle(string title)
            //{
            //    Console.WriteLine("Book title: " + title);
            //}

            //PrintBookTitle("Clean Code");

            #endregion

            #region Question 5
            // Write a method AddBonusPages(int pages) that adds 50 to pages.
            // Call it with a variable int pages = 400; and print pages afterward.
            // What do you expect to see, and why?

            //static void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}

            //int pages = 400;

            //AddBonusPages(pages);

            //Console.WriteLine(pages);

            #endregion

            #region Question 6

            // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
            // Call it with double[] prices = {25.5,40.0}; and print prices[0] afterward.
            // What do you expect to see, and why?

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}

            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine(prices[0]);

            #endregion

            #region Question 7

            //static void AddBonusPagesByRef(ref int pages)
            //{
            //    pages += 50;
            //}

            //int pages = 400;

            //AddBonusPagesByRef(ref pages);

            //Console.WriteLine(pages);

            #endregion

            #region Question 8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward
            //static void ReplaceArray(ref double[] prices)
            //{
            //    prices = new double[] { 10.0, 12.5, 15.0 };
            //}

            //double[] prices = { 25.5, 40.0 };

            //ReplaceArray(ref prices);

            //Console.WriteLine(prices.Length);
            #endregion

            #region Question 9

            // static bool TryGetPrice(string title, out double price)
            // {
            //     if (title == "Clean Code")
            //     {
            //         price = 25.5;
            //         return true;
            //     }

            //     price = 0;
            //     return false;
            // }

            // double price;

            // if (TryGetPrice("Clean Code", out price))
            // {
            //     Console.WriteLine("Price: " + price);
            // }
            // else
            // {
            //     Console.WriteLine("Book not found");
            // }

            #endregion

            #region Question 10
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            //it once with only a title, and once passing both a title and pages.

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine("Title: " + title);
            //    Console.WriteLine("Pages: " + pages);
            //}

            //PrintBookInfo("Clean Code");
            #endregion

            #region Question 11
            //Using the PrintBookInfo method from the question above, call it by naming the
            //parameters, passing pages before title.

            //static void PrintBookInfo(string title, int pages = 300)
            //{
            //    Console.WriteLine("Title: " + title);
            //    Console.WriteLine("Pages: " + pages);
            //}
            //PrintBookInfo(pages: 450, title: "Clean Code");

            #endregion
        }
    }
}
