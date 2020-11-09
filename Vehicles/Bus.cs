﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionLitersPerKm, tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
        }

        protected override double AirConditioning { get; set; } = 1.4;
    }
}
