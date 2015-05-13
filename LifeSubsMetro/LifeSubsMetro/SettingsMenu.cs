using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Threading;
using NAudio;
using NAudio.CoreAudioApi;

namespace LifeSubsMetro
{
    public partial class SettingsMenu : MetroForm
    {
        Thread updateUI = null;
        MainMenu mainMenu;
        Subtitle sub;
        Settings settings;
        MicLevelListener mll;

        public SettingsMenu(MainMenu mm)
        {
            this.mainMenu = mm;
            InitializeComponent();
            init();

            settings = new Settings();
            loadSettings();
        }

        public SettingsMenu(Subtitle sub)
        {
            this.sub = sub;
            InitializeComponent();
            init();

            settings = new Settings();
            loadSettings();
        }

        #region Initiate
        private void init() //Load on start
        {   
            //Load Font sizes
            fontSizeComboBox.Items.Add(6);
            fontSizeComboBox.Items.Add(8);
            fontSizeComboBox.Items.Add(10);
            fontSizeComboBox.Items.Add(12);
            fontSizeComboBox.Items.Add(14);
            fontSizeComboBox.Items.Add(16);

            //Load Subtitle number of lines
            subtitleLinesComboBox.Items.Add(1);
            subtitleLinesComboBox.Items.Add(2);
            subtitleLinesComboBox.Items.Add(3);
            subtitleLinesComboBox.Items.Add(4);

            //Load Languages of subtitling and the application
            subtitleLanguageComboBox.Items.Add("Nederlands");
            subtitleLanguageComboBox.Items.Add("Engels");
            subtitleLanguageComboBox.Items.Add("Duits");
            subtitleLanguageComboBox.Items.Add("Frans");
            applicationLanguageComboBox.Items.Add("Nederlands");

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
        }
        //Bring the main menu back when closing the settings
        private void SettingsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sub != null) sub.BringToFront();
            if (mainMenu!= null) mainMenu.BringToFront();
            if (mll != null) mll.stop();
        }

        #endregion Initiate

        #region Metro Tiles open
        //Call displaytiles() for the concerning tile
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
        private void fontTile_Click(object sender, EventArgs e) //Font tile
        {
            displayTiles("font");
        }
        private void linesTile_Click(object sender, EventArgs e) //Lines tile
        {
            displayTiles("lines");

        }
        private void saveTile_Click(object sender, EventArgs e) //Save tile
        {
            displayTiles("save");
        }
        private void delayTile_Click(object sender, EventArgs e) //Delay tile
        {
            displayTiles("delay");
        }
        private void languageTile_Click(object sender, EventArgs e) //Language tile
        {
            displayTiles("language");
        }



        //Set the called "displayTiles" tile visible = False so the panel becomes visible
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

        #region Metro Tiles close
        //Calls the save to XML and sets the concerning tiles on visible = true
        private void microphoneButton_Click(object sender, EventArgs e)  //Microphone tile
        {
            save();
            mll.stop();
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
        private void save()
    {
         DataSet ds = new DataSet("Settings");

            //xml datatable microphone
            DataTable dt = new DataTable("Microphone"); 
            DataColumn dc1 = new DataColumn("InputDevice");
            dt.Columns.Add(dc1);
            dt.Rows.Add(microphoneComboBox.Text);
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
            dt4.Columns.Add(dc8);
            dt4.Rows.Add(delayTrackBar.Value);
            ds.Tables.Add(dt4);

            //xml datatable language
            DataTable dt5 = new DataTable("Language");
            DataColumn dc9 = new DataColumn("Subtitle");
            DataColumn dc10 = new DataColumn("Application");
            dt5.Columns.Add(dc9);
            dt5.Columns.Add(dc10);
            dt5.Rows.Add(subtitleLanguageComboBox.Text, applicationLanguageComboBox.Text);
            ds.Tables.Add(dt5);

            //buffer.ReadXml("Settings.xml");

            //ds.Merge(buffer);

            ds.WriteXml("Settings.xml");
    }
                   
        #endregion Save to XML

        #region Subtitle Color
        //Change the color panel of the font to the selected color
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
        private void fontColorPanel_Click(object sender, EventArgs e)
        {
            if (fontColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                updateUI = new Thread(() => changeClrFont(fontColorDialog.Color));
                updateUI.IsBackground = true;
                updateUI.Start();
            }
        }
        #endregion Subtitle Color

        #region Subtitle Back Color
        //Change the color panel of the subtitle background to the selected color
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
        
        private void fontBackPanel_Click(object sender, EventArgs e)
        {
            if (backColorDialog.ShowDialog() != DialogResult.Cancel)
            {
                updateUI = new Thread(() => changeClrBack(backColorDialog.Color));
                updateUI.IsBackground = true;
                updateUI.Start();
            }


        }

        #endregion Subtitle Back Color

        #region Log Path
        //When clicking on the path button open a SaveFileDialog with a predifined save format
        private void pathButton_Click(object sender, EventArgs e)
        {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.FileName = "Log";
        sfd.AddExtension = true;
        sfd.DefaultExt = "txt";
        sfd.Filter = "Text(*.txt)|*.*";
        sfd.ShowDialog();
        pathTextBox.Text = sfd.FileName;
        }

        #endregion Log Path

        #region Delay
        //Set the numeric label value of the delay trackbar
        private void delayTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            delayLabel.Text = delayTrackBar.Value.ToString();
        }

        
        #endregion delay

        #region readXML
        //Load the settings from the XML file
        private void loadXML()
        {
            string settingsFile = @"Settings.xml";
            if(!System.IO.File.Exists(settingsFile)) return;

            DataSet ds = new DataSet();
            ds.ReadXml("Settings.xml");

            //Load the microphone tile
            microphoneComboBox.Text = ds.Tables["Microphone"].Rows[0][0].ToString();
            
            //Load the font tile
            
            //fontComboBox.Text = ds.Tables["Font"].Rows[0][0].ToString(); 

            Console.WriteLine( fontComboBox.Items.Count );

            fontSizeComboBox.Text = ds.Tables["Font"].Rows[0][1].ToString();
            subtitleLinesComboBox.Text = ds.Tables["Subtitle"].Rows[0][0].ToString(); 
            
            //load the subtitle tile
            string fontColor = ds.Tables["Subtitle"].Rows[0][1].ToString();
            //Convert the ARGB values correctly 
            string[] fontList = fontColor.Split(new Char[] { ',' });
            fontColorPanel.BackColor = System.Drawing.Color.FromArgb(Int32.Parse(fontList[0]), Int32.Parse(fontList[1]), Int32.Parse(fontList[2]), Int32.Parse(fontList[3]));
            string backColor = ds.Tables["Subtitle"].Rows[0][2].ToString();
            //Convert the ARGB values correctly
            string[] backList = backColor.Split(new Char[] { ',' });
            fontBackPanel.BackColor = System.Drawing.Color.FromArgb(Int32.Parse(backList[0]), Int32.Parse(backList[1]), Int32.Parse(backList[2]), Int32.Parse(backList[3]));
            
            //load the save tile
            pathTextBox.Text = ds.Tables["Save"].Rows[0][0].ToString(); 
            delayTrackBar.Value = Int32.Parse(ds.Tables["Delay"].Rows[0][0].ToString()); 
           
            //load the delay tile
            delayLabel.Text = ds.Tables["Delay"].Rows[0][0].ToString();
            subtitleLanguageComboBox.Text = ds.Tables["Language"].Rows[0][0].ToString(); 
            
            //load the language tile
            applicationLanguageComboBox.Text = ds.Tables["Language"].Rows[0][1].ToString();
        }
            
        #endregion readXML
        
        private void loadSettings()
        {

            //Load the microphone tile
            microphoneComboBox.Text = settings.microphone;

            //Load the font tile

            //fontComboBox.Text = ds.Tables["Font"].Rows[0][0].ToString(); 

            Console.WriteLine(fontComboBox.SelectedItem);
            fontComboBox.Text = settings.font;
            fontSizeComboBox.Text = settings.fontsize.ToString();
            subtitleLinesComboBox.Text = settings.lines.ToString();

            //load the subtitle tile
            fontColorPanel.BackColor = settings.subColor;
            fontBackPanel.BackColor = settings.bgColor;

            //load the save tile
            pathTextBox.Text = settings.savePath;
            delayTrackBar.Value = settings.delay;

            //load the delay tile
            delayLabel.Text = settings.delay.ToString();
            subtitleLanguageComboBox.Text = settings.subLanguage;

            //load the language tile
            applicationLanguageComboBox.Text = settings.appLanguage;
        }

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

        private void microphoneTile_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine(microphoneTile.Visible);
            if (microphoneTile.Visible == false) return;
            if (mll != null) mll.stop();
        }
    }
}
