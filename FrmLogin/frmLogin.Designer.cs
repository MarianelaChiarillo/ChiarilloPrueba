namespace FrmLogin
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            correo = new Label();
            Contraseña = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnEnviar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // correo
            // 
            correo.AutoSize = true;
            correo.Font = new Font("Segoe UI", 10F);
            correo.Location = new Point(28, 59);
            correo.Name = "correo";
            correo.Size = new Size(121, 19);
            correo.TabIndex = 0;
            correo.Text = "Correo electrónico";
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Font = new Font("Segoe UI", 10F);
            Contraseña.Location = new Point(28, 143);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(79, 19);
            Contraseña.TabIndex = 1;
            Contraseña.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(28, 81);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "  Ingrese su correo";
            txtCorreo.Size = new Size(295, 25);
            txtCorreo.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.Location = new Point(28, 165);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "  Ingrese su contraseña";
            txtContraseña.Size = new Size(295, 25);
            txtContraseña.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Location = new Point(28, 234);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(108, 35);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(215, 234);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(108, 35);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 301);
            Controls.Add(btnCerrar);
            Controls.Add(btnEnviar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(Contraseña);
            Controls.Add(correo);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label correo;
        private Label Contraseña;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnEnviar;
        private Button btnCerrar;
    }
}
