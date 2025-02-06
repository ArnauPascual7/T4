namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parella<string, int> parella1 = new Parella<string, int>("Hola", 1);
            Parella<double, bool> parella2 = new Parella<double, bool>(3.5d, true);

            parella1.ShowItems();
            parella2.ShowItems();
        }
    }
}
