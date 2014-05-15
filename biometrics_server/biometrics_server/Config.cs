using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biometrics_server
{
    class Config
    {
        public static string DB_Host;
        public static string DB_Name;
        public static string DB_User;
        public static string DB_Pass;

        //will return the connection string
        public static string getConnectionString()
        {
            return string.Format("Server={0};Database={1};Uid={2};Pwd={3};", DB_Host, DB_Name, DB_User, DB_Pass);
        }

    }
}
