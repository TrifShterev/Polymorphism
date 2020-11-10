using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }
        public  string Name { get; }

        public virtual double Weight { get; private set; }
        public virtual double WeightMultiplier { get; }

        public double FoodEaten { get; set; }
        protected void Throw(Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        public virtual void EatFood(Food food)
        {
            ValidateFood(food);

            this.FoodEaten += food.FoodQuantity;
        }
        protected abstract void ValidateFood(Food food);
        public virtual string ProduceSound()
        {
            return "";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
