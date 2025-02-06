namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pair<string, int> pair1 = new Pair<string, int>("Hola", 1);
            Pair<double, bool> pair2 = new Pair<double, bool>(3.5d, true);

            pair1.ShowItems();
            pair2.ShowItems();
        }
    }
}
