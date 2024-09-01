using System.Text;

namespace EnUzunOrtakOnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = new[] { "flower", "flow", "flight" };

            var result = LongestCommonPrefix(wordList);

            Console.WriteLine(result);
            Console.ReadLine();

        }

        static public string LongestCommonPrefix(string[] strs)
        {

            var strsShort = strs.OrderBy(str => str.Length).First();

            for (int i = 1; i < strs.Length; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();

                for (int j = 0; j < strsShort.Length; j++)
                {
                    if (strs[i][j] == strsShort[j])
                        stringBuilder.Append(strsShort[j]);
                    else
                        break;
                }

                strsShort = stringBuilder.ToString();
            }

            return strsShort;
        }

    }
}



//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.