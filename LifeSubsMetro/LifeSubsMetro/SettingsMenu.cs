using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;

namespace LifeSubsMetro
{
    public partial class SettingsMenu : MetroForm
    {
        Thread updateUI = null;
        MainMenu mainMenu;
        Subtitle sub;
        GroupConversations gcs;
        Settings settings;
        MicLevelListener mll;

        /// <summary>
        /// Constructor for calling SettingsMenu from MainMenu class
        /// </summary>
        /// <param name="mm"></param>
        public SettingsMenu(MainMenu mm)
        {
            this.mainMenu = mm;
            InitializeComponent();
            init();

            settings = new Settings();
            loadSettings();
        }

        /// <summary>
        /// Constructor for calling SettingsMenu from Subtitle class
        /// </summary>
        /// <param name="sub"></param>
        public SettingsMenu(Subtitle sub)
        {
            this.sub = sub;
            InitializeComponent();
            init();

            settings = new Settings();
            loadSettings();
        }

        /// <summary>
        /// Constructor for calling SettingsMenu from Subtitle class
        /// </summary>
        /// <param name="sub"></param>
        public SettingsMenu(GroupConversations gcs)
        {
            this.gcs = gcs;
            InitializeComponent();
            init();

            settings = new Settings();
            loadSettings();
        }
        #region Initiate
        /// <summary>
        /// Function to fill microphone- and monitor comboboxes to available devices
        /// </summary>
        private void init() 
        {   
            //Load Input devices
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }
            foreach (var source in sources)
            {
                microphoneComboBox.Items.Add(source.ProductName);
            }

            List<Screen> screens = new List<Screen>();

            foreach (Screen screen in Screen.AllScreens)
            {
                screens.Add(screen);
            }
            foreach (var screen in screens)
            {
                monitorComboBox.Items.Add(screen.DeviceName);
            }
        }
        
        /// <summary>
        /// Bring the main menu back when closing the SettingsMenu from MainMenu class
        /// Bring the subtitle screen back to front when closing SettingsMenu from Subtitles class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sub != null) sub.BringToFront();
            if (mainMenu != null) mainMenu.BringToFront();
            if (gcs != null) gcs.BringToFront();

