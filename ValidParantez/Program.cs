using static System.Net.Mime.MediaTypeNames;

namespace ValidParantez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ifade2 = "{}(])}";

            Console.WriteLine($"{ifade2} -> {IsValid(ifade2)}");
        }

        static public bool IsValid(string s)
        {
            Stack<char> parantezYigini = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    parantezYigini.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (parantezYigini.Count == 0)
                        return false;

                    char enUst = parantezYigini.Pop();

                    if (!Eslestir(enUst, c))
                        return false;
                }
            }

            return parantezYigini.Count == 0;

        }

        static bool Eslestir(char acilan, char kapanan)
        {
            if (acilan == '(' && kapanan == ')') return true;
            if (acilan == '{' && kapanan == '}') return true;
            if (acilan == '[' && kapanan == ']') return true;
            return false;
        }

    }
}
