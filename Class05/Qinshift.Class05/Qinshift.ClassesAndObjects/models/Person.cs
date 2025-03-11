

namespace Qinshift.ClassesAndObjects.models
{
    public class Person
    {

        // This is how we add default constructor
        // Even if we dont specify it explicitly, it is there in C# classes => it is called default constructor, and added by default
        public Person()
        {
            // Constructor
            SSN = GenerateSSN();
        }

        public Person(string fName, string lName, int age)
        {
            // Constructor
            FirstName = fName;
            LastName = lName;
            Age = age;
            SSN = GenerateSSN();

            // Constructor for the Person class, it is a method that is called when we create an object of the class
        }

        // Properties must have type, access modifier and get/set
        public string FirstName { get; set; } = "Martin"; // Default value  - can be set if no value is provided
        public string LastName { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        private long GenerateSSN()
        {
            return new Random().Next(100000, 999999); // Get random number between the values given.
        }

        public long GetSSN()
        {
            return SSN;

            // Public method to access private property, it can be accessed from outside the class
        }

        public void Talk(string text )
        {
            Console.WriteLine($"The human named {FirstName} {LastName} says: {text}");
        }
    }
}
