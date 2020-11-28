using Programacion_II.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void BtDeposito_Click(object sender, EventArgs e)
        {
            new Deposito().ShowDialog();
        }

        private void BtRetiro_Click(object sender, EventArgs e)
        {
            new Retiro().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new préstamo().ShowDialog();
        }

        private void BtUsuario_Click(object sender, EventArgs e)
        {
            new ControlUsuario().ShowDialog();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Btacercad_Click(object sender, EventArgs e)
        {
            new Cliente().ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
