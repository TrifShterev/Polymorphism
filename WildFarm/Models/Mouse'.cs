using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
  public  class Mouse: Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }
        public override double WeightMultiplier => 0.10;
        public override string ProduceSound()
        {
            return "Squeak";

        }
        protected override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                Throw(food);
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight + FoodEaten * WeightMultiplier}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
