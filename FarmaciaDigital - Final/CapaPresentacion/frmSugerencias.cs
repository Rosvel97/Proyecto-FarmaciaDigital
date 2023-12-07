using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using FarmaciaDigital;

namespace FrmAyuda
{
    public partial class frmSugerencias : Form
    {
        public frmSugerencias()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNumero.Text))
                {
                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress("farmaciadigitalsv@gmail.com");
                    correo.To.Add("farmaciadigitalsv@gmail.com");
                    correo.Subject = "Sugerencia";
                    correo.Body = txtSugerencia.Text + " " + "\n\nNombre del cliente: " + txtNombre.Text + " " + "\nNumero:   " + txtNumero.Text;


                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                    clienteSmtp.EnableSsl = true;
                    clienteSmtp.Credentials = new System.Net.NetworkCredential("farmaciadigitalsv@gmail.com", "rikbsjqcfdtzofuz");

                    clienteSmtp.Send(correo);

                    MessageBox.Show("La sugerencia se envió correctamente.", "Envío exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Por favor ingresar tu nombre y tu numero telefonico.", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar la sugerencia. Error: " + ex.Message, "Error al enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) //Solo agg && !char.IsWhiteSpace(e.KeyChar)
            { 
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {

                e.Handled = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
