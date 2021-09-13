namespace SOR4VSChat.panels.subpanels
{
    partial class PanelLives
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
            this.chk_life1 = new System.Windows.Forms.CheckBox();
            this.chk_life0 = new System.Windows.Forms.CheckBox();
            this.chk_life = new System.Windows.Forms.CheckBox();
            this.chk_star = new System.Windows.Forms.CheckBox();
            this.chk_star0 = new System.Windows.Forms.CheckBox();
            this.chk_star1 = new System.Windows.Forms.CheckBox();
            this.txt_life1 = new System.Windows.Forms.TextBox();
            this.txt_life0 = new System.Windows.Forms.TextBox();
            this.txt_life = new System.Windows.Forms.TextBox();
            this.txt_star1 = new System.Windows.Forms.TextBox();
            this.txt_star0 = new System.Windows.Forms.TextBox();
            this.txt_star = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_life1param = new System.Windows.Forms.CheckBox();
            this.chk_life0param = new System.Windows.Forms.CheckBox();
            this.chk_star1param = new System.Windows.Forms.CheckBox();
            this.chk_star0param = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_life_cooldown = new System.Windows.Forms.NumericUpDown();
            this.txt_star_cooldown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_life_cooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_star_cooldown)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_life1
            // 
            this.chk_life1.AutoSize = true;
            this.chk_life1.Location = new System.Drawing.Point(37, 90);
            this.chk_life1.Name = "chk_life1";
            this.chk_life1.Size = new System.Drawing.Size(59, 19);
            this.chk_life1.TabIndex = 8;
            this.chk_life1.Text = "!lifeup";
            this.chk_life1.UseVisualStyleBackColor = true;
            // 
            // chk_life0
            // 
            this.chk_life0.AutoSize = true;
            this.chk_life0.Location = new System.Drawing.Point(37, 124);
            this.chk_life0.Name = "chk_life0";
            this.chk_life0.Size = new System.Drawing.Size(75, 19);
            this.chk_life0.TabIndex = 9;
            this.chk_life0.Text = "!lifedown";
            this.chk_life0.UseVisualStyleBackColor = true;
            // 
            // chk_life
            // 
            this.chk_life.AutoSize = true;
            this.chk_life.Checked = true;
            this.chk_life.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_life.Location = new System.Drawing.Point(37, 57);
            this.chk_life.Name = "chk_life";
            this.chk_life.Size = new System.Drawing.Size(112, 19);
            this.chk_life.TabIndex = 7;
            this.chk_life.Text = "!life (randomize)";
            this.chk_life.UseVisualStyleBackColor = true;
            // 
            // chk_star
            // 
            this.chk_star.AutoSize = true;
            this.chk_star.Checked = true;
            this.chk_star.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_star.Location = new System.Drawing.Point(37, 268);
            this.chk_star.Name = "chk_star";
            this.chk_star.Size = new System.Drawing.Size(115, 19);
            this.chk_star.TabIndex = 10;
            this.chk_star.Text = "!star (randomize)";
            this.chk_star.UseVisualStyleBackColor = true;
            // 
            // chk_star0
            // 
            this.chk_star0.AutoSize = true;
            this.chk_star0.Location = new System.Drawing.Point(37, 334);
            this.chk_star0.Name = "chk_star0";
            this.chk_star0.Size = new System.Drawing.Size(88, 19);
            this.chk_star0.TabIndex = 12;
            this.chk_star0.Text = "!removestar";
            this.chk_star0.UseVisualStyleBackColor = true;
            // 
            // chk_star1
            // 
            this.chk_star1.AutoSize = true;
            this.chk_star1.Location = new System.Drawing.Point(37, 301);
            this.chk_star1.Name = "chk_star1";
            this.chk_star1.Size = new System.Drawing.Size(68, 19);
            this.chk_star1.TabIndex = 11;
            this.chk_star1.Text = "!addstar";
            this.chk_star1.UseVisualStyleBackColor = true;
            // 
            // txt_life1
            // 
            this.txt_life1.Location = new System.Drawing.Point(275, 88);
            this.txt_life1.Name = "txt_life1";
            this.txt_life1.Size = new System.Drawing.Size(289, 23);
            this.txt_life1.TabIndex = 2;
            this.txt_life1.Text = "Gained a life";
            // 
            // txt_life0
            // 
            this.txt_life0.Location = new System.Drawing.Point(275, 122);
            this.txt_life0.Name = "txt_life0";
            this.txt_life0.Size = new System.Drawing.Size(289, 23);
            this.txt_life0.TabIndex = 3;
            this.txt_life0.Text = "Lost a life";
            // 
            // txt_life
            // 
            this.txt_life.Location = new System.Drawing.Point(275, 55);
            this.txt_life.Name = "txt_life";
            this.txt_life.Size = new System.Drawing.Size(289, 23);
            this.txt_life.TabIndex = 1;
            this.txt_life.Visible = false;
            // 
            // txt_star1
            // 
            this.txt_star1.Location = new System.Drawing.Point(275, 299);
            this.txt_star1.Name = "txt_star1";
            this.txt_star1.Size = new System.Drawing.Size(289, 23);
            this.txt_star1.TabIndex = 5;
            this.txt_star1.Text = "Gained a star";
            // 
            // txt_star0
            // 
            this.txt_star0.Location = new System.Drawing.Point(275, 332);
            this.txt_star0.Name = "txt_star0";
            this.txt_star0.Size = new System.Drawing.Size(289, 23);
            this.txt_star0.TabIndex = 6;
            this.txt_star0.Text = "Lost a star";
            // 
            // txt_star
            // 
            this.txt_star.Location = new System.Drawing.Point(275, 266);
            this.txt_star.Name = "txt_star";
            this.txt_star.Size = new System.Drawing.Size(289, 23);
            this.txt_star.TabIndex = 4;
            this.txt_star.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Enable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bot Response";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, -6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "LIVES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "STARS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Bot Response";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Enable";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(16, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(559, 2);
            this.label13.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 75);
            this.label1.TabIndex = 74;
            this.label1.Text = "Chat Variables:\r\n{current} - character lives/stars\r\n\r\nExample: I have {current} s" +
    "tars now\r\nResult:     I have 4 stars now";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Accept Values";
            // 
            // chk_life1param
            // 
            this.chk_life1param.AutoSize = true;
            this.chk_life1param.Location = new System.Drawing.Point(196, 92);
            this.chk_life1param.Name = "chk_life1param";
            this.chk_life1param.Size = new System.Drawing.Size(15, 14);
            this.chk_life1param.TabIndex = 76;
            this.chk_life1param.UseVisualStyleBackColor = true;
            // 
            // chk_life0param
            // 
            this.chk_life0param.AutoSize = true;
            this.chk_life0param.Location = new System.Drawing.Point(196, 126);
            this.chk_life0param.Name = "chk_life0param";
            this.chk_life0param.Size = new System.Drawing.Size(15, 14);
            this.chk_life0param.TabIndex = 77;
            this.chk_life0param.UseVisualStyleBackColor = true;
            // 
            // chk_star1param
            // 
            this.chk_star1param.AutoSize = true;
            this.chk_star1param.Location = new System.Drawing.Point(196, 303);
            this.chk_star1param.Name = "chk_star1param";
            this.chk_star1param.Size = new System.Drawing.Size(15, 14);
            this.chk_star1param.TabIndex = 78;
            this.chk_star1param.UseVisualStyleBackColor = true;
            // 
            // chk_star0param
            // 
            this.chk_star0param.AutoSize = true;
            this.chk_star0param.Location = new System.Drawing.Point(196, 336);
            this.chk_star0param.Name = "chk_star0param";
            this.chk_star0param.Size = new System.Drawing.Size(15, 14);
            this.chk_star0param.TabIndex = 79;
            this.chk_star0param.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "LIFE commands cooldown (in seconds)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "STAR commands cooldown (in seconds)";
            // 
            // txt_life_cooldown
            // 
            this.txt_life_cooldown.Location = new System.Drawing.Point(275, 156);
            this.txt_life_cooldown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.txt_life_cooldown.Name = "txt_life_cooldown";
            this.txt_life_cooldown.Size = new System.Drawing.Size(70, 23);
            this.txt_life_cooldown.TabIndex = 86;
            // 
            // txt_star_cooldown
            // 
            this.txt_star_cooldown.Location = new System.Drawing.Point(275, 367);
            this.txt_star_cooldown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.txt_star_cooldown.Name = "txt_star_cooldown";
            this.txt_star_cooldown.Size = new System.Drawing.Size(70, 23);
            this.txt_star_cooldown.TabIndex = 87;
            // 
            // PanelLives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 513);
            this.Controls.Add(this.txt_star_cooldown);
            this.Controls.Add(this.txt_life_cooldown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk_star0param);
            this.Controls.Add(this.chk_star1param);
            this.Controls.Add(this.chk_life0param);
            this.Controls.Add(this.chk_life1param);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_star);
            this.Controls.Add(this.txt_star0);
            this.Controls.Add(this.txt_star1);
            this.Controls.Add(this.txt_life);
            this.Controls.Add(this.txt_life0);
            this.Controls.Add(this.txt_life1);
            this.Controls.Add(this.chk_star);
            this.Controls.Add(this.chk_star0);
            this.Controls.Add(this.chk_star1);
            this.Controls.Add(this.chk_life);
            this.Controls.Add(this.chk_life0);
            this.Controls.Add(this.chk_life1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelLives";
            this.Text = "6";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLives_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelLives_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.txt_life_cooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_star_cooldown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.CheckBox chk_life1;
        public System.Windows.Forms.CheckBox chk_life0;
        public System.Windows.Forms.CheckBox chk_life;
        public System.Windows.Forms.CheckBox chk_star;
        public System.Windows.Forms.CheckBox chk_star0;
        public System.Windows.Forms.CheckBox chk_star1;
        public System.Windows.Forms.TextBox txt_life1;
        public System.Windows.Forms.TextBox txt_life0;
        public System.Windows.Forms.TextBox txt_life;
        public System.Windows.Forms.TextBox txt_star1;
        public System.Windows.Forms.TextBox txt_star0;
        public System.Windows.Forms.TextBox txt_star;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_life1param;
        private System.Windows.Forms.CheckBox chk_life0param;
        private System.Windows.Forms.CheckBox chk_star1param;
        private System.Windows.Forms.CheckBox chk_star0param;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown txt_life_cooldown;
        private System.Windows.Forms.NumericUpDown txt_star_cooldown;
    }
}