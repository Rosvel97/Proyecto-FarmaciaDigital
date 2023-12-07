using FarmaciaDigital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienesSomos
{
    public partial class frmQuienesSomos : Form
    {
        public frmQuienesSomos()
        {
            InitializeComponent();
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para mas informacion puedes ir a la ventana sugerencias y enviarnos un correo a farmaciadigitalsv@gmail.com","FARMACIA DIGITAL",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
