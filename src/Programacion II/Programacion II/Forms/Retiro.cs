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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
            timer1.Start();
        }

        /// <summary>
        /// Declaracion de veriables y constantes
        /// </summary>
        string vDia;
        string vHora;
        private void Atras_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vDia = DateTime.Today.ToShortDateString();
            vHora = DateTime.Now.ToString("hh:mm");
            Tiempo.Text = vDia + " " + vHora;
        }
    }
}
