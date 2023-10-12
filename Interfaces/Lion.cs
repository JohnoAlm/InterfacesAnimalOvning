using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Lion : Animal, IFeline
    {
        public Lion(string name ,int numberOfLegs) : base(name, numberOfLegs)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The lion is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("The lion is sleeping...");
        }

        public void Meow()
        {
            Console.WriteLine("The lion is meowing!");
        }
    }
}
