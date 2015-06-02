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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.passwordBox = new MetroFramework.Controls.MetroTextBox();
            this.roomNameBox = new MetroFramework.Controls.MetroTextBox();
            this.joinRoomButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.joinRoomPanel = new MetroFramework.Controls.MetroPanel();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.usernameTB = new MetroFramework.Controls.MetroTextBox();
            this.makeRoomPanel = new System.Windows.Forms.Panel();
            this.addRoomBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.usernameCreateRoomTextbox = new System.Windows.Forms.TextBox();
            this.roomPassCreateRoomTextbox = new System.Windows.Forms.TextBox();
            this.roomNameCreateTextbox = new System.Windows.Forms.TextBox();
            this.subtitleRoomPanel = new System.Windows.Forms.Panel();
            this.subtitleRoomNameTextbox = new System.Windows.Forms.TextBox();
            this.newRoomCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.subtitleUsernameTextbox = new System.Windows.Forms.TextBox();
            this.subtitlePasswordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.roomNameLabel = new MetroFramework.Controls.MetroLabel();
            this.startSubtitlingButton = new MetroFramework.Controls.MetroButton();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.tileExit = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.tileJoinRoom = new MetroFramework.Controls.MetroTile();
            this.tileCreateRoom = new MetroFramework.Controls.MetroTile();
            this.tileSubtitle = new MetroFramework.Controls.MetroTile();
            this.joinRoomPanel.SuspendLayout();
            this.makeRoomPanel.SuspendLayout();
            this.subtitleRoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Lines = new string[0];
            this.passwordBox.Location = new System.Drawing.Point(0, 113);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(147, 23);
            this.passwordBox.TabIndex = 2;
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
            // joinRoomButton
            // 
            this.joinRoomButton.Location = new System.Drawing.Point(0, 142);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new System.Drawing.Size(147, 23);
            this.joinRoomButton.TabIndex = 3;
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
            this.metroLabel2.Location = new System.Drawing.Point(-3, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Wachtwoord:";
            // 
            // joinRoomPanel
            // 
            this.joinRoomPanel.Controls.Add(this.usernameLabel);
            this.joinRoomPanel.Controls.Add(this.usernameTB);
            this.joinRoomPanel.Controls.Add(this.metroLabel1);
            this.joinRoomPanel.Controls.Add(this.metroLabel2);
            this.joinRoomPanel.Controls.Add(this.passwordBox);
            this.joinRoomPanel.Controls.Add(this.joinRoomButton);
            this.joinRoomPanel.Controls.Add(this.roomNameBox);
            this.joinRoomPanel.HorizontalScrollbarBarColor = true;
            this.joinRoomPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.joinRoomPanel.HorizontalScrollbarSize = 10;
            this.joinRoomPanel.Location = new System.Drawing.Point(232, 76);
            this.joinRoomPanel.Name = "joinRoomPanel";
            this.joinRoomPanel.Size = new System.Drawing.Size(150, 171);
            this.joinRoomPanel.TabIndex = 8;
            this.joinRoomPanel.VerticalScrollbarBarColor = true;
            this.joinRoomPanel.VerticalScrollbarHighlightOnWheel = false;
            this.joinRoomPanel.VerticalScrollbarSize = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(-3, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 19);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Gebruikersnaam";
            // 
            // usernameTB
            // 
            this.usernameTB.Lines = new string[0];
            this.usernameTB.Location = new System.Drawing.Point(0, 63);
            this.usernameTB.MaxLength = 32767;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(147, 23);
            this.usernameTB.TabIndex = 1;
            this.usernameTB.UseSelectable = true;
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
            this.makeRoomPanel.Location = new System.Drawing.Point(433, 72);
            this.makeRoomPanel.Name = "makeRoomPanel";
            this.makeRoomPanel.Size = new System.Drawing.Size(174, 175);
            this.makeRoomPanel.TabIndex = 9;
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Location = new System.Drawing.Point(4, 135);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(166, 37);
            this.addRoomBtn.TabIndex = 3;
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
            // subtitleRoomPanel
            // 
            this.subtitleRoomPanel.Controls.Add(this.subtitleRoomNameTextbox);
            this.subtitleRoomPanel.Controls.Add(this.newRoomCheckbox);
            this.subtitleRoomPanel.Controls.Add(this.subtitleUsernameTextbox);
            this.subtitleRoomPanel.Controls.Add(this.subtitlePasswordTextbox);
            this.subtitleRoomPanel.Controls.Add(this.passwordLabel);
            this.subtitleRoomPanel.Controls.Add(this.nameLabel);
            this.subtitleRoomPanel.Controls.Add(this.roomNameLabel);
            this.subtitleRoomPanel.Controls.Add(this.startSubtitlingButton);
            this.subtitleRoomPanel.Controls.Add(this.loginButton);
            this.subtitleRoomPanel.Location = new System.Drawing.Point(20, 58);
            this.subtitleRoomPanel.Name = "subtitleRoomPanel";
            this.subtitleRoomPanel.Size = new System.Drawing.Size(179, 200);
            this.subtitleRoomPanel.TabIndex = 10;
            this.subtitleRoomPanel.Visible = false;
            // 
            // subtitleRoomNameTextbox
            // 
            this.subtitleRoomNameTextbox.Location = new System.Drawing.Point(3, 41);
            this.subtitleRoomNameTextbox.Name = "subtitleRoomNameTextbox";
            this.subtitleRoomNameTextbox.Size = new System.Drawing.Size(167, 20);
            this.subtitleRoomNameTextbox.TabIndex = 0;
            // 
            // newRoomCheckbox
            // 
            this.newRoomCheckbox.AutoSize = true;
            this.newRoomCheckbox.Location = new System.Drawing.Point(3, 8);
            this.newRoomCheckbox.Name = "newRoomCheckbox";
            this.newRoomCheckbox.Size = new System.Drawing.Size(162, 15);
            this.newRoomCheckbox.TabIndex = 8;
            this.newRoomCheckbox.Text = "Nieuwe kamer aanmaken?";
            this.newRoomCheckbox.UseSelectable = true;
            this.newRoomCheckbox.CheckedChanged += new System.EventHandler(this.newRoomCheckbox_CheckedChanged);
            // 
            // subtitleUsernameTextbox
            // 
            this.subtitleUsernameTextbox.Location = new System.Drawing.Point(3, 115);
            this.subtitleUsernameTextbox.Name = "subtitleUsernameTextbox";
            this.subtitleUsernameTextbox.Size = new System.Drawing.Size(167, 20);
            this.subtitleUsernameTextbox.TabIndex = 2;
            // 
            // subtitlePasswordTextbox
            // 
            this.subtitlePasswordTextbox.Location = new System.Drawing.Point(3, 79);
            this.subtitlePasswordTextbox.Name = "subtitlePasswordTextbox";
            this.subtitlePasswordTextbox.Size = new System.Drawing.Size(167, 20);
            this.subtitlePasswordTextbox.TabIndex = 1;
            this.subtitlePasswordTextbox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(0, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 19);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Wachtwoord";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 19);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Gebruikersnaam";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(0, 24);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(80, 19);
            this.roomNameLabel.TabIndex = 5;
            this.roomNameLabel.Text = "Kamernaam";
            // 
            // startSubtitlingButton
            // 
            this.startSubtitlingButton.Location = new System.Drawing.Point(3, 169);
            this.startSubtitlingButton.Name = "startSubtitlingButton";
            this.startSubtitlingButton.Size = new System.Drawing.Size(167, 25);
            this.startSubtitlingButton.TabIndex = 4;
            this.startSubtitlingButton.Text = "Zonder kamer gebruiken";
            this.startSubtitlingButton.UseSelectable = true;
            this.startSubtitlingButton.Click += new System.EventHandler(this.startSubtitlingButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(3, 141);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(167, 25);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log in";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tileExit
            // 
            this.tileExit.ActiveControl = null;
            this.tileExit.Location = new System.Drawing.Point(626, 161);
            this.tileExit.Name = "tileExit";
            this.tileExit.Size = new System.Drawing.Size(95, 97);
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
            this.tileSettings.Location = new System.Drawing.Point(626, 58);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(95, 97);
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
            // tileJoinRoom
            // 
            this.tileJoinRoom.ActiveControl = null;
            this.tileJoinRoom.Location = new System.Drawing.Point(214, 58);
            this.tileJoinRoom.Name = "tileJoinRoom";
            this.tileJoinRoom.Size = new System.Drawing.Size(200, 200);
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
            // tileCreateRoom
            // 
            this.tileCreateRoom.ActiveControl = null;
            this.tileCreateRoom.Location = new System.Drawing.Point(420, 58);
            this.tileCreateRoom.Name = "tileCreateRoom";
            this.tileCreateRoom.Size = new System.Drawing.Size(200, 200);
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCreateRoom.TabIndex = 3;
            this.tileCreateRoom.Text = "Creëer kamer";
            this.tileCreateRoom.TileImage = global::LifeSubsMetro.Properties.Resources.Add_Group_100;
            this.tileCreateRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCreateRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCreateRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCreateRoom.UseSelectable = true;
            this.tileCreateRoom.UseTileImage = true;
            this.tileCreateRoom.Click += new System.EventHandler(this.tileCreateRoom_Click);
            this.tileCreateRoom.MouseEnter += new System.EventHandler(this.tileCreateRoom_MouseEnter);
            this.tileCreateRoom.MouseLeave += new System.EventHandler(this.tileCreateRoom_MouseLeave);
            // 
            // tileSubtitle
            // 
            this.tileSubtitle.ActiveControl = null;
            this.tileSubtitle.Location = new System.Drawing.Point(8, 58);
            this.tileSubtitle.Name = "tileSubtitle";
            this.tileSubtitle.Size = new System.Drawing.Size(200, 200);
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 270);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileJoinRoom);
            this.Controls.Add(this.tileCreateRoom);
            this.Controls.Add(this.joinRoomPanel);
            this.Controls.Add(this.makeRoomPanel);
            this.Controls.Add(this.tileSubtitle);
            this.Controls.Add(this.subtitleRoomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.subtitleRoomPanel.ResumeLayout(false);
            this.subtitleRoomPanel.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox usernameCreateRoomTextbox;
        private System.Windows.Forms.TextBox roomPassCreateRoomTextbox;
        private System.Windows.Forms.TextBox roomNameCreateTextbox;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroTextBox usernameTB;
        private MetroFramework.Controls.MetroButton addRoomBtn;
        private System.Windows.Forms.Panel subtitleRoomPanel;
        private System.Windows.Forms.TextBox subtitleUsernameTextbox;
        private System.Windows.Forms.TextBox subtitlePasswordTextbox;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel roomNameLabel;
        private MetroFramework.Controls.MetroButton startSubtitlingButton;
        private MetroFramework.Controls.MetroButton loginButton;
        private System.Windows.Forms.TextBox subtitleRoomNameTextbox;
        private MetroFramework.Controls.MetroCheckBox newRoomCheckbox;

    }
}