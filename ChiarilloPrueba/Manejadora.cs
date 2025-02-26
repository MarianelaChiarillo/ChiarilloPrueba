using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entidades.Final;

namespace Entidades.Final
{
    public  class Manejadora
    {
        public static bool EscribirArchivo(List<Usuario> users, string apellidoIngresado)
        {
            try
            {
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "usuarios.log");

                using (StreamWriter escribir = new StreamWriter(rutaArchivo, true))
                {
                    if (users.Count > 0) 
                    {
                        escribir.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        escribir.WriteLine(apellidoIngresado + ":");

                        foreach (var usuario in users)
                        {
                            escribir.WriteLine(usuario.Correo);
                        }

                        escribir.WriteLine("---------------------");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo: " + ex.Message);
                return false;
            }
        }

        public static bool SerializarJSON(List<Usuario> users, string path)
        {
            try
            {
                if (users.Count > 0) 
                {
                    string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

                    string rutaArchivoJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), path);
                    File.WriteAllText(rutaArchivoJson, json);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar en JSON: " + ex.Message);
                return false;
            }
        }



        public static bool DeserializarJSON(string path, out List<Usuario> users)
        {
            users = new List<Usuario>();
            try
            {
                string miJson = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<Usuario>>(miJson);
                return true;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Archivo no encontrado: " + ex.Message);
                return false;
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error en el formato JSON: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }




    }
}
