namespace PROCESO_CRUD
{
    partial class frmGaleria
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
            this.pbPerro = new System.Windows.Forms.PictureBox();
            this.pbPajaro = new System.Windows.Forms.PictureBox();
            this.pbLoro = new System.Windows.Forms.PictureBox();
            this.pbGato = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPajaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPerro
            // 
            this.pbPerro.Image = global::PROCESO_CRUD.Properties.Resources._1366_2000;
            this.pbPerro.Location = new System.Drawing.Point(17, 19);
            this.pbPerro.Name = "pbPerro";
            this.pbPerro.Size = new System.Drawing.Size(176, 132);
            this.pbPerro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerro.TabIndex = 0;
            this.pbPerro.TabStop = false;
            // 
            // pbPajaro
            // 
            this.pbPajaro.Image = global::PROCESO_CRUD.Properties.Resources.contenido;
            this.pbPajaro.Location = new System.Drawing.Point(17, 172);
            this.pbPajaro.Name = "pbPajaro";
            this.pbPajaro.Size = new System.Drawing.Size(176, 132);
            this.pbPajaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPajaro.TabIndex = 1;
            this.pbPajaro.TabStop = false;
            // 
            // pbLoro
            // 
            this.pbLoro.Image = global::PROCESO_CRUD.Properties.Resources.saludable;
            this.pbLoro.Location = new System.Drawing.Point(268, 172);
            this.pbLoro.Name = "pbLoro";
            this.pbLoro.Size = new System.Drawing.Size(176, 132);
            this.pbLoro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoro.TabIndex = 3;
            this.pbLoro.TabStop = false;
            // 
            // pbGato
            // 
            this.pbGato.Image = global::PROCESO_CRUD.Properties.Resources.camara_reflex_digital;
            this.pbGato.Location = new System.Drawing.Point(268, 19);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(176, 132);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGato.TabIndex = 2;
            this.pbGato.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPerro);
            this.groupBox1.Controls.Add(this.pbLoro);
            this.groupBox1.Controls.Add(this.pbGato);
            this.groupBox1.Controls.Add(this.pbPajaro);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 330);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galeria";
            // 
            // frmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGaleria";
            this.Text = "frmGaleria";
            ((System.ComponentModel.ISupportInitialize)(this.pbPerro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPajaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPerro;
        private System.Windows.Forms.PictureBox pbPajaro;
        private System.Windows.Forms.PictureBox pbLoro;
        private System.Windows.Forms.PictureBox pbGato;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}