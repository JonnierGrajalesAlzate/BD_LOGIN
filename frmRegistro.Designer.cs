namespace PROCESO_CRUD
{
    partial class frmRegistro
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
            this.govContenedor = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.govContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // govContenedor
            // 
            this.govContenedor.Controls.Add(this.lblSoloNumeros);
            this.govContenedor.Controls.Add(this.btnGuardar);
            this.govContenedor.Controls.Add(this.txtClave);
            this.govContenedor.Controls.Add(this.txtNombre);
            this.govContenedor.Controls.Add(this.lblNombre);
            this.govContenedor.Controls.Add(this.lblClave);
            this.govContenedor.Location = new System.Drawing.Point(13, 38);
            this.govContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.govContenedor.Name = "govContenedor";
            this.govContenedor.Padding = new System.Windows.Forms.Padding(4);
            this.govContenedor.Size = new System.Drawing.Size(402, 174);
            this.govContenedor.TabIndex = 7;
            this.govContenedor.TabStop = false;
            this.govContenedor.Text = "Información";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(21, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(219, 58);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(132, 22);
            this.txtClave.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 58);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 38);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(215, 38);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(42, 16);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(163, 9);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(85, 16);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "REGISTRO";
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNumeros.Location = new System.Drawing.Point(278, 84);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(90, 16);
            this.lblSoloNumeros.TabIndex = 7;
            this.lblSoloNumeros.Text = "Solo números";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 225);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.govContenedor);
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.govContenedor.ResumeLayout(false);
            this.govContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox govContenedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblSoloNumeros;
    }
}