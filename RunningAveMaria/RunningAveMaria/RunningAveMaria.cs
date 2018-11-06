using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAveMaria
{
    public partial class frmRunningAve : Form
    {
        public frmRunningAve()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //declare local variables
            int nextNumber;
            int total;
            int mark;

            //get the number from the textbox
            nextNumber = int.Parse(txtNumber.Text);

            //if th user enters -1, display a Goodbye message and disable buttons


            else if (nextNumber == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.btnAverage.Enabled = false;
                this.txtNumber.Visible = false;
            }
        }
    }
}
