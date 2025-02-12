using System;

namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operation(int a, int b);
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static void Main(string[] args)
        {
            Operation multiply = Multiply;
            Operation divide = Divide;
            //Operation multiply = (a, b) => a * b;
            //Operation divide = (a, b) => a / b;

            Console.WriteLine(multiply(3, 2));
            Console.WriteLine(divide(10, 2));
        }
    }
}
