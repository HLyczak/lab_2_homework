using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    /*+ – element publiczny,
    # – element „chroniony” (może odpowiadać protected w języku Java),
    - – element prywatny */

    public class Person : IThing
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int Age
        {
            get => age;
            set { age = value; }
        }

        public virtual string Print() => $" {Name}, ({Age} y.o.){Environment.NewLine}";
    }
}