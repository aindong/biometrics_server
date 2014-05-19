using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Riss.Devices;

namespace biometrics_server.Business {
    public class InitData {
        public static readonly DateTime MinDateTime = new DateTime(2010, 01, 01, 0, 0, 0);

        public static readonly DateTime MaxDateTime = new DateTime(2099, 12, 31, 23, 59, 59);

        private InitData() { }

        public static void InitAlarmDN(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.BellGroupCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitValidAttendTimeDN(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.MaxValidAttendTimeCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitTimerOnOffDN(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.PowerTimeCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitHour(ComboBox cbo) {
            for (int i = 0; i <= 23; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitMinuteOrSecond(ComboBox cbo) {
            for (int i = 0; i <= 59; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitZoneNo(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.TimeZoneCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitGroupNo(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.GroupTimeCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitHolidayNo(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.MaxHolidayCount; i++) {
                cbo.Items.Add(i);
            }
        }

        public static void InitMessageSN(ComboBox cbo) {
            for (int i = 1; i <= Zd2911Utils.MaxDeviceMessageCount; i++) {
                cbo.Items.Add(i);
            }
        }
    }
}
