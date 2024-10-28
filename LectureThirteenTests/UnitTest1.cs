using LectureThirteen;

namespace LectureThirteenTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetAverage_WithNegativeNumbers_ReturnsAverage()
    {
        // Arrange
        int[] input = new int[] { -1, -2, -3, -4, -5 };
        int expected = -3;

        // Act
        int result = Methods.GetAverage(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetAverage_WithPositiveNumbers_ReturnsAverage()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int expected = 3;

        // Act
        int result = Methods.GetAverage(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetPositive_WithMixedNumbers_ReturnsPositiveNumbers()
    {
        // Arrange
        int[] input = new int[] { 1, -2, 3, -4, 5 };
        int[] expected = new int[] { 1, 3, 5 };

        // Act
        int[] result = Methods.GetPositiveNumbers(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetPositive_WithPositiveNumbers_ReturnsPositiveNumbers()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int[] expected = new int[] { 1, 2, 3, 4, 5 };

        // Act
        int[] result = Methods.GetPositiveNumbers(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
    
    
}