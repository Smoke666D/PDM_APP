namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Settings.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LUA_TIME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnComLoad = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.app_version_lebel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLUARestart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LuaState = new System.Windows.Forms.Label();
            this.DinInput = new System.Windows.Forms.DataGridView();
            this.AnalogInput = new System.Windows.Forms.DataGridView();
            this.DiscreteOut = new System.Windows.Forms.DataGridView();
            this.System_Par = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LoopTimeLabel = new System.Windows.Forms.Label();
            this.LoopTime = new System.Windows.Forms.TextBox();
            this.btnTelemetryStop = new System.Windows.Forms.Button();
            this.btnTelemetryRecord = new System.Windows.Forms.Button();
            this.btnTelemetryPause = new System.Windows.Forms.Button();
            this.btnTelemetryRun = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lua5_4 = new System.Windows.Forms.RadioButton();
            this.lua5_3 = new System.Windows.Forms.RadioButton();
            this.LuacFileOpenButton = new System.Windows.Forms.Button();
            this.LuaFileButton = new System.Windows.Forms.Button();
            this.LibChecked = new System.Windows.Forms.CheckedListBox();
            this.LibFolderButton = new System.Windows.Forms.Button();
            this.UtilFolderButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.StatusLine = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LuaCompileButton = new System.Windows.Forms.Button();
            this.LuaRunButton = new System.Windows.Forms.Button();
            this.LuacLoadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnOnlineTelemetry = new System.Windows.Forms.Button();
            this.btnOfflineTelemetry = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.Chart8Window = new System.Windows.Forms.Button();
            this.Chart8_1Select = new System.Windows.Forms.ComboBox();
            this.Chart8_2Select = new System.Windows.Forms.ComboBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.Chart7Window = new System.Windows.Forms.Button();
            this.Chart7_1Select = new System.Windows.Forms.ComboBox();
            this.Chart7_2Select = new System.Windows.Forms.ComboBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.Chart6Window = new System.Windows.Forms.Button();
            this.Chart6_1Select = new System.Windows.Forms.ComboBox();
            this.Chart6_2Select = new System.Windows.Forms.ComboBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.buttChart5Window = new System.Windows.Forms.Button();
            this.Chart5_1Select = new System.Windows.Forms.ComboBox();
            this.Chart5_2Select = new System.Windows.Forms.ComboBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.Chart4Window = new System.Windows.Forms.Button();
            this.Chart4_1Select = new System.Windows.Forms.ComboBox();
            this.Chart4_2Select = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.Chart3Window = new System.Windows.Forms.Button();
            this.Chart3_1Select = new System.Windows.Forms.ComboBox();
            this.Chart3_2Select = new System.Windows.Forms.ComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.Chart2Window = new System.Windows.Forms.Button();
            this.Chart2_1Select = new System.Windows.Forms.ComboBox();
            this.Chart2_2Select = new System.Windows.Forms.ComboBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Chart1Window = new System.Windows.Forms.Button();
            this.Chart1_1Select = new System.Windows.Forms.ComboBox();
            this.Chart1_2Select = new System.Windows.Forms.ComboBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnTelemetryStop1 = new System.Windows.Forms.Button();
            this.btnTelemetryRecord1 = new System.Windows.Forms.Button();
            this.btnTelemetryPause1 = new System.Windows.Forms.Button();
            this.btnTelemetryRun1 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel33 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.btnWriteES = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReadES = new System.Windows.Forms.Button();
            this.tbEEPROMSize = new System.Windows.Forms.TextBox();
            this.btnAccess = new System.Windows.Forms.Button();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RecordFormatView = new System.Windows.Forms.DataGridView();
            this.timeStampCheck = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfigStorage = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRgisterCount = new System.Windows.Forms.TextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.RegisterView = new System.Windows.Forms.DataGridView();
            this.RecordView = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txRecordCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaxRecord = new System.Windows.Forms.TextBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReadTime = new System.Windows.Forms.Button();
            this.btnSyn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HTxtb = new System.Windows.Forms.TextBox();
            this.MTxtb = new System.Windows.Forms.TextBox();
            this.STxtb = new System.Windows.Forms.TextBox();
            this.YTxtb = new System.Windows.Forms.TextBox();
            this.DTxtb = new System.Windows.Forms.TextBox();
            this.MonTxtb = new System.Windows.Forms.TextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.fieldNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RecordForamtSource = new System.Windows.Forms.BindingSource(this.components);
            this.n1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.n2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.n3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.n4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.n5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RegisterSource = new System.Windows.Forms.BindingSource(this.components);
            this.p1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordSource = new System.Windows.Forms.BindingSource(this.components);
            this.SystemDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscreteOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_Par)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordFormatView)).BeginInit();
            this.panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).BeginInit();
            this.panel27.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordForamtSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LUA_TIME
            // 
            this.LUA_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LUA_TIME.AutoSize = true;
            this.LUA_TIME.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUA_TIME.Location = new System.Drawing.Point(360, 53);
            this.LUA_TIME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LUA_TIME.Name = "LUA_TIME";
            this.LUA_TIME.Size = new System.Drawing.Size(77, 28);
            this.LUA_TIME.TabIndex = 5;
            this.LUA_TIME.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(195, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время исполнения";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel17.Controls.Add(this.btnComLoad);
            this.panel17.Controls.Add(this.btnStop);
            this.panel17.Controls.Add(this.btnJournal);
            this.panel17.Controls.Add(this.btnConnect);
            this.panel17.Controls.Add(this.btnHelp);
            this.panel17.Controls.Add(this.app_version_lebel);
            this.panel17.Controls.Add(this.label2);
            this.panel17.Controls.Add(this.btnLUARestart);
            this.panel17.Controls.Add(this.button3);
            this.panel17.Controls.Add(this.btnLoad);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(131, 694);
            this.panel17.TabIndex = 20;
            // 
            // btnComLoad
            // 
            this.btnComLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnComLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComLoad.BackgroundImage")));
            this.btnComLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComLoad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComLoad.Location = new System.Drawing.Point(7, 11);
            this.btnComLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnComLoad.Name = "btnComLoad";
            this.btnComLoad.Size = new System.Drawing.Size(116, 63);
            this.btnComLoad.TabIndex = 39;
            this.btnComLoad.UseVisualStyleBackColor = false;
            this.btnComLoad.Click += new System.EventHandler(this.btnComLoad_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(7, 225);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 63);
            this.btnStop.TabIndex = 38;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.BackColor = System.Drawing.SystemColors.Control;
            this.btnJournal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJournal.BackgroundImage")));
            this.btnJournal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJournal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJournal.Location = new System.Drawing.Point(7, 514);
            this.btnJournal.Margin = new System.Windows.Forms.Padding(2);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(116, 63);
            this.btnJournal.TabIndex = 37;
            this.btnJournal.UseVisualStyleBackColor = false;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Location = new System.Drawing.Point(7, 88);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(116, 63);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Location = new System.Drawing.Point(7, 594);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(116, 63);
            this.btnHelp.TabIndex = 34;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.button4_Click);
            // 
            // app_version_lebel
            // 
            this.app_version_lebel.AutoSize = true;
            this.app_version_lebel.Location = new System.Drawing.Point(44, 672);
            this.app_version_lebel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.app_version_lebel.Name = "app_version_lebel";
            this.app_version_lebel.Size = new System.Drawing.Size(31, 13);
            this.app_version_lebel.TabIndex = 33;
            this.app_version_lebel.Text = "v 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 659);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Версия приложения:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLUARestart
            // 
            this.btnLUARestart.BackColor = System.Drawing.SystemColors.Control;
            this.btnLUARestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLUARestart.BackgroundImage")));
            this.btnLUARestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLUARestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLUARestart.Location = new System.Drawing.Point(7, 158);
            this.btnLUARestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnLUARestart.Name = "btnLUARestart";
            this.btnLUARestart.Size = new System.Drawing.Size(116, 63);
            this.btnLUARestart.TabIndex = 31;
            this.btnLUARestart.UseVisualStyleBackColor = false;
            this.btnLUARestart.Click += new System.EventHandler(this.btnLUARestart_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(7, 447);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 63);
            this.button3.TabIndex = 30;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(7, 313);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 63);
            this.btnLoad.TabIndex = 29;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(7, 380);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(459, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "мкс";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(31, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 75);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // LuaState
            // 
            this.LuaState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuaState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuaState.Location = new System.Drawing.Point(0, 0);
            this.LuaState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LuaState.Name = "LuaState";
            this.LuaState.Size = new System.Drawing.Size(367, 44);
            this.LuaState.TabIndex = 5;
            this.LuaState.Text = "Init";
            this.LuaState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DinInput
            // 
            this.DinInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DinInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DinInput.Location = new System.Drawing.Point(559, 3);
            this.DinInput.Name = "DinInput";
            this.DinInput.RowHeadersWidth = 51;
            this.DinInput.Size = new System.Drawing.Size(124, 481);
            this.DinInput.TabIndex = 24;
            this.DinInput.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DinInput_CellValueChanged);
            // 
            // AnalogInput
            // 
            this.AnalogInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnalogInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalogInput.Location = new System.Drawing.Point(312, 3);
            this.AnalogInput.Name = "AnalogInput";
            this.AnalogInput.RowHeadersWidth = 51;
            this.AnalogInput.Size = new System.Drawing.Size(241, 481);
            this.AnalogInput.TabIndex = 25;
            // 
            // DiscreteOut
            // 
            this.DiscreteOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscreteOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscreteOut.Location = new System.Drawing.Point(3, 3);
            this.DiscreteOut.Name = "DiscreteOut";
            this.DiscreteOut.RowHeadersWidth = 51;
            this.DiscreteOut.Size = new System.Drawing.Size(303, 481);
            this.DiscreteOut.TabIndex = 26;
            // 
            // System_Par
            // 
            this.System_Par.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.System_Par.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.System_Par.Location = new System.Drawing.Point(689, 3);
            this.System_Par.Name = "System_Par";
            this.System_Par.RowHeadersWidth = 51;
            this.System_Par.Size = new System.Drawing.Size(287, 479);
            this.System_Par.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(136, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 694);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 23;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel12);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1019, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.93613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.03656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.02731F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.AnalogInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DiscreteOut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.System_Par, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DinInput, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 136);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 505);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.LUA_TIME);
            this.panel9.Location = new System.Drawing.Point(488, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(506, 101);
            this.panel9.TabIndex = 33;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.LuaState);
            this.panel13.Location = new System.Drawing.Point(129, 12);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(367, 44);
            this.panel13.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel10.Location = new System.Drawing.Point(490, 26);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(515, 103);
            this.panel10.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.LoopTimeLabel);
            this.panel7.Controls.Add(this.LoopTime);
            this.panel7.Controls.Add(this.btnTelemetryStop);
            this.panel7.Controls.Add(this.btnTelemetryRecord);
            this.panel7.Controls.Add(this.btnTelemetryPause);
            this.panel7.Controls.Add(this.btnTelemetryRun);
            this.panel7.Location = new System.Drawing.Point(14, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 101);
            this.panel7.TabIndex = 31;
            // 
            // LoopTimeLabel
            // 
            this.LoopTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTimeLabel.AutoSize = true;
            this.LoopTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopTimeLabel.Location = new System.Drawing.Point(356, 23);
            this.LoopTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoopTimeLabel.Name = "LoopTimeLabel";
            this.LoopTimeLabel.Size = new System.Drawing.Size(0, 19);
            this.LoopTimeLabel.TabIndex = 6;
            // 
            // LoopTime
            // 
            this.LoopTime.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopTime.Location = new System.Drawing.Point(350, 67);
            this.LoopTime.Margin = new System.Windows.Forms.Padding(2);
            this.LoopTime.Name = "LoopTime";
            this.LoopTime.Size = new System.Drawing.Size(94, 25);
            this.LoopTime.TabIndex = 5;
            this.LoopTime.Text = "100";
            this.LoopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoopTime.TextChanged += new System.EventHandler(this.LoopTime_TextChanged);
            // 
            // btnTelemetryStop
            // 
            this.btnTelemetryStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryStop.BackgroundImage")));
            this.btnTelemetryStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryStop.Location = new System.Drawing.Point(87, 13);
            this.btnTelemetryStop.Name = "btnTelemetryStop";
            this.btnTelemetryStop.Size = new System.Drawing.Size(77, 76);
            this.btnTelemetryStop.TabIndex = 4;
            this.btnTelemetryStop.UseVisualStyleBackColor = false;
            this.btnTelemetryStop.Click += new System.EventHandler(this.btnTelemetryStop_Click);
            // 
            // btnTelemetryRecord
            // 
            this.btnTelemetryRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRecord.BackgroundImage")));
            this.btnTelemetryRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRecord.Location = new System.Drawing.Point(254, 13);
            this.btnTelemetryRecord.Name = "btnTelemetryRecord";
            this.btnTelemetryRecord.Size = new System.Drawing.Size(82, 76);
            this.btnTelemetryRecord.TabIndex = 3;
            this.btnTelemetryRecord.UseVisualStyleBackColor = false;
            this.btnTelemetryRecord.Click += new System.EventHandler(this.btnTelemetryRecord_Click);
            // 
            // btnTelemetryPause
            // 
            this.btnTelemetryPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryPause.BackgroundImage")));
            this.btnTelemetryPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryPause.Location = new System.Drawing.Point(170, 13);
            this.btnTelemetryPause.Name = "btnTelemetryPause";
            this.btnTelemetryPause.Size = new System.Drawing.Size(77, 76);
            this.btnTelemetryPause.TabIndex = 2;
            this.btnTelemetryPause.UseVisualStyleBackColor = false;
            this.btnTelemetryPause.Click += new System.EventHandler(this.btnTelemetryPause_Click);
            // 
            // btnTelemetryRun
            // 
            this.btnTelemetryRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRun.BackgroundImage")));
            this.btnTelemetryRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRun.Location = new System.Drawing.Point(6, 13);
            this.btnTelemetryRun.Name = "btnTelemetryRun";
            this.btnTelemetryRun.Size = new System.Drawing.Size(75, 76);
            this.btnTelemetryRun.TabIndex = 1;
            this.btnTelemetryRun.UseVisualStyleBackColor = false;
            this.btnTelemetryRun.Click += new System.EventHandler(this.btnTelemetryRun_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(17, 26);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(464, 103);
            this.panel8.TabIndex = 30;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel12.Location = new System.Drawing.Point(17, 148);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(988, 234);
            this.panel12.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1019, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.ConsoleTextBox);
            this.panel5.Location = new System.Drawing.Point(354, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 504);
            this.panel5.TabIndex = 6;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTextBox.Location = new System.Drawing.Point(11, 13);
            this.ConsoleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(616, 475);
            this.ConsoleTextBox.TabIndex = 2;
            this.ConsoleTextBox.Text = "";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(365, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(640, 506);
            this.panel6.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.LuacFileOpenButton);
            this.panel3.Controls.Add(this.LuaFileButton);
            this.panel3.Controls.Add(this.LibChecked);
            this.panel3.Controls.Add(this.LibFolderButton);
            this.panel3.Controls.Add(this.UtilFolderButton);
            this.panel3.Location = new System.Drawing.Point(15, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 504);
            this.panel3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lua5_4);
            this.groupBox1.Controls.Add(this.lua5_3);
            this.groupBox1.Location = new System.Drawing.Point(20, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Платформа";
            // 
            // lua5_4
            // 
            this.lua5_4.AutoSize = true;
            this.lua5_4.Location = new System.Drawing.Point(81, 19);
            this.lua5_4.Name = "lua5_4";
            this.lua5_4.Size = new System.Drawing.Size(58, 17);
            this.lua5_4.TabIndex = 6;
            this.lua5_4.TabStop = true;
            this.lua5_4.Text = "Lua5.4";
            this.lua5_4.UseVisualStyleBackColor = true;
            // 
            // lua5_3
            // 
            this.lua5_3.AutoSize = true;
            this.lua5_3.Location = new System.Drawing.Point(160, 19);
            this.lua5_3.Name = "lua5_3";
            this.lua5_3.Size = new System.Drawing.Size(58, 17);
            this.lua5_3.TabIndex = 7;
            this.lua5_3.TabStop = true;
            this.lua5_3.Text = "Lua5.3";
            this.lua5_3.UseVisualStyleBackColor = true;
            // 
            // LuacFileOpenButton
            // 
            this.LuacFileOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuacFileOpenButton.BackgroundImage")));
            this.LuacFileOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LuacFileOpenButton.Location = new System.Drawing.Point(20, 14);
            this.LuacFileOpenButton.Name = "LuacFileOpenButton";
            this.LuacFileOpenButton.Size = new System.Drawing.Size(278, 57);
            this.LuacFileOpenButton.TabIndex = 5;
            this.LuacFileOpenButton.UseVisualStyleBackColor = true;
            this.LuacFileOpenButton.Click += new System.EventHandler(this.LuacFileOpenButton_Click);
            // 
            // LuaFileButton
            // 
            this.LuaFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaFileButton.BackgroundImage")));
            this.LuaFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaFileButton.Location = new System.Drawing.Point(20, 80);
            this.LuaFileButton.Name = "LuaFileButton";
            this.LuaFileButton.Size = new System.Drawing.Size(278, 57);
            this.LuaFileButton.TabIndex = 4;
            this.LuaFileButton.UseVisualStyleBackColor = true;
            this.LuaFileButton.Click += new System.EventHandler(this.LuaFileButton_Click);
            // 
            // LibChecked
            // 
            this.LibChecked.FormattingEnabled = true;
            this.LibChecked.Location = new System.Drawing.Point(20, 283);
            this.LibChecked.Margin = new System.Windows.Forms.Padding(2);
            this.LibChecked.Name = "LibChecked";
            this.LibChecked.Size = new System.Drawing.Size(278, 154);
            this.LibChecked.TabIndex = 3;
            // 
            // LibFolderButton
            // 
            this.LibFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibFolderButton.BackgroundImage")));
            this.LibFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LibFolderButton.Location = new System.Drawing.Point(20, 206);
            this.LibFolderButton.Name = "LibFolderButton";
            this.LibFolderButton.Size = new System.Drawing.Size(278, 57);
            this.LibFolderButton.TabIndex = 2;
            this.LibFolderButton.UseVisualStyleBackColor = true;
            this.LibFolderButton.Click += new System.EventHandler(this.LibFolderButton_Click);
            // 
            // UtilFolderButton
            // 
            this.UtilFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UtilFolderButton.BackgroundImage")));
            this.UtilFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UtilFolderButton.Location = new System.Drawing.Point(20, 143);
            this.UtilFolderButton.Name = "UtilFolderButton";
            this.UtilFolderButton.Size = new System.Drawing.Size(278, 57);
            this.UtilFolderButton.TabIndex = 1;
            this.UtilFolderButton.UseVisualStyleBackColor = true;
            this.UtilFolderButton.Click += new System.EventHandler(this.UtilFolderButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(18, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 506);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.LuaCompileButton);
            this.panel2.Controls.Add(this.LuaRunButton);
            this.panel2.Controls.Add(this.LuacLoadButton);
            this.panel2.Location = new System.Drawing.Point(15, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 101);
            this.panel2.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.StatusLine);
            this.panel11.Location = new System.Drawing.Point(415, 12);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(541, 44);
            this.panel11.TabIndex = 3;
            // 
            // StatusLine
            // 
            this.StatusLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLine.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusLine.Location = new System.Drawing.Point(0, 0);
            this.StatusLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(541, 44);
            this.StatusLine.TabIndex = 6;
            this.StatusLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(318, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 76);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(415, 61);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Maximum = 103;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(541, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // LuaCompileButton
            // 
            this.LuaCompileButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuaCompileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaCompileButton.BackgroundImage")));
            this.LuaCompileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaCompileButton.Location = new System.Drawing.Point(20, 13);
            this.LuaCompileButton.Name = "LuaCompileButton";
            this.LuaCompileButton.Size = new System.Drawing.Size(82, 76);
            this.LuaCompileButton.TabIndex = 3;
            this.LuaCompileButton.UseVisualStyleBackColor = false;
            this.LuaCompileButton.Click += new System.EventHandler(this.LuaCompileButton_Click);
            // 
            // LuaRunButton
            // 
            this.LuaRunButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuaRunButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaRunButton.BackgroundImage")));
            this.LuaRunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaRunButton.Location = new System.Drawing.Point(220, 13);
            this.LuaRunButton.Name = "LuaRunButton";
            this.LuaRunButton.Size = new System.Drawing.Size(77, 76);
            this.LuaRunButton.TabIndex = 2;
            this.LuaRunButton.UseVisualStyleBackColor = false;
            this.LuaRunButton.Click += new System.EventHandler(this.LuaRunButton_Click);
            // 
            // LuacLoadButton
            // 
            this.LuacLoadButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuacLoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuacLoadButton.BackgroundImage")));
            this.LuacLoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuacLoadButton.Location = new System.Drawing.Point(124, 13);
            this.LuacLoadButton.Name = "LuacLoadButton";
            this.LuacLoadButton.Size = new System.Drawing.Size(75, 76);
            this.LuacLoadButton.TabIndex = 1;
            this.LuacLoadButton.UseVisualStyleBackColor = false;
            this.LuacLoadButton.Click += new System.EventHandler(this.LuacLoadButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(18, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 103);
            this.panel1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel26);
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Controls.Add(this.panel16);
            this.tabPage3.Controls.Add(this.panel18);
            this.tabPage3.Controls.Add(this.panel25);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1019, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel26.Controls.Add(this.btnOnlineTelemetry);
            this.panel26.Controls.Add(this.btnOfflineTelemetry);
            this.panel26.Controls.Add(this.btnSaveLog);
            this.panel26.Location = new System.Drawing.Point(398, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(314, 101);
            this.panel26.TabIndex = 44;
            // 
            // btnOnlineTelemetry
            // 
            this.btnOnlineTelemetry.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnlineTelemetry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnlineTelemetry.BackgroundImage")));
            this.btnOnlineTelemetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOnlineTelemetry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOnlineTelemetry.Location = new System.Drawing.Point(15, 13);
            this.btnOnlineTelemetry.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnlineTelemetry.Name = "btnOnlineTelemetry";
            this.btnOnlineTelemetry.Size = new System.Drawing.Size(82, 76);
            this.btnOnlineTelemetry.TabIndex = 48;
            this.btnOnlineTelemetry.UseVisualStyleBackColor = false;
            this.btnOnlineTelemetry.Click += new System.EventHandler(this.btnOnlineTelemetry_Click);
            // 
            // btnOfflineTelemetry
            // 
            this.btnOfflineTelemetry.BackColor = System.Drawing.SystemColors.Control;
            this.btnOfflineTelemetry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOfflineTelemetry.BackgroundImage")));
            this.btnOfflineTelemetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOfflineTelemetry.Location = new System.Drawing.Point(110, 13);
            this.btnOfflineTelemetry.Name = "btnOfflineTelemetry";
            this.btnOfflineTelemetry.Size = new System.Drawing.Size(82, 76);
            this.btnOfflineTelemetry.TabIndex = 5;
            this.btnOfflineTelemetry.UseVisualStyleBackColor = false;
            this.btnOfflineTelemetry.Click += new System.EventHandler(this.btnOfflineTelemetry_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveLog.BackgroundImage")));
            this.btnSaveLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveLog.Location = new System.Drawing.Point(207, 13);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(82, 76);
            this.btnSaveLog.TabIndex = 6;
            this.btnSaveLog.UseVisualStyleBackColor = false;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel24, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel23, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel22, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel21, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel20, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel19, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 115);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(988, 513);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // panel24
            // 
            this.panel24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel24.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel24.Controls.Add(this.Chart8Window);
            this.panel24.Controls.Add(this.Chart8_1Select);
            this.panel24.Controls.Add(this.Chart8_2Select);
            this.panel24.Location = new System.Drawing.Point(497, 387);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(488, 111);
            this.panel24.TabIndex = 56;
            // 
            // Chart8Window
            // 
            this.Chart8Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart8Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart8Window.Location = new System.Drawing.Point(16, 27);
            this.Chart8Window.Name = "Chart8Window";
            this.Chart8Window.Size = new System.Drawing.Size(152, 58);
            this.Chart8Window.TabIndex = 34;
            this.Chart8Window.Text = "График 8";
            this.Chart8Window.UseVisualStyleBackColor = false;
            this.Chart8Window.Click += new System.EventHandler(this.Chart8Window_Click);
            // 
            // Chart8_1Select
            // 
            this.Chart8_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart8_1Select.FormattingEnabled = true;
            this.Chart8_1Select.Location = new System.Drawing.Point(292, 27);
            this.Chart8_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart8_1Select.Name = "Chart8_1Select";
            this.Chart8_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart8_1Select.TabIndex = 42;
            this.Chart8_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart8_1Select_SelectedIndexChanged);
            // 
            // Chart8_2Select
            // 
            this.Chart8_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart8_2Select.FormattingEnabled = true;
            this.Chart8_2Select.Location = new System.Drawing.Point(292, 66);
            this.Chart8_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart8_2Select.Name = "Chart8_2Select";
            this.Chart8_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart8_2Select.TabIndex = 43;
            this.Chart8_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart8_2Select_SelectedIndexChanged);
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel23.Controls.Add(this.Chart7Window);
            this.panel23.Controls.Add(this.Chart7_1Select);
            this.panel23.Controls.Add(this.Chart7_2Select);
            this.panel23.Location = new System.Drawing.Point(3, 387);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(488, 111);
            this.panel23.TabIndex = 55;
            // 
            // Chart7Window
            // 
            this.Chart7Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart7Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart7Window.Location = new System.Drawing.Point(16, 27);
            this.Chart7Window.Name = "Chart7Window";
            this.Chart7Window.Size = new System.Drawing.Size(152, 58);
            this.Chart7Window.TabIndex = 34;
            this.Chart7Window.Text = "График 7";
            this.Chart7Window.UseVisualStyleBackColor = false;
            this.Chart7Window.Click += new System.EventHandler(this.Chart7Window_Click);
            // 
            // Chart7_1Select
            // 
            this.Chart7_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart7_1Select.FormattingEnabled = true;
            this.Chart7_1Select.Location = new System.Drawing.Point(307, 27);
            this.Chart7_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart7_1Select.Name = "Chart7_1Select";
            this.Chart7_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart7_1Select.TabIndex = 42;
            this.Chart7_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart7_1Select_SelectedIndexChanged);
            // 
            // Chart7_2Select
            // 
            this.Chart7_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart7_2Select.FormattingEnabled = true;
            this.Chart7_2Select.Location = new System.Drawing.Point(307, 66);
            this.Chart7_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart7_2Select.Name = "Chart7_2Select";
            this.Chart7_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart7_2Select.TabIndex = 43;
            this.Chart7_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart7_2Select_SelectedIndexChanged);
            // 
            // panel22
            // 
            this.panel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel22.Controls.Add(this.Chart6Window);
            this.panel22.Controls.Add(this.Chart6_1Select);
            this.panel22.Controls.Add(this.Chart6_2Select);
            this.panel22.Location = new System.Drawing.Point(497, 259);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(488, 111);
            this.panel22.TabIndex = 54;
            // 
            // Chart6Window
            // 
            this.Chart6Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart6Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart6Window.Location = new System.Drawing.Point(16, 27);
            this.Chart6Window.Name = "Chart6Window";
            this.Chart6Window.Size = new System.Drawing.Size(152, 58);
            this.Chart6Window.TabIndex = 34;
            this.Chart6Window.Text = "График 6";
            this.Chart6Window.UseVisualStyleBackColor = false;
            this.Chart6Window.Click += new System.EventHandler(this.Chart6Window_Click);
            // 
            // Chart6_1Select
            // 
            this.Chart6_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart6_1Select.FormattingEnabled = true;
            this.Chart6_1Select.Location = new System.Drawing.Point(292, 27);
            this.Chart6_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart6_1Select.Name = "Chart6_1Select";
            this.Chart6_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart6_1Select.TabIndex = 42;
            this.Chart6_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart6_1Select_SelectedIndexChanged);
            // 
            // Chart6_2Select
            // 
            this.Chart6_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart6_2Select.FormattingEnabled = true;
            this.Chart6_2Select.Location = new System.Drawing.Point(292, 66);
            this.Chart6_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart6_2Select.Name = "Chart6_2Select";
            this.Chart6_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart6_2Select.TabIndex = 43;
            this.Chart6_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart6_2Select_SelectedIndexChanged);
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel21.Controls.Add(this.buttChart5Window);
            this.panel21.Controls.Add(this.Chart5_1Select);
            this.panel21.Controls.Add(this.Chart5_2Select);
            this.panel21.Location = new System.Drawing.Point(3, 259);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(488, 111);
            this.panel21.TabIndex = 53;
            // 
            // buttChart5Window
            // 
            this.buttChart5Window.BackColor = System.Drawing.SystemColors.Control;
            this.buttChart5Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttChart5Window.Location = new System.Drawing.Point(16, 27);
            this.buttChart5Window.Name = "buttChart5Window";
            this.buttChart5Window.Size = new System.Drawing.Size(152, 58);
            this.buttChart5Window.TabIndex = 34;
            this.buttChart5Window.Text = "График 5";
            this.buttChart5Window.UseVisualStyleBackColor = false;
            this.buttChart5Window.Click += new System.EventHandler(this.buttChart5Window_Click);
            // 
            // Chart5_1Select
            // 
            this.Chart5_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart5_1Select.FormattingEnabled = true;
            this.Chart5_1Select.Location = new System.Drawing.Point(307, 27);
            this.Chart5_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart5_1Select.Name = "Chart5_1Select";
            this.Chart5_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart5_1Select.TabIndex = 42;
            this.Chart5_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart5_1Select_SelectedIndexChanged);
            // 
            // Chart5_2Select
            // 
            this.Chart5_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart5_2Select.FormattingEnabled = true;
            this.Chart5_2Select.Location = new System.Drawing.Point(307, 66);
            this.Chart5_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart5_2Select.Name = "Chart5_2Select";
            this.Chart5_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart5_2Select.TabIndex = 43;
            this.Chart5_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart5_2Select_SelectedIndexChanged);
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel20.Controls.Add(this.Chart4Window);
            this.panel20.Controls.Add(this.Chart4_1Select);
            this.panel20.Controls.Add(this.Chart4_2Select);
            this.panel20.Location = new System.Drawing.Point(497, 131);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(488, 111);
            this.panel20.TabIndex = 52;
            // 
            // Chart4Window
            // 
            this.Chart4Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart4Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart4Window.Location = new System.Drawing.Point(16, 27);
            this.Chart4Window.Name = "Chart4Window";
            this.Chart4Window.Size = new System.Drawing.Size(152, 58);
            this.Chart4Window.TabIndex = 34;
            this.Chart4Window.Text = "График 4";
            this.Chart4Window.UseVisualStyleBackColor = false;
            this.Chart4Window.Click += new System.EventHandler(this.Chart4Window_Click);
            // 
            // Chart4_1Select
            // 
            this.Chart4_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart4_1Select.FormattingEnabled = true;
            this.Chart4_1Select.Location = new System.Drawing.Point(292, 27);
            this.Chart4_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart4_1Select.Name = "Chart4_1Select";
            this.Chart4_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart4_1Select.TabIndex = 42;
            this.Chart4_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart4_1Select_SelectedIndexChanged);
            // 
            // Chart4_2Select
            // 
            this.Chart4_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart4_2Select.FormattingEnabled = true;
            this.Chart4_2Select.Location = new System.Drawing.Point(292, 66);
            this.Chart4_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart4_2Select.Name = "Chart4_2Select";
            this.Chart4_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart4_2Select.TabIndex = 43;
            this.Chart4_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart4_2Select_SelectedIndexChanged);
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel19.Controls.Add(this.Chart3Window);
            this.panel19.Controls.Add(this.Chart3_1Select);
            this.panel19.Controls.Add(this.Chart3_2Select);
            this.panel19.Location = new System.Drawing.Point(3, 131);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(488, 111);
            this.panel19.TabIndex = 51;
            // 
            // Chart3Window
            // 
            this.Chart3Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart3Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart3Window.Location = new System.Drawing.Point(16, 27);
            this.Chart3Window.Name = "Chart3Window";
            this.Chart3Window.Size = new System.Drawing.Size(152, 58);
            this.Chart3Window.TabIndex = 34;
            this.Chart3Window.Text = "График 3";
            this.Chart3Window.UseVisualStyleBackColor = false;
            this.Chart3Window.Click += new System.EventHandler(this.Chart3Window_Click);
            // 
            // Chart3_1Select
            // 
            this.Chart3_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart3_1Select.FormattingEnabled = true;
            this.Chart3_1Select.Location = new System.Drawing.Point(307, 27);
            this.Chart3_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart3_1Select.Name = "Chart3_1Select";
            this.Chart3_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart3_1Select.TabIndex = 42;
            this.Chart3_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart3_1Select_SelectedIndexChanged);
            // 
            // Chart3_2Select
            // 
            this.Chart3_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart3_2Select.FormattingEnabled = true;
            this.Chart3_2Select.Location = new System.Drawing.Point(307, 66);
            this.Chart3_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart3_2Select.Name = "Chart3_2Select";
            this.Chart3_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart3_2Select.TabIndex = 43;
            this.Chart3_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart3_2Select_SelectedIndexChanged);
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel14.Controls.Add(this.Chart2Window);
            this.panel14.Controls.Add(this.Chart2_1Select);
            this.panel14.Controls.Add(this.Chart2_2Select);
            this.panel14.Location = new System.Drawing.Point(497, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(488, 119);
            this.panel14.TabIndex = 49;
            // 
            // Chart2Window
            // 
            this.Chart2Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart2Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart2Window.Location = new System.Drawing.Point(16, 27);
            this.Chart2Window.Name = "Chart2Window";
            this.Chart2Window.Size = new System.Drawing.Size(152, 58);
            this.Chart2Window.TabIndex = 34;
            this.Chart2Window.Text = "График 2";
            this.Chart2Window.UseVisualStyleBackColor = false;
            this.Chart2Window.Click += new System.EventHandler(this.Chart2Window_Click);
            // 
            // Chart2_1Select
            // 
            this.Chart2_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart2_1Select.FormattingEnabled = true;
            this.Chart2_1Select.Location = new System.Drawing.Point(292, 27);
            this.Chart2_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart2_1Select.Name = "Chart2_1Select";
            this.Chart2_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart2_1Select.TabIndex = 42;
            this.Chart2_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart2_1Select_SelectedIndexChanged);
            // 
            // Chart2_2Select
            // 
            this.Chart2_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart2_2Select.FormattingEnabled = true;
            this.Chart2_2Select.Location = new System.Drawing.Point(292, 66);
            this.Chart2_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart2_2Select.Name = "Chart2_2Select";
            this.Chart2_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart2_2Select.TabIndex = 43;
            this.Chart2_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart2_2Select_SelectedIndexChanged);
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel15.Controls.Add(this.Chart1Window);
            this.panel15.Controls.Add(this.Chart1_1Select);
            this.panel15.Controls.Add(this.Chart1_2Select);
            this.panel15.Location = new System.Drawing.Point(3, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(488, 119);
            this.panel15.TabIndex = 50;
            // 
            // Chart1Window
            // 
            this.Chart1Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart1Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chart1Window.Location = new System.Drawing.Point(16, 27);
            this.Chart1Window.Name = "Chart1Window";
            this.Chart1Window.Size = new System.Drawing.Size(152, 58);
            this.Chart1Window.TabIndex = 34;
            this.Chart1Window.Text = "График 1";
            this.Chart1Window.UseVisualStyleBackColor = false;
            this.Chart1Window.Click += new System.EventHandler(this.Chart1Window_Click);
            // 
            // Chart1_1Select
            // 
            this.Chart1_1Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart1_1Select.FormattingEnabled = true;
            this.Chart1_1Select.Location = new System.Drawing.Point(307, 27);
            this.Chart1_1Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart1_1Select.Name = "Chart1_1Select";
            this.Chart1_1Select.Size = new System.Drawing.Size(123, 21);
            this.Chart1_1Select.TabIndex = 42;
            this.Chart1_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart2_1Select_SelectedIndexChanged);
            // 
            // Chart1_2Select
            // 
            this.Chart1_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart1_2Select.FormattingEnabled = true;
            this.Chart1_2Select.Location = new System.Drawing.Point(307, 66);
            this.Chart1_2Select.Margin = new System.Windows.Forms.Padding(2);
            this.Chart1_2Select.Name = "Chart1_2Select";
            this.Chart1_2Select.Size = new System.Drawing.Size(123, 21);
            this.Chart1_2Select.TabIndex = 43;
            this.Chart1_2Select.SelectedIndexChanged += new System.EventHandler(this.Chart1_2Select_SelectedIndexChanged);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel16.Controls.Add(this.btnTelemetryStop1);
            this.panel16.Controls.Add(this.btnTelemetryRecord1);
            this.panel16.Controls.Add(this.btnTelemetryPause1);
            this.panel16.Controls.Add(this.btnTelemetryRun1);
            this.panel16.Location = new System.Drawing.Point(31, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(350, 101);
            this.panel16.TabIndex = 33;
            // 
            // btnTelemetryStop1
            // 
            this.btnTelemetryStop1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryStop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryStop1.BackgroundImage")));
            this.btnTelemetryStop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryStop1.Location = new System.Drawing.Point(87, 13);
            this.btnTelemetryStop1.Name = "btnTelemetryStop1";
            this.btnTelemetryStop1.Size = new System.Drawing.Size(77, 76);
            this.btnTelemetryStop1.TabIndex = 4;
            this.btnTelemetryStop1.UseVisualStyleBackColor = false;
            this.btnTelemetryStop1.Click += new System.EventHandler(this.btnTelemetryStop_Click);
            // 
            // btnTelemetryRecord1
            // 
            this.btnTelemetryRecord1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRecord1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRecord1.BackgroundImage")));
            this.btnTelemetryRecord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRecord1.Location = new System.Drawing.Point(254, 13);
            this.btnTelemetryRecord1.Name = "btnTelemetryRecord1";
            this.btnTelemetryRecord1.Size = new System.Drawing.Size(82, 76);
            this.btnTelemetryRecord1.TabIndex = 3;
            this.btnTelemetryRecord1.UseVisualStyleBackColor = false;
            this.btnTelemetryRecord1.Click += new System.EventHandler(this.btnTelemetryRecord_Click);
            // 
            // btnTelemetryPause1
            // 
            this.btnTelemetryPause1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryPause1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryPause1.BackgroundImage")));
            this.btnTelemetryPause1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryPause1.Location = new System.Drawing.Point(170, 13);
            this.btnTelemetryPause1.Name = "btnTelemetryPause1";
            this.btnTelemetryPause1.Size = new System.Drawing.Size(77, 76);
            this.btnTelemetryPause1.TabIndex = 2;
            this.btnTelemetryPause1.UseVisualStyleBackColor = false;
            this.btnTelemetryPause1.Click += new System.EventHandler(this.btnTelemetryPause_Click);
            // 
            // btnTelemetryRun1
            // 
            this.btnTelemetryRun1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRun1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRun1.BackgroundImage")));
            this.btnTelemetryRun1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRun1.Location = new System.Drawing.Point(6, 13);
            this.btnTelemetryRun1.Name = "btnTelemetryRun1";
            this.btnTelemetryRun1.Size = new System.Drawing.Size(75, 76);
            this.btnTelemetryRun1.TabIndex = 1;
            this.btnTelemetryRun1.UseVisualStyleBackColor = false;
            this.btnTelemetryRun1.Click += new System.EventHandler(this.btnTelemetryRun_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel18.Location = new System.Drawing.Point(31, 6);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(358, 103);
            this.panel18.TabIndex = 32;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel25.Location = new System.Drawing.Point(395, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(329, 106);
            this.panel25.TabIndex = 47;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel33);
            this.tabPage4.Controls.Add(this.panel34);
            this.tabPage4.Controls.Add(this.panel32);
            this.tabPage4.Controls.Add(this.panel29);
            this.tabPage4.Controls.Add(this.panel30);
            this.tabPage4.Controls.Add(this.panel27);
            this.tabPage4.Controls.Add(this.panel28);
            this.tabPage4.Controls.Add(this.panel31);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1019, 685);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel33.Controls.Add(this.progressBar2);
            this.panel33.Controls.Add(this.btnWriteES);
            this.panel33.Controls.Add(this.label10);
            this.panel33.Controls.Add(this.btnReadES);
            this.panel33.Controls.Add(this.tbEEPROMSize);
            this.panel33.Controls.Add(this.btnAccess);
            this.panel33.Location = new System.Drawing.Point(5, 3);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(241, 248);
            this.panel33.TabIndex = 52;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(17, 215);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(212, 19);
            this.progressBar2.TabIndex = 50;
            // 
            // btnWriteES
            // 
            this.btnWriteES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWriteES.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWriteES.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWriteES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteES.Location = new System.Drawing.Point(10, 122);
            this.btnWriteES.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteES.Name = "btnWriteES";
            this.btnWriteES.Size = new System.Drawing.Size(218, 36);
            this.btnWriteES.TabIndex = 48;
            this.btnWriteES.Text = "Записать в устройство";
            this.btnWriteES.UseVisualStyleBackColor = false;
            this.btnWriteES.Click += new System.EventHandler(this.btnWriteES_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Размер EEPROM";
            // 
            // btnReadES
            // 
            this.btnReadES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadES.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReadES.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReadES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadES.Location = new System.Drawing.Point(10, 66);
            this.btnReadES.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadES.Name = "btnReadES";
            this.btnReadES.Size = new System.Drawing.Size(218, 38);
            this.btnReadES.TabIndex = 49;
            this.btnReadES.Text = "Прочитать из устройства";
            this.btnReadES.UseVisualStyleBackColor = false;
            this.btnReadES.Click += new System.EventHandler(this.btnReadES_Click);
            // 
            // tbEEPROMSize
            // 
            this.tbEEPROMSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEEPROMSize.Location = new System.Drawing.Point(153, 180);
            this.tbEEPROMSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbEEPROMSize.Name = "tbEEPROMSize";
            this.tbEEPROMSize.ReadOnly = true;
            this.tbEEPROMSize.Size = new System.Drawing.Size(77, 26);
            this.tbEEPROMSize.TabIndex = 3;
            this.tbEEPROMSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAccess
            // 
            this.btnAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccess.BackColor = System.Drawing.SystemColors.Control;
            this.btnAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccess.BackgroundImage")));
            this.btnAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccess.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccess.Location = new System.Drawing.Point(10, 11);
            this.btnAccess.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(218, 44);
            this.btnAccess.TabIndex = 37;
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel34.Location = new System.Drawing.Point(14, 15);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(241, 246);
            this.panel34.TabIndex = 53;
            // 
            // panel32
            // 
            this.panel32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel32.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel32.Controls.Add(this.button4);
            this.panel32.Controls.Add(this.button2);
            this.panel32.Controls.Add(this.RecordFormatView);
            this.panel32.Controls.Add(this.timeStampCheck);
            this.panel32.Controls.Add(this.label11);
            this.panel32.Controls.Add(this.btnConfigStorage);
            this.panel32.Controls.Add(this.label15);
            this.panel32.Controls.Add(this.tbRgisterCount);
            this.panel32.Location = new System.Drawing.Point(5, 267);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(241, 358);
            this.panel32.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(118, 258);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 37);
            this.button4.TabIndex = 50;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(8, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 49;
            this.button2.Text = "+Поле";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RecordFormatView
            // 
            this.RecordFormatView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordFormatView.AutoGenerateColumns = false;
            this.RecordFormatView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordFormatView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNumberDataGridViewTextBoxColumn,
            this.fieldTypeDataGridViewTextBoxColumn});
            this.RecordFormatView.DataSource = this.RecordForamtSource;
            this.RecordFormatView.Location = new System.Drawing.Point(8, 113);
            this.RecordFormatView.Margin = new System.Windows.Forms.Padding(2);
            this.RecordFormatView.Name = "RecordFormatView";
            this.RecordFormatView.RowHeadersVisible = false;
            this.RecordFormatView.RowHeadersWidth = 51;
            this.RecordFormatView.RowTemplate.Height = 24;
            this.RecordFormatView.Size = new System.Drawing.Size(220, 135);
            this.RecordFormatView.TabIndex = 48;
            // 
            // timeStampCheck
            // 
            this.timeStampCheck.AutoSize = true;
            this.timeStampCheck.Location = new System.Drawing.Point(10, 84);
            this.timeStampCheck.Margin = new System.Windows.Forms.Padding(2);
            this.timeStampCheck.Name = "timeStampCheck";
            this.timeStampCheck.Size = new System.Drawing.Size(175, 17);
            this.timeStampCheck.TabIndex = 47;
            this.timeStampCheck.Text = "Добавлять временную метку";
            this.timeStampCheck.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(60, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Формат записи";
            // 
            // btnConfigStorage
            // 
            this.btnConfigStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigStorage.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfigStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfigStorage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfigStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfigStorage.Location = new System.Drawing.Point(10, 310);
            this.btnConfigStorage.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigStorage.Name = "btnConfigStorage";
            this.btnConfigStorage.Size = new System.Drawing.Size(220, 37);
            this.btnConfigStorage.TabIndex = 38;
            this.btnConfigStorage.Text = "Сконфигурировать";
            this.btnConfigStorage.UseVisualStyleBackColor = false;
            this.btnConfigStorage.Click += new System.EventHandler(this.btnConfigStorage_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(34, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Количество регистров";
            // 
            // tbRgisterCount
            // 
            this.tbRgisterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRgisterCount.Location = new System.Drawing.Point(76, 39);
            this.tbRgisterCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbRgisterCount.Name = "tbRgisterCount";
            this.tbRgisterCount.Size = new System.Drawing.Size(77, 26);
            this.tbRgisterCount.TabIndex = 0;
            this.tbRgisterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel29
            // 
            this.panel29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel29.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel29.Controls.Add(this.RegisterView);
            this.panel29.Controls.Add(this.RecordView);
            this.panel29.Controls.Add(this.label13);
            this.panel29.Controls.Add(this.txRecordCount);
            this.panel29.Controls.Add(this.label12);
            this.panel29.Controls.Add(this.tbMaxRecord);
            this.panel29.Location = new System.Drawing.Point(263, 98);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(732, 528);
            this.panel29.TabIndex = 50;
            // 
            // RegisterView
            // 
            this.RegisterView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RegisterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisterView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n1DataGridViewTextBoxColumn,
            this.d1DataGridViewTextBoxColumn,
            this.t1DataGridViewTextBoxColumn,
            this.n2DataGridViewTextBoxColumn,
            this.d2DataGridViewTextBoxColumn,
            this.t2DataGridViewTextBoxColumn,
            this.n3DataGridViewTextBoxColumn,
            this.d3DataGridViewTextBoxColumn,
            this.t3DataGridViewTextBoxColumn,
            this.n4DataGridViewTextBoxColumn,
            this.d4DataGridViewTextBoxColumn,
            this.t4DataGridViewTextBoxColumn,
            this.n5DataGridViewTextBoxColumn,
            this.d5DataGridViewTextBoxColumn,
            this.t5DataGridViewTextBoxColumn});
            this.RegisterView.DataSource = this.RegisterSource;
            this.RegisterView.Location = new System.Drawing.Point(17, 16);
            this.RegisterView.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterView.Name = "RegisterView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RegisterView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RegisterView.RowHeadersVisible = false;
            this.RegisterView.RowHeadersWidth = 51;
            this.RegisterView.RowTemplate.Height = 24;
            this.RegisterView.Size = new System.Drawing.Size(696, 280);
            this.RegisterView.TabIndex = 54;
            this.RegisterView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RegisterView_MouseClick);
            // 
            // RecordView
            // 
            this.RecordView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordView.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.p1DataGridViewTextBoxColumn,
            this.p2DataGridViewTextBoxColumn,
            this.p3DataGridViewTextBoxColumn,
            this.p4DataGridViewTextBoxColumn,
            this.p5DataGridViewTextBoxColumn,
            this.p6DataGridViewTextBoxColumn,
            this.p7DataGridViewTextBoxColumn,
            this.p8DataGridViewTextBoxColumn,
            this.p9DataGridViewTextBoxColumn,
            this.p10DataGridViewTextBoxColumn,
            this.P11,
            this.P12,
            this.P13,
            this.P14,
            this.P15,
            this.P16,
            this.P17,
            this.P18,
            this.P19,
            this.P20,
            this.P21,
            this.P23,
            this.P24,
            this.P25,
            this.P26,
            this.P27,
            this.P28,
            this.P29,
            this.P30,
            this.P31,
            this.P32});
            this.RecordView.DataSource = this.RecordSource;
            this.RecordView.Location = new System.Drawing.Point(17, 310);
            this.RecordView.Margin = new System.Windows.Forms.Padding(2);
            this.RecordView.Name = "RecordView";
            this.RecordView.RowHeadersVisible = false;
            this.RecordView.RowHeadersWidth = 51;
            this.RecordView.RowTemplate.Height = 24;
            this.RecordView.Size = new System.Drawing.Size(693, 150);
            this.RecordView.TabIndex = 53;
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "Номер";
            this.index.MinimumWidth = 60;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Visible = false;
            this.index.Width = 60;
            // 
            // P11
            // 
            this.P11.DataPropertyName = "P11";
            this.P11.HeaderText = "Поле 11";
            this.P11.MinimumWidth = 6;
            this.P11.Name = "P11";
            this.P11.ReadOnly = true;
            this.P11.Visible = false;
            this.P11.Width = 125;
            // 
            // P12
            // 
            this.P12.DataPropertyName = "P12";
            this.P12.HeaderText = "Поле 12";
            this.P12.MinimumWidth = 6;
            this.P12.Name = "P12";
            this.P12.ReadOnly = true;
            this.P12.Visible = false;
            this.P12.Width = 125;
            // 
            // P13
            // 
            this.P13.DataPropertyName = "P13";
            this.P13.HeaderText = "Поле 13";
            this.P13.MinimumWidth = 6;
            this.P13.Name = "P13";
            this.P13.ReadOnly = true;
            this.P13.Visible = false;
            this.P13.Width = 125;
            // 
            // P14
            // 
            this.P14.DataPropertyName = "P14";
            this.P14.HeaderText = "Поле 14";
            this.P14.MinimumWidth = 6;
            this.P14.Name = "P14";
            this.P14.ReadOnly = true;
            this.P14.Visible = false;
            this.P14.Width = 125;
            // 
            // P15
            // 
            this.P15.DataPropertyName = "P15";
            this.P15.HeaderText = "Поле 15";
            this.P15.MinimumWidth = 6;
            this.P15.Name = "P15";
            this.P15.ReadOnly = true;
            this.P15.Visible = false;
            this.P15.Width = 125;
            // 
            // P16
            // 
            this.P16.DataPropertyName = "P16";
            this.P16.HeaderText = "Поле 16";
            this.P16.MinimumWidth = 6;
            this.P16.Name = "P16";
            this.P16.ReadOnly = true;
            this.P16.Visible = false;
            this.P16.Width = 125;
            // 
            // P17
            // 
            this.P17.DataPropertyName = "P17";
            this.P17.HeaderText = "Поле 17";
            this.P17.MinimumWidth = 6;
            this.P17.Name = "P17";
            this.P17.ReadOnly = true;
            this.P17.Visible = false;
            this.P17.Width = 125;
            // 
            // P18
            // 
            this.P18.DataPropertyName = "P18";
            this.P18.HeaderText = "Поле 18";
            this.P18.MinimumWidth = 6;
            this.P18.Name = "P18";
            this.P18.ReadOnly = true;
            this.P18.Visible = false;
            this.P18.Width = 125;
            // 
            // P19
            // 
            this.P19.DataPropertyName = "P19";
            this.P19.HeaderText = "Поле 19";
            this.P19.MinimumWidth = 6;
            this.P19.Name = "P19";
            this.P19.ReadOnly = true;
            this.P19.Visible = false;
            this.P19.Width = 125;
            // 
            // P20
            // 
            this.P20.DataPropertyName = "P20";
            this.P20.HeaderText = "Поле 20";
            this.P20.MinimumWidth = 6;
            this.P20.Name = "P20";
            this.P20.ReadOnly = true;
            this.P20.Visible = false;
            this.P20.Width = 125;
            // 
            // P21
            // 
            this.P21.DataPropertyName = "P21";
            this.P21.HeaderText = "Поле 21";
            this.P21.MinimumWidth = 6;
            this.P21.Name = "P21";
            this.P21.ReadOnly = true;
            this.P21.Visible = false;
            this.P21.Width = 125;
            // 
            // P23
            // 
            this.P23.DataPropertyName = "P23";
            this.P23.HeaderText = "Поле 23";
            this.P23.MinimumWidth = 6;
            this.P23.Name = "P23";
            this.P23.ReadOnly = true;
            this.P23.Visible = false;
            this.P23.Width = 125;
            // 
            // P24
            // 
            this.P24.DataPropertyName = "P24";
            this.P24.HeaderText = "Поле 24";
            this.P24.MinimumWidth = 6;
            this.P24.Name = "P24";
            this.P24.ReadOnly = true;
            this.P24.Visible = false;
            this.P24.Width = 125;
            // 
            // P25
            // 
            this.P25.DataPropertyName = "P25";
            this.P25.HeaderText = "Поле 25";
            this.P25.MinimumWidth = 6;
            this.P25.Name = "P25";
            this.P25.ReadOnly = true;
            this.P25.Visible = false;
            this.P25.Width = 125;
            // 
            // P26
            // 
            this.P26.DataPropertyName = "P26";
            this.P26.HeaderText = "Поле 26";
            this.P26.MinimumWidth = 6;
            this.P26.Name = "P26";
            this.P26.ReadOnly = true;
            this.P26.Visible = false;
            this.P26.Width = 125;
            // 
            // P27
            // 
            this.P27.DataPropertyName = "P27";
            this.P27.HeaderText = "Поле 27";
            this.P27.MinimumWidth = 6;
            this.P27.Name = "P27";
            this.P27.ReadOnly = true;
            this.P27.Visible = false;
            this.P27.Width = 125;
            // 
            // P28
            // 
            this.P28.DataPropertyName = "P28";
            this.P28.HeaderText = "Поле 28";
            this.P28.MinimumWidth = 6;
            this.P28.Name = "P28";
            this.P28.ReadOnly = true;
            this.P28.Visible = false;
            this.P28.Width = 125;
            // 
            // P29
            // 
            this.P29.DataPropertyName = "P29";
            this.P29.HeaderText = "Поле 29";
            this.P29.MinimumWidth = 6;
            this.P29.Name = "P29";
            this.P29.ReadOnly = true;
            this.P29.Visible = false;
            this.P29.Width = 125;
            // 
            // P30
            // 
            this.P30.DataPropertyName = "P30";
            this.P30.HeaderText = "Поле 30";
            this.P30.MinimumWidth = 6;
            this.P30.Name = "P30";
            this.P30.ReadOnly = true;
            this.P30.Visible = false;
            this.P30.Width = 125;
            // 
            // P31
            // 
            this.P31.DataPropertyName = "P31";
            this.P31.HeaderText = "Поле 31";
            this.P31.MinimumWidth = 6;
            this.P31.Name = "P31";
            this.P31.ReadOnly = true;
            this.P31.Visible = false;
            this.P31.Width = 125;
            // 
            // P32
            // 
            this.P32.DataPropertyName = "P32";
            this.P32.HeaderText = "Поле 32";
            this.P32.MinimumWidth = 6;
            this.P32.Name = "P32";
            this.P32.ReadOnly = true;
            this.P32.Visible = false;
            this.P32.Width = 125;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(490, 489);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = " Кол-во записей";
            // 
            // txRecordCount
            // 
            this.txRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txRecordCount.Location = new System.Drawing.Point(635, 486);
            this.txRecordCount.Margin = new System.Windows.Forms.Padding(2);
            this.txRecordCount.Name = "txRecordCount";
            this.txRecordCount.ReadOnly = true;
            this.txRecordCount.Size = new System.Drawing.Size(77, 26);
            this.txRecordCount.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 489);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Макc. кол-во записей";
            // 
            // tbMaxRecord
            // 
            this.tbMaxRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaxRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxRecord.Location = new System.Drawing.Point(220, 486);
            this.tbMaxRecord.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxRecord.Name = "tbMaxRecord";
            this.tbMaxRecord.ReadOnly = true;
            this.tbMaxRecord.Size = new System.Drawing.Size(77, 26);
            this.tbMaxRecord.TabIndex = 48;
            // 
            // panel30
            // 
            this.panel30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel30.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel30.Location = new System.Drawing.Point(272, 115);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(736, 521);
            this.panel30.TabIndex = 51;
            // 
            // panel27
            // 
            this.panel27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel27.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel27.Controls.Add(this.tableLayoutPanel3);
            this.panel27.Controls.Add(this.label9);
            this.panel27.Controls.Add(this.label8);
            this.panel27.Controls.Add(this.label7);
            this.panel27.Controls.Add(this.label6);
            this.panel27.Controls.Add(this.label5);
            this.panel27.Controls.Add(this.label4);
            this.panel27.Controls.Add(this.HTxtb);
            this.panel27.Controls.Add(this.MTxtb);
            this.panel27.Controls.Add(this.STxtb);
            this.panel27.Controls.Add(this.YTxtb);
            this.panel27.Controls.Add(this.DTxtb);
            this.panel27.Controls.Add(this.MonTxtb);
            this.panel27.Location = new System.Drawing.Point(263, 3);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(732, 75);
            this.panel27.TabIndex = 48;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnReadTime, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSyn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(309, 8);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 47);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // btnReadTime
            // 
            this.btnReadTime.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReadTime.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReadTime.Location = new System.Drawing.Point(2, 2);
            this.btnReadTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadTime.Name = "btnReadTime";
            this.btnReadTime.Size = new System.Drawing.Size(203, 43);
            this.btnReadTime.TabIndex = 37;
            this.btnReadTime.Text = "Прочитать время";
            this.btnReadTime.UseVisualStyleBackColor = false;
            this.btnReadTime.Click += new System.EventHandler(this.btnReadTime_Click);
            // 
            // btnSyn
            // 
            this.btnSyn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSyn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSyn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSyn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSyn.Location = new System.Drawing.Point(209, 2);
            this.btnSyn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(203, 43);
            this.btnSyn.TabIndex = 38;
            this.btnSyn.Text = "Синхронизировать верия";
            this.btnSyn.UseVisualStyleBackColor = false;
            this.btnSyn.Click += new System.EventHandler(this.btnSyn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Дата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(190, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(125, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(189, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(125, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Время";
            // 
            // HTxtb
            // 
            this.HTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HTxtb.Location = new System.Drawing.Point(84, 10);
            this.HTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.HTxtb.Name = "HTxtb";
            this.HTxtb.Size = new System.Drawing.Size(38, 26);
            this.HTxtb.TabIndex = 0;
            // 
            // MTxtb
            // 
            this.MTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MTxtb.Location = new System.Drawing.Point(148, 8);
            this.MTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.MTxtb.Name = "MTxtb";
            this.MTxtb.Size = new System.Drawing.Size(36, 26);
            this.MTxtb.TabIndex = 1;
            // 
            // STxtb
            // 
            this.STxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STxtb.Location = new System.Drawing.Point(208, 8);
            this.STxtb.Margin = new System.Windows.Forms.Padding(2);
            this.STxtb.Name = "STxtb";
            this.STxtb.Size = new System.Drawing.Size(36, 26);
            this.STxtb.TabIndex = 2;
            // 
            // YTxtb
            // 
            this.YTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTxtb.Location = new System.Drawing.Point(208, 42);
            this.YTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.YTxtb.Name = "YTxtb";
            this.YTxtb.Size = new System.Drawing.Size(44, 26);
            this.YTxtb.TabIndex = 5;
            // 
            // DTxtb
            // 
            this.DTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DTxtb.Location = new System.Drawing.Point(84, 42);
            this.DTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.DTxtb.Name = "DTxtb";
            this.DTxtb.Size = new System.Drawing.Size(38, 26);
            this.DTxtb.TabIndex = 3;
            // 
            // MonTxtb
            // 
            this.MonTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonTxtb.Location = new System.Drawing.Point(148, 42);
            this.MonTxtb.Margin = new System.Windows.Forms.Padding(2);
            this.MonTxtb.Name = "MonTxtb";
            this.MonTxtb.Size = new System.Drawing.Size(36, 26);
            this.MonTxtb.TabIndex = 4;
            // 
            // panel28
            // 
            this.panel28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel28.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel28.Location = new System.Drawing.Point(272, 13);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(736, 79);
            this.panel28.TabIndex = 49;
            // 
            // panel31
            // 
            this.panel31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel31.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel31.Location = new System.Drawing.Point(10, 280);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(244, 356);
            this.panel31.TabIndex = 50;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\i.dymov\\Documents\\WindowsFormsApp1\\WindowsFormsApp1\\PDM Help File.chm";
            // 
            // fieldNumberDataGridViewTextBoxColumn
            // 
            this.fieldNumberDataGridViewTextBoxColumn.DataPropertyName = "FieldNumber";
            this.fieldNumberDataGridViewTextBoxColumn.HeaderText = "№ поля";
            this.fieldNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldNumberDataGridViewTextBoxColumn.Name = "fieldNumberDataGridViewTextBoxColumn";
            this.fieldNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // fieldTypeDataGridViewTextBoxColumn
            // 
            this.fieldTypeDataGridViewTextBoxColumn.DataPropertyName = "FieldType";
            this.fieldTypeDataGridViewTextBoxColumn.HeaderText = "Тип поля";
            this.fieldTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "BYTE",
            "SHORT",
            "LUA_TYPE"});
            this.fieldTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fieldTypeDataGridViewTextBoxColumn.Name = "fieldTypeDataGridViewTextBoxColumn";
            this.fieldTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fieldTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // RecordForamtSource
            // 
            this.RecordForamtSource.AllowNew = false;
            this.RecordForamtSource.DataSource = typeof(WindowsFormsApp1.EEPROMRecordFormat);
            // 
            // n1DataGridViewTextBoxColumn
            // 
            this.n1DataGridViewTextBoxColumn.DataPropertyName = "N1";
            this.n1DataGridViewTextBoxColumn.HeaderText = "N";
            this.n1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n1DataGridViewTextBoxColumn.Name = "n1DataGridViewTextBoxColumn";
            this.n1DataGridViewTextBoxColumn.ReadOnly = true;
            this.n1DataGridViewTextBoxColumn.Width = 20;
            // 
            // d1DataGridViewTextBoxColumn
            // 
            this.d1DataGridViewTextBoxColumn.DataPropertyName = "D1";
            this.d1DataGridViewTextBoxColumn.HeaderText = "Значение";
            this.d1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.d1DataGridViewTextBoxColumn.Name = "d1DataGridViewTextBoxColumn";
            this.d1DataGridViewTextBoxColumn.Width = 110;
            // 
            // t1DataGridViewTextBoxColumn
            // 
            this.t1DataGridViewTextBoxColumn.DataPropertyName = "T1";
            this.t1DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.t1DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Не определено",
            "Дата и время",
            "LUA_INT",
            "LUA_FLOAT",
            "LUA_BOOL"});
            this.t1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t1DataGridViewTextBoxColumn.Name = "t1DataGridViewTextBoxColumn";
            this.t1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.t1DataGridViewTextBoxColumn.Width = 90;
            // 
            // n2DataGridViewTextBoxColumn
            // 
            this.n2DataGridViewTextBoxColumn.DataPropertyName = "N2";
            this.n2DataGridViewTextBoxColumn.HeaderText = "N";
            this.n2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n2DataGridViewTextBoxColumn.Name = "n2DataGridViewTextBoxColumn";
            this.n2DataGridViewTextBoxColumn.ReadOnly = true;
            this.n2DataGridViewTextBoxColumn.Width = 20;
            // 
            // d2DataGridViewTextBoxColumn
            // 
            this.d2DataGridViewTextBoxColumn.DataPropertyName = "D2";
            this.d2DataGridViewTextBoxColumn.HeaderText = "Значение";
            this.d2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.d2DataGridViewTextBoxColumn.Name = "d2DataGridViewTextBoxColumn";
            this.d2DataGridViewTextBoxColumn.Width = 110;
            // 
            // t2DataGridViewTextBoxColumn
            // 
            this.t2DataGridViewTextBoxColumn.DataPropertyName = "T2";
            this.t2DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.t2DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Не определено",
            "Дата и время",
            "LUA_INT",
            "LUA_FLOAT",
            "LUA_BOOL"});
            this.t2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t2DataGridViewTextBoxColumn.Name = "t2DataGridViewTextBoxColumn";
            this.t2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.t2DataGridViewTextBoxColumn.Width = 90;
            // 
            // n3DataGridViewTextBoxColumn
            // 
            this.n3DataGridViewTextBoxColumn.DataPropertyName = "N3";
            this.n3DataGridViewTextBoxColumn.HeaderText = "N";
            this.n3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n3DataGridViewTextBoxColumn.Name = "n3DataGridViewTextBoxColumn";
            this.n3DataGridViewTextBoxColumn.ReadOnly = true;
            this.n3DataGridViewTextBoxColumn.Width = 20;
            // 
            // d3DataGridViewTextBoxColumn
            // 
            this.d3DataGridViewTextBoxColumn.DataPropertyName = "D3";
            this.d3DataGridViewTextBoxColumn.HeaderText = "Значение";
            this.d3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.d3DataGridViewTextBoxColumn.Name = "d3DataGridViewTextBoxColumn";
            this.d3DataGridViewTextBoxColumn.Width = 110;
            // 
            // t3DataGridViewTextBoxColumn
            // 
            this.t3DataGridViewTextBoxColumn.DataPropertyName = "T3";
            this.t3DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.t3DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Не определено",
            "Дата и время",
            "LUA_INT",
            "LUA_FLOAT",
            "LUA_BOOL"});
            this.t3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t3DataGridViewTextBoxColumn.Name = "t3DataGridViewTextBoxColumn";
            this.t3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.t3DataGridViewTextBoxColumn.Width = 90;
            // 
            // n4DataGridViewTextBoxColumn
            // 
            this.n4DataGridViewTextBoxColumn.DataPropertyName = "N4";
            this.n4DataGridViewTextBoxColumn.HeaderText = "N";
            this.n4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n4DataGridViewTextBoxColumn.Name = "n4DataGridViewTextBoxColumn";
            this.n4DataGridViewTextBoxColumn.ReadOnly = true;
            this.n4DataGridViewTextBoxColumn.Width = 20;
            // 
            // d4DataGridViewTextBoxColumn
            // 
            this.d4DataGridViewTextBoxColumn.DataPropertyName = "D4";
            this.d4DataGridViewTextBoxColumn.HeaderText = "Значение";
            this.d4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.d4DataGridViewTextBoxColumn.Name = "d4DataGridViewTextBoxColumn";
            this.d4DataGridViewTextBoxColumn.Width = 110;
            // 
            // t4DataGridViewTextBoxColumn
            // 
            this.t4DataGridViewTextBoxColumn.DataPropertyName = "T4";
            this.t4DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.t4DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Не определено",
            "Дата и время",
            "LUA_INT",
            "LUA_FLOAT",
            "LUA_BOOL"});
            this.t4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t4DataGridViewTextBoxColumn.Name = "t4DataGridViewTextBoxColumn";
            this.t4DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t4DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.t4DataGridViewTextBoxColumn.Width = 90;
            // 
            // n5DataGridViewTextBoxColumn
            // 
            this.n5DataGridViewTextBoxColumn.DataPropertyName = "N5";
            this.n5DataGridViewTextBoxColumn.HeaderText = "N";
            this.n5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.n5DataGridViewTextBoxColumn.Name = "n5DataGridViewTextBoxColumn";
            this.n5DataGridViewTextBoxColumn.ReadOnly = true;
            this.n5DataGridViewTextBoxColumn.Width = 29;
            // 
            // d5DataGridViewTextBoxColumn
            // 
            this.d5DataGridViewTextBoxColumn.DataPropertyName = "D5";
            this.d5DataGridViewTextBoxColumn.HeaderText = "Значение";
            this.d5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.d5DataGridViewTextBoxColumn.Name = "d5DataGridViewTextBoxColumn";
            this.d5DataGridViewTextBoxColumn.Width = 110;
            // 
            // t5DataGridViewTextBoxColumn
            // 
            this.t5DataGridViewTextBoxColumn.DataPropertyName = "T5";
            this.t5DataGridViewTextBoxColumn.HeaderText = "Тип";
            this.t5DataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Не определено",
            "Дата и время",
            "LUA_INT",
            "LUA_FLOAT",
            "LUA_BOOL"});
            this.t5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.t5DataGridViewTextBoxColumn.Name = "t5DataGridViewTextBoxColumn";
            this.t5DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t5DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.t5DataGridViewTextBoxColumn.Width = 90;
            // 
            // RegisterSource
            // 
            this.RegisterSource.DataSource = typeof(WindowsFormsApp1.EEPROMRegister);
            // 
            // p1DataGridViewTextBoxColumn
            // 
            this.p1DataGridViewTextBoxColumn.DataPropertyName = "P1";
            this.p1DataGridViewTextBoxColumn.HeaderText = "Поле 1";
            this.p1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p1DataGridViewTextBoxColumn.Name = "p1DataGridViewTextBoxColumn";
            this.p1DataGridViewTextBoxColumn.ReadOnly = true;
            this.p1DataGridViewTextBoxColumn.Visible = false;
            this.p1DataGridViewTextBoxColumn.Width = 125;
            // 
            // p2DataGridViewTextBoxColumn
            // 
            this.p2DataGridViewTextBoxColumn.DataPropertyName = "P2";
            this.p2DataGridViewTextBoxColumn.HeaderText = "Поле 2";
            this.p2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p2DataGridViewTextBoxColumn.Name = "p2DataGridViewTextBoxColumn";
            this.p2DataGridViewTextBoxColumn.ReadOnly = true;
            this.p2DataGridViewTextBoxColumn.Visible = false;
            this.p2DataGridViewTextBoxColumn.Width = 125;
            // 
            // p3DataGridViewTextBoxColumn
            // 
            this.p3DataGridViewTextBoxColumn.DataPropertyName = "P3";
            this.p3DataGridViewTextBoxColumn.HeaderText = "Поле 3";
            this.p3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p3DataGridViewTextBoxColumn.Name = "p3DataGridViewTextBoxColumn";
            this.p3DataGridViewTextBoxColumn.ReadOnly = true;
            this.p3DataGridViewTextBoxColumn.Visible = false;
            this.p3DataGridViewTextBoxColumn.Width = 125;
            // 
            // p4DataGridViewTextBoxColumn
            // 
            this.p4DataGridViewTextBoxColumn.DataPropertyName = "P4";
            this.p4DataGridViewTextBoxColumn.HeaderText = "Поле 4";
            this.p4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p4DataGridViewTextBoxColumn.Name = "p4DataGridViewTextBoxColumn";
            this.p4DataGridViewTextBoxColumn.ReadOnly = true;
            this.p4DataGridViewTextBoxColumn.Visible = false;
            this.p4DataGridViewTextBoxColumn.Width = 125;
            // 
            // p5DataGridViewTextBoxColumn
            // 
            this.p5DataGridViewTextBoxColumn.DataPropertyName = "P5";
            this.p5DataGridViewTextBoxColumn.HeaderText = "Поле 5";
            this.p5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p5DataGridViewTextBoxColumn.Name = "p5DataGridViewTextBoxColumn";
            this.p5DataGridViewTextBoxColumn.ReadOnly = true;
            this.p5DataGridViewTextBoxColumn.Visible = false;
            this.p5DataGridViewTextBoxColumn.Width = 125;
            // 
            // p6DataGridViewTextBoxColumn
            // 
            this.p6DataGridViewTextBoxColumn.DataPropertyName = "P6";
            this.p6DataGridViewTextBoxColumn.HeaderText = "Поле 6";
            this.p6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p6DataGridViewTextBoxColumn.Name = "p6DataGridViewTextBoxColumn";
            this.p6DataGridViewTextBoxColumn.ReadOnly = true;
            this.p6DataGridViewTextBoxColumn.Visible = false;
            this.p6DataGridViewTextBoxColumn.Width = 125;
            // 
            // p7DataGridViewTextBoxColumn
            // 
            this.p7DataGridViewTextBoxColumn.DataPropertyName = "P7";
            this.p7DataGridViewTextBoxColumn.HeaderText = "Поле 7";
            this.p7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p7DataGridViewTextBoxColumn.Name = "p7DataGridViewTextBoxColumn";
            this.p7DataGridViewTextBoxColumn.ReadOnly = true;
            this.p7DataGridViewTextBoxColumn.Visible = false;
            this.p7DataGridViewTextBoxColumn.Width = 125;
            // 
            // p8DataGridViewTextBoxColumn
            // 
            this.p8DataGridViewTextBoxColumn.DataPropertyName = "P8";
            this.p8DataGridViewTextBoxColumn.HeaderText = "Поле 8";
            this.p8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p8DataGridViewTextBoxColumn.Name = "p8DataGridViewTextBoxColumn";
            this.p8DataGridViewTextBoxColumn.ReadOnly = true;
            this.p8DataGridViewTextBoxColumn.Visible = false;
            this.p8DataGridViewTextBoxColumn.Width = 125;
            // 
            // p9DataGridViewTextBoxColumn
            // 
            this.p9DataGridViewTextBoxColumn.DataPropertyName = "P9";
            this.p9DataGridViewTextBoxColumn.HeaderText = "Поле 9";
            this.p9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p9DataGridViewTextBoxColumn.Name = "p9DataGridViewTextBoxColumn";
            this.p9DataGridViewTextBoxColumn.ReadOnly = true;
            this.p9DataGridViewTextBoxColumn.Visible = false;
            this.p9DataGridViewTextBoxColumn.Width = 125;
            // 
            // p10DataGridViewTextBoxColumn
            // 
            this.p10DataGridViewTextBoxColumn.DataPropertyName = "P10";
            this.p10DataGridViewTextBoxColumn.HeaderText = "Поле 10";
            this.p10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.p10DataGridViewTextBoxColumn.Name = "p10DataGridViewTextBoxColumn";
            this.p10DataGridViewTextBoxColumn.ReadOnly = true;
            this.p10DataGridViewTextBoxColumn.Visible = false;
            this.p10DataGridViewTextBoxColumn.Width = 125;
            // 
            // RecordSource
            // 
            this.RecordSource.DataSource = typeof(WindowsFormsApp1.EEPROMRecord);
            // 
            // SystemDataSource
            // 
            this.SystemDataSource.DataSource = typeof(WindowsFormsApp1.Properties.DataSources.TelemtryFull);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 694);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel17);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sider";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscreteOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_Par)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel33.PerformLayout();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordFormatView)).EndInit();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordForamtSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label LUA_TIME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LuaState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DinInput;
        private System.Windows.Forms.DataGridView AnalogInput;
        private System.Windows.Forms.DataGridView DiscreteOut;
        private System.Windows.Forms.DataGridView System_Par;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource RecordSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LuacLoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LibFolderButton;
        private System.Windows.Forms.Button UtilFolderButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button LuaRunButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox LibChecked;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button LuaCompileButton;
        private System.Windows.Forms.Button LuacFileOpenButton;
        private System.Windows.Forms.Button LuaFileButton;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLUARestart;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnTelemetryStop;
        private System.Windows.Forms.Button btnTelemetryRecord;
        private System.Windows.Forms.Button btnTelemetryPause;
        private System.Windows.Forms.Button btnTelemetryRun;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label LoopTimeLabel;
        private System.Windows.Forms.TextBox LoopTime;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.Button btnOfflineTelemetry;
        private System.Windows.Forms.Button btnTelemetryStop1;
        private System.Windows.Forms.Button btnTelemetryRecord1;
        private System.Windows.Forms.Button btnTelemetryPause1;
        private System.Windows.Forms.Button btnTelemetryRun1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button Chart2Window;
        private System.Windows.Forms.ComboBox Chart2_1Select;
        private System.Windows.Forms.ComboBox Chart2_2Select;
        private System.Windows.Forms.Button Chart1Window;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button Chart8Window;
        private System.Windows.Forms.ComboBox Chart8_1Select;
        private System.Windows.Forms.ComboBox Chart8_2Select;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button Chart7Window;
        private System.Windows.Forms.ComboBox Chart7_1Select;
        private System.Windows.Forms.ComboBox Chart7_2Select;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button Chart6Window;
        private System.Windows.Forms.ComboBox Chart6_1Select;
        private System.Windows.Forms.ComboBox Chart6_2Select;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button buttChart5Window;
        private System.Windows.Forms.ComboBox Chart5_1Select;
        private System.Windows.Forms.ComboBox Chart5_2Select;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button Chart4Window;
        private System.Windows.Forms.ComboBox Chart4_1Select;
        private System.Windows.Forms.ComboBox Chart4_2Select;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button Chart3Window;
        private System.Windows.Forms.ComboBox Chart3_1Select;
        private System.Windows.Forms.ComboBox Chart3_2Select;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox Chart1_1Select;
        private System.Windows.Forms.ComboBox Chart1_2Select;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnOnlineTelemetry;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label app_version_lebel;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSyn;
        private System.Windows.Forms.Button btnReadTime;
        private System.Windows.Forms.TextBox YTxtb;
        private System.Windows.Forms.TextBox MonTxtb;
        private System.Windows.Forms.TextBox DTxtb;
        private System.Windows.Forms.TextBox STxtb;
        private System.Windows.Forms.TextBox MTxtb;
        private System.Windows.Forms.TextBox HTxtb;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.TextBox tbRgisterCount;
        private System.Windows.Forms.Button btnConfigStorage;
        private System.Windows.Forms.TextBox tbEEPROMSize;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnWriteES;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaxRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Button btnReadES;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txRecordCount;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox timeStampCheck;
        private System.Windows.Forms.BindingSource RegisterSource;
        private System.Windows.Forms.DataGridView RecordView;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P11;
        private System.Windows.Forms.DataGridViewTextBoxColumn P12;
        private System.Windows.Forms.DataGridViewTextBoxColumn P13;
        private System.Windows.Forms.DataGridViewTextBoxColumn P14;
        private System.Windows.Forms.DataGridViewTextBoxColumn P15;
        private System.Windows.Forms.DataGridViewTextBoxColumn P16;
        private System.Windows.Forms.DataGridViewTextBoxColumn P17;
        private System.Windows.Forms.DataGridViewTextBoxColumn P18;
        private System.Windows.Forms.DataGridViewTextBoxColumn P19;
        private System.Windows.Forms.DataGridViewTextBoxColumn P20;
        private System.Windows.Forms.DataGridViewTextBoxColumn P21;
        private System.Windows.Forms.DataGridViewTextBoxColumn P23;
        private System.Windows.Forms.DataGridViewTextBoxColumn P24;
        private System.Windows.Forms.DataGridViewTextBoxColumn P25;
        private System.Windows.Forms.DataGridViewTextBoxColumn P26;
        private System.Windows.Forms.DataGridViewTextBoxColumn P27;
        private System.Windows.Forms.DataGridViewTextBoxColumn P28;
        private System.Windows.Forms.DataGridViewTextBoxColumn P29;
        private System.Windows.Forms.DataGridViewTextBoxColumn P30;
        private System.Windows.Forms.DataGridViewTextBoxColumn P31;
        private System.Windows.Forms.DataGridViewTextBoxColumn P32;
        private System.Windows.Forms.DataGridView RegisterView;
        private System.Windows.Forms.DataGridViewTextBoxColumn n1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn n5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView RecordFormatView;
        private System.Windows.Forms.BindingSource RecordForamtSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fieldTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource SystemDataSource;
        private System.Windows.Forms.Button btnComLoad;
        private System.Windows.Forms.RadioButton lua5_3;
        private System.Windows.Forms.RadioButton lua5_4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

