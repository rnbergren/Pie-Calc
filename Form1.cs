using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPI_Click(object sender, EventArgs e)
        {
            double dPI = 0.00;
            int isign = 0;
            double ifour = 4;
            double iSeed = 0;
            bool ival = double.TryParse(txtValue.Text.ToString(),out iSeed);
            for (ulong i = 1; i < iSeed; i += 2)
            {
                if (isign == 1)
                {
                    dPI += ifour / i;
                    isign = 0;
                }
                else
                {
                    dPI -= ifour / i;
                    isign = 1;
                    lblAns.Text = dPI.ToString(); // i.ToString();
                }
                lblo.Text = i.ToString();
                Application.DoEvents();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
