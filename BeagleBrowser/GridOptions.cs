using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeagleBrowser
{
    public partial class GridOptions : Form
    {
        public GridOptions()
        {
            InitializeComponent();
        }
        private void rowsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (rowsUpDown.Value < 1) { rowsUpDown.Value = 1; }
        }

        private void columnsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (columnsUpDown.Value < 1) { columnsUpDown.Value = 1; }
        }

        private void trackCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            gridOptionsStatus.Text = "Stat";
        }

    }
}
