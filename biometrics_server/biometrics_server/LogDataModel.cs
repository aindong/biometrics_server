using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace biometrics_server
{
    class LogDataModel
    {
        //Add biometric data to Database

        public static void syncData(ref ListView lstBiometricData)
        {
            for (int ctr = 0; ctr < lstBiometricData.Items.Count; ctr++)
            {
                string id = lstBiometricData.Items[ctr].SubItems[2].Text;
                
                using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                {
                    con.Open();
                    string sql = "SELECT ";
                }
            }
            
        }
    }
}
