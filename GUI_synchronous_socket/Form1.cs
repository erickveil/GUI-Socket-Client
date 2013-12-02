using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GUI_synchronous_socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bu_send_Click(object sender, EventArgs e)
        {
            Thread send_client = new Thread(launchClient);
            send_client.IsBackground = true;
            send_client.Start();
        }

        public void launchClient()
        {
            SynchronousSocketClient com_client = new SynchronousSocketClient();
            com_client.StartClient();
        }

    }
}
