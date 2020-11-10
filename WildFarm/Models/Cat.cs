using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }
        public override double WeightMultiplier => 0.30;
        public override string ProduceSound()
        {
            return "Meow";

        }
        protected override void ValidateFood(Food food)
        {
            var type = food.GetType().Name;

            if (type!= nameof(Meat)&&type!=nameof(Vegetable))
            {
                Throw(food);
            }
        }
        //public override string ToString()
        //{
        //    return base.ToString() + $"{Weight + FoodEaten * WeightMultiplier}, {LivingRegion}, {FoodEaten}]";
        //}
    }
}
