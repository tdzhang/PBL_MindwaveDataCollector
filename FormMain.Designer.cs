namespace ThinkGearNETTest
{
	partial class FormMain
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
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.btnEnableBlink = new System.Windows.Forms.Button();
            this.btnDisableBlink = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.cboRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTimeDataViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyDataVierwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(63, 31);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 21);
            this.cboPort.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 59);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(7, 159);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(387, 244);
            this.txtState.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(113, 59);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(11, 115);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(49, 13);
            this.lblAttention.TabIndex = 5;
            this.lblAttention.Text = "Attention";
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Location = new System.Drawing.Point(11, 135);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(56, 13);
            this.lblMeditation.TabIndex = 5;
            this.lblMeditation.Text = "Meditation";
            // 
            // btnEnableBlink
            // 
            this.btnEnableBlink.Location = new System.Drawing.Point(17, 83);
            this.btnEnableBlink.Name = "btnEnableBlink";
            this.btnEnableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnEnableBlink.TabIndex = 6;
            this.btnEnableBlink.Text = "Enable Blink";
            this.btnEnableBlink.UseVisualStyleBackColor = true;
            this.btnEnableBlink.Click += new System.EventHandler(this.btnEnableBlink_Click);
            // 
            // btnDisableBlink
            // 
            this.btnDisableBlink.Location = new System.Drawing.Point(113, 83);
            this.btnDisableBlink.Name = "btnDisableBlink";
            this.btnDisableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnDisableBlink.TabIndex = 7;
            this.btnDisableBlink.Text = "Disable Blink";
            this.btnDisableBlink.UseVisualStyleBackColor = true;
            this.btnDisableBlink.Click += new System.EventHandler(this.btnDisableBlink_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(212, 59);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(97, 23);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Location = new System.Drawing.Point(212, 82);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(97, 23);
            this.btnStopRecord.TabIndex = 9;
            this.btnStopRecord.Text = "Stop Record";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // cboRate
            // 
            this.cboRate.FormattingEnabled = true;
            this.cboRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "57600",
            "115200"});
            this.cboRate.Location = new System.Drawing.Point(273, 31);
            this.cboRate.Name = "cboRate";
            this.cboRate.Size = new System.Drawing.Size(121, 21);
            this.cboRate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Checked = true;
            this.viewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readTimeDataViewerToolStripMenuItem,
            this.historyDataVierwerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // readTimeDataViewerToolStripMenuItem
            // 
            this.readTimeDataViewerToolStripMenuItem.Checked = true;
            this.readTimeDataViewerToolStripMenuItem.CheckOnClick = true;
            this.readTimeDataViewerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.readTimeDataViewerToolStripMenuItem.Name = "readTimeDataViewerToolStripMenuItem";
            this.readTimeDataViewerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.readTimeDataViewerToolStripMenuItem.Text = "Att/Medi DataViewer";
            this.readTimeDataViewerToolStripMenuItem.Click += new System.EventHandler(this.readTimeDataViewerToolStripMenuItem_Click);
            // 
            // historyDataVierwerToolStripMenuItem
            // 
            this.historyDataVierwerToolStripMenuItem.CheckOnClick = true;
            this.historyDataVierwerToolStripMenuItem.Name = "historyDataVierwerToolStripMenuItem";
            this.historyDataVierwerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.historyDataVierwerToolStripMenuItem.Text = "History DataVierwer";
            this.historyDataVierwerToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.historyDataVierwerToolStripMenuItem_CheckStateChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 397);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRate);
            this.Controls.Add(this.btnStopRecord);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnDisableBlink);
            this.Controls.Add(this.btnEnableBlink);
            this.Controls.Add(this.lblMeditation);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkGearNET Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lblAttention;
		private System.Windows.Forms.Label lblMeditation;
		private System.Windows.Forms.Button btnEnableBlink;
		private System.Windows.Forms.Button btnDisableBlink;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.ComboBox cboRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTimeDataViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyDataVierwerToolStripMenuItem;
	}
}

