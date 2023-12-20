using System;
using System.Collections;
using System.Collections.Concurrent;

namespace collectonsList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();

            //List<int> numnerList = new List<int>(); Generic provide type safety

            Console.WriteLine("ArrayList Demo");
            Console.WriteLine("==============");

            // Add elements to the ArrayList
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            numbersList.Add(50);

            #region ArrayList with different types
            //ArrayList numbersList2 = new ArrayList() { "1", 2, 4, "something" };

            //foreach (object number in numbersList2)
            //{
            //    Console.Write(number );
            //}
            // Display the contents of the ArrayList
            #endregion

            Console.WriteLine("Elements in the List:");

            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Accessing elements by index
            int firstElement = (int)numbersList[0];
            int thirdElement = (int)numbersList[2];

            Console.WriteLine($"First Element: {firstElement}");
            Console.WriteLine($"Third Element: {thirdElement}");

            // Finding the index of an element
            int indexOf40 = numbersList.IndexOf(40);
            Console.WriteLine($"Index of 40: {indexOf40}");

            // Removing elements
            numbersList.Remove(30);

            numbersList.RemoveAt(0);

            // Display the updated contents of the ArrayList
            Console.WriteLine("Updated elements in the ArrayList:");

            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Clearing the ArrayList
            numbersList.Clear();

            Console.WriteLine("List cleared. Count: " + numbersList.Count);

            Console.ReadLine();
        }
    }
}
