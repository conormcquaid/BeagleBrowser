using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Shell;
using System.Windows;

namespace BeagleBrowser
{
    public partial class GridViewer : Form
    {
        volatile int nPackets;
        volatile int maxPacketLen;
        volatile int[] averages;
        volatile int[] packet;
        volatile int[] max;
        volatile int[] min;
        volatile int nCellsWide, nCellsHigh;

        public BeagleDocument doc;

        public GridViewer(BeagleDocument bDoc)
        {
            InitializeComponent();

            doc = bDoc;
            nPackets = doc.getNumberOfPackets();
            maxPacketLen = doc.getMaxPacketLength();

            averages = new int[maxPacketLen / 2];
            max = new int[maxPacketLen / 2];
            min = new int[maxPacketLen / 2];
            packet = new int[maxPacketLen / 2];

            vScrollAvgMax.Maximum = nPackets;
            vScrollAvgMax.Minimum = 0;
            vScrollAvgMax.Value = nPackets;

            vScrollAvgMin.Maximum = nPackets;
            vScrollAvgMin.Minimum = 0;
            vScrollAvgMin.Value = 0;

            hScrollTimeline.Minimum = 0;
            hScrollTimeline.Maximum = nPackets;
            hScrollTimeline.Value = 0;

            vScrollAvgMax.Update();
            vScrollAvgMin.Update();
            hScrollTimeline.Update();

            nCellsWide = 8;
            nCellsHigh = 12;
            if(doc.getNumberOfPackets() != 0)
            {
                byte[] b = doc.getPacket(0);
                for (int i = 0; i < maxPacketLen / 2; i++)
                {
                    packet[i] = b[2 * i] * 256 + b[2 * i + 1];
                }

                calculateAverages();
            }
            
        }

        public void Init()
        {
            //app a = (app)this.ParentForm;

            //nPackets = doc.getNumberOfPackets();
            //maxPacketLen = doc.getMaxPacketLength();

            //averages = new int[maxPacketLen/2];
            //max = new int[maxPacketLen / 2];
            //min = new int[maxPacketLen / 2];
            //packet = new int[maxPacketLen / 2];

            //vScrollAvgMax.Maximum = nPackets;
            //vScrollAvgMax.Minimum = 0;
            //vScrollAvgMax.Value = nPackets;

            //vScrollAvgMin.Maximum = nPackets;
            //vScrollAvgMin.Minimum = 0;
            //vScrollAvgMin.Value = 0;

            //hScrollTimeline.Minimum = 0;
            //hScrollTimeline.Maximum = nPackets;
            //hScrollTimeline.Value = 0;

            //vScrollAvgMax.Update();
            //vScrollAvgMin.Update();
            //hScrollTimeline.Update();

            //nCellsWide = 8;
            //nCellsHigh = 12;

            //byte[] b = doc.getPacket(0);
            //for(int i = 0; i< maxPacketLen/2; i++)
            //{
            //    packet[i] = b[2 * i] * 256 + b[2 * i + 1];
            //}

            //Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics graphics = e.Graphics;


            // Draw a string on the PictureBox.
            graphics.DrawString("This is a diagonal line drawn on the control",
                new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            graphics.DrawLine(System.Drawing.Pens.Red, gridPanel.Left, gridPanel.Top,
                gridPanel.Right, gridPanel.Bottom);

            System.Drawing.Color color = new Color();
            int red, green, blue;
            red = 0;green = 0;blue = 0;
            

            //for(int y = 0; y < nCellsHigh; y++)
            //{
            //    for(int x = 0; x < nCellsWide; x++)
            //    {
            //        int index = y * nCellsWide + x;
                    
            //        int value = packet[index] - averages[index];

            //        if(value > 0) {
            //            red = (255 - value > 0) ? 255 - value : 0;
            //            green = 255;
            //            blue = (255 - value > 0) ? 255 - value : 0; ;
            //        }else
            //        {
            //            red = 255;
            //            green = 255;
            //            blue = (255 + value > 0) ? 255 - value : 0; ;
            //        }

            //        color = Color.FromArgb(0, red, green, blue);
            //        fillCell(graphics, x, y, color);
            //    }
            //}
        }

        private void fillCell(Graphics g, int x, int y, Color c)
        {
            SolidBrush b = new SolidBrush(c);
            int x_stride = this.gridPanel.Width/nCellsWide;
            int y_stride = this.gridPanel.Height/nCellsHigh;
            g.FillRectangle(b, x * x_stride, y * y_stride, x_stride - 1, y_stride - 1);

        }

        private void GridViewer_Load(object sender, EventArgs e)
        {
            Init();
            Console.Write("GridView Init" + Environment.NewLine);
        }

        private void gridPanel_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics graphics = e.Graphics;


            //// Draw a string on the PictureBox.
            //graphics.DrawString("This is a diagonal line drawn on the control",
            //    new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
            //// Draw a line in the PictureBox.
            //graphics.DrawLine(System.Drawing.Pens.Red, gridPanel.Left, gridPanel.Top,
            //    gridPanel.Right, gridPanel.Bottom);

            System.Drawing.Color color = new Color();
            int red, green, blue;
            red = 0; green = 0; blue = 0;


            for (int y = 0; y < nCellsHigh; y++)
            {
                for (int x = 0; x < nCellsWide; x++)
                {
                    int index = y * nCellsWide + x;

                    int value = packet[index] - averages[index];

                    if (value > 0)
                    {
                        red = (255 - value > 0) ? 255 - value : 0;
                        green = 255;
                        blue = (255 - value > 0) ? 255 - value : 0; ;
                    }
                    else
                    {
                        red = 255;
                        green = 255;
                        blue = (255 + value > 0) ? 255 + value : 0; ;
                    }

                    color = Color.FromArgb(127, red, green, blue);
                    fillCell(graphics, x, y, color);
                }
            }
        }

