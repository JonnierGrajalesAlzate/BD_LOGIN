namespace PROCESO_CRUD
{
    partial class frmCreador
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(160, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:  Jonnier Grajales Alzate";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(9, 79);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(170, 13);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo:  alzatejonny39@gmail.com";
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Location = new System.Drawing.Point(9, 124);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(98, 13);
            this.lblEstudio.TabIndex = 2;
            this.lblEstudio.Text = "Estudio: Ing de soft";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.pbImagen);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblEstudio);
            this.gbDatos.Controls.Add(this.lblCorreo);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(508, 208);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de contacto";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::PROCESO_CRUD.Properties.Resources.IMG_0913;
            this.pbImagen.Location = new System.Drawing.Point(280, 29);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(159, 150);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // frmCreador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.gbDatos);
            this.Name = "frmCreador";
            this.Text = "frmCreador";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}