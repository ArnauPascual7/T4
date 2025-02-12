namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetDayOfWeek());
        }
        public static DayOfWeek GetDayOfWeek() => DateTime.Now.DayOfWeek;
    }
}
