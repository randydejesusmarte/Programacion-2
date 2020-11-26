using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Buscar();
        }
        private readonly Conectar conectar = new Conectar();

        private void Bt_Usuario_Click(object sender, EventArgs e)
        {
            new ControlUsuario().ShowDialog();
        }

        private void Bt_Atras_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            Close();
        }

        private void Buscar()
        {
            try
            {
                conectar.Abrir();
                SqlCommand sqlCommand = new SqlCommand("SELECT Id as 'ID',Nom_cli as 'Nombre del Cliente',Num_cue as 'Numero de Cuenta',tip_cue as 'Tipo de Cuenta',Ced_cli as 'Cedula del Cliente',Val_cue as 'Valor' FROM Cliente Where Id like'%" + textBox1.Text + "%' or Nom_cli like'%" + textBox1.Text + "%';", conectar.SqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource=dataTable;
                conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                conectar.Cerrar();
            }
        }

        private void Bt_Buscar_Click(object sender, EventArgs e) => Buscar();
    }
}
