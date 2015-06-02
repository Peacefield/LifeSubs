using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    public class ApiHandler
    {
        public ApiHandler()
        {

        }

        public void createRoom(string name, string ip, string pass, string md5Pass, string username, MainMenu mm, Boolean isSubtitle)
        {
            string url = "http://lifesubs.windesheim.nl/api/addRoom.php?func=addRoom&name=" + name + "&ip=" + ip + " &usn=" + username + "&key=" + md5Pass;

            string response;
            bool error;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string[] returnParts = response.Split('|');
                MetroMessageBox.Show(mm, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dictionary<string, string> values = splitReturn(response);
                //Loop trough Dictionary<string, string> values to seperate items
                string roomName = "";
                string userId = "";
                string roomId = "";
                foreach (KeyValuePair<string, string> pair in values)
                {
                    //Console.WriteLine("{0} => {1}",
                    //pair.Key,
                    //pair.Value);

                    switch (pair.Key)
                    {
                        case "roomName":
                            roomName = pair.Value;
                            break;
                        case "userId":
                            userId = pair.Value;
                            break;
                        case "roomId":
                            roomId = pair.Value;
                            break;
                    }
                }

                MetroMessageBox.Show(mm, "De kamernaam is: " + roomName + ".\r\nHet wachtwoord is: " + pass + "\r\n\r\nNoteer deze gegevens - ze zijn nodig voor het inloggen in de zojuist aangemaakte kamer!", "Kamer succesvol aangemaakt!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                foreach (Control c in mm.Controls)
                {
                    if (c.GetType() == typeof(MetroFramework.Controls.MetroTile))
                    {
                        c.Visible = true;
                    }
                }

                if (isSubtitle)
                {
                    Subtitle sub = new Subtitle(mm, this);
                    sub.userId = userId;
                    sub.roomId = roomId;
                    sub.Show();
                }
                else
                {
                    GroupConversations gcs = new GroupConversations(mm);
                    gcs.userId = userId;
                    gcs.roomId = roomId;
                    gcs.roomName = roomName;
                    gcs.ShowDialog();
                }


            }
        }

        public void joinRoom(string name, string key, string ip, string username, MainMenu mm, Boolean isSubtitle)
        {
            string nameEnc = name.Replace("#", "%23");
            string url = "http://lifesubs.windesheim.nl/api/enterRoom.php?func=enterRoom&roomName=" + nameEnc + "&key=" + key + "&ip=" + ip + "&username=" + username;

            Console.WriteLine("Start ----> " + url);

            string response;
            bool error;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string[] returnParts = response.Split('|');
                MetroMessageBox.Show(mm, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dictionary<string, string> values = splitReturn(response);
                //Loop trough Dictionary<string, string> values to seperate items
                string roomName = "";
                string roomId = "";
                string userId = "";
                foreach (KeyValuePair<string, string> pair in values)
                {
                    switch (pair.Key)
                    {
                        case "roomName":
                            roomName = pair.Value;
                            break;
                        case "userid":
                            userId = pair.Value;
                            break;
                        case "roomId":
                            roomId = pair.Value;
                            break;
                    }
                }
                MetroMessageBox.Show(mm, "Welkom in " + roomName + ", " + username, "Succesvol verbonden!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (isSubtitle)
                {
                    Subtitle sub = new Subtitle(mm, this);
                    sub.userId = userId;
                    sub.roomId = roomId;
                    sub.Show();
                }
                else
                {
                    GroupConversations gcs = new GroupConversations(mm);
                    gcs.userId = userId;
                    gcs.roomId = roomId;
                    gcs.roomName = roomName;
                    gcs.ShowDialog();
                }

                foreach (Control c in mm.Controls)
                {
                    if (c.GetType() == typeof(MetroFramework.Controls.MetroTile))
                    {
                        c.Visible = true;
                    }
                }
            }
        }

        public void sendMessage(string roomId, string userId, string msg, GroupConversations gc)
        {
            string time = DateTime.Now.ToString().Replace(" ", "%20");
            string msgEnc = msg.Replace(" ", "%20").Replace("#", "%23").Replace("&", "%26");

            string url = "http://lifesubs.windesheim.nl/api/addMessage.php?func=addMessage&room="
                + roomId
                + "&sender=" + userId
                + "&text=" + msgEnc
                + "&time=" + time;

            Console.WriteLine("Start ----> " + url);

            string response;
            bool error;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string[] returnParts = response.Split('|');
                MetroMessageBox.Show(gc, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (gc != null)
                {
                    gc.clearTextBox();
                }

                //MetroMessageBox.Show(gc, "Verzonden", "Bericht succesvol verzonden!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void getMessages(string messageId, GroupConversations gcs)
        {
            string roomId = gcs.roomId;

            string url = "http://lifesubs.windesheim.nl/api/getMessages.php?func=getMessages"
                + "&room=" + roomId
                + "&messageId=" + messageId;

            Console.WriteLine("Start ----> " + url);

            string response;
            bool error;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string[] returnParts = response.Split('|');
                if (returnParts[1] != "noMessage")
                    MetroMessageBox.Show(gcs, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Dictionary<string, string> values = splitReturn(response);

                string[] splitReq = response.Split(new String[] { "|||" }, StringSplitOptions.None);

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
                    string senderId = "";
                    string senderName = "";
                    string msg = "";
                    string time = "";

                    string logMsg = "";

                    foreach (KeyValuePair<string, string> pair in values)
                    {
                        //Console.WriteLine("{0} => {1}",
                        //pair.Key,
                        //pair.Value);

                        switch (pair.Key)
                        {
                            case "idmessages":
                                gcs.messageId = pair.Value;
                                break;
                            case "sender_messages":
                                senderId = pair.Value;
                                Console.WriteLine("Verzonden door ----->" + senderId);
                                break;
                            case "text_messages":
                                msg = pair.Value;
                                Console.WriteLine("Bericht ----->" + msg);
                                break;
                            case "time_messages":
                                time = pair.Value;
                                break;
                            case "room_messages":
                                break;
                            case "name_user":
                                senderName = pair.Value;

                                logMsg = /*"[" + gcs.messageId + "] " +*/ senderName + ": " + msg;

                                gcs.updateLog(logMsg);

                                if (senderId == gcs.userId)
                                    gcs.sendMessage(msg);
                                else
                                    gcs.receiveMessage(senderName, msg);
                                break;
                        }
                    }
                }
            }
        }

        public void exitRoom(GroupConversations gcs, string id)
        {
            string userId;

            if (id != null)
            {
                userId = id;
            }
            else
            {
                userId = gcs.userId;
            }
            string url = "http://lifesubs.windesheim.nl/api/deleteData.php?func=exitRoom&userid="
                + userId;

            Console.WriteLine("Start ----> " + url);

            string response;
            bool error;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string[] returnParts = response.Split('|');
                MetroMessageBox.Show(gcs, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MetroMessageBox.Show(gcs, "Doei", "Kamer succesvol verlaten!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public Dictionary<string, string> splitReturn(string httpResponse)
        {
            //Loop through the Http response and add to Dictionary<string, string> values
            string[] splitReq = httpResponse.Split(new String[] { "|||" }, StringSplitOptions.None);

            string keyvalue = "key";
            string key = "";
            string value = "";
            Dictionary<string, string> values = null;

            foreach (string s in splitReq)
            {
                values = new Dictionary<string, string>();

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
            }
            return values;
        }
    }
}
