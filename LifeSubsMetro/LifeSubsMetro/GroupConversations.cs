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
using System.Net;

namespace LifeSubsMetro
{
    public partial class GroupConversations : MetroForm
    {
        MainMenu mm;
        public GroupConversations(MainMenu mm)
        {
            this.mm = mm;
            InitializeComponent();
            ArrayList messages = new ArrayList();

            messages.Add("ewfergve");
            messages.Add("koekjes");
            messages.Add("egrfgregrtrferfer");
            messages.Add("fwerfergergregfer");
            messages.Add("ewfergve");

            //ListViewItem lvi = new ListViewItem();
            //lvi.SubItems.Add("SubItem");
            //messagesList.Items.Add(lvi);

            
            //metroGrid1
            metroGrid1.ColumnCount = 3;
            metroGrid1.Columns[0].Name = "Product ID";
            metroGrid1.Columns[1].Name = "Product Name";
            metroGrid1.Columns[2].Name = "Product Price";

            string[] row = new string[] { "1", "Product 1", "1000" };
            string[] row1 = new string[] { " ", " ", " " };
            string[] row2 = new string[] { "1", "Product 1", "1000" };
            string[] row3 = new string[] { " ", " ", " " };
            string[] row4 = new string[] { "1", "Product 1", "1000" };

            metroGrid1.Rows.Add(row);
            metroGrid1.Rows.Add(row1);
            metroGrid1.Rows.Add(row2);
            metroGrid1.Rows.Add(row3);
            metroGrid1.Rows.Add(row4);

            for (int i = 0; i < messages.Count; i++)
            {
                //First item of 3 - the profile pic of the other
                //ListViewItem text = new ListViewItem(messages[i].ToString() + " - EERSTE");
               
                //string[] row1 = new string[] { "column2 value", "column6 value" };
                //metroGrid1.Rows.Add("wedwe", "fwefwewef");
                //Second item of 3 - the (spoken) text of both you and the other
                //text.SubItems.Add(messages[i].ToString() + " - TWEEDE");

                //Third item of 3 - your profile pic
               // text.SubItems.Add("rgfds - DERDE");

                //Add item and its subitems to the list
               // messagesList.Items.Add(text);

            }
               
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            mm.Visible = true;
        }

        private void GroupConversations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mm.Visible = true;
        }
    }
}
