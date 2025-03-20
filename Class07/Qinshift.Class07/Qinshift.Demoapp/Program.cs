using Qinshift.Library.Enums;
using Qinshift.Library.Services;

#region Enum
Console.WriteLine((int)Days.Thursday);

#endregion

#region Enums and how to use them.
static void IsLectureDay(Days day)
{
    if (day == Days.Tuesday || day == Days.Thursday)
    {
        Console.WriteLine("You have lectures today!");
    }
    else
    {
        Console.WriteLine("You have to study hard today!");
    }
}

#endregion

IsLectureDay(Days.Monday);
IsLectureDay(Days.Tuesday);

#region Converting enums

Console.WriteLine("============== Converting enums ===================");

int num = 2;

Days day = (Days)num;

Console.WriteLine(day);

Console.WriteLine("You give me a number, I'll give you a month name:");

int userInput = int.Parse(Console.ReadLine());

// Get an enum value from an integer
//Months monthName = (Months)userInput;

//Console.WriteLine(monthName);
// Do the same by using service method
MonthService monthService = new MonthService();
Months.September.GetMonthOutOfNumber(userInput);



// Get a number value from an enum
Months january = Months.January;
int firstMonth = (int)january;



// Get a string value from an enum
string july = Months.July.ToString();
Console.WriteLine($"July month: {july}");




#endregion