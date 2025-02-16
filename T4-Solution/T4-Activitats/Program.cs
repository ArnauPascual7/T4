namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsSecondDatePosterior());
        }
        public static bool IsSecondDatePosterior()
        {
            Console.WriteLine("Introdueix dues dates (dd, mm, yyyy - dd, mm, yyyy):");
            string[] array = Console.ReadLine().Split("-");

            DateTime dt1 = DateTime.Parse(array[0]);
            DateTime dt2 = DateTime.Parse(array[1]);

            return dt1 < dt2;
        }
    }
}
