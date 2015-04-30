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
            this.components = new System.ComponentModel.Container();
            this.tbOutput = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbOutput.Lines = new string[0];
            this.tbOutput.Location = new System.Drawing.Point(23, 29);
            this.tbOutput.MaxLength = 32767;
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.PasswordChar = '\0';
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbOutput.SelectedText = "";
            this.tbOutput.Size = new System.Drawing.Size(254, 214);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.UseCustomBackColor = true;
            this.tbOutput.UseSelectable = true;
            // 
            // Subtitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.tbOutput);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Subtitle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subtitle_FormClosing);
            this.Load += new System.EventHandler(this.Subtitle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbOutput;
    }
}
