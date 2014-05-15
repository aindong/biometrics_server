using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biometrics_server
{
    class Config
    {
        public static string DB_Host = Properties.Settings.Default.DB_Host;
        public static string DB_Name = Properties.Settings.Default.DB_Name;
        public static string DB_User = Properties.Settings.Default.DB_User;
        public static string DB_Pass = Properties.Settings.Default.DB_Pass;

        public static void saveSettings()
        {
            Properties.Settings.Default.DB_Host = DB_Host;
            Properties.Settings.Default.DB_Name = DB_Name;
            Properties.Settings.Default.DB_User = DB_User;
            Properties.Settings.Default.DB_Pass = DB_Pass;

            //save settings
            Properties.Settings.Default.Save();
        }

        //will return the connection string
        public static string getConnectionString()
        {
            return string.Format("Server={0};Database={1};Uid={2};Pwd={3};", DB_Host, DB_Name, DB_User, DB_Pass);
        }

    }
}
