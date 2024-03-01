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
                Console.WriteLine("Welcome to menu, choose one of the options below.");
                Console.WriteLine("0. Exits the program");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Add more than a person");
                Console.WriteLine("3. write the input and repeat it ten times on a row");
                Console.WriteLine("4. divide the input by each space and add it to a array");

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
                    case "3"://skriv det text användaren har srivit 10 ggr

                        Console.WriteLine("Write the text you want to repeat 10 times: ");
                        string input = Console.ReadLine();

                        string text = "";
                        for (int i = 1; i <= 10; i++)
                        {
                            text += $"{i}. {input}";
                            if (i != 10)
                            {
                                text += ", ";
                            }
                        }

                        Console.WriteLine(text);
                        break;
                    case "4":
                        bool sucess = false;
                        string[] wordsList;
                        do
                        {
                            Console.WriteLine("Please enter a text with at least 3 words");
                            var inputText = Console.ReadLine();
                            wordsList = inputText.Split(" ");

                            //om vi har 3 eller mer så gå avsluta loopen
                            if(wordsList.Length >= 3)
                            {
                                sucess = true;
                            }

                        } while (!sucess);

                        //print the thrid string of the text
                        string thirdString = wordsList[2];
                        Console.WriteLine(thirdString);
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
            bool sucessTotPepole = false;
            do
            {
                Console.WriteLine("Write how many people will be in your company: ");
                //Check so that we have right datatype in the input 
                if (int.TryParse(Console.ReadLine(), out int totPeople))
                {
                    for (int i = 1; i <= totPeople; i++)
                    {
                        bool sucessInputAge = false;
                        do 
                        {
                            Console.WriteLine($"Input {i}. Insert age: ");
                            //Check so that we have right datatype in the input 
                            if (uint.TryParse(Console.ReadLine(), out uint age))
                            {
                                Person person = new Person(age);
                                peopleList.addPersonToList(person);
                                sucessInputAge = true;
                            }
                            else
                            {
                                Console.WriteLine("Please insert a value from 0 and up");
                            }

                        } while (!sucessInputAge);
                    }
                    sucessTotPepole = true;
                }
                else
                {
                    Console.WriteLine("Please insert a value from 0 and up");
                }

            } while (!sucessTotPepole);
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
