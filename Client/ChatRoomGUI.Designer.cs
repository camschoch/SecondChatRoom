namespace Client
{
    partial class ChatRoomGUI
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
            this.CheckOnline = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.PeopleOnline = new System.Windows.Forms.TextBox();
            this.PeopleOnChat = new System.Windows.Forms.ListView();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckOnline
            // 
            this.CheckOnline.AutoSize = true;
            this.CheckOnline.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOnline.Location = new System.Drawing.Point(26, 8);
            this.CheckOnline.Name = "CheckOnline";
            this.CheckOnline.Size = new System.Drawing.Size(98, 32);
            this.CheckOnline.TabIndex = 10;
            this.CheckOnline.Text = "Online";
            this.CheckOnline.UseVisualStyleBackColor = true;
            this.CheckOnline.CheckedChanged += new System.EventHandler(this.CheckOnline_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 62);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fancy Chat";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(960, 24);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 48);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PeopleOnline
            // 
            this.PeopleOnline.BackColor = System.Drawing.SystemColors.ControlText;
            this.PeopleOnline.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleOnline.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeopleOnline.Location = new System.Drawing.Point(1052, -3);
            this.PeopleOnline.Name = "PeopleOnline";
            this.PeopleOnline.Size = new System.Drawing.Size(219, 48);
            this.PeopleOnline.TabIndex = 14;
            this.PeopleOnline.Text = "People Online";
            this.PeopleOnline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PeopleOnChat
            // 
            this.PeopleOnChat.Location = new System.Drawing.Point(1037, 54);
            this.PeopleOnChat.Name = "PeopleOnChat";
            this.PeopleOnChat.Size = new System.Drawing.Size(244, 374);
            this.PeopleOnChat.TabIndex = 15;
            this.PeopleOnChat.UseCompatibleStateImageBehavior = false;
            this.PeopleOnChat.SelectedIndexChanged += new System.EventHandler(this.PeopleOnChat_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(26, 434);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(977, 56);
            this.textBox.TabIndex = 17;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1040, 434);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(231, 57);
            this.Send.TabIndex = 18;
            this.Send.Tag = "client.Send";
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(26, 78);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(977, 330);
            this.chatBox.TabIndex = 20;
            // 
            // ChatRoomGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 504);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.PeopleOnChat);
            this.Controls.Add(this.PeopleOnline);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckOnline);
            this.Name = "ChatRoomGUI";
            this.Text = "ChatRoomGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckOnline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PeopleOnline;
        private System.Windows.Forms.ListView PeopleOnChat;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Send;
        public System.Windows.Forms.TextBox chatBox;
    }
}