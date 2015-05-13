using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Settings settings;
        int deviceNumber = 0;
        string path = @"C:\audiotest";
        int lines;

        public Subtitle(MainMenu mm)
        {
            InitializeComponent();

            createDir();
            setStyle();
            this.mm = mm;
            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var width = screen.Width;
            this.Width = width;
            this.tbOutput.Width = width - 40;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            
        }

        public void setStyle()
        {
            settings = new Settings();
            int additionalSpacing;

            this.tbOutput.Font = new Font(settings.font, settings.fontsize);
            this.tbOutput.BackColor = settings.bgColor;
            this.tbOutput.ForeColor = settings.subColor;
            this.lines = settings.lines;

            additionalSpacing = calcAdditionalSpacing(this.tbOutput.Font);

            int fontsize = Int32.Parse(tbOutput.Font.Size.ToString());
            this.tbOutput.Height = (fontsize * lines) + additionalSpacing;
            this.Height = tbOutput.Height + 50;
            this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
        }
        
        private int calcAdditionalSpacing(Font font)
        {
            int additionalSpacing = 40;

            switch (font.Name)
            {
                case "Arial": 
                    if (font.Size < 24)
                    {
                        additionalSpacing = 40;
                    }
                    else if(font.Size == 24)
                    {
                        additionalSpacing = 60;
                    }
                    else
                    {
                        additionalSpacing = 70;
                    }

                    if (lines == 1) additionalSpacing -= 10;

                    break;
                case "Calibri":
                    if (font.Size < 24)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size == 24)
                    {
                        additionalSpacing = 60;
                    }
                    else
                    {
                        additionalSpacing = 70;
                    }

                    if (lines == 4) additionalSpacing += 15;
                    if (lines == 1) additionalSpacing -= 10;

                    break;
                case "Constantia":
                    if (font.Size == 18)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size == 20)
                    {
                        additionalSpacing = 60;
                    }
                    else if (font.Size == 22)
                    {
                        additionalSpacing = 65;
                    }
                    else if (font.Size == 30)
                    {
                        additionalSpacing = 90;
                    }
                    else
                    {
                        additionalSpacing = 70;
                    }
                    if (lines == 1) additionalSpacing -= 20;

                    break;
                case "Georgia": 
                    if (font.Size == 18)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size == 20)
                    {
                        additionalSpacing = 60;
                    }
                    else if (font.Size == 22)
                    {
                        additionalSpacing = 65;
                    }
                    else if (font.Size == 30)
                    {
                        additionalSpacing = 90;
                    }
                    else
                    {
                        additionalSpacing = 70;
                    }
                    if (lines == 1) additionalSpacing = 40;
                    if (lines == 2) additionalSpacing -= 10;

                    break;
                case "Gill Sans MT":
                    if (font.Size == 18)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size == 20)
                    {
                        additionalSpacing = 60;
                    }
                    else if (font.Size == 22)
                    {
                        additionalSpacing = 80;
                    }
                    else if (font.Size == 24)
                    {
                        additionalSpacing = 90;
                    }
                    else if (font.Size == 26)
                    {
                        additionalSpacing = 100;
                    }
                    else if (font.Size == 28)
                    {
                        additionalSpacing = 105;
                    }
                    else if (font.Size == 30)
                    {
                        additionalSpacing = 110;
                    }

                    if (lines == 1) additionalSpacing = 40;
                    if (lines == 2) additionalSpacing -= 10;

                    break;
                case "Impact":
                    if (font.Size == 18)
                    {
                        additionalSpacing = 55;
                    }
                    else if (font.Size <= 24)
                    {
                        additionalSpacing = 70;
                    }
                    else
                    {
                        additionalSpacing = 80;
                    }

                    if (lines == 1) additionalSpacing -= 20;

                    break;
                case "Rockwell":
                    if (font.Size < 24)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size < 28)
                    {
                        additionalSpacing = 60;
                    }
                    else if (font.Size >= 28)
                    {
                        additionalSpacing = 70;
                    }

                    if (lines == 1) additionalSpacing -= 10;

                    break;
                case "Segoe WP":
                    if (font.Size == 18)
                    {
                        additionalSpacing = 65;
                    }
                    else if (font.Size < 24)
                    {
                        additionalSpacing = 80;
                    }
                    else if (font.Size < 28)
                    {
                        additionalSpacing = 90;
                    }
                    else if (font.Size == 28)
                    {
                        additionalSpacing = 100;
                    }
                    else if (font.Size == 30)
                    {
                        additionalSpacing = 110;
                    }

                    if (lines == 1) additionalSpacing -= 10;
                    break;
                case "Times New Roman":
                    if (font.Size <= 24)
                    {
                        additionalSpacing = 60;   
                    }
                    else if (font.Size == 26)
                    {
                        additionalSpacing = 75;
                    }
                    else if (font.Size > 24)
                    {
                        additionalSpacing = 80;
                    }

                    if (lines == 1) additionalSpacing -= 20;
                    break;
                case "Verdana":
                    if (font.Size == 18)
                    {
                        additionalSpacing = 50;
                    }
                    else if (font.Size == 20)
                    {
                        additionalSpacing = 55;                        
                    }
                    else if (font.Size == 22)
                    {
                        additionalSpacing = 60;
                    }
                    else if (font.Size == 24)
                    {
                        additionalSpacing = 65;
                    }
                    else if (font.Size == 26)
                    {
                        additionalSpacing = 70;
                    }
                    else if (font.Size == 28)
                    {
                        additionalSpacing = 75;
                    }
                    else if (font.Size == 30)
                    {
                        additionalSpacing = 80;
                    }

                    if (lines == 1) additionalSpacing -= 10;
                    break;
            }

            return additionalSpacing;
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

        #region form opening/closing handling
        private void Subtitle_Load(object sender, EventArgs e)
        {
            mll = new MicLevelListener(this);
            mll.listenToStream();

            //Initiate recording
            currentListener = "listener1";
            listener1 = new Listener(deviceNumber, currentListener, this);
            listener1.startRecording();
        }

        private void Subtitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
            mm.Visible = true;
            mll.stop();
            deleteDir();
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
        #endregion

        #region setters to call from other threads
        public void setResult(string result)
        {
            if (result == "" || result == "500") return;

            try
            {
                if (this.tbOutput.InvokeRequired)
                    this.tbOutput.Invoke((MethodInvoker)delegate { this.tbOutput.AppendText( result + "\r\n"); });
                else
                    this.tbOutput.AppendText(result + "\r\n");
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Textbox niet kunnen vinden");
                Console.WriteLine(result);
            }
        }

        public void setVolumeMeter(int amp)
        {
            amp = amp + 150;
            try
            {
                if (this.volumeMeter.InvokeRequired)
                {
                    try
                    {
                        this.volumeMeter.Invoke((MethodInvoker)delegate { this.volumeMeter.Value = amp; });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("VolumeMeter niet kunnen vinden");
            }
            
        }

        public void setSendNoti(Color color)
        {
            try
            {
                if (this.sendNotificationPanel.InvokeRequired)
                {
                    this.sendNotificationPanel.Invoke((MethodInvoker)delegate { this.sendNotificationPanel.BackColor = color; });
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("NotificationPanel niet kunnen vinden");
            }
        }

        public void setLabel(String text)
        {
            if (text == "") return;
            try
            {
                if (this.label1.InvokeRequired)
                    this.label1.Invoke((MethodInvoker)delegate { this.label1.Text = text; });
                else
                    this.label1.Text = text;
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Label niet kunnen vinden");
            }
        }
        #endregion

        private void label1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("NIEUWE LABEL TEXT = " + label1.Text);
            if (label1.Text == "send")
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!send!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                send();
            }
            else if (label1.Text == "leeg")
            {
                empty();
            }
        }

        #region Listenhandlers
        private void stop()
        {
            if (listener1 != null) listener1.stop();
            if (listener2 != null) listener2.stop();
        }

        public void empty()
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

                    break;
            }
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
        #endregion

        private void settingsPB_Click(object sender, System.EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu(this);
            sm.Show();
        }

        public void changeFontSize(int size)
        {
            this.tbOutput.Font = new Font(tbOutput.Font.FontFamily, size);
        }
    }
}
