namespace Remote_Control_Access
{
    partial class ScreenForm
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
            this.tooltips = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.miscTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.createFolder = new System.Windows.Forms.Button();
            this.webTxt = new System.Windows.Forms.TextBox();
            this.openWeb = new System.Windows.Forms.Button();
            this.soundManagerTab = new System.Windows.Forms.GroupBox();
            this.set = new System.Windows.Forms.Button();
            this.screenTab = new System.Windows.Forms.TabPage();
            this.screenPicture = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.soundBar = new System.Windows.Forms.TrackBar();
            this.rndSoundValueSetter = new System.Windows.Forms.Button();
            this.muteSoundBtn = new System.Windows.Forms.Button();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.soundManagerTab.SuspendLayout();
            this.screenTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenPicture)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tooltips
            // 
            this.tooltips.IsBalloon = true;
            this.tooltips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltips.ToolTipTitle = "Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.mainText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 32);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.mainText.Location = new System.Drawing.Point(6, 6);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(176, 19);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "Remote Control Panel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // miscTab
            // 
            this.miscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.miscTab.Controls.Add(this.groupBox4);
            this.miscTab.Controls.Add(this.groupBox2);
            this.miscTab.Controls.Add(this.soundManagerTab);
            this.miscTab.Controls.Add(this.groupBox1);
            this.miscTab.Location = new System.Drawing.Point(4, 25);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(584, 266);
            this.miscTab.TabIndex = 1;
            this.miscTab.Text = "Fun";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.sendMsgBtn);
            this.groupBox1.Controls.Add(this.openWeb);
            this.groupBox1.Controls.Add(this.webTxt);
            this.groupBox1.Controls.Add(this.createFolder);
            this.groupBox1.Controls.Add(this.folderTxt);
            this.groupBox1.Controls.Add(this.messageTxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscelanious";
            // 
            // messageTxt
            // 
            this.messageTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTxt.Location = new System.Drawing.Point(6, 21);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(139, 25);
            this.messageTxt.TabIndex = 1;
            // 
            // folderTxt
            // 
            this.folderTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderTxt.Location = new System.Drawing.Point(6, 52);
            this.folderTxt.Multiline = true;
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(139, 24);
            this.folderTxt.TabIndex = 3;
            // 
            // createFolder
            // 
            this.createFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.createFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.createFolder.Location = new System.Drawing.Point(151, 52);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(118, 24);
            this.createFolder.TabIndex = 4;
            this.createFolder.Text = "Create Folder";
            this.createFolder.UseVisualStyleBackColor = false;
            this.createFolder.Click += new System.EventHandler(this.createFolder_Click);
            // 
            // webTxt
            // 
            this.webTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.webTxt.Location = new System.Drawing.Point(6, 82);
            this.webTxt.Multiline = true;
            this.webTxt.Name = "webTxt";
            this.webTxt.Size = new System.Drawing.Size(139, 24);
            this.webTxt.TabIndex = 5;
            // 
            // openWeb
            // 
            this.openWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.openWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.openWeb.Location = new System.Drawing.Point(151, 82);
            this.openWeb.Name = "openWeb";
            this.openWeb.Size = new System.Drawing.Size(118, 24);
            this.openWeb.TabIndex = 6;
            this.openWeb.Text = "Open Website";
            this.openWeb.UseVisualStyleBackColor = false;
            this.openWeb.Click += new System.EventHandler(this.openWeb_Click);
            // 
            // soundManagerTab
            // 
            this.soundManagerTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soundManagerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.soundManagerTab.Controls.Add(this.muteSoundBtn);
            this.soundManagerTab.Controls.Add(this.rndSoundValueSetter);
            this.soundManagerTab.Controls.Add(this.soundBar);
            this.soundManagerTab.Controls.Add(this.set);
            this.soundManagerTab.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundManagerTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.soundManagerTab.Location = new System.Drawing.Point(9, 125);
            this.soundManagerTab.Name = "soundManagerTab";
            this.soundManagerTab.Size = new System.Drawing.Size(275, 115);
            this.soundManagerTab.TabIndex = 7;
            this.soundManagerTab.TabStop = false;
            this.soundManagerTab.Text = "Audio Manager";
            // 
            // set
            // 
            this.set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.set.Location = new System.Drawing.Point(151, 19);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(118, 27);
            this.set.TabIndex = 2;
            this.set.Text = "Change Volume";
            this.set.UseVisualStyleBackColor = false;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // screenTab
            // 
            this.screenTab.Controls.Add(this.screenPicture);
            this.screenTab.Location = new System.Drawing.Point(4, 25);
            this.screenTab.Name = "screenTab";
            this.screenTab.Padding = new System.Windows.Forms.Padding(3);
            this.screenTab.Size = new System.Drawing.Size(591, 266);
            this.screenTab.TabIndex = 0;
            this.screenTab.Text = "Screen Monitoring";
            this.screenTab.UseVisualStyleBackColor = true;
            // 
            // screenPicture
            // 
            this.screenPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.screenPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.screenPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPicture.Location = new System.Drawing.Point(3, 3);
            this.screenPicture.Name = "screenPicture";
            this.screenPicture.Size = new System.Drawing.Size(585, 260);
            this.screenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenPicture.TabIndex = 0;
            this.screenPicture.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.screenTab);
            this.tabControl.Controls.Add(this.miscTab);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(592, 295);
            this.tabControl.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.groupBox2.Location = new System.Drawing.Point(290, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Miscelanious";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.groupBox4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.groupBox4.Location = new System.Drawing.Point(290, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 115);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miscelanious";
            // 
            // soundBar
            // 
            this.soundBar.LargeChange = 1;
            this.soundBar.Location = new System.Drawing.Point(6, 21);
            this.soundBar.Maximum = 100;
            this.soundBar.Name = "soundBar";
            this.soundBar.Size = new System.Drawing.Size(139, 45);
            this.soundBar.TabIndex = 0;
            // 
            // rndSoundValueSetter
            // 
            this.rndSoundValueSetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.rndSoundValueSetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndSoundValueSetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.rndSoundValueSetter.Location = new System.Drawing.Point(6, 52);
            this.rndSoundValueSetter.Name = "rndSoundValueSetter";
            this.rndSoundValueSetter.Size = new System.Drawing.Size(263, 27);
            this.rndSoundValueSetter.TabIndex = 3;
            this.rndSoundValueSetter.Text = "Random Sound Value";
            this.rndSoundValueSetter.UseVisualStyleBackColor = false;
            this.rndSoundValueSetter.Click += new System.EventHandler(this.rndSoundValueSetter_Click);
            // 
            // muteSoundBtn
            // 
            this.muteSoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.muteSoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteSoundBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.muteSoundBtn.Location = new System.Drawing.Point(6, 82);
            this.muteSoundBtn.Name = "muteSoundBtn";
            this.muteSoundBtn.Size = new System.Drawing.Size(263, 27);
            this.muteSoundBtn.TabIndex = 4;
            this.muteSoundBtn.Text = "Mute Sound";
            this.muteSoundBtn.UseVisualStyleBackColor = false;
            this.muteSoundBtn.Click += new System.EventHandler(this.muteSoundBtn_Click);
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.sendMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMsgBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.sendMsgBtn.Location = new System.Drawing.Point(151, 22);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(118, 24);
            this.sendMsgBtn.TabIndex = 7;
            this.sendMsgBtn.Text = "Send MessageBox";
            this.sendMsgBtn.UseVisualStyleBackColor = false;
            this.sendMsgBtn.Click += new System.EventHandler(this.sendMsgBtn_Click);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(592, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenForm";
            this.Text = "ScreenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.miscTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.soundManagerTab.ResumeLayout(false);
            this.soundManagerTab.PerformLayout();
            this.screenTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenPicture)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soundBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tooltips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox soundManagerTab;
        private System.Windows.Forms.Button muteSoundBtn;
        private System.Windows.Forms.Button rndSoundValueSetter;
        private System.Windows.Forms.TrackBar soundBar;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openWeb;
        private System.Windows.Forms.TextBox webTxt;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.TabPage screenTab;
        private System.Windows.Forms.PictureBox screenPicture;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button sendMsgBtn;
    }
}