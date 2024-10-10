
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the Fourth lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// Switch cases

var day = 8;

switch (day)
{
    case 1:
        Console.WriteLine("Pirmadienis");
        break;
    case 2:
        Console.WriteLine("Antradienis");
        break;
    case 3:
        Console.WriteLine("Treciadienis");
        break;
    case 4:
        Console.WriteLine("Ketvirtadienis");
        break;
    case 5:
        Console.WriteLine("Penktadienis");
        break;
    case 6:
        Console.WriteLine("Sestadienis");
        break;
    case 7:
        Console.WriteLine("Sekmadienis");
        break;
    default:
        Console.WriteLine("Nera tokios dienos");
        break;
}

Console.WriteLine();
Console.WriteLine();

var operation = 1;

var result = operation switch
{
    1 => "Pirmadienis",
    2 => "Antradienis",
    3 => "Treciadienis",
    4 => "Ketvirtadienis",
    5 => "Penktadienis",
    6 => "Sestadienis",
    7 => "Sekmadienis",
    _ => "Nera tokios dienos"
};

Console.WriteLine(result);

/// PRAKTIKA
//===============================================================//
/// Uzduotis Nr.1

//===============================================================//
/// Uzduotis Nr.2

//===============================================================//
/// Uzduotis Nr.3

//===============================================================//
/// Uzduotis Nr.4

//===============================================================//
/// Uzduotis Nr.5

//===============================================================//
/// Uzduotis Nr.6
