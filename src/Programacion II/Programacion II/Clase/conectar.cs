using System;
using System.Data.SqlClient;

namespace Programacion_II
{
    internal class Conectar
    {
        public SqlConnection SqlConnection = new SqlConnection();

        private readonly string cadena = $"Data source = DESKTOP-UJUKNJS\\SQLEXPRESS; Initial Catalog = Control_Financiero; Integrated Security = True;";

        public Conectar()
        {
            SqlConnection.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                SqlConnection.Open();
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }
        public void Cerrar()
        {
            try
            {
                SqlConnection.Close();
            }
            catch (Exception es)
            {
                Console.WriteLine(es);
            }
        }
    }
}
