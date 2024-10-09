
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

Console.WriteLine("Skaiciaus lyginimas su 100");

Console.Write("Iveskite norima skaiciu: ");
var inputNumber = Int32.Parse(Console.ReadLine());

if (inputNumber > 100)
    Console.WriteLine("Skaicius yra didesnis nei 100");
else if (inputNumber == 100)
    Console.WriteLine("Skaicius yra lygus 100");
else
    Console.WriteLine("Skaicius yra mazesnis nei 100");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Savaites diena pagal skaiciu");

Console.Write("Iveskite dienos skaiciu: ");
var dayNumber = Int32.Parse(Console.ReadLine());

if (dayNumber == 1) Console.WriteLine("Pirmadienis");
else if (dayNumber == 2) Console.WriteLine("Antradienis");
else if (dayNumber == 3) Console.WriteLine("Treciadienis");
else if (dayNumber == 4) Console.WriteLine("Ketvirtadienis");
else if (dayNumber == 5) Console.WriteLine("Penktadienis");
else if (dayNumber == 6) Console.WriteLine("Sestadienis");
else if (dayNumber == 7) Console.WriteLine("Sekmadienis");
else Console.WriteLine($"Neteisingas dienos skaicius: {dayNumber}");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.2

Console.WriteLine("Skaicius lyginis arba dalijasi is 5");
Console.Write("Iveskite norima skaiciu: ");
var divide = Int32.Parse(Console.ReadLine());

if (divide % 2 == 0 && divide % 5 == 0)
    Console.WriteLine("Skaicius lyginis ir dalijasi is 5");
else if (divide % 2 == 0)
    Console.WriteLine("Skaicius lyginis");
else if (divide % 5 == 0)
    Console.WriteLine("Skaicius dalijasi is 5");
else
    Console.WriteLine("Skaicius neatitinka salygu");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Temperatura");
Console.Write("Iveskite temperatura: ");
var temps = Int32.Parse(Console.ReadLine());

if (temps <= 0)
    Console.WriteLine("Salta");
else if (temps > 0 && temps <= 20)
    Console.WriteLine("Vesu");
else
    Console.WriteLine("Karsta");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.3

Console.Write("Kuria valanda pakilote ryte? ");
var gotUp = Int32.Parse(Console.ReadLine());

if (gotUp >= 0 && gotUp < 12)
    Console.WriteLine("Geros dienos!");
else if (gotUp >= 12 && gotUp < 18)
    Console.WriteLine("Geros popietes!");
else if (gotUp >= 18 && gotUp <= 24)
    Console.WriteLine("Gero vakaro!");
else
    Console.WriteLine("Ivesta valanda neatitinka 24h formato");

Console.WriteLine();
Console.WriteLine();

Console.Write("Iveskite slaptazodi: ");
var pass = "Password";
var passInput = Console.ReadLine();

if (passInput == pass || passInput == "Mellon")
    Console.WriteLine("Sekmingai prisijungete");
else if (passInput == "01101001 01101110")
    Console.WriteLine("Nulauzta...");
else
    Console.WriteLine("Slaptazodis neteisingas, prasome bandyti veliau");

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.4

Console.Write("Iveskite savo amziu: ");
var age = Int32.Parse(Console.ReadLine());

if (age < 18)
    Console.WriteLine("Jums priklauso nepilnamecio akcija");
else if (age >= 18 && age < 65)
    Console.WriteLine("Jus esate suauges");
else if (age >= 65)
    Console.WriteLine("Jums priklauso senjoro akcija");
else
    Console.WriteLine("Netinkamas amzius");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.5

Console.Write("Iveskite metus: ");
var leapYear = Int32.Parse(Console.ReadLine());

if ((leapYear % 4 == 0 && leapYear % 100 != 0) || leapYear % 400 == 0)
    Console.WriteLine("Tai yra keliamieji metai!");
else 
    Console.WriteLine("Tai nera keliamieji metai!");

//===============================================================//
/// Uzduotis Nr.6

Console.Write("FizzBuzz: ");
var fiz = Int32.Parse(Console.ReadLine());

if (fiz % 3 == 0 && fiz % 5 == 0)
    Console.WriteLine("BazingaPop");
else if (fiz % 3 == 0)
    Console.WriteLine("Bazinga");
else if (fiz % 5 == 0)
    Console.WriteLine("Pop");
else 
    Console.WriteLine(fiz);

Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.7

Console.Write("Iveskite du skaicius: ");
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


