using Xunit;

namespace CleverDevices.Tests
{
    public class Answer3
    {
        [Theory]
        [InlineData("", "", "")]
        [InlineData(null, null, "")]
        [InlineData("a", "a", "a")]
        [InlineData(" ", " ", " ")]
        [InlineData("A", "a", "a")]
        [InlineData("abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-_+=[]{};':,./<>?", "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-_+=[]{};':,./<>?", "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()-_+=[]{};':,./<>?")]
        [InlineData("Hello world!", "The ocean is blue", "helo")]
        public void Test(string a, string b, string expected)
        {
            var result = Answers.Answer3.CommonCharacters(a, b);
            Assert.Equal(expected, result);
        }
    }
}
