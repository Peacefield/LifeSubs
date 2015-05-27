﻿using MetroFramework.Forms;
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
        public string userId { get; set; }

        string path = @"C:\audiotest";
        MainMenu mm;

        Thread th;
        Thread th2;

        MicLevelListener mll;
        string currentListener;
        Listener listener1 = null;
        Settings settings;

        MessageHandler mh;

        public GroupConversations(MainMenu mm, String ip)
        {
            settings = new Settings();
            this.mm = mm;
            InitializeComponent();

            Font font = new System.Drawing.Font("Arial", 18);
            dataGridOutput.DefaultCellStyle.Font = new Font(font, FontStyle.Regular);
            dataGridOutput.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font(dataGridOutput.DefaultCellStyle.Font.ToString(), 50);

            mh = new MessageHandler(this);

            userId = "2";
        }

        #region sendMessage
        public void sendMessage(string msg, Color c)
        {
                    string str = tbInput.Text;

                    DataGridViewRow dr = new DataGridViewRow();

                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    dr.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Style.BackColor = c;
                    cell2.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    cell2.Value = msg;
                    dr.Cells.Add(cell2);

                    if (this.dataGridOutput.InvokeRequired)
                    {
                        try
                        {
                            this.dataGridOutput.Invoke((MethodInvoker)delegate { dataGridOutput.Rows.Add(dr); });

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    //dataGridOutput.Rows.Add(dr);

                    tbInput.Text = "";
        }

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

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (tbInput.Text != "")
                    sendMessage(tbInput.Text, Color.PowderBlue);
            }
        }
        #endregion

        public void receiveMessage(string sender, string msg, Color c)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = sender;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = c;
            cell2.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            if (this.dataGridOutput.InvokeRequired)
            {
                try
                {
                    this.dataGridOutput.Invoke((MethodInvoker)delegate { dataGridOutput.Rows.Add(dr); dataGridOutput.CurrentCell = dataGridOutput.Rows[dr.Index].Cells[0]; });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
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

            mh.stopTimer();

            //if (serverThread != null) serverThread.Abort();
            //mm.closeRoom();
            Thread.Sleep(1); //To prevent black screen while room is being destroyed
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


    }
}
