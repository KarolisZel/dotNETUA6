// ReSharper disable InvalidXmlDocComment

namespace LectureThirteen;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Thirteen");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// Užduotis Nr.1
        
        int[] input = { 1, -2, 3, -4, 5 };
        Console.WriteLine($"Input array: {string.Join(" , ", input)}");

        Console.WriteLine($"Average: {Methods.GetAverage(input)}");
        Console.WriteLine();

        Console.WriteLine($"Positive numbers: {string.Join(" , ", Methods.GetPositiveNumbers(input))}");
        Console.WriteLine();

        //----------------------------------------------------------------//

        double[] payments = { 100.25, 158.12, 133.12, 465.45, 231.13, 785.46 };
        Console.WriteLine($"Payments: {string.Join(" , ", payments)}");

        Console.WriteLine($"GPM amount: {Methods.GetGpmAmount(payments)}");
        Console.WriteLine();

        //----------------------------------------------------------------//

        var sentence = "Kaip tau sekasi mokytis programuoti?";

        Console.WriteLine(
            $"Words longer/equal to 5 chars: {string.Join(" , ", Methods.GetLongerThanFiveChars(sentence))}");
        Console.WriteLine();

        //----------------------------------------------------------------//

        string[] deckTypes = { "Bugnu", "Sirdziu", "Kryziu", "Lapu" };
        string[] deckCards =
        {
            "Tuzas", "Dviake", "Triake", "Keturake", "Penkake", "Sesake", "Septynake", "Astuonake", "Devynake",
            "Desimtake", "Valetas", "Dama", "Karalius"
        };

        Console.WriteLine($"Deck of cards: {string.Join(" , ", Methods.GetCardDeck(deckTypes, deckCards))}");
        Console.WriteLine();

        //===============================================================//
        /// Užduotis Nr.2

        Console.Write("Enter row count: ");
        var rows = int.Parse(Console.ReadLine());
        
        Console.Write("Enter column count: ");
        var columns = int.Parse(Console.ReadLine());
        
        Console.Write("Enter desired elements: ");
        var elements = Console.ReadLine();
        
        var matrix1 = Methods.GetMatrix(rows, columns, elements);
        Methods.PrintMatrix(matrix1);
        
        //----------------------------------------------------------------//

        var input1 = new[,] { {1,2,1}, {2,3,2},{1,5,1} };

        var result1 = Methods.GetMaxFromMatrix(input1, out var row, out var col);

        Console.WriteLine($"Max form matrix: {result1}, Position index: I => {row} J => {col} ");
        Console.WriteLine();
        
        Methods.FindRepeatingNumbers(input1);
        Console.WriteLine();
        
        // Methods.FindRepeatingNames(input2);
        // Console.WriteLine();
        
        

    }
}

//===============================================================//
/// PRAKTIKA
public class Methods
{
    
    //===============================================================//
    /// ForEach
    public static int GetAverage(int[] input)
    {
        var sum = 0;
        foreach (var num in input)
        {
            sum += num;
        }

        return sum / input.Length;
    }

    //----------------------------------------------------------------//

    public static int[] GetPositiveNumbers(int[] input)
    {
        var count = input.Count(x => x > 0);
        var index = 0;

        int[] result = new int[count];

        foreach (var num in input)
        {
            if (num > 0)
            {
                result[index] = num;
                index++;
            }
        }

        index = 0;
        return result;
    }

    //----------------------------------------------------------------//

    public static double GetGpmAmount(double[] input)
    {
        var gpm = 0.15d;
        var amount = 0d;
        foreach (var payment in input)
        {
            amount += payment * gpm;
        }

        return Math.Round(amount, 2);
    }

    //----------------------------------------------------------------//

    public static string[] GetLongerThanFiveChars(string input)
    {
        var sentence = input.Trim().Split(" ");

        var count = sentence.Count(x => x.Length >= 5);
        var index = 0;
        var output = new string[count];

        foreach (var str in sentence)
        {
            if (str.Length >= 5)
            {
                output[index] = str;
                index++;
            }
        }

        return output;
    }

    //----------------------------------------------------------------//

    public static string[] GetCardDeck(string[] types, string[] cards)
    {
        string[] deck = new string[52];
        var index = 0;
        foreach (var type in types)
        {
            foreach (var card in cards)
            {
                deck[index] = string.Concat(type, " ", card);
                index++;
            }
        }

        index = 0;
        return deck;
    }

    //===============================================================//
    /// Matrix

    public static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i,j].PadRight(4));

            Console.WriteLine();
        }
    }
    
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i,j]}\t");

            Console.WriteLine();
        }
    }

    private static int[] StringToIntArray(string[] input)
    {
        var count = input.Length;

        int[] output = new int[count];

        for (int i = 0; i < input.Length; i++)
        {
            int.TryParse(input[i], out output[i]);
        }

        return output;
    }
    
    public static int[,] GetMatrix(int rows, int columns, string input)
    {
        int[,] result = new int[rows, columns];
        var inputSequence = input.Trim().Split(",");

        var intArray = StringToIntArray(inputSequence);

        var index = 0;

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = intArray[index];
                index++;
            }
        }

        return result;
    }

    public static int GetMaxFromMatrix(int[,] input, out int row, out int col)
    {
        row = col = 0;
        
        var result = input[0,0];

        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (result >= input[i, j]) 
                    continue;
                
                result = input[i, j];
                row = i;
                col = j;
            }
        }

        return result;
    }

    public static void FindRepeatingNumbers(int[,] input)
    {
        int rows = input.GetLength(0);
        int cols = input.GetLength(1);
        
        bool[] printed = new bool[9]; 
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int current = input[i, j];
                
                if (printed[current]) 
                    continue;

                bool isDuplicate = false;
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if ((x != i || y != j) && input[x, y] == current)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (isDuplicate) break;
                }

                if (isDuplicate)
                {
                    Console.WriteLine(current);
                    printed[current] = true; 
                }
            }
        }
    }
    
    public static void FindRepeatingNames(string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        bool[] printed = new bool[rows * cols];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                string current = matrix[i, j];
                
                if (NamePrinted(current, matrix, printed)) continue;

                bool isDuplicate = false;
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if ((x != i || y != j) && matrix[x, y] == current)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (isDuplicate) break;
                }

                if (isDuplicate)
                {
                    Console.WriteLine(current);
                    MarkAsPrinted(current, matrix, printed);
                }
            }
        }
    }

    private static bool NamePrinted(string name, string[,] matrix, bool[] printed)
    {
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == name && printed[index])
                {
                    return true;
                }
                index++;
            }
        }
        return false;
    }

    private static void MarkAsPrinted(string name, string[,] matrix, bool[] printed)
    {
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == name)
                {
                    printed[index] = true;
                }
                index++;
            }
        }
    }
    
    
    
}