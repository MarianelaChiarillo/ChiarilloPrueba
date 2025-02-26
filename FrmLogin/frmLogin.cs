using Entidades.Final; // Correcto
using Forms;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            string correo = txtCorreo.Text;
            string clave = txtContraseña.Text; 

            Login login = new Login(correo, clave);

            bool esTrue = login.Loguear();

            if (esTrue)
            {
                FrmPrincipal formPrincipal = new FrmPrincipal();
                formPrincipal.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Error: correo o contraseña incorrectos");
            }
        }

    }
}
