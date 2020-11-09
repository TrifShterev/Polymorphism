using System;
using System.IO;

namespace Vehicles
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var inputCar = Console.ReadLine().Split();
            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]));
            var inputTruck = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var vehicle = input[1];
                var amount = double.Parse(input[2]);

                if (input[0]=="Drive")
                {
                    if (vehicle=="Car")
                    {
                        car.Drive(amount);
                    }
                    else if (vehicle=="Truck")
                    {
                        truck.Drive(amount);
                    }

                }
                else if (input[0]=="Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refueling(amount);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refueling(amount);
                    }
                }

            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
