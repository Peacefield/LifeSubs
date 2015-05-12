using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSubsMetro
{
    class Settings
    {
        public string microphone { get; set; }
        public string font { get; set; }
        public int fontsize { get; set; }
        public int lines { get; set; }
        public System.Drawing.Color subColor { get; set; }
        public System.Drawing.Color bgColor { get; set; }
        public string savePath { get; set; }
        public int delay { get; set; }
        public string subLanguage { get; set; }
        public string appLanguage { get; set; }

        public Settings()
        {
            loadXML();
        }

        private void loadXML()
        {
            Console.WriteLine("start loading");
            string settingsFile = @"Settings.xml";
            if (!System.IO.File.Exists(settingsFile)) return;

            DataSet ds = new DataSet();
            ds.ReadXml("Settings.xml");

            //Load the microphone tile
            this.microphone = ds.Tables["Microphone"].Rows[0][0].ToString();

            //Load the font tile
            this.font = ds.Tables["Font"].Rows[0][0].ToString(); 
            this.fontsize = Int32.Parse(ds.Tables["Font"].Rows[0][1].ToString());
            this.lines = Int32.Parse(ds.Tables["Subtitle"].Rows[0][0].ToString());
            //load the subtitle tile
            string fontColor = ds.Tables["Subtitle"].Rows[0][1].ToString();
            //Convert the ARGB values correctly 
            string[] fontList = fontColor.Split(new Char[] { ',' });
            subColor = System.Drawing.Color.FromArgb(Int32.Parse(fontList[0]), Int32.Parse(fontList[1]), Int32.Parse(fontList[2]), Int32.Parse(fontList[3]));
            string backColor = ds.Tables["Subtitle"].Rows[0][2].ToString();
            //Convert the ARGB values correctly
            string[] backList = backColor.Split(new Char[] { ',' });
            bgColor = System.Drawing.Color.FromArgb(Int32.Parse(backList[0]), Int32.Parse(backList[1]), Int32.Parse(backList[2]), Int32.Parse(backList[3]));

            //load the save tile
            savePath = ds.Tables["Save"].Rows[0][0].ToString();
            //load the delay tile
            delay = Int32.Parse(ds.Tables["Delay"].Rows[0][0].ToString());
            subLanguage = ds.Tables["Language"].Rows[0][0].ToString();

            //load the language tile
            appLanguage = ds.Tables["Language"].Rows[0][1].ToString();
            Console.WriteLine("done loading");
        }
    }
}
