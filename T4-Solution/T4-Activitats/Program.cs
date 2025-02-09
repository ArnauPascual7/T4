namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un nom:";
            const string MsgResult = "Llista:";
            const string MsgOrderedResult = "Llista ordenada:";

            List<string> list = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Msg);
                list.Add(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(MsgResult);
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.Sort();

            Console.WriteLine();
            Console.WriteLine(MsgOrderedResult);
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
