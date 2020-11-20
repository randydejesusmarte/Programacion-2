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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly Conectar Con = new Conectar();
        private void BT_Entrar_Click(object sender, EventArgs e)
        {
            if (Formesvalido())
            {
                if (Esusuario())
                {
                    new Menu_principal().Show();
                    Hide();
                }
            }
        }

        private bool Esusuario()
        {
            try
            {
                Con.Abrir();
                SqlCommand login = new SqlCommand("Select Count(*) From Usuario Where Nom_udu = '" + Txtnom.Text.Trim() + "' and Cla_usu = '" + Txtcla.Text.Trim() + "'", Con.SqlConnection);
                int valor = int.Parse(login.ExecuteScalar().ToString());
                if (valor == 0)
                {
                    MessageBox.Show("El usuario o la contraseña estan incorrentos");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.ToString());
                return false;
            }
        }

        private bool Formesvalido()
        {
            if (Txtnom.Text.ToString().Trim() == string.Empty || Txtcla.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Falta datos\nFabor complete los campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
