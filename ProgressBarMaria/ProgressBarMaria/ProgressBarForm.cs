/*
 * Created by: Maria
 * Created on: 24-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Progress Bar
 * This program 
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

namespace ProgressBarMaria
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            const int MAX_PROGRESS_BAR_VALUE = 100;
            int valueOfProgressBar = 0;

            //increment the value of the progress bar by each time until it has reached it's max value
            do
            {
                this.prbProgressBar.Value = valueOfProgressBar;
                valueOfProgressBar = valueOfProgressBar + 5;
                // it refreshed
                this.Refresh();
            } while (valueOfProgressBar <= MAX_PROGRESS_BAR_VALUE);
        }
    }
}
