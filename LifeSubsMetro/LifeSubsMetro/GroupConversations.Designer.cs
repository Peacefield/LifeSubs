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
            this.dataGridOutput = new System.Windows.Forms.DataGridView();
            this.imgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInput = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.friendIpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.ownPort = new System.Windows.Forms.TextBox();
            this.otherPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendTile = new MetroFramework.Controls.MetroTile();
            this.ipLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startGroupListenerBtn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
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
            this.dataGridOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutput.ColumnHeadersVisible = false;
            this.dataGridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgColumn,
            this.msgColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOutput.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOutput.EnableHeadersVisualStyles = false;
            this.dataGridOutput.Location = new System.Drawing.Point(23, 63);
            this.dataGridOutput.Name = "dataGridOutput";
            this.dataGridOutput.ReadOnly = true;
            this.dataGridOutput.RowHeadersVisible = false;
            this.dataGridOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridOutput.Size = new System.Drawing.Size(974, 362);
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
            this.tbInput.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eigen IP:";
            // 
            // friendIpTextBox
            // 
            this.friendIpTextBox.Location = new System.Drawing.Point(500, 37);
            this.friendIpTextBox.Name = "friendIpTextBox";
            this.friendIpTextBox.Size = new System.Drawing.Size(136, 20);
            this.friendIpTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ander IP";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(666, 10);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 47);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // ownPort
            // 
            this.ownPort.Location = new System.Drawing.Point(309, 17);
            this.ownPort.Name = "ownPort";
            this.ownPort.Size = new System.Drawing.Size(33, 20);
            this.ownPort.TabIndex = 9;
            // 
            // otherPort
            // 
            this.otherPort.Location = new System.Drawing.Point(500, 15);
            this.otherPort.Name = "otherPort";
            this.otherPort.Size = new System.Drawing.Size(34, 20);
            this.otherPort.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Own port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ander poort";
            // 
            // sendTile
            // 
            this.sendTile.ActiveControl = null;
            this.sendTile.Location = new System.Drawing.Point(885, 483);
            this.sendTile.Name = "sendTile";
            this.sendTile.Size = new System.Drawing.Size(67, 59);
            this.sendTile.TabIndex = 2;
            this.sendTile.Text = "Verzend";
            this.sendTile.UseSelectable = true;
            this.sendTile.Click += new System.EventHandler(this.sendTile_Click);
            // 
            // ipLabel
            // 
            this.ipLabel.Location = new System.Drawing.Point(309, 40);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(100, 20);
            this.ipLabel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // startGroupListenerBtn
            // 
            this.startGroupListenerBtn.ActiveControl = null;
            this.startGroupListenerBtn.Location = new System.Drawing.Point(958, 483);
            this.startGroupListenerBtn.Name = "startGroupListenerBtn";
            this.startGroupListenerBtn.Size = new System.Drawing.Size(47, 59);
            this.startGroupListenerBtn.TabIndex = 16;
            this.startGroupListenerBtn.TileImage = global::LifeSubsMetro.Properties.Resources.Microphone_50;
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
            this.Controls.Add(this.startGroupListenerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.otherPort);
            this.Controls.Add(this.ownPort);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.friendIpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendTile);
            this.Controls.Add(this.dataGridOutput);
            this.Controls.Add(this.tbInput);
            this.MaximizeBox = false;
            this.Name = "GroupConversations";
            this.Resizable = false;
            this.Text = "Kamer: IT innovations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupConversations_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbInput;
        private MetroFramework.Controls.MetroTile sendTile;
        private System.Windows.Forms.DataGridView dataGridOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox friendIpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox ownPort;
        private System.Windows.Forms.TextBox otherPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipLabel;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTile startGroupListenerBtn;








    }
}