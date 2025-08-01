using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main()
        {
            // ╔══════════════════════════════════════╗
            // ║        GRADE CALCULATOR              ║
            // ║     Personal Project by: Marg        ║
            // ║     In loving memory & support       ║
            // ║     For Marg — All the Best!         ║
            // ╚══════════════════════════════════════╝
            // 
            // Purpose: Converts a numerical grade (0-100)
            //          into a letter grade (A, B, C, D, F)
            // Features: Colorful output, input validation,
            //           personalized feedback, and love.

          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.WriteLine("╔════════════════════════════════════════════╗");
          Console.WriteLine("║         MARG's GRADE CALCULATOR            ║");
          Console.WriteLine("║           Made with care by:               ║");
          Console.WriteLine("║               Marguerita                   ║");
          Console.WriteLine("║                                            ║");
          Console.WriteLine("║                                            ║");
          Console.WriteLine("║        Form Marguerita — All the Best!     ║");
          Console.WriteLine("╚════════════════════════════════════════════╝");
          Console.ResetColor();
           

            Console.WriteLine();
            Console.WriteLine("Enter your numerical grade (0-100) and I'll tell you the letter grade!");
            Console.WriteLine();

            // Step 1: Get input from the user
            Console.Write("📝 Your grade: ");
            string? input = Console.ReadLine();

            // Step 2: Validate if input is a valid number
            if (!double.TryParse(input, out double grade))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Oops! That's not a valid number. Please enter digits only.");
                Console.ResetColor();
                return;
            }

            // Step 3: Ensure grade is within valid range (0-100)
            if (grade < 0 || grade > 100)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("⚠️  Grade must be between 0 and 100.");
                Console.ResetColor();
                return;
            }

            // Step 4: Determine the letter grade and personalized feedback
            char letterGrade;
            string feedback = "";

            if (grade >= 90)
            {
                letterGrade = 'A';
                feedback = "🎉 Excellent! You crushed it!";
                Console.ForegroundColor = ConsoleColor.Green;
            } 
            else if (grade >= 80)
            {
                letterGrade = 'B';
                feedback = "👏 Great job! Solid work.";
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
                feedback = "Not bad! You passed!";
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
                feedback = "Okay, you got this. Keep trying!";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                letterGrade = 'F';
                feedback = "💔";
                Console.ForegroundColor = ConsoleColor.Red;
            }

            // Step 5: Display the result with style and emotion
            Console.WriteLine();
            Console.WriteLine("📊 RESULT:");
            Console.WriteLine($"   Your grade: {grade:F1} → {letterGrade}");
            Console.WriteLine($"   {feedback}");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Thanks for using Marguerita's Grade Calculator!");
            Console.WriteLine("Form Marg,You've got this. All the best!");
        }
    }
}