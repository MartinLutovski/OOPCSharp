class TaskOne
{
    
    static void NumberStats(double number)
    {
        
        string positiveOrNegative = number < 0 ? "Negative" : "Positive";

   
        string oddEven = number % 2 == 0 ? "Even" : "Odd";


        string type = number == (int)number ? "Integer" : "Decimal";

        Console.WriteLine($"Stats for number: {number}");
        Console.WriteLine(positiveOrNegative);
        Console.WriteLine(type);
        Console.WriteLine(oddEven);
    }


    static bool IsValidNumber(string input, out double number)
    {
        return double.TryParse(input, out number);
    }

    static void Main(string[] args)
    {
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (IsValidNumber(userInput, out double number))
            {
                NumberStats(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            bool validChoice = false; 
            while (!validChoice)
            {
                Console.Write("Press 'Y' to try again or 'X' to exit: ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "X")
                {
                    continueLoop = false;
                    validChoice = true;
                }
                else if (choice == "Y")
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please press 'Y' to try again or 'X' to exit.");
                }
            }
        }
    }
}
