namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sayi = 121;

            var result = IsPalindrome(sayi);


            Console.WriteLine(result);
            Console.ReadLine();
        }



        static public bool IsPalindrome(int sayi)
        {
            char[] sayiArr = sayi.ToString().ToCharArray();

            var sayiRevers = sayiArr.Reverse().ToArray();
            

            if (new string(sayiRevers) == new string(sayiArr))
                return true;
            else
                return false;

        }

    }
}
