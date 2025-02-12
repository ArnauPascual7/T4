namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix una data:";
            const string MsgRes = "Dies restants: {0}";
            const string Err = "Data incorrecte";

            DateTime dateTime;
            Console.WriteLine(Msg);
            // dateTime = DateTime.Parse(Console.ReadLine());
            while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.WriteLine(Err);
            }

            Console.WriteLine(MsgRes, (dateTime - DateTime.Today).Days);
        }
    }
}
