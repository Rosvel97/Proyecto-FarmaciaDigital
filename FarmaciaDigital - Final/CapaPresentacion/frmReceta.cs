using FarmaciaDigital.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecetaMedica
{
    public partial class frmReceta : Form
    {
        private ConexionBD conn;
        private SqlCommand cmd;
        int Cantidad_1, Cantidad_2, Cantidad_3;
        string Medicamento_1, Medicamento_2, Medicamento_3;
        public frmReceta()
        {
            InitializeComponent();
            conn = new ConexionBD();
            cmd = new SqlCommand();
            AyudaMessages();
        }

        private void MostrarReceta_Load(object sender, EventArgs e)
        {
            txtMedico.Clear();
            txtExpediente.Clear();
            cmbPaciente.SelectedValue = false;
            dtpFecha.Checked = false;
            txtIndicaciones.Clear();
            cmbMedicamento1.Enabled = false;
            cmbMedicamento2.Enabled = false;
            cmbMedicamento3.Enabled = false;
            nupCantidad1.Enabled = false;
            nupCantidad2.Enabled = false;
            nupCantidad3.Enabled = false;
            cmbMedicamento1.SelectedIndex = -1;
            cmbMedicamento2.SelectedIndex = -1;
            cmbMedicamento3.SelectedIndex = -1;
        }

        private void ActualizarStockMaximo(NumericUpDown numericUpDown, ComboBox comboBox)
        {
            if (comboBox.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboBox.SelectedItem;
                int stockDisponible = Convert.ToInt32(selectedRow["Cantidad"]);
                numericUpDown.Maximum = stockDisponible;
            }
        }

        private void cmbMedicamento1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarStockMaximo(nupCantidad1, cmbMedicamento1);
        }

        private void cmbMedicamento2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarStockMaximo(nupCantidad2, cmbMedicamento2);
        }

        private void cmbMedicamento3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarStockMaximo(nupCantidad3, cmbMedicamento3);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //TIPOS DE TEXTOS

            Font tipotexto = new Font("Arial", 12, FontStyle.Regular); // <== tipo de letra
            Font tipoNegrita = new Font("Century Gothic", 18, FontStyle.Bold); // <== tipo de letra
            Font tituloTexto = new Font("Century Gothic", 25, FontStyle.Bold);

            //Impresion del titulo

            e.Graphics.DrawString("FARMACIA DIGITAL", tituloTexto, Brushes.Black, 250, 200);

            //Impresion del logo minsal
            string rutalogo = Path.Combine(Application.StartupPath, "Resources", "logominsal.png");
            Image Logo = Image.FromFile(rutalogo);

            e.Graphics.DrawImage(Logo, 50, 50, 350, 150);

            //Impresion del pie de pagina

            string rutalogo02 = Path.Combine(Application.StartupPath, "Resources", "PiePagina.png");
            Image Logo2 = Image.FromFile(rutalogo02);

            e.Graphics.DrawImage(Logo2, 0, 950, 800, 150);

            //Impresion de los textbox
            e.Graphics.DrawString("Fecha de entrega: ", tipoNegrita, Brushes.Black, 50, 270);
            e.Graphics.DrawString(dtpFecha.Text, tipotexto, Brushes.Black, 280, 275);

            e.Graphics.DrawString("Doctor: ", tipoNegrita, Brushes.Black, 50, 300);
            e.Graphics.DrawString(txtMedico.Text, tipotexto, Brushes.Black, 150, 305);

            e.Graphics.DrawString("Paciente: ", tipoNegrita, Brushes.Black, 50, 330);
            e.Graphics.DrawString(cmbPaciente.Text, tipotexto, Brushes.Black, 175, 335);

            e.Graphics.DrawString("Expediente: ", tipoNegrita, Brushes.Black, 50, 355);
            e.Graphics.DrawString(txtExpediente.Text, tipotexto, Brushes.Black, 200, 360);

            e.Graphics.DrawString("Medicamento: ", tipoNegrita, Brushes.Black, 50, 380);
            e.Graphics.DrawString(nupCantidad1.Text, tipotexto, Brushes.Black, 50, 410);
            e.Graphics.DrawString(cmbMedicamento1.Text, tipotexto, Brushes.Black, 90, 410);

            e.Graphics.DrawString(nupCantidad2.Text, tipotexto, Brushes.Black, 50, 435);
            e.Graphics.DrawString(cmbMedicamento2.Text, tipotexto, Brushes.Black, 90, 435);

            e.Graphics.DrawString(nupCantidad3.Text, tipotexto, Brushes.Black, 50, 460);
            e.Graphics.DrawString(cmbMedicamento3.Text, tipotexto, Brushes.Black, 90, 460);

            e.Graphics.DrawString("INDICACIONES: ", tipoNegrita, Brushes.Black, 50, 500);

            //Impresion de las indicaciones
            

            // Obtén el contenido del TextBox
            string contenido = txtIndicaciones.Text;


            // Especifica la posición deseada para el inicio del texto
            float x = 50;
            float y = 530;

            // Crea un objeto StringFormat para alinear el texto
            StringFormat formato = new StringFormat();

            // Crea un rectángulo para delimitar el área de impresión
            RectangleF areaImpresion = new RectangleF(x, y, e.MarginBounds.Width - x, e.MarginBounds.Height - y);

            // Imprime el contenido del TextBox
            e.Graphics.DrawString(contenido, tipotexto, Brushes.Black, areaImpresion, formato);


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Libera los recursos del objeto PrintPreviewDialog existente
                if (printPreviewDialog1 != null)
                {
                    printPreviewDialog1.Dispose();
                    printPreviewDialog1 = null;
                }

                // Crea una nueva instancia de PrintPreviewDialog
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument1; // Asigna el PrintDocument correcto

                // Muestra el PrintPreviewDialog
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL IMPRIMIR LA FACTURA POR FALTA DE DATOS", "FARMACIA DIGITAL"+ ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
      
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIndicaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            int MaxCaracteres = 300; // MAXIMO DE CARACTERES

            if(txtIndicaciones.Text.Length >= MaxCaracteres && e.KeyChar != '\b') // Verifica si alcanzo el limite de caracteres y no es la tecla de retroceso

                    e.Handled = true;


        }
        private void AyudaMessages()
        {
            ttMessages.SetToolTip(btnGuardar, "Boton para guardar la receta");
            ttMessages.SetToolTip(btnImprimir, "Boton para imprimir la receta");
            ttMessages.SetToolTip(btnNuevo, "Boton para crear una nueva receta");
        }
        public void LimpiarCampos()
        {
            txtMedico.Clear();
            txtExpediente.Clear();
            cmbPaciente.Enabled = false;
            dtpFecha.Checked = false;
            txtIndicaciones.Clear();
            cmbMedicamento1.Enabled = false;
            cmbMedicamento2.Enabled = false;
            cmbMedicamento3.Enabled = false;
            nupCantidad1.Enabled = false;
            nupCantidad2.Enabled = false;
            nupCantidad3.Enabled = false;
            nupCantidad1.Value = 0;
            nupCantidad2.Value = 0;
            nupCantidad3.Value = 0;
            cmbMedicamento1.SelectedIndex = -1;
            cmbMedicamento2.SelectedIndex = -1;
            cmbMedicamento3.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtMedico.Enabled = true;
            txtExpediente.Enabled = true;
            cmbMedicamento1.Enabled = true;
            nupCantidad1.Enabled = true;
            cmbMedicamento2.Enabled = true;
            nupCantidad2.Enabled = true;
            cmbMedicamento3.Enabled = true;
            nupCantidad3.Enabled = true;
            txtIndicaciones.Enabled = true;
            dtpFecha.Enabled = true;
            cmbPaciente.Enabled = true;

            conn.AbrirConexion();

            // Obtener datos de Pacientes
            string queryPacientes = "SELECT * FROM Pacientes";
            SqlDataAdapter daPacientes = new SqlDataAdapter(queryPacientes, conn.ObtenerConexion());
            DataTable dtPacientes = new DataTable();
            daPacientes.Fill(dtPacientes);

            // Enlazar los datos al ComboBox de Pacientes
            cmbPaciente.DataSource = dtPacientes;
            dtPacientes.Columns.Add("InfoPaciente", typeof(string), "Expediente + ' - ' + Nombres + ' ' + Apellidos");
            cmbPaciente.DisplayMember = "InfoPaciente";
            cmbPaciente.SelectedIndex = -1;

            // Obtener datos de Medicamentos
            string queryMedicamentos = "SELECT Nombre, Cantidad FROM Medicamentos";
            SqlDataAdapter daMedicamentos = new SqlDataAdapter(queryMedicamentos, conn.ObtenerConexion());
            DataTable dtMedicamentos1 = new DataTable();
            DataTable dtMedicamentos2 = new DataTable();
            DataTable dtMedicamentos3 = new DataTable();
            daMedicamentos.Fill(dtMedicamentos1);
            daMedicamentos.Fill(dtMedicamentos2);
            daMedicamentos.Fill(dtMedicamentos3);

            // Enlazar los datos a los ComboBox correspondientes
            cmbMedicamento1.DataSource = dtMedicamentos1;
            cmbMedicamento1.DisplayMember = "Nombre";
            cmbMedicamento1.SelectedIndex = -1;

            cmbMedicamento2.DataSource = dtMedicamentos2;
            cmbMedicamento2.DisplayMember = "Nombre";
            cmbMedicamento2.SelectedIndex = -1;

            cmbMedicamento3.DataSource = dtMedicamentos3;
            cmbMedicamento3.DisplayMember = "Nombre";
            cmbMedicamento3.SelectedIndex = -1;

            conn.CerrarConexion();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMedico.Text) || string.IsNullOrEmpty(txtExpediente.Text) || string.IsNullOrEmpty(txtIndicaciones.Text) ||
            cmbPaciente.SelectedIndex == -1 || cmbMedicamento1.SelectedIndex == -1 || cmbMedicamento2.SelectedIndex == -1 || cmbMedicamento3.SelectedIndex == -1 ||
            string.IsNullOrEmpty(nupCantidad1.Text) || string.IsNullOrEmpty(nupCantidad2.Text) || string.IsNullOrEmpty(nupCantidad3.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar la receta médica.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            conn.AbrirConexion();

            // Actualizar la cantidad de medicamentos
            string UpdateQuery = "UPDATE Medicamentos SET Cantidad = Cantidad - @Cantidad WHERE Nombre = @Nombre";
            SqlCommand upt = new SqlCommand(UpdateQuery, conn.ObtenerConexion());

            Cantidad_1 = int.Parse(nupCantidad1.Text);
            Medicamento_1 = cmbMedicamento1.Text;

            Cantidad_2 = int.Parse(nupCantidad2.Text);
            Medicamento_2 = cmbMedicamento2.Text;

            Cantidad_3 = int.Parse(nupCantidad3.Text);
            Medicamento_3 = cmbMedicamento3.Text;

            upt.Parameters.AddWithValue("@Cantidad", Cantidad_1);
            upt.Parameters.AddWithValue("@Nombre", Medicamento_1);
            upt.ExecuteNonQuery();

            upt.Parameters["@Cantidad"].Value = Cantidad_2;
            upt.Parameters["@Nombre"].Value = Medicamento_2;
            upt.ExecuteNonQuery();

            upt.Parameters["@Cantidad"].Value = Cantidad_3;
            upt.Parameters["@Nombre"].Value = Medicamento_3;
            upt.ExecuteNonQuery();

            ActualizarStockMaximo(nupCantidad1, cmbMedicamento1);
            ActualizarStockMaximo(nupCantidad2, cmbMedicamento2);
            ActualizarStockMaximo(nupCantidad3, cmbMedicamento3);

            LimpiarCampos();

            conn.CerrarConexion();


            MessageBox.Show("Receta medica ingresada", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
