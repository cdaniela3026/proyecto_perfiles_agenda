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
    public partial class FrmRevisiones : Form
    {
        public FrmRevisiones()
        {
            InitializeComponent();
        }
        int posY = 0;
        int posX = 0;


        private void btnCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel2Rev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void General_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnCancelarRevicion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
