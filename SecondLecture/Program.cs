
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the second lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// String kintamasis
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
/// Indeksavimas
//===============================================================//

var input = "CodeAcademy";
var lastIndex = input.Length - 1;

var firstChar = input[0];
var lastChar = input[lastIndex];

Console.WriteLine($"{input} pirmas char: {firstChar}, paskutinis char: {lastChar}");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Tuscios eilutes
//===============================================================//
//string word1 = "";
//string word2;

//===============================================================//
/// String metodai
//===============================================================//
/// Replace

string word1 = "mama";
string word2 = word1.Replace('m', 'p');
Console.WriteLine($"{word1} panaudojus Replace metoda: {word2}");
Console.WriteLine();
Console.WriteLine();

//===============================================================//
/// Substring
var i = 2;
var k = 5;
var subsFromTo = input.Substring(i, k);
Console.WriteLine($"{input} substring nuo {i} iki {k}: {subsFromTo}");
var subsFrom = input.Substring(i);
Console.WriteLine($"{input} substring nuo {i}: {subsFrom}");
Console.WriteLine();

//===============================================================//
/// IndexOf
var index1 = input.IndexOf("c");
Console.WriteLine($"{input} => IndexOf 'c': {index1}");
Console.WriteLine();

//===============================================================//
/// Trim
var trimWord = "Mano vardas Karolis";
Console.WriteLine(trimWord.Trim());
Console.WriteLine();

////===============================================================//
/// Concat
string str1 = "ap", str2 = "apa", str3 = "mama";
string result = string.Concat(str1, str2, str3);
Console.WriteLine(result);
Console.WriteLine();
Console.WriteLine();

////===============================================================//
/// ToString
var num = 987;
Console.WriteLine(num.ToString());


/// PRAKTIKA
//===============================================================//

///Nr. 1
// Ivesti string, atvaizduoti String.Length, atvaizduoti String[n]
Console.Write("Iveskite norima string: ");
var consoleOutput = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Ivesties simboliu kiekis: {consoleOutput.Length}");
if (consoleOutput.Length % 2 == 0)
    Console.WriteLine($"Ivesties vidurys susideda is dvieju simboliu {consoleOutput[consoleOutput.Length / 2 - 1]} ir {consoleOutput[consoleOutput.Length / 2]} ");
else
    Console.WriteLine($"Ivesties vidurinysis simbolis: {consoleOutput[consoleOutput.Length / 2]}");
Console.WriteLine();
Console.WriteLine();

///Nr .2
//String vardas, Substring tik vardas, Substring "Mano"

var inputName = "Mano vardas Karolis";

Console.WriteLine($"Input: {inputName}");
Console.WriteLine($"Vardas yra: {inputName.Substring(12)}");
Console.WriteLine($"Tik pirmas zodis: {inputName.Substring(0, 4)}");
Console.WriteLine();
Console.WriteLine();

