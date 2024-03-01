using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_LoopsAndStringManipulation
{

    internal class peopleList
    {
        private List<Person> people;

        public peopleList()
        {
            people = new List<Person>();
        }

        public void addPersonToList(Person person)
        { 
             people.Add(person);
        }

        public void displayList() 
        {
            foreach (var item in people)
            {
                Console.WriteLine($"age: {item.age} , price: {item.price}");
            }
        }

        public uint calculatePriceForCompany()
        {
            uint sumPrice = 0; 
            foreach(var item in people)
            {
                sumPrice += item.price;
            }

            return sumPrice;
        }

        public uint getCountOfList() 
        {
            return (uint)people.Count;
        }

        public void clearList()
        {
            if (people != null)
            {
                people.Clear();
            }
        }




    }
}
