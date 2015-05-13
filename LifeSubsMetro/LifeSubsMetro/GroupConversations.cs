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
        
        string ownIpAddress;
        public delegate void IMErrorEventHandler(object sender, IMErrorEventArgs e);
        public enum IMError : byte
        {
            TooUserName = IMClient.IM_TooUsername,
            TooPassword = IMClient.IM_TooPassword,
            Exists = IMClient.IM_Exists,
            NoExists = IMClient.IM_NoExists,
            WrongPassword = IMClient.IM_WrongPass
        }

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
            //populating listView:

            Font font = new System.Drawing.Font("Impact", 15);
            dataGridOutput.DefaultCellStyle.Font = new Font(font, FontStyle.Regular);
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
                addMessage(tbInput.Text, Color.PowderBlue);
            }
                

        private void startBtn_Click(object sender, EventArgs e)
        {




            }


        
    }
}
