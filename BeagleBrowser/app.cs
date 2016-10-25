using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalPhase;

namespace BeagleBrowser
{
    public partial class app : Form
    {

        public BeagleDocument bDoc { get; set; }

        private String sUserImageDir;
        private Thread readerThread;

        enum PlayStatus {  pause, play  } ;
        PlayStatus playStatus;

        static int beagle;

        public app()
        {
            InitializeComponent();
            statusLabel.Text = "Ready.";

            bDoc = new BeagleDocument();

            if(bDoc == null)
            {

                textBox1.AppendText("Doc is null" + Environment.NewLine);
            }
            playStatus = PlayStatus.pause;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox1();//
            about.ShowDialog();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadCaptureFromFile())
            {
                // display the data?
            }
        }

        private bool loadCaptureFromFile()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (sUserImageDir == "")
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            else
            {
                ofd.InitialDirectory = sUserImageDir;
            }
            ofd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ofd.FilterIndex = 2;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               
                bool ret = false;
                
                //bDoc = new BeagleDocument();

                try
                {
                    foreach(String line in File.ReadLines(ofd.FileName))
                    {
                        textBox1.AppendText(">>>" + Environment.NewLine); 

                        // ignore any comment lines at start of a totalphase file
                        if (line.StartsWith("#")) continue;

                        // should ignore start and stop lines also

                        // suck any parseable lines into doc
                        // level, index, timestamp, duration, length, err, sp, addr, record, data
                        String[] fields = line.Split(',');

                        if( fields[3].Length == 0)
                        {
                            continue;// start/stop fields have no duration
                        }


                        // asterisk at end of data indicates NAK
                        if (fields[9].EndsWith("*"))
                        {
                            textBox1.AppendText("HHH" + Environment.NewLine);
                            fields[9].TrimEnd('*', '\n');
                        }
                            
                        fields[9].TrimEnd('*', '\n');
                        // }
                        textBox1.AppendText(fields[9] + Environment.NewLine);
                        // 9th field is packet data in  space separated ascii bytes
                        //if (bDoc.addPacket(fields[9]))
                        //{
                        //    ret = true;
                        //}
                        ret = bDoc.addPacket(fields[9].TrimEnd('*', '\n'));
                    }

                }
                catch (Exception e)
                {

                }

                //save dir
                sUserImageDir = System.IO.Path.GetDirectoryName(ofd.FileName);
                
                return ret;
            }
            return false;


        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            //TODO: connect only if NOT connected, else, disconnect/disable beagle

            connectDlg connect = new connectDlg();//

            if (connect.ShowDialog() == DialogResult.OK)
            {
                beagle = connect.getBeagleIndex();

                connectButton.Image = global::BeagleBrowser.Properties.Resources.connected; ;
                statusLabel.Text = "Connected";
                textBox1.AppendText("Connected" + Environment.NewLine);
            };
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            //toggle state!
            //if (playStatus == PlayStatus.play) { playStatus = PlayStatus.pause; } else { playStatus = PlayStatus.play; }

            // if paused, show play image & vice versa
            if (playStatus == PlayStatus.play)
            {
                playPauseButton.Image = global::BeagleBrowser.Properties.Resources.play;
                playStatus = PlayStatus.pause;

                BeagleApi.bg_disable(beagle);
                if(readerThread.IsAlive /*.ThreadState == ThreadState.Running*/ )
                {
                    readerThread.Suspend();
                }
                return;

            }

            if (BeagleApi.bg_enable(beagle, BeagleProtocol.BG_PROTOCOL_I2C) !=
            (int)BeagleStatus.BG_OK)
            {
                return;
            }

            readerThread = new Thread(new ThreadStart(readerThreadFunc));
            readerThread.Start();

            playPauseButton.Image = global::BeagleBrowser.Properties.Resources.pause;
            playStatus = PlayStatus.play;
        }

        private void appendToText(string text)
        {
            // insert in BeagleDocument
            bDoc.addPacket(text);
            textBox1.AppendText(text);
        }
        public delegate void appendCallback(string text);

        private void readerThreadFunc()
        {
            uint status = 0;
            ulong time_sop = 0, time_sop_ns = 0;
            ulong time_duration = 0;
            uint time_dataoffset = 0;
            ushort[] data_in = new ushort[4096];

            while (true)
            {
                int count = BeagleApi.bg_i2c_read(beagle, ref status, ref time_sop, ref time_duration, ref time_dataoffset, 4096, data_in);
                if (count > 0) {

                    StringBuilder hexstring = new StringBuilder(count*2);

                    //if (Convert.ToInt32(data_in[0]) & 1 != 0)
                    //{
                    //    hexstring.AppendFormat("[R:{0:x2}] ", data_in[0] >> 1);
                    //}else
                    //{
                    //    hexstring.AppendFormat("[W:{0:x2}] ", data_in[0] >> 1);
                    //}
                    for (int i = 1; i < count; i++)
                    {
                        hexstring.AppendFormat( "{0:x2} ",data_in[i]);
                    }
                    //textBox1.Invoke(new appendCallback(this.appendToText), new object[] { string.Format("Thread sez hi {0}", count) + Environment.NewLine });
                    textBox1.Invoke(new appendCallback(this.appendToText), new object[] { hexstring.ToString() + Environment.NewLine });
                }
                Thread.Sleep(10);
            }
            


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            GridViewer gv = new GridViewer(bDoc);
            GridOptions go = new GridOptions();

            gv.Show(this);
            go.Show(this);

            //gv.doc = bDoc;
            
            
        }
    }
}
