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
    public partial class ControlUsuario : Form
    {
        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void Bt_guardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se agragara un nuevo usuario\n¿Estas seguro que deseas guardarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("si");
            }
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("La creacion del nuevo usuario sera canselado\n¿esta seguro que deseas cerrar?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("si");
            }
        }
    }
}
