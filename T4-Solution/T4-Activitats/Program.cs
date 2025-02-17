namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5];
            int result = 0;

            foreach (int num in list)
            {
                result += num;
            }

            Console.WriteLine($"Suma dels elements: {result}");
        }
    }
}
