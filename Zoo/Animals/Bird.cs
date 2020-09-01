using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Bird : Animal
    {
        public override bool ColdBlooded => false;
    }

    public class BaldEagle : Bird ,iLayEggs
    {
        public override decimal WeightPounds => 10.25m;

        public bool LayEggs { get => true; }

        public override string Sound()
        {
            return "I bust nuts during freefall";
        }
        public override string Eat()
        {
            return "Carnivore";
        }
        public override string Climate()
        {
            return "Murica!";
        }
    }
}
