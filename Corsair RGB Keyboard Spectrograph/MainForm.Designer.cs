﻿namespace RGBKeyboardSpectrograph
{
    partial class MainForm
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
        /* Copy these into InitializeComponent every time the designer nukes it
        UpdateStatusMessage.NewMsg += UpdateStatusMessage_NewMsg;
        UpdateWorkerThread.NewAct += UpdateWorker_NewAct;
        */
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpdateStatusMessage.NewMsg += UpdateStatusMessage_NewMsg;
            UpdateWorkerThread.NewAct += UpdateWorker_NewAct;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartSpectrographButton = new System.Windows.Forms.Button();
            this.StopSpectrographButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLight = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.KeyboardModelComboBox = new System.Windows.Forms.ComboBox();
            this.KeyboardLayoutComboBox = new System.Windows.Forms.ComboBox();
            this.AmplitudeUD = new System.Windows.Forms.NumericUpDown();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblRainbowBrightness = new System.Windows.Forms.Label();
            this.BackgroundBrightnessUD = new System.Windows.Forms.NumericUpDown();
            this.TestModeButton = new System.Windows.Forms.Button();
            this.TesterUD = new System.Windows.Forms.NumericUpDown();
            this.StatusLog = new System.Windows.Forms.RichTextBox();
            this.LogLevelUD = new System.Windows.Forms.NumericUpDown();
            this.LogLevelLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeToTrayCheck = new System.Windows.Forms.CheckBox();
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.RefreshDelayLabel = new System.Windows.Forms.Label();
            this.RefreshDelayUD = new System.Windows.Forms.NumericUpDown();
            this.LaunchCueCheck = new System.Windows.Forms.CheckBox();
            this.colorBars = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBrightnessUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TesterUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogLevelUD)).BeginInit();
            this.RightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDelayUD)).BeginInit();
            this.SuspendLayout();
            // 
            // StartSpectrographButton
            // 
            this.StartSpectrographButton.Location = new System.Drawing.Point(12, 279);
            this.StartSpectrographButton.Name = "StartSpectrographButton";
            this.StartSpectrographButton.Size = new System.Drawing.Size(87, 23);
            this.StartSpectrographButton.TabIndex = 0;
            this.StartSpectrographButton.Text = "Start";
            this.StartSpectrographButton.UseVisualStyleBackColor = true;
            this.StartSpectrographButton.Click += new System.EventHandler(this.StartSpectrograph_Click);
            // 
            // StopSpectrographButton
            // 
            this.StopSpectrographButton.Location = new System.Drawing.Point(198, 279);
            this.StopSpectrographButton.Name = "StopSpectrographButton";
            this.StopSpectrographButton.Size = new System.Drawing.Size(87, 23);
            this.StopSpectrographButton.TabIndex = 1;
            this.StopSpectrographButton.Text = "Stop";
            this.StopSpectrographButton.UseVisualStyleBackColor = true;
            this.StopSpectrographButton.Click += new System.EventHandler(this.StopSpectrograph_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLight,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLight
            // 
            this.StatusLight.Name = "StatusLight";
            this.StatusLight.Size = new System.Drawing.Size(16, 17);
            this.StatusLight.Text = "   ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 17);
            this.StatusLabel.Text = "StatusLabel";
            // 
            // KeyboardModelComboBox
            // 
            this.KeyboardModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyboardModelComboBox.FormattingEnabled = true;
            this.KeyboardModelComboBox.Location = new System.Drawing.Point(12, 12);
            this.KeyboardModelComboBox.Name = "KeyboardModelComboBox";
            this.KeyboardModelComboBox.Size = new System.Drawing.Size(119, 21);
            this.KeyboardModelComboBox.TabIndex = 4;
            this.KeyboardModelComboBox.SelectedIndexChanged += new System.EventHandler(this.KeyboardModelComboBox_SelectedIndexChanged);
            // 
            // KeyboardLayoutComboBox
            // 
            this.KeyboardLayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyboardLayoutComboBox.FormattingEnabled = true;
            this.KeyboardLayoutComboBox.Location = new System.Drawing.Point(155, 12);
            this.KeyboardLayoutComboBox.Name = "KeyboardLayoutComboBox";
            this.KeyboardLayoutComboBox.Size = new System.Drawing.Size(119, 21);
            this.KeyboardLayoutComboBox.TabIndex = 6;
            this.KeyboardLayoutComboBox.SelectedIndexChanged += new System.EventHandler(this.KeyboardLayoutComboBox_SelectedIndexChanged);
            // 
            // AmplitudeUD
            // 
            this.AmplitudeUD.Location = new System.Drawing.Point(227, 57);
            this.AmplitudeUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmplitudeUD.Name = "AmplitudeUD";
            this.AmplitudeUD.Size = new System.Drawing.Size(47, 20);
            this.AmplitudeUD.TabIndex = 8;
            this.AmplitudeUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmplitudeUD.ValueChanged += new System.EventHandler(this.AmplitudeUD_ValueChanged);
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(164, 59);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(57, 13);
            this.lblAmplitude.TabIndex = 9;
            this.lblAmplitude.Text = "Sensitivity:";
            // 
            // lblRainbowBrightness
            // 
            this.lblRainbowBrightness.AutoSize = true;
            this.lblRainbowBrightness.Location = new System.Drawing.Point(101, 85);
            this.lblRainbowBrightness.Name = "lblRainbowBrightness";
            this.lblRainbowBrightness.Size = new System.Drawing.Size(120, 13);
            this.lblRainbowBrightness.TabIndex = 19;
            this.lblRainbowBrightness.Text = "Background Brightness:";
            // 
            // BackgroundBrightnessUD
            // 
            this.BackgroundBrightnessUD.Location = new System.Drawing.Point(227, 83);
            this.BackgroundBrightnessUD.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.BackgroundBrightnessUD.Name = "BackgroundBrightnessUD";
            this.BackgroundBrightnessUD.Size = new System.Drawing.Size(47, 20);
            this.BackgroundBrightnessUD.TabIndex = 18;
            this.BackgroundBrightnessUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.BackgroundBrightnessUD.ValueChanged += new System.EventHandler(this.BackgroundBrightnessUD_ValueChanged);
            // 
            // TestModeButton
            // 
            this.TestModeButton.Location = new System.Drawing.Point(291, 279);
            this.TestModeButton.Name = "TestModeButton";
            this.TestModeButton.Size = new System.Drawing.Size(87, 23);
            this.TestModeButton.TabIndex = 20;
            this.TestModeButton.Text = "Test Mode";
            this.TestModeButton.UseVisualStyleBackColor = true;
            this.TestModeButton.Click += new System.EventHandler(this.TestModeButton_Click);
            // 
            // TesterUD
            // 
            this.TesterUD.Location = new System.Drawing.Point(384, 282);
            this.TesterUD.Maximum = new decimal(new int[] {
            143,
            0,
            0,
            0});
            this.TesterUD.Name = "TesterUD";
            this.TesterUD.Size = new System.Drawing.Size(47, 20);
            this.TesterUD.TabIndex = 21;
            this.TesterUD.ValueChanged += new System.EventHandler(this.TesterUD_ValueChanged);
            // 
            // StatusLog
            // 
            this.StatusLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLog.HideSelection = false;
            this.StatusLog.Location = new System.Drawing.Point(291, 12);
            this.StatusLog.Name = "StatusLog";
            this.StatusLog.Size = new System.Drawing.Size(356, 261);
            this.StatusLog.TabIndex = 22;
            this.StatusLog.Text = "";
            // 
            // LogLevelUD
            // 
            this.LogLevelUD.Location = new System.Drawing.Point(517, 282);
            this.LogLevelUD.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.LogLevelUD.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LogLevelUD.Name = "LogLevelUD";
            this.LogLevelUD.Size = new System.Drawing.Size(47, 20);
            this.LogLevelUD.TabIndex = 23;
            this.LogLevelUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LogLevelUD.ValueChanged += new System.EventHandler(this.VerbosityUD_ValueChanged);
            // 
            // LogLevelLabel
            // 
            this.LogLevelLabel.AutoSize = true;
            this.LogLevelLabel.Location = new System.Drawing.Point(454, 284);
            this.LogLevelLabel.Name = "LogLevelLabel";
            this.LogLevelLabel.Size = new System.Drawing.Size(57, 13);
            this.LogLevelLabel.TabIndex = 24;
            this.LogLevelLabel.Text = "Log Level:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Double-click to restore.";
            this.notifyIcon.BalloonTipTitle = "Keyboard Spectrograph";
            this.notifyIcon.ContextMenuStrip = this.RightClickMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Keyboard Spectrograph";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout,
            this.toolStripSeparator1,
            this.tsmStart,
            this.tsmStop,
            this.toolStripSeparator2,
            this.tsmQuit});
            this.RightClickMenu.Name = "contextMenuStrip1";
            this.RightClickMenu.ShowCheckMargin = true;
            this.RightClickMenu.ShowImageMargin = false;
            this.RightClickMenu.Size = new System.Drawing.Size(171, 104);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Enabled = false;
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(170, 22);
            this.tsmAbout.Text = "RGB Spectrograph";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.Size = new System.Drawing.Size(170, 22);
            this.tsmStart.Text = "Start";
            this.tsmStart.Click += new System.EventHandler(this.StartSpectrograph_Click);
            // 
            // tsmStop
            // 
            this.tsmStop.Name = "tsmStop";
            this.tsmStop.Size = new System.Drawing.Size(170, 22);
            this.tsmStop.Text = "Stop";
            this.tsmStop.Click += new System.EventHandler(this.StopSpectrograph_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(170, 22);
            this.tsmQuit.Text = "Quit";
            this.tsmQuit.Click += new System.EventHandler(this.tsmQuit_Click);
            // 
            // MinimizeToTrayCheck
            // 
            this.MinimizeToTrayCheck.AutoSize = true;
            this.MinimizeToTrayCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeToTrayCheck.Location = new System.Drawing.Point(146, 256);
            this.MinimizeToTrayCheck.Name = "MinimizeToTrayCheck";
            this.MinimizeToTrayCheck.Size = new System.Drawing.Size(139, 17);
            this.MinimizeToTrayCheck.TabIndex = 25;
            this.MinimizeToTrayCheck.Text = "Minimize to System Tray";
            this.MinimizeToTrayCheck.UseVisualStyleBackColor = true;
            // 
            // StatusTimer
            // 
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // RefreshDelayLabel
            // 
            this.RefreshDelayLabel.AutoSize = true;
            this.RefreshDelayLabel.Location = new System.Drawing.Point(1, 61);
            this.RefreshDelayLabel.Name = "RefreshDelayLabel";
            this.RefreshDelayLabel.Size = new System.Drawing.Size(77, 13);
            this.RefreshDelayLabel.TabIndex = 27;
            this.RefreshDelayLabel.Text = "Refresh Delay:";
            // 
            // RefreshDelayUD
            // 
            this.RefreshDelayUD.Location = new System.Drawing.Point(84, 59);
            this.RefreshDelayUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RefreshDelayUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RefreshDelayUD.Name = "RefreshDelayUD";
            this.RefreshDelayUD.Size = new System.Drawing.Size(47, 20);
            this.RefreshDelayUD.TabIndex = 26;
            this.RefreshDelayUD.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RefreshDelayUD.ValueChanged += new System.EventHandler(this.RefreshDelayUD_ValueChanged);
            // 
            // LaunchCueCheck
            // 
            this.LaunchCueCheck.AutoSize = true;
            this.LaunchCueCheck.Location = new System.Drawing.Point(12, 256);
            this.LaunchCueCheck.Name = "LaunchCueCheck";
            this.LaunchCueCheck.Size = new System.Drawing.Size(122, 17);
            this.LaunchCueCheck.TabIndex = 28;
            this.LaunchCueCheck.Text = "Launch CUE on Exit";
            this.LaunchCueCheck.UseVisualStyleBackColor = true;
            // 
            // colorBars
            // 
            this.colorBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBars.Location = new System.Drawing.Point(210, 128);
            this.colorBars.Name = "colorBars";
            this.colorBars.Size = new System.Drawing.Size(75, 23);
            this.colorBars.TabIndex = 29;
            this.colorBars.Text = "Bars";
            this.colorBars.UseVisualStyleBackColor = true;
            this.colorBars.Click += new System.EventHandler(this.colorBars_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 334);
            this.Controls.Add(this.colorBars);
            this.Controls.Add(this.LaunchCueCheck);
            this.Controls.Add(this.RefreshDelayLabel);
            this.Controls.Add(this.RefreshDelayUD);
            this.Controls.Add(this.MinimizeToTrayCheck);
            this.Controls.Add(this.LogLevelLabel);
            this.Controls.Add(this.LogLevelUD);
            this.Controls.Add(this.StatusLog);
            this.Controls.Add(this.TesterUD);
            this.Controls.Add(this.TestModeButton);
            this.Controls.Add(this.lblRainbowBrightness);
            this.Controls.Add(this.BackgroundBrightnessUD);
            this.Controls.Add(this.lblAmplitude);
            this.Controls.Add(this.AmplitudeUD);
            this.Controls.Add(this.KeyboardLayoutComboBox);
            this.Controls.Add(this.KeyboardModelComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StopSpectrographButton);
            this.Controls.Add(this.StartSpectrographButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Corsair RGB Keyboard Spectrograph";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBrightnessUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TesterUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogLevelUD)).EndInit();
            this.RightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDelayUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartSpectrographButton;
        private System.Windows.Forms.Button StopSpectrographButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ComboBox KeyboardModelComboBox;
        private System.Windows.Forms.ComboBox KeyboardLayoutComboBox;
        private System.Windows.Forms.NumericUpDown AmplitudeUD;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblRainbowBrightness;
        private System.Windows.Forms.NumericUpDown BackgroundBrightnessUD;
        private System.Windows.Forms.Button TestModeButton;
        private System.Windows.Forms.NumericUpDown TesterUD;
        private System.Windows.Forms.RichTextBox StatusLog;
        private System.Windows.Forms.NumericUpDown LogLevelUD;
        private System.Windows.Forms.Label LogLevelLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox MinimizeToTrayCheck;
        private System.Windows.Forms.ToolStripStatusLabel StatusLight;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.Label RefreshDelayLabel;
        private System.Windows.Forms.NumericUpDown RefreshDelayUD;
        private System.Windows.Forms.ContextMenuStrip RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.CheckBox LaunchCueCheck;
        private System.Windows.Forms.Button colorBars;

    }
}
