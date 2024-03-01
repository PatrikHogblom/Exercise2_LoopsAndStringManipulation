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

    internal class Person
    {
        public uint age;
        public uint price;

        public Person() { }
        public Person(uint age)
        {
            this.age = age;
        }

        public string getPriceOfPersonMessage()
        {
            if (age < 20)//Ungdompris
            {
                this.price = (uint)Prices.youth;
                return $"Ungdompris: {price:C}";
            }
            else if (age > 64)//Pensionärspris
            {
                this.price = (uint)Prices.senior;
                return $"Pensionärspris: {price:C}";
            }
            else //standardpris
            {
                this.price = (uint)Prices.standard;
                return $"Standardpris: {price:C}";
            }
        }

    }
}
