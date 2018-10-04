namespace Simon_Says2
{
    partial class EV3WIFI
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
            this.buttonForward = new System.Windows.Forms.Button();
            this.sendMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.receivedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.receivedMessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.sendMessageGroupBox.SuspendLayout();
            this.connectionGroupBox.SuspendLayout();
            this.receivedDataGroupBox.SuspendLayout();
            this.receivedMessagesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(125, 15);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(65, 40);
            this.buttonForward.TabIndex = 1;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.sendForwardButton_Click);
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.buttonBackward);
            this.sendMessageGroupBox.Controls.Add(this.buttonLeft);
            this.sendMessageGroupBox.Controls.Add(this.buttonRight);
            this.sendMessageGroupBox.Controls.Add(this.buttonForward);
            this.sendMessageGroupBox.Location = new System.Drawing.Point(10, 105);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Size = new System.Drawing.Size(299, 156);
            this.sendMessageGroupBox.TabIndex = 2;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "EV3 Move";
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(125, 95);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(65, 40);
            this.buttonBackward.TabIndex = 4;
            this.buttonBackward.Text = "Backward";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.sendBackwardButton_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(45, 55);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(65, 40);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.sendLeftButton_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(200, 55);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(65, 44);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.sendRightButton_Click);
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.label3);
            this.connectionGroupBox.Controls.Add(this.ipAddressBox);
            this.connectionGroupBox.Controls.Add(this.connectedDeviceLabel);
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Location = new System.Drawing.Point(10, 10);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(680, 86);
            this.connectionGroupBox.TabIndex = 3;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP address of EV3";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(45, 36);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(114, 20);
            this.ipAddressBox.TabIndex = 11;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(430, 20);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(145, 47);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(305, 50);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(305, 15);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // receivedDataGroupBox
            // 
            this.receivedDataGroupBox.Controls.Add(this.label2);
            this.receivedDataGroupBox.Controls.Add(this.angleTextBox);
            this.receivedDataGroupBox.Controls.Add(this.label1);
            this.receivedDataGroupBox.Controls.Add(this.distanceTextBox);
            this.receivedDataGroupBox.Location = new System.Drawing.Point(320, 275);
            this.receivedDataGroupBox.Name = "receivedDataGroupBox";
            this.receivedDataGroupBox.Size = new System.Drawing.Size(370, 75);
            this.receivedDataGroupBox.TabIndex = 4;
            this.receivedDataGroupBox.TabStop = false;
            this.receivedDataGroupBox.Text = "EV3 Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angle";
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(230, 40);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.Size = new System.Drawing.Size(90, 20);
            this.angleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(45, 40);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(90, 20);
            this.distanceTextBox.TabIndex = 0;
            // 
            // receivedMessagesGroupBox
            // 
            this.receivedMessagesGroupBox.Controls.Add(this.clearReceivedMessagesButton);
            this.receivedMessagesGroupBox.Controls.Add(this.receivedMessagesListBox);
            this.receivedMessagesGroupBox.Location = new System.Drawing.Point(320, 105);
            this.receivedMessagesGroupBox.Name = "receivedMessagesGroupBox";
            this.receivedMessagesGroupBox.Size = new System.Drawing.Size(370, 155);
            this.receivedMessagesGroupBox.TabIndex = 5;
            this.receivedMessagesGroupBox.TabStop = false;
            this.receivedMessagesGroupBox.Text = "EV3 message receive";
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(15, 120);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(350, 23);
            this.clearReceivedMessagesButton.TabIndex = 2;
            this.clearReceivedMessagesButton.Text = "Clear";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = true;
            this.clearReceivedMessagesButton.Click += new System.EventHandler(this.clearReceivedMessagesButton_Click);
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(15, 20);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(350, 95);
            this.receivedMessagesListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(320, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "version november 2017";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.commandBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EV3 message send";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(115, 75);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(10, 40);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(280, 20);
            this.commandBox.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.receivedMessagesGroupBox);
            this.Controls.Add(this.receivedDataGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.sendMessageGroupBox);
            this.Name = "Mainform";
            this.Text = "EV3 Remote Control Wifi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.sendMessageGroupBox.ResumeLayout(false);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.receivedDataGroupBox.ResumeLayout(false);
            this.receivedDataGroupBox.PerformLayout();
            this.receivedMessagesGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.GroupBox receivedDataGroupBox;
        private System.Windows.Forms.GroupBox receivedMessagesGroupBox;
        private System.Windows.Forms.ListBox receivedMessagesListBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clearReceivedMessagesButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressBox;
    }
}

