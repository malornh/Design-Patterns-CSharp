using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    public class Truck : IVehicle
    {
        public string GetVehicleInfo() => "Truck Delivery Vehicle";
    }
}
