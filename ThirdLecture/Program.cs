
// ReSharper disable InvalidXmlDocComment
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the third lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// IF Statements
//===============================================================//


/// PRAKTIKA
//===============================================================//
/// Uzduotis Nr.1

Console.WriteLine("Number relevance to 100");

Console.Write("Enter a number: ");
var inputNumber = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.NumberRelevantToHundred(inputNumber));

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Weekday number to weekday name");

Console.Write("Enter a weekday number: ");
var dayNumber = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.DayNumberToDayName(dayNumber));

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.2

Console.WriteLine("Number even or divides by 5");
Console.Write("Enter a number: ");
var divide = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.NumberEvenOrDividesByFive(divide));

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Temperature");
Console.Write("Enter a temperature: ");
var temps = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.Temperature(temps));

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.3

Console.Write("When did you get up? ");
var gotUp = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.WhenDidYouGetUp(gotUp));

Console.WriteLine();
Console.WriteLine();

Console.Write("Enter your password: ");
var pass = "Password";
var passInput = Console.ReadLine();

Console.WriteLine(Methods.Password(passInput));

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.4

Console.Write("Enter your age: ");
var age = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.TestAge(age));

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.5

Console.Write("Enter year: ");
var leapYear = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.LeapYear(leapYear));

//===============================================================//
/// Uzduotis Nr.6

Console.Write("FizzBuzz: ");
var fiz = Int32.Parse(Console.ReadLine());

Console.WriteLine(Methods.FizzBuzz(fiz));

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.7

Console.Write("Enter two numbers: ");
var num1 = Int32.Parse(Console.ReadLine());
var num2 = Int32.Parse(Console.ReadLine());

if (num1 > 0 && num2 > 0)
    Console.WriteLine("Skaiciai teigiami");
else if (num1 > 0 || num2 > 0)
    Console.WriteLine("Vienas teigiamas");
else Console.WriteLine("Nei vienas teigiamas");

Console.WriteLine();
Console.WriteLine();

Console.Write("Iveskite tris skaicius: ");
var num3 = Int32.Parse(Console.ReadLine());
var num4 = Int32.Parse(Console.ReadLine());
var num5 = Int32.Parse(Console.ReadLine());

if (num3 == num4 && num4 == num5 && num3 == num5)
    Console.WriteLine("Visi lygus");
else if (num3 == num4 || num4 == num5 || num3 == num5)
    Console.WriteLine("Du skaiciai lygus");
else Console.WriteLine("Nei vienas nelygus");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.8

Console.Write("Iveskite tris skaicius: ");

int sums;
var a = Int32.Parse(Console.ReadLine());
var b = Int32.Parse(Console.ReadLine());
var c = Int32.Parse(Console.ReadLine());

var isAPos = a > 0;
var isBPos = b > 0;
var isCPos = c > 0;

if (isAPos && isBPos && isCPos)
    Console.WriteLine(sums = a + b + c);
else if (isAPos && isBPos)
    Console.WriteLine(sums = a + b);
else if (isAPos && isCPos)
    Console.WriteLine(sums = a + c);
else if (isBPos && isCPos)
    Console.WriteLine(sums = b + c);
else Console.WriteLine("Neimanoma suskaiciuoti sumos");

Console.WriteLine();
Console.WriteLine();

Console.Write("Iveskite metus: ");
var year = Int32.Parse(Console.ReadLine());
Console.Write("Iveskite menesi (skaicius): ");
var month = Int32.Parse(Console.ReadLine());

if (month == 1 || month == 2 || month == 3)
    Console.WriteLine("Saltas laikotarpis");
else if (month == 6 || month == 7 || month == 8)
    Console.WriteLine("Karstas laikotarpis");
else Console.WriteLine("Vidutinis laikotarpis");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.9

Console.Write("Iveskite tris skirtingus skaicius, atitinkancius trikampio krastiniu ilgius: ");

var firstNum = Int32.Parse(Console.ReadLine());
var secondNum = Int32.Parse(Console.ReadLine());
var thirdNum = Int32.Parse(Console.ReadLine());

var isFirstLonger = (firstNum > thirdNum) || (firstNum > secondNum);
var isSecondLonger = (secondNum > firstNum) || (secondNum > thirdNum);
var isThirdLonger = (thirdNum > firstNum) || (thirdNum > secondNum);

if ((isFirstLonger && isSecondLonger) || (isSecondLonger && isThirdLonger) || (isFirstLonger && isThirdLonger))
    Console.WriteLine("Galima sudaryti trikampi");
