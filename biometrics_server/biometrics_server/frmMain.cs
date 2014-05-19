using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Riss.Devices;
using biometrics_server.Entity;
using biometrics_server.IConvert;

namespace biometrics_server
{
    public partial class frmMain : Form
    {
        private Device device;
        private DeviceConnection deviceConnection;
        private DeviceComEty deviceEty;
        public frmMain()
        {
            InitializeComponent();
        }


        private void btn_DBConfig_Click(object sender, EventArgs e)
        {
            frmConnect frm = new frmConnect();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAttendance frm = new frmAttendance();
            frm.ShowDialog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                device = new Device();
                device.DN = 1;
                device.Password = "0";
                device.Model = "A-C030";
                device.ConnectionModel = 5;//等于5时才能正确加载ZD2911通讯模块

                if(rdb_Network.Checked == true){
                    //ip address
                    if (string.IsNullOrEmpty(txt_IP.Text.Trim()))
                    {
                        MessageBox.Show("Please Input IP Address", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_IP.Focus();
                        return;
                    }

                    if (false == ConvertObject.IsCorrenctIP(txt_IP.Text.Trim()))
                    {
                        MessageBox.Show("Illegal IP Address", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_IP.Focus();
                        return;
                    }

                    device.IpAddress = txt_IP.Text.Trim();
                    device.IpPort = int.Parse(txt_Port.Text);
                    device.CommunicationType = CommunicationType.Tcp;

                }else{
                    device.CommunicationType = CommunicationType.Usb;
                }
               
                deviceConnection = DeviceConnection.CreateConnection(ref device);
                if (deviceConnection.Open() > 0)
                {
                    deviceEty = new DeviceComEty();
                    deviceEty.Device = device;
                    deviceEty.DeviceConnection = deviceConnection;
                    btnDisconnect.Enabled = true;
                    MessageBox.Show("Device successfully connected", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Connect to Device", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmRealTimeLog frmRtl = new frmRealTimeLog();
            frmRtl.ShowDialog();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            deviceConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogData frmLD = new frmLogData();
            frmLD.ShowDialog();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
