using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
  public abstract class Feline:Mammal
    {
        public Feline(string name, double weight, string livingRegion,string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get;  }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight + FoodEaten * WeightMultiplier}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
