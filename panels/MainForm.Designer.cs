namespace SOR4VSChat
{
    partial class MainForm
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
            this.btnStartBot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.btnBotSettings = new System.Windows.Forms.Button();
            this.btnToggleCommandLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartBot
            // 
            this.btnStartBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartBot.Location = new System.Drawing.Point(198, 548);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(206, 45);
            this.btnStartBot.TabIndex = 1;
            this.btnStartBot.Text = "START BOT";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VS Chat Settings";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Location = new System.Drawing.Point(477, 22);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(114, 26);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.Location = new System.Drawing.Point(25, 71);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(566, 471);
            this.chatPanel.TabIndex = 17;
            // 
            // btnBotSettings
            // 
            this.btnBotSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotSettings.Location = new System.Drawing.Point(363, 22);
            this.btnBotSettings.Name = "btnBotSettings";
            this.btnBotSettings.Size = new System.Drawing.Size(108, 26);
            this.btnBotSettings.TabIndex = 18;
            this.btnBotSettings.Text = "Bot Settings";
            this.btnBotSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBotSettings.UseVisualStyleBackColor = true;
            this.btnBotSettings.Click += new System.EventHandler(this.btnBotSettings_Click);
            // 
            // btnToggleCommandLog
            // 
            this.btnToggleCommandLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleCommandLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleCommandLog.Location = new System.Drawing.Point(462, 568);
            this.btnToggleCommandLog.Name = "btnToggleCommandLog";
            this.btnToggleCommandLog.Size = new System.Drawing.Size(129, 25);
            this.btnToggleCommandLog.TabIndex = 19;
            this.btnToggleCommandLog.Text = "Show Command Log";
            this.btnToggleCommandLog.UseVisualStyleBackColor = true;
            this.btnToggleCommandLog.Click += new System.EventHandler(this.btnToggleCommandLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 632);
            this.Controls.Add(this.btnToggleCommandLog);
            this.Controls.Add(this.btnBotSettings);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnStartBot);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "PanelStars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel chatPanel;
        public System.Windows.Forms.Button btnSaveSettings;
        public System.Windows.Forms.Button btnBotSettings;
        public System.Windows.Forms.Button btnToggleCommandLog;
    }
}