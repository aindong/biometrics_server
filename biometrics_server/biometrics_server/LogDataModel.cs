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
                //get listview data and store it to variable
                string id = lstBiometricData.Items[ctr].SubItems[2].Text;
                string verifyMode = lstBiometricData.Items[ctr].SubItems[3].Text;
                if (verifyMode == "F C P I")
                {
                    MessageBox.Show("True");
                    break;
                }
                string type = lstBiometricData.Items[ctr].SubItems[4].Text; //action (timeIn, timeOut etc)
                string attendanceDate = lstBiometricData.Items[ctr].SubItems[5].Text;
                DateTime dateNow = DateTime.Now;
                try
                {
                    using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                    {
                        con.Open();

                        string sql = "INSERT INTO attendance SET attendance_employee = @id, attendance_date = @attendanceDate, attendance_active = 1, attendance_type = @type, attendance_flag = 0, attendance_created = @dateNow, attendance_updated = @dateNow";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.Parameters.AddWithValue("attendanceDate", attendanceDate);
                        cmd.Parameters.AddWithValue("type", type);
                        cmd.Parameters.AddWithValue("dateNow", dateNow);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(MySqlException ex){
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
               
            }
            
        }
    }
}

