using EigthLecture_UnitTest;

namespace EighthLecture_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetTextLength_LeadWhiteSpaceText_ReturnsLength()
    {
        //Arange
        var text = "   test   ";
        var expected = 4;
        
        //Act
        var actual = Methods.GetTextLength(text);
        
        //Assert
        Assert.AreEqual(expected, actual);
    }
        
}