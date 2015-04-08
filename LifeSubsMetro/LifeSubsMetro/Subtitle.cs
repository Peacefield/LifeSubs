using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSubsMetro
{
    public partial class Subtitle : MetroForm
    {
        MainMenu mm;
        public Subtitle(MainMenu mm)
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var width = screen.Width;
            this.mm = mm;

            InitializeComponent();

            this.Width = width;
            this.Height = 150;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - this.Height);
            this.TopMost = true;
        }

        private void Subtitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            mm.WindowState = FormWindowState.Normal;
        }
    }
}
