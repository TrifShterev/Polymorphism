using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
  public  class Car:Vehicle
    {

        
        public Car(double quantity, double liters)
            :base(quantity,liters+0.9)
        {
            
        }
       
     
       
    }
}

