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

        Console.WriteLine($"Words longer/equal to 5 chars: {string.Join(" , ", Methods.GetLongerThanFiveChars(sentence))}");
        Console.WriteLine();

        //----------------------------------------------------------------//

        string[] deckTypes = { "Bugnu", "Sirdziu", "Kryziu", "Lapu" };
        string[] deckCards =
        {
            "Dviake", "Triake", "Keturake", "Penkake", "Sesake", "Septynake", "Astuonake", "Devynake", "Desimtake",
            "Valetas", "Dama", "Karalius", "Tuzas"
        };

        Console.WriteLine($"Deck of cards: {string.Join(" , ", Methods.GetCardDeck(deckTypes, deckCards))}");
    }
}

//===============================================================//
/// PRAKTIKA

public class Methods
{
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
}