else Console.WriteLine("Negalima sudaryti trikampio");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.10

Console.WriteLine("Pienas: 1 Eur, Sviestas: 2 Eur, Duona: 3 Eur");

var milkPrice = 1;
var butterPrice = 2;
var breadPrice = 3;

double prodA;
double prodB;
double sum;

Console.Write("Pasirinkite pirmaji produkta: ");
var firstPick = Console.ReadLine();

if (firstPick.ToLower() == "pienas")
    prodA = milkPrice;
else if (firstPick.ToLower() == "sviestas")
    prodA = butterPrice;
else if (firstPick.ToLower() == "duona")
    prodA = breadPrice;
else
{
    prodA = 0;
    Console.WriteLine("Blogai ivestas pasirinkimas");
}

Console.Write("Pasirinkite antra produkta: ");
var secondPick = Console.ReadLine();

if (secondPick.ToLower() == "pienas")
    prodB = milkPrice;
else if (secondPick.ToLower() == "sviestas")
    prodB = butterPrice;
else if (secondPick.ToLower() == "duona")
    prodB = breadPrice;
else
{
    prodB = 0;
    Console.WriteLine("Blogai ivestas pasirinkimas");
}

if (prodA == prodB)
    sum = (prodA + prodB) * 0.9;
else
    sum = prodA + prodB;

Console.Write("Ar turite lojalumo kortele (T/N): ");
var thirdPick = Console.ReadLine();
if (thirdPick.ToUpper() == "T")
    Console.WriteLine($"Galutine suma: {sum *= 0.9} Eur");
else if (thirdPick.ToUpper() == "N")
    Console.WriteLine($"Galutine suma: {sum}");
else
    Console.WriteLine("Netinkamas pasirinkimas");


//===============================================================//
/// Uzduotis Nr.11


//===============================================================//
/// METHODS

class Methods
{
    public static string NumberRelevantToHundred(int number)
    {
        if (number > 100)
            return "More than 100";

        if (number == 100)
            return "Equal to 100";
        
        return "Less than 100";
    }
    
    public static string DayNumberToDayName(int dayNumber)
    {
        if (dayNumber == 1) return "Monday";
        if (dayNumber == 2) return "Tuesday";
        if (dayNumber == 3) return "Wednesday";
        if (dayNumber == 4) return "Thursday";
        if (dayNumber == 5) return "Friday";
        if (dayNumber == 6) return "Saturday";
        if (dayNumber == 7) return "Sunday";
        return $"Invalid day number: {dayNumber}";
    }
    
    public static string NumberEvenOrDividesByFive(int divide)
    {
        if (divide % 2 == 0 && divide % 5 == 0)
            return "Skaicius lyginis ir dalijasi is 5";
        if (divide % 2 == 0)
            return "Skaicius lyginis";
        if (divide % 5 == 0)
            return "Skaicius dalijasi is 5";
        return "Skaicius neatitinka salygu";
    }
    
    public static string Temperature(int temps)
    {
        if (temps <= 0)
            return "Salta";
        if (temps > 0 && temps <= 20)
            return "Vesu";
        return "Karsta";
    }
    
    public static string WhenDidYouGetUp(int gotUp)
    {
        if (gotUp >= 0 && gotUp < 12)
            return "Good morning!";
        if (gotUp >= 12 && gotUp < 18)
            return "Good afternoon!";
        if (gotUp >= 18 && gotUp <= 24)
            return "Good evening!";
        return "Entered time is not in 24h format";
    }

    public static string Password(string pass)
    {
        if (pass is "Password" or "Mellon")
            return "Logged in successfully!";
        if (pass == "01101001 01101110")
            return "Hacked...";
        return "Incorrect password, please try again later...";
    }

    public static string TestAge(int age)
    {
        if (age < 18)
            return "You have minor discount";
        if (age >= 18 && age < 65)
            return "You're an adult";
        if (age >= 65)
            return "You have senior discount";
        return "Incorrect age";
    }
    
    public static string LeapYear(int leapYear)
    {
        if ((leapYear % 4 == 0 && leapYear % 100 != 0) || leapYear % 400 == 0)
            return "It's a leap year!";
        return "It's not a leap year!";
    }

    public static string FizzBuzz(int fiz)
    {
        if (fiz % 3 == 0 && fiz % 5 == 0)
            return "BazingaPop";
        if (fiz % 3 == 0)
            return "Bazinga";
        if (fiz % 5 == 0)
            return "Pop";
        return fiz.ToString();
    }
    
    
}