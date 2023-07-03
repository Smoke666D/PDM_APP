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
            this.LUA_TIME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscreteOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.System_Par)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // LUA_TIME
            // 
            this.LUA_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LUA_TIME.AutoSize = true;
            this.LUA_TIME.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUA_TIME.Location = new System.Drawing.Point(480, 65);
            this.LUA_TIME.Name = "LUA_TIME";
            this.LUA_TIME.Size = new System.Drawing.Size(100, 36);
            this.LUA_TIME.TabIndex = 5;
            this.LUA_TIME.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время исполнения";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(175, 793);
            this.panel17.TabIndex = 20;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.Location = new System.Drawing.Point(10, 639);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(155, 78);
            this.btnHelp.TabIndex = 34;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.button4_Click);
            // 
            // app_version_lebel
            // 
            this.app_version_lebel.AutoSize = true;
            this.app_version_lebel.Location = new System.Drawing.Point(59, 759);
            this.app_version_lebel.Name = "app_version_lebel";
            this.app_version_lebel.Size = new System.Drawing.Size(34, 16);
            this.app_version_lebel.TabIndex = 33;
            this.app_version_lebel.Text = "v 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 733);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
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
            this.btnLUARestart.Location = new System.Drawing.Point(10, 90);
            this.btnLUARestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLUARestart.Name = "btnLUARestart";
            this.btnLUARestart.Size = new System.Drawing.Size(155, 78);
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
            this.button3.Location = new System.Drawing.Point(10, 445);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 78);
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
            this.btnLoad.Location = new System.Drawing.Point(10, 281);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(155, 78);
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
            this.button1.Location = new System.Drawing.Point(10, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 78);
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
            this.label1.Location = new System.Drawing.Point(612, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "мкс";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(41, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 92);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // LuaState
            // 
            this.LuaState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LuaState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuaState.Location = new System.Drawing.Point(0, 0);
            this.LuaState.Name = "LuaState";
            this.LuaState.Size = new System.Drawing.Size(489, 54);
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
            this.DinInput.Location = new System.Drawing.Point(768, 4);
            this.DinInput.Margin = new System.Windows.Forms.Padding(4);
            this.DinInput.Name = "DinInput";
            this.DinInput.RowHeadersWidth = 51;
            this.DinInput.Size = new System.Drawing.Size(171, 592);
            this.DinInput.TabIndex = 24;
            // 
            // AnalogInput
            // 
            this.AnalogInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnalogInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalogInput.Location = new System.Drawing.Point(428, 4);
            this.AnalogInput.Margin = new System.Windows.Forms.Padding(4);
            this.AnalogInput.Name = "AnalogInput";
            this.AnalogInput.RowHeadersWidth = 51;
            this.AnalogInput.Size = new System.Drawing.Size(332, 592);
            this.AnalogInput.TabIndex = 25;
            // 
            // DiscreteOut
            // 
            this.DiscreteOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscreteOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscreteOut.Location = new System.Drawing.Point(4, 4);
            this.DiscreteOut.Margin = new System.Windows.Forms.Padding(4);
            this.DiscreteOut.Name = "DiscreteOut";
            this.DiscreteOut.RowHeadersWidth = 51;
            this.DiscreteOut.Size = new System.Drawing.Size(416, 592);
            this.DiscreteOut.TabIndex = 26;
            // 
            // System_Par
            // 
            this.System_Par.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.System_Par.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.System_Par.Location = new System.Drawing.Point(947, 4);
            this.System_Par.Margin = new System.Windows.Forms.Padding(4);
            this.System_Par.Name = "System_Par";
            this.System_Par.RowHeadersWidth = 51;
            this.System_Par.Size = new System.Drawing.Size(354, 592);
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
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(182, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1369, 793);
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
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1361, 784);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1305, 594);
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
            this.panel9.Location = new System.Drawing.Point(650, 20);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(674, 124);
            this.panel9.TabIndex = 33;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.LuaState);
            this.panel13.Location = new System.Drawing.Point(172, 15);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(489, 54);
            this.panel13.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel10.Location = new System.Drawing.Point(654, 32);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(687, 127);
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
            this.panel7.Location = new System.Drawing.Point(19, 20);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(605, 124);
            this.panel7.TabIndex = 31;
            // 
            // LoopTimeLabel
            // 
            this.LoopTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopTimeLabel.AutoSize = true;
            this.LoopTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopTimeLabel.Location = new System.Drawing.Point(474, 28);
            this.LoopTimeLabel.Name = "LoopTimeLabel";
            this.LoopTimeLabel.Size = new System.Drawing.Size(0, 26);
            this.LoopTimeLabel.TabIndex = 6;
            // 
            // LoopTime
            // 
            this.LoopTime.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopTime.Location = new System.Drawing.Point(467, 82);
            this.LoopTime.Name = "LoopTime";
            this.LoopTime.Size = new System.Drawing.Size(124, 30);
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
            this.btnTelemetryStop.Location = new System.Drawing.Point(116, 16);
            this.btnTelemetryStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryStop.Name = "btnTelemetryStop";
            this.btnTelemetryStop.Size = new System.Drawing.Size(103, 94);
            this.btnTelemetryStop.TabIndex = 4;
            this.btnTelemetryStop.UseVisualStyleBackColor = false;
            this.btnTelemetryStop.Click += new System.EventHandler(this.btnTelemetryStop_Click);
            // 
            // btnTelemetryRecord
            // 
            this.btnTelemetryRecord.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRecord.BackgroundImage")));
            this.btnTelemetryRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRecord.Location = new System.Drawing.Point(338, 16);
            this.btnTelemetryRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryRecord.Name = "btnTelemetryRecord";
            this.btnTelemetryRecord.Size = new System.Drawing.Size(110, 94);
            this.btnTelemetryRecord.TabIndex = 3;
            this.btnTelemetryRecord.UseVisualStyleBackColor = false;
            this.btnTelemetryRecord.Click += new System.EventHandler(this.btnTelemetryRecord_Click);
            // 
            // btnTelemetryPause
            // 
            this.btnTelemetryPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryPause.BackgroundImage")));
            this.btnTelemetryPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryPause.Location = new System.Drawing.Point(227, 16);
            this.btnTelemetryPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryPause.Name = "btnTelemetryPause";
            this.btnTelemetryPause.Size = new System.Drawing.Size(103, 94);
            this.btnTelemetryPause.TabIndex = 2;
            this.btnTelemetryPause.UseVisualStyleBackColor = false;
            this.btnTelemetryPause.Click += new System.EventHandler(this.btnTelemetryPause_Click);
            // 
            // btnTelemetryRun
            // 
            this.btnTelemetryRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRun.BackgroundImage")));
            this.btnTelemetryRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRun.Location = new System.Drawing.Point(8, 16);
            this.btnTelemetryRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryRun.Name = "btnTelemetryRun";
            this.btnTelemetryRun.Size = new System.Drawing.Size(100, 94);
            this.btnTelemetryRun.TabIndex = 1;
            this.btnTelemetryRun.UseVisualStyleBackColor = false;
            this.btnTelemetryRun.Click += new System.EventHandler(this.btnTelemetryRun_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Location = new System.Drawing.Point(23, 32);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(619, 127);
            this.panel8.TabIndex = 30;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel12.Location = new System.Drawing.Point(23, 182);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1318, 592);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1361, 784);
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
            this.panel5.Location = new System.Drawing.Point(472, 167);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(848, 567);
            this.panel5.TabIndex = 6;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTextBox.Location = new System.Drawing.Point(15, 16);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(817, 531);
            this.ConsoleTextBox.TabIndex = 2;
            this.ConsoleTextBox.Text = "";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(487, 180);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(851, 567);
            this.panel6.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.LuacFileOpenButton);
            this.panel3.Controls.Add(this.LuaFileButton);
            this.panel3.Controls.Add(this.LibChecked);
            this.panel3.Controls.Add(this.LibFolderButton);
            this.panel3.Controls.Add(this.UtilFolderButton);
            this.panel3.Location = new System.Drawing.Point(20, 167);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 567);
            this.panel3.TabIndex = 5;
            // 
            // LuacFileOpenButton
            // 
            this.LuacFileOpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuacFileOpenButton.BackgroundImage")));
            this.LuacFileOpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LuacFileOpenButton.Location = new System.Drawing.Point(27, 17);
            this.LuacFileOpenButton.Margin = new System.Windows.Forms.Padding(4);
            this.LuacFileOpenButton.Name = "LuacFileOpenButton";
            this.LuacFileOpenButton.Size = new System.Drawing.Size(370, 70);
            this.LuacFileOpenButton.TabIndex = 5;
            this.LuacFileOpenButton.UseVisualStyleBackColor = true;
            this.LuacFileOpenButton.Click += new System.EventHandler(this.LuacFileOpenButton_Click);
            // 
            // LuaFileButton
            // 
            this.LuaFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaFileButton.BackgroundImage")));
            this.LuaFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaFileButton.Location = new System.Drawing.Point(27, 98);
            this.LuaFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.LuaFileButton.Name = "LuaFileButton";
            this.LuaFileButton.Size = new System.Drawing.Size(370, 70);
            this.LuaFileButton.TabIndex = 4;
            this.LuaFileButton.UseVisualStyleBackColor = true;
            this.LuaFileButton.Click += new System.EventHandler(this.LuaFileButton_Click);
            // 
            // LibChecked
            // 
            this.LibChecked.FormattingEnabled = true;
            this.LibChecked.Location = new System.Drawing.Point(27, 348);
            this.LibChecked.Name = "LibChecked";
            this.LibChecked.Size = new System.Drawing.Size(370, 191);
            this.LibChecked.TabIndex = 3;
            // 
            // LibFolderButton
            // 
            this.LibFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LibFolderButton.BackgroundImage")));
            this.LibFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LibFolderButton.Location = new System.Drawing.Point(27, 254);
            this.LibFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.LibFolderButton.Name = "LibFolderButton";
            this.LibFolderButton.Size = new System.Drawing.Size(370, 70);
            this.LibFolderButton.TabIndex = 2;
            this.LibFolderButton.UseVisualStyleBackColor = true;
            this.LibFolderButton.Click += new System.EventHandler(this.LibFolderButton_Click);
            // 
            // UtilFolderButton
            // 
            this.UtilFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UtilFolderButton.BackgroundImage")));
            this.UtilFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UtilFolderButton.Location = new System.Drawing.Point(27, 176);
            this.UtilFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.UtilFolderButton.Name = "UtilFolderButton";
            this.UtilFolderButton.Size = new System.Drawing.Size(370, 70);
            this.UtilFolderButton.TabIndex = 1;
            this.UtilFolderButton.UseVisualStyleBackColor = true;
            this.UtilFolderButton.Click += new System.EventHandler(this.UtilFolderButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(24, 180);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 567);
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
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 124);
            this.panel2.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.StatusLine);
            this.panel11.Location = new System.Drawing.Point(553, 15);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(719, 54);
            this.panel11.TabIndex = 3;
            // 
            // StatusLine
            // 
            this.StatusLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLine.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatusLine.Location = new System.Drawing.Point(0, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(719, 54);
            this.StatusLine.TabIndex = 6;
            this.StatusLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(424, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 94);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(553, 75);
            this.progressBar1.Maximum = 103;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(719, 35);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // LuaCompileButton
            // 
            this.LuaCompileButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuaCompileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaCompileButton.BackgroundImage")));
            this.LuaCompileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaCompileButton.Location = new System.Drawing.Point(27, 16);
            this.LuaCompileButton.Margin = new System.Windows.Forms.Padding(4);
            this.LuaCompileButton.Name = "LuaCompileButton";
            this.LuaCompileButton.Size = new System.Drawing.Size(110, 94);
            this.LuaCompileButton.TabIndex = 3;
            this.LuaCompileButton.UseVisualStyleBackColor = false;
            this.LuaCompileButton.Click += new System.EventHandler(this.LuaCompileButton_Click);
            // 
            // LuaRunButton
            // 
            this.LuaRunButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuaRunButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuaRunButton.BackgroundImage")));
            this.LuaRunButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuaRunButton.Location = new System.Drawing.Point(294, 16);
            this.LuaRunButton.Margin = new System.Windows.Forms.Padding(4);
            this.LuaRunButton.Name = "LuaRunButton";
            this.LuaRunButton.Size = new System.Drawing.Size(103, 94);
            this.LuaRunButton.TabIndex = 2;
            this.LuaRunButton.UseVisualStyleBackColor = false;
            this.LuaRunButton.Click += new System.EventHandler(this.LuaRunButton_Click);
            // 
            // LuacLoadButton
            // 
            this.LuacLoadButton.BackColor = System.Drawing.SystemColors.Control;
            this.LuacLoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LuacLoadButton.BackgroundImage")));
            this.LuacLoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LuacLoadButton.Location = new System.Drawing.Point(166, 16);
            this.LuacLoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LuacLoadButton.Name = "LuacLoadButton";
            this.LuacLoadButton.Size = new System.Drawing.Size(100, 94);
            this.LuacLoadButton.TabIndex = 1;
            this.LuacLoadButton.UseVisualStyleBackColor = false;
            this.LuacLoadButton.Click += new System.EventHandler(this.LuacLoadButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(24, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 127);
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
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1361, 784);
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
            this.panel26.Location = new System.Drawing.Point(531, 0);
            this.panel26.Margin = new System.Windows.Forms.Padding(4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(418, 124);
            this.panel26.TabIndex = 44;
            // 
            // btnOnlineTelemetry
            // 
            this.btnOnlineTelemetry.BackColor = System.Drawing.SystemColors.Control;
            this.btnOnlineTelemetry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnlineTelemetry.BackgroundImage")));
            this.btnOnlineTelemetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOnlineTelemetry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOnlineTelemetry.Location = new System.Drawing.Point(20, 16);
            this.btnOnlineTelemetry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnlineTelemetry.Name = "btnOnlineTelemetry";
            this.btnOnlineTelemetry.Size = new System.Drawing.Size(109, 94);
            this.btnOnlineTelemetry.TabIndex = 48;
            this.btnOnlineTelemetry.UseVisualStyleBackColor = false;
            this.btnOnlineTelemetry.Click += new System.EventHandler(this.btnOnlineTelemetry_Click);
            // 
            // btnOfflineTelemetry
            // 
            this.btnOfflineTelemetry.BackColor = System.Drawing.SystemColors.Control;
            this.btnOfflineTelemetry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOfflineTelemetry.BackgroundImage")));
            this.btnOfflineTelemetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOfflineTelemetry.Location = new System.Drawing.Point(147, 16);
            this.btnOfflineTelemetry.Margin = new System.Windows.Forms.Padding(4);
            this.btnOfflineTelemetry.Name = "btnOfflineTelemetry";
            this.btnOfflineTelemetry.Size = new System.Drawing.Size(110, 94);
            this.btnOfflineTelemetry.TabIndex = 5;
            this.btnOfflineTelemetry.UseVisualStyleBackColor = false;
            this.btnOfflineTelemetry.Click += new System.EventHandler(this.btnOfflineTelemetry_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveLog.BackgroundImage")));
            this.btnSaveLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveLog.Location = new System.Drawing.Point(276, 16);
            this.btnSaveLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(110, 94);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 142);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1314, 619);
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
            this.panel24.Location = new System.Drawing.Point(661, 466);
            this.panel24.Margin = new System.Windows.Forms.Padding(4);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(649, 137);
            this.panel24.TabIndex = 56;
            // 
            // Chart8Window
            // 
            this.Chart8Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart8Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart8Window.Location = new System.Drawing.Point(21, 33);
            this.Chart8Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart8Window.Name = "Chart8Window";
            this.Chart8Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart8_1Select.Location = new System.Drawing.Point(390, 33);
            this.Chart8_1Select.Name = "Chart8_1Select";
            this.Chart8_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart8_1Select.TabIndex = 42;
            this.Chart8_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart8_1Select_SelectedIndexChanged);
            // 
            // Chart8_2Select
            // 
            this.Chart8_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart8_2Select.FormattingEnabled = true;
            this.Chart8_2Select.Location = new System.Drawing.Point(390, 81);
            this.Chart8_2Select.Name = "Chart8_2Select";
            this.Chart8_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel23.Location = new System.Drawing.Point(4, 466);
            this.panel23.Margin = new System.Windows.Forms.Padding(4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(649, 137);
            this.panel23.TabIndex = 55;
            // 
            // Chart7Window
            // 
            this.Chart7Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart7Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart7Window.Location = new System.Drawing.Point(21, 33);
            this.Chart7Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart7Window.Name = "Chart7Window";
            this.Chart7Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart7_1Select.Location = new System.Drawing.Point(409, 33);
            this.Chart7_1Select.Name = "Chart7_1Select";
            this.Chart7_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart7_1Select.TabIndex = 42;
            this.Chart7_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart7_1Select_SelectedIndexChanged);
            // 
            // Chart7_2Select
            // 
            this.Chart7_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart7_2Select.FormattingEnabled = true;
            this.Chart7_2Select.Location = new System.Drawing.Point(409, 81);
            this.Chart7_2Select.Name = "Chart7_2Select";
            this.Chart7_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel22.Location = new System.Drawing.Point(661, 312);
            this.panel22.Margin = new System.Windows.Forms.Padding(4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(649, 137);
            this.panel22.TabIndex = 54;
            // 
            // Chart6Window
            // 
            this.Chart6Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart6Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart6Window.Location = new System.Drawing.Point(21, 33);
            this.Chart6Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart6Window.Name = "Chart6Window";
            this.Chart6Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart6_1Select.Location = new System.Drawing.Point(390, 33);
            this.Chart6_1Select.Name = "Chart6_1Select";
            this.Chart6_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart6_1Select.TabIndex = 42;
            this.Chart6_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart6_1Select_SelectedIndexChanged);
            // 
            // Chart6_2Select
            // 
            this.Chart6_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart6_2Select.FormattingEnabled = true;
            this.Chart6_2Select.Location = new System.Drawing.Point(390, 81);
            this.Chart6_2Select.Name = "Chart6_2Select";
            this.Chart6_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel21.Location = new System.Drawing.Point(4, 312);
            this.panel21.Margin = new System.Windows.Forms.Padding(4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(649, 137);
            this.panel21.TabIndex = 53;
            // 
            // buttChart5Window
            // 
            this.buttChart5Window.BackColor = System.Drawing.SystemColors.Control;
            this.buttChart5Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttChart5Window.Location = new System.Drawing.Point(21, 33);
            this.buttChart5Window.Margin = new System.Windows.Forms.Padding(4);
            this.buttChart5Window.Name = "buttChart5Window";
            this.buttChart5Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart5_1Select.Location = new System.Drawing.Point(409, 33);
            this.Chart5_1Select.Name = "Chart5_1Select";
            this.Chart5_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart5_1Select.TabIndex = 42;
            this.Chart5_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart5_1Select_SelectedIndexChanged);
            // 
            // Chart5_2Select
            // 
            this.Chart5_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart5_2Select.FormattingEnabled = true;
            this.Chart5_2Select.Location = new System.Drawing.Point(409, 81);
            this.Chart5_2Select.Name = "Chart5_2Select";
            this.Chart5_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel20.Location = new System.Drawing.Point(661, 158);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(649, 137);
            this.panel20.TabIndex = 52;
            // 
            // Chart4Window
            // 
            this.Chart4Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart4Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart4Window.Location = new System.Drawing.Point(21, 33);
            this.Chart4Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart4Window.Name = "Chart4Window";
            this.Chart4Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart4_1Select.Location = new System.Drawing.Point(390, 33);
            this.Chart4_1Select.Name = "Chart4_1Select";
            this.Chart4_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart4_1Select.TabIndex = 42;
            this.Chart4_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart4_1Select_SelectedIndexChanged);
            // 
            // Chart4_2Select
            // 
            this.Chart4_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart4_2Select.FormattingEnabled = true;
            this.Chart4_2Select.Location = new System.Drawing.Point(390, 81);
            this.Chart4_2Select.Name = "Chart4_2Select";
            this.Chart4_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel19.Location = new System.Drawing.Point(4, 158);
            this.panel19.Margin = new System.Windows.Forms.Padding(4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(649, 137);
            this.panel19.TabIndex = 51;
            // 
            // Chart3Window
            // 
            this.Chart3Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart3Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart3Window.Location = new System.Drawing.Point(21, 33);
            this.Chart3Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart3Window.Name = "Chart3Window";
            this.Chart3Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart3_1Select.Location = new System.Drawing.Point(409, 33);
            this.Chart3_1Select.Name = "Chart3_1Select";
            this.Chart3_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart3_1Select.TabIndex = 42;
            this.Chart3_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart3_1Select_SelectedIndexChanged);
            // 
            // Chart3_2Select
            // 
            this.Chart3_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart3_2Select.FormattingEnabled = true;
            this.Chart3_2Select.Location = new System.Drawing.Point(409, 81);
            this.Chart3_2Select.Name = "Chart3_2Select";
            this.Chart3_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel14.Location = new System.Drawing.Point(661, 4);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(649, 146);
            this.panel14.TabIndex = 49;
            // 
            // Chart2Window
            // 
            this.Chart2Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart2Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Chart2Window.Location = new System.Drawing.Point(21, 33);
            this.Chart2Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart2Window.Name = "Chart2Window";
            this.Chart2Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart2_1Select.Location = new System.Drawing.Point(390, 33);
            this.Chart2_1Select.Name = "Chart2_1Select";
            this.Chart2_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart2_1Select.TabIndex = 42;
            this.Chart2_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart2_1Select_SelectedIndexChanged);
            // 
            // Chart2_2Select
            // 
            this.Chart2_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart2_2Select.FormattingEnabled = true;
            this.Chart2_2Select.Location = new System.Drawing.Point(390, 81);
            this.Chart2_2Select.Name = "Chart2_2Select";
            this.Chart2_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel15.Location = new System.Drawing.Point(4, 4);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(649, 146);
            this.panel15.TabIndex = 50;
            // 
            // Chart1Window
            // 
            this.Chart1Window.BackColor = System.Drawing.SystemColors.Control;
            this.Chart1Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chart1Window.Location = new System.Drawing.Point(21, 33);
            this.Chart1Window.Margin = new System.Windows.Forms.Padding(4);
            this.Chart1Window.Name = "Chart1Window";
            this.Chart1Window.Size = new System.Drawing.Size(202, 72);
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
            this.Chart1_1Select.Location = new System.Drawing.Point(409, 33);
            this.Chart1_1Select.Name = "Chart1_1Select";
            this.Chart1_1Select.Size = new System.Drawing.Size(161, 24);
            this.Chart1_1Select.TabIndex = 42;
            this.Chart1_1Select.SelectedIndexChanged += new System.EventHandler(this.Chart1_1Select_SelectedIndexChanged);
            // 
            // Chart1_2Select
            // 
            this.Chart1_2Select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart1_2Select.FormattingEnabled = true;
            this.Chart1_2Select.Location = new System.Drawing.Point(409, 81);
            this.Chart1_2Select.Name = "Chart1_2Select";
            this.Chart1_2Select.Size = new System.Drawing.Size(161, 24);
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
            this.panel16.Location = new System.Drawing.Point(41, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(467, 124);
            this.panel16.TabIndex = 33;
            // 
            // btnTelemetryStop1
            // 
            this.btnTelemetryStop1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryStop1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryStop1.BackgroundImage")));
            this.btnTelemetryStop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryStop1.Location = new System.Drawing.Point(116, 16);
            this.btnTelemetryStop1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryStop1.Name = "btnTelemetryStop1";
            this.btnTelemetryStop1.Size = new System.Drawing.Size(103, 94);
            this.btnTelemetryStop1.TabIndex = 4;
            this.btnTelemetryStop1.UseVisualStyleBackColor = false;
            this.btnTelemetryStop1.Click += new System.EventHandler(this.btnTelemetryStop_Click);
            // 
            // btnTelemetryRecord1
            // 
            this.btnTelemetryRecord1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRecord1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRecord1.BackgroundImage")));
            this.btnTelemetryRecord1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRecord1.Location = new System.Drawing.Point(338, 16);
            this.btnTelemetryRecord1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryRecord1.Name = "btnTelemetryRecord1";
            this.btnTelemetryRecord1.Size = new System.Drawing.Size(110, 94);
            this.btnTelemetryRecord1.TabIndex = 3;
            this.btnTelemetryRecord1.UseVisualStyleBackColor = false;
            this.btnTelemetryRecord1.Click += new System.EventHandler(this.btnTelemetryRecord_Click);
            // 
            // btnTelemetryPause1
            // 
            this.btnTelemetryPause1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryPause1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryPause1.BackgroundImage")));
            this.btnTelemetryPause1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryPause1.Location = new System.Drawing.Point(227, 16);
            this.btnTelemetryPause1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryPause1.Name = "btnTelemetryPause1";
            this.btnTelemetryPause1.Size = new System.Drawing.Size(103, 94);
            this.btnTelemetryPause1.TabIndex = 2;
            this.btnTelemetryPause1.UseVisualStyleBackColor = false;
            this.btnTelemetryPause1.Click += new System.EventHandler(this.btnTelemetryPause_Click);
            // 
            // btnTelemetryRun1
            // 
            this.btnTelemetryRun1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTelemetryRun1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelemetryRun1.BackgroundImage")));
            this.btnTelemetryRun1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTelemetryRun1.Location = new System.Drawing.Point(8, 16);
            this.btnTelemetryRun1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTelemetryRun1.Name = "btnTelemetryRun1";
            this.btnTelemetryRun1.Size = new System.Drawing.Size(100, 94);
            this.btnTelemetryRun1.TabIndex = 1;
            this.btnTelemetryRun1.UseVisualStyleBackColor = false;
            this.btnTelemetryRun1.Click += new System.EventHandler(this.btnTelemetryRun_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel18.Location = new System.Drawing.Point(41, 8);
            this.panel18.Margin = new System.Windows.Forms.Padding(4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(478, 127);
            this.panel18.TabIndex = 32;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel25.Location = new System.Drawing.Point(527, 5);
            this.panel25.Margin = new System.Windows.Forms.Padding(4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(439, 130);
            this.panel25.TabIndex = 47;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\i.dymov\\Documents\\WindowsFormsApp1\\WindowsFormsApp1\\PDM Help File.chm";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Location = new System.Drawing.Point(12, 8);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(155, 78);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1586, 793);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel17);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
    }
}

