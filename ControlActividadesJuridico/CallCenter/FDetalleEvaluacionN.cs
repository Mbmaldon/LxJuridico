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
    public partial class FDetalleEvaluacionN : Form
    {
        int iIdEva;
     
        EDEvaluacionRegistradaN IEvaluacion;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FDetalleEvaluacionN(int idEvaluacion)
        {
            InitializeComponent();
            iIdEva      = idEvaluacion;
          
            IEvaluacion = null;
            DDetallesEvaluacion infoEvaluacion = new DDetallesEvaluacion();
            IEvaluacion = infoEvaluacion.informacionEvaluacionN(iIdEva);
            informacionEvaluacion(IEvaluacion);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void informacionEvaluacion(EDEvaluacionRegistradaN Evaluacion)
        {
            rbNO.Checked            = true;
            txtObservaciones.Text   = Evaluacion.sObservaciones;
            lblFRegistro.Text       = Evaluacion.sFechaRegistro;
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
