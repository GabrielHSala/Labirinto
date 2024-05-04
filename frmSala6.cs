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
    public partial class frmSala6 : Form
    {
        public frmSala6()
        {
            InitializeComponent();
        }

        private void frmSala6_Load(object sender, EventArgs e)
        {

        }

        private void btn6x12_Click(object sender, EventArgs e)
        {
            frmSala12 frmSala12 = new frmSala12();

            this.Hide();

            frmSala12.Closed += (object s, EventArgs ev) => this.Show();

            frmSala12.Show();
        }

        private void btn6x5_Click(object sender, EventArgs e)
        {

        }

        private void btn6x4_Click(object sender, EventArgs e)
        {
        }

        private void btn6x3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
