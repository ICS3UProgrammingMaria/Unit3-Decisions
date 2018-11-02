/*
 * Created by: Maria
 * Created on: 01-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicdoe
 * This program converts the letter to unicode
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeMaria
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //declare local variables
            String aLetter;
            int counter;

            //string = convert.Char
            //clear the items in the listbox
            this.lstUnicode.Items.Clear();

            for (counter = 65; counter <= 90;  counter++)
            {
                //convert 
                aLetter = Char.ConvertFromUtf32(counter);

                //counter + "->" + aLetter;

                //list the unicode in the listbox for the user to see
                this.lstUnicode.Items.Add(counter);

            }
        }
    }
}
