namespace T4_Activitats
{
    public class Program
    {
        public delegate void Notification(string msg);
        public static void ExecutarAmbMetodeAnonim(Notification notification) => notification("a");
        public static void Main(string[] args)
        {
            ExecutarAmbMetodeAnonim(delegate (string msg) { Console.WriteLine(msg); } );
        }
    }
}
