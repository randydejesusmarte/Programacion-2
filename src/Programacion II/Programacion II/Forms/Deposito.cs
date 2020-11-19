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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
