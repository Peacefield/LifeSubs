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
        Socket sck;
        EndPoint epLocal, epRemote;
        string ownIpAddress;
        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            ownIpAddress = getOwnIp();
            ipLabel.Text = ownIpAddress;
            sendTile.Enabled = false;
            //populating listView:
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
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    addMessage("IEMAND", receivedMessage, Color.Orange);
                }

                byte[] buffer = new byte[1500];

                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

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

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            mm.Visible = true;
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

                sck.Send(msg);
                addMessage("IK", tbInput.Text, Color.PowderBlue);
                tbInput.Text = "";
            }
            catch (Exception exc)
            {
                addMessage("FOUT", exc.ToString(), Color.Red);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Text = "Bezig...";

            try
        {
                epLocal = new IPEndPoint(IPAddress.Parse(ownIpAddress), Convert.ToInt32(ownPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(friendIpTextBox.Text), Convert.ToInt32(otherPort.Text));
                sck.Bind(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                startBtn.Enabled = false;
                startBtn.Text = "Verbonden!";
                sendTile.Enabled = true;
        }
            catch (Exception ex)
        {
                addMessage("FOUT", ex.ToString(), Color.Red);
                startBtn.Text = "Start";
        } 

        }


        
    }
}
