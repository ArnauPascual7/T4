namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = [1, 2, 3, 4, 5];

            Console.WriteLine("Nombres parells:");
            foreach (int num in nums)
            {
                if (num % 2 == 0) Console.WriteLine(num);
            }
        }
    }
}
