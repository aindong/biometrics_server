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
    //model for Form Log Data
    class LogDataModel
    {
        //Function that executes adding of biometrics login data to Operations Database
        public static void syncData(ref ListView lstBiometricData, ref ProgressBar progressBar)
        {
            //count variable is use for progress bar
            int count = 0;
            //loop through list view and add it to Operations Database
            for (int ctr = 0; ctr < lstBiometricData.Items.Count; ctr++)
            {
                //get listview data and store it to variable (avoiding long line of codes)
                string id = lstBiometricData.Items[ctr].SubItems[2].Text;
                string verifyMode = lstBiometricData.Items[ctr].SubItems[3].Text;
                string type = lstBiometricData.Items[ctr].SubItems[4].Text; //action (timeIn, timeOut etc)
                string attendanceDate = lstBiometricData.Items[ctr].SubItems[5].Text;
                DateTime dateNow = DateTime.Now;

                //connect to database.
                try
                {
                    using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                    {
                        //check if data is already stored in the database
                        con.Open();
                        string checkData = "SELECT * FROM attendance WHERE attendance_employee = @id AND attendance_date = @attendanceDate";
                        MySqlCommand cmdData = new MySqlCommand(checkData, con);
                        //catch parameters and add it to command parameter
                        //command parameters are accessible by using '@' in sql
                        cmdData.Parameters.AddWithValue("id", id);
                        cmdData.Parameters.AddWithValue("attendanceDate", attendanceDate);
                       
                        //execute the query. adding row/s to reader
                        MySqlDataReader reader = cmdData.ExecuteReader();
                        reader.Read();
                        //if no rows were found, add it to Database
                        if (!reader.HasRows)
                        {
                            //add 1 to progress bar.
                            progressBar.Value = progressBar.Value + 1;
                            //call function to insert data to Database
                            insertBiometricsData(id, attendanceDate, type, dateNow);
                            count++;
                        }
                    }
                }
                catch(MySqlException ex){
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }

            }
            //this is for progressbar and messagebox
            //if count is zero, it means no data to sync
            if (count == 0)
            {
                progressBar.Visible = false;
                MessageBox.Show("No data to sync at this particular date range.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                progressBar.Value = lstBiometricData.Items.Count;
                MessageBox.Show("Data has been synced.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Visible = false;
            }
        }

        public static void realtimeSyncData(ref ListView lstBiometricData)
        {
            //count variable is use for progress bar
            int count = 0;
            //loop through list view and add it to Operations Database
            for (int ctr = 0; ctr < lstBiometricData.Items.Count; ctr++)
            {
                //get listview data and store it to variable (avoiding long line of codes)
                string id = lstBiometricData.Items[ctr].SubItems[2].Text;
                string verifyMode = lstBiometricData.Items[ctr].SubItems[3].Text;
                string type = lstBiometricData.Items[ctr].SubItems[4].Text; //action (timeIn, timeOut etc)
                string attendanceDate = lstBiometricData.Items[ctr].SubItems[5].Text;
                DateTime dateNow = DateTime.Now;

                //connect to database.
                try
                {
                    using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                    {
                        //check if data is already stored in the database
                        con.Open();
                        string checkData = "SELECT * FROM attendance WHERE attendance_employee = @id AND attendance_date = @attendanceDate";
                        MySqlCommand cmdData = new MySqlCommand(checkData, con);
                        //catch parameters and add it to command parameter
                        //command parameters are accessible by using '@' in sql
                        cmdData.Parameters.AddWithValue("id", id);
                        cmdData.Parameters.AddWithValue("attendanceDate", attendanceDate);

                        //execute the query. adding row/s to reader
                        MySqlDataReader reader = cmdData.ExecuteReader();
                        reader.Read();
                        //if no rows were found, add it to Database
                        if (!reader.HasRows)
                        {
                            
                            //call function to insert data to Database
                            insertBiometricsData(id, attendanceDate, type, dateNow);
                            count++;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }

            }
            //this is for progressbar and messagebox
            //if count is zero, it means no data to sync
            if (count == 0)
            {
               
               // MessageBox.Show("No data to sync at this particular date range.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                //MessageBox.Show("Data has been synced.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
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
                    //catch parameters and add it to command parameter
                    //command parameters are accessible by using '@' in sql
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("attendanceDate", attendanceDate);
                    cmd.Parameters.AddWithValue("type", type);
                    cmd.Parameters.AddWithValue("dateNow", dateNow);
                    //execute the query
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

