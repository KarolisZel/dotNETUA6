
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the second lecture");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
///String kintamasis
//===============================================================//

var firstLine = "vienas";
var secondLine = "du";
var thirdLine = firstLine + secondLine;
Console.WriteLine(thirdLine);
Console.WriteLine();
Console.WriteLine();

//===============================================================//

var city = "Kaunas";

Console.WriteLine($"String '{city}' ilgis: {city.Length}");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
///Indeksavimas
//===============================================================//

var input = "CodeAcademy";
var lastIndex = input.Length - 1;

var firstChar = input[0];
var lastChar = input[lastIndex];

Console.WriteLine($"{input} pirmas char: {firstChar}, paskutinis char: {lastChar}");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
///Tuscios eilutes
//===============================================================//
string word1 = "";
string word2;