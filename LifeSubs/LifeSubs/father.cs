using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LifeSubs
{
    
    public class Father
    {
        public static string ACCESS_GOOGLE_SPEECH_KEY = "AIzaSyA9lHYaBSRVWuI5CyDTKGzYC4GV8AvqCus";
        public static string TEST_NEW_PATH_2014_PART =
        "https://www.google.com/speech-api/v2/recognize?output=json&lang=en-us&key=";

        public static string NOT_MY_KEY = "AIzaSyCnl6MRydhw_5fLXIdASxkLJzcJh5iX0M4";
        public Form1 form1;

        public Father(Form1 form)
        {
           form1 = form;
        }

        public String GoogleSpeechRequest(String flacName, int sampleRate)
        {
            try
            {
                String PATH = TEST_NEW_PATH_2014_PART + ACCESS_GOOGLE_SPEECH_KEY;
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(PATH);
                request.Method = "POST";
                byte[] byteArray = File.ReadAllBytes(flacName);
                sampleRate = 44100;
                request.ContentType = "audio/x-flac; rate=" + sampleRate.ToString();
                request.ContentLength = byteArray.Length;
                Stream sendStream = request.GetRequestStream();
                sendStream.Write(byteArray, 0, byteArray.Length);
                sendStream.Close();
                string responseFromServer;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                return responseFromServer;
            }
            catch(Exception e)
            {
                //form1.label1.Text = "Er is een fout opgetreden. Google speech kon niet benaderd worden...";
                form1.label1.Text = e.ToString();
                Console.WriteLine(e);
                return e.ToString();
            }
            
        } 
        
    }
}
