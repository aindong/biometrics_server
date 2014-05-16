namespace biometrics_server
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_Network = new System.Windows.Forms.RadioButton();
            this.rdb_USB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRealTimeLog = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnDBConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biometric Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port :";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(111, 109);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(117, 23);
            this.txt_IP.TabIndex = 0;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(111, 142);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(117, 23);
            this.txt_Port.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 39);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Navigation";
            // 
            // rdb_Network
            // 
            this.rdb_Network.AutoSize = true;
            this.rdb_Network.Checked = true;
            this.rdb_Network.Location = new System.Drawing.Point(15, 84);
            this.rdb_Network.Name = "rdb_Network";
            this.rdb_Network.Size = new System.Drawing.Size(135, 19);
            this.rdb_Network.TabIndex = 10;
            this.rdb_Network.TabStop = true;
            this.rdb_Network.Text = "Network Connection";
            this.rdb_Network.UseVisualStyleBackColor = true;
            // 
            // rdb_USB
            // 
            this.rdb_USB.AutoSize = true;
            this.rdb_USB.Location = new System.Drawing.Point(15, 59);
            this.rdb_USB.Name = "rdb_USB";
            this.rdb_USB.Size = new System.Drawing.Size(111, 19);
            this.rdb_USB.TabIndex = 11;
            this.rdb_USB.TabStop = true;
            this.rdb_USB.Text = "USB Connection";
            this.rdb_USB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::biometrics_server.Properties.Resources.NetByte_Design_Studio___0369;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(396, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 77);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sync Database";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRealTimeLog
            // 
            this.btnRealTimeLog.Image = global::biometrics_server.Properties.Resources.history;
            this.btnRealTimeLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealTimeLog.Location = new System.Drawing.Point(137, 237);
            this.btnRealTimeLog.Name = "btnRealTimeLog";
            this.btnRealTimeLog.Size = new System.Drawing.Size(109, 77);
            this.btnRealTimeLog.TabIndex = 9;
            this.btnRealTimeLog.Text = "Real Time Log";
            this.btnRealTimeLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealTimeLog.UseVisualStyleBackColor = true;
            this.btnRealTimeLog.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Image = global::biometrics_server.Properties.Resources.Wrong;
            this.btnDisconnect.Location = new System.Drawing.Point(390, 84);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 84);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::biometrics_server.Properties.Resources.Forward;
            this.btnConnect.Location = new System.Drawing.Point(261, 84);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 84);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect to Device";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Image = global::biometrics_server.Properties.Resources.Calendar;
            this.btnViewAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewAttendance.Location = new System.Drawing.Point(269, 237);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(109, 77);
            this.btnViewAttendance.TabIndex = 8;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDBConfig
            // 
            this.btnDBConfig.Image = global::biometrics_server.Properties.Resources.db1;
            this.btnDBConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDBConfig.Location = new System.Drawing.Point(10, 237);
            this.btnDBConfig.Name = "btnDBConfig";
            this.btnDBConfig.Size = new System.Drawing.Size(109, 77);
            this.btnDBConfig.TabIndex = 7;
            this.btnDBConfig.Text = "Database Config";
            this.btnDBConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDBConfig.UseVisualStyleBackColor = true;
            this.btnDBConfig.Click += new System.EventHandler(this.btn_DBConfig_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(519, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_USB);
            this.Controls.Add(this.rdb_Network);
            this.Controls.Add(this.btnRealTimeLog);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.btnDBConfig);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDBConfig;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnRealTimeLog;
        private System.Windows.Forms.RadioButton rdb_Network;
        private System.Windows.Forms.RadioButton rdb_USB;
        private System.Windows.Forms.Button button1;
    }
}

