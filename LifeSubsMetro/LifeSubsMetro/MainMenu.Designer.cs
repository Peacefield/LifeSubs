﻿namespace LifeSubsMetro
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
            this.tileSubtitle = new MetroFramework.Controls.MetroTile();
            this.tileCreateRoom = new MetroFramework.Controls.MetroTile();
            this.tileJoinRoom = new MetroFramework.Controls.MetroTile();
            this.tileExit = new MetroFramework.Controls.MetroTile();
            this.tileSettings = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileSubtitle
            // 
            this.tileSubtitle.ActiveControl = null;
            this.tileSubtitle.Location = new System.Drawing.Point(23, 63);
            this.tileSubtitle.Name = "tileSubtitle";
            this.tileSubtitle.Size = new System.Drawing.Size(150, 150);
            this.tileSubtitle.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSubtitle.TabIndex = 0;
            this.tileSubtitle.Text = "Start Subtitling";
            this.tileSubtitle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSubtitle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSubtitle.UseSelectable = true;
            this.tileSubtitle.Click += new System.EventHandler(this.tileSubtitle_Click);
            this.tileSubtitle.MouseEnter += new System.EventHandler(this.tileSubtitle_MouseEnter);
            this.tileSubtitle.MouseLeave += new System.EventHandler(this.tileSubtitle_MouseLeave);
            // 
            // tileCreateRoom
            // 
            this.tileCreateRoom.ActiveControl = null;
            this.tileCreateRoom.Location = new System.Drawing.Point(335, 63);
            this.tileCreateRoom.Name = "tileCreateRoom";
            this.tileCreateRoom.Size = new System.Drawing.Size(155, 70);
            this.tileCreateRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileCreateRoom.TabIndex = 3;
            this.tileCreateRoom.Text = "Create Room";
            this.tileCreateRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileCreateRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileCreateRoom.UseSelectable = true;
            this.tileCreateRoom.MouseEnter += new System.EventHandler(this.tileCreateRoom_MouseEnter);
            this.tileCreateRoom.MouseLeave += new System.EventHandler(this.tileCreateRoom_MouseLeave);
            // 
            // tileJoinRoom
            // 
            this.tileJoinRoom.ActiveControl = null;
            this.tileJoinRoom.Location = new System.Drawing.Point(179, 63);
            this.tileJoinRoom.Name = "tileJoinRoom";
            this.tileJoinRoom.Size = new System.Drawing.Size(150, 150);
            this.tileJoinRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.tileJoinRoom.TabIndex = 4;
            this.tileJoinRoom.Text = "Join Room";
            this.tileJoinRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileJoinRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileJoinRoom.UseSelectable = true;
            this.tileJoinRoom.MouseEnter += new System.EventHandler(this.tileJoinRoom_MouseEnter);
            this.tileJoinRoom.MouseLeave += new System.EventHandler(this.tileJoinRoom_MouseLeave);
            // 
            // tileExit
            // 
            this.tileExit.ActiveControl = null;
            this.tileExit.Location = new System.Drawing.Point(416, 139);
            this.tileExit.Name = "tileExit";
            this.tileExit.Size = new System.Drawing.Size(75, 75);
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
            this.tileSettings.Location = new System.Drawing.Point(335, 139);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Size = new System.Drawing.Size(75, 75);
            this.tileSettings.Style = MetroFramework.MetroColorStyle.Green;
            this.tileSettings.TabIndex = 2;
            this.tileSettings.TileImage = global::LifeSubsMetro.Properties.Resources.settings_21_48;
            this.tileSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSettings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileSettings.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileSettings.UseSelectable = true;
            this.tileSettings.UseTileImage = true;
            this.tileSettings.MouseEnter += new System.EventHandler(this.tileSettings_MouseEnter);
            this.tileSettings.MouseLeave += new System.EventHandler(this.tileSettings_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 242);
            this.Controls.Add(this.tileExit);
            this.Controls.Add(this.tileJoinRoom);
            this.Controls.Add(this.tileCreateRoom);
            this.Controls.Add(this.tileSettings);
            this.Controls.Add(this.tileSubtitle);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "LifeSubs";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileSubtitle;
        private MetroFramework.Controls.MetroTile tileSettings;
        private MetroFramework.Controls.MetroTile tileJoinRoom;
        private MetroFramework.Controls.MetroTile tileCreateRoom;
        private MetroFramework.Controls.MetroTile tileExit;

    }
}