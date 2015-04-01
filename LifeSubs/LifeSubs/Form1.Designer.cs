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
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartSubs = new System.Windows.Forms.Button();
            this.menuStripPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPanel
            // 
            this.menuStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStripPanel.Controls.Add(this.buttonStartSubs);
            this.menuStripPanel.Controls.Add(this.closeBtn);
            this.menuStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStripPanel.Location = new System.Drawing.Point(0, 0);
            this.menuStripPanel.Name = "menuStripPanel";
            this.menuStripPanel.Size = new System.Drawing.Size(284, 40);
            this.menuStripPanel.TabIndex = 0;
            this.menuStripPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseDown);
            this.menuStripPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseMove);
            this.menuStripPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStripPanel_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.closeBtn.Location = new System.Drawing.Point(255, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 17);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1013, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "veragr grs gb jyukb khubkub gkubghkbu bilniluh nhuilniul";
            // 
            // buttonStartSubs
            // 
            this.buttonStartSubs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonStartSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSubs.Location = new System.Drawing.Point(9, 8);
            this.buttonStartSubs.Name = "buttonStartSubs";
            this.buttonStartSubs.Size = new System.Drawing.Size(118, 23);
            this.buttonStartSubs.TabIndex = 2;
            this.buttonStartSubs.Text = "Start ondertiteling";
            this.buttonStartSubs.UseVisualStyleBackColor = true;
            this.buttonStartSubs.Click += new System.EventHandler(this.buttonStartSubs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.TopMost = true;
            this.menuStripPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel menuStripPanel;
        private Button closeBtn;
        private Button buttonStartSubs;
        public Label label1;

    }
}

