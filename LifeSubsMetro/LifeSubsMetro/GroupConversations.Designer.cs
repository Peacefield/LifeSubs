namespace LifeSubsMetro
{
    partial class GroupConversations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupConversations));
            this.dataGridOutput = new System.Windows.Forms.DataGridView();
            this.imgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInput = new MetroFramework.Controls.MetroTextBox();
            this.sendTile = new MetroFramework.Controls.MetroTile();
            this.volumemeterGrp = new MetroFramework.Controls.MetroProgressBar();
            this.canSendPanelGrp = new System.Windows.Forms.Panel();
            this.settingsPB = new System.Windows.Forms.PictureBox();
            this.startGroupListenerBtn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOutput
            // 
            this.dataGridOutput.AllowUserToDeleteRows = false;
            this.dataGridOutput.AllowUserToResizeColumns = false;
            this.dataGridOutput.AllowUserToResizeRows = false;
            this.dataGridOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutput.ColumnHeadersVisible = false;
            this.dataGridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgColumn,
            this.msgColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOutput.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOutput.EnableHeadersVisualStyles = false;
            this.dataGridOutput.Location = new System.Drawing.Point(20, 48);
            this.dataGridOutput.Name = "dataGridOutput";
            this.dataGridOutput.ReadOnly = true;
            this.dataGridOutput.RowHeadersVisible = false;
            this.dataGridOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridOutput.Size = new System.Drawing.Size(977, 419);
            this.dataGridOutput.TabIndex = 3;
            // 
            // imgColumn
            // 
            this.imgColumn.HeaderText = "imgColumn";
            this.imgColumn.Name = "imgColumn";
            this.imgColumn.ReadOnly = true;
            this.imgColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imgColumn.Width = 200;
            // 
            // msgColumn
            // 
            this.msgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgColumn.HeaderText = "msgColumn";
            this.msgColumn.Name = "msgColumn";
            this.msgColumn.ReadOnly = true;
            this.msgColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbInput
            // 
            this.tbInput.Lines = new string[0];
            this.tbInput.Location = new System.Drawing.Point(20, 483);
            this.tbInput.MaxLength = 32767;
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.PasswordChar = '\0';
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInput.SelectedText = "";
            this.tbInput.Size = new System.Drawing.Size(858, 59);
            this.tbInput.TabIndex = 1;
            this.tbInput.UseCustomBackColor = true;
            this.tbInput.UseCustomForeColor = true;
            this.tbInput.UseSelectable = true;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // sendTile
            // 
            this.sendTile.ActiveControl = null;
            this.sendTile.Location = new System.Drawing.Point(885, 483);
            this.sendTile.Name = "sendTile";
            this.sendTile.Size = new System.Drawing.Size(67, 59);
            this.sendTile.Style = MetroFramework.MetroColorStyle.Green;
            this.sendTile.TabIndex = 2;
            this.sendTile.Text = "Verzend";
            this.sendTile.UseSelectable = true;
            this.sendTile.Click += new System.EventHandler(this.sendTile_Click);
            // 
            // volumemeterGrp
            // 
            this.volumemeterGrp.Location = new System.Drawing.Point(20, 548);
            this.volumemeterGrp.Name = "volumemeterGrp";
            this.volumemeterGrp.Size = new System.Drawing.Size(985, 10);
            this.volumemeterGrp.TabIndex = 17;
            this.volumemeterGrp.Visible = false;
            // 
            // canSendPanelGrp
            // 
            this.canSendPanelGrp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.canSendPanelGrp.Location = new System.Drawing.Point(20, 548);
            this.canSendPanelGrp.Name = "canSendPanelGrp";
            this.canSendPanelGrp.Size = new System.Drawing.Size(985, 10);
            this.canSendPanelGrp.TabIndex = 18;
            this.canSendPanelGrp.Visible = false;
            this.canSendPanelGrp.VisibleChanged += new System.EventHandler(this.canSendPanelGrp_VisibleChanged);
            // 
            // settingsPB
            // 
            this.settingsPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPB.Image = global::LifeSubsMetro.Properties.Resources._1428589893_engineering_48;
            this.settingsPB.Location = new System.Drawing.Point(942, 9);
            this.settingsPB.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPB.Name = "settingsPB";
            this.settingsPB.Size = new System.Drawing.Size(20, 20);
            this.settingsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsPB.TabIndex = 19;
            this.settingsPB.TabStop = false;
            this.settingsPB.Click += new System.EventHandler(this.settingsPB_Click);
            // 
            // startGroupListenerBtn
            // 
            this.startGroupListenerBtn.ActiveControl = null;
            this.startGroupListenerBtn.Location = new System.Drawing.Point(958, 483);
            this.startGroupListenerBtn.Name = "startGroupListenerBtn";
            this.startGroupListenerBtn.Size = new System.Drawing.Size(47, 59);
            this.startGroupListenerBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.startGroupListenerBtn.TabIndex = 16;
            this.startGroupListenerBtn.TileImage = ((System.Drawing.Image)(resources.GetObject("startGroupListenerBtn.TileImage")));
            this.startGroupListenerBtn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startGroupListenerBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.startGroupListenerBtn.UseSelectable = true;
            this.startGroupListenerBtn.UseTileImage = true;
            this.startGroupListenerBtn.Click += new System.EventHandler(this.startGroupListenerBtn_Click);
            // 
            // GroupConversations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 565);
            this.Controls.Add(this.settingsPB);
            this.Controls.Add(this.startGroupListenerBtn);
            this.Controls.Add(this.sendTile);
            this.Controls.Add(this.dataGridOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.canSendPanelGrp);
            this.Controls.Add(this.volumemeterGrp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupConversations";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Kamer: IT innovations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupConversations_FormClosing);
            this.Load += new System.EventHandler(this.GroupConversations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbInput;
        private MetroFramework.Controls.MetroTile sendTile;
        private System.Windows.Forms.DataGridView dataGridOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgColumn;
        private MetroFramework.Controls.MetroTile startGroupListenerBtn;
        private MetroFramework.Controls.MetroProgressBar volumemeterGrp;
        private System.Windows.Forms.Panel canSendPanelGrp;
        private System.Windows.Forms.PictureBox settingsPB;








    }
}