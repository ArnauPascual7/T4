namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operation(int a, int b);
        public static int Sum(int a, int b) => a + b;
        public static void ExecuteOperation(int a, int b, Operation op) => Console.WriteLine(op(a, b));
        public static void Main(string[] args)
        {
            ExecuteOperation(10, 2, (a, b) => a * b);
            ExecuteOperation(10, 2, (a, b) => a - b);
            ExecuteOperation(10, 2, Sum);
        }
    }
}
