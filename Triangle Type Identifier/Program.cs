using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        bool continueApp = true;

        Console.WriteLine("=== Triangle Type Identifier ===");

        while (continueApp)
        {
            double side1 = GetSideLength("Enter length of side 1: ");
            double side2 = GetSideLength("Enter length of side 2: ");
            double side3 = GetSideLength("Enter length of side 3: ");

            if (IsValidTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The lengths entered cannot form a valid triangle.");
            }

            Console.Write("\nDo you want to check another triangle? (Y/N): ");
            string response = Console.ReadLine()?.Trim();

            if (!response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                continueApp = false;
                Console.WriteLine("Exiting Triangle Type Identifier. Goodbye! ");
            }
        }
    }

    static double GetSideLength(string prompt)
    {
        double length = -1;
        bool valid = false;

        while (!valid)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim();

            if (double.TryParse(input, out length))
            {
                if (length > 0)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Length must be greater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        return length;
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        
        return a + b > c && a + c > b && b + c > a;
    }
}
