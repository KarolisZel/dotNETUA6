﻿// ReSharper disable InvalidXmlDocComment

using System.Text;

namespace LectureEleven_Debug;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the lecture Eleven");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// PRAKTIKA
        //===============================================================//
        /// DEBUG
        
        // PrintMax();
        // Console.WriteLine();
        //
        // PrintFullName();
        // Console.WriteLine();
        //
        // CountFromOneToTen();
        // Console.WriteLine();
        //
        // CountFromOneToFive();
        // Console.WriteLine();
        //
        // CompareNames();
        // Console.WriteLine();
        
        //===============================================================//
        /// STRINGBUILDER
        
        Console.Write("Enter a string: ");
        var input = Console.ReadLine();
        
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Reversed string: {ReverseString(input)}");
        Console.WriteLine();

        Console.WriteLine($"Duplicates removed: {RemoveDuplicates(input)}");
        Console.WriteLine();
        
        
    }

    private static void PrintMax()
    {
        var a = 10;
        var b = 5;
        var c = 8;

        var max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;        // max = b => max = c
        
        Console.WriteLine($"Max: {max}");
    }
    
    private static void PrintFullName()
    {
        var firstName = "John";
        var lastName = "Doe";                                    // Pašalinta eilutė (Syntactic sugar)
        Console.WriteLine($"Full name: {firstName} {lastName}"); //Kad gražiai atspausdinti, reikia naudoti tarpą
    }
    
    private static void CountFromOneToTen()
    {
        var counter = 1;                // Pradedama nuo 1, kadangi to reikalauja užduotis
        while (counter <= 10)
        {
            Console.WriteLine($"Count: {counter}");
            counter++;                  // Reikia didinti reikšmę, o ne mažinti
        }
    }

    private static void CountFromOneToFive()
    {
        var i = 1;              // Pakeistas i = 5 => i = 1
        while (i <= 5)          // Pakeistas i > 0 => i <= 5
        {
            Console.WriteLine($"Count: {i}");
            i++;
        }
    }

    private static void CompareNames()
    {
        var firstName = "John";
        var secondName = "john";
        // Pakeistas firstName.Equals(secondName) => firstName.ToLower() == secondName.ToLower()
        // Nebent norima naudoti string.Equals() metodą, tuomet reiktų abiem panaudoti ToLower() arba ToUpper() metodus
        if (firstName.ToLower() == secondName.ToLower())        
            Console.WriteLine("Names are the same");
        else
            Console.WriteLine("Names are not the same");
    }
    
    //----------------------------------------------------------------//
    
    private static string ReverseString(string str)
    {
        var reversedString = new StringBuilder();
        
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedString.Append(str[i]);
        }
        
        return reversedString.ToString();
    }

    private static string RemoveDuplicates(string str)
    {
        var duplicates = new StringBuilder();
        
        for (int i = 0; i < str.Length; i++)
        {
            if (duplicates.ToString().Contains(str[i].ToString()))
                continue;
            
            duplicates.Append(str[i]);
        }
        
        return duplicates.ToString();
    }
}