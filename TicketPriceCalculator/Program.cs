using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main()
        {
            // ╔════════════════════════════════════════════════╗
            // ║        🎟️ MARG'S TICKETING SYSTEM             ║
            // ║                                                ║
            // ║      Created by: Marguerita                    ║
            // ║     ID: 22011137                               ║
            // ║                                                ║
            // ║   💖 Welcome to "Marg's Ticketing" —           ║
            // ║      a warm, friendly cinema experience        ║
            // ║      made with care, just for you.             ║
            // ║                                                ║
            // ╚════════════════════════════════════════════════╝
            //
            // 📝 Purpose:
            //    - Calculates movie ticket price based on age.
            //    - Regular price: GHC10
            //    - Discount (GHC7) for children (≤12) and seniors (≥65)
            //
            //    Features:
            //    - Input validation (ensures valid age)
            //    - Color-coded output for clarity
            //    - Warm, personal messages
            //    - Dedicated to Marg — All the Best! 💖

            // Clear the console for a fresh, clean start
            Console.Clear();

            // Set a warm, inviting color for the header
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║        🎟️MARG'S TICKETING SYSTEM              ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║     Created by: Martin Gbebleou                ║");
            Console.WriteLine("║     ID: 22011137                               ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║       Welcome to Marg's Ticketing!             ║");
            Console.WriteLine("║      Enjoy the show — prices with care.        ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("🎬 Let's find your ticket price!");
            Console.WriteLine("Please enter your age, and I'll tell you the cost.");
            Console.WriteLine();

            // Step 1: Prompt the user for their age
            Console.Write("🧓 Enter your age: ");
            string? input = Console.ReadLine();

            // Step 2: Validate that the input is a valid integer
            //         If not, show an error and exit gracefully
            if (!int.TryParse(input, out int age))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Oops! That's not a valid age. Please enter numbers only.");
                Console.ResetColor();
                return; // Exit the program
            }

            // Step 3: Ensure the age is realistic (positive and reasonable)
            if (age <= 0 || age > 150)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️  Hmm... that age seems unusual. Please enter a valid age.");
                Console.ResetColor();
                return;
            }

            // Step 4: Determine the ticket price based on age
            //         - Children (12 and below): GHC7
            //         - Seniors (65 and above): GHC7
            //         - Everyone else: GHC10
            decimal ticketPrice;
            string discountMessage = "";

            if (age <= 12)
            {
                ticketPrice = 7.00m;
                discountMessage = "🎈 Yay! Child discount applied.";
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (age >= 65)
            {
                ticketPrice = 7.00m;
                discountMessage = "👵 Welcome, senior! Special price for you.";
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                ticketPrice = 10.00m;
                discountMessage = "🎟️  Regular ticket price.";
                Console.ForegroundColor = ConsoleColor.White;
            }

            // Step 5: Display the final result with warmth and clarity
            Console.WriteLine();
            Console.WriteLine("🎫 FINAL TICKET PRICE:");
            Console.WriteLine($"   Age: {age} years");
            Console.WriteLine($"   Price: GHC{ticketPrice:0.00}");
            Console.WriteLine($"   {discountMessage}");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thank you for visiting Marg's Ticketing!");
            Console.WriteLine(" Enjoy the movie.");
            Console.ResetColor();
        }
    }
}