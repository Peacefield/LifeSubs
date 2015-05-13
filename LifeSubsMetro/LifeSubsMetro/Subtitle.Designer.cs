namespace LifeSubsMetro
{
    partial class Subtitle
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.volumeMeter = new System.Windows.Forms.ProgressBar();
            this.sendNotificationPanel = new System.Windows.Forms.Panel();
            this.settingsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(24, 46);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(253, 231);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeMeter
            // 
            this.volumeMeter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.volumeMeter.Location = new System.Drawing.Point(77, 15);
            this.volumeMeter.Maximum = 300;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Size = new System.Drawing.Size(200, 13);
            this.volumeMeter.TabIndex = 5;
            // 
            // sendNotificationPanel
            // 
            this.sendNotificationPanel.BackColor = System.Drawing.Color.LightGreen;
            this.sendNotificationPanel.Location = new System.Drawing.Point(23, 17);
            this.sendNotificationPanel.Name = "sendNotificationPanel";
            this.sendNotificationPanel.Size = new System.Drawing.Size(10, 10);
            this.sendNotificationPanel.TabIndex = 6;
            // 
            // settingsPB
            // 
            this.settingsPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPB.Image = global::LifeSubsMetro.Properties.Resources._1428589893_engineering_48;
            this.settingsPB.Location = new System.Drawing.Point(225, 10);
            this.settingsPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsPB.Name = "settingsPB";
            this.settingsPB.Size = new System.Drawing.Size(13, 14);
            this.settingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPB.TabIndex = 7;
            this.settingsPB.TabStop = false;
            this.settingsPB.Click += new System.EventHandler(this.pictureBox1_Click);
            this.sendNotificationPanel.BackColor = System.Drawing.Color.LightGreen;
            this.sendNotificationPanel.Location = new System.Drawing.Point(23, 17);
            this.sendNotificationPanel.Name = "sendNotificationPanel";
            this.sendNotificationPanel.Size = new System.Drawing.Size(10, 10);
            this.sendNotificationPanel.TabIndex = 6;
            // 
            // Subtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.settingsPB);
            this.Controls.Add(this.sendNotificationPanel);
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Subtitle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subtitle_FormClosing);
            this.Load += new System.EventHandler(this.Subtitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ProgressBar volumeMeter;
        private System.Windows.Forms.Panel sendNotificationPanel;
        private System.Windows.Forms.PictureBox settingsPB;
    }
}
