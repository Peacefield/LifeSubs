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
            this.makeRoomPanel = new System.Windows.Forms.Panel();
            this.addRoomBtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.usernameCreateRoomTextbox = new System.Windows.Forms.TextBox();
            this.roomPassCreateRoomTextbox = new System.Windows.Forms.TextBox();
            this.roomNameCreateTextbox = new System.Windows.Forms.TextBox();
            this.joinRoomPanel.SuspendLayout();
            this.makeRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(0, 83);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(147, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSelectable = true;
            this.passwordBox.UseSystemPasswordChar = true;
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
            this.tileCreateRoom.Location = new System.Drawing.Point(381, 60);
            this.tileCreateRoom.Name = "tileCreateRoom";
            this.tileCreateRoom.Size = new System.Drawing.Size(175, 175);
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCreateRoom.TabIndex = 3;
            this.tileCreateRoom.Text = "Creëer kamer";
            this.tileCreateRoom.TileImage = global::LifeSubsMetro.Properties.Resources.Add_Group_64;
            this.tileCreateRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCreateRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCreateRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCreateRoom.UseSelectable = true;
            this.tileCreateRoom.UseTileImage = true;
            this.tileCreateRoom.Click += new System.EventHandler(this.tileCreateRoom_Click);
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
            // 
            // tileExit
            // 
            this.tileExit.ActiveControl = null;
            this.tileExit.Location = new System.Drawing.Point(561, 150);
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
            this.tileSettings.Location = new System.Drawing.Point(561, 60);
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
            // makeRoomPanel
            // 
            this.makeRoomPanel.Controls.Add(this.addRoomBtn);
            this.makeRoomPanel.Controls.Add(this.metroLabel5);
            this.makeRoomPanel.Controls.Add(this.metroLabel4);
            this.makeRoomPanel.Controls.Add(this.metroLabel3);
            this.makeRoomPanel.Controls.Add(this.usernameCreateRoomTextbox);
            this.makeRoomPanel.Controls.Add(this.roomPassCreateRoomTextbox);
            this.makeRoomPanel.Controls.Add(this.roomNameCreateTextbox);
            this.makeRoomPanel.Location = new System.Drawing.Point(381, 60);
            this.makeRoomPanel.Name = "makeRoomPanel";
            this.makeRoomPanel.Size = new System.Drawing.Size(174, 175);
            this.makeRoomPanel.TabIndex = 9;
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.ActiveControl = null;
            this.addRoomBtn.Location = new System.Drawing.Point(4, 136);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(167, 23);
            this.addRoomBtn.TabIndex = 6;
            this.addRoomBtn.Text = "Creëer kamer";
            this.addRoomBtn.UseSelectable = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(1, 88);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Eigen gebruikersnaam";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(4, 45);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Kamerwachtwoord";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 2);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Kamernaam:";
            // 
            // usernameCreateRoomTextbox
            // 
            this.usernameCreateRoomTextbox.Location = new System.Drawing.Point(3, 109);
            this.usernameCreateRoomTextbox.Name = "usernameCreateRoomTextbox";
            this.usernameCreateRoomTextbox.Size = new System.Drawing.Size(167, 20);
            this.usernameCreateRoomTextbox.TabIndex = 2;
            // 
            // roomPassCreateRoomTextbox
            // 
            this.roomPassCreateRoomTextbox.Location = new System.Drawing.Point(3, 65);
            this.roomPassCreateRoomTextbox.Name = "roomPassCreateRoomTextbox";
            this.roomPassCreateRoomTextbox.Size = new System.Drawing.Size(167, 20);
            this.roomPassCreateRoomTextbox.TabIndex = 1;
            this.roomPassCreateRoomTextbox.UseSystemPasswordChar = true;
            // 
            // roomNameCreateTextbox
            // 
            this.roomNameCreateTextbox.Location = new System.Drawing.Point(4, 22);
            this.roomNameCreateTextbox.Name = "roomNameCreateTextbox";
            this.roomNameCreateTextbox.Size = new System.Drawing.Size(167, 20);
            this.roomNameCreateTextbox.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 250);
            this.Controls.Add(this.tileJoinRoom);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileSubtitle);
            this.Controls.Add(this.joinRoomPanel);
            this.Controls.Add(this.tileCreateRoom);
            this.Controls.Add(this.makeRoomPanel);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "LifeSubs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.joinRoomPanel.ResumeLayout(false);
            this.joinRoomPanel.PerformLayout();
            this.makeRoomPanel.ResumeLayout(false);
            this.makeRoomPanel.PerformLayout();
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
        private System.Windows.Forms.Panel makeRoomPanel;
        private MetroFramework.Controls.MetroTile addRoomBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox usernameCreateRoomTextbox;
        private System.Windows.Forms.TextBox roomPassCreateRoomTextbox;
        private System.Windows.Forms.TextBox roomNameCreateTextbox;

    }
}