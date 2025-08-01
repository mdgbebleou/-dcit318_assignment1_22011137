using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("📐 Triangle Type Identifier");
            Console.WriteLine("Enter the lengths of three sides of a triangle:");

            // Read side A
            Console.Write("Side A: ");
            if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0)
            {
                Console.WriteLine("❌ Side A must be a positive number.");
                return;
            }

            // Read side B
            Console.Write("Side B: ");
            if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0)
            {
                Console.WriteLine("❌ Side B must be a positive number.");
                return;
            }

            // Read side C
            Console.Write("Side C: ");
            if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0)
            {
                Console.WriteLine("❌ Side C must be a positive number.");
                return;
            }

            // Check triangle inequality
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("❌ These sides do not form a valid triangle.");
                return;
            }

            // Determine triangle type
            if (a == b && b == c)
            {
                Console.WriteLine("✅ This is an Equilateral triangle. (All sides equal)");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("✅ This is an Isosceles triangle. (Two sides equal)");
            }
            else
            {
                Console.WriteLine("✅ This is a Scalene triangle. (No sides equal)");
            }
        }
    }
}