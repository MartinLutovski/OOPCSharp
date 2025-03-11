
Human human = new Human();

Console.Write("Enter First Name: ");
human.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
human.LastName = Console.ReadLine();

Console.Write("Enter Age: ");

if (int.TryParse(Console.ReadLine(), out int age))
{
    human.Age = age;
}
else
{
    Console.WriteLine("Invalid input for age. Please enter a valid number.");
    return;
}





Console.WriteLine(human.GetPersonStats());

