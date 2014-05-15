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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btn_ViewAttendance = new System.Windows.Forms.Button();
            this.btn_DBConfig = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(452, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port :";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(86, 76);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(117, 23);
            this.txt_IP.TabIndex = 3;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(86, 109);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(117, 23);
            this.txt_Port.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 39);
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
            // btnDisconnect
            // 
            this.btnDisconnect.Image = global::biometrics_server.Properties.Resources.Wrong;
            this.btnDisconnect.Location = new System.Drawing.Point(338, 67);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 84);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::biometrics_server.Properties.Resources.Forward;
            this.btnConnect.Location = new System.Drawing.Point(215, 67);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 84);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect to Device";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btn_ViewAttendance
            // 
            this.btn_ViewAttendance.Image = global::biometrics_server.Properties.Resources.history;
            this.btn_ViewAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ViewAttendance.Location = new System.Drawing.Point(344, 228);
            this.btn_ViewAttendance.Name = "btn_ViewAttendance";
            this.btn_ViewAttendance.Size = new System.Drawing.Size(109, 77);
            this.btn_ViewAttendance.TabIndex = 8;
            this.btn_ViewAttendance.Text = "View Attendance";
            this.btn_ViewAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ViewAttendance.UseVisualStyleBackColor = true;
            this.btn_ViewAttendance.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DBConfig
            // 
            this.btn_DBConfig.Image = global::biometrics_server.Properties.Resources.db1;
            this.btn_DBConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DBConfig.Location = new System.Drawing.Point(15, 228);
            this.btn_DBConfig.Name = "btn_DBConfig";
            this.btn_DBConfig.Size = new System.Drawing.Size(109, 77);
            this.btn_DBConfig.TabIndex = 7;
            this.btn_DBConfig.Text = "Database Config";
            this.btn_DBConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_DBConfig.UseVisualStyleBackColor = true;
            this.btn_DBConfig.Click += new System.EventHandler(this.btn_DBConfig_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(465, 328);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btn_ViewAttendance);
            this.Controls.Add(this.btn_DBConfig);
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
        private System.Windows.Forms.Button btn_DBConfig;
        private System.Windows.Forms.Button btn_ViewAttendance;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

