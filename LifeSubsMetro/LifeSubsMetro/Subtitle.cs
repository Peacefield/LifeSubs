using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    public partial class Subtitle : MetroForm
    {
        MainMenu mm;
        MicLevelListener mll;
        Thread th = null;
        Thread th2 = null;
        Listener listener1 = null;
        Listener listener2 = null;
        String currentListener;
        int deviceNumber = 0;

        public Subtitle(MainMenu mm)
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var width = screen.Width;
            this.mm = mm;

            InitializeComponent();

            this.Width = width;
            this.Height = 150;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
            this.TopMost = true;
            
            this.tbOutput.Width = width - 40;
            this.tbOutput.Height = 100;
        }

        private void Subtitle_Load(object sender, EventArgs e)
        {
            mll = new MicLevelListener(this);
            mll.listenToStream();

            //Initiate recording
            currentListener = "listener1";
            listener1 = new Listener(deviceNumber, currentListener, this);
            listener1.startRecording();
            //listener1 = new Listener(deviceNumber, currentListener, this);
            //listener1.startRecording();
        }

        private void Subtitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            mm.Visible = true;
            mll.stop();
        }

        //Get list of available devices for recording audio
        //Gets executed at Load()
        //Eventually move to settings
        //public void getDevices()
        //{
        //    List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

        //    for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
        //    {
        //        sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
        //    }

        //    sourceList.Items.Clear();

        //    foreach (var source in sources)
        //    {
        //        ListViewItem item = new ListViewItem(source.ProductName);
        //        item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
        //        sourceList.Items.Add(item);
        //    }
        //}

        //private void stopListening()
        //{
        //    Console.WriteLine("Stop listening");

        //    if (listener1 != null) listener1.stop();
        //    if (listener2 != null) listener2.stop();
        //}

        public void setResult(string result)
        {
            if (result == "") return;

            if (this.tbOutput.InvokeRequired)
                this.tbOutput.Invoke((MethodInvoker)delegate { this.tbOutput.AppendText( result + "\r\n"); });
            else
                this.tbOutput.AppendText(result + "\r\n");
        }

        public void setVolumeMeter(int amp)
        {
            amp = amp + 150;
            if (this.volumeMeter.InvokeRequired)
            {
                try
                {
                    this.volumeMeter.Invoke((MethodInvoker)delegate { this.volumeMeter.Value = amp; });
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void setSendNoti(Color color)
        {

            if (this.sendNotificationPanel.InvokeRequired)
            {
                this.sendNotificationPanel.Invoke((MethodInvoker)delegate { this.sendNotificationPanel.BackColor = color; });
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("NIEUWE LABEL TEXT = " + label1.Text);
            if (label1.Text == "send")
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!send!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                send();
            }
        }

        public void setLabel(String text)
        {
            if (text == "") return;

            if (this.label1.InvokeRequired)
                this.label1.Invoke((MethodInvoker)delegate { this.label1.Text = text; });
            else
                this.label1.Text = text;
        }

        private void stop()
        {
            if (listener1 != null) listener1.stop();
            if (listener2 != null) listener2.stop();
        }

        public void send()
        {
            switch (currentListener)
            {
                case "listener1":
                    //Set next listener
                    currentListener = "listener2";
                    //Create next listener
                    listener2 = new Listener(deviceNumber, currentListener, this);
                    //Start next listener
                    listener2.startRecording();
                    
                    Console.WriteLine("listener1 currently recording");
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
                    break;
                case "listener2":
                    Console.WriteLine("listener2 currently recording");
                    //Set next listener
                    currentListener = "listener1";
                    //Create next listener
                    listener1 = new Listener(deviceNumber, currentListener, this);
                    //Start next listener
                    listener1.startRecording();
                    listener2.stop();

                    th2 = new Thread(listener2.request);
                    th2.Start();
                    while (!th2.IsAlive) ;
                    Thread.Sleep(1);
                    if (th != null)
                    {
                        Console.WriteLine("th leeft");
                        th.Abort();
                        th.Join();
                    }

                    break;
            }

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu(this);
            sm.Show();
        }

        
    }
}
