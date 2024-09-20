using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory.Factories
{
    public class ShipDeliveryFactory : IDeliveryEmployeeFactory
    {
        public IDriver CreateDriver() => new TruckDriver();
        public IVehicle CreateVehicle() => new Truck();
    }
}
