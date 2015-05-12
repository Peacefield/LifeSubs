using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LifeSubsMetro
{
    public partial class GroupConversations : MetroForm
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        MainMenu mm;
        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();

            //populating listView:

                addMessage("FOTO", "BERICHT", Color.Orange);
                addMessage("FOTO", "TEST", Color.Blue);
                addMessage("FOTO", "NOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TEST", Color.Yellow);

            
        }

        private void addMessage(string sender, string msg, Color c)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Style.BackColor = Color.Wheat;
            cell1.Value = sender;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = c;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            dataGridView1.Rows.Add(dr);
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            mm.Visible = true;
        }

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm.Visible = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            addMessage("U",metroTextBox1.Text, Color.Blue);
            metroTextBox1.Text = "";
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(metroTextBox1.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ...";
            msg();
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(metroTextBox1.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                //textBox1.Text = textBox1.Text + Environment.NewLine + " >> " + readData;
                addMessage(readData,metroTextBox1.Text,Color.Orange);
        } 

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }


        
    }
}
