namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> multiply = (a, b) => a * b;
            Console.WriteLine(multiply(2, 3));
            Action<int, int> printSum = (a, b) => Console.WriteLine((a + b));
            printSum(2, 2);
        }
    }
}
