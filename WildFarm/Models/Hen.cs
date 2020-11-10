using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Hen : Birds
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }
        public override double WeightMultiplier => 0.35;
        public override string ProduceSound()
        {
            return "Cluck";
        }

        protected override void ValidateFood(Food food)
        {
            
        }
    }
}
