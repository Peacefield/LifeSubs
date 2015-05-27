using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LifeSubsMetro
{
    class MessageHandler
    {
        private Timer aTimer;
        GroupConversations gcs;
        string time;
        string userId;
        public MessageHandler(GroupConversations gc)
        {
            this.gcs = gc;
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;

            userId = gcs.userId;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.time = e.SignalTime.ToString();
            //Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

            //Perfrom HTTP request to get new messages

            String httpMsg = getMessages();

            string[] splitReq = httpMsg.Split(new String[] { "|||" }, StringSplitOptions.None);

            string keyvalue = "key";
            string key = "";
            string value = "";



            foreach (string s in splitReq)
            {
                Dictionary<string, string> values = new Dictionary<string, string>();

                if (s.Trim() != "")
                {
                    string[] splitArray = s.Split(new String[] { "||" }, StringSplitOptions.None);
                    foreach (string array in splitArray)
                    {
                        if (array.Trim() != "")
                        {
                            string[] splitItems = array.Split(new String[] { "|" }, StringSplitOptions.None);
                            foreach (string item in splitItems)
                            {
                                if (item.Trim() != "")
                                {
                                    switch (keyvalue)
                                    {
                                        case "key":
                                            key = item;
                                            keyvalue = "value";
                                            break;
                                        case "value":
                                            value = item;
                                            keyvalue = "key";

                                            values.Add(key, value);
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }

                string sender = "";
                string msg = "";
                string time = "";
                foreach (KeyValuePair<string, string> pair in values)
                {
                    //Console.WriteLine("{0} => {1}",
                    //pair.Key,
                    //pair.Value);

                    switch (pair.Key)
                    {
                        case "time_messages":
                            time = pair.Value;
                            break;
                        case "sender_messages":
                            sender = pair.Value;
                            break;
                        case "text_messages":
                            msg = pair.Value;
                            if (sender == gcs.userId)
                                gcs.sendMessage(msg, Color.PowderBlue);
                            else
                                gcs.receiveMessage(sender, msg, Color.Red);
                            break;
                    }
                }
            }

            //if (user == "localip")
            //    gcs.sendMessage("Bericht", Color.PowderBlue);
            //if(user == "remoteip")
            //    gcs.receiveMessage("Jan", "Bericht", Color.Red);
        }


        public void stopTimer()
        {
            aTimer.Stop();
        }

        private string getMessages()
        {
            //return "time_messages|10-10-2010 10:22:11||sender_messages|1||text_messages|DIT IS EEN KNETTERSTOER BERICHTJE|||time_messages|10-10-2010 10:22:13||sender_messages|1||text_messages|RICARDO HEEFT EEN POEPSNOR|||";

            string path = "http://lifesubs.windesheim.nl/api/messages.php";
            Console.WriteLine("request started: " + path);
            string result;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);

                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                Stream stream = request.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(stream);

                result = sr.ReadToEnd();

                sr.Close();
                stream.Close();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        if ((int)response.StatusCode == 500)
                        {
                            Console.WriteLine("HTTP Status Code: " + (int)response.StatusCode);
                            result = "500";
                        }
                        else
                        {
                            Console.WriteLine("HTTP Status Code: " + (int)response.StatusCode);
                            result = "";
                        }
                    }
                    else
                    {
                        // no http status code available
                        Console.WriteLine("ProtocolError: " + ex.Status);
                        result = "";
                    }
                }
                else
                {
                    // no http status code available
                    Console.WriteLine(ex.Status.ToString());
                    result = "";
                }
            }

            return result;
        }
    }
}
