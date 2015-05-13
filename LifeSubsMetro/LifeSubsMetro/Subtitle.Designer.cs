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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(32, 57);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(336, 283);
            this.tbOutput.TabIndex = 4;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeMeter
            // 
            this.volumeMeter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.volumeMeter.Location = new System.Drawing.Point(103, 18);
            this.volumeMeter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volumeMeter.Maximum = 300;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Size = new System.Drawing.Size(267, 16);
            this.volumeMeter.TabIndex = 5;
            // 
            // sendNotificationPanel
            // 
            this.sendNotificationPanel.BackColor = System.Drawing.Color.LightGreen;
            this.sendNotificationPanel.Location = new System.Drawing.Point(31, 21);
            this.sendNotificationPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendNotificationPanel.Name = "sendNotificationPanel";
            this.sendNotificationPanel.Size = new System.Drawing.Size(13, 12);
            this.sendNotificationPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LifeSubsMetro.Properties.Resources._1428589893_engineering_48;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Subtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendNotificationPanel);
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Subtitle";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subtitle_FormClosing);
            this.Load += new System.EventHandler(this.Subtitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ProgressBar volumeMeter;
        private System.Windows.Forms.Panel sendNotificationPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
