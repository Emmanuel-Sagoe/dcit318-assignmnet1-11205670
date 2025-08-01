using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        bool continueApp = true;

        Console.WriteLine("=== Movie Ticket Price Calculator ===");

        while (continueApp)
        {
            int age = -1;
            bool validInput = false;

            
            while (!validInput)
            {
                Console.Write("\nEnter your age: ");
                string input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out age))
                {
                    if (age >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid age. Age cannot be negative.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            
            int price = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"🎟️ Your ticket price is: GHC{price}");

            
            Console.Write("\nDo you want to enter another age? (Y/N): ");
            string response = Console.ReadLine()?.Trim();

            if (!response.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                continueApp = false;
                Console.WriteLine("\nThank you for using the Ticket Price Calculator. ");
            }
        }
    }
}
