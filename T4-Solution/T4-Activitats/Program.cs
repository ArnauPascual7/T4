using System.Collections;

namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Maria");
            arrayList.Add("Joan");
            arrayList.Add("Anna");
            arrayList.Add(42);
            arrayList.Add(true);

            Console.WriteLine("Arraylist");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove(42);
            arrayList.Remove(true);
            arrayList.Insert(2, "Pere");

            Console.WriteLine("Anna està en la llista? " + arrayList.Contains("Anna"));

            string[] array = (string[])arrayList.ToArray(typeof(string));

            Console.WriteLine("Array de Strings");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
