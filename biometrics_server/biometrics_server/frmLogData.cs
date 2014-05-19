using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biometrics_server.Business;
using biometrics_server.IConvert;
using biometrics_server.Entity;
using Riss.Devices;


namespace biometrics_server.UI

{
    public partial class frmLogData : Form
    {
        private Device device;
        private DeviceConnection deviceConnection;
        private bool isRealTime = false;

        public frmLogData(DeviceComEty deviceEty)
        {
            InitializeComponent();
            device = deviceEty.Device;
            deviceConnection = deviceEty.DeviceConnection;
        }

        private List<DateTime> GetDateTimeList()
        {
            List<DateTime> dtList = new List<DateTime>();
            dtList.Add(dtp_Begin.Value);
            dtList.Add(dtp_End.Value);
            return dtList;
        }

        private void AddRecordToListView(List<Record> recordList)
        {
            lvw_GLogList.Items.Clear();
            int no = 1;
            foreach (Record record in recordList)
            {
                string type = ConvertObject.GLogType(record.Verify);
                string mode = ConvertObject.IOMode(record.Action);
                ListViewItem item = new ListViewItem(new string[]{ no.ToString(), record.DN.ToString(), record.DIN.ToString(),
                    type, mode, record.Clock.ToString("yyyy-MM-dd HH:mm:ss") });
                lvw_GLogList.Items.Add(item);
                no++;
            }
        }
        private void frmLogData_Load(object sender, EventArgs e)
        {
            getLogs();
        }

        private void btn_DownloadHistory_Click(object sender, EventArgs e)
        {
            getLogs();
        }

        private void getLogs()
        {
            object extraProperty = new object();
            object extraData = new object();
            extraData = Global.DeviceBusy;

            try
            {
                List<DateTime> dtList = GetDateTimeList();
                bool result = deviceConnection.SetProperty(DeviceProperty.Enable, extraProperty, device, extraData);
                extraProperty = false;
                extraData = dtList;
                result = deviceConnection.GetProperty(DeviceProperty.AttRecordsCount, extraProperty, ref device,
                    ref extraData);
                if (false == result)
                {
                    MessageBox.Show("Get All Glog Fail", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int recordCount = (int)extraData;
                if (0 == recordCount)
                {//为0时说明没有新日志记录
                    lvw_GLogList.Items.Clear();
                    return;
                }

                List<bool> boolList = new List<bool>();
                boolList.Add(false);//所有日志
                boolList.Add(chk_NewFlag.Checked);//清除新日志标记，false则不清除
                extraProperty = boolList;
                extraData = dtList;
                result = deviceConnection.GetProperty(DeviceProperty.AttRecords, extraProperty, ref device, ref extraData);
                if (result)
                {
                    List<Record> recordList = (List<Record>)extraData;
                    AddRecordToListView(recordList);
                }
                else
                {
                    MessageBox.Show("Get All Glog Fail", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                extraData = Global.DeviceIdle;
                deviceConnection.SetProperty(DeviceProperty.Enable, extraProperty, device, extraData);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            object extraProperty = new object();
            object extraData = new object();
            extraData = Global.DeviceBusy;

            try
            {
                bool result = deviceConnection.SetProperty(DeviceProperty.Enable, extraProperty, device, extraData);
                result = deviceConnection.SetProperty(DeviceProperty.AttRecords, extraProperty, device, extraData);
                if (result)
                {
                    lvw_GLogList.Items.Clear();
                    MessageBox.Show("Clear All Glog Success", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Clear All Glog Fail", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                extraData = Global.DeviceIdle;
                deviceConnection.SetProperty(DeviceProperty.Enable, extraProperty, device, extraData);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(isRealTime == false)
            {
                timer1.Interval = int.Parse(comboBox1.Text) * 100;
                timer1.Enabled = true;
                button2.Text = "Stop Realtime Logs";
            }
            else
            {
                timer1.Enabled = false;
                button2.Text = "Start Realtime Logs";
            }
            
        }
    }
}
