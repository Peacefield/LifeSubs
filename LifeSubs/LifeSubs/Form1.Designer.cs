using System.Drawing;
using System.Windows.Forms;
namespace LifeSubs
{
    partial class Form1
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
            this.menuStripPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // menuStripPanel
            // 
            this.menuStripPanel.Location = new System.Drawing.Point(0, 0);
            this.menuStripPanel.Name = "menuStripPanel";
            this.menuStripPanel.Size = new System.Drawing.Size(0, 20);
            this.menuStripPanel.TabIndex = 0;
            this.menuStripPanel.Dock = DockStyle.Top;
            this.menuStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStripPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseDown);
            this.menuStripPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseMove);
            this.menuStripPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.menuStripPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel menuStripPanel;

    }
}

