using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Product
    {
        private string name;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Product(string Name)
        {
            this.Name = name;
        }

        public void Print(string prefix) => Console.WriteLine(prefix);
    }
}