using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    public partial class ChatRoomGUI : Form
    {
        Client client;
       
        public ChatRoomGUI(Client client)
        {
            this.client = client;
            
            InitializeComponent();
        }

        
        private void Send_Click(object sender, EventArgs e)
        {

           
            client.textwords = textBox.Text;
            client.thing = true;
            client.Send();
            textBox.Text = null;
           


        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //if(client.thing == true)
            //{
            //    textBox.Text = null;
            //}
            //client.thing = false;
            
        }

        private void ConvoBox_TextChanged(object sender, EventArgs e)
        {
            client.Recieve();
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
            
        }
    }
}
