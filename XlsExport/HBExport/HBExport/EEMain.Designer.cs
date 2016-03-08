namespace XBExport
{
    partial class EEMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EEMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.timer_Task = new System.Windows.Forms.Timer(this.components);
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorkerReport = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBarReport = new System.Windows.Forms.ProgressBar();
            this.lstBoxReport = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnSaveCfg = new System.Windows.Forms.Button();
            this.btnPathSelect = new System.Windows.Forms.Button();
            this.txtSaveDocPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearLstBox = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblShowMsg = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTimerInterval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.MyContextMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_exit,
            this.ToolStripMenuItem_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Image = global::XBExport.Properties.Resources.RCAUserManager_exe_4__1;
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_exit.Text = "退出";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // ToolStripMenuItem_about
            // 
            this.ToolStripMenuItem_about.Image = global::XBExport.Properties.Resources.UserManager_exe_50__1;
            this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
            this.ToolStripMenuItem_about.Size = new System.Drawing.Size(60, 21);
            this.ToolStripMenuItem_about.Text = "关于";
            this.ToolStripMenuItem_about.Click += new System.EventHandler(this.ToolStripMenuItem_about_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // timer_Task
            // 
            this.timer_Task.Tick += new System.EventHandler(this.timer_Task_Tick);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MyNotifyIcon.BalloonTipText = "西北分公司报表导出工具V1.0";
            this.MyNotifyIcon.ContextMenuStrip = this.MyContextMenu;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Tag = "";
            this.MyNotifyIcon.Text = "西北分公司报表导出工具V1.0";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyNotifyIcon_MouseDoubleClick);
            // 
            // MyContextMenu
            // 
            this.MyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Show,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Quit});
            this.MyContextMenu.Name = "MyContextMenu";
            this.MyContextMenu.Size = new System.Drawing.Size(161, 78);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox1.HideSelection = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 16);
            this.toolStripTextBox1.Text = "报表导出工具";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem_Show
            // 
            this.toolStripMenuItem_Show.Name = "toolStripMenuItem_Show";
            this.toolStripMenuItem_Show.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem_Show.Text = "显示主界面";
            this.toolStripMenuItem_Show.Click += new System.EventHandler(this.toolStripMenuItem_Show_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem_Quit
            // 
            this.toolStripMenuItem_Quit.Name = "toolStripMenuItem_Quit";
            this.toolStripMenuItem_Quit.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem_Quit.Text = "退出";
            this.toolStripMenuItem_Quit.Click += new System.EventHandler(this.toolStripMenuItem_Quit_Click);
            // 
            // bgWorkerReport
            // 
            this.bgWorkerReport.WorkerReportsProgress = true;
            this.bgWorkerReport.WorkerSupportsCancellation = true;
            this.bgWorkerReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerReport_DoWork);
            this.bgWorkerReport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerReport_ProgressChanged);
            this.bgWorkerReport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerReport_RunWorkerCompleted);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBarReport);
            this.tabPage1.Controls.Add(this.lstBoxReport);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "参数设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBarReport
            // 
            this.progressBarReport.Location = new System.Drawing.Point(14, 315);
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(365, 14);
            this.progressBarReport.TabIndex = 40;
            // 
            // lstBoxReport
            // 
            this.lstBoxReport.FormattingEnabled = true;
            this.lstBoxReport.ItemHeight = 12;
            this.lstBoxReport.Location = new System.Drawing.Point(14, 175);
            this.lstBoxReport.Name = "lstBoxReport";
            this.lstBoxReport.Size = new System.Drawing.Size(365, 136);
            this.lstBoxReport.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenDirectory);
            this.groupBox3.Controls.Add(this.btnSaveCfg);
            this.groupBox3.Controls.Add(this.btnPathSelect);
            this.groupBox3.Controls.Add(this.txtSaveDocPath);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnClearLstBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblShowMsg);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.txtTimerInterval);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(14, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 150);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(234, 107);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(43, 26);
            this.btnOpenDirectory.TabIndex = 53;
            this.btnOpenDirectory.Text = "打开";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click_1);
            // 
            // btnSaveCfg
            // 
            this.btnSaveCfg.Location = new System.Drawing.Point(281, 107);
            this.btnSaveCfg.Name = "btnSaveCfg";
            this.btnSaveCfg.Size = new System.Drawing.Size(69, 26);
            this.btnSaveCfg.TabIndex = 52;
            this.btnSaveCfg.Text = "保存设置";
            this.btnSaveCfg.UseVisualStyleBackColor = true;
            this.btnSaveCfg.Click += new System.EventHandler(this.btnSaveCfg_Click_1);
            // 
            // btnPathSelect
            // 
            this.btnPathSelect.Location = new System.Drawing.Point(197, 107);
            this.btnPathSelect.Name = "btnPathSelect";
            this.btnPathSelect.Size = new System.Drawing.Size(31, 26);
            this.btnPathSelect.TabIndex = 51;
            this.btnPathSelect.Text = "...";
            this.btnPathSelect.UseVisualStyleBackColor = true;
            this.btnPathSelect.Click += new System.EventHandler(this.btnPathSelect_Click_1);
            // 
            // txtSaveDocPath
            // 
            this.txtSaveDocPath.Location = new System.Drawing.Point(70, 110);
            this.txtSaveDocPath.Name = "txtSaveDocPath";
            this.txtSaveDocPath.Size = new System.Drawing.Size(121, 21);
            this.txtSaveDocPath.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "导出路径：";
            // 
            // btnClearLstBox
            // 
            this.btnClearLstBox.Location = new System.Drawing.Point(258, 20);
            this.btnClearLstBox.Name = "btnClearLstBox";
            this.btnClearLstBox.Size = new System.Drawing.Size(92, 27);
            this.btnClearLstBox.TabIndex = 38;
            this.btnClearLstBox.Text = "清空显示记录";
            this.btnClearLstBox.UseVisualStyleBackColor = true;
            this.btnClearLstBox.Click += new System.EventHandler(this.btnClearLstBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "(毫秒)";
            // 
            // lblShowMsg
            // 
            this.lblShowMsg.AutoSize = true;
            this.lblShowMsg.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblShowMsg.Location = new System.Drawing.Point(67, 27);
            this.lblShowMsg.Name = "lblShowMsg";
            this.lblShowMsg.Size = new System.Drawing.Size(0, 12);
            this.lblShowMsg.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 27);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::XBExport.Properties.Resources.UserManager_exe_32__1;
            this.btnStart.Location = new System.Drawing.Point(18, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(43, 27);
            this.btnStart.TabIndex = 23;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::XBExport.Properties.Resources.UserManager_exe_33__1;
            this.btnStop.Location = new System.Drawing.Point(18, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 27);
            this.btnStop.TabIndex = 24;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.Location = new System.Drawing.Point(104, 63);
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(124, 21);
            this.txtTimerInterval.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "定时器扫描间隔";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 373);
            this.tabControl1.TabIndex = 7;
            // 
            // EEMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 398);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EEMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华北报表导出服务V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.EEMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MyContextMenu.ResumeLayout(false);
            this.MyContextMenu.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Timer timer_Task;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip MyContextMenu;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Quit;
        private System.ComponentModel.BackgroundWorker bgWorkerReport;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ProgressBar progressBarReport;
        private System.Windows.Forms.ListBox lstBoxReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearLstBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblShowMsg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtTimerInterval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnSaveCfg;
        private System.Windows.Forms.Button btnPathSelect;
        private System.Windows.Forms.TextBox txtSaveDocPath;
        private System.Windows.Forms.Label label1;
    }
}