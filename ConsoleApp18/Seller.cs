using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {
        }

        public void Print(string prefix) => Console.WriteLine(prefix);
    }
}