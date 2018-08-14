using ClaseData.Clases.CallCenter;
using ClaseData.Clases.CallCenter.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.CallCenter
{
    public partial class FDetalleEvaluacionS : Form
    {
        int iIdEva;
     
        EDEvaluacionRegistradaS IEvaluacion;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FDetalleEvaluacionS( int idEvaluacion)
        {
            InitializeComponent();
            iIdEva = idEvaluacion;
         
            IEvaluacion = null;
            DDetallesEvaluacion infoEvaluacion = new DDetallesEvaluacion();
            IEvaluacion = infoEvaluacion.informacionEvaluacionS(iIdEva);
            informacionEvaluacion(IEvaluacion);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void informacionEvaluacion(EDEvaluacionRegistradaS Evalucion)
        {
            rbSI.Checked        = true;
            txtP1.Text          = Evalucion.sP1;
            txtP2.Text          = Evalucion.sP2;
            txtP3.Text          = Evalucion.sP3;
            txtP4.Text          = Evalucion.sP4;
            txtP5.Text          = Evalucion.sP5;
            txtP6.Text          = Evalucion.sP6;
            txtComentario.Text  = Evalucion.sComentarios;
            lblFRegistro.Text   = Evalucion.sFechaRegistro;
        }

        /*Evento click de boton cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento KeyPress evita la escritura de texto en el control */
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
