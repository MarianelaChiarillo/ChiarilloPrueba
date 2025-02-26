using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Entidades.Final
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Trusted;
        private string Encrypt;
        private static Conexion conn = null; // Debe ser static para Singleton

        private Conexion()
        {
            this.Base = "laboratorio_2";
            this.Servidor = "DESKTOP-G6OHPKU\\SQLEXPRESS";
            this.Trusted = "True";
            this.Encrypt = "False";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = $"Server={this.Servidor};Database={this.Base};Trusted_Connection={this.Trusted};Encrypt={this.Encrypt};";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw new Exception("Error al crear la conexión", ex);
            }
            return Cadena;
        }

        public static Conexion GetInstancia()
        {
            if (conn == null)
            {
                conn = new Conexion();
            }
            return conn;
        }
    }
}



/// <summary>
/// connection = new SqlConnection("Server=DESKTOP-G6OHPKU;Database=Users;Trusted_Connection=True;Encrypt=False");
/// </summary>