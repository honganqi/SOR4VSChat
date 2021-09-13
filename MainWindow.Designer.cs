namespace SOR4VSChat
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.activePanel = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnCharPanel = new System.Windows.Forms.Button();
            this.btnHealthPanel = new System.Windows.Forms.Button();
            this.btnBotCredentials = new System.Windows.Forms.Button();
            this.btnSizePanel = new System.Windows.Forms.Button();
            this.btnGravityPanel = new System.Windows.Forms.Button();
            this.btnSpeedPanel = new System.Windows.Forms.Button();
            this.btnLivesPanel = new System.Windows.Forms.Button();
            this.imgSF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTwitch = new System.Windows.Forms.PictureBox();
            this.imgYoutube = new System.Windows.Forms.PictureBox();
            this.imgBMCSupport = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activePanel
            // 
            this.activePanel.Location = new System.Drawing.Point(110, 33);
            this.activePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(614, 617);
            this.activePanel.TabIndex = 1;
            this.activePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.activePanel_MouseDown);
            this.activePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.activePanel_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.labelAuthor);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(110, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(614, 36);
            this.panelTop.TabIndex = 45;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "v1.1";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(161, 13);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(73, 13);
            this.labelAuthor.TabIndex = 43;
            this.labelAuthor.Text = "by honganqi";
            this.labelAuthor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAuthor_MouseDown);
            this.labelAuthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelAuthor_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(542, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 42;
            this.btnMinimize.Text = "̶̶";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(578, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(119, 21);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "SOR4 VS CHAT";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.btnCharPanel);
            this.panelLeft.Controls.Add(this.btnHealthPanel);
            this.panelLeft.Controls.Add(this.btnBotCredentials);
            this.panelLeft.Controls.Add(this.btnSizePanel);
            this.panelLeft.Controls.Add(this.btnGravityPanel);
            this.panelLeft.Controls.Add(this.btnSpeedPanel);
            this.panelLeft.Controls.Add(this.btnLivesPanel);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(110, 729);
            this.panelLeft.TabIndex = 46;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            // 
            // btnCharPanel
            // 
            this.btnCharPanel.FlatAppearance.BorderSize = 0;
            this.btnCharPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCharPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharPanel.ForeColor = System.Drawing.Color.White;
            this.btnCharPanel.Location = new System.Drawing.Point(10, 560);
            this.btnCharPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCharPanel.Name = "btnCharPanel";
            this.btnCharPanel.Size = new System.Drawing.Size(90, 90);
            this.btnCharPanel.TabIndex = 44;
            this.btnCharPanel.Text = "Character";
            this.btnCharPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCharPanel.UseVisualStyleBackColor = true;
            this.btnCharPanel.Visible = false;
            this.btnCharPanel.Click += new System.EventHandler(this.btnCharPanel_Click);
            // 
            // btnHealthPanel
            // 
            this.btnHealthPanel.FlatAppearance.BorderSize = 0;
            this.btnHealthPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHealthPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealthPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealthPanel.ForeColor = System.Drawing.Color.White;
            this.btnHealthPanel.Location = new System.Drawing.Point(10, 340);
            this.btnHealthPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnHealthPanel.Name = "btnHealthPanel";
            this.btnHealthPanel.Size = new System.Drawing.Size(90, 90);
            this.btnHealthPanel.TabIndex = 43;
            this.btnHealthPanel.Text = "Health";
            this.btnHealthPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHealthPanel.UseVisualStyleBackColor = true;
            this.btnHealthPanel.Visible = false;
            this.btnHealthPanel.Click += new System.EventHandler(this.btnHealthPanel_Click);
            // 
            // btnBotCredentials
            // 
            this.btnBotCredentials.FlatAppearance.BorderSize = 0;
            this.btnBotCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBotCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotCredentials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotCredentials.ForeColor = System.Drawing.Color.White;
            this.btnBotCredentials.Location = new System.Drawing.Point(10, 670);
            this.btnBotCredentials.Margin = new System.Windows.Forms.Padding(0);
            this.btnBotCredentials.Name = "btnBotCredentials";
            this.btnBotCredentials.Size = new System.Drawing.Size(90, 90);
            this.btnBotCredentials.TabIndex = 42;
            this.btnBotCredentials.Text = "Bot Info";
            this.btnBotCredentials.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBotCredentials.UseVisualStyleBackColor = true;
            this.btnBotCredentials.Click += new System.EventHandler(this.btnBotCredentials_Click);
            // 
            // btnSizePanel
            // 
            this.btnSizePanel.FlatAppearance.BorderSize = 0;
            this.btnSizePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSizePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizePanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizePanel.ForeColor = System.Drawing.Color.White;
            this.btnSizePanel.Location = new System.Drawing.Point(10, 230);
            this.btnSizePanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnSizePanel.Name = "btnSizePanel";
            this.btnSizePanel.Size = new System.Drawing.Size(90, 90);
            this.btnSizePanel.TabIndex = 41;
            this.btnSizePanel.Text = "Size";
            this.btnSizePanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSizePanel.UseVisualStyleBackColor = true;
            this.btnSizePanel.Visible = false;
            this.btnSizePanel.Click += new System.EventHandler(this.btnSizePanel_Click);
            // 
            // btnGravityPanel
            // 
            this.btnGravityPanel.FlatAppearance.BorderSize = 0;
            this.btnGravityPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGravityPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravityPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravityPanel.ForeColor = System.Drawing.Color.White;
            this.btnGravityPanel.Location = new System.Drawing.Point(10, 450);
            this.btnGravityPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btnGravityPanel.Name = "btnGravityPanel";
            this.btnGravityPanel.Size = new System.Drawing.Size(90, 90);
            this.btnGravityPanel.TabIndex = 40;
            this.btnGravityPanel.Text = "Gravity";
            this.btnGravityPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravityPanel.UseVisualStyleBackColor = true;
            this.btnGravityPanel.Visible = false;
            this.btnGravityPanel.Click += new System.EventHandler(this.btnGravityPanel_Click);
            // 
            // btnSpeedPanel
            // 
            this.btnSpeedPanel.FlatAppearance.BorderSize = 0;
            this.btnSpeedPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSpeedPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeedPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedPanel.ForeColor = System.Drawing.Color.White;
            this.btnSpeedPanel.Location = new System.Drawing.Point(10, 120);
            this.btnSpeedPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSpeedPanel.Name = "btnSpeedPanel";
            this.btnSpeedPanel.Size = new System.Drawing.Size(88, 90);
            this.btnSpeedPanel.TabIndex = 23;
            this.btnSpeedPanel.Text = "Speed";
            this.btnSpeedPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSpeedPanel.UseVisualStyleBackColor = true;
            this.btnSpeedPanel.Visible = false;
            this.btnSpeedPanel.Click += new System.EventHandler(this.btnSpeedPanel_Click);
            // 
            // btnLivesPanel
            // 
            this.btnLivesPanel.FlatAppearance.BorderSize = 0;
            this.btnLivesPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLivesPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivesPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivesPanel.ForeColor = System.Drawing.Color.White;
            this.btnLivesPanel.Location = new System.Drawing.Point(10, 10);
            this.btnLivesPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLivesPanel.Name = "btnLivesPanel";
            this.btnLivesPanel.Size = new System.Drawing.Size(90, 90);
            this.btnLivesPanel.TabIndex = 11;
            this.btnLivesPanel.Text = "Lives / Stars";
            this.btnLivesPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLivesPanel.UseVisualStyleBackColor = true;
            this.btnLivesPanel.Visible = false;
            this.btnLivesPanel.Click += new System.EventHandler(this.btnLivesPanel_Click);
            // 
            // imgSF
            // 
            this.imgSF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSF.Location = new System.Drawing.Point(496, 38);
            this.imgSF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgSF.Name = "imgSF";
            this.imgSF.Size = new System.Drawing.Size(95, 20);
            this.imgSF.TabIndex = 75;
            this.imgSF.TabStop = false;
            this.imgSF.Click += new System.EventHandler(this.imgSF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(543, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 78;
            this.label1.Text = "Updates on";
            // 
            // imgTwitch
            // 
            this.imgTwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTwitch.Location = new System.Drawing.Point(479, 41);
            this.imgTwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgTwitch.Name = "imgTwitch";
            this.imgTwitch.Size = new System.Drawing.Size(15, 16);
            this.imgTwitch.TabIndex = 77;
            this.imgTwitch.TabStop = false;
            // 
            // imgYoutube
            // 
            this.imgYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgYoutube.Location = new System.Drawing.Point(454, 41);
            this.imgYoutube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgYoutube.Name = "imgYoutube";
            this.imgYoutube.Size = new System.Drawing.Size(23, 16);
            this.imgYoutube.TabIndex = 76;
            this.imgYoutube.TabStop = false;
            // 
            // imgBMCSupport
            // 
            this.imgBMCSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBMCSupport.InitialImage = null;
            this.imgBMCSupport.Location = new System.Drawing.Point(25, 15);
            this.imgBMCSupport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBMCSupport.Name = "imgBMCSupport";
            this.imgBMCSupport.Size = new System.Drawing.Size(152, 43);
            this.imgBMCSupport.TabIndex = 74;
            this.imgBMCSupport.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgBMCSupport);
            this.panel1.Controls.Add(this.imgSF);
            this.panel1.Controls.Add(this.imgYoutube);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.imgTwitch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(110, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 78);
            this.panel1.TabIndex = 79;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.activePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainWindow";
            this.Text = "SOR4 VS Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBMCSupport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.Button btnSizePanel;
        private System.Windows.Forms.Button btnGravityPanel;
        public System.Windows.Forms.Button btnSpeedPanel;
        private System.Windows.Forms.Button btnLivesPanel;
        private System.Windows.Forms.Button btnBotCredentials;
        public System.Windows.Forms.PictureBox imgSF;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox imgTwitch;
        public System.Windows.Forms.PictureBox imgYoutube;
        public System.Windows.Forms.PictureBox imgBMCSupport;
        private System.Windows.Forms.Button btnHealthPanel;
        private System.Windows.Forms.Button btnCharPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

