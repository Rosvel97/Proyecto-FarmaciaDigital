using FarmaciaDigital.CapaPresentacion;
using FarmaciaDigital.Clases;
using FarmaciaMedicamentos;
using FrmAyuda;
using Mostrar_Medicamento;
using QuienesSomos;
using RecetaMedica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FarmaciaDigital
{
    public partial class frmMenu : Form 
    {
        public frmMenu()
        {
            InitializeComponent();
            ayudaMessages();
        }

        //METODO PARA MOSTRAR MENSAJES DE AYUDA EN LOS BOTONES DEL MENU PRINCIPAL
        public void ayudaMessages()
        {
            ttMessages.SetToolTip(btnIngresoMedicamentos, "Boton para acceder al formulario Ingreso Medicamentos");
            ttMessages.SetToolTip(btnInventario, "Boton para acceder al formulario Inventario de Medicamentos");
            ttMessages.SetToolTip(btnIngresoDatosPacientes, "Boton para acceder al formulario Ingreso de datos Pacientes");
            ttMessages.SetToolTip(btnMostrarPacientes, "Boton para acceder al formulario de Mostrar Pacientes");
            ttMessages.SetToolTip(btnAyuda, "Boton para acceder al formulario de Ayuda");
            ttMessages.SetToolTip(btnQuienesSomos, "Boton para acceder al formulario Quienes somos");
            ttMessages.SetToolTip(btnSalirSesion, "Boton para salir de la sesion");
            ttMessages.SetToolTip(grbxFechaHora, "Hora y fecha actual");
        }
        private void btnIngresoMedicamentos_Click(object sender, EventArgs e)
        {
            frmIngresoMed ingresoMedicamentos = new frmIngresoMed();
            ingresoMedicamentos.Show();
            ingresoMedicamentos.FormClosed += Salir; 
            this.Hide();
        }

        private void btnIngresoDatosPacientes_Click(object sender, EventArgs e)
        {
            frmCapturaDatos CapturaDatos = new frmCapturaDatos();
            CapturaDatos.Show();
            CapturaDatos.FormClosed += Salir; 
            this.Hide();
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            frmMostrarDatos frmMostrarDatos = new frmMostrarDatos();
            this.Hide();
            frmMostrarDatos.Show();
            frmMostrarDatos.FormClosed += Salir; 
        }

        private void btnQuienesSomos_Click(object sender, EventArgs e)
        {

            frmQuienesSomos frmQuienesSomos = new frmQuienesSomos();
            frmQuienesSomos.Show();
            frmQuienesSomos.FormClosed += Salir; 
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmSugerencias ayuda= new frmSugerencias();
            ayuda.Show();
            ayuda.FormClosed += Salir; 
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmMostrarMeds mostrarMeds = new frmMostrarMeds();
            mostrarMeds.Show();
            mostrarMeds.FormClosed += Salir;
            this.Hide();
        }

        private void MostrarMeds_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Estas seguro de cerrar sesion?","FARMACIA DIGITAL",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                this.Close(); 
            }
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text =DateTime.Now.ToShortTimeString();
            lbFecha.Text =DateTime.Now.ToShortDateString();
        }

        private void Salir(object sender, EventArgs e)
        {
            this.Show(); 
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (LoginEntidades.Rol == "ADMIN")
            {
                btnIngresoMedicamentos.Enabled = true;
                btnIngresoDatosPacientes.Enabled = true;
                btnAyuda.Enabled = true;
                btnInventario.Enabled = true;
                btnMostrarPacientes.Enabled = true;
                btnQuienesSomos.Enabled = true;
            }
            else if (LoginEntidades.Rol == "ADMIN")
            {
                btnIngresoMedicamentos.Enabled = true;
                btnIngresoDatosPacientes.Enabled = true;
                btnAyuda.Enabled = true;
                btnInventario.Enabled = true;
                btnMostrarPacientes.Enabled = true;
                btnQuienesSomos.Enabled = true;
            }
            else
            {
                btnIngresoMedicamentos.Enabled = false;
                btnIngresoDatosPacientes.Enabled = false;
                btnAyuda.Enabled = true;
                btnInventario.Enabled = true;
                btnMostrarPacientes.Enabled = true;
                btnQuienesSomos.Enabled = true;
            }
        }

        private void btnRecetaMedica_Click(object sender, EventArgs e)
        {
            frmReceta receta = new frmReceta();
            receta.FormClosed += Salir;
            this.Hide();
            receta.Show();
        }
    }
}
