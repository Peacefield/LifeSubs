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
        Socket listenSocket, sendSocket;
        EndPoint epLocal, epRemote;
        UdpListener listener;
        string ownIpAddress;
        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();

            //listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //listenSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sendSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            ownIpAddress = getOwnIp();
            ipLabel.Text = ownIpAddress;
            friendIpTextBox.Text = ownIpAddress;
            ownPort.Text = "11000";
            otherPort.Text = "11001";
            sendTile.Enabled = false;
            //populating listView:
            Font font = new System.Drawing.Font("Georgia", 15);

            dataGridOutput.DefaultCellStyle.Font =
                new Font(font, FontStyle.Regular);
            dataGridOutput.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font(dataGridOutput.DefaultCellStyle.Font.ToString(), 50);

            //populating listView:
            //    addMessage("FOTO", "BERICHT", Color.Orange);
            //    addMessage("FOTO", "TEST", Color.Blue);
            //addMessage("FOTO", "NOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TEST", Color.Yellow);
            //addMessage("FOTO", "BERICHT", Color.Orange);
            //addMessage("FOTO", "TEST", Color.Blue);
            //addMessage("FOTO", "NOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TESTNOG EEN TEST", Color.Yellow);

            //addMessage("Ik verstuur ook zelf iets", Color.Red);
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
            addMessage("--->", "DATA ONTVANGEN", Color.Green);
            try
            {
                int size = sendSocket.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    addMessage("IEMAND", receivedMessage, Color.Orange);
                }

                byte[] buffer = new byte[1500];

                sendSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
                Console.WriteLine("BINNENGEKREGEN");
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
            cell1.Value = sender;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = c;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            dr.Height = 50;

            dataGridOutput.Rows.Add(dr);
        }

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm.Visible = true;
        }

        private void sendTile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(tbInput.Text);
                //sck1.Send(msg);
                string msgtext = tbInput.Text;
                /*******************************/
                SocketAsyncEventArgs h = new SocketAsyncEventArgs();
                h.SetBuffer(msg, 0, msg.Length);
                h.Completed += new EventHandler<SocketAsyncEventArgs>(SendCallback);

                //bool completedAsync = false;

                try
                {
                    sendSocket.SendAsync(h);
                    Console.WriteLine("async gelukt");
                    
                }
                catch (SocketException se)
                {
                    Console.WriteLine("Socket Exception: " + se.ErrorCode + " Message: " + se.Message);
                }

                /*************************************/
                addMessage(tbInput.Text, Color.PowderBlue);
                tbInput.Text = "";
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
                addMessage("ANDER", "test", Color.Green);
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


                //epLocal = new IPEndPoint(IPAddress.Parse(ipLabel.Text), Convert.ToInt32(ownPort.Text));
                //Console.WriteLine(IPAddress.Parse(ipLabel.Text) + "<------ EIGEN IP");
                //Console.WriteLine(Convert.ToInt32(ownPort.Text) + "<------ EIGEN POORT");
                //listenSocket.Bind(epLocal);

                listener = new UdpListener(int.Parse(ownPort.Text), ipLabel.Text);
                epRemote = new IPEndPoint(IPAddress.Parse(friendIpTextBox.Text), Convert.ToInt32(otherPort.Text));
                Console.WriteLine(IPAddress.Parse(friendIpTextBox.Text) + "<------ ANDER IP");
                Console.WriteLine(Convert.ToInt32(otherPort.Text) + "<------ ANDER POORT");
                sendSocket.Bind(epRemote);

                byte[] buffer = new byte[1024];
                sendSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);


                //sck2.Accept();
                
                /****************/

                SocketAsyncEventArgs d = new SocketAsyncEventArgs();
                d.Completed += receiveCompleted;
                d.SetBuffer(new byte[1024], 0, 1024);
                if (!sendSocket.ReceiveAsync(d)) 
                { 
                    receiveCompleted(this, d);
                } 
                else
                {
                    Console.WriteLine("<<ONTVANGEN>>");
                    Console.WriteLine(d.ToString());
                }
                /******************************/

                
               
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
            //ProcessData(e);
            addMessage("TEST", "|TEST", Color.GhostWhite);
            //if (!Socket.ReceiveAsync(e)) { receiveCompleted(this, e); }
        }
        
    }
}
