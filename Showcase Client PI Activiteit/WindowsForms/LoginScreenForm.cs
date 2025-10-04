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


        private void ConnectToServerButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || ipTextBox.Text == "") {
                ErrorLabel1.Text = "No name or IP addres was enterd";
                return;
            }

            if (Program.client.client != null && nameTextBox.Text != "") { 
                Messenger.SendInitializingMessage(nameTextBox.Text, Program.client.stream);
                return;
            }

            try
            {
                Program.client.ConnectToServer(ipTextBox.Text, 5000);
                Messenger.SendInitializingMessage(nameTextBox.Text, Program.client.stream);
            }
            catch {
                ErrorLabel1.Text = "Het IP-Addres is niet juist, probeer t nog een keer!";
            }
        }

        private void LoginScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
