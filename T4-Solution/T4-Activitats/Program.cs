namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string MsgName = "Introdueix el nom:";
            const string MsgAge = "Introdueix l'edat:";
            const string MsgRes = "Valors";

            Dictionary<string, int> ages = new Dictionary<string, int>();
            string name = "";
            int age = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(MsgName);
                name = Console.ReadLine();
                Console.WriteLine(MsgAge);
                age = Convert.ToInt32(Console.ReadLine());
                ages.Add(name, age);
            }

            foreach (var item in ages)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
