using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Animals
    {
        private string name;
        private string favoriteFood;
        public Animals(string name, string food)
        {
            this.name = name;
            this.favoriteFood = food;
        }
       

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my fovourite food is {this.favoriteFood}";
        }
    }
}
