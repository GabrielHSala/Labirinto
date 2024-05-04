using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmSala12 : Form
    {
        public frmSala12()
        {
            InitializeComponent();
        }

        private void btn12x14_Click(object sender, EventArgs e)
        {
            frmFinal frmFinal = new frmFinal();

            this.Hide();

            frmFinal.Closed += (object s, EventArgs ev) => this.Show();

            frmFinal.Show();

        }

        private void btn12x6_Click(object sender, EventArgs e)
        {

        }

        private void btn12x13_Click(object sender, EventArgs e)
        {
        }

        private void btn12x3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
