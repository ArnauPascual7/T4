namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine($"Edat: {employee.GetAge(DateTime.Parse("11/2/2010"))}");
        }
    }
}
