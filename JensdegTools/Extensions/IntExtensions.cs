namespace JensdegTools.Extensions;

/// <summary>
/// Provides extension methods for ints.
/// </summary>
public static class IntExtensions
{
    /// <summary>
    /// Converts the digits of the specified integer to their corresponding letter representations.
    /// </summary>
    /// <remarks>This method processes each digit of the integer individually and maps it to a letter
    /// based on a predefined mapping. For example, the integer 123 will be converted to "abc".</remarks>
    /// <param name="value">The integer value to convert. Each digit in the integer is mapped to a specific letter.</param>
    /// <returns>A string where each digit of the input integer is replaced by a corresponding letter: '1' becomes 'a', '2'
    /// becomes 'b', ..., '9' becomes 'i', and '0' becomes 'j'.</returns>
    public static string ToLetters(this int value)
    {
        var valueString = value.ToString();
        var result = string.Empty;
        foreach (char c in valueString)
        {
            var numberString = c switch
            {
                '1' => "a",
                '2' => "b",
                '3' => "c",
                '4' => "d",
                '5' => "e",
                '6' => "f",
                '7' => "g",
                '8' => "h",
                '9' => "i",
                '0' => "j",
                _ => "z"
            };
            result += numberString;
        }
        return result;
    }
}
