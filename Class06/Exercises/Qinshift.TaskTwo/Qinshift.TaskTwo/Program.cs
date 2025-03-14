class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Messages { get; set; }

    public User(string username, string password, string[] messages)
    {
        
        Username = username;
        Password = password;
        Messages = messages;
    }
    public User(int id, string username, string password, string[] messages)
    {
        Id = id;
        Username = username;
        Password = password;
        Messages = messages;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Hard-coded users
        User[] users = new User[]
        {
            new User(1, "Username1", "password1", new string[] { "Message1", "Message2" }),
            new User(2, "Username2", "password2", new string[] { "Message1" }),
            new User(3, "Username3", "password3", new string[] { "Message1", "Message2", "Message3" })
        };

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // existing user login
                    Console.Write("Enter your username: ");
                    string loginUsername = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string loginPassword = Console.ReadLine();

                    bool userFound = false;
                    foreach (User user in users)
                    {
                        if (user.Username == loginUsername && user.Password == loginPassword)
                        {
                            Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                            foreach (var message in user.Messages)
                            {
                                Console.WriteLine(message);
                            }
                            userFound = true;
                            break;
                        }
                    }

                    if (!userFound)
                    {
                        Console.WriteLine("Error: User not found or incorrect password.");
                    }
                    break;

                case "2":
                 // new
                   
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();

                  
                    bool usernameExists = false;
                    foreach (var user in users)
                    {
                        if (user.Username == username)
                        {
                            usernameExists = true;
                            break;
                        }
                    }

                    if (usernameExists)
                    {
                        Console.WriteLine("Error: A user with that username already exists.");
                    }
                    else
                    {
                        
                        Array.Resize(ref users, users.Length + 1);
                        User newUser = new User(username, password, new string[] { });
                        users[users.Length - 1] = newUser;
                        newUser.Id = users.Length;

                        Console.WriteLine("Registration complete! Users:");
                        foreach (var user in users)
                        {
                            Console.WriteLine($"{user.Id} {user.Username}");
                        }
                    }
                    break;

                case "3":
                
                    continueProgram = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice, please select 1, 2, or 3.");
                    break;
            }
        }
    }
}