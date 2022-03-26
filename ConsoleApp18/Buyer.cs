using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Buyer : Person
    {
        protected List<Product> products = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(int index)
        {
            this.products.RemoveAt(index);
        }

        public override string Print()
        {
            if (products.Count == 0)
            {
                return $"Bayer: {Name} ({Age} y.o){Environment.NewLine}";
            }
            else
            {
                string print = $" {Environment.NewLine}Bayer: {Name} ({Age} y.o){Environment.NewLine}{Environment.NewLine}-- Products: -- {Environment.NewLine}";
                //Console.WriteLine($"Seller: {Name} ({Age} y.o)");

                foreach (var i in products)
                {
                    print += i.Print();
                }

                return print + Environment.NewLine;
            }
        }
    }
}