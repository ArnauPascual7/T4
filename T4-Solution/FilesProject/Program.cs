using System.Text.RegularExpressions;

namespace FilesProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string file = "MyFile.txt";
            string file = "PhoneNumbers.txt";
            string path = Path.GetFullPath(@"..\..\..\Files\" + file);
            /*
            if (File.Exists(path) )
            {
                using StreamReader sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null) Console.WriteLine(line);
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No s'ha pugut llegir el fitxer");
                Console.WriteLine(ex.Message);
            }*/

            Regex regex = new Regex(@"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$");
            if (File.Exists(path))
            {
                using StreamWriter sr = new StreamWriter(path);
                string phone = "";

                Console.WriteLine("Introdueix números de telèfon, escriu Exit per sortir:");

                do
                {
                    phone = Console.ReadLine();
                    if (phone != "Exit")
                    {
                        if (!regex.IsMatch(phone)) Console.WriteLine("Format incorrecte!");
                        else sr.WriteLine(phone);
                    }
                } while (phone != "Exit");
            }
        }
    }
}
