using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biometrics_server
{
    class Config
    {
        /// <summary>
        /// This is the host or the ip of the mysql database
        /// </summary>
        public static string DB_Host = Properties.Settings.Default.DB_Host;

        /// <summary>
        /// This is the database name that you want to access
        /// </summary>
        public static string DB_Name = Properties.Settings.Default.DB_Name;

        /// <summary>
        /// Username of the account to access the database
        /// </summary>
        public static string DB_User = Properties.Settings.Default.DB_User;

        /// <summary>
        /// Password of the user in the database
        /// </summary>
        public static string DB_Pass = Properties.Settings.Default.DB_Pass;

        /// <summary>
        /// Save all the settings in the binary configuration of the system, to save states
        /// </summary>
        public static void saveSettings()
        {
            Properties.Settings.Default.DB_Host = DB_Host;
            Properties.Settings.Default.DB_Name = DB_Name;
            Properties.Settings.Default.DB_User = DB_User;
            Properties.Settings.Default.DB_Pass = DB_Pass;

            //save settings
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Get all the credentials on the variables and concatenate them to create 
        /// a connectionstring
        /// </summary>
        /// <returns>String - Connectionstring</returns>
        public static string getConnectionString()
        {
            return string.Format("Server={0};Database={1};Uid={2};Pwd={3};", DB_Host, DB_Name, DB_User, DB_Pass);
        }

    }
}
