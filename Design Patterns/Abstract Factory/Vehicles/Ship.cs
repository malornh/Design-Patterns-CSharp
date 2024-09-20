using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    public class Ship : IVehicle
    {
        public string GetVehicleInfo() => "Ship Delivery Vehicle";
    }
}
