using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🎟️ Ticket Price Calculator");
            Console.WriteLine("Enter your age:");

            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("❌ Invalid input. Please enter a valid age.");
                return;
            }

            decimal ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m;  // GHC7 for children and seniors
                Console.WriteLine($"✅ You qualify for a discount. Ticket price: GHC{ticketPrice}");
            }
            else
            {
                ticketPrice = 10.00m; // GHC10 regular price
                Console.WriteLine($"✅ Ticket price: GHC{ticketPrice}");
            }
        }
    }
}