namespace One
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 2, 7, 11, 15 };

            var target = 9;

            // TwoSum metodunu çağır ve sonucu al
            var result = TwoSum(arr, target);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            Console.ReadLine();
        }



        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length >= 2)
            {
                for (var i = 0; i <= nums.Length - 1; i++)
                {

                    for (var j = i + 1; j <= nums.Length - 1; j++)
                    {
                        if (target == nums[i] + nums[j])
                        {
                            return new int[] { i, j };
                        }

                    }
                }

            }


            throw new ArgumentException("Target bulunumadı!");
        }
    }
}
