using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Timers;

namespace LifeSubsMetro
{
    class MessageHandler
    {
        private Timer timer;
        GroupConversations gcs;
        string time;
        string userId;
        public MessageHandler(GroupConversations gc)
        {
            this.gcs = gc;
            //Create a timer with a one second interval
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;

            //Get userid to differentiate between message-adding functions
            userId = gcs.userId;
        }

        #region timer
        /// <summary>
        /// Elapsed event for Timer timer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.time = e.SignalTime.ToString();

            //Perfrom HTTP request to get new messages
            //TODO: Base on timestamp/id
            String httpMsg = getMessages();

            //Loop through the Http response and add to Dictionary<string, string> values
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

                //Loop trough Dictionary<string, string> values to seperate items
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
                                gcs.sendMessage(msg);
                            else
                                gcs.receiveMessage(sender, msg);
                            break;
                    }
                }
            }
        }

        public void stopTimer()
        {
            timer.Stop();
        }
        #endregion

        #region request
        private string getMessages()
        {
            return "time_messages|10-10-2010 10:22:11||sender_messages|2||text_messages|DIT IS MIJN BERICHTJE"
                    + "|||"
                    + "time_messages|10-10-2010 10:22:13||sender_messages|1||text_messages|DIT IS EEN BINNENGEKOMEN BERICHTJE|||";

            string path = "http://lifesubs.windesheim.nl/api/messages.php"
                + "?timeID=" + userId
                + "?timeID=" + time;

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
        #endregion
    }
}
