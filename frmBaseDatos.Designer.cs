namespace PROCESO_CRUD
{
    partial class frm_BaseDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.govContenedor = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.govContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(17, 50);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(18, 16);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(128, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(325, 50);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(42, 16);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(21, 70);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(329, 70);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(132, 22);
            this.txtClave.TabIndex = 5;
            // 
            // govContenedor
            // 
            this.govContenedor.Controls.Add(this.lblSoloNumeros);
            this.govContenedor.Controls.Add(this.btnEliminar);
            this.govContenedor.Controls.Add(this.btnActualizar);
            this.govContenedor.Controls.Add(this.btnGuardar);
            this.govContenedor.Controls.Add(this.txtId);
            this.govContenedor.Controls.Add(this.txtClave);
            this.govContenedor.Controls.Add(this.lblCedula);
            this.govContenedor.Controls.Add(this.txtNombre);
            this.govContenedor.Controls.Add(this.lblNombre);
            this.govContenedor.Controls.Add(this.lblClave);
            this.govContenedor.Location = new System.Drawing.Point(16, 15);
            this.govContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.govContenedor.Name = "govContenedor";
            this.govContenedor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.govContenedor.Size = new System.Drawing.Size(513, 159);
            this.govContenedor.TabIndex = 6;
            this.govContenedor.TabStop = false;
            this.govContenedor.Text = "Informacion Persona";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(268, 117);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(147, 117);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 28);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(21, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.GridColor = System.Drawing.Color.LightGray;
            this.dgvPersonas.Location = new System.Drawing.Point(16, 181);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.Size = new System.Drawing.Size(513, 217);
            this.dgvPersonas.TabIndex = 7;
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNumeros.Location = new System.Drawing.Point(403, 96);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(90, 16);
            this.lblSoloNumeros.TabIndex = 9;
            this.lblSoloNumeros.Text = "Solo números";
            // 
            // frm_BaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 411);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.govContenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_BaseDatos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmr_Panel_Load);
            this.govContenedor.ResumeLayout(false);
            this.govContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.GroupBox govContenedor;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label lblSoloNumeros;
    }
}

