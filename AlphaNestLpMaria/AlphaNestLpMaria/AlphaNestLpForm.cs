/*
 * Created by: Maria
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program...
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

namespace AlphaNestLpMaria
{
    public partial class frmAlphaNestLp : Form
    {
        public frmAlphaNestLp()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            String aLetter;
            int counter;

            //clear the items from the listbox
            this.lstAlphabet.Items.Clear();

            for(counter = 65; counter <= 90; counter++)
            {
                for (counter = 97; counter <= 122; counter++)
                //convert aLetter
                aLetter = Char.ConvertFromUtf32(counter);

                //join character and counter
                lstAlphabet.Items.Add(aLetter + "->" + counter);

                //List the alphabet in the list box for the user to see
                this.lstAlphabet.Items.Add(counter);

            }
        }
    }
}
