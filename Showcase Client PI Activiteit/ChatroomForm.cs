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


        private void messageTextbox_Click(object sender, EventArgs e)
        {
            messageTextbox.Clear();
            messageTextbox.ForeColor = Color.Black;
        }

        private void messageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
        private void SendMessage()
        {
            if (messageTextbox.Text != "" && messageTextbox.Text != "Enter something to send to server")
            {
                Program.client.SendMessage(messageTextbox.Text);
                messageTextbox.Clear();


            }
        }
    }
}
