using LectureTwelve_Arrays;

namespace LectureTwelve_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SquareArray_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = new int[] { };
        int[] expected = new int[] { };

        // Act
        int[] result = Program.GetSquareArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void SumArray_WithMixedNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int[] input = new int[] { 1, -2, 3, -4 };
        int expected = -2;

        // Act
        int result = Program.GetSumArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void MaxArray_WithMixedNumbers_ReturnsMax()
    {
        // Arrange
        int[] input = new int[] { -2, 0, 3, -1 };
        int expected = 3;

        // Act
        int result = Program.GetMaxArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void StringToCharArray_WithMultipleCharacters_ReturnsCorrectCharArray()
    {
        // Arrange
        string input = "Test";
        char[] expected = new char[] { 'T', 'e', 's', 't' };

        // Act
        char[] result = Program.StringToCharArray(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetFirstLetter_WithLeadingSpacesAndNumbers_ReturnsFirstLetter()
    {
        // Arrange
        string input = "   6485Spaces before letter.";
        char expected = 'S';

        // Act
        char result = Program.GetFirstLetter(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetLastLetter_WithMixedCharacters_ReturnsLastLetter()
    {
        // Arrange
        string input = "abc123";
        char expected = 'c';

        // Act
        char result = Program.GetLastLetter(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void SortArrayAscending_HandlesNegativeNumbersAndDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { -5, -1, -3, 2, 0, 0, 2 };
        int[] expected = { -5, -3, -1, 0, 0, 2, 2 };

        // Act
        var result = Program.SortArrayAscending(array);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void SortArrayDecending_HandlesNegativeNumbersAndDuplicates_ReturnsSortedArray()
    {
        // Arrange
        int[] array = { -5, -1, -3, -3, 2, 0, 0, 2 };
        int[] expected = { 2, 2, 0, 0, -1, -3, -3, -5 };

        // Act
        var result = Program.SortArrayDecending(array);

        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void AddElementToArray_AddsElementToEndOfArray_ReturnsNewArray()
    {
        // Arrange
        int[] array = { 1, 2, 3 };
        int element = 4;
        int[] expected = { 1, 2, 3, 4 };

        // Act
        var result = Program.AddElementToArray(array, element);

        // Assert
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void RemoveElementFromArray_RemovesMultipleOccurrences()
    {
        // Arrange
        int[] array = { 1, 2, 3, 2, 4, 2, 5 };
        int elementToRemove = 2;
        int[] expected = { 1, 3, 4, 5 };

        // Act
        var result = Program.RemoveElementFromArray(array, elementToRemove);

        // Assert
        Assert.AreEqual(expected, result);
    }
}