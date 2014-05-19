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
using biometrics_server.IConvert;
using System.Net.Sockets;
using System.IO.Ports;
using System.Net;

namespace biometrics_server
{
    public partial class frmRealTimeLog : Form
    {
        private int no = 1;
        private Zd2911Monitor listener;
        private delegate void AddRecord(ListViewItem lvi);

        public frmRealTimeLog()
        {
            InitializeComponent();
        }

        private string GetLocalIPAddress()
        {
            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipAddressList)
            {
                if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                {
                    return ip.ToString();
                }
            }

            return string.Empty;
        }

        private void AddRecordToListView(ListViewItem lvi)
        {
            listView1.Items.Add(lvi);
        }

        private void listener_ReceiveHandler(object sender, ReceiveEventArg e)
        {
            Record record = e.record;
            //string verify = ConvertObject.GLogType(record.Verify);
            string action = ConvertObject.IOMode(record.Action);
            ListViewItem lvi = new ListViewItem(new string[]{no.ToString(), record.DN.ToString(), record.DIN.ToString(),
                string.Empty, action, record.Clock.ToString("yyyy-MM-dd HH:mm:ss")});
            BeginInvoke(new AddRecord(AddRecordToListView), new object[] { lvi });
            no++;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (btnConnect.Text.Trim().Equals("Listen"))
                {
                    MessageBox.Show(GetLocalIPAddress());
                    Monitor m = new Monitor();
                    m.UDPAddress = GetLocalIPAddress();
                    m.UDPPort = 5500;
                    m.Mode = 0;
                    listener = Zd2911Monitor.CreateZd2911Monitor(m);
                    listener.ReceiveHandler += new ReceiveHandler(listener_ReceiveHandler);
                    listener.OpenListen();
                    btnConnect.Text = "Cancel";
                }
                else
                {
                    listener.CloseListen();
                    listener = null;
                    btnConnect.Text = "Listen";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRealTimeLog_Load(object sender, EventArgs e)
        {

        }


    }
}
