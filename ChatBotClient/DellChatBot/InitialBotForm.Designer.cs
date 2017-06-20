namespace DellChatBot
{
    partial class InitialBotForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.chatLbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(88, 13);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Chat Bot Initiated";
            // 
            // chatLbl1
            // 
            this.chatLbl1.AutoSize = true;
            this.chatLbl1.Location = new System.Drawing.Point(163, 92);
            this.chatLbl1.Name = "chatLbl1";
            this.chatLbl1.Size = new System.Drawing.Size(35, 13);
            this.chatLbl1.TabIndex = 1;
            this.chatLbl1.Text = "label1";
            // 
            // InitialBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 202);
            this.Controls.Add(this.chatLbl1);
            this.Controls.Add(this.messageLabel);
            this.Name = "InitialBotForm";
            this.Text = "Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label chatLbl1;
    }
}

