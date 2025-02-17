namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesEmployee salesEmployee = new SalesEmployee("A2", "Arnau", "Pascual", DateTime.Parse("10/2/2000"), DateTime.Parse("10/2/2020"), 0.5f);
            Console.WriteLine(salesEmployee.ToString());
            Console.WriteLine($"Employees: {Employee.EmployeesCount}");
        }
    }
}
