using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FarmaciaDigital.Clases;

namespace FarmaciaDigital.CapaPresentacion
{
    public partial class FrmEditarPaciente : Form
    {
        ConexionBD conexion = new ConexionBD();


        public int Expediente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public string Alergias{ get; set; }
        public string Sexo{ get; set; }

        public FrmEditarPaciente()
        {
            InitializeComponent();
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            //Mostramos los valores en los textbox
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtDUI.Text = DUI;
            txtTelefono.Text = Telefono; 
            txtCorreo.Text = Correo;
            dtpFechaNacimiento.Value = FechaNacimiento;

            if (Sexo == "M")
                rbtnM.Checked = true; 
            else 
                rbtnF.Checked = true;


            if (Alergias == "NO")
            {
                rbtnNo.Checked = true; 
            }
            else
            {
                txtAlergia.Text = Alergias; 
                rbtnSI.Checked = true; 
                lblAlergia.Visible = true;
                txtAlergia.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void rbtnSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSI.Checked)
            {
                lblAlergia.Visible = true;
                txtAlergia.Visible = true;
                Alergias = txtAlergia.Text;
            }
            else
            {
                txtAlergia.Text = "NO"; 
                lblAlergia.Visible = false;
                txtAlergia.Visible = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtAlergia.Text != "" && txtAlergia.Text != "NO")
                Alergias = txtAlergia.Text;
            else
                Alergias = "NO";

            

           
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SP_Actualizar_Pacientes";
                    cmd.CommandType = CommandType.StoredProcedure; //INDICA QUE LA CONSULTA ES DE UN PROCEDIMIENTO ALMACENADO
                    cmd.Parameters.AddWithValue("@Expediente", Expediente);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@DUI", txtDUI.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@FechaNaciemto", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Alergia",Alergias);

                    SqlDataReader dt = cmd.ExecuteReader();

                    MessageBox.Show("REGISTRO ACTUALIZADO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
            }
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnM.Checked)
            {
                Sexo = "M"; 
            }
            else
            {
                Sexo = "F";
            }
        }
    }
}
