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
            
            Font font = new System.Drawing.Font("Georgia", 15);

            dataGridOutput.DefaultCellStyle.Font =
                new Font(font, FontStyle.Regular);
            dataGridOutput.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font(dataGridOutput.DefaultCellStyle.Font.ToString(), 50);

            //populating listView:
            addMessage("FOTO", "BERICHT", Color.Orange);
            addMessage("FOTO", "TEST", Color.Blue);
            addMessage("FOTO", "NOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TEST", Color.Yellow);
            addMessage("FOTO", "BERICHT", Color.Orange);
            addMessage("FOTO", "TEST", Color.Blue);
            addMessage("FOTO", "NOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TEST", Color.Yellow);
            
            addMessage("Ik verstuur ook zelf iets", Color.Red);
        }

        private void addMessage(string msg, Color c)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = c;
            cell2.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            dataGridOutput.Rows.Add(dr);
        }

        private void addMessage(string sender, string msg, Color c)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = sender;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = c;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            dr.Height = 50;

            dataGridOutput.Rows.Add(dr);
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            mm.Visible = true;
        }

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "") return;
            addMessage(tbInput.Text, Color.Red);
            tbInput.Text = "";
            //byte[] outStream = System.Text.Encoding.ASCII.GetBytes(metroTextBox1.Text + "$");
            //serverStream.Write(outStream, 0, outStream.Length);
            //serverStream.Flush();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ...";
            msg();
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(tbInput.Text + "$");
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
                addMessage(readData,tbInput.Text,Color.Orange);
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
