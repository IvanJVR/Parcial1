
namespace Parcial1
{
    partial class Form1
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
            this.gbDigitalData = new System.Windows.Forms.GroupBox();
            this.gbDigitalSent = new System.Windows.Forms.GroupBox();
            this.gbAnalogData = new System.Windows.Forms.GroupBox();
            this.gbSerialPortSettings = new System.Windows.Forms.GroupBox();
            this.gbCounterSpeed = new System.Windows.Forms.GroupBox();
            this.gpSendingOptions = new System.Windows.Forms.GroupBox();
            this.gbDataSent = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSearchPorts = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.rbAnalog = new System.Windows.Forms.RadioButton();
            this.rbCounter = new System.Windows.Forms.RadioButton();
            this.hsbSpeed = new System.Windows.Forms.HScrollBar();
            this.lblMin = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.gbDigitalData.SuspendLayout();
            this.gbSerialPortSettings.SuspendLayout();
            this.gbCounterSpeed.SuspendLayout();
            this.gpSendingOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDigitalData
            // 
            this.gbDigitalData.Controls.Add(this.btnSet);
            this.gbDigitalData.Controls.Add(this.btnClear);
            this.gbDigitalData.Location = new System.Drawing.Point(32, 23);
            this.gbDigitalData.Name = "gbDigitalData";
            this.gbDigitalData.Size = new System.Drawing.Size(268, 135);
            this.gbDigitalData.TabIndex = 0;
            this.gbDigitalData.TabStop = false;
            this.gbDigitalData.Text = "Digital Data";
            // 
            // gbDigitalSent
            // 
            this.gbDigitalSent.Location = new System.Drawing.Point(306, 23);
            this.gbDigitalSent.Name = "gbDigitalSent";
            this.gbDigitalSent.Size = new System.Drawing.Size(276, 133);
            this.gbDigitalSent.TabIndex = 1;
            this.gbDigitalSent.TabStop = false;
            this.gbDigitalSent.Text = "Digital Data Sent";
            // 
            // gbAnalogData
            // 
            this.gbAnalogData.Location = new System.Drawing.Point(33, 171);
            this.gbAnalogData.Name = "gbAnalogData";
            this.gbAnalogData.Size = new System.Drawing.Size(267, 135);
            this.gbAnalogData.TabIndex = 2;
            this.gbAnalogData.TabStop = false;
            this.gbAnalogData.Text = "Analog Data";
            // 
            // gbSerialPortSettings
            // 
            this.gbSerialPortSettings.Controls.Add(this.comboBox1);
            this.gbSerialPortSettings.Controls.Add(this.btnSearchPorts);
            this.gbSerialPortSettings.Controls.Add(this.btnConnect);
            this.gbSerialPortSettings.Location = new System.Drawing.Point(306, 256);
            this.gbSerialPortSettings.Name = "gbSerialPortSettings";
            this.gbSerialPortSettings.Size = new System.Drawing.Size(276, 100);
            this.gbSerialPortSettings.TabIndex = 3;
            this.gbSerialPortSettings.TabStop = false;
            this.gbSerialPortSettings.Text = "Serial Port Settings";
            // 
            // gbCounterSpeed
            // 
            this.gbCounterSpeed.Controls.Add(this.tbSpeed);
            this.gbCounterSpeed.Controls.Add(this.lblMax);
            this.gbCounterSpeed.Controls.Add(this.lblInterval);
            this.gbCounterSpeed.Controls.Add(this.lblMin);
            this.gbCounterSpeed.Controls.Add(this.hsbSpeed);
            this.gbCounterSpeed.Controls.Add(this.btnStop);
            this.gbCounterSpeed.Controls.Add(this.btnStart);
            this.gbCounterSpeed.Controls.Add(this.btnReset);
            this.gbCounterSpeed.Location = new System.Drawing.Point(32, 321);
            this.gbCounterSpeed.Name = "gbCounterSpeed";
            this.gbCounterSpeed.Size = new System.Drawing.Size(268, 155);
            this.gbCounterSpeed.TabIndex = 4;
            this.gbCounterSpeed.TabStop = false;
            this.gbCounterSpeed.Text = "CounterSpeed";
            // 
            // gpSendingOptions
            // 
            this.gpSendingOptions.Controls.Add(this.rbCounter);
            this.gpSendingOptions.Controls.Add(this.rbAnalog);
            this.gpSendingOptions.Controls.Add(this.rbDigital);
            this.gpSendingOptions.Location = new System.Drawing.Point(306, 371);
            this.gpSendingOptions.Name = "gpSendingOptions";
            this.gpSendingOptions.Size = new System.Drawing.Size(276, 80);
            this.gpSendingOptions.TabIndex = 5;
            this.gpSendingOptions.TabStop = false;
            this.gpSendingOptions.Text = "Sending Options";
            // 
            // gbDataSent
            // 
            this.gbDataSent.Location = new System.Drawing.Point(306, 171);
            this.gbDataSent.Name = "gbDataSent";
            this.gbDataSent.Size = new System.Drawing.Size(276, 79);
            this.gbDataSent.TabIndex = 6;
            this.gbDataSent.TabStop = false;
            this.gbDataSent.Text = "Data Sent";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(28, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(144, 94);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set All";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 29);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(106, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(187, 113);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(354, 483);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 483);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(264, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnSearchPorts
            // 
            this.btnSearchPorts.Location = new System.Drawing.Point(7, 26);
            this.btnSearchPorts.Name = "btnSearchPorts";
            this.btnSearchPorts.Size = new System.Drawing.Size(110, 23);
            this.btnSearchPorts.TabIndex = 1;
            this.btnSearchPorts.Text = "Search Ports";
            this.btnSearchPorts.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(7, 44);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(68, 21);
            this.rbDigital.TabIndex = 0;
            this.rbDigital.TabStop = true;
            this.rbDigital.Text = "Digital";
            this.rbDigital.UseVisualStyleBackColor = true;
            // 
            // rbAnalog
            // 
            this.rbAnalog.AutoSize = true;
            this.rbAnalog.Location = new System.Drawing.Point(100, 44);
            this.rbAnalog.Name = "rbAnalog";
            this.rbAnalog.Size = new System.Drawing.Size(73, 21);
            this.rbAnalog.TabIndex = 1;
            this.rbAnalog.TabStop = true;
            this.rbAnalog.Text = "Analog";
            this.rbAnalog.UseVisualStyleBackColor = true;
            // 
            // rbCounter
            // 
            this.rbCounter.AutoSize = true;
            this.rbCounter.Location = new System.Drawing.Point(181, 44);
            this.rbCounter.Name = "rbCounter";
            this.rbCounter.Size = new System.Drawing.Size(79, 21);
            this.rbCounter.TabIndex = 2;
            this.rbCounter.TabStop = true;
            this.rbCounter.Text = "Counter";
            this.rbCounter.UseVisualStyleBackColor = true;
            // 
            // hsbSpeed
            // 
            this.hsbSpeed.Enabled = false;
            this.hsbSpeed.Location = new System.Drawing.Point(3, 27);
            this.hsbSpeed.Name = "hsbSpeed";
            this.hsbSpeed.Size = new System.Drawing.Size(255, 22);
            this.hsbSpeed.TabIndex = 3;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(7, 62);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(46, 17);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "10 ms";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(10, 85);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(54, 17);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "Interval";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(196, 62);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(62, 17);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "2550 ms";
            // 
            // tbSpeed
            // 
            this.tbSpeed.BackColor = System.Drawing.SystemColors.Menu;
            this.tbSpeed.Location = new System.Drawing.Point(70, 82);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(111, 22);
            this.tbSpeed.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.gbDataSent);
            this.Controls.Add(this.gpSendingOptions);
            this.Controls.Add(this.gbCounterSpeed);
            this.Controls.Add(this.gbSerialPortSettings);
            this.Controls.Add(this.gbAnalogData);
            this.Controls.Add(this.gbDigitalSent);
            this.Controls.Add(this.gbDigitalData);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Controller";
            this.gbDigitalData.ResumeLayout(false);
            this.gbSerialPortSettings.ResumeLayout(false);
            this.gbCounterSpeed.ResumeLayout(false);
            this.gbCounterSpeed.PerformLayout();
            this.gpSendingOptions.ResumeLayout(false);
            this.gpSendingOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDigitalData;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbDigitalSent;
        private System.Windows.Forms.GroupBox gbAnalogData;
        private System.Windows.Forms.GroupBox gbSerialPortSettings;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSearchPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbCounterSpeed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gpSendingOptions;
        private System.Windows.Forms.GroupBox gbDataSent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.HScrollBar hsbSpeed;
        private System.Windows.Forms.RadioButton rbCounter;
        private System.Windows.Forms.RadioButton rbAnalog;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

