
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the Fourth lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// Switch cases

var day = 8;

switch (day) {
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

var ops = 1;

var results = ops switch
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

Console.WriteLine(results);

/// PRAKTIKA
//===============================================================//
/// Uzduotis Nr.1

Console.Write("Iveskite savaites dienos skaiciu: ");

var op1 = Console.ReadLine();

var result = op1 switch
{
    "1" => "Pirmadienis",
    "2" => "Antradienis",
    "3" => "Treciadienis",
    "4" => "Ketvirtadienis",
    "5" => "Penktadienis",
    "6" => "Sestadienis",
    "7" => "Sekmadienis",
    _ => "Nera tokios dienos"
};
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine();

Console.Write("Iveskite savo amziu: ");

var op2 = Int32.Parse(Console.ReadLine());

var result2 = op2 switch
{
    >= 0 and < 7 => "Vaikas",
    > 6 and <= 18 => "Moksleivis",
    > 18 and <= 25 => "Studentas",
    > 25 and <= 65 => "Darbuotojas",
    > 65 => "Pensininkas",
    _ => "Netinkamas skaicius"
};
Console.WriteLine(result2);

Console.WriteLine();
Console.WriteLine();

Console.Write("Iveskite menesio skaiciu: ");

var op3 = int.Parse(Console.ReadLine());

var lol = 1 is 2 or 3;

var result3 = op3 switch
{
    1 => "Sausis",
    2 => "Vasaris",
    3 => "Kovas",
    4 => "Balandis",
    5 => "Geguze",
    6 => "Birzelis",
    7 => "Liepa",
    8 => "Rugpjutis",
    9 => "Rugsejis",
    10 => "Spalis",
    11 => "Lapkritis",
    12 => "Gruodis",
    _ => "Nera tokios dienos"
};
Console.WriteLine(result3);

Console.WriteLine();
Console.WriteLine();


//===============================================================//
/// Uzduotis Nr.2

Console.WriteLine("Figuros ploto skaiciavimas");
Console.WriteLine("Kvadratas/Apskritimas/Trikampis/Staciakampis");

Console.Write("Iveskite figuros pavadinima: ");
var figure = Console.ReadLine();

switch (figure.ToLower()) {
    case "kvadratas":
        Console.Write("Iveskite krastines ilgi: ");
        var krastineKv = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Plotas: {krastineKv * krastineKv}");
        break;
    case "apskritimas":
        Console.Write("Iveskite spindulio ilgi: ");
        var spindulys = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Plotas: {(spindulys * spindulys) * Math.PI}");
        break;
    case "trikampis":
        Console.Write("Iveskite aukstines ilgi: ");
        var aukstine = Int32.Parse(Console.ReadLine());
        Console.Write("Iveskite pagrindo ilgi: ");
        var parindas = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Plotas: {(aukstine * parindas) / 2}");
        break;
    case "staciakampis":
        Console.Write("Iveskite vienos krastines ilgi: ");
        var krastineA = Int32.Parse(Console.ReadLine());
        Console.Write("Iveskite kitos krastines ilgi: ");
        var krastineB = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Plotas: {krastineA * krastineB}");
        break;
    default:
        Console.WriteLine("Ivesta netinkama figura");
        break;
}

Console.Write("Iveskite pagrindinio elemento pavadinima: ");
var element = Console.ReadLine();

var result4 = element.ToLower() switch
{
    "zeme" => "ZemeChar ir ZemeSav",
    "oras" => "OrasChar ir OrasSav",
    "vanduo" => "VanduoChar ir VanduoSav",
    "ugnis" => "UgnisChar ir UgnisSav",
    "eteris" => "EterisChar ir EterisSav",
};
Console.WriteLine(result4);

Console.WriteLine();
Console.WriteLine();

//Console.Write("Iveskite specialybes pavadinima: ");
//var spec = Console.ReadLine();

//Reikia metinisVidurkis, egzBalas, olimpiada ir gauti sansasPatekti

//===============================================================//
/// Uzduotis Nr.3

Console.Write("Iveskite menesio skaiciu: ");

var op4 = Int32.Parse(Console.ReadLine());

var result5 = op4 switch
{
    3 or 4 or 5 => "Pavasaris",
    6 or 7 or 8 => "Vasara",
    9 or 10 or 11 => "Ruduo",
    1 or 2 or 12 => "Ziema",
    _ => "Netinkamas menesis",
};

Console.WriteLine(result5);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("----|SKAICIUOTUVAS|----");

double result6;

Console.Write("Iveskite pirma skaiciu: ");
var num1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Galimi veiksmai:");
Console.WriteLine("+ -> sudetis, - -> atimtis, * -> daugyba, / -> dalyba, kv -> kelimas kvadratu, skn -> saknies traukimas");
Console.Write("Iveskite veiksma: ");
var operation = Console.ReadLine();

if (operation == "kv")
    Console.WriteLine($"Resultatas: {num1 * num1}");
else if (operation == "skn")
    Console.WriteLine($"Resultatas: {Math.Sqrt(num1)}");
else if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
{
    Console.Write("Iveskite antra skaiciu: ");
    var num2 = Int32.Parse(Console.ReadLine());

    result6 = operation switch
    {
        "+" => num1 + num2,
        "-" => num1 - num2,
        "*" => num1 * num2,
        "/" => num1 / num2,
    };
    Console.WriteLine($"Resultatas: {result6}");
}
else
    Console.WriteLine("Ivestas netinkamas veiksmas!");

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("----|VALIUTOS SKAICIUOKLE|----");
Console.WriteLine();

//-----------------------//
// VALIUTU KURSAI
var usdEur = 0.92;
var usdGbp = 0.77;
var usdJpy = 148.73;

var eurUsd = 1.09;
var eurGbp = 0.84;
var eurJpy = 162.44;

var gbpUsd = 1.30;
var gbpEur = 1.19;
var gbpJpy = 194.07;

var jpyUsd = 0.0067;
var jpyEur = 0.0062;
var jpyGbp = 0.0052;
//-----------------------//

Console.WriteLine("Galimos valiutos: USD, EUR, GBP, JPY");
Console.Write("Iveskite norima valiuta: ");
var val = Console.ReadLine();

Console.Write("Iveskite suma: ");
var sum = Int32.Parse(Console.ReadLine());



Console.WriteLine("Suma kitomis valiutomis:");
switch (val.ToUpper()) {
    case "USD":
        Console.WriteLine($"EUR: {sum * usdEur}");
        Console.WriteLine($"GBP: {sum * usdGbp}");
        Console.WriteLine($"JPY: {sum * usdJpy}");
        break;
    case "EUR":
        Console.WriteLine($"USD: {sum * eurUsd}");
        Console.WriteLine($"GBP: {sum * eurGbp}");
        Console.WriteLine($"JPY: {sum * eurJpy}");
        break;
    case "GBP":
        Console.WriteLine($"USD: {sum * gbpUsd}");
        Console.WriteLine($"EUR: {sum * gbpEur}");
        Console.WriteLine($"JPY: {sum * gbpJpy}");
        break;
    case "JPY":
        Console.WriteLine($"USD: {sum * jpyUsd}");
        Console.WriteLine($"EUR: {sum * jpyEur}");
        Console.WriteLine($"GBP: {sum * jpyGbp}");
        break;
    default:
        Console.WriteLine("Pasirinkta bloga valiuta");
        break;
}

Console.WriteLine();
Console.WriteLine();
