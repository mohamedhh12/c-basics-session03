using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAssignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            /*question: Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            both title and upperTitle to show that title did not change.*/
            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine("title: " + title);
            Console.WriteLine("upperTitle: " + upperTitle);
            #endregion
            Console.WriteLine("=============================================");
            #region Task02
            /*question: Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            to check if they point to the same object in memory.*/
            string str1 = "Clean Code";
            string str2 = "Clean Code";

            bool isEqual = ReferenceEquals(str1, str2);

            Console.WriteLine(isEqual);
            #endregion
            Console.WriteLine("=============================================");
            #region Task03
            /*question: Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            object. Print the final result.*/
            StringBuilder bookList03 = new StringBuilder();

            bookList03.Append("Book List");
            bookList03.Append(" - Updated");

            Console.WriteLine(bookList03);

            #endregion
            Console.WriteLine("=============================================");

            #region Task04
            /*question: Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            Print the result.*/
            StringBuilder bookList04 = new StringBuilder();

            bookList04.Append("Book List");
            bookList04.Append(" - Updated");

            bookList04.Replace("Book List", "Library");

            Console.WriteLine(bookList04);
            // another solution using the same StringBuilder From the previous question :
            bookList03.Replace("Book List", "Library");
            Console.WriteLine(bookList03);
            #endregion
            Console.WriteLine("=============================================");
            #region Task05
            /*question: Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            Pages: 464" using the + operator..*/
            string title05 = "Clean Code";
            int pages05 = 464;

            string result05 = "Book: " + title05 + ",\nPages: " + pages05;

            Console.WriteLine(result05);
            #endregion
            Console.WriteLine("=============================================");
            #region Task06
            /*question: Build the same sentence as above, but using string interpolation ($"...").*/
            string title06 = "Clean Code";
            int pages06 = 464;

            string result06 = $"Book: {title06},\nPages: {pages06}";

            Console.WriteLine(result06);

            #endregion
            Console.WriteLine("=============================================");
            #region Task07 
            /*question: Build the same sentence again, but using string.Format().*/
            string title07 = "Clean Code";
            int pages07 = 464;

            string result07 = string.Format("Book: {0},\nPages: {1}", title07, pages07);

            Console.WriteLine(result07);
            #endregion
            Console.WriteLine("=============================================");
            #region Task08
            /*question: Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            300, otherwise prints "Short Book".*/
            int pages08 = 464;

            if (pages08 > 300)
            {
                // if the condition is true, it will print "Long Book"
                Console.WriteLine("Long Book");
            }
            else
            {
                //if the condition is false, it will print "Short Book"
                Console.WriteLine("Short Book");
            }
            #endregion
            Console.WriteLine("=============================================");
            #region Task09
            /*question: Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            greater than 300 and isAvailable is true. Use the && operator.*/
            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {
                // if both conditions are true, it will print "You can borrow this book"
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            Console.WriteLine("=============================================");
            #region Task10
            /*question: Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/
            string title10 = "Refactoring";

            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;// if the title is "Clean Code", it will print "Great choice!"

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;// if the title is "Refactoring", it will print "Nice pick!"

                default:
                    Console.WriteLine("Never heard of it");
                    break;// if the title is neither "Clean Code" nor "Refactoring", it will print "Never heard of it"
            }
            #endregion
            Console.WriteLine("=============================================");
            #region Task11
            /*question:Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            variable sizeLabel (same rule as question 8: long if pages > 300).*/
            int pages11 = 464;

            string sizeLabel = pages11 > 300 ? "Long Book" /*if the condition is true, it will store "Long Book"*/: "Short Book"/*if the condition is false, it will store "Short Book"*/;

            Console.WriteLine(sizeLabel);

            #endregion
            Console.WriteLine("=============================================");
        }
    }
}
