using System.Linq;

namespace CleverDevices.Answers
{
    public static class Answer1
    {
        /// <summary>
        /// Reverses the order of words of a sentence.
        /// Note - if more than one sentance is present in input, only the first sentence is reversed!
        /// Note - '.', '?', '!' is used as a delimiter to extract a sentence from the input string
        /// </summary>
        /// <param name="input">Input sentence</param>
        /// <returns>Reversed words</returns>
        public static string ReverseSentenceWords(string input)
        {
            //handle null, empty, or whitespace
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            //split the string using delimiters and get the first sentence value
            var sentences = input.Split(new char[] { '.', '?', '!' });
            var firstSentence = sentences[0];

            //split sentence words using space/whitespace as delimiters
            var words = firstSentence.Split(new char[] { ' ', '\t' });

            //reverse word array and join strings together to get output string
            var output = string.Join(" ", words.Where(x=>!string.IsNullOrWhiteSpace(x)).Reverse());
            output = output.TrimEnd();

            return output;
        }
    }
}
