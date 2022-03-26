using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Product : IThing
    {
        private string name;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public Product(string name)
        {
            this.Name = name;
        }

        public virtual string Print()
        {
            return $" {Environment.NewLine}){Environment.NewLine}";
            //Console.WriteLine($"Seller: {Name} ({Age} y.o)");
        }
    }
}