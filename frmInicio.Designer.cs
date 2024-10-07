namespace PROCESO_CRUD
{
    partial class frmInicio
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(69, 100);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(257, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(69, 167);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(257, 22);
            this.txtClave.TabIndex = 1; 
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Location = new System.Drawing.Point(123, 22);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(107, 16);
            this.lblIniciarSesion.TabIndex = 2;
            this.lblIniciarSesion.Text = "INICIAR SESION";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(65, 80);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(65, 148);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(42, 16);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Location = new System.Drawing.Point(127, 208);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(131, 28);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROCESO_CRUD.Properties.Resources.saludable;
            this.pictureBox1.Location = new System.Drawing.Point(384, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(13, 278);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(94, 28);
            this.btnRegistrarse.TabIndex = 8;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(611, 278);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 321);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.Text = "fmrInicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnAdmin;
    }
}