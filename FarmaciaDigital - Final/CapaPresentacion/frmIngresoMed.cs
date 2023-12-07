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
using System.Data.SqlClient;
using FarmaciaDigital.Clases;

namespace FarmaciaMedicamentos
{
    public partial class frmIngresoMed : Form
    {

        //DECLARACION DE VARIABLES LOCALES 
        float Precio;
        String NombreMedicamento;
        int Cantidad;
        private ConexionBD conn;
        private SqlCommand cmd;

        public frmIngresoMed()
        {
            InitializeComponent();

            conn = new ConexionBD();
            cmd = new SqlCommand();

        }

        // Metodo para limpiar
        private void Limpiartexto()
        {
            txtNombreMedicamento.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void ActivarControl()
        {
            btnGuardar.Enabled = true;
            txtNombreMedicamento.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecio.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControl();
            Limpiartexto();
            errorProvider1.Clear();

        }
        //METODO PARA HACER COMPRABACIONES
        private void Comprobacion()
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {  
                if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtNombreMedicamento.Text))
                {
                    // asignar el valor del cuadro de texto a la variable NombreMedicamento
                    NombreMedicamento = txtNombreMedicamento.Text;
                    Precio = float.Parse(txtPrecio.Text);
                    Cantidad = int.Parse(txtCantidad.Text);

                    if (Precio > 0 && Cantidad > 0)
                    {
                            conn.AbrirConexion();

                            // consulta SQL de inserción de datos
                            string insertQuery = "INSERT INTO Medicamentos (Nombre, Cantidad, Precio, TipoIngreso) VALUES (@Nombre, @Cantidad, @Precio, @TipoIngreso)";
                            // objeto SqlCommand con la consulta y la conexión
                            SqlCommand cmd = new SqlCommand(insertQuery, conn.ObtenerConexion());

                            // asignar valores a los parámetros
                            cmd.Parameters.AddWithValue("@Nombre", NombreMedicamento);
                            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                            cmd.Parameters.AddWithValue("@Precio", Precio);
                            if (chbxDonacion.Checked)
                            {
                                cmd.Parameters.AddWithValue("@TipoIngreso", "Donación");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@TipoIngreso", "Comprado");
                            }

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Ha sido ingresado " + NombreMedicamento, "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("El precio o cantidad no pueden ser menores o iguales a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Los campos no deben quedar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }      

                conn.CerrarConexion();
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Número de error específico para la violación de la restricción UNIQUE KEY
                {
                    // Manejar la excepción de clave duplicada aquí
                    // Puedes mostrar un mensaje de error al usuario o tomar cualquier otra acción necesaria
                    MessageBox.Show("No se puede ingresar un medicamento duplicado.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Manejar otros errores de SqlException aquí
                    MessageBox.Show("Error de SQL: " + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex.Message + "Error");
            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {

                e.Handled = true;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}