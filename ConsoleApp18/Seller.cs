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

        public override string Print() => $"Seller: {Name} ({Age} y.o)";
    }
}