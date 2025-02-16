namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = [5, 10, 15, 20, 25];
            list.Add(30);
            list.Insert(1, 7);
            list.Remove(15);
            list.Reverse();

            foreach (int item in list)
            {
                if (item % 2 == 0) Console.WriteLine(item);
            }
        }
    }
}
