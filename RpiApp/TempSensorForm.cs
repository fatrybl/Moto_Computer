using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpiApp
{

    public partial class TempSensorForm : Form
    {
        public Raspberry.IO.Components.Sensors.Temperature.Dht.DhtData data;
        Data.TempSensor temp = new Data.TempSensor();

        public TempSensorForm()
        {
            InitializeComponent();
            temp.Read();
            data = temp.TempData;
            
        }
        public int PinNumber;

        private void TempSensorLabel_Click(object sender, EventArgs e)
        {

        }

        private void PinNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if(PinNumberTextBox.Text==null)
            {
                TempSensorLabel.Text = "Enter pin number";
            }
            else
            {
                PinNumber = Convert.ToInt32(PinNumberTextBox.Text);
            }
        }

        private void TempPinApplyButton_Click(object sender, EventArgs e)
        {
            TempSensorLabel.Text = "you set pin " + PinNumber + " as temperature pin";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
