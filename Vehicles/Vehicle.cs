using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public class Vehicle
    {
        
       
        private double fuelConsumption;
        public Vehicle(double quantity, double liters)
        {
            FuelQuantity = quantity;
            fuelConsumption = liters;
        }
        public double FuelQuantity { get; set; }
        public virtual void Drive(double distance)
        {

            var fuel = this.FuelQuantity;
            this.FuelQuantity -= (this.fuelConsumption) * distance;
            if (this.FuelQuantity > 0)
            {
                Console.WriteLine($"{this.GetType()} travelled {distance} km");
            }
            else
            {
                this.FuelQuantity = fuel;
                Console.WriteLine($"{this.GetType()} needs refueling");
            }

        }
        public virtual void Refueling(double liters)
        {
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType()}: {this.FuelQuantity:f2}";
        }
    }
}

