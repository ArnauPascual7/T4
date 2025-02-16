namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Marc", 21);
            students.Add("Laura", 19);
            students.Add("Pau", 22);

            Console.WriteLine("Diccionari");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine("Introdueix el nom d'un estudiant:");
            string name = Console.ReadLine();
            Console.WriteLine(students.ContainsKey(name) ? $"L'estudiant existeix: {name} {students[name]}" : "L'estudiant no existeix");

            students.Remove("Laura");

            Console.WriteLine("Diccionari sense Laura");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}
