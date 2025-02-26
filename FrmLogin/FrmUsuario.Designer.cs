namespace Forms
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblCorreo = new Label();
            lblClave = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(29, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 19);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F);
            lblApellido.Location = new Point(29, 109);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(61, 19);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.Location = new Point(29, 171);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 19);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F);
            lblCorreo.Location = new Point(29, 273);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(124, 19);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F);
            lblClave.Location = new Point(29, 333);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(82, 19);
            lblClave.TabIndex = 4;
            lblClave.Text = "Contraseña:";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(29, 436);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(99, 43);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(234, 436);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 43);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(29, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(304, 25);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(29, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(304, 25);
            txtApellido.TabIndex = 8;
            // 
            // txtDNI
            // 
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Segoe UI", 10F);
            txtDNI.Location = new Point(29, 193);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(304, 25);
            txtDNI.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(29, 295);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(304, 25);
            txtCorreo.TabIndex = 10;
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.Location = new Point(29, 355);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(304, 25);
            txtContraseña.TabIndex = 11;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 501);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblClave);
            Controls.Add(lblCorreo);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblCorreo;
        private Label lblClave;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
    }
}