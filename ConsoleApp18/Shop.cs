using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Shop : IThing
    {
        private String name;
        private Person[] people;
        private Product[] products;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.Name = name;
            this.people = people;
            this.products = products;
        }

        public void Print(string prefix) => Console.WriteLine(prefix);
    }
}