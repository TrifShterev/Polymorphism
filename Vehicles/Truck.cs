using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
  public  class Truck:Vehicle
    {
       
        
        public Truck(double quantity, double liters)
            :base(quantity,liters+1.6)
        {
            
        }

        public override void Refueling(double liters)
        {
            FuelQuantity += liters*0.95;
        }

    }
}
