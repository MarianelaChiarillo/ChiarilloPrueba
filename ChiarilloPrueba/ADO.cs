using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class ADO
    {

        private static Conexion conexion = Conexion.GetInstancia();
        public delegate void ApellidoUsuarioExistente(string apellido);
        public event ApellidoUsuarioExistente? apellidoExistente;

        public ADO()
        {
           
        }

        public bool apellidoEnLista(string apellido)
        {
            List<Usuario> listaUsuarios = ObtenerTodos();

            foreach (var usuario in listaUsuarios)
            {
                if (usuario.Apellido == apellido)
                {
                    apellidoExistente?.Invoke(apellido); 
                    return true;
                }
            }

            return false;
        }

        public void Manejador_apellidoExistenteLog(string apellido)
        {
            List<Usuario> usuariosConApellido = ObtenerTodos(apellido);
            Manejadora.EscribirArchivo(usuariosConApellido, apellido);
        }

        public void Manejador_apellidoExistenteJSON(string apellido)
        {
            List<Usuario> usuariosConApellido = ObtenerTodos(apellido);
            bool resultado = Manejadora.SerializarJSON(usuariosConApellido, "usuarios_repetidos.json");

            if (resultado)
            {
                Console.WriteLine("Usuarios repetidos serializados correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontraron usuarios repetidos o hubo un error.");
            }
        }

    

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT nombre, apellido, dni, correo, clave FROM usuarios";

            using (SqlConnection connection = conexion.CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario(
                                reader["nombre"].ToString(),
                                reader["apellido"].ToString(),
                                Convert.ToInt32(reader["dni"]),
                                reader["correo"].ToString(),
                                reader["clave"].ToString()
                            );
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en ObtenerTodos: " + ex.Message);
                }
            }

            return listaUsuarios;
        }

        public static List<Usuario> ObtenerTodos(string apellidoUsuario)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            string query = "SELECT nombre, apellido, dni, correo, clave FROM usuarios WHERE apellido = @apellido";

            using (SqlConnection connection = conexion.CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@apellido", apellidoUsuario);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario(
                                    reader["nombre"].ToString(),
                                    reader["apellido"].ToString(),
                                    Convert.ToInt32(reader["dni"]),
                                    reader["correo"].ToString(),
                                    reader["clave"].ToString()
                                );
                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en ObtenerTodos(apellido): " + ex.Message);
                }
            }

            return listaUsuarios;
        }

        public bool Agregar(Usuario user)
        {

            apellidoExistente += Manejador_apellidoExistenteLog;
            apellidoExistente += Manejador_apellidoExistenteJSON;

            string query = "INSERT INTO usuarios (nombre, apellido, dni, correo, clave) VALUES (@nombre, @apellido, @dni, @correo, @clave)";

            if (apellidoEnLista(user.Apellido))
            {
                apellidoExistente?.Invoke(user.Apellido);
            }

            using (SqlConnection connectionString = conexion.CrearConexion())
            {
                try
                {
                    connectionString.Open();
                    using (SqlCommand comando = new SqlCommand(query, connectionString))
                    {
                        comando.Parameters.AddWithValue("@nombre", user.Nombre);
                        comando.Parameters.AddWithValue("@apellido", user.Apellido);
                        comando.Parameters.AddWithValue("@dni", user.Dni);
                        comando.Parameters.AddWithValue("@correo", user.Correo);
                        comando.Parameters.AddWithValue("@clave", user.Clave);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }


        public bool Eliminar(Usuario user)
        {
            string query = "DELETE FROM usuarios WHERE dni = @dni";

            using (SqlConnection con = conexion.CrearConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dni", user.Dni); // Corregido
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en Eliminar: " + ex.Message);
                    return false;
                }
            }
        }


        public bool Modificar(Usuario user)
        {
            string query = "UPDATE usuarios SET nombre = @nombre, apellido = @apellido, correo = @correo, clave = @clave WHERE dni = @dni";

            using (SqlConnection connection = conexion.CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand comando = new SqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@nombre", user.Nombre);
                        comando.Parameters.AddWithValue("@apellido", user.Apellido);
                        comando.Parameters.AddWithValue("@correo", user.Correo);
                        comando.Parameters.AddWithValue("@clave", user.Clave);
                        comando.Parameters.AddWithValue("@dni", user.Dni); 

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en Modificar: " + ex.Message);
                    return false;
                }
            }
        }


     

    }
}

