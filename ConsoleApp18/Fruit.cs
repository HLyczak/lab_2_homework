using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Fruit : Product
    {
        private int count;

        public int Count
        {
            get => count;
            set { count = value; }
        }

        public Fruit(string name, int count) : base(name)
        {
            this.Count = count;
        }

        public override string Print() => $"{Name} ({count} fruits){Environment.NewLine}";
    }
}