using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory.Factories
{
    public class TruckDeliveryFactory : IDeliveryEmployeeFactory
    {
        public IDriver CreateDriver() => new ShipCaptain();
        public IVehicle CreateVehicle() => new Ship();
    }
}
