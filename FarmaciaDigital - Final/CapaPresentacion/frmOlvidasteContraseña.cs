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
using System.Text.RegularExpressions;


namespace FarmaciaDigital
{
    public partial class frmCambioContrase : Form
    {
        public frmCambioContrase()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmLogin inicio = new frmLogin();
            inicio.Show();
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtCorreo.Text) &&!string.IsNullOrEmpty(txtTel.Text))
                {
                    MailMessage correo = new MailMessage();
                    string email = txtCorreo.Text;
                    Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                    correo.From = new MailAddress("farmaciadigitalsv@gmail.com");
                    correo.To.Add("farmaciadigitalsv@gmail.com");
                    correo.Subject = "Cambio de contraseña";
                    correo.Body ="Solicitud de cambio de contraseña" + "\n\nNombre de usuario: " + txtUsuario.Text + " "+ "\nCorreo: "+ email + " "+"\nNumero:   "+ txtTel.Text;
                    

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    
                    smtp.Credentials = new System.Net.NetworkCredential("farmaciadigitalsv@gmail.com", "rikbsjqcfdtzofuz");
                    smtp.EnableSsl = true;
                    smtp.Send(correo);

                    MessageBox.Show("La solicitud de cambio de contraseña se envió correctamente.", "Envío exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Por favor ingresar usuario, correo y numero de telefono", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar la solicitud de cambio de contraseña. Error: " + ex.Message, "Error al enviar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
