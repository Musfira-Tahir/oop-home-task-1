using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1_Hometask_04
{
    internal class Book
    {
        // Class attributes
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;  // Original Price
        private double DiscountedPrice; // New Price after Discount

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("\n-------------------- The Book Details are: ");
            Console.WriteLine($"     Book Title: {Title}");
            Console.WriteLine($"     Author Name: {Author}");
            Console.WriteLine($"     Book ISBN: {ISBN}");
            Console.WriteLine($"     Original Price: Rs.{Price}");

            // If discount was applied, show the new price
            if (DiscountedPrice > 0)
            {
                Console.WriteLine($"     Discounted Price: Rs.{DiscountedPrice}");
            }
        }

        // Method to apply discount
        public void DiscountPrice(double percentage)
        {
            DiscountedPrice = Price - (Price * (percentage / 100)); // Correctly updating discounted price
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n        ------>  Welcome to the Library Management System    <-------      ");
            Console.WriteLine("\n                    The Book Details Are: ");
            Console.WriteLine();

            // First object
            Book book_one = new Book();
            book_one.Title = "The Kite Runner";
            book_one.Author = "Khaled Hossaini";
            book_one.ISBN = "ABF";
            book_one.Price = Convert.ToDouble("1050");

            // Second object
            Book book_two = new Book();
            book_two.Title = "Thinking Fast, and Slow";
            book_two.Author = "Daniel Kahneman";
            book_two.ISBN = "GDHJS";
            book_two.Price = Convert.ToDouble("850");

            // Third object
            Book book_three = new Book();
            book_three.Title = "Matilda";
            book_three.Author = "Roald Dahl";
            book_three.ISBN = "WENXJDJ";
            book_three.Price = Convert.ToDouble("685"); // Fixed the assignment

            // Displaying details initially
            Console.WriteLine("   ---------- Book Details BEFORE Discount Are: -----------");
            book_one.DisplayBookDetails();
            book_two.DisplayBookDetails();
            book_three.DisplayBookDetails();
            Console.WriteLine();

            // Applying Discount
            book_one.DiscountPrice(15);
            book_two.DiscountPrice(9);
            book_three.DiscountPrice(33);
            Console.WriteLine();

            // Displaying Details after discount:
            Console.WriteLine("   ---------- Book Details AFTER Discount Are: -----------");
            book_one.DisplayBookDetails();
            book_two.DisplayBookDetails();
            book_three.DisplayBookDetails();
            Console.WriteLine();

            Console.ReadLine();
        }

    }
}
