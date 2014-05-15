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
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            AttendanceModel.loadRecord(ref lstAttendance, ref lstEmployee);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstEmployee_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AttendanceModel.loadRecord(ref lstAttendance, ref lstEmployee);
        }
        

        
    }
}
