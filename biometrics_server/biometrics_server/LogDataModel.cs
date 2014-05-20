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
            //count
            int count = 0;
            for (int ctr = 0; ctr < lstBiometricData.Items.Count; ctr++)
            {
                //get listview data and store it to variable (avoiding long line of codes)
                string id = lstBiometricData.Items[ctr].SubItems[2].Text;
                string verifyMode = lstBiometricData.Items[ctr].SubItems[3].Text;
                if (verifyMode == "FCPI") //if not equal to "P C", employee didnt login successfully
                {
                    MessageBox.Show("True");
                    break;
                }
                string type = lstBiometricData.Items[ctr].SubItems[4].Text; //action (timeIn, timeOut etc)
                string attendanceDate = lstBiometricData.Items[ctr].SubItems[5].Text;
                DateTime dateNow = DateTime.Now;
                try
                {
                    //insert record to attendance table
                    using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                    {
                        con.Open();
                        //check if already stored in the database
                        string checkData = "SELECT * FROM attendance WHERE attendance_employee = @id AND attendance_date = @attendanceDate";
                        MySqlCommand cmdData = new MySqlCommand(checkData, con);
                        //add parameters to command, accessible by using '@'
                        cmdData.Parameters.AddWithValue("id", id);
                        cmdData.Parameters.AddWithValue("attendanceDate", attendanceDate);
                       
                        MySqlDataReader reader = cmdData.ExecuteReader();
                        //if not, insert biometric data to database, call to function insertBiometricsData
                        reader.Read();
                        if (!reader.HasRows)
                        {
                            insertBiometricsData(id, attendanceDate, type, dateNow);
                            count++;
                        }
                    }
                }
                catch(MySqlException ex){
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }

            }

            MessageBox.Show(count.ToString());

        }
        //insert biometrics data to database
        public static void insertBiometricsData(String id, String attendanceDate, String type, DateTime dateNow)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                {
                    con.Open();
                    string sql = "INSERT INTO attendance (attendance_employee, attendance_date, attendance_active, attendance_type, attendance_flag, attendance_created, attendance_updated) VALUES(@id, @attendanceDate, 1, @type, 0, @dateNow, @dateNow)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("attendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("type", type);
                    cmd.Parameters.AddWithValue("dateNow", dateNow);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }
    }
}

