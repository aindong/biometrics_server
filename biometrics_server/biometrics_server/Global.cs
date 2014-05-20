using System;
using System.Collections.Generic;
using System.Text;

namespace biometrics_server
{
    public class Global
    {
        private Global() { }

        /// <summary>
        /// Busy flag, this flag is set to 1 whenever the device is busy doing other process
        /// </summary>
        public const long DeviceBusy = 1;

        /// <summary>
        /// Idle flag, this flag is set to 1 whenever the device is in idle state
        /// </summary>
        public const long DeviceIdle = 0;
    }
}
