
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n================== STRINGS ==================\n");
Console.ResetColor();


#region String Concatenation

Console.WriteLine("\n\n============== String Concatenation ==============\n");

// Normal strings
string firstName = "Bob";
string lastName = "Bobsky";

// String Concatenation

// 1) using '+' operator
string hello1 = "Hello " + firstName + " " + lastName;
Console.WriteLine(hello1);
// 2) *using String Interpolation*
string hello2 = $"Hello {firstName} {lastName}";
Console.WriteLine(hello2);
// 3) using string.Format
string hello3 = string.Format("Hello {0} {1}", lastName, firstName);
Console.WriteLine(hello3);
// 4) using String.Concat
string hello4 = string.Concat("Hello ", firstName, " ", lastName);
Console.WriteLine(hello4);
// 5) using StringBuilder (only for info, will be explained in detail further on..)

#endregion


#region String Formatting

Console.WriteLine("\n\n============== String Formatting ==============\n");

// *Currency Formatting*

string currency = string.Format("Price: {0:C}", 123.23);
Console.WriteLine(currency);

// *Percentage Formatting*

string percent = string.Format("Percent: {0:P}", 0.23);
Console.WriteLine(percent);
Console.WriteLine(string.Format("Percent: {0:P0}", 0.23));




// *Custom Formatting*
string customPhoneNumberFormat = string.Format("Phone Number: {0:0##-###-###}", 071273260); // 071-273-260
Console.WriteLine(customPhoneNumberFormat);

int number = 1234567;
string customNumberFormat = string.Format("Number: format {0:#,###}", number); 
Console.WriteLine(customNumberFormat);

// *Alignment Formatting*

string customAlignment = string.Format("| {0, 10} | {1, 20} |", "Id", "Order");
Console.WriteLine(customAlignment);




#endregion

#region Escaping Reserved Characters

Console.WriteLine("\n\n============== Escaping Reserved Characters ==============\n");
// string escape1 = "Check your c:\ drive"; // error
// string escape2 = "We will have \"fair\" elections"; // error
// string escape3 = "The \\n sign means: new line";  // error
// Console.WriteLine(escape3);

// 1) Escaping with "\" (backslash)
string escape1 = "Check your c:\\ drive";
string escape2 = "We will have \"fair\" elections";
string escape3 = "The \\n sign means: new line";
Console.WriteLine(escape1);
Console.WriteLine(escape2);
Console.WriteLine(escape3);

// 2) Escaping a whole string with '@' (verbatim string)
escape1 = @"Check your c:\ drive";
escape2 = @"We will have ""fair"" elections";
escape3 = @"The \n sign means: new line";

#endregion



#region Using ToString()

Console.WriteLine("\n\n============== ToString() ==============\n");


int someNumber = 234334;
bool isTrue = false;

// Convert other dataypes to string
string someNumberString = someNumber.ToString();
string isTrueString = isTrue.ToString();

Console.WriteLine(someNumberString); 
Console.WriteLine(isTrueString);

string formatedString = someNumber.ToString("#,##0");
Console.WriteLine(formatedString);



#endregion


#region String Methods

Console.WriteLine("\n\n============== String Methods ==============\n");

string ourString = "   We are learning C# and it is FUN and EASY. Okay, maybe just FUN.    ";
Console.WriteLine(ourString);


// 1) ToUpper() and ToLower()
Console.WriteLine(ourString.ToUpper());
Console.WriteLine(ourString.ToLower());


// 2) Length (property)

Console.WriteLine(ourString.Length);


// 3) Split 

string[] splitedString = ourString.Split('.');
Console.WriteLine("SPLITED");
Console.WriteLine(splitedString[0]);
Console.WriteLine(splitedString[1]);
Console.WriteLine(splitedString[2]);


// 4) Join

string joinedString = string.Join(" .(PERIOD)", splitedString); 
Console.WriteLine(joinedString);


// 5) Trim

string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);


// 6) Startswith and Endswith

bool startsWith = trimmedString.StartsWith("We");
Console.WriteLine(startsWith);

// 7) Contains

bool containsString = trimmedString.Contains("learning");
Console.WriteLine(containsString);

// 8) String is Null or Empty
Console.WriteLine("==== NULL OR EMPTY");
Console.WriteLine(string.IsNullOrEmpty("")); // true
Console.WriteLine(string.IsNullOrEmpty(null)); // true
Console.WriteLine(string.IsNullOrEmpty(" ")); // false
Console.WriteLine(string.IsNullOrWhiteSpace(" ")); // true
Console.WriteLine(string.IsNullOrWhiteSpace(""));  // true
Console.WriteLine(string.IsNullOrWhiteSpace("    d")); //   false


// 9) Substring

string subString = ourString.Substring(5, 16);
Console.WriteLine(subString);



#endregion





Console.ReadLine();
