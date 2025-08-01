using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        bool continueApp = true;

        Console.WriteLine("=== Grade Calculator ===");

        while (continueApp)
        {
            int grade = -1;
            bool validInput = false;

            
            while (!validInput)
            {
                Console.Write("\nEnter your grade (0 - 100): ");
                string input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                }
            }

            
            string letterGrade = grade switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            Console.WriteLine($"Your letter grade is: {letterGrade}");

           
            Console.Write("\nDo you want to enter another grade? (Y/N): ");
            string response = Console.ReadLine()?.Trim();

            if (!response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                continueApp = false;
                Console.WriteLine("\nExiting Grade Calculator. Goodbye! ");
            }
        }
    }
}

