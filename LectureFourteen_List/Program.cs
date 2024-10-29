// ReSharper disable InvalidXmlDocComment
namespace LectureFourteen_List;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Fourteen");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// Užduotis Nr.1

        var stringList = new List<string> { "Labas", "As", "Krabas" };
        
        Methods.PrintList(Methods.GetElementLength(stringList), 10);
        Console.WriteLine();

        var intList = Methods.GenerateIntList(50);
        Console.WriteLine("Input:");
        Methods.PrintList(intList, 10);
        Console.WriteLine($"Average: {Methods.GetAverage(intList)}");
        Console.WriteLine();

        Console.WriteLine($"More than ten:");
        Methods.PrintList(Methods.GetElementsMoreThanTen(intList), 10);
        Console.WriteLine();

        Console.WriteLine("Letter ASCII is even:");
        Methods.PrintList(Methods.GetAsciiEvenList(stringList), 10);
        Console.WriteLine();

        Console.WriteLine($"Input factorial list:");
        Methods.PrintList(Methods.GetElementFactorialList(intList), 10);
        Console.WriteLine();

        Console.WriteLine($"Letter ASCII is prime number:");
        Methods.PrintList(Methods.GetAsciiIsPrime(stringList), 10);
        Console.WriteLine();

    }
}

class Methods
{
    public static void PrintList<T>(List<T> input, int itemsPerLine)
    {
        for (int i = 0; i < input.Count; i++)
        {
            Console.Write(input[i]);

            // Add a comma after each item except the last in a line
            if ((i + 1) % itemsPerLine != 0 && i != input.Count - 1)
            {
                Console.Write(", ");
            }

            // Start a new line after reaching the itemsPerLine limit
            if ((i + 1) % itemsPerLine == 0)
            {
                Console.WriteLine();
            }
        }

        // Ensure a new line at the end if the last line didn't end with a line break
        if (input.Count % itemsPerLine != 0)
        {
            Console.WriteLine();
        }
    }

    public static List<int> GenerateIntList(int length)
    {
        var result = new List<int>();

        for (int i = 1; i <= length; i++) 
            result.Add(i);

        return result;
    }
    
    private static int GetAsciiSum(string input)
    {
        int sum = 0;
    
        foreach (char c in input)
        {
            sum += c;  
        }
    
        return sum;
    }
    
    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2 || number == 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }
    
        return true;
    }
    
    private static int CalculateFactorial(int number)
    {
        if (number < 0)
            return 0;
        if (number is 0 or 1)
            return 1;
        return number * CalculateFactorial(number - 1);
    }
    
    public static List<int> GetElementLength(List<string> input)
    {
        var result = new List<int>();

        foreach (var str in input)
        {
            result.Add(str.Length);
        }

        return result;
    }

    public static double GetAverage(List<int> input)
    {
        var result = 0d;

        foreach (var number in input) 
            result += number;

        return result / input.Count;
    }

    public static List<int> GetElementsMoreThanTen(List<int> input)
    {
        var result = new List<int>();

        foreach (var i in input)
        {
            if (i>10) 
                result.Add(i);
        }

        return result;
    }

    public static List<string> GetAsciiEvenList(List<string> input)
    {
        var result = new List<string>();

        foreach (var str in input)
        {
            if (GetAsciiSum(str) % 2 == 0) 
                result.Add(str);
        }

        return result;
    }

    public static List<int> GetElementFactorialList(List<int> input)
    {
        var result = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            result.Add(CalculateFactorial(input[i]));
        }

        return result;
    }

    public static List<string> GetAsciiIsPrime(List<string> input)
    {
        var result = new List<string>();

        foreach (var str in input)
        {
            if (IsPrime(GetAsciiSum(str)))
            {
                result.Add(str);
            }
        }

        if (result.Count == 0)
        {
            result.Add("Empty");
        }
        return result;
    }
    
}