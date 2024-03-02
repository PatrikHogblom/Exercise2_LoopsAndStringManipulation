using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_LoopsAndStringManipulation
{
    /// <summary>
    /// Represents a list of people added from the object Person, so we will 
    /// currently get a list on age and price  
    /// </summary>
    internal class peopleList
    {
        private List<Person> people;
        /// <summary>
        /// Initalizes a new instance of the <see cref="peopleList"/> class
        /// </summary>
        public peopleList()
        {
            people = new List<Person>();
        }

        /// <summary>
        /// adds a person to the list
        /// </summary>
        /// <param name="person">the persons age and price is added to the list</param>
        public void addPersonToList(Person person)
        { 
             people.Add(person);
        }

        /// <summary>
        /// displays the list
        /// </summary>
        public void displayList() 
        {
            foreach (var item in people)
            {
                Console.WriteLine($"age: {item.age} , price: {item.price}");
            }
        }

        /// <summary>
        /// Calculates the total price for all people added in the list  
        /// </summary>
        /// <returns>the total price of tickets for the company of people based on thier ages</returns>
        public uint calculatePriceForCompany()
        {
            uint sumPrice = 0; 
            foreach(var item in people)
            {
                sumPrice += item.price;
            }

            return sumPrice;
        }
        /// <summary>
        /// Counts how many people we have in the list
        /// </summary>
        /// <returns></returns>
        public uint getCountOfList() 
        {
            return (uint)people.Count;
        }

        /// <summary>
        /// Clears the list of people
        /// </summary>
        public void clearList()
        {
            if (people != null)
            {
                people.Clear();
            }
        }

    }
}
