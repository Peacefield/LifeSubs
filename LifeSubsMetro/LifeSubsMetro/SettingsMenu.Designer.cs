namespace LifeSubsMetro
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.microphoneButton = new MetroFramework.Controls.MetroButton();
            this.microphoneComboBox = new MetroFramework.Controls.MetroComboBox();
            this.microphoneLabel = new System.Windows.Forms.Label();
            this.microphonePanel = new System.Windows.Forms.Panel();
            this.microphoneProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.fontPanel = new System.Windows.Forms.Panel();
            this.fontSizeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontButton = new MetroFramework.Controls.MetroButton();
            this.volumePanel = new System.Windows.Forms.Panel();
            this.fontBackPanel = new System.Windows.Forms.Panel();
            this.fontColorPanel = new System.Windows.Forms.Panel();
            this.subtitleBackgroundColorLabel = new MetroFramework.Controls.MetroLabel();
            this.subtitleColorLabel = new MetroFramework.Controls.MetroLabel();
            this.subtitleLinesLabel = new MetroFramework.Controls.MetroLabel();
            this.subtitleLinesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.linesLabel = new System.Windows.Forms.Label();
            this.linesButton = new MetroFramework.Controls.MetroButton();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.backColorDialog = new System.Windows.Forms.ColorDialog();
            this.savePanel = new System.Windows.Forms.Panel();
            this.pathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pathButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.delayPanel = new System.Windows.Forms.Panel();
            this.delayLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.delayTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.delayButton = new MetroFramework.Controls.MetroButton();
            this.languagePanel = new System.Windows.Forms.Panel();
            this.applicationLanguageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subtitleLanguageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.languageButton = new MetroFramework.Controls.MetroButton();
            this.languageTile = new MetroFramework.Controls.MetroTile();
            this.fontTile = new MetroFramework.Controls.MetroTile();
            this.microphoneTile = new MetroFramework.Controls.MetroTile();
            this.saveTile = new MetroFramework.Controls.MetroTile();
            this.linesTile = new MetroFramework.Controls.MetroTile();
            this.delayTile = new MetroFramework.Controls.MetroTile();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontComboBox = new LifeSubsMetro.FontComboBox();
            this.microphonePanel.SuspendLayout();
            this.fontPanel.SuspendLayout();
            this.volumePanel.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.delayPanel.SuspendLayout();
            this.languagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // microphoneButton
            // 
            this.microphoneButton.Location = new System.Drawing.Point(5, 154);
            this.microphoneButton.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneButton.Name = "microphoneButton";
            this.microphoneButton.Size = new System.Drawing.Size(192, 28);
            this.microphoneButton.TabIndex = 1;
            this.microphoneButton.Text = "Opslaan";
            this.microphoneButton.UseSelectable = true;
            this.microphoneButton.Click += new System.EventHandler(this.microphoneButton_Click);
            // 
            // microphoneComboBox
            // 
            this.microphoneComboBox.FormattingEnabled = true;
            this.microphoneComboBox.ItemHeight = 23;
            this.microphoneComboBox.Location = new System.Drawing.Point(4, 34);
            this.microphoneComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneComboBox.Name = "microphoneComboBox";
            this.microphoneComboBox.Size = new System.Drawing.Size(192, 29);
            this.microphoneComboBox.TabIndex = 2;
            this.microphoneComboBox.UseSelectable = true;
            this.microphoneComboBox.SelectedIndexChanged += new System.EventHandler(this.microphoneComboBox_SelectedIndexChanged);
            // 
            // microphoneLabel
            // 
            this.microphoneLabel.AutoSize = true;
            this.microphoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.microphoneLabel.Location = new System.Drawing.Point(0, 1);
            this.microphoneLabel.Name = "microphoneLabel";
            this.microphoneLabel.Size = new System.Drawing.Size(126, 29);
            this.microphoneLabel.TabIndex = 0;
            this.microphoneLabel.Text = "Microfoon:";
            // 
            // microphonePanel
            // 
            this.microphonePanel.Controls.Add(this.microphoneProgressBar);
            this.microphonePanel.Controls.Add(this.microphoneLabel);
            this.microphonePanel.Controls.Add(this.microphoneButton);
            this.microphonePanel.Controls.Add(this.microphoneComboBox);
            this.microphonePanel.Location = new System.Drawing.Point(16, 78);
            this.microphonePanel.Name = "microphonePanel";
            this.microphonePanel.Size = new System.Drawing.Size(200, 200);
            this.microphonePanel.TabIndex = 3;
            // 
            // microphoneProgressBar
            // 
            this.microphoneProgressBar.Location = new System.Drawing.Point(5, 72);
            this.microphoneProgressBar.Maximum = 300;
            this.microphoneProgressBar.Name = "microphoneProgressBar";
            this.microphoneProgressBar.Size = new System.Drawing.Size(191, 23);
            this.microphoneProgressBar.TabIndex = 3;
            this.microphoneProgressBar.Value = 10;
            // 
            // fontPanel
            // 
            this.fontPanel.Controls.Add(this.fontComboBox);
            this.fontPanel.Controls.Add(this.fontSizeComboBox);
            this.fontPanel.Controls.Add(this.fontLabel);
            this.fontPanel.Controls.Add(this.fontButton);
            this.fontPanel.Location = new System.Drawing.Point(223, 79);
            this.fontPanel.Name = "fontPanel";
            this.fontPanel.Size = new System.Drawing.Size(200, 200);
            this.fontPanel.TabIndex = 4;
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.ItemHeight = 23;
            this.fontSizeComboBox.Location = new System.Drawing.Point(142, 32);
            this.fontSizeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(54, 29);
            this.fontSizeComboBox.TabIndex = 3;
            this.fontSizeComboBox.UseSelectable = true;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontLabel.Location = new System.Drawing.Point(0, 1);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(125, 29);
            this.fontLabel.TabIndex = 0;
            this.fontLabel.Text = "Lettertype:";
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(4, 153);
            this.fontButton.Margin = new System.Windows.Forms.Padding(4);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(192, 28);
            this.fontButton.TabIndex = 1;
            this.fontButton.Text = "Opslaan";
            this.fontButton.UseSelectable = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // volumePanel
            // 
            this.volumePanel.Controls.Add(this.fontBackPanel);
            this.volumePanel.Controls.Add(this.fontColorPanel);
            this.volumePanel.Controls.Add(this.subtitleBackgroundColorLabel);
            this.volumePanel.Controls.Add(this.subtitleColorLabel);
            this.volumePanel.Controls.Add(this.subtitleLinesLabel);
            this.volumePanel.Controls.Add(this.subtitleLinesComboBox);
            this.volumePanel.Controls.Add(this.linesLabel);
            this.volumePanel.Controls.Add(this.linesButton);
            this.volumePanel.Location = new System.Drawing.Point(429, 79);
            this.volumePanel.Name = "volumePanel";
            this.volumePanel.Size = new System.Drawing.Size(200, 200);
            this.volumePanel.TabIndex = 6;
            // 
            // fontBackPanel
            // 
            this.fontBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontBackPanel.Location = new System.Drawing.Point(138, 112);
            this.fontBackPanel.Name = "fontBackPanel";
            this.fontBackPanel.Size = new System.Drawing.Size(54, 31);
            this.fontBackPanel.TabIndex = 8;
            this.fontBackPanel.Click += new System.EventHandler(this.fontBackPanel_Click);
            // 
            // fontColorPanel
            // 
            this.fontColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontColorPanel.Location = new System.Drawing.Point(138, 78);
            this.fontColorPanel.Name = "fontColorPanel";
            this.fontColorPanel.Size = new System.Drawing.Size(54, 31);
            this.fontColorPanel.TabIndex = 7;
            this.fontColorPanel.Click += new System.EventHandler(this.fontColorPanel_Click);
            // 
            // subtitleBackgroundColorLabel
            // 
            this.subtitleBackgroundColorLabel.AutoSize = true;
            this.subtitleBackgroundColorLabel.Location = new System.Drawing.Point(4, 112);
            this.subtitleBackgroundColorLabel.Name = "subtitleBackgroundColorLabel";
            this.subtitleBackgroundColorLabel.Size = new System.Drawing.Size(117, 19);
            this.subtitleBackgroundColorLabel.TabIndex = 9;
            this.subtitleBackgroundColorLabel.Text = "Kleur achtergrond:";
            // 
            // subtitleColorLabel
            // 
            this.subtitleColorLabel.AutoSize = true;
            this.subtitleColorLabel.Location = new System.Drawing.Point(4, 83);
            this.subtitleColorLabel.Name = "subtitleColorLabel";
            this.subtitleColorLabel.Size = new System.Drawing.Size(102, 19);
            this.subtitleColorLabel.TabIndex = 8;
            this.subtitleColorLabel.Text = "Kleur ondertitel:";
            // 
            // subtitleLinesLabel
            // 
            this.subtitleLinesLabel.AutoSize = true;
            this.subtitleLinesLabel.Location = new System.Drawing.Point(4, 42);
            this.subtitleLinesLabel.Name = "subtitleLinesLabel";
            this.subtitleLinesLabel.Size = new System.Drawing.Size(88, 19);
            this.subtitleLinesLabel.TabIndex = 7;
            this.subtitleLinesLabel.Text = "Aantal regels:";
            // 
            // subtitleLinesComboBox
            // 
            this.subtitleLinesComboBox.FormattingEnabled = true;
            this.subtitleLinesComboBox.ItemHeight = 23;
            this.subtitleLinesComboBox.Location = new System.Drawing.Point(138, 42);
            this.subtitleLinesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subtitleLinesComboBox.Name = "subtitleLinesComboBox";
            this.subtitleLinesComboBox.Size = new System.Drawing.Size(54, 29);
            this.subtitleLinesComboBox.TabIndex = 6;
            this.subtitleLinesComboBox.UseSelectable = true;
            this.subtitleLinesComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesLabel.Location = new System.Drawing.Point(-1, 9);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(152, 29);
            this.linesLabel.TabIndex = 4;
            this.linesLabel.Text = "Ondertiteling";
            // 
            // linesButton
            // 
            this.linesButton.Location = new System.Drawing.Point(4, 153);
            this.linesButton.Margin = new System.Windows.Forms.Padding(4);
            this.linesButton.Name = "linesButton";
            this.linesButton.Size = new System.Drawing.Size(192, 28);
            this.linesButton.TabIndex = 4;
            this.linesButton.Text = "Opslaan";
            this.linesButton.UseSelectable = true;
            this.linesButton.Click += new System.EventHandler(this.linesButton_Click);
            // 
            // savePanel
            // 
            this.savePanel.Controls.Add(this.pathTextBox);
            this.savePanel.Controls.Add(this.pathButton);
            this.savePanel.Controls.Add(this.label1);
            this.savePanel.Controls.Add(this.saveButton);
            this.savePanel.Location = new System.Drawing.Point(16, 285);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(200, 200);
            this.savePanel.TabIndex = 4;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Lines = new string[0];
            this.pathTextBox.Location = new System.Drawing.Point(5, 47);
            this.pathTextBox.MaxLength = 32767;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.PasswordChar = '\0';
            this.pathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pathTextBox.SelectedText = "";
            this.pathTextBox.Size = new System.Drawing.Size(166, 23);
            this.pathTextBox.TabIndex = 3;
            this.pathTextBox.UseSelectable = true;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(177, 47);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(19, 23);
            this.pathButton.TabIndex = 2;
            this.pathButton.Text = "...";
            this.pathButton.UseSelectable = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opslag Logboek:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(5, 154);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseSelectable = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // delayPanel
            // 
            this.delayPanel.Controls.Add(this.delayLabel);
            this.delayPanel.Controls.Add(this.metroLabel1);
            this.delayPanel.Controls.Add(this.delayTrackBar);
            this.delayPanel.Controls.Add(this.label2);
            this.delayPanel.Controls.Add(this.delayButton);
            this.delayPanel.Location = new System.Drawing.Point(223, 285);
            this.delayPanel.Name = "delayPanel";
            this.delayPanel.Size = new System.Drawing.Size(200, 200);
            this.delayPanel.TabIndex = 8;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(5, 76);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(0, 0);
            this.delayLabel.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Seconden";
            // 
            // delayTrackBar
            // 
            this.delayTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.delayTrackBar.Location = new System.Drawing.Point(5, 47);
            this.delayTrackBar.Maximum = 3;
            this.delayTrackBar.Name = "delayTrackBar";
            this.delayTrackBar.Size = new System.Drawing.Size(139, 23);
            this.delayTrackBar.TabIndex = 2;
            this.delayTrackBar.Text = "metroTrackBar1";
            this.delayTrackBar.Value = 1;
            this.delayTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.delayTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tijdsduur:";
            // 
            // delayButton
            // 
            this.delayButton.Location = new System.Drawing.Point(5, 154);
            this.delayButton.Margin = new System.Windows.Forms.Padding(4);
            this.delayButton.Name = "delayButton";
            this.delayButton.Size = new System.Drawing.Size(192, 28);
            this.delayButton.TabIndex = 1;
            this.delayButton.Text = "Opslaan";
            this.delayButton.UseSelectable = true;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // languagePanel
            // 
            this.languagePanel.Controls.Add(this.applicationLanguageComboBox);
            this.languagePanel.Controls.Add(this.metroLabel3);
            this.languagePanel.Controls.Add(this.metroLabel2);
            this.languagePanel.Controls.Add(this.subtitleLanguageComboBox);
            this.languagePanel.Controls.Add(this.label3);
            this.languagePanel.Controls.Add(this.languageButton);
            this.languagePanel.Location = new System.Drawing.Point(429, 286);
            this.languagePanel.Name = "languagePanel";
            this.languagePanel.Size = new System.Drawing.Size(200, 200);
            this.languagePanel.TabIndex = 10;
            // 
            // applicationLanguageComboBox
            // 
            this.applicationLanguageComboBox.FormattingEnabled = true;
            this.applicationLanguageComboBox.ItemHeight = 23;
            this.applicationLanguageComboBox.Location = new System.Drawing.Point(81, 99);
            this.applicationLanguageComboBox.Name = "applicationLanguageComboBox";
            this.applicationLanguageComboBox.Size = new System.Drawing.Size(107, 29);
            this.applicationLanguageComboBox.TabIndex = 12;
            this.applicationLanguageComboBox.UseSelectable = true;
            this.applicationLanguageComboBox.Items.AddRange(new object[] {
            "Nederlands"});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Applicatie:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Ondertitel:";
            // 
            // subtitleLanguageComboBox
            // 
            this.subtitleLanguageComboBox.FormattingEnabled = true;
            this.subtitleLanguageComboBox.ItemHeight = 23;
            this.subtitleLanguageComboBox.Location = new System.Drawing.Point(81, 46);
            this.subtitleLanguageComboBox.Name = "subtitleLanguageComboBox";
            this.subtitleLanguageComboBox.Size = new System.Drawing.Size(107, 29);
            this.subtitleLanguageComboBox.TabIndex = 2;
            this.subtitleLanguageComboBox.UseSelectable = true;
            this.subtitleLanguageComboBox.Items.AddRange(new object[] {
            "Nederlands",
            "Engels",
            "Duits",
            "Frans"});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taal:";
            // 
            // languageButton
            // 
            this.languageButton.Location = new System.Drawing.Point(5, 154);
            this.languageButton.Margin = new System.Windows.Forms.Padding(4);
            this.languageButton.Name = "languageButton";
            this.languageButton.Size = new System.Drawing.Size(192, 28);
            this.languageButton.TabIndex = 1;
            this.languageButton.Text = "Opslaan";
            this.languageButton.UseSelectable = true;
            this.languageButton.Click += new System.EventHandler(this.languageButton_Click);
            // 
            // languageTile
            // 
            this.languageTile.ActiveControl = null;
            this.languageTile.Location = new System.Drawing.Point(429, 286);
            this.languageTile.Margin = new System.Windows.Forms.Padding(4);
            this.languageTile.Name = "languageTile";
            this.languageTile.Size = new System.Drawing.Size(200, 200);
            this.languageTile.TabIndex = 11;
            this.languageTile.Text = "Taal";
            this.languageTile.TileImage = global::LifeSubsMetro.Properties.Resources.Geography_50;
            this.languageTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.languageTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.languageTile.UseSelectable = true;
            this.languageTile.UseTileImage = true;
            this.languageTile.Click += new System.EventHandler(this.languageTile_Click);
            // 
            // fontTile
            // 
            this.fontTile.ActiveControl = null;
            this.fontTile.Location = new System.Drawing.Point(223, 79);
            this.fontTile.Name = "fontTile";
            this.fontTile.Size = new System.Drawing.Size(200, 200);
            this.fontTile.TabIndex = 4;
            this.fontTile.Text = "Lettertype";
            this.fontTile.TileImage = global::LifeSubsMetro.Properties.Resources.Generic_Text_50;
            this.fontTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fontTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.fontTile.UseSelectable = true;
            this.fontTile.UseTileImage = true;
            this.fontTile.Click += new System.EventHandler(this.fontTile_Click);
            // 
            // microphoneTile
            // 
            this.microphoneTile.ActiveControl = null;
            this.microphoneTile.Location = new System.Drawing.Point(16, 78);
            this.microphoneTile.Margin = new System.Windows.Forms.Padding(4);
            this.microphoneTile.Name = "microphoneTile";
            this.microphoneTile.Size = new System.Drawing.Size(200, 200);
            this.microphoneTile.TabIndex = 0;
            this.microphoneTile.Text = "Microfoon";
            this.microphoneTile.TileImage = ((System.Drawing.Image)(resources.GetObject("microphoneTile.TileImage")));
            this.microphoneTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.microphoneTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.microphoneTile.UseSelectable = true;
            this.microphoneTile.UseTileImage = true;
            this.microphoneTile.VisibleChanged += new System.EventHandler(this.microphoneTile_VisibleChanged);
            this.microphoneTile.Click += new System.EventHandler(this.microphoneTile_Click);
            // 
            // saveTile
            // 
            this.saveTile.ActiveControl = null;
            this.saveTile.Location = new System.Drawing.Point(16, 285);
            this.saveTile.Margin = new System.Windows.Forms.Padding(4);
            this.saveTile.Name = "saveTile";
            this.saveTile.Size = new System.Drawing.Size(200, 200);
            this.saveTile.TabIndex = 7;
            this.saveTile.Text = "Opslag";
            this.saveTile.TileImage = global::LifeSubsMetro.Properties.Resources.Save_50;
            this.saveTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.saveTile.UseSelectable = true;
            this.saveTile.UseTileImage = true;
            this.saveTile.Click += new System.EventHandler(this.saveTile_Click);
            // 
            // linesTile
            // 
            this.linesTile.ActiveControl = null;
            this.linesTile.Location = new System.Drawing.Point(429, 79);
            this.linesTile.Name = "linesTile";
            this.linesTile.Size = new System.Drawing.Size(200, 200);
            this.linesTile.TabIndex = 5;
            this.linesTile.Text = "Ondertiteling";
            this.linesTile.TileImage = global::LifeSubsMetro.Properties.Resources.Numbered_List_50;
            this.linesTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linesTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.linesTile.UseSelectable = true;
            this.linesTile.UseTileImage = true;
            this.linesTile.Click += new System.EventHandler(this.linesTile_Click);
            // 
            // delayTile
            // 
            this.delayTile.ActiveControl = null;
            this.delayTile.Location = new System.Drawing.Point(223, 285);
            this.delayTile.Margin = new System.Windows.Forms.Padding(4);
            this.delayTile.Name = "delayTile";
            this.delayTile.Size = new System.Drawing.Size(200, 200);
            this.delayTile.TabIndex = 9;
            this.delayTile.Text = "Tijdsduur";
            this.delayTile.TileImage = global::LifeSubsMetro.Properties.Resources.Time_50;
            this.delayTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delayTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.delayTile.UseSelectable = true;
            this.delayTile.UseTileImage = true;
            this.delayTile.Click += new System.EventHandler(this.delayTile_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.fontComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(5, 33);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(130, 23);
            this.fontComboBox.TabIndex = 6;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.linesTile);
            this.Controls.Add(this.delayTile);
            this.Controls.Add(this.languageTile);
            this.Controls.Add(this.volumePanel);
            this.Controls.Add(this.languagePanel);
            this.Controls.Add(this.delayPanel);
            this.Controls.Add(this.saveTile);
            this.Controls.Add(this.savePanel);
            this.Controls.Add(this.fontTile);
            this.Controls.Add(this.fontPanel);
            this.Controls.Add(this.microphoneTile);
            this.Controls.Add(this.microphonePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsMenu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "SettingsMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsMenu_FormClosing);
            this.microphonePanel.ResumeLayout(false);
            this.microphonePanel.PerformLayout();
            this.fontPanel.ResumeLayout(false);
            this.fontPanel.PerformLayout();
            this.volumePanel.ResumeLayout(false);
            this.volumePanel.PerformLayout();
            this.savePanel.ResumeLayout(false);
            this.savePanel.PerformLayout();
            this.delayPanel.ResumeLayout(false);
            this.delayPanel.PerformLayout();
            this.languagePanel.ResumeLayout(false);
            this.languagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile microphoneTile;
        private MetroFramework.Controls.MetroButton microphoneButton;
        private MetroFramework.Controls.MetroComboBox microphoneComboBox;
        private System.Windows.Forms.Label microphoneLabel;
        private System.Windows.Forms.Panel microphonePanel;
        private MetroFramework.Controls.MetroTile fontTile;
        private System.Windows.Forms.Panel fontPanel;
        private System.Windows.Forms.Label fontLabel;
        private MetroFramework.Controls.MetroButton fontButton;
        private MetroFramework.Controls.MetroComboBox fontSizeComboBox;
        private MetroFramework.Controls.MetroTile linesTile;
        private System.Windows.Forms.Panel volumePanel;
        private MetroFramework.Controls.MetroButton linesButton;
        private System.Windows.Forms.Label linesLabel;
        private MetroFramework.Controls.MetroProgressBar microphoneProgressBar;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private MetroFramework.Controls.MetroLabel subtitleLinesLabel;
        private MetroFramework.Controls.MetroComboBox subtitleLinesComboBox;
        private MetroFramework.Controls.MetroLabel subtitleBackgroundColorLabel;
        private MetroFramework.Controls.MetroLabel subtitleColorLabel;
        private System.Windows.Forms.Panel fontColorPanel;
        private System.Windows.Forms.Panel fontBackPanel;
        private System.Windows.Forms.ColorDialog backColorDialog;
        private System.Windows.Forms.Panel savePanel;
        private MetroFramework.Controls.MetroTile saveTile;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.Panel delayPanel;
        private MetroFramework.Controls.MetroTile delayTile;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton delayButton;
        private System.Windows.Forms.Panel languagePanel;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton languageButton;
        private MetroFramework.Controls.MetroTile languageTile;
        private MetroFramework.Controls.MetroButton pathButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroTextBox pathTextBox;
        private MetroFramework.Controls.MetroTrackBar delayTrackBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel delayLabel;
        private MetroFramework.Controls.MetroComboBox applicationLanguageComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox subtitleLanguageComboBox;
        private FontComboBox fontComboBox;
    }
}