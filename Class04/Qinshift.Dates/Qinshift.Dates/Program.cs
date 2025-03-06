Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n=========== Working With Dates ==============\n\n");
Console.ResetColor();

#region Creating DateTime
Console.WriteLine("\n=================Creating DateTime===================\n");

// 1) Creating an empty DateTime

DateTime emptyDateTime = new DateTime(); // default value is 1/1/0001 00:00:00
Console.WriteLine($"Empty DateTime: {emptyDateTime}");

// 2) Creating a costume DateTime

DateTime costumeDateTime = new DateTime(2021, 12, 31);
Console.WriteLine($"Costume DateTime: {costumeDateTime}");

// 3) Creating a current DateTime with the current Date

DateTime currentDateTime = DateTime.Today;
Console.WriteLine($"Current DateTime: {currentDateTime}");

// 4) Creating a current DateTime with the current Date and Time

DateTime currentDateTimeWithTime = DateTime.Now;
Console.WriteLine($"Current DateTime with Time: {currentDateTimeWithTime}"); // Local Time
Console.WriteLine($"Current DateTime with Time: {DateTime.UtcNow}"); // UTC Time - Greenwich Mean Time



#endregion



#region Parsing DateTime
Console.WriteLine("\n=================Parsing DateTime===================\n");
string stringDate = "12-15-2024";
DateTime.TryParse(stringDate, out DateTime parsedDateTime);
Console.WriteLine($"Parsed DateTime: {parsedDateTime}");



#endregion



#region DateTime Properties
Console.WriteLine("\n=================DateTime Properties===================\n");

DateTime currentDateAndTime = DateTime.Now;
int month = currentDateAndTime.Month;
Console.WriteLine(month);

Console.WriteLine($"Day: {currentDateAndTime.Day}");
Console.WriteLine($"DayOfWeek: {currentDateAndTime.DayOfWeek}");
Console.WriteLine($"DayOfYear: {currentDateAndTime.DayOfYear}");
Console.WriteLine($"Ticks: {currentDateAndTime.Ticks}"); // 1 tick = 100 nanoseconds xD



#endregion




#region DateTime Methods
Console.WriteLine("\n=================DateTime Methods===================\n");

// 1) Adding or removing days to a DateTime date
DateTime addedDays = currentDateAndTime.AddDays(2);
Console.WriteLine($"Added Days: {addedDays}");
Console.WriteLine($"Removed Days: {addedDays.AddDays(-5)}");

// 2) Adding or removing months to a DateTime date
DateTime addedMonths = currentDateAndTime.AddMonths(5);
Console.WriteLine($"Added Months: {addedMonths}");


// same for years, hours, minutes, seconds, milliseconds, etc. 






#endregion



#region Formating Dates
Console.WriteLine("\n=================Formating Dates===================\n");
string dateFormat1 = currentDateAndTime.ToString("dd/MM/yyyy");
Console.WriteLine($"Date Format 1: {dateFormat1}");
string dateFormat2 = currentDateAndTime.ToString("dddd dd MMMM yyyy HH:mm:ss");
Console.WriteLine($"Date Format 2: {dateFormat2}");
string dateFormat3 = currentDateAndTime.ToString("dddd dd MMMM yyyy HH:mm:ss tt");
Console.WriteLine($"Date Format 3: {dateFormat3}");
string dateFormat4 = currentDateAndTime.ToString("dddd dd MMMM yyyy HH:mm:ss tt zzz");
Console.WriteLine($"Date Format 4: {dateFormat4}");
string dateFormat5 = string.Format("Today is {0:dddd dd MMMM yyyy HH:mm:ss tt zzz}", currentDateAndTime);
Console.WriteLine($"Date Format 5: {dateFormat5}");


#endregion



#region Bonus
Console.WriteLine("\n=================Bonus===================\n");
// *** Comparing Dates ***
DateTime date1 = new DateTime(2021, 12, 31);
DateTime date2 = new DateTime(2021, 12, 31);
Console.WriteLine(date1 == date2); // True

// *** Calculating the difference between two dates ***
DateTime dateInstance1 = new DateTime(2021, 12, 31);
DateTime dateInstance2 = new DateTime(2022, 12, 31);
TimeSpan difference = dateInstance2 - dateInstance1;
Console.WriteLine($"Difference: {difference.Days} days");





#endregion