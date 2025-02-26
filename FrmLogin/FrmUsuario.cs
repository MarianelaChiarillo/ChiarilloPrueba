using Entidades.Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmUsuario : Form
    {

        private Usuario usuarioActual;

        public FrmUsuario()
        {

            InitializeComponent();
            ADO ado = new ADO();
            ado.apellidoExistente += ado.Manejador_apellidoExistenteLog;
            ado.apellidoExistente += ado.Manejador_apellidoExistenteJSON;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        public FrmUsuario(Usuario usuario) : this()
        {
            usuarioActual = usuario;
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (usuarioActual != null)
            {
                txtNombre.Text = usuarioActual.Nombre;
                txtApellido.Text = usuarioActual.Apellido;
                txtDNI.Text = usuarioActual.Dni.ToString();
                txtDNI.Enabled = false;
                txtCorreo.Text = usuarioActual.Correo;
                txtContraseña.Text = usuarioActual.Clave;
            }
        }


        private bool ValidarCampo(string campo, string valor, string tipo)
        {
            Regex regex = null;

            switch (tipo)
            {
                case "nombreApellido":
                    regex = new Regex(@"^[a-zA-Z]+$");
                    break;
                case "dni":
                    regex = new Regex(@"^\d{8}$");
                    break;
                case "correo":
                    regex = new Regex(@"^[^@]+@[^@]+\.[^@]+$");
                    break;
                default:
                    return false;
            }

            if (string.IsNullOrWhiteSpace(valor) || !regex.IsMatch(valor))
            {
                MessageBox.Show($"{campo} no es válido.");
                return false;
            }

            return true;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;
            string dni = txtDNI.Text;

            // Validaciones usando el método genérico
            if (!ValidarCampo("El nombre", nombre, "nombreApellido") ||
                !ValidarCampo("El apellido", apellido, "nombreApellido") ||
                !ValidarCampo("El DNI", dni, "dni") ||
                !ValidarCampo("El correo", correo, "correo"))
            {
                return; // Si alguna validación falla, se detiene el proceso
            }

            int dniInt = int.Parse(dni); // Convertimos el DNI a un entero

            if (usuarioActual == null)
            {
                Usuario nuevoUsuario = new Usuario(nombre, apellido, dniInt, correo, contraseña);
                ADO ado = new ADO();

                bool esTrue = ado.Agregar(nuevoUsuario);

                if (esTrue)
                {
                    FrmPrincipal formPrincipal = new FrmPrincipal();
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: El apellido ya existe.");
                }
            }
            else
            {
                usuarioActual.Nombre = nombre;
                usuarioActual.Apellido = apellido;
                usuarioActual.Correo = correo;
                usuarioActual.Clave = contraseña;

                bool modificado = new ADO().Modificar(usuarioActual);

                if (!modificado)
                {
                    MessageBox.Show("Error: No se pudo modificar el usuario.");
                    return;
                }
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

