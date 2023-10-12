namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf("Wolf",4);
            Dog dog = new Dog("Dog",4);
            Lion lion = new Lion("Lion", 4);

            List<Animal> animals = new List<Animal>()
            {
                wolf, dog, lion
            };

            foreach (Animal animal in animals)
            {
                animal.Eat();
                animal.Sleep();

                if(animal is ICanine)
                {
                    ICanine canine = (ICanine) animal;
                    canine.Bark();
                }

                else if(animal is IFeline)
                {
                    IFeline feline = (IFeline) animal;
                    feline.Meow();
                }

                Console.WriteLine($"The {animal.Name} has {animal.NumberOfLegs} legs");

            }
        }
    }
}