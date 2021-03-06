﻿using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LifeSubs
{
    public partial class Subtitle : MetroForm
    {
        public string userId { get; set; }
        public string roomId { get; set; }

        MainMenu mm;
        MicLevelListener mll;
        Thread th = null;
        Thread th2 = null;
        Listener listener1 = null;
        Listener listener2 = null;
        String currentListener;
        Settings settings;
        int deviceNumber = -1;
        string path = @"audio\";
        string logPath;
        int lines;
        public string position;
        public ApiHandler apihandler;
        // Drag form
        private bool dragging;
        private Point dragAt = Point.Empty;
        private Screen screen;

        /// <summary>
        /// Starts an instance of the Subtitle class from the main menu without joining a room
        /// Displays a form that listens for incoming speech to display as text
        /// </summary>
        /// <param name="mm">MainMenu</param>
        public Subtitle(MainMenu mm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.mm = mm;
            this.position = "bottom";

            createDir();
            setPosition(position);
        }

        /// <summary>
        /// Starts an instance of the Subtitle class from the main menu while joining a room
        /// Displays a form that listens for incoming speech to display as text
        /// </summary>
        /// <param name="mm">MainMenu</param>
        /// <param name="api">ApiHandler</param>
        public Subtitle(MainMenu mm, ApiHandler api)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.mm = mm;
            this.position = "bottom";
            this.apihandler = api;

            createDir();
            setPosition(position);
        }

        #region StyleHandlers
        /// <summary>
        /// Sets the style of the form according to the settings class
        /// </summary>
        private void setStyle()
        {
            try
            {
                this.screen = Screen.AllScreens[settings.screenIndex];
            }
            catch (IndexOutOfRangeException)
            {
                this.screen = Screen.AllScreens[0];
            }
            var width = screen.Bounds.Width;
            this.Width = width;
            this.dataOutput.Width = width - 40;
            this.TopMost = true;

            dataOutput.RowTemplate.Height = settings.fontsize;
            this.lines = settings.lines;

            dataOutput.Height = (settings.fontsize * lines) * 2;

            this.Height = dataOutput.Height + 50;
            dataOutput.Columns[0].Width = this.Width - 70;
            dataOutput.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataOutput.DefaultCellStyle.Font = new Font(settings.font, settings.fontsize);
            dataOutput.DefaultCellStyle.Font = new Font(settings.font, settings.fontsize + 1);
            dataOutput.DefaultCellStyle.Font = new Font(settings.font, settings.fontsize);
            dataOutput.DefaultCellStyle.BackColor = settings.bgColor;
            dataOutput.DefaultCellStyle.ForeColor = settings.subColor;
            dataOutput.DefaultCellStyle.SelectionBackColor = settings.bgColor;
            dataOutput.DefaultCellStyle.SelectionForeColor = settings.subColor;
            dataOutput.BackgroundColor = settings.bgColor;

            this.deviceNumber = settings.microphone;

            if (mll != null)
            {
                mll.stop();
                //mll = new MicLevelListener(this);
                mll.deviceNumber = settings.microphone;
                mll.noiseLevel = settings.noiseLevel;
                mll.sec = settings.delay * 10;
                mll.listenToStream();
            }
        }

        /// <summary>
        /// Sets the position of the subtitle form according to the specified string
        /// </summary>
        /// <param name="pos">Desired position of the subtitle form. 
        /// If empty it defaults to bottom if this hasn't been changed by the user during the running of the application</param>
        public void setPosition(string pos)
        {
            settings = new Settings();
            setStyle();

            if (listener1 != null)
            {
                listener1.language = settings.subLanguage;
                listener1.deviceNumber = settings.microphone;
            }
            if (listener2 != null)
            {
                listener2.language = settings.subLanguage;
                listener2.deviceNumber = settings.microphone;
            }
            if (pos == "") pos = position;

            switch (pos)
            {
                //switch snap to top
                case "top":
                    this.snapPB.Image = global::LifeSubs.Properties.Resources.Down_Circular_32;
                    this.Location = new Point(screen.Bounds.X, screen.Bounds.Y);
                    position = "top";
                    break;
                //switch snap to bottom
                case "bottom":
                    this.snapPB.Image = global::LifeSubs.Properties.Resources.Up_Circular_32;
                    this.Location = new Point(screen.Bounds.X, screen.Bounds.Height - this.Height);
                    position = "bottom";
                    break;
            }
            if (dataOutput.Rows.Count > 0)
                dataOutput.CurrentCell = dataOutput.Rows[dataOutput.Rows.Count - 1].Cells[0];
        }

        /// <summary>
        /// Create a path for the saved log location
        /// Uses a timestamp to make it unique
        /// 
        /// Call at start-up form
        /// </summary>
        /// <returns>Timestamp in format yyyy-mm-dd_hhmmss</returns>
        private string saveLogPath()
        {
            string savePath = settings.savePath;

            Console.WriteLine("LogPath ---> " + savePath);

            bool folderExists = Directory.Exists(savePath);
            if (!folderExists) Directory.CreateDirectory(savePath);

            DateTime datetime = DateTime.Now;
            string day = datetime.Day.ToString();
            string month = datetime.Month.ToString();
            string hour = datetime.Hour.ToString();
            string minute = datetime.Minute.ToString();
            string seconds = datetime.Second.ToString();

            if (datetime.Day < 10) day = "0" + datetime.Day;
            if (datetime.Month < 10) month = "0" + datetime.Month;
            if (datetime.Hour < 10) hour = "0" + datetime.Hour;
            if (datetime.Minute < 10) minute = "0" + datetime.Minute;
            if (datetime.Second < 10) seconds = "0" + datetime.Second;

            string date = datetime.Year + "-" + month + "-" + day + "_" + hour + minute + seconds;
            savePath += date + ".txt";


            return savePath;
        }
        #endregion

        #region Directory Handling
        /// <summary>
        /// Create directory defined in string path if it does not exist yet
        /// </summary>
        private void createDir()
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists) Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Delete directory defined in string path if it exists
        /// </summary>
        private void deleteDir()
        {
            bool folderExists = Directory.Exists(path);
            if (folderExists) Directory.Delete(path, true);
        }
        #endregion

        #region form opening/closing handling
        /// <summary>
        /// Event handler for loading of form
        /// Start MicLevelListener
        /// Starts listening on default listener1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Subtitle_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            mll = new MicLevelListener(this);
            mll.deviceNumber = settings.microphone;
            mll.noiseLevel = settings.noiseLevel;
            mll.sec = settings.delay * 10;
            mll.listenToStream();

            this.logPath = saveLogPath();

            //Initiate recording
            currentListener = "listener1";
            listener1 = new Listener(deviceNumber, "listener1", this);
            listener2 = new Listener(deviceNumber, "listener2", this);
            listener1.startRecording();
        }

        /// <summary>
        /// Event handler for closing of form
        /// Stops listeners
        /// Stops MicLevelListener
        /// Returns MainMenu
        /// Deletes directory with temporary audiofiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Subtitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
            mll.stop();
            mm.Visible = true;
            deleteDir();

            if(apihandler != null)
            {
                apihandler.exitRoom(null, userId);
            }
        }
        #endregion

        #region setters to call from other threads
        /// <summary>
        /// Adds the returned message from the Http request to the textbox tbOutput
        /// </summary>
        /// <param name="result">Returned message from Http request</param>
        public void setResult(string result)
        {
            if (result == "" || result == "500") return;
            if(apihandler != null)
            {
                apihandler.sendMessage(roomId, userId, result, null);
            }

            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = result;
            dr.Cells.Add(cell1);

            try
            {
                if (this.dataOutput.InvokeRequired)
                    this.dataOutput.Invoke((MethodInvoker)delegate { dataOutput.Rows.Add(dr); dataOutput.CurrentCell = dataOutput.Rows[dr.Index].Cells[0]; });
                else
                    dataOutput.Rows.Add(dr); dataOutput.CurrentCell = dataOutput.Rows[dr.Index].Cells[0];
                //this.tbOutput.AppendText( result );
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Datagridview niet kunnen vinden");
                Console.WriteLine(result);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Datagridview niet kunnen vinden");
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Sets the volumemeter to give the user feedback on his current volume
        /// </summary>
        /// <param name="amp"></param>
        public void setVolumeMeter(int amp)
        {
            amp = amp + 25;
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

        /// <summary>
        /// Sets the color of sendNotificationPanel to give the user feedback on the current state of the listener
        /// </summary>
        /// <param name="color"></param>
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

        /// <summary>
        /// Changes text of label1 in order to perform a TextChanged event 
        /// </summary>
        /// <param name="text"></param>
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

        public void updateLog(String text)
        {
            if (text == "" || text == "500") return;
            Console.WriteLine(logPath);
            try
            {
                if (this.dataOutput.InvokeRequired)
                    this.dataOutput.Invoke((MethodInvoker)delegate
                    {
                        using (StreamWriter sw = File.AppendText(logPath))
                        {
                            sw.WriteLine(text);
                        }
                    });
                else
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine(text);
                    }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("File not found: " + dnfe.Message);
            }
        }
        #endregion
        
        #region Listenhandlers

        /// <summary>
        /// TextChanged eventhandler to call the appropriate functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "send")
            {
                send();
            }
            else if (label1.Text == "leeg")
            {
                empty();
            }
        }

        /// <summary>
        /// Stops the listeners if they're active
        /// </summary>
        private void stop()
        {
            if (listener1 != null) listener1.stop();
            if (listener2 != null) listener2.stop();
        }

        /// <summary>
        /// Changes the listeners if there was no sound detected
        /// This prevents the audiofile from containing a lot of silence
        /// Switches Listeners to switch the currently in use-audio file
        /// </summary>
        public void empty()
        {
            switch (currentListener)
            {
                case "listener1":
                    Console.WriteLine("listener1 currently recording");
                    //Set next listener
                    currentListener = "listener2";
                    //Create next listener
                    //Start next listener
                    listener2.startRecording();

                    Console.WriteLine("Stop listener1");
                    listener1.stop();

                    break;
                case "listener2":
                    Console.WriteLine("listener2 currently recording");
                    //Set next listener
                    currentListener = "listener1";
                    //Create next listener
                    //listener1 = new Listener(deviceNumber, currentListener, this);
                    //Start next listener
                    listener1.startRecording();

                    Console.WriteLine("Stop listener2");
                    listener2.stop();

                    break;
            }
        }

        /// <summary>
        /// Sends the audiofile if there was sound detected during the recording
        /// Switches Listeners to switch the currently in use-audio file
        /// </summary>
        public void send()
        {
            switch (currentListener)
            {
                case "listener1":
                    Console.WriteLine("listener1 currently recording");
                    //Set next listener
                    currentListener = "listener2";
                    //Create next listener
                    //listener2 = new Listener(deviceNumber, currentListener, this);
                    //Start next listener
                    listener2.startRecording();
                    Console.WriteLine("Stop listener1");
                    listener1.stop();

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
                    //listener1 = new Listener(deviceNumber, currentListener, this);
                    //Start next listener
                    listener1.startRecording();
                    Console.WriteLine("Stop listener2");
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

        #region mousehandlers
        /// <summary>
        /// Clickevent on picturebox with settignsicon opens a new SettingsMenu, as Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsPB_Click(object sender, System.EventArgs e)
        {
            new SettingsMenu(this).ShowDialog();
        }

        /// <summary>
        /// Clickevent on picturebox with snapicon, arrow up or down, sets position for currently running application
        /// Does not get saved to .xml so it will not be remembered for later use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snapPB_Click(object sender, EventArgs e)
        {
            switch (position)
            {
                case "top":
                    position = "bottom";
                    break;
                case "bottom":
                    position = "top";
                    break;
            }
            setPosition(position);
        }

        /// <summary>
        /// Activate the form draggable modus when the left mousebutton is pressed.
        /// </summary>
        private void dragPB_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragPB.Cursor = Cursors.SizeAll;

            if (e.Button == MouseButtons.Left)
            {
                this.dragging = true;
                this.dragAt = new Point(e.X, e.Y);
                ((Control)sender).Capture = true;
            }
        }

        /// <summary>
        /// Stops moving the form when the mousebutton is released.
        /// </summary>
        private void dragPB_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragPB.Cursor = Cursors.Default;

            this.dragging = false;
            ((Control)sender).Capture = false;
        }

        /// <summary>
        /// Moves the form when the left mousebutton is pressed and the mouse moves.
        /// </summary>
        private void dragPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging && e.Button == MouseButtons.Left)
            {
                if (this.dataOutput.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Left = e.X + Left - dragAt.X;
                        this.Top = e.Y + Top - dragAt.Y;
                    });
                }
                else
                {
                    this.Left = e.X + Left - dragAt.X;
                    this.Top = e.Y + Top - dragAt.Y;
                }
            }
            else
            {
                this.dragAt = new Point(e.X, e.Y);
            }
        }
        #endregion
    }
}
