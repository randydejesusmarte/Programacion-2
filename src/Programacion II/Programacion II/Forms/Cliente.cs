using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II.Forms
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new ControlUsuario().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            Close();
        }
    }
}
