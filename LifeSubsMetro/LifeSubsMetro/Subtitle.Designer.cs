namespace LifeSubs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subtitle));
            this.label1 = new System.Windows.Forms.Label();
            this.volumeMeter = new System.Windows.Forms.ProgressBar();
            this.sendNotificationPanel = new System.Windows.Forms.Panel();
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.outputColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupConvoPB = new System.Windows.Forms.PictureBox();
            this.dragPB = new System.Windows.Forms.PictureBox();
            this.snapPB = new System.Windows.Forms.PictureBox();
            this.settingsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConvoPB)).BeginInit();
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
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.AllowUserToResizeColumns = false;
            this.dataOutput.AllowUserToResizeRows = false;
            this.dataOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataOutput.ColumnHeadersVisible = false;
            this.dataOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outputColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOutput.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataOutput.Location = new System.Drawing.Point(23, 46);
            this.dataOutput.MultiSelect = false;
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.ReadOnly = true;
            this.dataOutput.RowHeadersVisible = false;
            this.dataOutput.Size = new System.Drawing.Size(240, 150);
            this.dataOutput.TabIndex = 10;
            // 
            // outputColumn
            // 
            this.outputColumn.HeaderText = "Output";
            this.outputColumn.Name = "outputColumn";
            this.outputColumn.ReadOnly = true;
            this.outputColumn.Width = this.dataOutput.Width;
            // 
            // groupConvoPB
            // 
            this.groupConvoPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConvoPB.Image = global::LifeSubs.Properties.Resources.Chat_Message_50;
            this.groupConvoPB.Location = new System.Drawing.Point(174, 10);
            this.groupConvoPB.Margin = new System.Windows.Forms.Padding(2);
            this.groupConvoPB.Name = "groupConvoPB";
            this.groupConvoPB.Size = new System.Drawing.Size(13, 14);
            this.groupConvoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupConvoPB.TabIndex = 11;
            this.groupConvoPB.TabStop = false;
            this.groupConvoPB.Visible = false;
            this.groupConvoPB.Click += new System.EventHandler(this.groupConvoPB_Click);
            // 
            // dragPB
            // 
            this.dragPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dragPB.Image = global::LifeSubs.Properties.Resources.Resize_Four_Directions_32;
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
            this.snapPB.Image = global::LifeSubs.Properties.Resources.Up_Circular_32;
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
            this.settingsPB.Image = global::LifeSubs.Properties.Resources._1428589893_engineering_48;
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
            this.Controls.Add(this.groupConvoPB);
            this.Controls.Add(this.dataOutput);
            this.Controls.Add(this.dragPB);
            this.Controls.Add(this.snapPB);
            this.Controls.Add(this.settingsPB);
            this.Controls.Add(this.sendNotificationPanel);
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Subtitle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subtitle_FormClosing);
            this.Load += new System.EventHandler(this.Subtitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupConvoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar volumeMeter;
        private System.Windows.Forms.Panel sendNotificationPanel;
        private System.Windows.Forms.PictureBox settingsPB;
        private System.Windows.Forms.PictureBox snapPB;
        private System.Windows.Forms.PictureBox dragPB;
        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputColumn;
        private System.Windows.Forms.PictureBox groupConvoPB;
    }
}
