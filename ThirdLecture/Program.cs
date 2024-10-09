
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