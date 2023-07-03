namespace WindowsFormsApp1
{
    partial class SystemInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ControllerRevision = new System.Windows.Forms.Label();
            this.SoftwareVersion = new System.Windows.Forms.Label();
            this.LuaVersion = new System.Windows.Forms.Label();
            this.device_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип устройства";
            // 
            // DeviceVersion
            // 
            this.DeviceVersion.AutoSize = true;
            this.DeviceVersion.Location = new System.Drawing.Point(292, 88);
            this.DeviceVersion.Name = "DeviceVersion";
            this.DeviceVersion.Size = new System.Drawing.Size(37, 16);
            this.DeviceVersion.TabIndex = 1;
            this.DeviceVersion.Text = "PDM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ревизия платы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Версия системной прошивки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Версия LUA";
            // 
            // ControllerRevision
            // 
            this.ControllerRevision.AutoSize = true;
            this.ControllerRevision.Location = new System.Drawing.Point(292, 134);
            this.ControllerRevision.Name = "ControllerRevision";
            this.ControllerRevision.Size = new System.Drawing.Size(37, 16);
            this.ControllerRevision.TabIndex = 5;
            this.ControllerRevision.Text = "PDM";
            // 
            // SoftwareVersion
            // 
            this.SoftwareVersion.AutoSize = true;
            this.SoftwareVersion.Location = new System.Drawing.Point(292, 175);
            this.SoftwareVersion.Name = "SoftwareVersion";
            this.SoftwareVersion.Size = new System.Drawing.Size(37, 16);
            this.SoftwareVersion.TabIndex = 6;
            this.SoftwareVersion.Text = "PDM";
            // 
            // LuaVersion
            // 
            this.LuaVersion.AutoSize = true;
            this.LuaVersion.Location = new System.Drawing.Point(292, 223);
            this.LuaVersion.Name = "LuaVersion";
            this.LuaVersion.Size = new System.Drawing.Size(37, 16);
            this.LuaVersion.TabIndex = 7;
            this.LuaVersion.Text = "PDM";
            // 
            // device_status
            // 
            this.device_status.AutoSize = true;
            this.device_status.Location = new System.Drawing.Point(116, 31);
            this.device_status.Name = "device_status";
            this.device_status.Size = new System.Drawing.Size(187, 16);
            this.device_status.TabIndex = 8;
            this.device_status.Text = "Устройство не обнаружено";
            // 
            // SystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 270);
            this.Controls.Add(this.device_status);
            this.Controls.Add(this.LuaVersion);
            this.Controls.Add(this.SoftwareVersion);
            this.Controls.Add(this.ControllerRevision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeviceVersion);
            this.Controls.Add(this.label1);
            this.Name = "SystemInfo";
            this.Text = "Информация об устройстве";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeviceVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ControllerRevision;
        private System.Windows.Forms.Label SoftwareVersion;
        private System.Windows.Forms.Label LuaVersion;
        private System.Windows.Forms.Label device_status;
    }
}