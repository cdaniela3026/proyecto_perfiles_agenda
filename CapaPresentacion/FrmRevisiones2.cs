using CapaPresentacion.Revisiones;
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
    public partial class FrmRevisiones2 : Form
    {
        public FrmRevisiones2()
        {
            InitializeComponent();
           
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelRev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRevisiones2_Load(object sender, EventArgs e)
        {
            btnGeneralRev_Click(null, e);
            btnSegundaRev.Visible = false;
            panelrev2.Visible = false;
            btnTerceraRev.Visible = false;
            panelRev3.Visible = false;
            btnCuartaRev.Visible = false;
            panelRev4.Visible = false;
            btnAddNewRev3.Visible = false;
            btnAddNewRev4.Visible = false;
        }

        private void btnGeneralRev_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new General());
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedorRev.Controls.Count > 0)
                this.panelContenedorRev.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorRev.Controls.Add(fh);
            this.panelContenedorRev.Tag = fh;
            fh.Show();

        }

        private void btnPrimeraRev_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Revision1());
            
        }

        private void btnSegundaRev_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Revision2());
        }

        private void btnGuardarRev_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddNewRev_Click(object sender, EventArgs e)
        {
            if(btnSegundaRev.Visible == false && panelrev2.Visible == false)
            {
                btnSegundaRev.Visible = true;
                panelrev2.Visible = true;
                btnAddNewRev.Visible = false;
                btnAddNewRev3.Visible = true;
            }
        

        }

        private void btnAddNewRev3_Click(object sender, EventArgs e)
        {
            if (btnTerceraRev.Visible == false && panelRev3.Visible == false)
            {
                btnTerceraRev.Visible = true;
                panelRev3.Visible = true;
                btnAddNewRev3.Visible = false;
                btnAddNewRev4.Visible = true;
            }
        }

        private void btnAddNewRev4_Click(object sender, EventArgs e)
        {
            if (btnCuartaRev.Visible == false && panelRev4.Visible == false)
            {
                btnCuartaRev.Visible = true;
                panelRev4.Visible = true;
                btnAddNewRev4.Visible = false;
               
            }
        }
    }
    }
