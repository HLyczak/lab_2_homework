using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Buyer : Person
    {
        protected List<Product> task = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
        }

        public void AddProduct(Product product)
        { }

        public void RemoveProduct(int index)
        { }

        public void Print(string prefix) => Console.WriteLine(prefix);
    }
}