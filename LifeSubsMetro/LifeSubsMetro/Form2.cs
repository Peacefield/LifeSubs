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
using System.Collections;

namespace LifeSubsMetro
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            ArrayList messages = new ArrayList();

            messages.Add("ewfergve");
            messages.Add("koekjes");
            messages.Add("egrfgregrtrferfer");
            messages.Add("fwerfergergregfer");

            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add("SubItem");
            messagesList.Items.Add(lvi);


            //ListViewItem text = new ListViewItem("Messages");

            //for (int i = 0; i < messages.Count; i++)
            //{
            //    Console.WriteLine(messages[i]);
                
            //    text.SubItems.Add(messages[i].ToString());
                
            //}
            //text.SubItems.Add("rgfds");
            //messagesList.Items.Add(text);
        }
    }
}
