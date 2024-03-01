namespace Exercise2_LoopsAndStringManipulation
{
    internal class Program
    {
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
                string inputOption = Console.ReadLine().ToLower();

                switch (inputOption)
                {
                    case "0": //stänger programmet
                        Console.WriteLine("Exits the program");
                        programRun = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            
            }


        }
    }
}
