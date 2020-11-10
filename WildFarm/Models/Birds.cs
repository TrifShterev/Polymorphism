using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Birds : Animal
    {
        public Birds(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; private set; }
        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight + FoodEaten * WeightMultiplier}, {FoodEaten}]";
        }
    }
}
