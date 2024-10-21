// ReSharper disable InvalidXmlDocComment

namespace LectureNine_RefOut;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Nine");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// TEORIJA
        //===============================================================//

        /// PRAKTIKA
        //===============================================================//
        /// Uzduotis Nr.1

        var x1 = 5;
        var y1 = 10;

        Swap(ref x1, ref y1);
        Console.WriteLine($"x: {x1}, y: {y1}");

        //----------------------------------------------------------------//
        var x2 = 3;

        IncrementByN(ref x2, 5);
        Console.WriteLine($"x: {x2}");

        //----------------------------------------------------------------//

        var x3 = "   dotnetas   ";

        TrimAndCapitalize(ref x3);
        Console.WriteLine($"x: {x3}");

        //===============================================================//
        /// Uzduotis Nr.2

        // GetUserData(out var name, out var surname);
        // Console.WriteLine($"Hello, {name} {surname}!");

        //----------------------------------------------------------------//

        // NumberMoreThanHundred( out var number);
        // Console.WriteLine($"{number} is more than 100!");

        //----------------------------------------------------------------//

        Console.Write("Enter first number: ");
        double.TryParse(Console.ReadLine(), out double x);

        Console.Write("Enter second number: ");
        double.TryParse(Console.ReadLine(), out double y);

        var quotient = Divide(x, y , out var remainder);
        Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
    }


    private static void Swap(ref int x, ref int y)
    {
        // (x, y) = (y, x);

        var temp = x;
        x = y;
        y = temp;
    }

    private static void IncrementByN(ref int x, int n)
    {
        x += n;
    }

    private static void TrimAndCapitalize(ref string text)
    {
        text = text.Trim();
        var c = char.ToUpper(text[0]);
        text = c + text.Substring(1);
    }

    private static void GetUserData(out string name, out string surname)
    {
        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your surname: ");
        surname = Console.ReadLine();
    }

    private static void NumberMoreThanHundred(out int number)
    {
        var isMoreThanHundred = false;
        number = 0;

        while (!isMoreThanHundred)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number");
                continue;
            }

            if (number <= 100)
            {
                Console.WriteLine("Number is less or equal to 100");
                continue;
            }

            isMoreThanHundred = true;
        }
    }

    private static double Divide(double x, double y, out double remainder)
    {
        double quotient = 0d;
        remainder = 0d;

        if (y == 0)
        {
            Console.WriteLine("Second number cannot be zero");
            return 0;
        }

        quotient = Math.Round(x / y, 2);
        remainder = Math.Round(x % y, 2);

        return quotient;
    }
}