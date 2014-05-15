using Riss.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Riss.Devices;

namespace biometrics_server.Entity
{
    class DeviceComEty
    {
        public DeviceComEty() { }

        public DeviceConnection DeviceConnection { get; set; }

        public Device Device { get; set; }
    }
}
