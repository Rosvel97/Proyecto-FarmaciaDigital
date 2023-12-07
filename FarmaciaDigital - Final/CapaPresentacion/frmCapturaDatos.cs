using FarmaciaDigital.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Referencia a MSVB uso de las DLLs
using System.Data.SqlClient;
using FarmaciaDigital.Clases;

namespace FarmaciaDigital
{
    public partial class frmCapturaDatos : Form
    {
        private ConexionBD conn;
        private SqlCommand cmd;
        public frmCapturaDatos()
        {
            InitializeComponent();

            conn = new ConexionBD();
            cmd = new SqlCommand();

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text) || string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Los campos no deben quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    conn.AbrirConexion();

                    string insertQuery = "INSERT INTO Pacientes (Nombres, Apellidos, DUI, Telefono, Correo, Sexo, FechaNacimiento, FechaIngreso, AlergiaMedicamento) VALUES (@Nombres, @Apellidos, @DUI, @Telefono, @Correo, @Sexo, @FechaNacimiento, @FechaIngreso, @AlergiaMedicamento)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn.ObtenerConexion());
                    cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                    cmd.Parameters.AddWithValue("@DUI", txtDui.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Sexo", rbMasculino.Checked ? "Masculino" : "Femenino");
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@FechaIngreso", dtpFechaNacimiento.Value);
                    if (chbxAlergico.Checked == true)
                    {
                        string alergiaMedicamento = Microsoft.VisualBasic.Interaction.InputBox("Tipo de medicamento al cual es alérgico:", "Alergia a medicamento");
                        cmd.Parameters.AddWithValue("@AlergiaMedicamento", alergiaMedicamento);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@AlergiaMedicamento", "Sin alergia");
                    }

                    cmd.ExecuteNonQuery();

                    // muestra un mensaje de confirmación
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombres.Clear();
                    txtApellidos.Clear();
                    txtDui.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    rbMasculino.Checked = false;
                    rbFemenino.Checked = false;
                    dtpFechaNacimiento.Checked = false;
                    dtpFechaIngreso.Checked = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error en el ingreso de datos" + "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.CerrarConexion();
        }

        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gbIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbxAlergico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
