using System;
using System.Collections.Generic;
using System.Text;

namespace biometrics_server
{
    public class Global
    {
        private Global() { }

        /// <summary>
        /// 设备处于繁忙状态
        /// </summary>
        public const long DeviceBusy = 1;

        /// <summary>
        /// 设备处于空闲状态
        /// </summary>
        public const long DeviceIdle = 0;
    }
}
