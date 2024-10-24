// ReSharper disable InvalidXmlDocComment

namespace LectureTwelve_Arrays;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Twelve");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// PRAKTIKA
        //===============================================================//
        /// Užduotis Nr. 1

        var array = new int[] { 1, 2, 3, 4, 5 };
        
        Console.WriteLine($"Original array: {string.Join(", ", array)}");
        Console.WriteLine();
        
        Console.WriteLine($"Squared array: {string.Join(", ", GetSquareArray(array))}");
        
        Console.WriteLine($"Sum: {GetSumArray(array)}");
        
        Console.WriteLine($"Max: {GetMaxArray(array)}");
        
        PrintIvertedArray(array);
        Console.WriteLine();
        
        //===============================================================//
        /// Užduotis Nr. 2
        
        var word = "Hello";
        
        Console.WriteLine($"Original word: {word}");
        
        Console.WriteLine($"Char array: {string.Join(", ", StringToCharArray(word))}");
        Console.WriteLine();
        
        var sentence = " 47 Agent47 ";
        Console.WriteLine($"Original sentence: {sentence}");
        
        Console.WriteLine($"First letter: {GetFirstLetter(sentence)}");
        
        Console.WriteLine($"Last letter: {GetLastLetter(sentence)}");

        //===============================================================//
        /// Užduotis Nr. 3
        
        var numberArray = new int[] { 9, 4, 2, 1, 3, 5, 6, 7, 8, 0 };
        
        Console.WriteLine($"Original array: {string.Join(", ", numberArray)}");
        
        var ascendingArray = SortArrayAscending(numberArray);
        Console.WriteLine($"Sorted array (ascending): {string.Join(", ", ascendingArray)}");
        
        var descendingArray = SortArrayDecending(numberArray);
        Console.WriteLine($"Sorted array (descending): {string.Join(", ", descendingArray)}");
        Console.WriteLine();
        
        var newArray = AddElementToArray(numberArray, 10);
        Console.WriteLine($"New array with added element: {string.Join(", ", newArray)}");

        var newArray2 = RemoveElementFromArray(numberArray, 5);
        Console.WriteLine($"New array without element: {string.Join(", ", newArray2)}");
        
    }

    public static int[] GetSquareArray(int[] array)
    {
        var squaredArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
            squaredArray[i] = array[i] * array[i];

        return squaredArray;
    }

    public static int GetSumArray(int[] array)
    {
        var sum = 0;

        for (int i = 0; i < array.Length; i++)
            sum += array[i];

        return sum;
    }

    public static int GetMaxArray(int[] array)
    {
        var max = array[0];

        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];

        return max;
    }

    public static void PrintIvertedArray(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
            Console.WriteLine(array[i]);
    }

    //----------------------------------------------------------------//

    public static char[] StringToCharArray(string word)
    {
        var charArray = new char[word.Length];

        for (int i = 0; i < word.Length; i++)
            charArray[i] = word[i];

        return charArray;
    }

    public static char GetFirstLetter(string sentence)
    {
        var firstLetter = ' ';

        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsLetter(sentence[i]))
            {
                firstLetter = sentence[i];
                break;
            }
        }

        return firstLetter;
    }

    public static char GetLastLetter(string sentence)
    {
        var lastLetter = ' ';

        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsLetter(sentence[i]))
                lastLetter = sentence[i];
        }

        return lastLetter;
    }

    //----------------------------------------------------------------//

    public static int[] SortArrayAscending(int[] array)
    {
        var sortedArray = new int[array.Length];

        // Copy original array to avoid modifying the input array
        Array.Copy(array, sortedArray, array.Length);

        // Perform selection sort on the copied array
        for (int i = 0; i < sortedArray.Length; i++)
        {
            var min = sortedArray[i];
            var index = i;

            for (int j = i + 1; j < sortedArray.Length; j++)
            {
                if (sortedArray[j] < min)
                {
                    min = sortedArray[j];
                    index = j;
                }
            }

            // Swap values if necessary
            if (index != i)
            {
                var temp = sortedArray[i];
                sortedArray[i] = sortedArray[index];
                sortedArray[index] = temp;
            }
        }

        return sortedArray;
    }

    public static int[] SortArrayDecending(int[] array)
    {
        var sortedArray = new int[array.Length];

        // Copy original array to avoid modifying the input array
        Array.Copy(array, sortedArray, array.Length);

        // Perform selection sort on the copied array
        for (int i = 0; i < sortedArray.Length; i++)
        {
            var max = sortedArray[i];
            var index = i;

            for (int j = i + 1; j < sortedArray.Length; j++)
            {
                if (sortedArray[j] > max)
                {
                    max = sortedArray[j];
                    index = j;
                }
            }
            
            // Swap values if necessary
            if (index != i)
            {
                var temp = sortedArray[i];
                sortedArray[i] = sortedArray[index];
                sortedArray[index] = temp;
            }
        }

        return sortedArray;
    }

    public static int[] AddElementToArray(int[] array, int element)
    {
        var newArray = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
            newArray[i] = array[i];

        newArray[array.Length] = element;

        return newArray;
    }

    public static int[] RemoveElementFromArray(int[] array, int element)
    {
        // Count how many elements will remain in the new array
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != element)
            {
                count++;
            }
        }

        // Create new array with the correct size
        var newArray = new int[count];

        // Fill the new array
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] != element)
            {
                newArray[j++] = array[i];
            }
        }

        return newArray;
    }
}