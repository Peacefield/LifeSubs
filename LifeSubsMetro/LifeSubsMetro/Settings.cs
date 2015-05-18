﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSubsMetro
{
    class Settings
    {
        //public string microphone { get; set; }  //TODO: Change to selectedindex        
        public int microphone { get; set; }  //TODO: Change to selectedindex
        public string font { get; set; }
        public int fontsize { get; set; }
        public int lines { get; set; }
        public System.Drawing.Color subColor { get; set; }
        public System.Drawing.Color bgColor { get; set; }
        public string savePath { get; set; }
        public int delay { get; set; }
        public string subLanguage { get; set; }
        public string appLanguage { get; set; }
        string settingsFile = @"Settings.xml";

        public Settings()
        {
            try
            {
                loadXML();
            }
            catch (FileNotFoundException)
            {
                createDefault();
            }
        }

        /// <summary>
        /// Function to give the application default settings
        /// </summary>
        private void createDefault()
        {
            this.microphone = -1;
            this.font = "Arial";
            this.fontsize = 20;
            this.lines = 3;
            this.subColor = System.Drawing.Color.Black;
            this.bgColor = System.Drawing.Color.White;
            this.savePath = @"log.txt";
            this.delay = 1;
            this.subLanguage = "Nederlands";
            this.appLanguage = "Nederlands";
        }

        private void loadXML()
        {
            Console.WriteLine("start loading");

            DataSet ds = new DataSet();
            ds.ReadXml(settingsFile);

            //Load the microphone tile
            this.microphone = Int32.Parse(ds.Tables["Microphone"].Rows[0][0].ToString());

            //Load the font tile
            this.font = ds.Tables["Font"].Rows[0][0].ToString(); 
            this.fontsize = Int32.Parse(ds.Tables["Font"].Rows[0][1].ToString());
            this.lines = Int32.Parse(ds.Tables["Subtitle"].Rows[0][0].ToString());
            //load the subtitle tile
            string fontColor = ds.Tables["Subtitle"].Rows[0][1].ToString();
            //Convert the ARGB values correctly 
            string[] fontList = fontColor.Split(new Char[] { ',' });
            this.subColor = System.Drawing.Color.FromArgb(Int32.Parse(fontList[0]), Int32.Parse(fontList[1]), Int32.Parse(fontList[2]), Int32.Parse(fontList[3]));
            string backColor = ds.Tables["Subtitle"].Rows[0][2].ToString();
            //Convert the ARGB values correctly
            string[] backList = backColor.Split(new Char[] { ',' });
            this.bgColor = System.Drawing.Color.FromArgb(Int32.Parse(backList[0]), Int32.Parse(backList[1]), Int32.Parse(backList[2]), Int32.Parse(backList[3]));

            //load the save tile
            this.savePath = ds.Tables["Save"].Rows[0][0].ToString();
            //load the delay tile
            this.delay = Int32.Parse(ds.Tables["Delay"].Rows[0][0].ToString());
            this.subLanguage = ds.Tables["Language"].Rows[0][0].ToString();

            //load the language tile
            this.appLanguage = ds.Tables["Language"].Rows[0][1].ToString();
            Console.WriteLine("done loading");
        }
    }
}