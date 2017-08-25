namespace ChatRoom
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.PeopleOnChat = new System.Windows.Forms.ListView();
            this.PeopleOnline = new System.Windows.Forms.TextBox();
            this.ConvoBox = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.CheckOnline = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 429);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(977, 56);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(1010, 428);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(231, 57);
            this.Send.TabIndex = 1;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeopleOnChat
            // 
            this.PeopleOnChat.Location = new System.Drawing.Point(1010, 57);
            this.PeopleOnChat.Name = "PeopleOnChat";
            this.PeopleOnChat.Size = new System.Drawing.Size(244, 374);
            this.PeopleOnChat.TabIndex = 2;
            this.PeopleOnChat.UseCompatibleStateImageBehavior = false;
            // 
            // PeopleOnline
            // 
            this.PeopleOnline.BackColor = System.Drawing.SystemColors.ControlText;
            this.PeopleOnline.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeopleOnline.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeopleOnline.Location = new System.Drawing.Point(1022, 3);
            this.PeopleOnline.Name = "PeopleOnline";
            this.PeopleOnline.Size = new System.Drawing.Size(219, 48);
            this.PeopleOnline.TabIndex = 3;
            this.PeopleOnline.Text = "People Online";
            this.PeopleOnline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvoBox
            // 
            this.ConvoBox.Location = new System.Drawing.Point(13, 96);
            this.ConvoBox.Name = "ConvoBox";
            this.ConvoBox.Size = new System.Drawing.Size(977, 326);
            this.ConvoBox.TabIndex = 4;
            this.ConvoBox.Text = "";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(933, 21);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 48);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // CheckOnline
            // 
            this.CheckOnline.AutoSize = true;
            this.CheckOnline.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOnline.Location = new System.Drawing.Point(13, 28);
            this.CheckOnline.Name = "CheckOnline";
            this.CheckOnline.Size = new System.Drawing.Size(98, 32);
            this.CheckOnline.TabIndex = 6;
            this.CheckOnline.Text = "Online";
            this.CheckOnline.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 62);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fancy Chat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckOnline);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConvoBox);
            this.Controls.Add(this.PeopleOnline);
            this.Controls.Add(this.PeopleOnChat);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ChatRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListView PeopleOnChat;
        private System.Windows.Forms.TextBox PeopleOnline;
        private System.Windows.Forms.RichTextBox ConvoBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox CheckOnline;
        private System.Windows.Forms.Label label1;
    }
}

