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

namespace Programacion_II
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
            Tempo.Start();
        }
        /// <summary>
        /// Declaracion de veriables y constantes
        /// </summary>
        string vDia;
        string vHora;
        Conectar conectar = new Conectar();

        private void Tempo_Tick(object sender, EventArgs e)
        {
            vDia = DateTime.Today.ToShortDateString();
            vHora = DateTime.Now.ToString("hh:mm");
            Tiempo.Text = vDia + " " + vHora;
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            Close();
        }
        private void Limpiar()
        {
            Cb_mon.SelectedItem = Cb_tip.SelectedItem = null;
            Tx_nom.Text = "";
            Mt_ced.Text = Mt_mon.Text = Mt_num.Text = Mt_val.Text = "";
        }
        private void Bt_nue_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Bt_gua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Se agragara un nuevo Deposito\n¿Estas seguro que deseas guardarlo?", "info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (formvalid())
                    {
                        conectar.Abrir();
                        SqlCommand guardar = new SqlCommand("insert into Deposito (Num_cue, Nom_ben, Ced_cli, Tip_cue, Mon_dep, Moneda) values ('" + Mt_num.Text + "','" + Tx_nom.Text + "','" + Mt_ced.Text + "','" + Cb_tip.SelectedItem.ToString() + "','" + Mt_mon.Text + "','" + Cb_tip.SelectedItem.ToString() + "');", conectar.SqlConnection);
                        guardar.ExecuteNonQuery();
                        MessageBox.Show("Reguistro exitoso", "correcto", MessageBoxButtons.OK);
                        Limpiar();
                        conectar.Cerrar();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                conectar.Cerrar();
            }
        }

        private bool formvalid()
        {
            if (Mt_ced.Text.ToString().Trim() == string.Empty || Mt_mon.Text.ToString() == string.Empty || Mt_num.Text.ToString() == string.Empty || Tx_nom.Text.ToString() == string.Empty || Cb_mon.SelectedItem.ToString() == string.Empty || Cb_tip.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Falta datos\nFabor complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Bt_mod_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se agragara un nuevo usuario\n¿Estas seguro que deseas guardarlo?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (formvalid())
                {
                    try
                    {
                        conectar.Abrir();
                        SqlCommand command = new SqlCommand("Update Deposito set Num_cue = '" + Mt_num.Text + "', Nom_ben = '" + Tx_nom.Text + "', Ced_cli = '" + Mt_ced.Text + "', Tip_cue = '" + Cb_tip.Text + "', Mon_dep = '" + Mt_mon.Text + "', Moneda = '" + Cb_mon.Text + "' where Id = '" + txt_id.Text + "'", conectar.SqlConnection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registro Actualizado", "Correcto", MessageBoxButtons.OK);
                        Limpiar();
                        conectar.Cerrar();
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                        conectar.Cerrar();
                    }
                }
            }
        }

        private void Bt_can_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("El usuario sera eliminado\n¿Esta seguro que deseas eliminar el usuario?", "info", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                conectar.Abrir();
                SqlCommand command = new SqlCommand("Delete From Deposito Where Id = '" + txt_id.Text + "'", conectar.SqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso", "Correcto", MessageBoxButtons.OK);
                Limpiar();
                conectar.Cerrar();
            }
        }
    }
}
