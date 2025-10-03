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
            headerChatroom = new Label();
            messageTextbox = new TextBox();
            sendMsgToServerButton = new Button();
            chatroomTextbox = new TextBox();
            menuStrip1 = new MenuStrip();
            ErrorLabelChat = new Label();
            SuspendLayout();
            // 
            // headerChatroom
            // 
            headerChatroom.AutoSize = true;
            headerChatroom.Font = new Font("Lucida Console", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerChatroom.Location = new Point(313, 37);
            headerChatroom.Name = "headerChatroom";
            headerChatroom.Size = new Size(652, 50);
            headerChatroom.TabIndex = 0;
            headerChatroom.Text = "PI Client Application";
            // 
            // messageTextbox
            // 
            messageTextbox.BorderStyle = BorderStyle.FixedSingle;
            messageTextbox.Font = new Font("Lucida Console", 19F);
            messageTextbox.ForeColor = SystemColors.ControlText;
            messageTextbox.Location = new Point(197, 609);
            messageTextbox.Name = "messageTextbox";
            messageTextbox.PlaceholderText = "Enter something to send to server";
            messageTextbox.Size = new Size(725, 39);
            messageTextbox.TabIndex = 1;
            messageTextbox.KeyDown += messageTextbox_KeyDown;
            // 
            // sendMsgToServerButton
            // 
            sendMsgToServerButton.Font = new Font("Lucida Console", 19F);
            sendMsgToServerButton.Location = new Point(966, 609);
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
            chatroomTextbox.Location = new Point(146, 104);
            chatroomTextbox.Multiline = true;
            chatroomTextbox.Name = "chatroomTextbox";
            chatroomTextbox.ReadOnly = true;
            chatroomTextbox.ScrollBars = ScrollBars.Both;
            chatroomTextbox.Size = new Size(986, 470);
            chatroomTextbox.TabIndex = 4;
            chatroomTextbox.TextChanged += chatroomTextbox_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // ErrorLabelChat
            // 
            ErrorLabelChat.AutoSize = true;
            ErrorLabelChat.ForeColor = Color.Red;
            ErrorLabelChat.Location = new Point(197, 586);
            ErrorLabelChat.Name = "ErrorLabelChat";
            ErrorLabelChat.Size = new Size(0, 20);
            ErrorLabelChat.TabIndex = 6;
            // 
            // ChatroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1262, 673);
            Controls.Add(ErrorLabelChat);
            Controls.Add(menuStrip1);
            Controls.Add(chatroomTextbox);
            Controls.Add(sendMsgToServerButton);
            Controls.Add(messageTextbox);
            Controls.Add(headerChatroom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChatroomForm";
            Text = "Chatroom";
            FormClosing += ChatroomForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox messageTextbox;
        private Button sendMsgToServerButton;
        public TextBox chatroomTextbox;
        public Label headerChatroom;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem darkmodeToolStripMenuItem;
        private Label ErrorLabelChat;
    }
}
