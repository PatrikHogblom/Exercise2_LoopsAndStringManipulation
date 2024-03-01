using System.Security.Cryptography.X509Certificates;

namespace Exercise2_LoopsAndStringManipulation
{
    internal class Program
    {
        public static peopleList peopleList = new peopleList();
        static void Main(string[] args)
        {
            //huvudmeny
            //skapa det så det håller sig vid liv
            bool programRun = true;

            while (programRun == true)
            {
                //säg till användaren att de har kommit till huvudmenyn
                Console.WriteLine("välkommen till huvudmenyn, choose one of the options below.");
                Console.WriteLine("0. Exits the program");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Add more than a person");
                string inputOption = Console.ReadLine();

                switch (inputOption)
                {

                    case "0": //stänger programmet
                        Console.WriteLine("Exits the program");
                        programRun = false;
                        break;
                    case "1"://addera person baserad på ålder
                        AddPerson();
                        break;
                    case "2"://addera mer än 1 person
                        AddMultiplePeople();
                        printPeopleAndTotalPrice();
                        //displayPeopleList();
                        peopleList.clearList();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            
            }
        }

        public static void AddPerson()
        {
            Console.WriteLine("Input your age: ");
            uint.TryParse(Console.ReadLine(), out uint age);

            Person person = new Person(age);
            Console.WriteLine(person.getPriceOfPersonMessage());
            //Console.ReadLine();
        }

        public static void AddMultiplePeople()
        {
            Console.WriteLine("Write how many people will be in your comapny: ");
            int.TryParse(Console.ReadLine(), out int totPeople);
            for (int i = 0; i < totPeople; i++)
            {
                Console.WriteLine("Input your age: ");
                uint.TryParse(Console.ReadLine(), out uint age);

                Person person = new Person(age);

                peopleList.addPersonToList(person);
            }
        }

        public static void printPeopleAndTotalPrice()
        {
            uint totalSum = peopleList.calculatePriceForCompany();
            uint totPeople = peopleList.getCountOfList(); 
            Console.WriteLine($"Total people: {totPeople}, Total cost: {totalSum:C}");
        }

        public static void displayPeopleList()
        {
            peopleList.displayList();
        }
    }
}
