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
    public partial class frmSala5 : Form
    {
        public frmSala5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSala6 frmSala6 = new frmSala6();

            this.Hide();

            frmSala6.Closed += (object s, EventArgs ev) => this.Show();

            frmSala6.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
