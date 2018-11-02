/*
 * Created by: Maria
 * Created on: 02-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
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

namespace ForEachMaria
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnCntrlButton_Click(object sender, EventArgs e)
        {
            //loop through each object on the form and make it green 
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;

                //if the object is a label, make it purple
                if(aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }
        }
    }
}
