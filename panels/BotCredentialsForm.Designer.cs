namespace SOR4VSChat
{
    partial class BotCredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotCredentialsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOAuth = new System.Windows.Forms.TextBox();
            this.txtBotNick = new System.Windows.Forms.TextBox();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnShowOAuth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNowOnline = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNoGameYet = new System.Windows.Forms.TextBox();
            this.labelLinkTwitchApps = new System.Windows.Forms.LinkLabel();
            this.chkBotRepliesToFile = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bot Settings";
            // 
            // txtOAuth
            // 
            this.txtOAuth.Location = new System.Drawing.Point(140, 59);
            this.txtOAuth.Name = "txtOAuth";
            this.txtOAuth.PasswordChar = '*';
            this.txtOAuth.Size = new System.Drawing.Size(246, 23);
            this.txtOAuth.TabIndex = 1;
            // 
            // txtBotNick
            // 
            this.txtBotNick.Location = new System.Drawing.Point(140, 126);
            this.txtBotNick.Name = "txtBotNick";
            this.txtBotNick.Size = new System.Drawing.Size(246, 23);
            this.txtBotNick.TabIndex = 3;
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(140, 162);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(246, 23);
            this.txtChannelName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Channel Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bot Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "OAuth Token";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Location = new System.Drawing.Point(140, 354);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(131, 37);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveBotSettings_Click);
            // 
            // btnShowOAuth
            // 
            this.btnShowOAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOAuth.Location = new System.Drawing.Point(392, 58);
            this.btnShowOAuth.Name = "btnShowOAuth";
            this.btnShowOAuth.Size = new System.Drawing.Size(85, 25);
            this.btnShowOAuth.TabIndex = 2;
            this.btnShowOAuth.Text = "Show Token";
            this.btnShowOAuth.UseVisualStyleBackColor = true;
            this.btnShowOAuth.Click += new System.EventHandler(this.btnShowOAuth_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(549, 229);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Now online";
            // 
            // txtNowOnline
            // 
            this.txtNowOnline.Location = new System.Drawing.Point(140, 252);
            this.txtNowOnline.Name = "txtNowOnline";
            this.txtNowOnline.Size = new System.Drawing.Size(246, 23);
            this.txtNowOnline.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(51, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 2);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Notifications";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "No game yet";
            // 
            // txtNoGameYet
            // 
            this.txtNoGameYet.Location = new System.Drawing.Point(140, 286);
            this.txtNoGameYet.Name = "txtNoGameYet";
            this.txtNoGameYet.Size = new System.Drawing.Size(246, 23);
            this.txtNoGameYet.TabIndex = 6;
            // 
            // labelLinkTwitchApps
            // 
            this.labelLinkTwitchApps.AutoSize = true;
            this.labelLinkTwitchApps.Location = new System.Drawing.Point(93, 435);
            this.labelLinkTwitchApps.Name = "labelLinkTwitchApps";
            this.labelLinkTwitchApps.Size = new System.Drawing.Size(155, 15);
            this.labelLinkTwitchApps.TabIndex = 17;
            this.labelLinkTwitchApps.TabStop = true;
            this.labelLinkTwitchApps.Text = "https://twitchapps.com/tmi";
            this.labelLinkTwitchApps.VisitedLinkColor = System.Drawing.Color.Blue;
            this.labelLinkTwitchApps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLinkTwitchApps_LinkClicked);
            // 
            // chkBotRepliesToFile
            // 
            this.chkBotRepliesToFile.AutoSize = true;
            this.chkBotRepliesToFile.Location = new System.Drawing.Point(140, 325);
            this.chkBotRepliesToFile.Name = "chkBotRepliesToFile";
            this.chkBotRepliesToFile.Size = new System.Drawing.Size(320, 19);
            this.chkBotRepliesToFile.TabIndex = 18;
            this.chkBotRepliesToFile.Text = "Send bot replies to file only (SOR4VSChat_botreplies.txt)";
            this.chkBotRepliesToFile.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(381, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "WARNING: Do not ever show this publicly.\r\nAnybody would be able to control your b" +
    "ot (or your account) with this.";
            // 
            // BotCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 650);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkBotRepliesToFile);
            this.Controls.Add(this.labelLinkTwitchApps);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoGameYet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNowOnline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShowOAuth);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.txtBotNick);
            this.Controls.Add(this.txtOAuth);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BotCredentialsForm";
            this.Text = "PanelStars";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BotCredentialsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BotCredentialsForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOAuth;
        private System.Windows.Forms.TextBox txtBotNick;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnShowOAuth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNowOnline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNoGameYet;
        private System.Windows.Forms.LinkLabel labelLinkTwitchApps;
        public System.Windows.Forms.CheckBox chkBotRepliesToFile;
        private System.Windows.Forms.Label label10;
    }
}