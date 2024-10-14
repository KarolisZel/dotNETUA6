
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the Fifth lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// Char

//var text = "Tekstas";

//Console.WriteLine(text[0]);

//var symbols = text.ToCharArray();
//symbols[0] = 'X';
//string changedText = new string(symbols);

//Console.WriteLine(changedText);

//Console.WriteLine();
//Console.WriteLine();



/// PRAKTIKA
//===============================================================//
/// Uzduotis Nr.1

//Console.Write("Iveskite norima teksta: ");
//var input1 = Console.ReadLine();
////Check for null/empty
//var symb1 = input1.ToCharArray();

//var changedInput1 = new string(char.ToUpper(symb1[0]) + input1.Substring(1));

//Console.WriteLine($"Jus ivedete: {input1}");
//Console.WriteLine($"Pakeista i: {changedInput1}");

//Console.WriteLine();
//Console.WriteLine();

//----------------------------------------------------------------//

//Console.Write("Iveskite bent 10 simboliu teksta: ");

//var input2 = Console.ReadLine();
////Check for null/empty

//var symb2 = input2.ToCharArray();

////Check length >= 10
//symb2[1] = 'g';
//symb2[3] = 'b';
//symb2[5] = '*';
//symb2[7] = 'x';
//symb2[9] = 'w';

//Console.WriteLine($"Ivestas tekstas: {input2}");
//Console.WriteLine($"Pakeistas tekstas: {new string(symb2)}");

//Console.WriteLine();
//Console.WriteLine();

//----------------------------------------------------------------//

//Console.Write("Iveskite \"5 simboliu ilgumo teksta\": ");
//var input3 = Console.ReadLine();
////Check for null/empty

//var symb3 = input3.ToCharArray();

//if (input3.Length < 5)
//    Console.WriteLine("Ivestas tekstas per trumpas!");
//else if (input3.Length > 5)
//    Console.WriteLine("Ivestas tekstas per ilgas!");


//Console.Write("Kaip noretumete uzkoduoti pranesima? ");
//var codeInput = Console.ReadLine();
////Check for null/empty

//string codedText = "";

//for (int i = 0; i < symb3.Length; i++)
//    codedText = codedText + (symb3[i] + codeInput.Length.ToString());

//Console.WriteLine(codedText);

//Console.WriteLine();
//Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.2

//Console.Write("Iveksite sakini: ");
//var input4 = Console.ReadLine();

//Console.WriteLine($"Pakeistas sakinys: {input4.Replace("a", "uo").Replace("i","e")}");

//Console.WriteLine();
//Console.WriteLine();

//----------------------------------------------------------------//

//Console.Write("Iveskite teksta (eilerastis/dainos zodziai): ");
//var input5 = Console.ReadLine();

//Console.Write("Koki zodi noretumete pakeisti? ");
//var inputToChange = Console.ReadLine();

//Console.Write("Kokiu zodziu keisti? ");
//var inputChange = Console.ReadLine();

//Console.WriteLine("Pakeistas tekstas:");
//Console.WriteLine(input5.Replace(inputToChange,inputChange));

//Console.WriteLine();
//Console.WriteLine();

//----------------------------------------------------------------//

//Console.Write("Kiek jums metu? ");
//var input6 = Console.ReadLine();
//var yearsCount = 90;

//if (!int.TryParse(input6, out var number))
//    Console.WriteLine("Ivestas blogas skaicius");

//var years = yearsCount - number;
//Console.WriteLine($"Iki jums bus {yearsCount} metu liko: ");
//Console.Write($"{years} metu arba {years * 12} menesiu arba {(years * 365) / 7} savaiciu arba {years * 365} dienu");

//Console.WriteLine();
//Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.3

//Console.Write("Iveskite zodi: ");
//var input6 = Console.ReadLine();

//var symb6 = input6.ToCharArray();

//if (symb6[0] == char.ToUpper(symb6[0]))
//    Console.WriteLine($"Pakeistas zodis: {input6.ToUpper()}");
//else
//    Console.WriteLine($"Pakeistas zodis: {new string(char.ToUpper(symb6[0]) + input6.Substring(1))}");

//Console.WriteLine();
//Console.WriteLine();

//----------------------------------------------------------------//

//Console.Write("Iveskite zodi: ");
//var input7 = Console.ReadLine();

//if (input7.Contains('a'))
//    Console.WriteLine($"Zodis: {input7}, Indeksas: {input7.IndexOf('a')}");
//else
//    Console.WriteLine("Simbolis 'a' nerastas");

//----------------------------------------------------------------//

//Console.Write("Iveskite zodi: ");
//var input8 = Console.ReadLine();

//var compare = "labas";

//if (input8.Equals(compare))
//    Console.WriteLine($"Atbulai: {new string(input8.Reverse().ToArray())}");
//else
//    Console.WriteLine($"Nesutampa: {input8}");

//Console.WriteLine();
//Console.WriteLine();

//===============================================================//
/// Uzduotis Nr.4

//Console.WriteLine("//====SUBWAY====\\\\");


//===============================================================//
/// Uzduotis Nr.5

Console.Write("Iveskite tel nr. i kuri bus skambinama (+...): ");
var telInput = Console.ReadLine();

Console.Write("Kiek laiko bus kalbama (Minutemis): ");
var talkTime = Console.ReadLine();

var LT = 0d;

var zoneOne = 0.23; // EE,LV,DK,NO,FI,SE

var zoneTwo = 1.19; // GB,AL,MD

var zoneFour = 1.79; // US

if (!int.TryParse(talkTime, out var minutes))
{
    Console.WriteLine("Netinkamai nurodytas kalbejimo laikas!");
}
else
{
    var isZoneOne = (telInput.StartsWith("+372") || telInput.StartsWith("+371")
        || telInput.StartsWith("+45") || telInput.StartsWith("+47")
        || telInput.StartsWith("+358") || telInput.StartsWith("+46"));

    var isZoneTwo = (telInput.StartsWith("+44") || telInput.StartsWith("+355") || telInput.StartsWith("+373"));

    var isZoneFour = telInput.StartsWith("+1");

    Console.WriteLine("Operatorius: BITE");
    Console.WriteLine($"Skambutis i numeri: {telInput}");
    Console.WriteLine($"Skambucio laukas: {minutes} minutes");
    if (telInput.StartsWith("+370"))
    {
        Console.WriteLine($"Skambucio kaina per minute: {LT}/1min");
        Console.WriteLine($"Galutine skambucio kaina: {Math.Round(minutes * LT, 2)} eur.");
    }
    else if (isZoneOne)
    {
        Console.WriteLine($"Skambucio kaina per minute: {zoneOne}/1min");
        Console.WriteLine($"Galutine skambucio kaina: {Math.Round(minutes * zoneOne, 2)} eur.");
    }
    else if (isZoneTwo)
    {
        Console.WriteLine($"Skambucio kaina per minute: {zoneTwo}/1min");
        Console.WriteLine($"Galutine skambucio kaina: {Math.Round(minutes * zoneTwo, 2)} eur.");
    }
    else if (isZoneFour)
    {
        Console.WriteLine($"Skambucio kaina per minute: {zoneFour}/1min");
        Console.WriteLine($"Galutine skambucio kaina: {Math.Round(minutes * zoneFour,2)} eur.");
    }
    else Console.WriteLine("Ivestas numeris neatitinka skaiciuokles!");
}
//===============================================================//
/// Uzduotis Nr.6


