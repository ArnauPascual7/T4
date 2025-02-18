using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;
using System.Globalization;
namespace CsvProject
{
    public class Program
    {
        private const string file = "MyCsv.csv";
        private const string path = @"..\..\..\Files\" + file;

        public static void Main(string[] args)
        {
            CsvDefault();
            CsvReader();
            CsvWriter();
            CsvReader();
            CsvAppend();
            CsvReader();
        }

        private static void CsvReader()
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<Person>();
            //var livingPersons = records.Where(person => person.IsLiving).ToList();

            Console.WriteLine("Person");
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Id}: {record.Name} {record.IsLiving} {record.DateOfBirth}");
            }

            /*Console.WriteLine("Living Person");
            foreach (var record in livingPersons)
            {
                Console.WriteLine($"{record.Id}: {record.Name} {record.IsLiving} {record.DateOfBirth}");
            }*/
        }

        private static void CsvWriter()
        {
            // Sobreescriu l'arxiu
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            List<Person> records = new List<Person>
            {
                new Person { Id = 1, Name = "u", IsLiving = true, DateOfBirth = new DateTime(2010, 10, 10) },
                new Person { Id = 2, Name = "dos", IsLiving = false, DateOfBirth = new DateTime(1000, 12, 23) }
            };

            csv.WriteRecords(records);
            Debug.WriteLine("Override");
        }

        private static void CsvAppend()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            /*using var stream = File.Open(path, FileMode.Append);
            using var writer = new StreamWriter(stream);*/
            using var writer = new StreamWriter(path, append: true);

            using var csv = new CsvWriter(writer, config);
            csv.WriteRecord<Person>(new Person { Id = 3, Name = "tre", IsLiving = true, DateOfBirth = new DateTime(2300, 11, 22) });
        }

        private static void CsvDefault()
        {
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            List<Person> records = new List<Person>
            {
                new Person { Id = 1, Name = "one", IsLiving = false, DateOfBirth = new DateTime(1923, 10, 29) },
                new Person { Id = 2, Name = "two", IsLiving = true, DateOfBirth = new DateTime(2015, 11, 15) }
            };

            csv.WriteRecords(records);

        }
    }
}
