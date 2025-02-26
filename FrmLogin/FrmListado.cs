using Entidades.Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmListado : Form
    {
        public FrmListado()
        {
            InitializeComponent();
            CargarUsuarios();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuario formUsuario = new FrmUsuario();
            formUsuario.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dataGridView1.SelectedRows[0].DataBoundItem;

                FrmUsuario formUsuario = new FrmUsuario(usuarioSeleccionado); // Pasamos el usuario a modificar
                formUsuario.ShowDialog();
                CargarUsuarios(); // Refrescar listado después de modificar
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Usuario usuarioSeleccionado = (Usuario)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool eliminado = new ADO().Eliminar(usuarioSeleccionado);

                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado con éxito.");
                        CargarUsuarios(); // Refrescar listado
                    }
                    else
                    {
                        MessageBox.Show("Error: No se pudo eliminar el usuario.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }

        private void CargarUsuarios()
        {
            List<Usuario> listaUsuarios = ADO.ObtenerTodos(); 
            dataGridView1.DataSource = listaUsuarios; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
