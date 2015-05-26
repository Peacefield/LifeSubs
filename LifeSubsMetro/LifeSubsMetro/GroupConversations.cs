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
        String hostIp = "localHost";
        string ownIpAddress;
        System.IO.StreamWriter streamWriter;
        System.IO.StreamReader streamReader;
        NetworkStream networkStream;

        public GroupConversations(MainMenu mm, String ip)
        {
            this.mm = mm;
            this.hostIp = ip;
            InitializeComponent();

            ownIpAddress = getOwnIp();
            //populating listView:

            Font font = new System.Drawing.Font("Arial", 18);
            dataGridOutput.DefaultCellStyle.Font = new Font(font, FontStyle.Regular);
            dataGridOutput.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font(dataGridOutput.DefaultCellStyle.Font.ToString(), 50);

            createClient();
        }

        private void createClient()
        {
            TcpClient socketForServer;
            try
            {
                //Change localhost to IP owner room/host
                socketForServer = new TcpClient(hostIp, 10);
            }
            catch
            {
                Console.WriteLine(
                "Failed to connect to server at {0}:999", "localhost");
                return;
            }

            networkStream = socketForServer.GetStream();
            streamReader = new System.IO.StreamReader(networkStream);
            streamWriter = new System.IO.StreamWriter(networkStream);
            Console.WriteLine("*******This is client program who is connected to localhost on port No:10*****");
        }

        private void sendMessage(string msg, Color c)
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

            try
            {
                //string outputString;
                // read the data from the host and display it
                {
                    //outputString = streamReader.ReadLine();
                    //Console.WriteLine("Message Recieved by server:" + outputString);

                    //Console.WriteLine("Type your message to be recieved by server:");
                    string str = tbInput.Text;
                    streamWriter.WriteLine(str);
                    streamWriter.Flush();

                    tbInput.Text = "";
                }
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
            }
        }

        private void receiveMessage(string sender, string msg, Color c)
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

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm.Visible = true;

            streamWriter.WriteLine("exit");
            streamWriter.Flush();
            networkStream.Close();
        }

        private void sendTile_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "") return;

            sendMessage(tbInput.Text, Color.PowderBlue);
        }        
    }
}
