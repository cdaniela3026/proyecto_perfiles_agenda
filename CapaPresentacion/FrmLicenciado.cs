﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLicenciado : Form
    {
        CapaNegocio.NegocioPerfiles obj = new CapaNegocio.NegocioPerfiles();
        public FrmLicenciado()
        {
            InitializeComponent();
            mostraLicenciados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregarLicenciado_Click(object sender, EventArgs e)
        {
            FrmNuevoLicenciado obj = new FrmNuevoLicenciado();
            obj.Show();
            this.Close();


        }

        private void pnlbarralicenciado_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarForm.ReleaseCapture();
            ArrastrarForm.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dtgLicenciados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
        public void mostraLicenciados()
        {
            dtgLicenciados.DataSource = obj.Licenciados();
        }
    }
}
