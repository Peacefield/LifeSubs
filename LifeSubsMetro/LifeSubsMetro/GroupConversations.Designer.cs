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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbInput = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new MetroFramework.Controls.MetroTile();
            this.dataGridOutput = new System.Windows.Forms.DataGridView();
            this.imgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConnect = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
            this.SuspendLayout();
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
            // btnSend
            // 
            this.btnSend.ActiveControl = null;
            this.btnSend.Location = new System.Drawing.Point(885, 483);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 59);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Verzend";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dataGridOutput
            // 
            this.dataGridOutput.AllowUserToDeleteRows = false;
            this.dataGridOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOutput.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutput.ColumnHeadersVisible = false;
            this.dataGridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgColumn,
            this.msgColumn});
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOutput.EnableHeadersVisualStyles = false;
            this.dataGridOutput.Location = new System.Drawing.Point(23, 63);
            this.dataGridOutput.Name = "dataGridOutput";
            this.dataGridOutput.ReadOnly = true;
            this.dataGridOutput.RowHeadersVisible = false;
            this.dataGridOutput.Size = new System.Drawing.Size(974, 362);
            this.dataGridOutput.TabIndex = 3;
            // 
            // imgColumn
            // 
            this.imgColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.imgColumn.DividerWidth = 1;
            this.imgColumn.HeaderText = "imgColumn";
            this.imgColumn.Name = "imgColumn";
            this.imgColumn.ReadOnly = true;
            this.imgColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgColumn.Width = 200;
            // 
            // msgColumn
            // 
            this.msgColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgColumn.HeaderText = "msgColumn";
            this.msgColumn.Name = "msgColumn";
            this.msgColumn.ReadOnly = true;
            this.msgColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnConnect
            // 
            this.btnConnect.ActiveControl = null;
            this.btnConnect.Location = new System.Drawing.Point(885, 454);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect...";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // GroupConversations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 565);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dataGridOutput);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbInput);
            this.MaximizeBox = false;
            this.Name = "GroupConversations";
            this.Resizable = false;
            this.Text = "Kamer: IT innovations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupConversations_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbInput;
        private MetroFramework.Controls.MetroTile btnSend;
        private System.Windows.Forms.DataGridView dataGridOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgColumn;
        private MetroFramework.Controls.MetroTile btnConnect;

    }
}