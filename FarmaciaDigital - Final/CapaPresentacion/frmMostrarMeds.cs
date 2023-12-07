using FarmaciaDigital;
using FarmaciaDigital.CapaPresentacion;
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

namespace Mostrar_Medicamento
{
    public partial class frmMostrarMeds : Form
    {
        String BuscarMed;
        private ConexionBD conexion = new ConexionBD();
        private SqlCommand cmd;
        string CampoFiltro = ""; 

        public frmMostrarMeds()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            conexion.ObtenerConexion();
        }

        public void ayudaMessages()
        {
            ttMessages.SetToolTip(txtBuscar, "Digite el nombre del medicamento a buscar");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {
                    BuscarMed = txtBuscar.Text;

                    if (cmbFiltro.Text != "Seleccione...")
                    {
                        // consulta SQL para seleccionar los registros de la tabla Medicamentos que coincidan con el nombre buscado
                        string selectQuery = $"SELECT * FROM Medicamentos WHERE {CampoFiltro} LIKE '%{BuscarMed}%'";

                        // objeto SqlCommand con la consulta y la conexión
                        SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());

                        // objeto SqlDataAdapter para llenar un DataTable con los resultados de la consulta
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        conexion.CerrarConexion();

                        if (dt.Rows.Count > 0)
                        {
                            dgvMostrarMeds.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Medicamento no encontrado", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SELECCIONE UN CAMPO POR EL QUE FILTRAR", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    errorProvider1.SetError(txtBuscar, "no puede quedar vacio");
                    MessageBox.Show("Por favor digite el nombre del medicamento", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
            
        }

        private void dgvMostrarMeds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void frmMostrarMeds_Load(object sender, EventArgs e)
        {
            try
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

                // consulta SQL para seleccionar los registros de la tabla Medicamentos que coincidan con el nombre buscado
                string selectQuery = "SELECT * FROM Medicamentos";

                // objeto SqlCommand con la consulta y la conexión
                SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());

                // objeto SqlDataAdapter para llenar un DataTable con los resultados de la consulta
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Cierra la conexión a la base de datos
                conexion.CerrarConexion();

                // Asigna los datos de la tabla al DataGridView
                dgvMostrarMeds.DataSource = dt;

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
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
                        CampoFiltro = "TipoIngreso";
                        break;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrarMeds.SelectedRows.Count > 0)
                {
                    int idMedicamento = Convert.ToInt32(dgvMostrarMeds.CurrentRow.Cells["ID"].Value.ToString()); //OBTENEMOS EL VALOR DEL CAMPO EXPEDIENTE DE LA FILA SELECCIONADA

                    conexion.AbrirConexion();
                    cmd.Connection = conexion.ObtenerConexion();
                    cmd.CommandText = "Delete from Medicamentos where ID = @id"; //INSTRUCCION PARA ELIMINAR EL REGISTRO SELECCIONADO
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", idMedicamento);
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                    cmd.Parameters.Clear();

                    MessageBox.Show("Se eliminó de forma correcta","FARMACIA DIGITAL - ELIMINAR REGISTRO",MessageBoxButtons.OK,MessageBoxIcon.Warning);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMostrarMeds.CurrentRow.Selected == false)
                {
                    MessageBox.Show("SELECCIONE LA FILA QUE DESEA EDITAR", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmEditarMedi editarMedi = new frmEditarMedi();

                    //asignamos los valores del registro a los textbox

                    editarMedi.Id = Convert.ToInt32(dgvMostrarMeds.CurrentRow.Cells["ID"].Value.ToString());
                    editarMedi.Nombre = dgvMostrarMeds.CurrentRow.Cells["Nombre"].Value.ToString();
                    editarMedi.Cantidad = Convert.ToInt32(dgvMostrarMeds.CurrentRow.Cells["Cantidad"].Value.ToString());
                    editarMedi.Precio = Convert.ToDouble(dgvMostrarMeds.CurrentRow.Cells["Precio"].Value.ToString());
                    editarMedi.Ingreso = dgvMostrarMeds.CurrentRow.Cells["TipoIngreso"].Value.ToString();

                    editarMedi.Show();
                    this.Hide();
                    editarMedi.FormClosed += Mostrar;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

   
        public void ActualizadDGV()
        {
            try
            {
                // consulta SQL para seleccionar los registros de la tabla Medicamentos que coincidan con el nombre buscado
                string selectQuery = "SELECT * FROM Medicamentos";

                // objeto SqlCommand con la consulta y la conexión
                SqlCommand cmd = new SqlCommand(selectQuery, conexion.ObtenerConexion());

                // objeto SqlDataAdapter para llenar un DataTable con los resultados de la consulta
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Cierra la conexión a la base de datos
                conexion.CerrarConexion();

                // Asigna los datos de la tabla al DataGridView
                dgvMostrarMeds.DataSource = dt;
            }

             catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }

        }

        public void Mostrar(object sender, EventArgs e)
        {
            ActualizadDGV();
            this.Show();
        }
    }
 }

