using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class Usuario
    {
        private string apellido;
        private string clave;
        private string correo;
        private int dni;
        private string nombre;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + " - Apellido: " + Apellido + " - Correo: " + Correo + " - Dni: " + Dni;
        }

        public Usuario()
        {
            
        }

        public Usuario(string nombre, string apellido, int dni, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correo = correo;
            this.clave = null;
        }

        public Usuario(string nombre, string apellido, int dni, string correo, string clave)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correo = correo;
            this.clave = clave;
        }
    }


}