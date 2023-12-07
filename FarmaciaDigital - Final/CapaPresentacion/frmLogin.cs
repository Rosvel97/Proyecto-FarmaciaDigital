using FarmaciaDigital.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaDigital
{
    public partial class frmLogin : Form
    {
        CuadroDialogo nuevaAlerta = new CuadroDialogo();
        private ConexionBD conn = new ConexionBD();
        private SqlCommand cmd;

        public frmLogin()
        {
            InitializeComponent();
            ttMessages.SetToolTip(btnEntrar, "Boton para ingresar al programa");
            cmd = new SqlCommand();
            cmd.Connection = conn.ObtenerConexion();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // EVALUAMOS QUE LOS CUADROS DE TEXTO NO SE ENCUENTREN VACIOS

            try
            {
                if (txtUser.Text != "" && txtPassword.Text != "")
                {                   
                       
                    Login usuario = new Login();
                    var usuarioLogin = usuario.Log_in(txtUser.Text, txtPassword.Text);

                    if (usuarioLogin == true)
                    {
                        //SI LOS DATOS SON CORRECTOS SE ABRE EL FORMULARIO MENU
                        frmMenu formMenu = new frmMenu();
                        formMenu.Show();
                        formMenu.FormClosed += salir; // SE EJECUTA CUANDO SE CIERRA EL FORMULARIO MENU
                        //OCULTA EL FORMULARIO ACTUAL
                        this.Hide();
                    }
                    else
                    {
                        //SI LOS DATOS SON ERRONEOS SE MUESTRA LA SIGUIENTE ALERTA Y LOS DATOS INGRESADOS SON BORRADOS

                        nuevaAlerta.FormatoCuadroDialogo(Color.LightPink, Color.Maroon,
                                                        "Error", "El usuario o la contraseña es incorrecto",
                                                        Properties.Resources.Error);

                        txtUser.Text = "";
                        txtPassword.Text = "";
                    }
                        conn.CerrarConexion();       
                   
                }
                else
                {
                    nuevaAlerta.FormatoCuadroDialogo(Color.LightGoldenrodYellow, Color.Goldenrod,
                                                     "Advertencia", "Falta ingresar usuario o contraseña",
                                                     Properties.Resources.Advertencia);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar" + "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void salir(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus(); 
            this.Show();
        }

        private void linklbOlvidaste_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambioContrase password = new frmCambioContrase();
            this.Hide();
            password.Show();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
