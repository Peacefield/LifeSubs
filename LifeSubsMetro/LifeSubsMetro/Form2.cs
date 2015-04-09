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

            //ListViewItem lvi = new ListViewItem();
            //lvi.SubItems.Add("SubItem");
            //messagesList.Items.Add(lvi);


            

            for (int i = 0; i < messages.Count; i++)
            {
                //First item of 3 - the profile pic of the other
                ListViewItem text = new ListViewItem(messages[i].ToString() + " - EERSTE");

                //Second item of 3 - the (spoken) text of both you and the other
                text.SubItems.Add(messages[i].ToString() + " - TWEEDE");

                //Third item of 3 - your profile pic
                text.SubItems.Add("rgfds - DERDE");

                //Add item and its subitems to the list
                messagesList.Items.Add(text);
                
            }
               
        }
    }
}
