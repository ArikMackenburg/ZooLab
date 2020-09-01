using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Reptile : Animal
    {
        public override bool ColdBlooded => true;
        public abstract bool Venomous { get; }
       
    }

    public class Chameleon : Reptile, iLayEggs
    {
        public bool LayEggs { get => true; }
        public override decimal WeightPounds => 0.9m;

        public override bool Venomous => false;

        public override string Sound()
        {
            return "I'm a F****n Ninja";
        }
        public override string Eat()
        {
            return "Carnivore";
        }
        public override string Climate()
        {
            return "Nobody knows cause it's invisible";
        }
    }

    public class SeaTurtle : Reptile, iLayEggs
    {
        public bool LayEggs { get => true; }
        public SeaTurtle()
        {
            Name = "Squirt";
        }
        public override decimal WeightPounds => 700;
        public override bool Venomous => false;

        public override string Sound()
        {
            return "Sweeeeet";
        }
        public override string Eat()
        {
            return "Herbivore";
        }
        public override string Climate()
        {
            return "Surfing the seven seas";
        }
        public override string Origin()
        {
            return "I'm a cartoon";
        }

    }
}
