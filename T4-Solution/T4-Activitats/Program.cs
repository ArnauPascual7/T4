namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un número:";
            const string MsgResult = "Nombres parells:";

            List<int> list = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Msg);
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine(MsgResult);
            foreach (int i in list)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }
    }
}
