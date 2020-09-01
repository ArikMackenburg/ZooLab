using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Mammal : Animal
    {
        public override bool ColdBlooded => false;


    }

    public class FennecFox : Mammal, iDrinkMilk, iCute
    {
        public bool IsCute { get => true; }
        public bool DrinkMilk { get => true; }
        public override decimal WeightPounds => 2.2m;

        public override string Sound()
        {
            return "Fox Noises";
        }
        public override string Eat()
        {
            return "Omnivore";
        }
        public override string Climate()
        {
            return "Desert";
        }
    }

    public class DuckBilledPlatypus : Mammal, iDrinkMilk, iCute
    {
        public bool IsCute { get => false; }
        public bool DrinkMilk { get => true; }
        public DuckBilledPlatypus()
        {
            Name = "Perry";
        }        
        public override decimal WeightPounds => 3m;

        public override string Sound()
        {
            return "My name is Perry";
        }
        public override string Eat()
        {
            return "Carnivore";
        }
        public override string Climate()
        {
            return "Australia";
        }
        public override string Origin()
        {
            return "I'm a cartoon";
        }
    }
}
