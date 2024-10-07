﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESO_CRUD
{
    public partial class frmAplicacion : Form
    {
        public frmAplicacion()
        {
            InitializeComponent();
        }

        private void msiInfoCreador_Click(object sender, EventArgs e)
        {
            frmCreador frmCreador = new frmCreador();
            frmCreador.MdiParent = this; 
            frmCreador.Show();
        }

        private void msiGaleria_Click(object sender, EventArgs e)
        {
            frmGaleria frmGaleria = new frmGaleria();
            frmGaleria.MdiParent = this;
            frmGaleria.Show();
        }
    }
}
