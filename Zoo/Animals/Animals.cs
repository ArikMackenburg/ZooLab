using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public abstract decimal WeightPounds { get; }
        
        

        public abstract bool ColdBlooded { get; }

        public abstract string Sound();
        public abstract string Eat();
        public abstract string Climate();
       
        public virtual string Animal()
        {
            return "I'm an animal";
        }


    }
}
