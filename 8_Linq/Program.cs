using System;
using System.Collections.Generic;
using linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var DaysInMonth = new Dictionary<string, int>() {

            { "Jan", 31 },

            { "Feb", 28 },

            { "Mar", 31 },

            { "Apr", 30 },

            { "May", 31 },

            { "Jun", 30 },

            { "Jul", 31 },

            { "Aug", 31 },

            { "Sep", 30 },

            { "Oct", 31 },

            { "Nov", 30 },

            { "Dec", 31 }

};


            var monthsByLength =

                                 from string key in DaysInMonth.Keys

                                 orderby DaysInMonth[key] ascending

                                 select key;

            Console.WriteLine("Months ordered by number of days:");

            foreach (var month in monthsByLength)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine("First month: " + monthsByLength.First());


            var months30 =

                         from string key in DaysInMonth.Keys

                         where DaysInMonth[key] == 31

                         select key;

            foreach (var month in months30) Console.WriteLine(month);


           // Using lamda function

            var months30code = DaysInMonth.Where(month => month.Value == 30).Select(month => month.Key);

            foreach (var month in months30code) Console.WriteLine("   " + month);
        }
    }
}
