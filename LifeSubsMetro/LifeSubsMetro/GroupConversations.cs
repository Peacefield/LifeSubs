using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace LifeSubsMetro
{
    public partial class GroupConversations : MetroForm
    {
        string path = @"C:\audiotest";
        MainMenu mm;
        String hostIp = "localHost";
        string ownIpAddress;
        System.IO.StreamWriter streamWriter;
        System.IO.StreamReader streamReader;
        NetworkStream networkStream;

        Thread th;
        Thread th2;
        MicLevelListener mll;
        string currentListener;
        Listener listener1 = null;
        Settings settings;

        public GroupConversations(MainMenu mm, String ip)
        {
            settings = new Settings();
            this.mm = mm;
            this.hostIp = ip;
            //this.hostIp = getOwnIp();
            InitializeComponent();

            ownIpAddress = getOwnIp();

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
                socketForServer = new TcpClient(hostIp, 10);
            }
            catch
            {
                Console.WriteLine("Failed to connect to server at {0}:999", "localhost");
                MetroFramework.MetroMessageBox.Show(mm, "Failed to connect to server at " + hostIp + ":999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            networkStream = socketForServer.GetStream();
            streamReader = new System.IO.StreamReader(networkStream);
            streamWriter = new System.IO.StreamWriter(networkStream);
            Console.WriteLine("*******This is client program who is connected to localhost on port No:10*****");
        }

        private void sendMessage(string msg, Color c)
        {
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

                    DataGridViewRow dr = new DataGridViewRow();

                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    dr.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Style.BackColor = c;
                    cell2.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    cell2.Value = msg;
                    dr.Cells.Add(cell2);

                    dataGridOutput.Rows.Add(dr);

                    tbInput.Text = "";
                }
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
                MetroFramework.MetroMessageBox.Show(this, "Kan geen verbinding maken met de server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { deleteDir(); }
            catch (Exception direx) { Console.WriteLine(direx.Message); }

            if (streamWriter != null)
            {
                try
                {
                    streamWriter.WriteLine("exit");
                    streamWriter.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (networkStream != null) networkStream.Close();

            mm.Visible = true;
        }

        private void sendTile_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "") return;

            sendMessage(tbInput.Text, Color.PowderBlue);
        }

        public void send()
        {
            Console.WriteLine("listener1 currently recording");
            //Stop listener
            Console.WriteLine("Stop listener1");
            listener1.stop();

            th = new Thread(listener1.request);
            th.Start();
            while (!th.IsAlive) ;
            Thread.Sleep(1);
            if (th2 != null)
            {
                Console.WriteLine("th2 leeft");
                th2.Abort();
                th2.Join();
            }
        }

        #region set properties from other thread
        public void setCanSendPanel(Boolean sent)
        {
            try
            {
                if (this.canSendPanelGrp.InvokeRequired)
                {
                    try
                    {
                        if (sent == false)
                        {
                            this.canSendPanelGrp.Invoke((MethodInvoker)delegate { canSendPanelGrp.Visible = true; });
                        }
                        if (sent == true)
                        {
                            this.canSendPanelGrp.Invoke((MethodInvoker)delegate { canSendPanelGrp.Visible = false; });
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Knop niet kunnen vinden");
            }

        }

        public void setListenButton(Boolean show)
        {
            try
            {
                if (this.startGroupListenerBtn.InvokeRequired)
                {
                    try
                    {
                        if (show == false)
                        {
                            this.startGroupListenerBtn.Invoke((MethodInvoker)delegate { startGroupListenerBtn.Visible = true; });
                        }
                        if (show == true)
                        {
                            this.startGroupListenerBtn.Invoke((MethodInvoker)delegate { startGroupListenerBtn.Visible = false; });
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Knop niet kunnen vinden");
            }
        }

        public void setVolumeMeter(int amp)
        {
            amp = amp + 50;
            try
            {
                if (this.volumemeterGrp.InvokeRequired)
                {
                    try
                    {
                        this.volumemeterGrp.Invoke((MethodInvoker)delegate { this.volumemeterGrp.Value = amp; });
                        Console.WriteLine("AMP = " + amp);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("VolumeMeter niet kunnen vinden");
            }

        }

        public void addMessageFromThread(string msg, Color c)
        {
            try
            {
                if (this.dataGridOutput.InvokeRequired)
                {
                    try
                    {
                        dataGridOutput.Invoke((MethodInvoker)(() => sendMessage(msg, c)));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("VolumeMeter niet kunnen vinden");
            }

        }

        #endregion

        private void startGroupListenerBtn_Click(object sender, EventArgs e)
        {
            startGroupListenerBtn.Visible = false;
            volumemeterGrp.Visible = true;
            createDir();
            mll = new MicLevelListener(this);
            mll.listenToStream();

            int deviceNumber = settings.microphone;

            //Initiate recording
            currentListener = "listener1";
            listener1 = new Listener(deviceNumber, currentListener, this);
            listener1.startRecording();
            //listener1 = new Listener(deviceNumber, currentListener, this);
            //listener1.startRecording();
        }

        #region Directory Handling
        private void createDir()
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists) Directory.CreateDirectory(path);
        }

        private void deleteDir()
        {
            bool folderExists = Directory.Exists(path);
            if (folderExists) Directory.Delete(path, true);
        }
        #endregion

        private void canSendPanelGrp_VisibleChanged(object sender, EventArgs e)
        {
            if (canSendPanelGrp.Visible == true)
            {
                Console.WriteLine("VERSTUUR");
                send();
                //canSendPanelGrp.Visible = false;
                volumemeterGrp.Visible = false;
            }
        }
        
    }
}
