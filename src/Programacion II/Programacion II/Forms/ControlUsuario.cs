using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
            Actualizar();
        }
        Conectar Conectar = new Conectar();

        private string tipo;

        private void Bt_guardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se agragara un nuevo usuario\n¿Estas seguro que deseas guardarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Rb_adm.Checked)
                {
                    tipo = "admin";
                }
                else if (Rb_dep.Checked)
                {
                    tipo = "Deposito";
                }
                else
                {
                    tipo = "retiro";
                }
                if (formvalid())
                {
                    if (Txt_cla.Text == Txt_ccl.Text)
                    {
                        try
                        {
                            Conectar.Abrir();
                            SqlCommand command = new SqlCommand("insert into Usuario (Cla_usu , Nom_udu , Ape_usu , Tip_usu , Ema_usu) values ('" + Txt_cla.Text + "','" + Txt_nom.Text + "','" + Txt_ape.Text + "','" + tipo + "','" + Txt_ema.Text + "')", Conectar.SqlConnection);
                            command.ExecuteNonQuery();
                            Conectar.Cerrar();
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.Message);
                            Conectar.Cerrar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La clacve no coinseden");
                        Txt_cla.Focus();
                    }
                }
            }
            Actualizar();
        }

        private bool formvalid()
        {
            if(Txt_nom.Text.ToString().Trim() == string.Empty || Txt_cla.Text.ToString() == string.Empty || Txt_ape.Text.ToString() == string.Empty || Txt_ccl.Text.ToString() == string.Empty || Txt_ema.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Falta datos\nFabor complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("La creacion del nuevo usuario sera canselado\n¿esta seguro que deseas cerrar?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bt_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se se borrara todo los daton en el Formilario\n¿Estas seguro que deseas limpiarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Txt_id.Text = Txt_nom.Text = Txt_ape.Text = Txt_cla.Text = Txt_ema.Text = Txt_ccl.Text = "";
                Rb_adm.Checked = true;
            }
        }

        private void Bt_modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se Modificaran los datos el Usuario\n¿Estas seguro que deseas actualizarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("si");
            }
        }
       
        private void Actualizar()
        {
            try
            {
                Conectar.Abrir();
                SqlCommand com = new SqlCommand("select Ide_usu as'ID', Nom_udu as 'Nombre', Ape_usu as'Apellido', Tip_usu as 'Tipo de Usuario', Ema_usu as 'Email' from Usuario", Conectar.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                Conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Conectar.Cerrar();
            }
        }
    }
}
