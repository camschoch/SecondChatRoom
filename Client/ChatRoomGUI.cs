using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Client
{
    public partial class ChatRoomGUI : Form
    {
        Client client;
        public Thread RecievingMessages;
        public ChatRoomGUI(Client client)
        {
            this.client = client;
            this.RecievingMessages = new Thread(new ThreadStart(this.client.Recieve));
            InitializeComponent();
        }
        private void Send_Click(object sender, EventArgs e)
        {
            client.textwords = textBox.Text;
            client.thing = true;
            client.Send();
            textBox.Text = null;
            textBox_TextChanged(sender, e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void PeopleOnChat_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOnline_CheckedChanged(object sender, EventArgs e)
        {
            this.RecievingMessages.Start();
            
        }

        private void chatBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
