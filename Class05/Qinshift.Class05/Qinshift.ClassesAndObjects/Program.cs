using Qinshift.ClassesAndObjects.models;


#region Simple class definition and usage



string[] array = new string[1];
//Console.WriteLine(array); => System.String[] types the data type of the array
User user = new User();
user.UserName = "Martin";
user.Password = "12345";
Console.WriteLine(user.UserName);

#endregion



#region Classes and Objects

Person bob = new Person();
bob.FirstName = "Bob";
bob.LastName = "Bobsky";
bob.Age = 30;
//bob.SSN = 1234567890; // This is not possible because SSN is private
bob.Talk("Hello there, we are learining classes and objects");


Person Jill = new Person("Jill", "Jillsky", 25); // This is how we can use constructor with parameters
Jill.Talk("Hi there");
Console.WriteLine(Jill.GetSSN());



Person martin = new Person
{
    FirstName = "Martin",
    LastName = "Lutovski",
    Age = 35

    // This is how we can create an object and set properties at the same time - constructor notation
};

#endregion



