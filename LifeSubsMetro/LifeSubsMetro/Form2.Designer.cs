namespace LifeSubsMetro
{
    partial class Form2
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
            this.messagesList = new System.Windows.Forms.ListView();
            this.columnPicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTextHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // messagesList
            // 
            this.messagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPicHeader,
            this.columnTextHeader});
            this.messagesList.Enabled = false;
            this.messagesList.Location = new System.Drawing.Point(23, 63);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(604, 382);
            this.messagesList.TabIndex = 0;
            this.messagesList.UseCompatibleStateImageBehavior = false;
            this.messagesList.View = System.Windows.Forms.View.List;
            // 
            // columnPicHeader
            // 
            this.columnPicHeader.Width = 218;
            // 
            // columnTextHeader
            // 
            this.columnTextHeader.Width = 383;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 483);
            this.Controls.Add(this.messagesList);
            this.Name = "Form2";
            this.Text = "Kamer: IT innovations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView messagesList;
        private System.Windows.Forms.ColumnHeader columnPicHeader;
        private System.Windows.Forms.ColumnHeader columnTextHeader;

    }
}