using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Mammal : Animals
    {
        public override bool ColdBlooded => false;


    }

    public class FennecFox : Mammal
    {
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

    public class DuckBilledPlatypus : Mammal
    {
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
        public override string Animal()
        {
            return "I'm a cartoon";
        }
    }
}
