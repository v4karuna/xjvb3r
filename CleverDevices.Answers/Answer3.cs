using System.Linq;
using System.Text;

namespace CleverDevices.Answers
{
    public static class Answer3
    {
        /// <summary>
        /// Common characters found in both strings
        /// </summary>
        /// <param name="a">string a</param>
        /// <param name="b">string b</param>
        /// <returns>string containing common characters found in a and b</returns>
        public static string CommonCharacters(string a, string b)
        {
            //null or empty check
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return string.Empty;

            //convert to lower case and distinct char array
            var distinctA = a.ToLowerInvariant().ToCharArray().Distinct();
            var distinctB = b.ToLowerInvariant().ToCharArray().Distinct();

            //loop through to find matching characters, if yes add to output
            var output = new StringBuilder();
            foreach(var character in distinctA)
            {
                if (distinctB.Contains(character))
                    output.Append(character);
            }

            return output.ToString();
        }
    }
}
