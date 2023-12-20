using System;

namespace _2_enum
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Using the DaysOfWeek enum to declare variables
            DaysOfWeek today = (DaysOfWeek)4;
            DaysOfWeek favoriteDay = DaysOfWeek.Friday;

            Console.WriteLine("Today is: " + today);
            Console.WriteLine("My favorite day is: " + favoriteDay);
            Console.WriteLine("My favorite day is: " + (int)favoriteDay);

           // Enum comparison and switching

            if (today == DaysOfWeek.Wednesday)
            {
                Console.WriteLine("It's the middle of the week!");
            }
            else if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
            {
                Console.WriteLine("It's the weekend!");
            }
            else
            {
                Console.WriteLine("It's a regular weekday.");
            }

            // Enum iteration
            Console.WriteLine("\nAll days of the week:");




            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
               Console.WriteLine($"{day}");
            }
        }
    }
}


