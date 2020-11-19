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
    public partial class préstamo : Form
    {
        public préstamo()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            Close();
        }
    }
}
