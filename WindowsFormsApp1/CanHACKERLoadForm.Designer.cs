namespace WindowsFormsApp1
{
    partial class CanHACKERLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanHACKERLoadForm));
            this.btLoadData = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.lbBootDeviceList = new System.Windows.Forms.ListBox();
            this.tbSystemFileName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.cboxComPortName = new System.Windows.Forms.ComboBox();
            this.cbCOMBrate = new System.Windows.Forms.ComboBox();
            this.cbBRateConnect = new System.Windows.Forms.ComboBox();
            this.backgroundCanHackerLoad = new System.ComponentModel.BackgroundWorker();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pbDataLoad = new System.Windows.Forms.ProgressBar();
            this.tbTimeElpsed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadLua = new System.Windows.Forms.Button();
            this.tbStartAddres = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadData
            // 
            this.btLoadData.BackColor = System.Drawing.SystemColors.Control;
            this.btLoadData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLoadData.BackgroundImage")));
            this.btLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLoadData.Location = new System.Drawing.Point(505, 254);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(75, 76);
            this.btLoadData.TabIndex = 2;
            this.btLoadData.UseVisualStyleBackColor = false;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStop.Location = new System.Drawing.Point(599, 254);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 76);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.SystemColors.Control;
            this.btnScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScan.BackgroundImage")));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnScan.Location = new System.Drawing.Point(623, 65);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(80, 76);
            this.btnScan.TabIndex = 32;
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lbBootDeviceList
            // 
            this.lbBootDeviceList.FormattingEnabled = true;
            this.lbBootDeviceList.Location = new System.Drawing.Point(463, 67);
            this.lbBootDeviceList.Name = "lbBootDeviceList";
            this.lbBootDeviceList.Size = new System.Drawing.Size(117, 121);
            this.lbBootDeviceList.TabIndex = 33;
            // 
            // tbSystemFileName
            // 
            this.tbSystemFileName.Location = new System.Drawing.Point(150, 381);
            this.tbSystemFileName.Name = "tbSystemFileName";
            this.tbSystemFileName.Size = new System.Drawing.Size(541, 20);
            this.tbSystemFileName.TabIndex = 34;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.BackgroundImage")));
            this.btnLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoadFile.Location = new System.Drawing.Point(46, 352);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(80, 76);
            this.btnLoadFile.TabIndex = 35;
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // cboxComPortName
            // 
            this.cboxComPortName.FormattingEnabled = true;
            this.cboxComPortName.Location = new System.Drawing.Point(17, 42);
            this.cboxComPortName.Name = "cboxComPortName";
            this.cboxComPortName.Size = new System.Drawing.Size(98, 21);
            this.cboxComPortName.TabIndex = 36;
            this.cboxComPortName.DropDown += new System.EventHandler(this.cboxComPortName_DropDown);
            // 
            // cbCOMBrate
            // 
            this.cbCOMBrate.FormattingEnabled = true;
            this.cbCOMBrate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cbCOMBrate.Location = new System.Drawing.Point(17, 69);
            this.cbCOMBrate.Name = "cbCOMBrate";
            this.cbCOMBrate.Size = new System.Drawing.Size(98, 21);
            this.cbCOMBrate.TabIndex = 38;
            // 
            // cbBRateConnect
            // 
            this.cbBRateConnect.FormattingEnabled = true;
            this.cbBRateConnect.Items.AddRange(new object[] {
            "1 Mб/c",
            "500 Kб/c",
            "250 Kб/c",
            "125 Kб/c",
            "100 Kб/c",
            "50 Kб/c",
            "20 Kб/c",
            "10 Kб/c"});
            this.cbBRateConnect.Location = new System.Drawing.Point(311, 120);
            this.cbBRateConnect.Name = "cbBRateConnect";
            this.cbBRateConnect.Size = new System.Drawing.Size(86, 21);
            this.cbBRateConnect.TabIndex = 40;
            // 
            // backgroundCanHackerLoad
            // 
            this.backgroundCanHackerLoad.WorkerReportsProgress = true;
            this.backgroundCanHackerLoad.WorkerSupportsCancellation = true;
            this.backgroundCanHackerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundCanHackerLoad_DoWork);
            this.backgroundCanHackerLoad.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundCanHackerLoad_ProgressChanged);
            this.backgroundCanHackerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundCanHackerLoad_RunWorkerCompleted);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Location = new System.Drawing.Point(136, 31);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 76);
            this.btnConnect.TabIndex = 42;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbDataLoad
            // 
            this.pbDataLoad.Location = new System.Drawing.Point(12, 22);
            this.pbDataLoad.Name = "pbDataLoad";
            this.pbDataLoad.Size = new System.Drawing.Size(765, 23);
            this.pbDataLoad.TabIndex = 43;
            // 
            // tbTimeElpsed
            // 
            this.tbTimeElpsed.Location = new System.Drawing.Point(311, 94);
            this.tbTimeElpsed.Name = "tbTimeElpsed";
            this.tbTimeElpsed.Size = new System.Drawing.Size(86, 20);
            this.tbTimeElpsed.TabIndex = 44;
            this.tbTimeElpsed.Text = "15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbCOMBrate);
            this.groupBox1.Controls.Add(this.cboxComPortName);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 128);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры CAN HACKER";
            // 
            // btnLoadLua
            // 
            this.btnLoadLua.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadLua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadLua.BackgroundImage")));
            this.btnLoadLua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadLua.Location = new System.Drawing.Point(408, 254);
            this.btnLoadLua.Name = "btnLoadLua";
            this.btnLoadLua.Size = new System.Drawing.Size(75, 76);
            this.btnLoadLua.TabIndex = 46;
            this.btnLoadLua.UseVisualStyleBackColor = false;
            this.btnLoadLua.Click += new System.EventHandler(this.btnLoadLua_Click);
            // 
            // tbStartAddres
            // 
            this.tbStartAddres.Location = new System.Drawing.Point(288, 283);
            this.tbStartAddres.Name = "tbStartAddres";
            this.tbStartAddres.Size = new System.Drawing.Size(86, 20);
            this.tbStartAddres.TabIndex = 47;
            this.tbStartAddres.Text = "25000";
            // 
            // CanHACKERLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 490);
            this.Controls.Add(this.tbStartAddres);
            this.Controls.Add(this.btnLoadLua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTimeElpsed);
            this.Controls.Add(this.pbDataLoad);
            this.Controls.Add(this.cbBRateConnect);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.tbSystemFileName);
            this.Controls.Add(this.lbBootDeviceList);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btLoadData);
            this.Name = "CanHACKERLoadForm";
            this.Text = "CanHACKERLoadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CanHACKERLoadForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListBox lbBootDeviceList;
        private System.Windows.Forms.TextBox tbSystemFileName;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ComboBox cboxComPortName;
        private System.Windows.Forms.ComboBox cbCOMBrate;
        private System.Windows.Forms.ComboBox cbBRateConnect;
        private System.ComponentModel.BackgroundWorker backgroundCanHackerLoad;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar pbDataLoad;
        private System.Windows.Forms.TextBox tbTimeElpsed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadLua;
        private System.Windows.Forms.TextBox tbStartAddres;
    }
}