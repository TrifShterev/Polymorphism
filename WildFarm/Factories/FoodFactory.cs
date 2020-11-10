using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using WildFarm.Models;

namespace WildFarm.Factories
{
  public static class FoodFactory
    {
        public static Food FFactory(string[] input)
        {
           
            var foodType = input[0];
            int quantity = int.Parse(input[1]);

            Food food;

            switch (foodType)
            {
                case "Vegetable":
                    return food = new Vegetable(quantity);
                  
                case "Fruit":
                    return food = new Fruit(quantity);
                case "Meat":
                    return food = new Meat(quantity);
                case "Seeds":
                    return food = new Seeds(quantity);
                default:
                 throw new   ArgumentException($"{foodType} is not a valid Food");
            }
        }
    }
}
