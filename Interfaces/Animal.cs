using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Animal : ILegs
    {
        public string Name { get; }

        public int NumberOfLegs { get; }

        public Animal(string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

        public abstract void Eat();

        public abstract void Sleep();
    }
}
