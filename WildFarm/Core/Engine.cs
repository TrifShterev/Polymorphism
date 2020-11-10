using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factories;
using WildFarm.Models;
using WildFarm.Models.Contracts;

namespace WildFarm.Core
{
    public class Engine : IRun
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                Animal animal = AnimalFactory.AFactory(command.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());
                Food food = FoodFactory.FFactory(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
