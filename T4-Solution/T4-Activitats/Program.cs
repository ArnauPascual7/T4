namespace T4_Activitats
{
    public class Program
    {
        public delegate void Notification(string message);
        public static void ShowMsgConsole(string message) => Console.WriteLine(message);
        public static void ShowMsgStars(string message) => Console.WriteLine($"**{message}**");
        public static void Main(string[] args)
        {
            Notification notifications = ShowMsgConsole;
            notifications += ShowMsgStars;

            notifications("Hola");
        }
    }
}
