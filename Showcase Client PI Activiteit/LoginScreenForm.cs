using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showcase_Client_PI_Activiteit
{

    public partial class LoginScreenForm : Form
    {

        public LoginScreenForm()
        {
            InitializeComponent();
        }


        private void connectToServerButton_Click(object sender, EventArgs e)
        {
            ChatroomForm frm = new ChatroomForm();
            frm.Show();
            this.Hide();

            Program.client.ConnectToServer(ipTextBox.Text, 5000);
            Thread thread1 = new Thread(() => Program.client.ReadMessages(frm));
            thread1.Start();
            Program.client.SendInitializingMessage(nameTextBox.Text);
        }
    }
}
