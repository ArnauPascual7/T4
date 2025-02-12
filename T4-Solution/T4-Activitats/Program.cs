namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operation(int a, int b);
        public static void Main(string[] args)
        {
            Operation power = (a, b) => (int)Math.Pow(a, b);
            Func<int, int, double> pow = (a, b) => Math.Pow(a, b);
            Console.WriteLine(power(2, 2));
            Console.WriteLine(pow(2, 3));
        }
    }
}
