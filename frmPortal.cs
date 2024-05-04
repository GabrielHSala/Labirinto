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
    public partial class frmPortal : Form
    {
        public frmPortal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmSala1 frmSala1 = new frmSala1();

            this.Hide();

            frmSala1.Closed += (object s, EventArgs ev) => this.Show();

            frmSala1.Show();

        }
    }
}
