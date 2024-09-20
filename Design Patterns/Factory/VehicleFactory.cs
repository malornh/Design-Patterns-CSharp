using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Factory.Vehicles;

namespace Design_Patterns.Factory
{
    public static class VehicleFactory
    {
       public static Vehicle CreateVehicle(string type)
        {
            switch (type.ToLower())
            {
                case "car": 
                    return new Car();
                case "bike":
                    return new Bike();
                case "truck":
                    return new Truck();
                default:
                    throw new ArgumentException("Unknown type of a vehicle.");
            }
        }
    }

}
