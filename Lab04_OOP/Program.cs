using System.Collections.Specialized;
using System.Threading.Channels;

namespace Lab04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDeveloper[] developers = new IDeveloper[4]
            {
                new Programmer("jun"),
                new Programmer("midl"),
                new Builder("hammer"),
                new Builder("axe")
            };

            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer);
            }
            Console.WriteLine();

            int i = 0;

            foreach (IDeveloper developer in developers)
            {
                developer.Create(i);
                i++;
            }

            Console.WriteLine();

            int j = 0;

            foreach (IDeveloper developer in developers)
            {
                developer.Destroy(j);
                j++;
            }

            Console.WriteLine();

            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer);
            }
            Console.WriteLine();



            developers[1].Tool = "jik";

            Console.WriteLine();
            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer);
            }

            List<IDeveloper> developersList = developers.ToList();
            developersList.Sort();
            developers = developersList.ToArray();

            Console.WriteLine();

            foreach (IDeveloper developer in developers)
            {
                Console.WriteLine(developer);
            }
            Console.WriteLine();

            //Dictionary

            Dictionary<string , string> persons = new Dictionary<string , string>();
            persons.Add("0001", "Sashko");
            persons.Add("0002", "Vladik");
            persons.Add("0003", "Vovochka");
            persons.Add("0004", "Vikusichka");
            persons.Add("0005", "Dinasichka");
            persons.Add("0006", "Nastachka");
            persons.Add("0007", "Irochka");


            Console.Write("Write the person id: ");
            string id = Console.ReadLine();
            try
            {
                Console.WriteLine($"Name of this id {persons[id]}");
            }
            catch
            {
                Console.WriteLine("There is no persons with this id!!!!!!!");
            }



        }
    }
}