using System.Collections;

namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string Msg = "Introdueix un valor:";
            const string MsgRes = "Valors:";

            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Msg);
                arrayList.Add(Console.ReadLine());
            }

            Console.WriteLine(MsgRes);
            foreach (string item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
