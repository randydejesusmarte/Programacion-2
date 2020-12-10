using Programacion_II.Report.Fomrs;
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
            Actualizar();
        }
        private readonly Conectar Conectar = new Conectar();

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
                Conectar.Abrir();
                SqlCommand sqlCommand = new SqlCommand("SELECT Id as 'ID',Nom_cli as 'Nombre del Cliente',Num_cue as 'Numero de Cuenta',tip_cue as 'Tipo de Cuenta',Ced_cli as 'Cedula del Cliente',Val_cue as 'Valor' FROM Cliente Where Id like'%" + textBox1.Text + "%' or Nom_cli like'%" + textBox1.Text + "%';", Conectar.SqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DGV.DataSource = dataTable;
                Conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Conectar.Cerrar();
            }
        }

        private bool formvalid()
        {
            if (Txt_nom.Text.ToString().Trim() == string.Empty || Txt_ced.Text.ToString() == string.Empty || Txt_ape.Text.ToString() == string.Empty || Txt_dir.Text.ToString() == string.Empty || Txt_ema.Text.ToString() == string.Empty || Mt_tel.Text.ToString() == string.Empty || Cb_sex.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Falta datos\nFabor complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Bt_Buscar_Click(object sender, EventArgs e) => Buscar();

        private void Bt_nue_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se se borrara todo los daton en el Formilario\n¿Estas seguro que deseas limpiarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                limpiar();
            }
        }

        private void Bt_can_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El usuario sera eliminado\n¿Esta seguro que deseas eliminar el usuario?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Conectar.Abrir();
                SqlCommand command = new SqlCommand("Delete From Cliente Where Id = '" + Txt_cod.Text + "'", Conectar.SqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso", "Correcto", MessageBoxButtons.OK);
                limpiar();
                Actualizar();
                Conectar.Cerrar();
            }
        }

        private void Bt_gua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se agragara un nuevo usuario\n¿Estas seguro que deseas guardarlo?", "info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (formvalid())
                    {
                        Conectar.Abrir();
                        SqlCommand command = new SqlCommand("insert into Cliente (Nom_cli , Ape_cli , Sex_cli , Ced_cli , Dir_cli, Tel_cli, Fec_cli, Ema_cli, Tip_cue, Val_cue) values ('" + Txt_nom.Text + "','" + Txt_ape.Text + "','" + Cb_sex.Text + "','" + Txt_ced.Text + "','" + Txt_dir.Text + "','" + Mt_tel.Text + "','" + Dtt_FEC.Text + "','" + Txt_ema.Text + "','" + Cb_tip.Text + "','" + Mt_val.Text + "')", Conectar.SqlConnection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Exitoso", "Correcto", MessageBoxButtons.OK);
                        limpiar();
                        Conectar.Cerrar();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Conectar.Cerrar();
            }
            Actualizar();
        }

        private void Bt_mod_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se Modificaran los datos el Usuario\n¿Estas seguro que deseas actualizarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (formvalid())
                {
                    try
                    {
                        Conectar.Abrir();
                        SqlCommand command = new SqlCommand("Update Cliente set Nom_cli = '" + Txt_nom.Text + "', Ape_cli = '" + Txt_ape.Text + "', Sex_cli = '" + Cb_sex.Text + "', Ced_cli = '" + Txt_ced.Text + "', Dir_cli = '" + Txt_dir.Text + "', Tel_cli = '" + Mt_tel.Text + "', Fec_cli = '" + Dtt_FEC.Text + "', Ema_cli = '" + Txt_ema.Text + "', Tip_cue = '" + Cb_tip.Text + "', Val_cue = '" + Mt_val.Text + "' where Id = '" + Txt_cod.Text + "'", Conectar.SqlConnection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Actualizado", "Correcto", MessageBoxButtons.OK);
                        limpiar();
                        Conectar.Cerrar();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                        Conectar.Cerrar();
                    }
                }
            }
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {
                Conectar.Abrir();
                SqlCommand com = new SqlCommand("select Id as'ID', Nom_cli as 'Nombre', Ape_cli as'Apellido', Sex_cli as 'Sexo', Ced_cli as 'Cedula', Dir_cli as 'Direccion', Tel_cli as 'Telefono', Fec_cli as 'Fecha de Nacimiento', Ema_cli as 'Email',  Tip_cue as 'Tipo de Usuario', Val_cue as 'Dinero' from Cliente", Conectar.SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGV.DataSource = dataTable;
                Conectar.Cerrar();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                Conectar.Cerrar();
            }
        }

        private void limpiar()
        {
            Txt_cod.Text = Txt_nom.Text = Txt_ape.Text = Txt_ced.Text = Txt_ema.Text = Txt_dir.Text = Mt_tel.Text = Cb_sex.Text = Cb_tip.Text = Mt_val.Text = "";
            Dtt_FEC.Value = DateTime.Today;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            Txt_cod.Text = row.Cells[0].Value.ToString();
            Txt_nom.Text = row.Cells[1].Value.ToString();
            Txt_ape.Text = row.Cells[2].Value.ToString();
            Cb_sex.Text = row.Cells[3].Value.ToString();
            Txt_ced.Text = row.Cells[4].Value.ToString();
            Txt_dir.Text = row.Cells[5].Value.ToString();
            Mt_tel.Text = row.Cells[6].Value.ToString();
            Dtt_FEC.Value = Convert.ToDateTime(row.Cells[7].Value.ToString());
            Txt_ema.Text = row.Cells[8].Value.ToString();
            Cb_tip.Text = row.Cells[9].Value.ToString();
            Mt_val.Text = row.Cells[10].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new RClintes().ShowDialog();
        }
    }
}
