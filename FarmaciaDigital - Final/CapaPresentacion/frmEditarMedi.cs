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
    public partial class frmEditarMedi : Form
    {
        ConexionBD conexion = new ConexionBD();
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string Ingreso { get; set; }
        public frmEditarMedi()
        {
            InitializeComponent();
        }

        private void frmEditarMedi_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Nombre;
            txtCantidad.Text = Cantidad.ToString();
            txtPrecio.Text = Precio.ToString();  
            cmbIngreso.Text = Ingreso;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cone = conexion.ObtenerConexion())
                {
                    cone.Open();

                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = cone;
                        cmd.CommandText = "SP_Actualizar_Medicamentos";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                        cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@TipoIngreso", cmbIngreso.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        MessageBox.Show("REGISTRO ACTUALIZADO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Número de error específico para la violación de la restricción UNIQUE KEY
                {
                    // Manejar la excepción de clave duplicada aquí
                    // Puedes mostrar un mensaje de error al usuario o tomar cualquier otra acción necesaria
                    MessageBox.Show("El nombre de medicamento que desea asignar ya esta registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Manejar otros errores de SqlException aquí
                    MessageBox.Show("Error de SQL: " + ex.Message);
                }
            }

            catch (Exception ex)
            {
                // Manejar otras excepciones aquí
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
