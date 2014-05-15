using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biometrics_server
{
    public partial class frmMain : Form
    {
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
    }
}
