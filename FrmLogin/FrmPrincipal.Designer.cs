namespace Forms
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            usuariosMenu = new ToolStripMenuItem();
            listCrud = new ToolStripMenuItem();
            verLog = new ToolStripMenuItem();
            deserializarJSON = new ToolStripMenuItem();
            task = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosMenu
            // 
            usuariosMenu.DropDownItems.AddRange(new ToolStripItem[] { listCrud, verLog, deserializarJSON, task });
            usuariosMenu.Name = "usuariosMenu";
            usuariosMenu.Size = new Size(64, 20);
            usuariosMenu.Text = "Usuarios";
            // 
            // listCrud
            // 
            listCrud.Name = "listCrud";
            listCrud.Size = new Size(181, 22);
            listCrud.Text = "1.- Listado CRUD";
            listCrud.Click += listCrud_Click;
            // 
            // verLog
            // 
            verLog.Name = "verLog";
            verLog.Size = new Size(181, 22);
            verLog.Text = "2.- Ver Log";
            verLog.Click += verLog_Click;
            // 
            // deserializarJSON
            // 
            deserializarJSON.Name = "deserializarJSON";
            deserializarJSON.Size = new Size(181, 22);
            deserializarJSON.Text = "3.- Deserializar JSON";
            deserializarJSON.Click += deserializarJSON_Click;
            // 
            // task
            // 
            task.Name = "task";
            task.Size = new Size(181, 22);
            task.Text = "4.- Task";
            task.Click += task_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 294);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 321);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Marianela Chiarillo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosMenu;
        private ToolStripMenuItem listCrud;
        private ToolStripMenuItem verLog;
        private ToolStripMenuItem deserializarJSON;
        private ToolStripMenuItem task;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
    }
}