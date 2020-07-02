using System;
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
    public partial class FrmRevisionIndividual : Form
    {
        public FrmRevisionIndividual()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnElegirTribunal_Click(object sender, EventArgs e)
        {
            Form frmElegirTribunal = new FrmLicenciado();
            frmElegirTribunal.Show();
        }

        private void btnCancelarNuevop_Click(object sender, EventArgs e)
        {
            FrmRevisiones2 frm = new FrmRevisiones2();
            frm.Close();
        }
    }
}
