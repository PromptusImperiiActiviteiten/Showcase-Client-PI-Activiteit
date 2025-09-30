namespace Showcase_Client_PI_Activiteit
{
    partial class ChatroomForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatroomForm));
            label1 = new Label();
            messageTextbox = new TextBox();
            sendMsgToServerButton = new Button();
            chatroomTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(652, 50);
            label1.TabIndex = 0;
            label1.Text = "PI Client Application";
            // 
            // messageTextbox
            // 
            messageTextbox.BorderStyle = BorderStyle.FixedSingle;
            messageTextbox.Font = new Font("Lucida Console", 19F);
            messageTextbox.ForeColor = SystemColors.InactiveCaption;
            messageTextbox.Location = new Point(192, 568);
            messageTextbox.Name = "messageTextbox";
            messageTextbox.Size = new Size(725, 39);
            messageTextbox.TabIndex = 1;
            messageTextbox.Text = "Enter something to send to server";
            messageTextbox.Click += messageTextbox_Click;
            messageTextbox.KeyDown += messageTextbox_KeyDown;
            // 
            // sendMsgToServerButton
            // 
            sendMsgToServerButton.Font = new Font("Lucida Console", 19F);
            sendMsgToServerButton.Location = new Point(963, 568);
            sendMsgToServerButton.Name = "sendMsgToServerButton";
            sendMsgToServerButton.Size = new Size(114, 39);
            sendMsgToServerButton.TabIndex = 3;
            sendMsgToServerButton.Text = "Send";
            sendMsgToServerButton.UseVisualStyleBackColor = true;
            sendMsgToServerButton.Click += sendMsgToServerButton_Click;
            // 
            // chatroomTextbox
            // 
            chatroomTextbox.BorderStyle = BorderStyle.FixedSingle;
            chatroomTextbox.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chatroomTextbox.Location = new Point(147, 76);
            chatroomTextbox.Multiline = true;
            chatroomTextbox.Name = "chatroomTextbox";
            chatroomTextbox.ReadOnly = true;
            chatroomTextbox.ScrollBars = ScrollBars.Both;
            chatroomTextbox.Size = new Size(986, 470);
            chatroomTextbox.TabIndex = 4;
            // 
            // ChatroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1262, 673);
            Controls.Add(chatroomTextbox);
            Controls.Add(sendMsgToServerButton);
            Controls.Add(messageTextbox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChatroomForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox messageTextbox;
        private Button sendMsgToServerButton;
        public TextBox chatroomTextbox;
        public Label label1;
    }
}
