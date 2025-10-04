using System.Windows.Forms;

namespace Showcase_Client_PI_Activiteit
{
    public partial class ChatroomForm : Form
    {
        public ChatroomForm()
        {
            InitializeComponent();
        }

        private void sendMsgToServerButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void messageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }
        private void SendMessage()
        {
            if (messageTextbox.Text != "")
            {
                Messenger.SendChatMessage(messageTextbox.Text, Program.client.stream);
                messageTextbox.Clear();
                ErrorLabelChat.Text = string.Empty;
            }
            else
            {
                ErrorLabelChat.Text = "The chatbox is empty";
            }
        }

        private void chatroomTextbox_TextChanged(object sender, EventArgs e)
        {
            if (chatroomTextbox.Text.Split('\n').Length > 7)
                chatroomTextbox.ScrollBars = ScrollBars.Vertical;
            else
                chatroomTextbox.ScrollBars = ScrollBars.Vertical;
        }

        private void ChatroomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
