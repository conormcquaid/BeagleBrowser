namespace BeagleBrowser
{
    partial class GridViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.fredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollAvgMin = new System.Windows.Forms.VScrollBar();
            this.vScrollAvgMax = new System.Windows.Forms.VScrollBar();
            this.hScrollTimeline = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.fredToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.juhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridStatusLabel,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(488, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fredToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // fredToolStripMenuItem
            // 
            this.fredToolStripMenuItem.Name = "fredToolStripMenuItem";
            this.fredToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fredToolStripMenuItem.Text = "Options";
            // 
            // vScrollAvgMin
            // 
            this.vScrollAvgMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vScrollAvgMin.Location = new System.Drawing.Point(27, 0);
            this.vScrollAvgMin.Name = "vScrollAvgMin";
            this.vScrollAvgMin.Size = new System.Drawing.Size(21, 427);
            this.vScrollAvgMin.TabIndex = 2;
            this.vScrollAvgMin.ValueChanged += new System.EventHandler(this.vScrollAvgMin_ValueChanged);
            // 
            // vScrollAvgMax
            // 
            this.vScrollAvgMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vScrollAvgMax.Location = new System.Drawing.Point(6, 0);
            this.vScrollAvgMax.Name = "vScrollAvgMax";
            this.vScrollAvgMax.Size = new System.Drawing.Size(21, 427);
            this.vScrollAvgMax.TabIndex = 3;
            this.vScrollAvgMax.ValueChanged += new System.EventHandler(this.vScrollAvgMax_ValueChanged);
            // 
            // hScrollTimeline
            // 
            this.hScrollTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollTimeline.Location = new System.Drawing.Point(9, 422);
            this.hScrollTimeline.Name = "hScrollTimeline";
            this.hScrollTimeline.Size = new System.Drawing.Size(422, 17);
            this.hScrollTimeline.TabIndex = 4;
            this.hScrollTimeline.ValueChanged += new System.EventHandler(this.hScrollTimeline_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.vScrollAvgMin);
            this.panel1.Controls.Add(this.vScrollAvgMax);
            this.panel1.Location = new System.Drawing.Point(434, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 427);
            this.panel1.TabIndex = 5;
            // 
            // gridStatusLabel
            // 
            this.gridStatusLabel.Name = "gridStatusLabel";
            this.gridStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.gridStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fredToolStripMenuItem1});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // fredToolStripMenuItem1
            // 
            this.fredToolStripMenuItem1.Name = "fredToolStripMenuItem1";
            this.fredToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fredToolStripMenuItem1.Text = "fred";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juhToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // juhToolStripMenuItem
            // 
            this.juhToolStripMenuItem.Name = "juhToolStripMenuItem";
            this.juhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.juhToolStripMenuItem.Text = "juh";
            // 
            // gridPanel
            // 
            this.gridPanel.Location = new System.Drawing.Point(12, 12);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(416, 407);
            this.gridPanel.TabIndex = 6;
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPanel_Paint);
            // 
            // GridViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 464);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollTimeline);
            this.Controls.Add(this.statusStrip1);
            this.Name = "GridViewer";
            this.Text = "GridViewer";
            this.Load += new System.EventHandler(this.GridViewer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem fredToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollAvgMin;
        private System.Windows.Forms.VScrollBar vScrollAvgMax;
        private System.Windows.Forms.HScrollBar hScrollTimeline;
        private System.Windows.Forms.ToolStripStatusLabel gridStatusLabel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem fredToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem juhToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel gridPanel;
    }
}