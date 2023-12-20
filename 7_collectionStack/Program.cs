using System;
using System.Collections.Generic;

namespace collectionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Stack to store books (strings in this case)
            Stack<string> bookStack = new Stack<string>();

            // Push books onto the stack
            bookStack.Push("Book 1");
            bookStack.Push("Book 2");
            bookStack.Push("Book 3");
            bookStack.Push("Book 4");

            

            // Display all books in the stack (top to bottom)
            Console.WriteLine("Books in the stack:");
            foreach (var book in bookStack)
            {
                Console.WriteLine(book);
            }

            // Pop and process books from the stack
            while (bookStack.Count > 0)
            {
                string currentBook = bookStack.Pop();
                Console.WriteLine($"\nProcessing: {currentBook}");
                // Simulate some work being done with the book
                System.Threading.Thread.Sleep(2000); // 1 second delay
                Console.WriteLine("Book processed.");
            }

            Console.WriteLine("\nAll books have been processed.");

            Console.ReadLine();
        }
    }
}
