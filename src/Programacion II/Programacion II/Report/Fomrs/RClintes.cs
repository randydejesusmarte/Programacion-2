using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II.Report.Fomrs
{
    public partial class RClintes : Form
    {
        public RClintes()
        {
            InitializeComponent();
        }

        private void rcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cliente.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.cliente.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
