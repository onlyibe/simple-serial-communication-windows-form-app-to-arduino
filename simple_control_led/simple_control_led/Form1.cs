using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace simple_control_led
{
    public partial class FIX_SIMPLE_LED_CONTROL : Form
    {
        
        public FIX_SIMPLE_LED_CONTROL()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
           serialPort1.Write("1");
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }
    }
}
