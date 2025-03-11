using Qinshift.ExerciseTwo;

Dog dog = new Dog();
Console.WriteLine("Enter Dog Name: ");
dog.Name = Console.ReadLine();
Console.WriteLine("Enter Dog Breed: ");
dog.Breed = Console.ReadLine();
Console.WriteLine("Enter Dog Color: ");
dog.Color = Console.ReadLine();

while (true)
{
    Console.WriteLine($"What do you want the {dog.Name} to do? ");
    Console.WriteLine("1. Eat");
    Console.WriteLine("2. Play");
    Console.WriteLine("3. Chase Tail");
    Console.WriteLine("0. Exit");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int choice))
    {
        if (choice == 0)
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            break; 
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine(dog.DogEat());
                break;
            case 2:
                Console.WriteLine(dog.Play());
                break;
            case 3:
                Console.WriteLine(dog.ChaseTail());
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

