using AwesomeAssertions;
using JensdegTools.Extensions;

namespace JensdegTools.Test.Extensions;

public class IntExtensionsShould
{
    [Fact]
    public void ConvertNumberToLetters()
    {
        // Arrange
        var expectedResult = "a";
        var expectedResult2 = "abcdefghij";

        // Act
        var result = 1.ToLetters();
        var result2 = 1234567890.ToLetters();

        // Assert
        result.Should().NotBeEmpty();
        result.Should().Be(expectedResult);
        result2.Should().Be(expectedResult2);
    }
}
