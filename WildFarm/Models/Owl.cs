using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Owl : Birds
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }
        public override double WeightMultiplier => 0.25;
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                this.Throw(food);
            }
        }
    }
}
