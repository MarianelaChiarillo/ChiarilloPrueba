using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Final;
using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;


namespace Entidades.Final
{
    public class Login
    {
        protected string email;
        protected string pass;

        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public Login(string correo, string clave)
        {
            this.email = correo;
            this.pass = clave;
        }



        public bool Loguear()
        {
            Conexion conexion = Conexion.GetInstancia();

            string query = "SELECT 1 FROM usuarios WHERE correo = @correo AND clave = @clave";

            using (SqlConnection conexionString = conexion.CrearConexion())
            {
                try
                {
                    conexionString.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexionString))
                    {
                        comando.Parameters.AddWithValue("@correo", this.email);
                        comando.Parameters.AddWithValue("@clave", this.pass);

                        return comando.ExecuteScalar() != null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la autenticación: " + ex.Message);
                    return false;
                }
            }
        }
    }
}





