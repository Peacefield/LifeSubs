namespace LifeSubsMetro
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.roomNameBox = new MetroFramework.Controls.MetroTextBox();
            this.tileCreateRoom = new MetroFramework.Controls.MetroTile();
            this.joinRoomButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.joinRoomPanel = new MetroFramework.Controls.MetroPanel();
            this.tileExit = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileSubtitle = new MetroFramework.Controls.MetroTile();
            this.tileJoinRoom = new MetroFramework.Controls.MetroTile();
            this.joinRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(0, 83);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '\0';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(147, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSelectable = true;
            // 
            // roomNameBox
            // 
            this.roomNameBox.Lines = new string[0];
            this.roomNameBox.Location = new System.Drawing.Point(0, 18);
            this.roomNameBox.MaxLength = 32767;
            this.roomNameBox.Name = "roomNameBox";
            this.roomNameBox.PasswordChar = '\0';
            this.roomNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomNameBox.SelectedText = "";
            this.roomNameBox.Size = new System.Drawing.Size(147, 23);
            this.roomNameBox.TabIndex = 0;
            this.roomNameBox.UseSelectable = true;
            // 
            // tileCreateRoom
            // 
            this.tileCreateRoom.ActiveControl = null;
            this.tileCreateRoom.Location = new System.Drawing.Point(380, 60);
            this.tileCreateRoom.Name = "tileCreateRoom";
            this.tileCreateRoom.Size = new System.Drawing.Size(175, 85);
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCreateRoom.TabIndex = 3;
            this.tileCreateRoom.Text = "Creëer kamer";
            this.tileCreateRoom.TileImage = global::LifeSubsMetro.Properties.Resources.Add_Group_64;
            this.tileCreateRoom.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileCreateRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCreateRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCreateRoom.UseSelectable = true;
            this.tileCreateRoom.UseTileImage = true;
            this.tileCreateRoom.MouseEnter += new System.EventHandler(this.tileCreateRoom_MouseEnter);
            this.tileCreateRoom.MouseLeave += new System.EventHandler(this.tileCreateRoom_MouseLeave);
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.Location = new System.Drawing.Point(0, 122);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new System.Drawing.Size(147, 37);
            this.joinRoomButton.TabIndex = 2;
            this.joinRoomButton.Text = "Verbinden";
            this.joinRoomButton.UseSelectable = true;
            this.joinRoomButton.Click += new System.EventHandler(this.joinRoomButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-3, -4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Kamernaam:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Wachtwoord:";
            // 
            // joinRoomPanel
            // 
            this.joinRoomPanel.Controls.Add(this.metroLabel1);
            this.joinRoomPanel.Controls.Add(this.metroLabel2);
            this.joinRoomPanel.Controls.Add(this.passwordBox);
            this.joinRoomPanel.Controls.Add(this.joinRoomButton);
            this.joinRoomPanel.Controls.Add(this.roomNameBox);
            this.joinRoomPanel.HorizontalScrollbarBarColor = true;
            this.joinRoomPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.joinRoomPanel.HorizontalScrollbarSize = 10;
            this.joinRoomPanel.Location = new System.Drawing.Point(212, 62);
            this.joinRoomPanel.Name = "joinRoomPanel";
            this.joinRoomPanel.Size = new System.Drawing.Size(150, 171);
            this.joinRoomPanel.TabIndex = 8;
            this.joinRoomPanel.VerticalScrollbarBarColor = true;
            this.joinRoomPanel.VerticalScrollbarHighlightOnWheel = false;
            this.joinRoomPanel.VerticalScrollbarSize = 10;
            this.joinRoomPanel.Visible = false;
            // 
            // tileExit
            // 
            this.tileExit.ActiveControl = null;
            this.tileExit.Location = new System.Drawing.Point(470, 150);
            this.tileExit.Name = "tileExit";
            this.tileExit.Size = new System.Drawing.Size(85, 85);
            this.tileExit.Style = MetroFramework.MetroColorStyle.Green;
            this.tileExit.TabIndex = 5;
            this.tileExit.TileImage = global::LifeSubsMetro.Properties.Resources.exit_48;
            this.tileExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileExit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileExit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileExit.UseSelectable = true;
            this.tileExit.UseTileImage = true;
            this.tileExit.Click += new System.EventHandler(this.tileExit_Click);
            this.tileExit.MouseEnter += new System.EventHandler(this.tileExit_MouseEnter);
            this.tileExit.MouseLeave += new System.EventHandler(this.tileExit_MouseLeave);
            // 
            // tileSettings
            // 
            this.tileSettings.ActiveControl = null;
            this.tileSettings.Location = new System.Drawing.Point(380, 150);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(85, 85);
            this.tileSettings.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSettings.TabIndex = 2;
            this.tileSettings.TileImage = global::LifeSubsMetro.Properties.Resources.settings_21_48;
            this.tileSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSettings.UseSelectable = true;
            this.tileSettings.UseTileImage = true;
            this.tileSettings.Click += new System.EventHandler(this.tileSettings_Click);
            this.tileSettings.MouseEnter += new System.EventHandler(this.tileSettings_MouseEnter);
            this.tileSettings.MouseLeave += new System.EventHandler(this.tileSettings_MouseLeave);
            // 
            // tileSubtitle
            // 
            this.tileSubtitle.ActiveControl = null;
            this.tileSubtitle.Location = new System.Drawing.Point(20, 60);
            this.tileSubtitle.Name = "tileSubtitle";
            this.tileSubtitle.Size = new System.Drawing.Size(175, 175);
            this.tileSubtitle.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSubtitle.TabIndex = 0;
            this.tileSubtitle.Text = "Start ondertiteling";
            this.tileSubtitle.TileImage = global::LifeSubsMetro.Properties.Resources.broken_lines;
            this.tileSubtitle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSubtitle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSubtitle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSubtitle.UseSelectable = true;
            this.tileSubtitle.UseTileImage = true;
            this.tileSubtitle.Click += new System.EventHandler(this.tileSubtitle_Click);
            this.tileSubtitle.MouseEnter += new System.EventHandler(this.tileSubtitle_MouseEnter);
            this.tileSubtitle.MouseLeave += new System.EventHandler(this.tileSubtitle_MouseLeave);
            // 
            // tileJoinRoom
            // 
            this.tileJoinRoom.ActiveControl = null;
            this.tileJoinRoom.Location = new System.Drawing.Point(200, 60);
            this.tileJoinRoom.Name = "tileJoinRoom";
            this.tileJoinRoom.Size = new System.Drawing.Size(175, 175);
            this.tileJoinRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileJoinRoom.TabIndex = 4;
            this.tileJoinRoom.Text = "Verbind met kamer";
            this.tileJoinRoom.TileImage = global::LifeSubsMetro.Properties.Resources.Groups_Filled_64;
            this.tileJoinRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileJoinRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileJoinRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileJoinRoom.UseSelectable = true;
            this.tileJoinRoom.UseTileImage = true;
            this.tileJoinRoom.Click += new System.EventHandler(this.tileJoinRoom_Click);
            this.tileJoinRoom.MouseEnter += new System.EventHandler(this.tileJoinRoom_MouseEnter);
            this.tileJoinRoom.MouseLeave += new System.EventHandler(this.tileJoinRoom_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 250);
            this.Controls.Add(this.tileJoinRoom);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileCreateRoom);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileSubtitle);
            this.Controls.Add(this.joinRoomPanel);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "LifeSubs";
            this.joinRoomPanel.ResumeLayout(false);
            this.joinRoomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileSubtitle;
        private MetroFramework.Controls.MetroTile tileSettings;
        private MetroFramework.Controls.MetroTile tileJoinRoom;
        private MetroFramework.Controls.MetroTile tileCreateRoom;
        private MetroFramework.Controls.MetroTile tileExit;
        private MetroFramework.Controls.MetroTextBox passwordBox;
        private MetroFramework.Controls.MetroTextBox roomNameBox;
        private MetroFramework.Controls.MetroButton joinRoomButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel joinRoomPanel;

    }
}