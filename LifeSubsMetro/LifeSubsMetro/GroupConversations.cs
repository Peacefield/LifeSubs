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

namespace LifeSubsMetro
{
    public partial class GroupConversations : MetroForm
    {
        MainMenu mm;
        Socket sck1, sck2;
        EndPoint epLocal, epRemote;
        string ownIpAddress;
        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();

            sck1 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck1.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            sck2 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck2.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            ownIpAddress = getOwnIp();
            ipLabel.Text = ownIpAddress;
            friendIpTextBox.Text = ownIpAddress;
            ownPort.Text = "80";
            otherPort.Text = "81";
            sendTile.Enabled = false;
            //populating listView:

                addMessage("FOTO", "BERICHT", Color.Orange);
                addMessage("FOTO", "TEST", Color.Blue);
                addMessage("FOTO", "NOG EEN TEST", Color.Yellow);


            
        }

        private string getOwnIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            Console.WriteLine(host);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";

        }

        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck2.EndReceiveFrom(aResult, ref epRemote);
                
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    addMessage("IEMAND", receivedMessage, Color.Orange);
                }

                byte[] buffer = new byte[1500];

                sck2.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

            }
            catch (Exception e)
            {
                addMessage("FOUT", e.ToString(), Color.Red);
            }
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
            try
            {
                

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(metroTextBox1.Text);
                //sck1.Send(msg);

                /*******************************/
                SocketAsyncEventArgs h = new SocketAsyncEventArgs();
                h.SetBuffer(msg, 0, msg.Length);
                h.Completed += new EventHandler<SocketAsyncEventArgs>(SendCallback);

                bool completedAsync = false;

                try
                {
                    completedAsync = sck1.SendAsync(h);
                }
                catch (SocketException se)
                {
                    Console.WriteLine("Socket Exception: " + se.ErrorCode + " Message: " + se.Message);
                }

                /*************************************/
                addMessage("IK", metroTextBox1.Text, Color.PowderBlue);
                metroTextBox1.Text = "";
            }
            catch (Exception exc)
            {
                addMessage("FOUT", exc.ToString(), Color.Red);
                Console.WriteLine(exc);
            }
        }


        private void SendCallback(object sender, SocketAsyncEventArgs e)
        {
            if (e.SocketError == SocketError.Success)
            {
                // You may need to specify some type of state and 
                // pass it into the BeginSend method so you don't start
                // sending from scratch
                //BeginSend();
            }
            else
            {
                //Console.WriteLine("Socket Error: {0} when sending to {1}",
                //       e.SocketError,
                //       _asyncTask.Host);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Text = "Bezig...";

            try
            {


                epLocal = new IPEndPoint(IPAddress.Parse(ipLabel.Text), int.Parse(ownPort.Text));
                Console.WriteLine(IPAddress.Parse(ipLabel.Text) + "<------ EIGEN IP");
                Console.WriteLine(Convert.ToInt32(ownPort.Text) + "<------ EIGEN POORT");
                sck1.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(friendIpTextBox.Text), int.Parse(otherPort.Text));
                Console.WriteLine(IPAddress.Parse(friendIpTextBox.Text) + "<------ ANDER IP");
                Console.WriteLine(Convert.ToInt32(otherPort.Text) + "<------ ANDER POORT");
                sck2.Bind(epRemote);

                byte[] buffer = new byte[1500];
                //sck2.Listen(100);
                //sck2.Accept();
                
                /****************/

                SocketAsyncEventArgs d = new SocketAsyncEventArgs();
                d.Completed += receiveCompleted;
                d.SetBuffer(new byte[1024], 0, 1024);
                if (!sck2.ReceiveAsync(d)) { receiveCompleted(this, d); } 
                /******************************/

                //sck2.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                startBtn.Enabled = false;
                startBtn.Text = "Verbonden!";
                sendTile.Enabled = true;
            }
            catch (Exception ex)
            {
                addMessage("FOUT", ex.ToString(), Color.Red);
                startBtn.Text = "Start";
                Console.WriteLine(ex);
            }



        }

        public void receiveCompleted(object sender, SocketAsyncEventArgs e)
        {
            ////ProcessData(e);

            //if (!Socket.ReceiveAsync(e)) { receiveCompleted(this, e); }
        }
        
    }
}
