using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using LifeSubsMetro.Properties

namespace LifeSubsMetro
{
    public partial class MainMenu : MetroForm
    {
        ServerSocket ss = null;
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Tile click eventhandlers
        /// <summary>
        /// Starts subtitle mode
        /// If no valid michrophone was selected the user gets prompted that no mic has been found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileSubtitle_Click(object sender, EventArgs e)
        {
            showTiles();
            Settings settings = new Settings();
            if (settings.microphone == -1)
            {
                MetroMessageBox.Show(this, "Microfoon niet gevonden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Subtitle subtitle = new Subtitle(this);
            subtitle.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Hides tileJoinRoom to show joinRoomPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileJoinRoom_Click(object sender, EventArgs e)
        {
            showTiles();
            this.tileJoinRoom.Visible = false;
            this.tileCreateRoom.Visible = true;
        }

        private void showTiles()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(MetroFramework.Controls.MetroTile))
                {
                    c.Visible = true;
                }
            }
        }
        /// <summary>
        /// Start groupconversation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            this.tileJoinRoom.Visible = true;

            string iptojoin = getOwnIp();
            //string iptojoin = "localHost";

            GroupConversations groupWindow = new GroupConversations(this, iptojoin);
            this.Visible = false;
            groupWindow.Visible = true;
        }

        /// <summary>
        /// Start settingsmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileSettings_Click(object sender, EventArgs e)
        {
            showTiles();
            new SettingsMenu(this).ShowDialog();
        }
        #endregion

        #region hoverEvents
        private void tileSubtitle_MouseEnter(object sender, EventArgs e)
        {
            this.tileSubtitle.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void tileSubtitle_MouseLeave(object sender, EventArgs e)
        {
            this.tileSubtitle.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void tileSettings_MouseEnter(object sender, EventArgs e)
        {
            this.tileSettings.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void tileSettings_MouseLeave(object sender, EventArgs e)
        {
            this.tileSettings.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void tileCreateRoom_MouseEnter(object sender, EventArgs e)
        {
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void tileCreateRoom_MouseLeave(object sender, EventArgs e)
        {
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void tileJoinRoom_MouseEnter(object sender, EventArgs e)
        {
            this.tileJoinRoom.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void tileJoinRoom_MouseLeave(object sender, EventArgs e)
        {
            this.tileJoinRoom.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void tileExit_MouseEnter(object sender, EventArgs e)
        {
            this.tileExit.Style = MetroFramework.MetroColorStyle.Lime;
        }

        private void tileExit_MouseLeave(object sender, EventArgs e)
        {
            this.tileExit.Style = MetroFramework.MetroColorStyle.Green;
        }

        #endregion

        private string toMD5(string pass)
        {
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(pass);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
                // without dashes
               .Replace("-", string.Empty)
                // make lowercase
               .ToLower();

            // encoded contains the hash you are wanting

            return encoded;
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            ss = new ServerSocket(this);
            tileCreateRoom.Visible = true;
            return;

            string roomName = roomNameCreateTextbox.Text;
            string roomPass = roomPassCreateRoomTextbox.Text;
            string roomUsername = usernameCreateRoomTextbox.Text;
            
            string response;
            bool error;

            string roomPassMD5 = toMD5(roomPass);

            string url = "http://lifesubs.windesheim.nl/api/addRoomTest.php?func=addRoom&name=" + roomName + "&ip=[IPADRES_AANMAKER]&usn=" + roomUsername + "&key=" + roomPassMD5;

            using (var wb = new WebClient())
            {
                response = wb.DownloadString(url);
                Console.WriteLine(response);
            }

            error = response.Contains("error");

            if (error)
            {
                string [] returnParts = response.Split('|');
                MetroMessageBox.Show(this, returnParts[1], "Oeps! Er is iets foutgegaan:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, "De kamernaam is: " + response + ".\r\nHet wachtwoord is: " + roomPass + "\r\n\r\nNoteer deze gegevens - ze zijn nodig voor het inloggen in de zojuist aangemaakte kamer!", "Kamer succesvol aangemaakt!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    //serverThread.Abort();
            //    //serverThread.Join();
            //}
            //catch (Exception eex)
            //{
            //    Console.WriteLine(eex); ;
            //}
            //closeRoom();
        }

        private void tileCreateRoom_Click(object sender, EventArgs e)
        {
            tileJoinRoom.Visible = true;
            tileCreateRoom.Visible = false;
        }

        public void closeRoom()
        {
            if (ss != null) ss.Destroy();
        }







        //REMOVE
        private string getOwnIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            Console.WriteLine(host);

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}