namespace BeagleBrowser
{
    partial class GridOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnsUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.trackCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridOptionsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.columnsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columns";
            // 
            // columnsUpDown
            // 
            this.columnsUpDown.Location = new System.Drawing.Point(30, 83);
            this.columnsUpDown.Name = "columnsUpDown";
            this.columnsUpDown.Size = new System.Drawing.Size(48, 20);
            this.columnsUpDown.TabIndex = 2;
            // 
            // rowsUpDown
            // 
            this.rowsUpDown.Location = new System.Drawing.Point(30, 57);
            this.rowsUpDown.Name = "rowsUpDown";
            this.rowsUpDown.Size = new System.Drawing.Size(48, 20);
            this.rowsUpDown.TabIndex = 3;
            // 
            // trackCheckBox
            // 
            this.trackCheckBox.AutoSize = true;
            this.trackCheckBox.Location = new System.Drawing.Point(30, 134);
            this.trackCheckBox.Name = "trackCheckBox";
            this.trackCheckBox.Size = new System.Drawing.Size(77, 17);
            this.trackCheckBox.TabIndex = 4;
            this.trackCheckBox.Text = "Track Live";
            this.trackCheckBox.UseVisualStyleBackColor = true;
            this.trackCheckBox.CheckStateChanged += new System.EventHandler(this.trackCheckBox_CheckStateChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridOptionsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridOptionsStatus
            // 
            this.gridOptionsStatus.Name = "gridOptionsStatus";
            this.gridOptionsStatus.Size = new System.Drawing.Size(118, 17);
            this.gridOptionsStatus.Text = "toolStripStatusLabel1";
            // 
            // GridOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.trackCheckBox);
            this.Controls.Add(this.rowsUpDown);
            this.Controls.Add(this.columnsUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GridOptions";
            this.Text = "GridOptions";
            ((System.ComponentModel.ISupportInitialize)(this.columnsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown columnsUpDown;
        private System.Windows.Forms.NumericUpDown rowsUpDown;
        private System.Windows.Forms.CheckBox trackCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel gridOptionsStatus;
    }
}