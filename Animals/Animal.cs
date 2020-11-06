using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Animal
    {
        public Animal(string name, string food)
        {
            Name = name;
            FavoriteFood = food;
        }
        public string  Name { get; private set; }
        public string FavoriteFood { get;private set; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavoriteFood}";
        }
    }
}
