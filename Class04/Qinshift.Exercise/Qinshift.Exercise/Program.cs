namespace Qinshift.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a mode (+ or -): ");
                int mode = Convert.ToChar(Console.ReadLine());
                if (mode == '+')
                {
                    Console.WriteLine("Sum: " + Sum(numOne, numTwo));
                    break;
                }
                else if (mode == '-')
                {
                    Console.WriteLine("Sub: " + Sub(numOne, numTwo));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                

            }
            Console.ReadLine();

        }
        
        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static int Sub(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
    }
}
