using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalPhase;

namespace BeagleBrowser
{
    
    public partial class connectDlg : Form
    {
        static int beagle;

        public int getBeagleIndex()
        {
            return beagle;

        }

        public connectDlg()
        {
            InitializeComponent();

            findDevices();

            this.availDevListBox.Focus();
        }

        private void findDevices()
        {
            ushort[] ports = new ushort[16];
            uint[] unique_ids = new uint[16];
            int nelem = 16;

            // Find all the attached devices
            int count = BeagleApi.bg_find_devices_ext(nelem, ports,
                    nelem, unique_ids);
            int i;

            //Console.Write("{0:d} device(s) found:\n", count);
           // availDevTextBox.AppendText(String.Format("{0:d} device(s) found:\n", count));

            //availDevListBox.Items.Add(string.Format("{0:d} device(s) found:\n", count));

            // Print the information on each device
            if (count > nelem) count = nelem;
            for (i = 0; i < count; ++i)
            {
                // Determine if the device is in-use
                String status = "(avail) ";
                if ((ports[i] & BeagleApi.BG_PORT_NOT_FREE) != 0)
                {
                    ports[i] &= unchecked((ushort)~BeagleApi.BG_PORT_NOT_FREE);
                    status = "(in-use)";
                }

                // Display device port number, in-use status, and serial number
                //Console.Write


                availDevListBox.Items.Add(string.Format("    port={0,-3:d} {1:s} ({2:d4}-{3:d6})\n",
                       ports[i], status,
                       unique_ids[i] / 1000000,
                       unique_ids[i] % 1000000));
            }
            if(availDevListBox.Items.Count > 0)
            {

                availDevListBox.SelectedIndex = 0;
            }


        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            int port = availDevListBox.SelectedIndex;
            int samplerate = 10000;  // in kHz
            uint timeout = 500;    // in milliseconds
            uint latency = 200;    // in milliseconds
            int len = 0;
            byte pullups = BeagleApi.BG_I2C_PULLUP_ON;
            byte target_pow = BeagleApi.BG_TARGET_POWER_ON;
            int num = 0;


            beagle = BeagleApi.bg_open(port);

            if(beagle <= 0){

                // port open failed
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

            // Set the samplerate
            samplerate = BeagleApi.bg_samplerate(beagle, samplerate);
            if (samplerate < 0)
            {
                Console.Write("error: {0:s}\n",
                     BeagleApi.bg_status_string(samplerate));
                Environment.Exit(1);
            }
            Console.Write("Sampling rate set to {0:d} KHz.\n", samplerate);

            // Set the idle timeout.
            // The Beagle read functions will return in the specified time
            // if there is no data available on the bus.
            BeagleApi.bg_timeout(beagle, timeout);
            Console.Write("Idle timeout set to {0:d} ms.\n", timeout);

            // Set the latency.
            // The latency parameter allows the programmer to balance the
            // tradeoff between host side buffering and the latency to
            // receive a packet when calling one of the Beagle read
            // functions.
            BeagleApi.bg_latency(beagle, latency);
            Console.Write("Latency set to {0:d} ms.\n", latency);

            Console.Write("Host interface is {0:s}.\n",
                   ((BeagleApi.bg_host_ifce_speed(beagle)) != 0) ?
                                                     "high speed" : "full speed");

            // There is usually no need for pullups or target power
            // when using the Beagle as a passive monitor.
            BeagleApi.bg_i2c_pullup(beagle, pullups);
            BeagleApi.bg_target_power(beagle, target_pow);

            Console.Write("\n");
            Console.Out.Flush();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void availDevListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availDevListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            connectButton_Click(sender, e);

        }
}


}
