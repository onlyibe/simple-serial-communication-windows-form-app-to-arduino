namespace simple_control_led
{
    partial class FIX_SIMPLE_LED_CONTROL
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
            this.buttonON = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // buttonON
            // 
            this.buttonON.BackColor = System.Drawing.Color.Lime;
            this.buttonON.Location = new System.Drawing.Point(58, 82);
            this.buttonON.Name = "buttonON";
            this.buttonON.Size = new System.Drawing.Size(101, 78);
            this.buttonON.TabIndex = 0;
            this.buttonON.Text = "ON";
            this.buttonON.UseVisualStyleBackColor = false;
            this.buttonON.Click += new System.EventHandler(this.buttonON_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.BackColor = System.Drawing.Color.Red;
            this.buttonOFF.Location = new System.Drawing.Point(272, 82);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(101, 78);
            this.buttonOFF.TabIndex = 1;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = false;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // FIX_SIMPLE_LED_CONTROL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 323);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonON);
            this.Name = "FIX_SIMPLE_LED_CONTROL";
            this.Text = "FIX SIMPLE CONTROL LED";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonON;
        private System.Windows.Forms.Button buttonOFF;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

