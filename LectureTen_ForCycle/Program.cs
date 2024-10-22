// ReSharper disable InvalidXmlDocComment

namespace LectureTen_ForCycle;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Ten");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// TEORIJA
        //===============================================================//

        /// PRAKTIKA
        //===============================================================//
        /// Užduotis Nr.1

        Console.WriteLine("Even numbers:");
        Console.WriteLine(string.Join(",", PrintEvenNumbers()));

        //----------------------------------------------------------------//

        Console.WriteLine("Numbers divisible by 3:");
        Console.WriteLine(string.Join(",", PrintNumbersDivideFromThree()));

        //----------------------------------------------------------------//

        var to = NumberInput();
        Console.WriteLine($"Sum of numbers from 1 to {to}: {SumOfNumbers(to)}");

        //----------------------------------------------------------------//

        Console.WriteLine($"Squares of numbers from 1 to {to}:");
        Console.WriteLine(string.Join(",", PrintSquares(to)));

        //----------------------------------------------------------------//

        Console.WriteLine($"Average of numbers from 1 to {to}: {CalculateAverage(to)}");
        Console.WriteLine(CalculateAverage(to));

        //----------------------------------------------------------------//

        PrintColumn(to);
    }

    private static int[] PrintEvenNumbers()
    {
        var numbers = new int[50];
        for (var i = 2; i <= 100; i += 2)
            numbers[i / 2 - 1] = i;

        return numbers;
    }

    private static int[] PrintNumbersDivideFromThree()
    {
        var numbers = new int[100 / 3];
        for (var i = 3; i <= 100; i += 3)
            numbers[i / 3 - 1] = i;

        return numbers;
    }

    private static int SumOfNumbers(int to)
    {
        var sum = 0;

        for (var i = 1; i <= to; i++)
            sum += i;

        return sum;
    }

    private static int[] PrintSquares(int to)
    {
        var numbers = new int[to];
        for (var i = 1; i <= to; i++)
            numbers[i - 1] = i * i;

        return numbers;
    }

    private static double CalculateAverage(int to)
    {
        var sum = 0d;

        for (var i = 1; i <= to; i++)
            sum += i;

        return Math.Round(sum / to, 3);
    }

    private static void PrintColumn(int to)
    {
        for (var i = 1; i <= to; i++)
            Console.WriteLine($"{i}: *");
    }

    private static int NumberInput()
    {
        Console.Write("Enter a number: ");
        var isValid = int.TryParse(Console.ReadLine(), out var num);

        if (isValid)
            return num;

        while (!isValid)
        {
            Console.Write("Invalid number, try again: ");
            isValid = int.TryParse(Console.ReadLine(), out num);
        }

        return num;
    }

}