namespace RomanNumberConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var romanString = "MCMXCIV";

            var result = RomanToInt(romanString);

            Console.WriteLine(result);
            Console.ReadLine();


        }


        static public int RomanToInt(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},

            };

            int answer = 0;
            int number = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                number = keyValuePairs[s[i]];


                if (4 * number < answer)
                    answer -= number;
                else
                    answer += number;
            }

            return answer;

        }
    }
}


//Example 1:

//Input: s = "III"
//Output: 3
//Explanation: III = 3.
//Example 2:

//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V = 5, III = 3.
//Example 3:

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.