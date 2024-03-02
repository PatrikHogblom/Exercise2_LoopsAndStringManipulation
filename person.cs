using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_LoopsAndStringManipulation
{
    internal enum Prices 
    {
        standard = 120,
        youth = 80,
        senior = 90
    }

    ///<summary>
    ///represents a class of one person with an age and associated price category
    ///</summary>
    internal class Person
    {
        /// <summary>
        /// the age of a person
        /// </summary>
        public uint age;
        /// <summary>
        /// the price category associated with the persons age
        /// </summary>
        public uint price;

        /// <summary>
        /// Initializes a constructor of the <see cref="Person"/> class
        /// </summary>
        public Person() { }

        /// <summary>
        /// Initializes a constructor of the <see cref="Person"/> class
        /// with a specified age
        /// </summary>
        /// <param name="age">The age of the person</param>
        /// <param name="price">The price of the person according to thier age</param>
        public Person(uint age)
        {
            this.age = age;
            price = getPriceOfPerson();
        }


        /// <summary>
        /// Determines the price category based on the persons age
        /// </summary>
        /// <returns>The price category based on the persons age</returns>
        public uint getPriceOfPerson()
        {
            if (age < 20)//Youth price
            {
                return (uint)Prices.youth;
            }
            else if (age > 64)//Senior price
            {
                return (uint)Prices.senior;
            }
            else //Standard price
            {
                return (uint)Prices.standard;
            }
        }

        /// <summary>
        /// Returns a message describing the price category based on the persons age
        /// </summary>
        /// <returns>A message of the price based on the persons age</returns>

        public string getPriceOfPersonMessage()
        {
            if (age < 20)////Youth price
            {
                return $"Ungdompris: {price:C}";
            }
            else if (age > 64)//Senior price
            {
                return $"Pensionärspris: {price:C}";
            }
            else //Standard price
            {
                return $"Standardpris: {price:C}";
            }
        }

    }
}