        private void vScrollAvgMax_ValueChanged(object sender, EventArgs e)
        {
            calculateAverages();
            updateGridStatus();
            this.Refresh();
        }

        private void vScrollAvgMin_ValueChanged(object sender, EventArgs e)
        {
            calculateAverages();
            updateGridStatus();
            this.Refresh();
        }

        private void hScrollTimeline_ValueChanged(object sender, EventArgs e)
        {
            byte[] b = doc.getPacket(0);
            for (int i = 0; i < maxPacketLen / 2; i++)
            {
                packet[i] = b[2 * i] * 256 + b[2 * i + 1];
            }
        }

        private void updateGridStatus()
        {
            gridStatusLabel.Text = string.Format("{0:000} [{1:000},{2:000}]", hScrollTimeline.Value, vScrollAvgMin.Value, vScrollAvgMax.Value);
        }

        private void calculateAverages()
        {
            for(int a = 0; a < maxPacketLen/2; a++) {
                averages[a] = 0;        
                max[a] = 0; 
                min[a] = (int)-1; 
            }

            // either of the vscroll bars can be max or min
            int vmax = (int)Math.Max(vScrollAvgMax.Value, vScrollAvgMin.Value);
            int vmin = (int)Math.Min(vScrollAvgMax.Value, vScrollAvgMin.Value);

            for (int i = vmin; i < vmax; i++)
            {
                byte[] b = doc.getPacket(i);

                for (int j = 0; j < averages.Count(); j++ )
                {
                    averages[j] += b[2 * j] * 256 + b[(2 * j) +1];

                    max[j] = averages[j] > max[j] ? averages[j] : max[j];
                    min[j] = averages[j] < min[j] ? averages[j] : min[j];

                }
            }
            // skip divide by zero if range is 1 packet
            if(vmax == vmin) { return; }
            for (int a = 0; a < maxPacketLen / 2; a++)
            {
                averages[a] = averages[a]/(vmax - vmin);
            }
        }
    }
}
