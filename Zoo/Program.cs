using System;
using Zoo.Animals;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new FennecFox(),
                new DuckBilledPlatypus(),
                new DuckBilledPlatypus(),
                new BaldEagle(),
                new Chameleon(),
                new SeaTurtle(),
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Sound: {animal.Sound()}");
                Console.WriteLine($"Diet: {animal.Eat()}");
                Console.WriteLine($"Climate: {animal.Climate()}");

                if (animal is iCute cute)
                {
                    IsCute(cute);
                }
                Console.WriteLine();
            }
        }

        static void IsCute(iCute cute)
        {
            if (cute.IsCute == true)
            {
                Console.WriteLine("I'm CUTE!");
            }
            if (cute.IsCute == false)
            {
                Console.WriteLine("I'm ugly");
            }
        }
    }
}
