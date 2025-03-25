using Qinshift.Generics.Models;
Console.WriteLine("===== Generics =====");





#region List - Generic Collection


// Declaration and initialization of a List of integers

string[] namesArr = new string[1] { "Martin" };



List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(-3);
numbers.Add(3454);

List<string> names = new List<string>() {"Martin", "Ana", "Frose", "Angel" };
names.Add("Luis");
names.Add("Robert");


List<bool> data = [ true, false, true, true, false ]; // Available in latest C# versions
                          // otherwise use List<bool> data = new List<bool> { true, false, true, true, false };

foreach (string name in names)
{
    Console.WriteLine(name);
}

for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

List<User> users = new List<User>
{
    new User { FirstName = "Martin", LastName = "Lutovski" },
    new User { FirstName = "Ana", LastName = "Melo" },
    new User { FirstName = "Frose", LastName = "Melo" },
    new()  { FirstName = "Angel", LastName = "Melo" }


};

foreach (User user in users)
{
    Console.WriteLine($"{user.FirstName} {user.LastName}");
}


#endregion



#region Dictionary - Generic Collection


// Declaration and initialization of a Dictionary of integers and strings

static void PrintDictionary(Dictionary<int, string> students)
{
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Key}. {student.Value}");
    }
}


static void PrintTodos(Dictionary<string, bool> todos)
{
    foreach (var todo in todos)
    {
        Console.WriteLine($"{todo.Key} {(todo.Value ? "Done" : "Todo")}");
    }
}

Dictionary<int, string> students = new Dictionary<int, string>() {
    { 1, "Martin" },
    { 2, "Frose" },
    { 3, "Ana" }    
};


students.Add(4, "Angel");
students.Add(5, "Sandra");

Console.WriteLine("Printing students");

PrintDictionary(students);


Dictionary<string, bool> todos = new Dictionary<string, bool>() {
    { "Get my dog for a walk!", false },
    { "Write homework", false },
    { "Go to the gym", true }
};



Console.WriteLine("Printing my todos");
PrintTodos(todos);


students.ContainsKey(3); // true
students.ContainsValue("Martin"); // true

students.Remove(2); // Removes the student with key 2, it doesnt reindex the dictionary, so the key 3 is still there.
Console.WriteLine("Printing students after removing student with key 2");
PrintDictionary(students);

students.TryGetValue(2, out string studentName); // studentName will be "Frose" if the key 2 exists, otherwise it will be null
Console.WriteLine($"Student with key 2 is {studentName}");
#endregion



#region Queue - Generic Collections

Queue<int> Queue = new Queue<int>();
Queue.Enqueue(1);
Queue.Enqueue(2);
Queue.Enqueue(3);
Queue.Enqueue(4);


// remove item from queue

Queue.Dequeue();
Console.WriteLine("Queue items");

foreach (var item in Queue)
{
    Console.WriteLine($"The next item in the queue is: {Queue.Peek()}");
}








#endregion