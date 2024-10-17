// ReSharper disable InvalidXmlDocComment
namespace EigthLecture_UnitTest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This is the Eighth lecture");
        Console.WriteLine();
        Console.WriteLine();
        //===============================================================//
        /// TEORIJA
        
        int length = Methods.GetTextLength("   test   ");
        Console.WriteLine(length);
        
    }

}

public class Methods
{
    public static int GetTextLength(string text, bool includeLeadSpace = false)
    {
        return !includeLeadSpace ? text.Trim().Length : text.Length;
    }
    
}