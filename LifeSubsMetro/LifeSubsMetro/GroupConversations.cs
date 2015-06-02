using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    public partial class GroupConversations : MetroForm
    {
        public string userId { get; set; }
        public string roomId { get; set; }
        public string roomName { get; set; }
        public string messageId { get; set; }

        string logpath;
        string path = @"audio\";
        MainMenu mm;

        Thread th;

        MicLevelListener mll;
        Listener listener1 = null;
        Settings settings;

        MessageHandler mh;
        ApiHandler apiHandler;

        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();
        }

        #region sendMessage
        /// <summary>
        /// Place your own message into the datagridview dataGridOutput as a new row
        /// </summary>
        /// <param name="msg"></param>
        public void sendMessage(string msg)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Style.BackColor = Color.PowderBlue;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
            cell2.Style.BackColor = Color.PowderBlue;
            cell2.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            cell2.Value = msg;
            dr.Cells.Add(cell2);

            if (this.dataGridOutput.InvokeRequired)
            {
                try
                {
                    this.dataGridOutput.Invoke((MethodInvoker)delegate { dataGridOutput.Rows.Add(dr); dataGridOutput.CurrentCell = dataGridOutput.Rows[dr.Index + 1].Cells[0]; });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                dataGridOutput.Rows.Add(dr);
                dataGridOutput.CurrentCell = dataGridOutput.Rows[dr.Index + 1].Cells[0];
                tbInput.Text = "";
            }

        }

        /// <summary>
        /// KeyDown event handler.
        /// Sends the text on "Enter"-press if tbInput containts text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (tbInput.Text != "")
                    sendToApi(tbInput.Text);
            }
        }
        /// <summary>
        /// Click event handler.
        /// Sends your message if tbInput containts text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendTile_Click(object sender, EventArgs e)
        {
            if (tbInput.Text == "") return;

            sendToApi(tbInput.Text);
        }

        public void sendToApi(string msg)
        {
            apiHandler.sendMessage(roomId, userId, msg, this);
        }

        public void clearTextBox()
        {
            tbInput.Text = "";
        }

        #endregion

        /// <summary>
        /// Place a received message into the datagridview dataGridOutput as a new row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        public void receiveMessage(string sender, string msg)
        {
            DataGridViewRow dr = new DataGridViewRow();

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            cell1.Value = sender;
            dr.Cells.Add(cell1);

            DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
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

        #region set properties from other thread

        public void setListenButton(Boolean show)
        {
            try
            {
                if (this.startGroupListenerBtn.InvokeRequired)
                {
                    try
                    {
                        this.startGroupListenerBtn.Invoke((MethodInvoker)delegate { startGroupListenerBtn.Visible = show; });

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    startGroupListenerBtn.Visible = show;
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Knop niet kunnen vinden");
            }
        }

        public void setVolumeMeter(int amp)
        {
            Console.WriteLine("AMP = " + amp);
            amp = amp + 50;
            try
            {
                if (this.volumemeterGrp.InvokeRequired)
                {
                    try
                    {
                        this.volumemeterGrp.Invoke((MethodInvoker)delegate { this.volumemeterGrp.Value = amp; });
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

        public void setCanSendPanel(Boolean sent)
        {
            try
            {
                if (this.canSendPanelGrp.InvokeRequired)
                {
                    try
                    {
                        Console.WriteLine("settings visibility of canSendPanelGrp in other thread to " + sent);
                        this.canSendPanelGrp.Invoke((MethodInvoker)delegate { canSendPanelGrp.Visible = sent; });

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("settings visibility of canSendPanelGrp in same thread to " + sent);
                    canSendPanelGrp.Visible = sent;
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("Knop niet kunnen vinden");
            }

        }
        #endregion

        #region Speech-to-text listener
        private void canSendPanelGrp_VisibleChanged(object sender, EventArgs e)
        {
            if (canSendPanelGrp.Visible == true)
            {
                Console.WriteLine("VERSTUUR");
                sendRequest();

                volumemeterGrp.Visible = false;
                startGroupListenerBtn.Visible = true;
            }
            else
            {
                if (th != null) th.Abort();
            }
        }

        public void sendRequest()
        {
            if (listener1 == null) return;
            //Stop listener
            Console.WriteLine("Stop recording listener1");
            listener1.stop();

            Console.WriteLine("Start request listener1");
            th = new Thread(listener1.request);
            th.Start();
            while (!th.IsAlive) ;
            Thread.Sleep(1);
        }

        /// <summary>
        /// Starts a listenerloop that stops when this button is pressed and ended when there was a silence for the set amount of time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGroupListenerBtn_Click(object sender, EventArgs e)
        {
            createDir();
            startGroupListenerBtn.Visible = false;
            volumemeterGrp.Visible = true;
            int deviceNumber = settings.microphone;

            //Initiate recording
            listener1 = new Listener(deviceNumber, "listener1", this);
            listener1.startRecording();
            Console.WriteLine("listener1 currently recording");

            //Initiate listening to silences
            mll = new MicLevelListener(this);
            mll.deviceNumber = deviceNumber;
            mll.listenToStream();
            Console.WriteLine("MicLevelListener currently listening");

        }
        #endregion

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

        /// <summary>
        /// Event handler for when the settings picturebox is clicked.
        /// Opens the Settingsmenu in a Dialog window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsPB_Click(object sender, EventArgs e)
        {
            SettingsMenu sm = new SettingsMenu(this);
            sm.ShowDialog();
        }

        /// <summary>
        /// Set the datagridview and textbox tot the user-specified or default style
        /// </summary>
        public void setStyle()
        {
            settings = new Settings();
            Font font = new System.Drawing.Font(settings.font, settings.fontsize);
            dataGridOutput.DefaultCellStyle.Font = font;
            dataGridOutput.DefaultCellStyle.BackColor = settings.bgColor;
            dataGridOutput.DefaultCellStyle.ForeColor = settings.subColor;
            dataGridOutput.DefaultCellStyle.SelectionBackColor = settings.bgColor;
            dataGridOutput.DefaultCellStyle.SelectionForeColor = settings.subColor;
            dataGridOutput.BackgroundColor = settings.bgColor;

            tbInput.BackColor = settings.bgColor;
            tbInput.ForeColor = settings.subColor;

            //TODO: Complete listener functionality and change microphone of requestlistener and miclevellistener here
        }

        /// <summary>
        /// Create a path for the saved log location
        /// Uses a timestamp to make it unique in combination with the room name
        /// 
        /// Call at start-up form
        /// </summary>
        /// <returns>Timestamp in format yyyy-mm-dd_hhmm</returns>
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

            string date = datetime.Year + "-" + month + "-" + day + "_" + hour + minute;
            savePath += date + " - " + roomName + ".txt";

            return savePath;
        }

        /// <summary>
        /// Update the rooms log with the latest messages
        /// </summary>
        /// <param name="text"></param>
        public void updateLog(String text)
        {
            if (text == "" || text == "500") return;
            Console.WriteLine(logpath);
            try
            {
                if (this.dataGridOutput.InvokeRequired)
                    this.dataGridOutput.Invoke((MethodInvoker)delegate
                    {
                        using (StreamWriter sw = File.AppendText(logpath))
                        {
                            sw.WriteLine(text);
                        }
                    });
                else
                    using (StreamWriter sw = File.AppendText(logpath))
                    {
                        sw.WriteLine(text);
                    }
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("File not found: " + dnfe.Message);
            }
        }

        /// <summary>
        /// Event handler for when this form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupConversations_Load(object sender, EventArgs e)
        {
            this.Text = roomName;
            this.messageId = "0";

            setStyle();
            this.logpath = saveLogPath();
            mh = new MessageHandler(this);
            apiHandler = new ApiHandler();
        }

        /// <summary>
        /// Event handler for when this form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupConversations_FormClosing(object sender, FormClosingEventArgs e)
        {
            mh.stopTimer();
            apiHandler.exitRoom(this, null);
            mm.BringToFront();

            try { deleteDir(); }
            catch (Exception direx) { Console.WriteLine(direx.Message); }

        }
    }
}
