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
        }

        #region Event handlers

        /// <summary>
        /// Activate the form draggable modus when the left mousebutton is pressed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void menuStripPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.menuStripPanel.Cursor = Cursors.SizeAll;

            if (e.Button == MouseButtons.Left)
            {
                this.dragging = true;
                this.dragAt = new Point(e.X, e.Y);
                ((Control)sender).Capture = true;
            }
        }

        /// <summary>
        /// Stops moving the form when the mousebutton is released.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void menuStripPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.menuStripPanel.Cursor = Cursors.Default;

            this.dragging = false;
            ((Control)sender).Capture = false;
        }

        /// <summary>
        /// Moves the application form over the screen when the left mousebutton is pressed and the mouse moves.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains the event data.</param>
        private void menuStripPanel_MouseMove(object sender, MouseEventArgs e)
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

        #endregion
    }
}
