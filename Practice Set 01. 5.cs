using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Circle Calculator ===");
            Console.WriteLine("[A] Compute Area");
            Console.WriteLine("[P] Compute Perimeter (Circumference)");
            Console.WriteLine("[X] Exit");
            Console.Write("Enter your choice: ");

            string raw = Console.ReadLine()?.Trim() ?? "";
            if (raw.Length == 0) { Console.WriteLine("Please enter A, P, or X."); continue; }

            char choice = char.ToUpper(raw[0]);

            if (choice == 'X')
            {
                Console.WriteLine("Exiting program... Goodbye!");
                break;
            }

            if (choice != 'A' && choice != 'P')
            {
                Console.WriteLine("Invalid choice! Please enter A, P, or X.");
                continue;
            }

            double radius = ReadNonNegativeDouble("Enter the radius of the circle: ");

            if (choice == 'A')
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine($"Area = π × r² = {area:F4}");
            }
            else // P
            {
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine($"Perimeter = 2 × π × r = {perimeter:F4}");
            }
        }
    }

    static double ReadNonNegativeDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? "").Trim();

            if (double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double value) ||
                double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                if (value >= 0) return value;
                Console.WriteLine("Radius cannot be negative. Try again.");
            }
            else
            {
                Console.WriteLine("Invalid number. Use digits and a decimal point/comma only. Try again.");
            }
        }
    }
}