            if (mll != null) mll.stop();
        }

        #endregion Initiate

        #region Metro Tiles event handlers
        /// <summary>
        /// Stops micLevelListener if this was initiated successfully 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void microphoneTile_Click(object sender, EventArgs e) //Microphone tile
        {
            if (microphoneComboBox.SelectedIndex >= 0)
            {
                mll = new MicLevelListener(this);
                mll.deviceNumber = microphoneComboBox.SelectedIndex;
                mll.listenToStream();
            }
            displayTiles("mic");
        }

        /// <summary>
        /// Font tile click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontTile_Click(object sender, EventArgs e) //Font tile
        {
            displayTiles("font");
        }

        /// <summary>
        /// Lines tile click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linesTile_Click(object sender, EventArgs e) //Lines tile
        {
            displayTiles("lines");
        }

        /// <summary>
        /// Save location tile click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTile_Click(object sender, EventArgs e) //Save tile
        {
            displayTiles("save");
        }

        /// <summary>
        /// Delay tile click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delayTile_Click(object sender, EventArgs e) //Delay tile
        {
            displayTiles("delay");
        }

        /// <summary>
        /// Language tile click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void languageTile_Click(object sender, EventArgs e) //Language tile
        {
            displayTiles("language");
        }

        /// <summary>
        /// Function to hide all tiles and then show tile that was clicked
        /// </summary>
        /// <param name="naam">Name of the clicked tile</param>
        private void displayTiles(string naam) 
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(MetroTile))
                {
                    c.Visible = true;
                }
            }

            switch (naam) 
            {
                case "mic": //Microphone tile
                    microphoneTile.Visible = false;
                    break;
                case "font": //Font tile
                    fontTile.Visible = false;
                    break;
                case "lines": //Lines tile
                    linesTile.Visible = false;
                    break;
                case "save": //Save tile
                    saveTile.Visible = false;
                    break;
                case "delay": //Delay tile
                    delayTile.Visible = false;
                    break;
                case "language": //Language tile
                    languageTile.Visible = false;
                    break;
            }
        }
        #endregion Metro Tiles open

        #region Metro Tiles close on save button click
        //Calls the save to XML and sets the concerning tiles on visible = true
        private void microphoneButton_Click(object sender, EventArgs e)  //Microphone tile
        {
            if (mll != null) mll.stop();
            save();
            microphoneTile.Visible = true;
        }
        private void fontButton_Click(object sender, EventArgs e) //Font tile
        {
            save();
            fontTile.Visible = true;
        }
        private void linesButton_Click(object sender, EventArgs e) //Lines tile
        {
            save();
            linesTile.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e) //Save tile
        {
            save();
            saveTile.Visible = true;
        }

        private void delayButton_Click(object sender, EventArgs e) //Delay tile
        {
            save();
            delayTile.Visible = true;
        }

        private void languageButton_Click(object sender, EventArgs e) //Language tile
        {
            save();
            languageTile.Visible = true;
        }

        #endregion Metro Tiles close

        #region Save to XML
        /// <summary>
        /// Function to save entered settings to .XML
        /// </summary>
        private void save()
        {
            DataSet ds = new DataSet("Settings");

            //xml datatable microphone
            DataTable dt = new DataTable("Devices");
            DataColumn dc1 = new DataColumn("Microphone");
            DataColumn monitorColumn = new DataColumn("Monitor");
            dt.Columns.Add(dc1);
            dt.Columns.Add(monitorColumn);
            dt.Rows.Add(microphoneComboBox.SelectedIndex, monitorComboBox.SelectedIndex);
            ds.Tables.Add(dt);

            //xml datatable font
            DataTable dt1 = new DataTable("Font"); 
            DataColumn dc2 = new DataColumn("FontType");
            DataColumn dc3 = new DataColumn("FontSize");
            dt1.Columns.Add(dc2);
            dt1.Columns.Add(dc3);
            dt1.Rows.Add(fontComboBox.Text, fontSizeComboBox.Text);
            ds.Tables.Add(dt1);

            //xml datatable subtitle
            DataTable dt2 = new DataTable("Subtitle");
            DataColumn dc4 = new DataColumn("Lines");
            DataColumn dc5 = new DataColumn("SubtitleColor");
            DataColumn dc6 = new DataColumn("BGColor");
            dt2.Columns.Add(dc4);
            dt2.Columns.Add(dc5);
            dt2.Columns.Add(dc6);

            string fontColor = fontColorPanel.BackColor.A + "," + fontColorPanel.BackColor.R + "," + fontColorPanel.BackColor.G + "," + fontColorPanel.BackColor.B;
            string backColor = fontBackPanel.BackColor.A + "," + fontBackPanel.BackColor.R + "," + fontBackPanel.BackColor.G + "," + fontBackPanel.BackColor.B;
            dt2.Rows.Add(subtitleLinesComboBox.Text, fontColor, backColor);
            ds.Tables.Add(dt2);

            //xml datatable save
            DataTable dt3 = new DataTable("Save");
            DataColumn dc7 = new DataColumn("Path");
            dt3.Columns.Add(dc7);
            dt3.Rows.Add(pathTextBox.Text);
            ds.Tables.Add(dt3);

            //xml datatable delay
            DataTable dt4 = new DataTable("Delay");
            DataColumn dc8 = new DataColumn("SubtitleDelay");
            DataColumn noiseColumn = new DataColumn("Noise_Situation");
            dt4.Columns.Add(dc8);
            dt4.Columns.Add(noiseColumn);
            dt4.Rows.Add(delayTrackBar.Value, noiseComboBox.SelectedItem.ToString());
            ds.Tables.Add(dt4);

            //xml datatable language
            DataTable dt5 = new DataTable("Language");
            DataColumn dc9 = new DataColumn("Subtitle");
            DataColumn dc10 = new DataColumn("Application");
            dt5.Columns.Add(dc9);
            dt5.Columns.Add(dc10);
            dt5.Rows.Add(subtitleLanguage(), applicationLanguageComboBox.Text);
            ds.Tables.Add(dt5);

            ds.WriteXml("Settings.xml");
            if (sub != null)
            {
                sub.setPosition("");
            }
            if (gcs != null)
                gcs.setStyle();
        }

        /// <summary>
        /// Switch entered preferred language to string necessary for dragon dictation http client
        /// </summary>
        /// <returns></returns>
        private string subtitleLanguage()
        {
            switch (subtitleLanguageComboBox.Text)
            {
                case "Nederlands":
                    return "nld-NLD";
                case "Duits":
                    return "deu-DEU";
                case "Frans":
                    return "fra-FRA";
                case "Engels (US)":
                    return "eng-USA";
                case "Engels (GB)":
                    return "eng-GBR";
                default:
                    return "nld-NLD";
            }
        }
                   
        #endregion Save to XML

        #region Subtitle Color
        /// <summary>
        /// Functon to change the backgroundcolor of the subtitle-fontpanel to the selected color
        /// </summary>
        /// <param name="color"></param>
        private void changeClrFont(Color color)
        {
            this.Invoke((MethodInvoker)delegate
            {
                fontColorPanel.BackColor = color;
                foreach (Control c in this.Controls)
                {
                    c.Invalidate();
                }
            });
            
        }

        /// <summary>
        /// Click event handler for font color panel fontColorPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontColorPanel_Click(object sender, EventArgs e)
        {
            if (fontColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                updateUI = new Thread(() => changeClrFont(fontColorDialog.Color));
                updateUI.IsBackground = true;
                updateUI.Start();
            }
        }

        /// <summary>
        /// function to change the backgroundcolor of the subtitle-backgroundpanel to the selected color
        /// </summary>
        /// <param name="color"></param>
        private void changeClrBack(Color color)
        {
            this.Invoke((MethodInvoker)delegate
            {
                fontBackPanel.BackColor = color;
                foreach (Control c in this.Controls)
                {
                    c.Invalidate();
                }
            });

        }
        /// <summary>
        /// Click event handler for backgroundcolor panel fontBackPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontBackPanel_Click(object sender, EventArgs e)
        {
            if (backColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                updateUI = new Thread(() => changeClrBack(backColorDialog.Color));
                updateUI.IsBackground = true;
                updateUI.Start();
            }
        }

        #endregion

        /// <summary>
        /// Function to load the settings for the Settings.cs into the SettingsMenu
        /// </summary>
        private void loadSettings()
        {
            try
            {
                microphoneComboBox.SelectedIndex = settings.microphone;
            }
            catch (ArgumentOutOfRangeException)
            {
                microphoneComboBox.SelectedIndex = -1;
            }

            try
            {
                monitorComboBox.SelectedIndex = settings.screenIndex;
            }
            catch (ArgumentOutOfRangeException)
            {
                monitorComboBox.SelectedIndex = 0;
            }

            //Load the font tile
            fontComboBox.Text = settings.font;
            fontSizeComboBox.Text = settings.fontsize.ToString();
            subtitleLinesComboBox.Text = settings.lines.ToString();

            //load the subtitle tile
            fontColorPanel.BackColor = settings.subColor;
            fontBackPanel.BackColor = settings.bgColor;

            //load the save tile
            pathTextBox.Text = settings.savePath;

            //load the delay tile
            delayTrackBar.Value = settings.delay;
            delayLabel.Text = delayTrackBar.Value.ToString();
            noiseComboBox.SelectedItem = settings.noiseLevel;

            //load the language tile
            subtitleLanguageComboBox.Text = subtitleLanguage(settings.subLanguage);
            applicationLanguageComboBox.Text = settings.appLanguage;
        }

        /// <summary>
        /// Function to switch the language settings in the settings file to user-friendly values
        /// </summary>
        /// <param name="language">language returned from Settings.cs</param>
        /// <returns></returns>
        private string subtitleLanguage(string language)
        {
            switch (language)
            {
                case "nld-NLD":
                    return "Nederlands";
                case "deu-DEU":
                    return "Duits";
                case "fra-FRA":
                    return "Frans";
                case "eng-USA":
                    return "Engels (US)";
                case "eng-GBR":
                    return "Engels (GB)";
                default:
                    return "Nederlands";
            }
        }

        /// <summary>
        /// Function to set the volumeMeter of the devices tile from another thread
        /// This gives the user direct feedback on the selected microphone
        /// </summary>
        /// <param name="amp"></param>
        public void setVolumeMeter(int amp)
        {
            amp = amp + 150;
            if (this.microphoneProgressBar.InvokeRequired)
            {
                try
                {
                    this.microphoneProgressBar.Invoke((MethodInvoker)delegate { this.microphoneProgressBar.Value = amp; });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #region other eventhandlers
        /// <summary>
        /// Functio to set the numeric label value of the delay trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delayTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            delayLabel.Text = delayTrackBar.Value.ToString();
        }

        /// <summary>
        /// Click event handler for path button to open a SaveFileDialog with a predifined save format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pathButton_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = fbd.ShowDialog();

            if (result != DialogResult.OK) return;

            path = fbd.SelectedPath + @"\";

            pathTextBox.Text = path;
        }

        /// <summary>
        /// Stop current miclevellistener and start a new one on indexChange
        /// This makes the volumeMeter display the volume of the currently selected microphone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void microphoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mll != null)
            {
                mll.stop();
                mll.deviceNumber = microphoneComboBox.SelectedIndex;
                mll.listenToStream();
            }
            else
            {
                mll = new MicLevelListener(this);
                mll.deviceNumber = microphoneComboBox.SelectedIndex;
                mll.listenToStream();
            }
            
        }

        /// <summary>
        /// Stop miclevellistener when the microphone tile is overlayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void microphoneTile_VisibleChanged(object sender, EventArgs e)
        {
            if (microphoneTile.Visible == false) return;
            if (mll != null) mll.stop();
        }
        #endregion

        #region hover events
        //Event handlers to handle mouseEnter and mouseLeave
        private void microphoneTile_MouseEnter(object sender, EventArgs e)
        {
            this.microphoneTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void microphoneTile_MouseLeave(object sender, EventArgs e)
        {
            this.microphoneTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void delayTile_MouseLeave(object sender, System.EventArgs e)
        {
            this.delayTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void delayTile_MouseEnter(object sender, System.EventArgs e)
        {
            this.delayTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void linesTile_MouseLeave(object sender, System.EventArgs e)
        {
            this.linesTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void linesTile_MouseEnter(object sender, System.EventArgs e)
        {
            this.linesTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void saveTile_MouseLeave(object sender, System.EventArgs e)
        {
            this.saveTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void saveTile_MouseEnter(object sender, System.EventArgs e)
        {
            this.saveTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void fontTile_MouseLeave(object sender, System.EventArgs e)
        {
            this.fontTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void fontTile_MouseEnter(object sender, System.EventArgs e)
        {
            this.fontTile.Style = MetroFramework.MetroColorStyle.Teal;
        }

        private void languageTile_MouseLeave(object sender, System.EventArgs e)
        {
            this.languageTile.Style = MetroFramework.MetroColorStyle.Default;
        }

        private void languageTile_MouseEnter(object sender, System.EventArgs e)
        {
            this.languageTile.Style = MetroFramework.MetroColorStyle.Teal;
        }
        #endregion

        private void openFolderTile_Click(object sender, EventArgs e)
        {
            string savedPath = pathTextBox.Text;
            bool folderExists = System.IO.Directory.Exists(savedPath);
            if (folderExists) System.Diagnostics.Process.Start(savedPath);
        }
    }
}
