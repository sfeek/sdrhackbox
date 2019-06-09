namespace SDRHackBox
{
    partial class SDRHackBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDRHackBox));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMemories = new System.Windows.Forms.TextBox();
            this.txtStepFreq = new System.Windows.Forms.TextBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.btnMemoryScan = new System.Windows.Forms.Button();
            this.grpBoxMemoryScan = new System.Windows.Forms.GroupBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.grpBoxSweepScan = new System.Windows.Forms.GroupBox();
            this.btnSweepScan = new System.Windows.Forms.Button();
            this.lblStop = new System.Windows.Forms.Label();
            this.txtStopFreq = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStartFreq = new System.Windows.Forms.TextBox();
            this.trkBarDelay = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.chkRandomTiming = new System.Windows.Forms.CheckBox();
            this.grpBoxMemoryScan.SuspendLayout();
            this.grpBoxSweepScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(132, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(160, 62);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect SDR#";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMemories
            // 
            this.txtMemories.Location = new System.Drawing.Point(8, 23);
            this.txtMemories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemories.Multiline = true;
            this.txtMemories.Name = "txtMemories";
            this.txtMemories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemories.Size = new System.Drawing.Size(159, 261);
            this.txtMemories.TabIndex = 0;
            // 
            // txtStepFreq
            // 
            this.txtStepFreq.Location = new System.Drawing.Point(56, 86);
            this.txtStepFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStepFreq.Name = "txtStepFreq";
            this.txtStepFreq.Size = new System.Drawing.Size(59, 22);
            this.txtStepFreq.TabIndex = 2;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(9, 90);
            this.lblStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(37, 17);
            this.lblStep.TabIndex = 5;
            this.lblStep.Text = "Step";
            // 
            // btnMemoryScan
            // 
            this.btnMemoryScan.Location = new System.Drawing.Point(8, 321);
            this.btnMemoryScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMemoryScan.Name = "btnMemoryScan";
            this.btnMemoryScan.Size = new System.Drawing.Size(160, 62);
            this.btnMemoryScan.TabIndex = 1;
            this.btnMemoryScan.Text = "Start Memory Scan";
            this.btnMemoryScan.UseVisualStyleBackColor = true;
            this.btnMemoryScan.Click += new System.EventHandler(this.btnMemoryScan_Click);
            // 
            // grpBoxMemoryScan
            // 
            this.grpBoxMemoryScan.Controls.Add(this.chkRandom);
            this.grpBoxMemoryScan.Controls.Add(this.txtMemories);
            this.grpBoxMemoryScan.Controls.Add(this.btnMemoryScan);
            this.grpBoxMemoryScan.Location = new System.Drawing.Point(16, 84);
            this.grpBoxMemoryScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxMemoryScan.Name = "grpBoxMemoryScan";
            this.grpBoxMemoryScan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxMemoryScan.Size = new System.Drawing.Size(175, 399);
            this.grpBoxMemoryScan.TabIndex = 1;
            this.grpBoxMemoryScan.TabStop = false;
            this.grpBoxMemoryScan.Text = "Memory Scan";
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(8, 293);
            this.chkRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(139, 21);
            this.chkRandom.TabIndex = 2;
            this.chkRandom.TabStop = false;
            this.chkRandom.Text = "Random Channel";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // grpBoxSweepScan
            // 
            this.grpBoxSweepScan.Controls.Add(this.btnSweepScan);
            this.grpBoxSweepScan.Controls.Add(this.lblStop);
            this.grpBoxSweepScan.Controls.Add(this.txtStopFreq);
            this.grpBoxSweepScan.Controls.Add(this.lblStart);
            this.grpBoxSweepScan.Controls.Add(this.txtStartFreq);
            this.grpBoxSweepScan.Controls.Add(this.txtStepFreq);
            this.grpBoxSweepScan.Controls.Add(this.lblStep);
            this.grpBoxSweepScan.Location = new System.Drawing.Point(212, 84);
            this.grpBoxSweepScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxSweepScan.Name = "grpBoxSweepScan";
            this.grpBoxSweepScan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxSweepScan.Size = new System.Drawing.Size(200, 196);
            this.grpBoxSweepScan.TabIndex = 2;
            this.grpBoxSweepScan.TabStop = false;
            this.grpBoxSweepScan.Text = "Sweep Scan";
            // 
            // btnSweepScan
            // 
            this.btnSweepScan.Location = new System.Drawing.Point(13, 118);
            this.btnSweepScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSweepScan.Name = "btnSweepScan";
            this.btnSweepScan.Size = new System.Drawing.Size(160, 62);
            this.btnSweepScan.TabIndex = 3;
            this.btnSweepScan.Text = "Start Sweep Scan";
            this.btnSweepScan.UseVisualStyleBackColor = true;
            this.btnSweepScan.Click += new System.EventHandler(this.btnSweepScan_Click);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(9, 59);
            this.lblStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(37, 17);
            this.lblStop.TabIndex = 9;
            this.lblStop.Text = "Stop";
            // 
            // txtStopFreq
            // 
            this.txtStopFreq.Location = new System.Drawing.Point(56, 55);
            this.txtStopFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStopFreq.Name = "txtStopFreq";
            this.txtStopFreq.Size = new System.Drawing.Size(132, 22);
            this.txtStopFreq.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(9, 27);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(38, 17);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Start";
            // 
            // txtStartFreq
            // 
            this.txtStartFreq.Location = new System.Drawing.Point(56, 23);
            this.txtStartFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartFreq.Name = "txtStartFreq";
            this.txtStartFreq.Size = new System.Drawing.Size(132, 22);
            this.txtStartFreq.TabIndex = 0;
            // 
            // trkBarDelay
            // 
            this.trkBarDelay.Location = new System.Drawing.Point(275, 314);
            this.trkBarDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkBarDelay.Maximum = 20;
            this.trkBarDelay.Minimum = 1;
            this.trkBarDelay.Name = "trkBarDelay";
            this.trkBarDelay.Size = new System.Drawing.Size(139, 56);
            this.trkBarDelay.TabIndex = 9;
            this.trkBarDelay.TabStop = false;
            this.trkBarDelay.Value = 10;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(215, 314);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(44, 17);
            this.lblDelay.TabIndex = 10;
            this.lblDelay.Text = "Delay";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "WFM",
            "AM",
            "NFM",
            "LSB",
            "USB"});
            this.cmbMode.Location = new System.Drawing.Point(275, 377);
            this.cmbMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(80, 24);
            this.cmbMode.TabIndex = 11;
            this.cmbMode.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(215, 380);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(43, 17);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "Mode";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(220, 418);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(99, 29);
            this.lblFrequency.TabIndex = 13;
            this.lblFrequency.Text = "0.0 MHz";
            // 
            // chkRandomTiming
            // 
            this.chkRandomTiming.AutoSize = true;
            this.chkRandomTiming.Location = new System.Drawing.Point(233, 457);
            this.chkRandomTiming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRandomTiming.Name = "chkRandomTiming";
            this.chkRandomTiming.Size = new System.Drawing.Size(129, 21);
            this.chkRandomTiming.TabIndex = 14;
            this.chkRandomTiming.Text = "Random Timing";
            this.chkRandomTiming.UseVisualStyleBackColor = true;
            // 
            // SDRHackBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 487);
            this.Controls.Add(this.chkRandomTiming);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.trkBarDelay);
            this.Controls.Add(this.grpBoxSweepScan);
            this.Controls.Add(this.grpBoxMemoryScan);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SDRHackBox";
            this.Text = "SDR HackBox v1.2";
            this.grpBoxMemoryScan.ResumeLayout(false);
            this.grpBoxMemoryScan.PerformLayout();
            this.grpBoxSweepScan.ResumeLayout(false);
            this.grpBoxSweepScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMemories;
        private System.Windows.Forms.TextBox txtStepFreq;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Button btnMemoryScan;
        private System.Windows.Forms.GroupBox grpBoxMemoryScan;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.GroupBox grpBoxSweepScan;
        private System.Windows.Forms.Button btnSweepScan;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.TextBox txtStopFreq;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStartFreq;
        private System.Windows.Forms.TrackBar trkBarDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.CheckBox chkRandomTiming;
    }
}

