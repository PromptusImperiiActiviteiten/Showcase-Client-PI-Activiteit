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

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            (new Form1()).Show();
            this.Hide();

            Program.client.ConnectToServer(textBox2.Text, 5000);
            Thread thread1 = new Thread(() => Program.client.ReadMessages());
            thread1.Start();
        }
    }
}
