using Qinshift.ErrorHandling.Models;

#region Execeptions

// Type of General execption , all the information are kept in a variable so we can access them

Console.WriteLine("===== Number Example =====");
Console.WriteLine("Enter a number:");

try
{
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine($"You entered: {number}");
}
catch (Exception ex)
{
    Console.BackgroundColor = ConsoleColor.Red;

    Console.WriteLine("Wrong input. Try again with a valid input!");
    Console.WriteLine($"Exeption message: {ex.Message}");
    Console.ResetColor();
}
finally
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("The Number example finished!");
    Console.ReadLine();
    Console.ResetColor();
}


//Self throw exception on pourpose
Console.WriteLine("===== Self throw Exception =====");

Console.WriteLine("Enter a letter a or b:");

try
{
    string letter = Console.ReadLine().ToLower().Trim();
    if (letter == "a" || letter == "b")
    {
        Console.WriteLine($"You entered: {letter}");
    }
    else
    {   // if this is not inside try catch block, the program will crash, it will break the aplication
        // just like any exception thrown
        throw new Exception("You entered a wrong letter. Please enter a or b");
    }
}
catch (Exception ex)
{

    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}
finally
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Press any key to exit!");
    Console.ReadLine();
    Console.ResetColor();
}


Console.WriteLine("===== Handling specific exceptions! =====");

try
{
    Console.WriteLine("Enter a character!");
    char char1 = char.Parse(Console.ReadLine());
    Console.WriteLine($"You have entered the character: {char1}");
    int[] numbers = new int[2] { 1, 2 };
    //numbers[2] = 4;

    Console.WriteLine("Please enter two numbers:");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"The division of the numbers is: {+num1 / num2}");

}
catch (FormatException ex)
{
    Console.WriteLine("You have entered something other than a character!");
    throw;
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Array out of range. Cannot insert numbers in the array!");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"You can not divide by 0! {ex.Message}");

}
catch (Exception ex)
{
    Console.WriteLine("Error occured! Try again later!");

}




#endregion



#region Exception from methods

// Exception handling inside a function (lower level)
static void HumanSkill1(Human human)
{
    try
    {
        foreach (var item in human.Skills)
        {
            Console.WriteLine(item.Name);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch inside the function: {ex.Message}");
    }



}
// Exception handling outside a function (higher level)
static void HumanSkill2(Human human)
{


    foreach (var item in human.Skills)
    {
        Console.WriteLine(item.Name);
    }

}


    Human h1 = new Human() { Name = "Bob" };
HumanSkill1(h1);

try
{
    HumanSkill2(h1);
}
catch (Exception ex)
{

    Console.WriteLine($"Catch outside the function: {ex.Message}");
}



#endregion

