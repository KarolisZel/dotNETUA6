
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

Console.Write("Iveskite norima teksta: ");
var input1 = Console.ReadLine();
//Check for null/empty
var symb1 = input1.ToCharArray();

var changed1 = char.ToUpper(symb1[0]);

var changedInput1 = new string(changed1 + input1.Substring(1));

Console.WriteLine($"Jus ivedete: {input1}");
Console.WriteLine($"Pakeista i: {changedInput1}");

Console.WriteLine();
Console.WriteLine();

//===============================================================//

Console.Write("Iveskite bent 10 simboliu teksta: ");

var input2 = Console.ReadLine();
//Check for null/empty

var symb2 = input2.ToCharArray();

//Check length >= 10
symb2[1] = 'g';
symb2[3] = 'b';
symb2[5] = '*';
symb2[7] = 'x';
symb2[9] = 'w';

var changed2 = new string(symb2);

Console.WriteLine($"Ivestas tekstas: {input2}");
Console.WriteLine($"Pakeistas tekstas: {changed2}");

Console.WriteLine();
Console.WriteLine();

//===============================================================//

Console.Write("Iveskite \"5 simboliu ilgumo teksta\": ");
var input3 = Console.ReadLine();
//Check for null/empty

var symb3 = input3.ToCharArray();

if (input3.Length < 5)
    Console.WriteLine("Ivestas tekstas per trumpas!");
else if (input3.Length > 5)
    Console.WriteLine("Ivestas tekstas per ilgas!");


Console.Write("Kaip noretumete uzkoduoti pranesima? ");
var codeInput = Console.ReadLine();
//Check for null/empty

string codedText = "";
for (int i = 0; i < symb3.Length; i++)
    codedText = codedText + (symb3[i] + codeInput.Length.ToString());

Console.WriteLine(codedText);

Console.WriteLine();
Console.WriteLine();
