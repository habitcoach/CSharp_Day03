using System;

namespace MovieTicketApp
{
    struct MovieTicket
    {

        // Properties
        public string MovieName { get; set; }
        public string TheaterName { get; set; }
        public DateTime ShowTime { get; set; }
        public int NumberOfTickets { get; set; }
        public double TicketPrice { get; set; }

        // Constructor
        public MovieTicket(string movieName, string theaterName, DateTime showTime, double ticketPrice)
        {
            this.MovieName = movieName;
            this.TheaterName = theaterName;
            this.ShowTime = showTime;
            this.TicketPrice = ticketPrice;
            this.NumberOfTickets = 0;
        }

        // Method to purchase tickets
        public void BuyTickets(int numberOfTickets)
        {
            if (numberOfTickets <= 0)
            {
                Console.WriteLine("Invalid number of tickets. Please select at least 1 ticket.");
                return;
            }

            NumberOfTickets += numberOfTickets;
            double totalPrice = TicketPrice * NumberOfTickets;

            Console.WriteLine("\nSuccessfully added {0} ticket(s) to your cart.", numberOfTickets);
            Console.WriteLine("Total Price: ${0}", totalPrice);
        }

        // Method to display ticket details
        public void DisplayTicketDetails()
        {
            Console.WriteLine("\n--- Ticket Details ---");
            Console.WriteLine("Movie: {0}", MovieName);
            Console.WriteLine("Theater: {0}", TheaterName);
            Console.WriteLine("Show Time: {0}", ShowTime);
            Console.WriteLine("Number of Tickets: {0}", NumberOfTickets);
            Console.WriteLine("Ticket Price: ${0}", TicketPrice);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Ticket Booking!");
            Console.WriteLine("================================\n");

            // Create a movie ticket instance
            MovieTicket movieTicket = new MovieTicket("Movie Title", "Theater XYZ", DateTime.Now.AddHours(2), 100);

            

            // Display ticket details
            movieTicket.DisplayTicketDetails();

            // Prompt user to buy tickets
            Console.Write("\nEnter the number of tickets you want to buy: ");
            int numberOfTicketsToBuy = int.Parse(Console.ReadLine());

            // Buy tickets
            movieTicket.BuyTickets(numberOfTicketsToBuy);

            // Display updated ticket details
            movieTicket.DisplayTicketDetails();

            Console.WriteLine("\nThank you for using our Movie Ticket Booking system. Enjoy the show!");
        }
    }
}
