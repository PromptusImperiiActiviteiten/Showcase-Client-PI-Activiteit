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
        bool darkModeOn = false;

        public LoginScreenForm()
        {
            InitializeComponent();
        }


        private void connectToServerButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && ipTextBox.Text != "")
            {
                ChatroomForm frm = new ChatroomForm();
                frm.Show();
                this.Hide();

                Program.client.ConnectToServer(ipTextBox.Text, 5000);
                Thread thread1 = new Thread(() => Program.client.ReadMessages(frm));
                thread1.IsBackground = true;
                thread1.Start();
                Program.client.SendInitializingMessage(nameTextBox.Text);
            }
            else
            {
                ErrorLabel1.Text = "No name or IP addres was enterd";
            }
        }

        private void LoginScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
