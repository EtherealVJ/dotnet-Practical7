using System;
using System.Collections.Generic;
using System.Text;
using VehicleInfo;

namespace Sorting
{
        public class VGeneric
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>(10);
            vehicles.Add(new Vehicle(1,70000, "ACTIVA", VehicleType.TwoWheeler)); 
            vehicles.Add(new Vehicle(2,85000, "RICKSHAW", VehicleType.ThreeWheeler));
            vehicles.Add(new Vehicle(3,700000, "CRETA", VehicleType.FourWheeler));
            vehicles.Add(new Vehicle(4,800000, "TATA TRUCK", VehicleType.SixWheeler));
            vehicles.Add(new Vehicle(5,900000, "MAHINDRA TRUCK", VehicleType.EightWheeler));
           
       
            Console.WriteLine("\nVEHICLES SORTED AS PER NAME: ");
            VehicleSelcSort.Sort<Vehicle>(vehicles, Vehicle.CompareName);
            vehicles.Reverse();
            foreach(Vehicle v1 in vehicles)
            {
                Console.WriteLine(v1.Name);
            }

            Console.WriteLine("\nVEHICLES SORTED AS PER COST: ");
            VehicleSelcSort.Sort<Vehicle>(vehicles, Vehicle.CompareCost);
            foreach(Vehicle v1 in vehicles)
            {
                Console.WriteLine($"{v1.Name} : RS {v1.Cost}");
            }
            
            Console.WriteLine("\nVEHICLES SORTED AS PER TYPE: ");
            VehicleSelcSort.Sort<Vehicle>(vehicles, Vehicle.CompareVehicleType);
            foreach(Vehicle v1 in vehicles)
            {
                Console.WriteLine($"{v1.Name}  : {v1.vehicleType}");
            }

            
        }
    }
}