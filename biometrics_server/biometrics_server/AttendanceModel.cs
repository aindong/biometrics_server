using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace biometrics_server
{
    class AttendanceModel
    {
        //load records
        public static void loadRecord(ref ListView lst, ref ListView lstEmp)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                {
                    con.Open();

                    string sql = "SELECT * FROM attendance INNER JOIN user ON user_id = attendance_id WHERE user_active = 1";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    lst.Items.Clear();
                    while(reader.Read())
                    {
                        lstEmp.Items.Add(reader["attendance_employee"].ToString());
                        lstEmp.Items[lstEmp.Items.Count - 1].SubItems.Add(reader["user_name"].ToString());

                        lst.Items.Add(reader["attendance_employee"].ToString());
                        DateTime aDate;
                        DateTime.TryParse(reader["attendance_date"].ToString(), out aDate);
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader["user_name"].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(aDate.ToString("MMMM dd, yyyy"));
                        lst.Items[lst.Items.Count - 1].SubItems.Add(aDate.ToString("hh:mm:ss tt"));
                    }

                }
            }
            catch(MySqlException ex)
            {

            }
        }

        //load record by date
        public static void loadRecordWithFilter(ref ListView lst, DateTime start, DateTime end, string empID = "")
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                {
                    con.Open();

                    string sql = "";

                    if(empID == "")
                    {
                        sql = "SELECT * FROM attendance WHERE attendance_date BETWEEN @start AND @end";
                    }
                    else
                    {
                        sql = "SELECT * FROM attendance WHERE attendance_employee = @empID attendance_date BETWEEN @start AND @end";
                    }
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //parameters
                    if (empID != "")
                    {
                        cmd.Parameters.AddWithValue("empID", empID);
                    }
                    cmd.Parameters.AddWithValue("start", start);
                    cmd.Parameters.AddWithValue("end", end);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    lst.Items.Clear();
                    while (reader.Read())
                    {
                        lst.Items.Add(reader[0].ToString());

                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[1].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[2].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[3].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[4].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[5].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[6].ToString());
                        lst.Items[lst.Items.Count - 1].SubItems.Add(reader[7].ToString());
                    }

                }
            }
            catch (MySqlException ex)
            {

            }
        }

        //insert record
        public static void insertRecord(int attendance_employee, string attendance_date, int attendance_active, string attendance_type, int attedance_flag, string attendance_created, string attendace_updated)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(biometrics_server.Config.getConnectionString()))
                {
                    con.Open();

                    string sql = "INSERT INTO attendance (attendance_employee, attendance_date, attendance_active, attendance_type, attedance_flag, attendance_created, attendace_updated) VALUES (@attendance_employee, @attendance_date, @attendance_active, @attendance_type, @attedance_flag, @attendance_created, @attendace_updated)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    //parameters
                    cmd.Parameters.AddWithValue("attendance_employee", attendance_employee);
                    cmd.Parameters.AddWithValue("attendance_date", attendance_date);
                    cmd.Parameters.AddWithValue("attendance_active", attendance_active);
                    cmd.Parameters.AddWithValue("attendance_type", attendance_type);
                    cmd.Parameters.AddWithValue("attedance_flag", attedance_flag);
                    cmd.Parameters.AddWithValue("attendance_created", attendance_created);
                    cmd.Parameters.AddWithValue("attendace_updated", attendace_updated);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(MySqlException e)
            {

            }
            
        }

        
    }
}
