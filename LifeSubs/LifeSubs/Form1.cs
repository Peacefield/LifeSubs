using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSubs
{
    public partial class Form1 : Form
    {
        private bool dragging;
        private Point dragAt = Point.Empty;

        public Form1()
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var width = screen.Width;

            InitializeComponent();
            this.Width = width;
            this.menuStripPanel.Width = width;
            this.menuStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }


        private void menuStripPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.menuStripPanel.Cursor = Cursors.SizeAll;

            if (e.Button == MouseButtons.Left)
            {
                this.dragging = true;
                this.dragAt = new Point(e.X, e.Y);
                ((Control)sender).Capture = true;
            }
        }

        private void menuStripPanel_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging && e.Button == MouseButtons.Left)
            {
                this.Left = e.X + Left - dragAt.X;
                this.Top = e.Y + Top - dragAt.Y;
            }
            else
            {
                this.dragAt = new Point(e.X, e.Y);
            }
        }

        private void menuStripPanel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.menuStripPanel.Cursor = Cursors.Default;

            this.dragging = false;
            ((Control)sender).Capture = false;
        }
    }
}
