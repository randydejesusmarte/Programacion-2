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
            new Deposito().Show();
            Close();
        }

        private void BtRetiro_Click(object sender, EventArgs e)
        {
            new Retiro().Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new préstamo().Show();
            Close();
        }

        private void BtUsuario_Click(object sender, EventArgs e)
        {
            new Cliente().Show();
            Close();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Btacercad_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
