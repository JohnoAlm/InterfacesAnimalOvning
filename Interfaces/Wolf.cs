using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Wolf : Animal, ICanine, ILegs
    {
        public Wolf(string name, int numberOfLegs) : base(name, numberOfLegs)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("The wolf is eating...");
        }

        public override void Sleep()
        {
            Console.WriteLine("The wolf is sleeping...");
        }

        public void Bark()
        {
            Console.WriteLine("The wolf is barking!");
        }
    }
}
