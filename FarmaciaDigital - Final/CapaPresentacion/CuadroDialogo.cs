using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace FarmaciaDigital
{
    public partial class CuadroDialogo : Form
    {
       
        public CuadroDialogo()
        {
            InitializeComponent();
        }

        private void CuadroDialogo_Load(object sender, EventArgs e)
        {
            LinAnimacion.Width = 0; // ESTABLECE EL ANCHO DEL PANEL A 0
            for (int i = 0; i < 475; i++)
                Temporizador.Start();        
        }

        public Color ColorFondo // DEFINE EL COLOR DE FONDO QUE TENDRÁ EL FORMULARIO
        {
            get { return this.BackColor; }
            set { this.BackColor = value;  }
        }

        public Color ColorAlerta // DEFINE EL COLOR DE LA LETRA
        {
            get { return LinAnimacion.BackColor; }
            set { LinAnimacion.BackColor = lblTituloAlerta.ForeColor = lblDescripcionAlerta.ForeColor = value; }
        }

        public Image IconoAlerta //ALMACENA EL ICONO QUE CONTENDRÁ EL PICTUREBOX DE ACUERDO AL TIPO DE ALERTA
        {
            get { return picAlerta.Image; }
            set { picAlerta.Image = value; }
        }

        public string TituloAlerta // DEVUELVE EL TITULO DE LA ALERTA
        {
            get { return lblTituloAlerta.Text; }
            set { lblTituloAlerta.Text = value; }
        }

        public string DescripcionAlerta // DEVUELVE UNA DESCRIPCIÓN DE LA ALERTA
        {
            get { return lblDescripcionAlerta.Text; }
            set { lblDescripcionAlerta.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // BOTON PARA CERRAR EL CUADRO DE DIALOGO
        {
            this.Close(); 
        }

        private void Temporizador_Tick_1(object sender, EventArgs e)
        {
            if (LinAnimacion.Width < 475)
                LinAnimacion.Width = LinAnimacion.Width + 7;           
        }

        public void FormatoCuadroDialogo(Color backColor, Color color, string titulo, string descripcion, Image icono)
        {
            ColorFondo = backColor;
            ColorAlerta = color;
            TituloAlerta = titulo;
            DescripcionAlerta = descripcion;
            IconoAlerta = icono;
            ShowDialog();
        }


        //FORMATO COMPLETADO: Color.LightGreen, Color.DarkGreen, "Completado", "El proceso se completó exitosamente", Properties.Resources.Completado
        //FORMATO ERROR: Color.LightPink, Color.Maroon, "Error", "Ha ocurrido un error inesperado", Properties.Resources.Error
        //FORMATO ADVERTENCIA: Color.LightGoldenrodYellow, Color.Goldenrod, "Advertencia",  "La información solicitada no está completa", Properties.Resources.Advertencia

    }
}
