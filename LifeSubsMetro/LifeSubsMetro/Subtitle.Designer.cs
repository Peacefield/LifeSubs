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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subtitle));
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.volumeMeter = new System.Windows.Forms.ProgressBar();
            this.sendNotificationPanel = new System.Windows.Forms.Panel();
            this.dragPB = new System.Windows.Forms.PictureBox();
            this.snapPB = new System.Windows.Forms.PictureBox();
            this.settingsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dragPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
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
            this.volumeMeter.Location = new System.Drawing.Point(44, 14);
            this.volumeMeter.Maximum = 50;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Size = new System.Drawing.Size(200, 15);
            this.volumeMeter.TabIndex = 5;
            this.volumeMeter.Value = 25;
            // 
            // sendNotificationPanel
            // 
            this.sendNotificationPanel.BackColor = System.Drawing.Color.LightGreen;
            this.sendNotificationPanel.Location = new System.Drawing.Point(23, 14);
            this.sendNotificationPanel.Name = "sendNotificationPanel";
            this.sendNotificationPanel.Size = new System.Drawing.Size(15, 15);
            this.sendNotificationPanel.TabIndex = 6;
            // 
            // dragPB
            // 
            this.dragPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPB.Image = global::LifeSubsMetro.Properties.Resources.Resize_Four_Directions_32;
            this.dragPB.Location = new System.Drawing.Point(191, 10);
            this.dragPB.Margin = new System.Windows.Forms.Padding(2);
            this.dragPB.Name = "dragPB";
            this.dragPB.Size = new System.Drawing.Size(13, 14);
            this.dragPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragPB.TabIndex = 9;
            this.dragPB.TabStop = false;
            this.dragPB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPB_MouseDown);
            this.dragPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPB_MouseMove);
            this.dragPB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPB_MouseUp);
            // 
            // snapPB
            // 
            this.snapPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.snapPB.Image = global::LifeSubsMetro.Properties.Resources.Up_Circular_32;
            this.snapPB.Location = new System.Drawing.Point(208, 10);
            this.snapPB.Margin = new System.Windows.Forms.Padding(2);
            this.snapPB.Name = "snapPB";
            this.snapPB.Size = new System.Drawing.Size(13, 14);
            this.snapPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snapPB.TabIndex = 8;
            this.snapPB.TabStop = false;
            this.snapPB.Click += new System.EventHandler(this.snapPB_Click);
            // 
            // settingsPB
            // 
            this.settingsPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPB.Image = global::LifeSubsMetro.Properties.Resources._1428589893_engineering_48;
            this.settingsPB.Location = new System.Drawing.Point(225, 10);
            this.settingsPB.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPB.Name = "settingsPB";
            this.settingsPB.Size = new System.Drawing.Size(13, 14);
            this.settingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPB.TabIndex = 7;
            this.settingsPB.TabStop = false;
            this.settingsPB.Click += new System.EventHandler(this.settingsPB_Click);
            // 
            // Subtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.dragPB);
            this.Controls.Add(this.snapPB);
            this.Controls.Add(this.settingsPB);
            this.Controls.Add(this.sendNotificationPanel);
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Subtitle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subtitle_FormClosing);
            this.Load += new System.EventHandler(this.Subtitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dragPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapPB)).EndInit();
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
        private System.Windows.Forms.PictureBox snapPB;
        private System.Windows.Forms.PictureBox dragPB;
    }
}
