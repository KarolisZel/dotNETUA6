// ReSharper disable InvalidXmlDocComment
Console.WriteLine("Hello, World!");
Console.WriteLine("This is the Sixth lecture");
Console.WriteLine();
Console.WriteLine();

/// TEORIJA
//===============================================================//
/// WHILE
//
// var i = 1;
// var result = "";
//
// while (i <= 5)
// {
//     Console.WriteLine("Iveskite teksta:");
//     var input = Console.ReadLine();
//
//     result += " " + input;
//     i++;
// }
// Console.WriteLine(result);
//
// var x = 1;
// var y = 1;
//
// while (x <= 3)
// {
//     Console.WriteLine($"Outer scope: {x}");
//     while (y <= 3)
//     {
//         Console.WriteLine($"Inner scope: {y}");
//         y++;
//     }
//
//     y = 1;
//     x++;
// }

/// PRAKTITA
//===============================================================//
/// Uzduotis nr.1

var x = 1;
while (x <= 5)
{
    Console.WriteLine(x);
    x++;
}

Console.WriteLine();

var y = 5;
while (y >= 1)
{
    Console.WriteLine(y);
    y--;
}
Console.WriteLine();

//----------------------------------------------------------------//

var a = 2;
while (a <= 10)
{
    Console.WriteLine(a);
    a += 2;
}

Console.WriteLine();

var b = 9;
while (b >= 1)
{
    Console.WriteLine(b);
    b -= 2;
}

Console.WriteLine();

//----------------------------------------------------------------//

Console.Write("Iveskite skaiciu: ");
var input1 = int.Parse(Console.ReadLine());

while (input1 <= 100)
{
    Console.Write("Bandykite dar karta: ");
    var inputRetry = int.Parse(Console.ReadLine());
    if (inputRetry > 100)
    {
        Console.WriteLine("SVEIKINIMAI!");
        break;
    }
}

Console.WriteLine();

Console.Write("Iveskite skaiciu: ");
var input2 = int.Parse(Console.ReadLine());

while (input2 % 2 != 0)
{
    Console.Write("Bandykite dar karta: ");
    var inputRetry = int.Parse(Console.ReadLine());
    if (inputRetry % 2 == 0)
    {
        Console.WriteLine("SVEIKINIMAI");
        break;
    }
}

//===============================================================//
/// Uzduotis nr.2

Console.Write("Iveskite skaiciu: ");
var input3 = int.Parse(Console.ReadLine());

var result3 = input3;

while (input3 >= 1)
{
    if (input3 - 1 > 0)
        result3 *= input3 - 1;
    input3--;
}
Console.WriteLine($"Faktorialas: {result3}");

Console.WriteLine();

Console.Write("Iveskite skaiciu: ");
var input4 = int.Parse(Console.ReadLine());

var result2 = 1;
bool isMoreThanZero = input4 > 0;

while (isMoreThanZero)
{
    while (input4 >= 1)
    {
        result2 *= input4;
        input4--;
    }

    Console.WriteLine($"Faktorialas: {result2}");
    result2 = 1;
    Console.Write("Iveskite kita skaiciu: ");
    input4 = int.Parse(Console.ReadLine());

    if (input4 < 0)
        isMoreThanZero = false;
}

Console.WriteLine();

//----------------------------------------------------------------//

Console.Write("Iveskite skaiciu: ");
var input5 = Console.ReadLine();

var i = 0;
while (i < input5.Length)
{
    Console.Write(" " + input5[i]);
    i++;
}

//----------------------------------------------------------------//

Console.Write("Iveskite skaiciu: ");
var input6 = int.Parse(Console.ReadLine());

var result4 = "";
var j = 1;
while (j <= input6)
{
    Console.WriteLine(result4 += "*");
    j++;
}

//===============================================================//
/// Uzduotis nr.3

Console.Write("Iveskite skaiciu: ");
var isParsed = int.TryParse(Console.ReadLine(), out var result5);

if (isParsed)
    Console.WriteLine($"Ivestas sveikas skaicius: {result5}");
else
{
    while (!isParsed)
    {
        Console.Write("Bandykite dar skaiciu: ");
        isParsed = int.TryParse(Console.ReadLine(), out result5);
    }
    Console.WriteLine($"Ivestas sveikas skaicius: {result5}");
}

//----------------------------------------------------------------//

Console.Write("Iveskite skaiciu: ");
var numb = int.Parse(Console.ReadLine());

Console.Write("Iveskite laipsni: ");
var power = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Pow(numb, power));

//----------------------------------------------------------------//

Console.Write("Iveskite skaiciu: ");
int.TryParse(Console.ReadLine(), out var number1);

Console.Write("Iveskite grupiu kieki: ");
int.TryParse(Console.ReadLine(), out var numberGroups);

var result = "";
var currNumber = "";
var l = 1;
while (l <= numberGroups)
{
    currNumber += number1.ToString();
    result += " -> " + currNumber;
    l++;
}
Console.WriteLine(result);

//===============================================================//
/// Uzduotis nr.4

Console.Write("Iveskite iteraciju skaiciu: ");
int.TryParse(Console.ReadLine(), out var iters);

var results = "";
var k = 1;
while (k <= iters)
{
    results = "";
    var m = 1;
    while (m <= k)
    {
        results += k.ToString();
        m++;
    }
    Console.WriteLine(results);
    k++;
}

//----------------------------------------------------------------//

Console.Write("Iveskite norima suma: ");
var sum = int.Parse(Console.ReadLine());

var taken = 0;
while (sum > 0)
{
    if (sum - 50 >= 0)
    {
        taken += 50;
        sum -= 50;
        Console.WriteLine("50 Eur");
    }
    else if (sum - 20 >= 0)
    {
        taken += 20;
        sum -= 20;
        Console.WriteLine("20 Eur");
    }
    else if (sum - 10 >= 0)
    {
        taken += 10;
        sum -= 10;
        Console.WriteLine("10 Eur");
    }
    else if (sum - 5 >= 0)
    {
        taken += 5;
        sum -= 5;
        Console.WriteLine("5 Eur");
    }
    else if (sum < 5)
    {
        Console.WriteLine("Daugiau ismiti nepavyksta!");
        Console.WriteLine($"Isimta suma: {taken}, Liko sumos: {sum}");
        break;
    }
}

//===============================================================//
/// Uzduotis nr.5

Console.Write("Iveskite skaiciu: ");
var input = Console.ReadLine();

var isParse = int.TryParse(input, out var number);
var suma = 0;

while (input.ToLower() != "baigti")
{
    if (isParse)
    {
        suma += number;
        Console.WriteLine($"Suma: {suma}");
    }
    Console.Write("Iveskite kita skaiciu: ");
    input = Console.ReadLine();
    isParse = int.TryParse(input, out number);
    if (input.ToLower() != "baigti" && !isParse)
        Console.WriteLine("Ivestas klaidingas skaicius!");
}

//----------------------------------------------------------------//

Console.Write("Iveskite slaptazodi: ");
var password = Console.ReadLine();

var pass = "123456";
var isPasswordCorrect = password == pass;

while (!isPasswordCorrect)
{
    Console.WriteLine("Slaptazodis neteisingas!");
    Console.Write("Iveskite slaptazodi: ");
    password = Console.ReadLine();
    isPasswordCorrect = password == pass;
}

//----------------------------------------------------------------//
