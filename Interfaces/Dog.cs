using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Dog : Animal, ICanine
    {
        public Dog(string name, int numberOfLegs) : base(name, numberOfLegs)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("The dog is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping...");
        }

        public void Bark()
        {
            Console.WriteLine("The dog is barking!");
        }
    }
}
