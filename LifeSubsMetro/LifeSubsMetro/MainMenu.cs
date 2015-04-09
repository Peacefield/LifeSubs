using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void tileSubtitle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Start Subtitling?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.OK)
            {
                Subtitle subtitle = new Subtitle(this);
                subtitle.Visible = true;
                this.Visible = false;
            }
        }

        private void tileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void tileJoinRoom_Click(object sender, EventArgs e)
        {
            this.tileJoinRoom.Visible = false;
            this.joinRoomPanel.Visible = true;
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            this.tileJoinRoom.Visible = true;
            this.joinRoomPanel.Visible = false;
            GroupConversations groupWindow = new GroupConversations(this);
            this.Visible = false;
            groupWindow.Visible = true;
        }


        #endregion
    }
}