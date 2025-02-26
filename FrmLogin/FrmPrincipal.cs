using Entidades.Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listCrud_Click(object sender, EventArgs e)
        {
            FrmListado formListado = new FrmListado();
            formListado.Show();
            this.Hide();
        }


        private void verLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Abrir archivo de usuarios";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Archivos de Log (*.log)|*.log";

            openFileDialog.DefaultExt = ".log";

            openFileDialog.FileName = "usuarios";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                MostrarContenidoLog(rutaArchivo);
            }
        }



        private void MostrarContenidoLog(string rutaArchivo)
        {
            try
            {
                string contenido = File.ReadAllText(rutaArchivo);

                string titulo = "Contenido del Log\n\n";
                string contenidoConTitulo = titulo + contenido;

                richTextBox1.Visible = true;
                richTextBox1.Text = contenidoConTitulo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }




        private void MostrarUsuariosDeserializados(string path)
        {
            if (Manejadora.DeserializarJSON(path, out List<Usuario> users))
            {
                richTextBox1.Visible = true;

                StringBuilder sb = new StringBuilder();

                foreach (var user in users)
                {
                    sb.AppendLine(user.ToString());
                }

                richTextBox1.Text = sb.ToString();
            }
            else
            {
                MessageBox.Show("Error al deserializar el archivo JSON.");
            }
        }


        private async void ObtenerYMostrarUsuariosAsync()
        {
            List<Usuario> listaUsuarios = ADO.ObtenerTodos();

            richTextBox1.Clear();
            foreach (var usuario in listaUsuarios)
            {
                richTextBox1.AppendText(usuario.ToString() + "\n");
            }

            await IntercambiarColoresAsync(listaUsuarios);
        }

        private async Task IntercambiarColoresAsync(List<Usuario> listaUsuarios)
        {
            bool esColorNegro = true;

            foreach (var usuario in listaUsuarios)
            {
                if (esColorNegro)
                {
                    richTextBox1.BackColor = Color.Black;
                    richTextBox1.ForeColor = Color.White;
                }
                else
                {
                    richTextBox1.BackColor = Color.White;
                    richTextBox1.ForeColor = Color.Black;
                }

                esColorNegro = !esColorNegro;

                await Task.Delay(1500);
            }
        }

        private void deserializarJSON_Click(object sender, EventArgs e)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = escritorio + @"\usuarios_repetidos.json";
            MostrarUsuariosDeserializados(rutaArchivo);
        }

        private void task_Click(object sender, EventArgs e)
        {
            ObtenerYMostrarUsuariosAsync();

        }
    }
}