namespace CSS490_chat
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
            this.myIP = new System.Windows.Forms.TextBox();
            this.myPort = new System.Windows.Forms.TextBox();
            this.otherIP = new System.Windows.Forms.TextBox();
            this.friendPort = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bigTextBox = new System.Windows.Forms.ListBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(88, 20);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(100, 22);
            this.myIP.TabIndex = 0;
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(88, 65);
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(100, 22);
            this.myPort.TabIndex = 1;
            // 
            // otherIP
            // 
            this.otherIP.Location = new System.Drawing.Point(275, 20);
            this.otherIP.Name = "otherIP";
            this.otherIP.Size = new System.Drawing.Size(100, 22);
            this.otherIP.TabIndex = 2;
            // 
            // friendPort
            // 
            this.friendPort.Location = new System.Drawing.Point(275, 65);
            this.friendPort.Name = "friendPort";
            this.friendPort.Size = new System.Drawing.Size(100, 22);
            this.friendPort.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(526, 29);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(88, 110);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(535, 78);
            this.outBox.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(664, 110);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "my IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "my port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "friend\'s IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "friend\'s port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message to send here";
            // 
            // bigTextBox
            // 
            this.bigTextBox.FormattingEnabled = true;
            this.bigTextBox.HorizontalScrollbar = true;
            this.bigTextBox.ItemHeight = 16;
            this.bigTextBox.Location = new System.Drawing.Point(230, 197);
            this.bigTextBox.Name = "bigTextBox";
            this.bigTextBox.Size = new System.Drawing.Size(558, 244);
            this.bigTextBox.TabIndex = 13;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(12, 194);
            this.ipBox.Multiline = true;
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(212, 244);
            this.ipBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.bigTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.friendPort);
            this.Controls.Add(this.otherIP);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.myIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myIP;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.TextBox otherIP;
        private System.Windows.Forms.TextBox friendPort;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox bigTextBox;
        private System.Windows.Forms.TextBox ipBox;
    }
}

