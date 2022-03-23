using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Meat : Product
    {
        private double weight;

        public double Weight
        {
            get => weight;
            set { weight = value; }
        }

        public Meat(string name, double weight) : base(name)
        {
            this.Weight = weight;
        }

        public void Print(string prefix) => Console.WriteLine(prefix);
    }
}