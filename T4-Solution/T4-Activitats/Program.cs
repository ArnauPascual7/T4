namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, float> employees = new Dictionary<string, float>();
            employees.Add("A", 1000.99f);
            employees.Add("B", 2222.22f);

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Key}: {employee.Value}");
            }
        }
    }
}
