


static void SearchPhoneBook(Dictionary<string, string> phoneBook, string name)
{

    if (!phoneBook.ContainsKey(name))
    {
        Console.WriteLine($"No such contact was found! Sorry!");
        return;
    }
    Console.WriteLine($"The phone number of {name} is: {phoneBook[name]}");
}



Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            { "Martin", "071-273-260" },
            { "Bob", "070-293-333" },
            { "Frose", "074-555-444" },
            { "David", "071-333-666" },
            { "Viktor", "077-111-222" }
        };


while (true)
{
  Console.WriteLine("Enter the name of the person you want to search for: ");
    string userInput = Console.ReadLine();

    SearchPhoneBook(phoneBook, userInput);

}