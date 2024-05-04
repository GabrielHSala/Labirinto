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
    public partial class frmSala1 : Form
    {
        public frmSala1()
        {
            InitializeComponent();
        }

        private void btn1x2_Click(object sender, EventArgs e)
        {
            frmSala2 frmSala2 = new frmSala2();

            this.Hide();

            frmSala2.Closed += (object s, EventArgs ev) => this.Show();

            frmSala2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
