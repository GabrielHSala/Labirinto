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
    public partial class frmSala2 : Form
    {
        public frmSala2()
        {
            InitializeComponent();
        }

        private void btn2x5_Click(object sender, EventArgs e)
        {
            frmSala5 frmSala5 = new frmSala5();

            this.Hide();

            frmSala5.Closed += (object s, EventArgs ev) => this.Show();

            frmSala5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
