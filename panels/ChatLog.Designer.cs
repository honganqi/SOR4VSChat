
namespace SOR4VSChat.panels
{
    partial class ChatLog
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
            this.txtChatLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtChatLog
            // 
            this.txtChatLog.BackColor = System.Drawing.Color.Black;
            this.txtChatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChatLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatLog.ForeColor = System.Drawing.Color.White;
            this.txtChatLog.Location = new System.Drawing.Point(0, 0);
            this.txtChatLog.MaxLength = 30;
            this.txtChatLog.Multiline = true;
            this.txtChatLog.Name = "txtChatLog";
            this.txtChatLog.ReadOnly = true;
            this.txtChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatLog.Size = new System.Drawing.Size(352, 450);
            this.txtChatLog.TabIndex = 0;
            // 
            // ChatLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.txtChatLog);
            this.Name = "ChatLog";
            this.ShowIcon = false;
            this.Text = "SOR4 VS Chat Command Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatLog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtChatLog;
    }
}