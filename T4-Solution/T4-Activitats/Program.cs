namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = { "a", "b", "c" };
            List<string> list = arr.ToList();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
