// ReSharper disable InvalidXmlDocComment
namespace SeventhLecture_Methods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the Seventh lecture");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// UŽDUOTIS NR.1

        Console.Write("Įveskite slaptažodį: ");
        var password = Console.ReadLine();
        Console.WriteLine($"Ar tinkamas slaptažodis? {IsPasswordValid(password)}");

        //----------------------------------------------------------------//

        Console.Write("Įveskite el. pašto adresą: ");
        var email = Console.ReadLine();
        Console.WriteLine($"Ar {email} tinkamas? {IsEmailValid(email)}");

        //----------------------------------------------------------------//

        Console.Write("Įveskite sumą doleriais: ");
        var dollars = ParseDouble(Console.ReadLine());
        if (dollars == -1)
            Console.WriteLine("Suma buvo neįvesta arba neteisinga!");
        else
            Console.WriteLine($"Paversti {dollars} į Eurus: {ConvertToEuros(dollars)}");

        //----------------------------------------------------------------//
        /// UŽDUOTIS NR.2

        Console.Write("Įveskite vardą: ");
        var firstName = Console.ReadLine();
        Console.Write("Įveskite pavardę: ");
        var lastName = Console.ReadLine();
        Console.WriteLine($"Inicialai: {GetInitials(firstName, lastName)}");

        //----------------------------------------------------------------//

        Console.Write("Įveskite spindulio dydį:");
        var radius = ParseDouble(Console.ReadLine());

        if (radius == -1)
            Console.WriteLine("Dydis buvo neįvestas arba neteisingas!");

        Console.Write("Įveskite aukštį: ");
        var height = ParseDouble(Console.ReadLine());

        if (height == -1)
            Console.WriteLine("Dydis buvo neįvestas arba neteisingas!");

        Console.WriteLine($"Cilindro tūris: {CalcutateCylinderVolume(radius, height)}");

        //----------------------------------------------------------------//

        Console.Write("Įveskite skaičių: ");
        var number = ParseInt(Console.ReadLine());
        if (number == -1)
            Console.WriteLine("Skaičius buvo neįvestas arba neteisingas!");
        else
            Console.WriteLine($"Ar {number} lyginis? {IsNumberEven(number)}");

        //----------------------------------------------------------------//

        Console.Write("Įveskite ilgį: ");
        var length = ParseDouble(Console.ReadLine());
        if (length == -1)
            Console.WriteLine("Ilgis buvo neįvestas arba neteisingas!");

        Console.Write("Įveskite plotį: ");
        var width = ParseDouble(Console.ReadLine());
        if (width == -1)
            Console.WriteLine("Plotas buvo neįvestas arba neteisingas!");

        Console.WriteLine($"Stačiakampio plotas: {CalculateRectangleArea(length, width)}");

        //----------------------------------------------------------------//
        /// UŽDUOTIS NR.3

        Console.WriteLine($"Įveskite skaičių: ");
        var factorialNumber = ParseInt(Console.ReadLine());
        if (factorialNumber == -1)
            Console.WriteLine("Skaičius buvo įvestas per mažas arba neįvestas!");
        else
            Console.WriteLine(
                $"Skaičiaus {factorialNumber} faktorialas: {CalculateFactorial(factorialNumber)}"
            );

        //----------------------------------------------------------------//

        Console.WriteLine($"Įveskite skaičių: ");
        var fibonacciNumber = ParseInt(Console.ReadLine());
        if (fibonacciNumber == -1)
            Console.WriteLine("Skaičius buvo įvestas per mažas arba neįvestas!");
        else
        {
            Console.WriteLine($"Skaičiaus {fibonacciNumber} fibonacci seka:");
            Console.WriteLine(CalculateFibonacci(fibonacciNumber));
        }

        //----------------------------------------------------------------//
    }

    /// TEORIJA
    //===============================================================//
    /// METHODS



    /// PRAKTITA
    //===============================================================//
    /// HELPER METHODS

    private static double ParseDouble(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            if (double.TryParse(input, out var result))
                return result;
            return -1;
        }
        return -1;
    }

    private static int ParseInt(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            if (int.TryParse(input, out var result))
                return result;
            return -1;
        }
        return -1;
    }

    /// Užduotis nr.1

    private static bool IsPasswordValid(string password)
    {
        if (!string.IsNullOrEmpty(password))
        {
            if (password.Length < 8)
                return false;

            return true;
        }

        Console.WriteLine("Slaptažodis neįvestas!");
        return false;
    }

    private static bool IsEmailValid(string email)
    {
        if (!string.IsNullOrEmpty(email))
        {
            if (email.Contains("@") && email.Contains("."))
                return true;

            return false;
        }

        Console.WriteLine("Neivestas el. pašto adresas!");
        return false;
    }

    private static double ConvertToEuros(double dollars)
    {
        return dollars * 0.85;
    }

    //===============================================================//
    /// Užduotis nr.2

    private static string GetInitials(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }

    private static double CalcutateCylinderVolume(double radius, double height)
    {
        return Math.Round(Math.PI * radius * radius * height, 3);
    }

    private static bool IsNumberEven(int number)
    {
        if (number % 2 == 0)
            return true;

        return false;
    }

    private static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    //===============================================================//
    /// Užduotis nr.3

    private static int CalculateFactorial(int number)
    {
        if (number < 0)
            return 0;
        if (number == 0 || number == 1)
            return 1;
        return number * CalculateFactorial(number - 1);
    }

    private static int CalculateFibonacci(int number)
    {
        if (number < 0)
            return -1;
        if (number == 0)
            return 0;
        if (number == 1)
            return 1;

        return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
    }
}
