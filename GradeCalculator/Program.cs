using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🎓 Grade Calculator");
            Console.WriteLine("Enter a numerical grade (0-100):");

            // Read input
            string? input = Console.ReadLine();

            // Try to parse the input
            if (!double.TryParse(input, out double grade))
            {
                Console.WriteLine("❌ Invalid input. Please enter a number.");
                return;
            }

            // Check if grade is in valid range
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("❌ Grade must be between 0 and 100.");
                return;
            }

            // Determine letter grade
            char letterGrade;

            if (grade >= 90)
                letterGrade = 'A';
            else if (grade >= 80)
                letterGrade = 'B';
            else if (grade >= 70)
                letterGrade = 'C';
            else if (grade >= 60)
                letterGrade = 'D';
            else
                letterGrade = 'F';

            // Output result
            Console.WriteLine($"✅ Your letter grade is: {letterGrade}");
        }
    }
}