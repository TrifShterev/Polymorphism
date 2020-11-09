using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public interface IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumptionLitersPerKm { get; set; }

        public double TankCapacity { get; set; }

        public void Drive(double distance, bool airConditioning);

        public void Refueled(double liters);
    }
}
