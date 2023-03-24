namespace Remote_Control_Access
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.connectTab = new System.Windows.Forms.TabPage();
            this.shareBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.shareTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.portTxt2 = new System.Windows.Forms.TextBox();
            this.listenBtn = new System.Windows.Forms.Button();
            this.shareTimer = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.mainTabs.SuspendLayout();
            this.connectTab.SuspendLayout();
            this.shareTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.connectTab);
            this.mainTabs.Controls.Add(this.shareTab);
            this.mainTabs.Location = new System.Drawing.Point(0, -1);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(412, 168);
            this.mainTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabs.TabIndex = 0;
            // 
            // connectTab
            // 
            this.connectTab.Controls.Add(this.shareBtn);
            this.connectTab.Controls.Add(this.connectBtn);
            this.connectTab.Controls.Add(this.portLabel);
            this.connectTab.Controls.Add(this.ipLabel);
            this.connectTab.Controls.Add(this.portTxt);
            this.connectTab.Controls.Add(this.ipTxt);
            this.connectTab.Location = new System.Drawing.Point(4, 22);
            this.connectTab.Name = "connectTab";
            this.connectTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectTab.Size = new System.Drawing.Size(404, 142);
            this.connectTab.TabIndex = 0;
            this.connectTab.Text = "Connect";
            this.connectTab.UseVisualStyleBackColor = true;
            // 
            // shareBtn
            // 
            this.shareBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shareBtn.Location = new System.Drawing.Point(219, 98);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(176, 31);
            this.shareBtn.TabIndex = 5;
            this.shareBtn.Text = "Share Screen";
            this.shareBtn.UseVisualStyleBackColor = true;
            this.shareBtn.Click += new System.EventHandler(this.shareBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Location = new System.Drawing.Point(23, 98);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(189, 31);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portLabel.Location = new System.Drawing.Point(162, 49);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(61, 20);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "PORT:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipLabel.Location = new System.Drawing.Point(181, 3);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(31, 20);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP:";
            // 
            // portTxt
            // 
            this.portTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTxt.Location = new System.Drawing.Point(100, 72);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(189, 22);
            this.portTxt.TabIndex = 1;
            this.portTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ipTxt
            // 
            this.ipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipTxt.Location = new System.Drawing.Point(100, 26);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(189, 22);
            this.ipTxt.TabIndex = 0;
            this.ipTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shareTab
            // 
            this.shareTab.Controls.Add(this.label1);
            this.shareTab.Controls.Add(this.portTxt2);
            this.shareTab.Controls.Add(this.listenBtn);
            this.shareTab.Location = new System.Drawing.Point(4, 22);
            this.shareTab.Name = "shareTab";
            this.shareTab.Padding = new System.Windows.Forms.Padding(3);
            this.shareTab.Size = new System.Drawing.Size(404, 142);
            this.shareTab.TabIndex = 1;
            this.shareTab.Text = "Share";
            this.shareTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT:";
            // 
            // portTxt2
            // 
            this.portTxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.portTxt2.Location = new System.Drawing.Point(100, 36);
            this.portTxt2.Name = "portTxt2";
            this.portTxt2.Size = new System.Drawing.Size(189, 22);
            this.portTxt2.TabIndex = 4;
            this.portTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listenBtn
            // 
            this.listenBtn.Location = new System.Drawing.Point(148, 64);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(75, 23);
            this.listenBtn.TabIndex = 0;
            this.listenBtn.Text = "Listen";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // shareTimer
            // 
            this.shareTimer.Interval = 15;
            this.shareTimer.Tick += new System.EventHandler(this.shareTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 163);
            this.Controls.Add(this.mainTabs);
            this.Name = "mainForm";
            this.Text = "Remote Controll - By Georgi Papazov";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainTabs.ResumeLayout(false);
            this.connectTab.ResumeLayout(false);
            this.connectTab.PerformLayout();
            this.shareTab.ResumeLayout(false);
            this.shareTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage connectTab;
        private System.Windows.Forms.Button shareBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TabPage shareTab;
        private System.Windows.Forms.Timer shareTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portTxt2;
        private System.Windows.Forms.Button listenBtn;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

