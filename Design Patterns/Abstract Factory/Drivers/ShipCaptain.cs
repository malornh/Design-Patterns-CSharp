using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    public class ShipCaptain : IDriver
    {
        public string GetLicenseInfo() => "Ship License Capitan";
    }
}
