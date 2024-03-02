namespace Exercise2_LoopsAndStringManipulation
{
    internal class Program
    {
        public static peopleList peopleList = new peopleList();

        /// <summary>
        /// Creates a main menu with five options to choose between:
        /// 0. Exits the program
        /// 1. you input your age and get a price of a cinema ticket according to your age
        /// 2. you input total people that will accompany to cinema and then input the age for each people. 
        /// And lastly the total people and the calculated price will be printed 
        /// 3. Repeats your input text ten times on a row, i.e. 1. input, 2.input, ..., 10.input
        /// 4. in the last option, you input a string and the program will print the third word that occured in your text
        /// </summary>
        static void Main(string[] args)
        {
            bool programRun = true;//bool variable to keep the program alive

            while (programRun == true)
            {
                //Tells the user you are in the main menu and what options exists in the program
                Console.WriteLine("\nWelcome to menu, choose one of the options below.");
                Console.WriteLine("0. Exits the program");
                Console.WriteLine("1. Add person and get the price for a cinema ticket");
                Console.WriteLine("2. Add more than a person and get the total price for all tickes");
                Console.WriteLine("3. Write the input and repeat it ten times on a row");
                Console.WriteLine("4. Prints the third word of the input\n");

                string inputOption = Console.ReadLine();

                switch (inputOption)
                {

                    case "0": //closes the program
                        Console.WriteLine("Exits the program");
                        programRun = false;
                        break;
                    case "1"://get the ticket price from an added person based on thier age
                        AddPerson();
                        break;
                    case "2"://add a company of people, inputs thier age and then calculates thier total price 
                        AddMultiplePeople();
                        printPeopleAndTotalPrice();
                        //displayPeopleList();
                        peopleList.clearList();
                        break;
                    case "3"://print the users input 10 times on a row 
                        repeatTenTimes();
                        break;
                    case "4"://user writes a text, and we get print of 3:rd placed word  in the text 
                        getInputAnPrintWordAtIndex(3);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }


        /// <summary>
        /// Tells the user to input thier age and gets the price using Person object class functions
        /// </summary>
        /// 
        public static void AddPerson()
        {
            //promts the user to input thier age
            Console.WriteLine("Input your age: ");
            bool sucess = false;
            do
            {
                //a if statement for the input should be of a specific datatype
                if (uint.TryParse(Console.ReadLine(), out uint age))
                {
                    Person person = new Person(age);//creates a object of a person with a specific age
                    Console.WriteLine(person.getPriceOfPersonMessage());//prints the price of the ticket
                    sucess = true;//tells to exit the loop
                }
                else//if datatype input was wrong then send a message for it was invalid input and promts the user to try again 
                {
                    Console.WriteLine("Invalid Input, try again");
                }

            } while (!sucess);

        }

        /// <summary>
        /// Inputs total comapny of people the user have and then tells the user to input the age 
        /// for each person. Each person will be stored in the peopleList class.  
        /// </summary>
        public static void AddMultiplePeople()
        {
            bool sucessTotPepole = false;
            do
            {
                Console.WriteLine("Write how many people will be in your company: ");
                //Reads the input of totPeople and checks so that we have right datatype in the input 
                if (int.TryParse(Console.ReadLine(), out int totPeople))
                {
                    for (int i = 1; i <= totPeople; i++)
                    {
                        bool sucessInputAge = false;
                        do
                        {
                            Console.WriteLine($"Input {i}. Insert age: ");
                            //reads the input of age and checks so that we have right datatype in the input 
                            if (uint.TryParse(Console.ReadLine(), out uint age))
                            {
                                Person person = new Person(age);
                                peopleList.addPersonToList(person);//add the person to a object list  
                                sucessInputAge = true;//exits the loop if we have input correct age
                            }
                            else
                            {
                                Console.WriteLine("Invalid age input, input 0 and up");
                            }

                        } while (!sucessInputAge);
                    }
                    sucessTotPepole = true;//exits the loop if we have input of total people
                }
                else
                {
                    Console.WriteLine("ivalid input! Please insert a value from 0 and up");
                }

            } while (!sucessTotPepole);
        }

        /// <summary>
        /// prints the total pepole we have in the list and the calculated price of tickets 
        /// of the company
        /// </summary>
        public static void printPeopleAndTotalPrice()
        {
            uint totalSum = peopleList.calculatePriceForCompany();
            uint totPeople = peopleList.getCountOfList();
            Console.WriteLine($"Total people: {totPeople}, Total cost: {totalSum:C}");
        }

        /// <summary>
        /// Displays the list of people(i.e. only currently age and price) in the list
        /// </summary>
        public static void displayPeopleList()
        {
            peopleList.displayList();
        }

        /// <summary>
        /// Prints your input text 10 times in a single row,
        /// i.e. 1. input, 2. input, ...., 10. input
        /// </summary>
        public static void repeatTenTimes()
        {
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
        }

        /// <summary>
        /// We propmt the user to insert thier input, there after we store each word in 
        /// a array using split function. Lastly we print the word of a choosen position(for now we print the 
        /// third word).  
        /// </summary>
        /// <param name="index">placement of the word we want to print out</param>
        public static void getInputAnPrintWordAtIndex(int index)
        {
            bool sucess = false;
            string[] wordsList;
            do
            {
                Console.WriteLine("Please enter a text with at least 3 words");
                var inputText = Console.ReadLine();
                wordsList = inputText.Split(" ");//stores evey word split up by space in a implicict array.  

                //if we have 3 or more words, then exit the do-loop since we have right amount
                //of text in the input
                if (wordsList.Length >= 3)//if we have correct amount words then exit the do-loop
                {
                    sucess = true;
                }
                else//if we have smaller than 3 words, prompt the user to input more words
                {
                    Console.WriteLine("Please enter more words!");
                }

            } while (!sucess);

            //prints currently the thrid stored word from the string array
            Console.WriteLine(wordsList[index - 1]);
        }
    }
}
