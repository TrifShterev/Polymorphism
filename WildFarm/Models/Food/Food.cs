using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public abstract class Food : IFoodable
    {
        public Food(int foodQuantity)
        {
            this.FoodQuantity = foodQuantity;
        }
        public virtual int FoodQuantity { get; }
    }
}
