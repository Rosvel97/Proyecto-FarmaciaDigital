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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmaciaDigital.CapaPresentacion
{
    public partial class frmMostrarDatos : Form
    {
        string buscar;
        private ConexionBD conexion = new ConexionBD();
        private SqlCommand cmd;
        string CampoFiltro = "";

        public frmMostrarDatos()
        {
            InitializeComponent();
            cmd = new SqlCommand();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    string selectQuery;

                    if (cmbFiltro.Text != "Seleccione...")
                    {

                        // declaramos la variable del textbox para buscar
                        buscar = txtBuscar.Text;

                        // consulta SQL para seleccionar los registros de la tabla Medicamentos que coincidan con el campo buscado
                        selectQuery = $"SELECT * FROM Pacientes WHERE {CampoFiltro} LIKE '{buscar}%'";

                        // objeto SqlCommand con la consulta y la conexión
                        SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());

                        // objeto SqlDataAdapter para llenar un DataTable con los resultados de la consulta
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // validamos si la tabla devolvera un registro
                        if (dt.Rows.Count > 0)
                        {
                            dgvPacientes.DataSource = dt;
                        }

                        else
                        {
                            MessageBox.Show("No se encontraron coincidencias", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el campo a filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("El cuadro no puede quedar vacio", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
             catch (Exception ex)
            {
                MessageBox.Show("Error" + "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmMostrarDatos_Load(object sender, EventArgs e)
        {
            if (LoginEntidades.Rol == "ADMIN")
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else if (LoginEntidades.Rol == "ADMINISTRATIVO")
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }

            // Crea una consulta SQL para seleccionar todos los registros de la tabla
            string selectQuery = "SELECT * FROM Pacientes";

            // Crea un objeto SqlCommand y ejecuta la consulta SQL
            SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Cierra la conexión a la base de datos
            conexion.CerrarConexion();

            // Asigna los datos de la tabla al DataGridView
            dgvPacientes.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbFiltro.SelectedIndex)
                {
                    case 0:
                        CampoFiltro = cmbFiltro.Text;
                        break;

                    case 1:
                        CampoFiltro = cmbFiltro.Text;
                        break;

                    case 2:
                        CampoFiltro = cmbFiltro.Text;
                        break;

                    case 3:
                        CampoFiltro = cmbFiltro.Text;
                        break;
                } 
           
            }
             catch (Exception ex)
            {
                MessageBox.Show("Error" + "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPacientes.SelectedRows.Count > 0)
                {
                    int idExpediente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Expediente"].Value.ToString()); //OBTENEMOS EL VALOR DEL CAMPO EXPEDIENTE DE LA FILA SELECCIONADA

                    conexion.AbrirConexion(); 
                    cmd.Connection = conexion.ObtenerConexion();
                    cmd.CommandText = "Delete from Pacientes where Expediente = @id"; //INSTRUCCION PARA ELIMINAR EL REGISTRO SELECCIONADO
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", idExpediente);
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Se eliminó de forma correcta");

                    ActualizadDGV();

                }
                else
                {
                    MessageBox.Show("Seleccione una fila a borrar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo borrar el registro" + ex);
            }
        }

        public void ActualizadDGV()
        {
            // Crea una consulta SQL para seleccionar todos los registros de la tabla
            string selectQuery = "SELECT * FROM Pacientes";

            // Crea un objeto SqlCommand y ejecuta la consulta SQL
            SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Cierra la conexión a la base de datos
            conexion.CerrarConexion();

            // Asigna los datos de la tabla al DataGridView
            dgvPacientes.DataSource = dt;
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarPaciente edicion = new FrmEditarPaciente();

            if (dgvPacientes.CurrentRow.Selected == false) //VALIDAMOS QUE SE HAYA SELECCIONADO UNA FILA
            {
                MessageBox.Show("SELECCIONE LA FILA QUE DESEA EDITAR", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                //Asignamos los valores de las celdas a las propiedades del formulario de edición

                edicion.Expediente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["Expediente"].Value.ToString()); 
                edicion.Nombre = dgvPacientes.CurrentRow.Cells["Nombres"].Value.ToString();
                edicion.Apellido = dgvPacientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                edicion.DUI = dgvPacientes.CurrentRow.Cells["DUI"].Value.ToString();
                edicion.Telefono = dgvPacientes.CurrentRow.Cells["Telefono"].Value.ToString();
                edicion.Correo = dgvPacientes.CurrentRow.Cells["Correo"].Value.ToString();
                edicion.FechaNacimiento = Convert.ToDateTime(dgvPacientes.CurrentRow.Cells["FechaNacimiento"].Value.ToString());
                edicion.Alergias = dgvPacientes.CurrentRow.Cells["AlergiaMedicamento"].Value.ToString();
                edicion.Sexo = dgvPacientes.CurrentRow.Cells["Sexo"].Value.ToString();

                edicion.Show();
                this.Hide(); 
            }

            edicion.FormClosed += Mostrar;
       
        }

        public void Mostrar(object sender, EventArgs e)
        {
            ActualizadDGV();
            this.Show(); 
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
