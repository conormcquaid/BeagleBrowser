namespace BeagleBrowser
{
    partial class connectDlg
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
            this.connectButton = new System.Windows.Forms.Button();
            this.availDevListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(197, 227);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // availDevListBox
            // 
            this.availDevListBox.FormattingEnabled = true;
            this.availDevListBox.Location = new System.Drawing.Point(12, 21);
            this.availDevListBox.Name = "availDevListBox";
            this.availDevListBox.Size = new System.Drawing.Size(260, 186);
            this.availDevListBox.TabIndex = 2;
            this.availDevListBox.SelectedIndexChanged += new System.EventHandler(this.availDevListBox_SelectedIndexChanged);
            this.availDevListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.availDevListBox_MouseDoubleClick);
            // 
            // connectDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.availDevListBox);
            this.Controls.Add(this.connectButton);
            this.Name = "connectDlg";
            this.Text = "Connect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox availDevListBox;
    }
}