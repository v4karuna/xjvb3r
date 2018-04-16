using Xunit;
using CleverDevices.Answers;

namespace CleverDevices.Tests
{
    public class Answer1
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void NullEmptyOrWhiteSpace(string input)
        {
            var output = Answers.Answer1.ReverseSentenceWords(input);
            Assert.Equal(output, string.Empty);
        }

        [Theory]
        [InlineData("a","a")]
        [InlineData("a!", "a")]
        [InlineData("?", "")]
        [InlineData("a b", "b a")]
        [InlineData(" ab cd ef  gh.", "gh ef cd ab")]
        [InlineData("one two one", "one two one")]
        public void SimpleSentences(string input, string expectedResult)
        {
            var output = Answers.Answer1.ReverseSentenceWords(input);
            Assert.Equal(expectedResult, output);
        }


    }
}
